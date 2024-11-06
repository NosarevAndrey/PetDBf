using Microsoft.EntityFrameworkCore;
using PetDB;
using PetDB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetDBf.Forms
{
    public partial class FormPets : Form
    {

        public FormPets()
        {
            InitializeComponent();
        }

        private void Pets_Load(object sender, EventArgs e)
        {
            PopulateComboboxes();
            PopulateDataGridView();
            dataGridViewPets.CellFormatting += DataGridViewPets_CellFormatting;
        }

        private void PopulateComboboxes()
        {
            comboBoxFilterAdoption.Items.Clear();
            comboBoxFilterType.Items.Clear();
            comboBoxType.DataSource = null;
            comboBoxGender.DataSource = null;
            comboBoxType.Items.Clear();
            comboBoxGender.Items.Clear();

            using (PetDBContext db = new())
            {
                comboBoxFilterAdoption.Items.Add("All");
                comboBoxFilterAdoption.Items.Add("Adopted");
                comboBoxFilterAdoption.Items.Add("Not Adopted");

                comboBoxFilterType.Items.Add("All");
                var petTypes = db.PetTypes.ToList();
                foreach (var petType in petTypes)
                    comboBoxFilterType.Items.Add(petType.TypeName);
                

                comboBoxType.DataSource = petTypes;
                comboBoxType.DisplayMember = "TypeName";
                comboBoxType.ValueMember = "Id";
                

                var genders = db.Genders.ToList();
                comboBoxGender.DataSource = genders;
                comboBoxGender.DisplayMember = "GenderName";
                comboBoxGender.ValueMember = "Id";


                comboBoxFilterAdoption.SelectedIndex = 0;
                comboBoxFilterType.SelectedIndex = 0;
                if (petTypes.Count > 0) comboBoxType.SelectedIndex = 0;
                comboBoxGender.SelectedIndex = 0;
            }
        }

        private void PopulateDataGridView(PetDBContext db)
        {
            string selectedAdoptionFilter = comboBoxFilterAdoption.SelectedItem?.ToString() ?? "All";
            string selectedTypeFilter = comboBoxFilterType.SelectedItem?.ToString() ?? "All";

            var pets = db.Pets
                .Include(p => p.PetType)
                .Include(p => p.Gender)
                .Where(p =>
                    (selectedAdoptionFilter == "All" ||
                        (selectedAdoptionFilter == "Adopted" && db.AdoptedPets.Any(a => a.PetId == p.Id)) ||
                        (selectedAdoptionFilter == "Not Adopted" && !db.AdoptedPets.Any(a => a.PetId == p.Id))
                    ) &&
                    (selectedTypeFilter == "All" || p.PetType.TypeName == selectedTypeFilter)
                )
                .ToList();


            dataGridViewPets.DataSource = pets;
            dataGridViewPets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewPets.Columns["Id"].Visible = false;
            dataGridViewPets.Columns["TypeId"].Visible = false;
            dataGridViewPets.Columns["GenderId"].Visible = false;
        }
        private void PopulateDataGridView()
        {
            using (PetDBContext db = new())
            {
                PopulateDataGridView(db);
            }
        }

        private void DataGridViewPets_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridViewPets.Columns[e.ColumnIndex].Name == "PetType" && e.Value != null)
            {
                var pet = (Pet)dataGridViewPets.Rows[e.RowIndex].DataBoundItem;
                e.Value = pet.PetType?.TypeName;
            }
            if (dataGridViewPets.Columns[e.ColumnIndex].Name == "Gender" && e.Value != null)
            {
                var pet = (Pet)dataGridViewPets.Rows[e.RowIndex].DataBoundItem;
                e.Value = pet.Gender?.GenderName;
            }
        }

        private int? selectedPetId = null;
        private void DataGridViewPets_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPets.CurrentRow == null)
            {
                textBoxName.Clear();
                comboBoxGender.SelectedIndex = -1;
                comboBoxType.SelectedIndex = -1;
                textBoxAge.Clear();
                richTextBoxDescription.Clear();

                selectedPetId = null;
                return;
            }

            var selectedPet = (Pet)dataGridViewPets.CurrentRow.DataBoundItem;

            selectedPetId = selectedPet.Id;

            textBoxName.Text = selectedPet.Name;
            comboBoxGender.SelectedValue = selectedPet.GenderId;
            comboBoxType.SelectedValue = selectedPet.TypeId;
            textBoxAge.Text = selectedPet.AgeMonth.ToString();
            richTextBoxDescription.Text = selectedPet.Description;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!selectedPetId.HasValue) return;

            using (PetDBContext db = new())
            {
                var pet = db.Pets.Include(p => p.PetType).FirstOrDefault(p => p.Id == selectedPetId.Value);
                if (pet != null)
                {
                    pet.Name = textBoxName.Text;
                    pet.GenderId = (int)comboBoxGender.SelectedValue;
                    pet.TypeId = (int)comboBoxType.SelectedValue;
                    pet.AgeMonth = int.Parse(textBoxAge.Text);
                    pet.Description = richTextBoxDescription.Text;

                    db.SaveChanges();
                }

                PopulateDataGridView(db);
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!selectedPetId.HasValue)
            {
                MessageBox.Show("Please select a pet to delete.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this pet?", "Confirm Deletion",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;

            using (PetDBContext db = new())
            {
                var pet = db.Pets.Include(p => p.PetType).Include(p => p.Gender).FirstOrDefault(p => p.Id == selectedPetId.Value);
                if (pet != null)
                {

                    var adoptedPet = db.AdoptedPets.FirstOrDefault(a => a.PetId == pet.Id);
                    if (adoptedPet != null) db.AdoptedPets.Remove(adoptedPet);

                    db.Pets.Remove(pet);
                    db.SaveChanges();
                }

                selectedPetId = null;
                PopulateDataGridView(db);
            }
        }

        private void buttonAddType_Click(object sender, EventArgs e)
        {
            FormPetTypes petTypesForm = new();
            petTypesForm.FormClosed += (s, args) => PopulateComboboxes();
            petTypesForm.ShowDialog();
        }

        private void buttonAddPet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                    comboBoxGender.SelectedIndex == -1 ||
                    comboBoxType.SelectedIndex == -1 ||
                    string.IsNullOrWhiteSpace(textBoxAge.Text) ||
                    !int.TryParse(textBoxAge.Text, out int age) ||
                    age < 0)
            {
                MessageBox.Show("Please fill all fields with valid data.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Pet newPet = new Pet
            {
                Name = textBoxName.Text,
                GenderId = (int)comboBoxGender.SelectedValue,
                TypeId = (int)comboBoxType.SelectedValue,
                AgeMonth = age,
                Description = richTextBoxDescription.Text
            };

            using (PetDBContext db = new())
            {
                db.Pets.Add(newPet);
                db.SaveChanges();

                selectedPetId = newPet.Id;
            }

            PopulateDataGridView();

            textBoxName.Clear();
            comboBoxGender.SelectedIndex = -1;
            comboBoxType.SelectedIndex = -1;
            textBoxAge.Clear();
            richTextBoxDescription.Clear();

            if (selectedPetId.HasValue)
            {
                dataGridViewPets.CurrentCell = dataGridViewPets.Rows[selectedPetId.Value + 1].Cells[1];
            }
        }

        private void comboBoxFilterAdoption_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void comboBoxFilterType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }
    }
}
