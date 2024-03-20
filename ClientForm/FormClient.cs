﻿using ClientForm.FoundamentalServiceReference;
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
        private FoundamentalClient client;
        private int Uid;
        public FormClient()
        {
            InitializeComponent();
        }
        private void FormClient_Load(object sender, EventArgs e)
        {
            client = new FoundamentalClient();
            PopulateGridViewByPersons();
            PopulateCmbByPersons();
        }
        private void PopulateGridViewByPersons()
        {
            DgvPersons.DataSource = null;
            var persons = client.GetAllPerson();
            DgvPersons.DataSource = persons;
        }
        private void PopulateCmbByPersons()
        {
            CmbPersons.DataSource = null;
            var persons = client.GetAllPerson();
            CmbPersons.DisplayMember = "FullName";
            CmbPersons.ValueMember = "Id";
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
                var selectedPerson = (PersonDTO)CmbPersons.SelectedItem;
                DialogResult result = MessageBox.Show($"Are you sure you want to delete {selectedPerson.FirstName}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    client.DeletePersonById(selectedPerson.Id);
                    PopulateGridViewByPersons();
                    PopulateCmbByPersons();
                }
            }
            else
            {
                MessageBox.Show("Please select a person to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                var NewPerson = new PersonDTO
                {
                    Id = Uid,
                    FirstName = firstName,
                    LastName = lastName,
                    PersonalId = personalId,
                    Email = email
                };
                client.AddPerson(NewPerson);
                PopulateGridViewByPersons();
                PopulateCmbByPersons();
                if(Uid != 0)
                {
                    MessageBox.Show($"Person {firstName} {lastName} Updated successfully!");
                }
                else
                {
                    MessageBox.Show($"Person {firstName} {lastName} added successfully!");
                }
                
                Uid = 0;
                InsertBtn.Text = "Add";
                Fname.Text = string.Empty;
                Lname.Text = string.Empty;
                Pid.Text = string.Empty;
                Email.Text = string.Empty;
                AddUpdateLabel.Text = "Add New Person";
            }
            else
            {
                MessageBox.Show("The one of the field is empty!");
            }
        }
        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            if (CmbPersons.SelectedItem  != null)
            {
                PersonDTO selectedPerson = (PersonDTO)CmbPersons.SelectedItem;
                if (selectedPerson != null)
                {
                    Uid = selectedPerson.Id;
                    Fname.Text = selectedPerson.FirstName;
                    Lname.Text = selectedPerson.LastName;
                    Email.Text = selectedPerson.Email;
                    Pid.Text = selectedPerson.PersonalId;

                    AddUpdateLabel.Text = $"Update Person: {Fname.Text} {Lname.Text}";
                    InsertBtn.Text = "Update";
                }
                
            }
        }
    }
}