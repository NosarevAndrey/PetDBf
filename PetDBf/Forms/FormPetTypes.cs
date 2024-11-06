using Microsoft.IdentityModel.Tokens;
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
    public partial class FormPetTypes : Form
    {
        public FormPetTypes()
        {
            InitializeComponent();
        }

        private void PetTypes_Load(object sender, EventArgs e)
        {
            PopulateDataGridView();
        }

        private void PopulateDataGridView()
        {
            using (PetDBContext db = new())
            {
                var petTypes = db.PetTypes.ToList();
                dataGridViewPetTypes.DataSource = petTypes; // Bind the list to the DataGridView
                dataGridViewPetTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Optional: set auto-sizing
            }
        }

        private void buttonAddPetType_Click(object sender, EventArgs e)
        {
            string newPetTypeName = textBoxPetType.Text.Trim().ToLower();

            if (newPetTypeName.IsNullOrEmpty())
            {
                MessageBox.Show(
                    "Please enter a pet type name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (PetDBContext db = new())
            {
                bool petTypeExists = db.PetTypes.Any(pt => pt.TypeName.Equals(newPetTypeName));

                if (petTypeExists)
                {
                    MessageBox.Show("This pet type already exists.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                PetType newPetType = new PetType { TypeName = newPetTypeName };
                db.PetTypes.Add(newPetType);
                db.SaveChanges();

                textBoxPetType.Clear();
                PopulateDataGridView();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
