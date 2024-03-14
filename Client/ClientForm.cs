using Client.AdventureWorksService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Client
{
    public partial class ClientForm : Form
    {
        private DataProviderClient service;
        private int customersDgvPageNumber;
        public ClientForm()
        {
            InitializeComponent();
        }
        private void ClientForm_Load(object sender, EventArgs e)
        {
            service = new DataProviderClient();
            customersDgvPageNumber = 1;
            PopulateDgvCustomers();
        }
        private void PopulateDgvCustomers()
        {
            CustomersDgv.DataSource = null;
            var customers = service.GetCustomers(customersDgvPageNumber);
            CustomersDgv.DataSource = customers;
            CurrentPageLabel.Text = customersDgvPageNumber.ToString();
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            if(customersDgvPageNumber - 1 <= 0)
            {
                MessageBox.Show("Page number cannot be negative number!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                customersDgvPageNumber--;
                PopulateDgvCustomers();
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            customersDgvPageNumber++;
            PopulateDgvCustomers();
        }
    }
}
