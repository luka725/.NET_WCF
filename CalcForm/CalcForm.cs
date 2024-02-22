using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcForm
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {
            CalculatorService.Service1Client calc = new CalculatorService.Service1Client();
            float n1 = float.Parse(n1add.Text);
            float n2 = float.Parse(n2add.Text);
            addResult.Text = calc.AddNumbers(n1, n2).ToString();
        }
    }
}
