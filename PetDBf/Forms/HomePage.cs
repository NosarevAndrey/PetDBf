using PetDBf.Forms;

namespace PetDBf
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void petTypes_Click(object sender, EventArgs e)
        {
            FormPetTypes petTypesForm = new();
            petTypesForm.ShowDialog();

        }

        private void pets_Click(object sender, EventArgs e)
        {
            FormPets petsForm = new();
            petsForm.ShowDialog();
        }

        private void clients_Click(object sender, EventArgs e)
        {
            FormClients petsForm = new();
            petsForm.ShowDialog();
        }
    }
}
