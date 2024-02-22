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
        public CalculatorServiceReference.Service1Client calc = new CalculatorServiceReference.Service1Client();
        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            float n1 = float.Parse(n1add.Text);
            float n2 = float.Parse(n2add.Text);
            addResult.Text = calc.AddNumbers(n1, n2).ToString();
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            float n1 = float.Parse(n1sub.Text);
            float n2 = float.Parse(n2sub.Text);
            subResult.Text = calc.SubstractNumbers(n1, n2).ToString();
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            float n1 = float.Parse(n1div.Text);
            float n2 = float.Parse(n2div.Text);
            divResult.Text = calc.DivideNumbers(n1, n2).ToString();
        }

        private void multBtn_Click(object sender, EventArgs e)
        {
            float n1 = float.Parse(n1mult.Text);
            float n2 = float.Parse(n2mult.Text);
            multResult.Text = calc.MultiplyNumbers(n1, n2).ToString();
        }
    }
}
