using ClientForm.FoundamentalServiceReference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForm
{
    public partial class FormClient : Form
    {
        private FoundamentalClient Service;
        public FormClient()
        {
            InitializeComponent();
        }
        private void FormClient_Load(object sender, EventArgs e)
        {
            Service = new FoundamentalClient();
            PopulateGridViewByPersons();
            PopulateCmbByPersons();
        }
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            string firstName = Fname.Text;
            string lastName = Lname.Text;
            string personalId = Pid.Text;
            string email = Email.Text;

            if (!string.IsNullOrEmpty(firstName) &&
                !string.IsNullOrEmpty(lastName) &&
                !string.IsNullOrEmpty(personalId) &&
                !string.IsNullOrEmpty(email))
            {
                Service.AddStudent(firstName, lastName, personalId, email);
                MessageBox.Show("Person added successfully!");
            }
            else
            {
                MessageBox.Show("The one of the field is empty!");
            }
        }
        private void PopulateGridViewByPersons()
        {
            var persons = Service.GetAllPerson();
            DgvPersons.DataSource = persons;
        }
        private void PopulateCmbByPersons()
        {
            var persons = Service.GetAllPerson();
            CmbPersons.DisplayMember = "FirstName";
            CmbPersons.ValueMember = "ID";
            CmbPersons.DataSource = persons;
        }
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            PopulateGridViewByPersons();
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (CmbPersons.SelectedItem != null)
            {
                var selectedPerson = (Person)CmbPersons.SelectedItem;
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {selectedPerson.FirstName}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    Service.DeletePersonById(selectedPerson.ID);
                    PopulateCmbByPersons();
                }
            }
            else
            {
                MessageBox.Show("Please select a person to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
