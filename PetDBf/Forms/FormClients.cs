using Microsoft.EntityFrameworkCore;
using PetDB;
using PetDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetDBf.Forms
{
    public partial class FormClients : Form
    {
        public FormClients()
        {
            InitializeComponent();
        }

        private void FormClients_Load(object sender, EventArgs e)
        {
            PopulateComboboxes();
            PopulateDataGridView();
            dataGridViewClients.CellFormatting += DataGridViewClients_CellFormatting;
        }

        private void PopulateComboboxes()
        {
            comboBoxGender.DataSource = null;
            comboBoxGender.Items.Clear();

            using (PetDBContext db = new())
            {
                var genders = db.Genders.ToList();
                comboBoxGender.DataSource = genders;
                comboBoxGender.DisplayMember = "GenderName";
                comboBoxGender.ValueMember = "Id";
                comboBoxGender.SelectedIndex = 0;
            }
        }

        private void PopulateDataGridView(PetDBContext db)
        {
            var clients = db.Clients.Include(p => p.Gender).ToList();
            dataGridViewClients.DataSource = clients;
            dataGridViewClients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewClients.Columns["Id"].Visible = false;
            dataGridViewClients.Columns["GenderId"].Visible = false;
        }
        private void PopulateDataGridView()
        {
            using (PetDBContext db = new())
            {
                PopulateDataGridView(db);
            }
        }
        private void DataGridViewClients_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewClients.Columns[e.ColumnIndex].Name == "Gender" && e.Value != null)
            {
                var client = (Client)dataGridViewClients.Rows[e.RowIndex].DataBoundItem;
                e.Value = client.Gender?.GenderName;
            }
        }

        private int? selectedClientId = null;

        private void DataGridViewClients_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewClients.CurrentRow == null)
            {
                textBoxName.Clear();
                textBoxPhone.Clear();
                textBoxAdress.Clear();
                textBoxEmail.Clear();
                comboBoxGender.SelectedIndex = -1;

                selectedClientId = null;
                return;
            }

            var selectedClient = (Client)dataGridViewClients.CurrentRow.DataBoundItem;

            selectedClientId = selectedClient.Id;

            textBoxName.Text = selectedClient.Name;
            comboBoxGender.SelectedValue = selectedClient.GenderId;
            textBoxPhone.Text = selectedClient.PhoneNumber ?? string.Empty;
            textBoxAdress.Text = selectedClient.Address ?? string.Empty;
            textBoxEmail.Text = selectedClient.Email ?? string.Empty;

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!selectedClientId.HasValue) return;

            using (PetDBContext db = new())
            {
                var client = db.Clients.FirstOrDefault(p => p.Id == selectedClientId.Value);
                if (client != null)
                {
                    client.Name = textBoxName.Text;
                    client.GenderId = (int)comboBoxGender.SelectedValue;
                    client.PhoneNumber = textBoxPhone.Text;
                    client.Address = textBoxAdress.Text;
                    client.Email = textBoxEmail.Text;


                    db.SaveChanges();
                }

                PopulateDataGridView(db);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!selectedClientId.HasValue)
            {
                MessageBox.Show("Please select a client to delete.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this client?", "Confirm Deletion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;

            using (PetDBContext db = new())
            {
                var client = db.Clients.Include(p => p.Gender).FirstOrDefault(p => p.Id == selectedClientId.Value);
                if (client != null)
                {
                    var adoptedPets = db.AdoptedPets.Where(ap => ap.ClientId == client.Id).ToList();
                    db.AdoptedPets.RemoveRange(adoptedPets);

                    db.Clients.Remove(client);
                    db.SaveChanges();
                }

                selectedClientId = null;
                PopulateDataGridView(db);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                    comboBoxGender.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields with valid data.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Client newClient = new Client
            {
                Name = textBoxName.Text,
                GenderId = (int)comboBoxGender.SelectedValue,
                Address = textBoxAdress.Text,
                PhoneNumber = textBoxPhone.Text,
                Email = textBoxEmail.Text
            };

            using (PetDBContext db = new())
            {
                db.Clients.Add(newClient);
                db.SaveChanges();

                selectedClientId = newClient.Id;
            }

            PopulateDataGridView();

            textBoxName.Clear();
            textBoxPhone.Clear();
            textBoxAdress.Clear();
            textBoxEmail.Clear();
            comboBoxGender.SelectedIndex = -1;

            if (selectedClientId.HasValue)
            {
                foreach (DataGridViewRow row in dataGridViewClients.Rows)
                {
                    if (row.Cells["Id"].Value != null && (int)row.Cells["Id"].Value == selectedClientId.Value)
                    {
                        dataGridViewClients.CurrentCell = row.Cells[1]; // Select the cell in the second column
                        break; // Exit the loop once the matching row is found
                    }
                }
            }
        }

        private void buttonAdopt_Click(object sender, EventArgs e)
        {
            if (!selectedClientId.HasValue) return;

            using (PetDBContext db = new())
            {
                var client = db.Clients.Include(c => c.Gender).FirstOrDefault(c => c.Id == selectedClientId.Value);
                if (client == null)
                {
                    MessageBox.Show("Client not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                FormAdopt adoptForm = new FormAdopt(client);
                adoptForm.ShowDialog();
            }
        }
    }
}
