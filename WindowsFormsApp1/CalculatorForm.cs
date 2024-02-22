using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class CalculatorForm : Form
    {
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client calc = new ServiceReference1.Service1Client();
            float n1 = float.Parse(n1add.Text);
            float n2 = float.Parse(n2add.Text);
            addResult.Text = calc.AddNumbers(n1, n2).ToString();
        }
    }
}
