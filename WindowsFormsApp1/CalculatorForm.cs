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
            if (TryGetFloatValues(n1add.Text, n2add.Text, out float float1, out float float2))
            {
                addResult.Text = calc.AddNumbers(float1, float2).ToString();
            }
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            if (TryGetFloatValues(n1sub.Text, n2sub.Text, out float float1, out float float2))
            {
                subResult.Text = calc.SubstractNumbers(float1, float2).ToString();
            }
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            if (TryGetFloatValues(n1div.Text, n2div.Text, out float float1, out float float2))
            {
                divResult.Text = calc.DivideNumbers(float1, float2).ToString();
            }
        }

        private void multBtn_Click(object sender, EventArgs e)
        {
            if (TryGetFloatValues(n1mult.Text, n2mult.Text, out float float1, out float float2))
            {
                multResult.Text = calc.MultiplyNumbers(float1, float2).ToString();
            }
            
        }
        private bool TryGetFloatValues(string input1, string input2, out float result1, out float result2)
        {
            result1 = result2 = 0;

            if (float.TryParse(input1, out result1) && float.TryParse(input2, out result2))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Both inputs should be valid float or integer numbers.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
        }
    }
}
