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
    public partial class FormAdopt : Form
    {
        private Client _client;
        public FormAdopt(Client client)
        {
            InitializeComponent();
            _client = client;
            labelGreeting.Text = $"{_client.Name}, welcome on adoption page";

        }
        private void FormAdopt_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
            dataGridViewAdopted.CellFormatting += DataGridViewAdopted_CellFormatting;
            dataGridViewToAdopt.CellFormatting += DataGridViewToAdopt_CellFormatting;
        }
        private void PopulateDataGridView(PetDBContext db)
        {
            var adoptedPetsIds = (from a in db.AdoptedPets
                                  select a.PetId).ToList();

            var adoptedPets = (from p in db.Pets
                               join petId in adoptedPetsIds on p.Id equals petId
                               select p)
                               .Include(p => p.PetType)
                               .Include(p => p.Gender)
                               .ToList();

            var availablePets = (from p in db.Pets
                                 where !adoptedPetsIds.Contains(p.Id)
                                 select p)
                                 .Include(p => p.PetType)
                                 .Include(p => p.Gender)
                                 .ToList();

            dataGridViewAdopted.DataSource = adoptedPets;
            dataGridViewAdopted.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewAdopted.Columns["Id"].Visible = false;
            dataGridViewAdopted.Columns["TypeId"].Visible = false;
            dataGridViewAdopted.Columns["GenderId"].Visible = false;

            dataGridViewToAdopt.DataSource = availablePets;
            dataGridViewToAdopt.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewToAdopt.Columns["Id"].Visible = false;
            dataGridViewToAdopt.Columns["TypeId"].Visible = false;
            dataGridViewToAdopt.Columns["GenderId"].Visible = false;
        }
        private void PopulateDataGridView()
        {
            using (PetDBContext db = new())
            {
                PopulateDataGridView(db);
            }
        }
        private void FormatPetDataGridViewCell(DataGridViewCellFormattingEventArgs e, DataGridView dataGridView)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "PetType" && e.Value != null)
            {
                var pet = (Pet)dataGridView.Rows[e.RowIndex].DataBoundItem;
                e.Value = pet.PetType?.TypeName;
            }
            if (dataGridView.Columns[e.ColumnIndex].Name == "Gender" && e.Value != null)
            {
                var pet = (Pet)dataGridView.Rows[e.RowIndex].DataBoundItem;
                e.Value = pet.Gender?.GenderName;
            }
        }
        private void DataGridViewAdopted_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            FormatPetDataGridViewCell(e, dataGridViewAdopted);
        }

        private void DataGridViewToAdopt_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            FormatPetDataGridViewCell(e, dataGridViewToAdopt);
        }

        private int? selectedPetToAdopt = null;
        private void dataGridViewToAdopt_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewToAdopt.CurrentRow == null)
            {
                selectedPetToAdopt = null;
                return;
            }

            var selectedPet = (Pet)dataGridViewToAdopt.CurrentRow.DataBoundItem;
            selectedPetToAdopt = selectedPet.Id;
        }

        private void buttonAdopt_Click(object sender, EventArgs e)
        {
            if (!selectedPetToAdopt.HasValue)
            {
                MessageBox.Show("Please select a pet to adopt.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to adopt this pet?", "Confirm Adoption",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;

            using (PetDBContext db = new())
            {
                var petToAdopt = (from p in db.Pets
                                  where p.Id == selectedPetToAdopt.Value
                                  select p).FirstOrDefault();
                if (petToAdopt == null)
                {
                    MessageBox.Show("The selected pet could not be found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var adoptedPet = new AdoptedPet
                {
                    PetId = petToAdopt.Id,
                    ClientId = _client.Id,
                    AdoptionDate = DateTime.Now
                };

                db.AdoptedPets.Add(adoptedPet);
                db.SaveChanges();

                PopulateDataGridView(db);
            }

            selectedPetToAdopt = null;
        }


        private int? selectedPetToReturn = null;
        private void dataGridViewAdopted_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewAdopted.CurrentRow == null)
            {
                selectedPetToReturn = null;
                return;
            }

            var selectedPet = (Pet)dataGridViewAdopted.CurrentRow.DataBoundItem;
            selectedPetToReturn = selectedPet.Id;
        }
        private void buttonReturn_Click(object sender, EventArgs e)
        {
            if (!selectedPetToReturn.HasValue)
            {
                MessageBox.Show("Please select a pet to return.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to return this pet?", "Confirm Return",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;

            using (PetDBContext db = new())
            {
                var adoptedPet = (from a in db.AdoptedPets
                                  where a.PetId == selectedPetToReturn.Value
                                  select a).FirstOrDefault();
                if (adoptedPet == null)
                {
                    MessageBox.Show("The selected pet is not adopted or has already been returned.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                db.AdoptedPets.Remove(adoptedPet);
                db.SaveChanges();

                PopulateDataGridView(db);
            }

            selectedPetToReturn = null;
        }
    }
}
