using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForm
{
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
        }

        private void FormClient_Load(object sender, EventArgs e)
        {
            FoundamentalServiceReference.FoundamentalClient service = new FoundamentalServiceReference.FoundamentalClient();
            var person = service.GetAllPerson();
            label1.Text = person.First().FirstName;
        }
    }
}
