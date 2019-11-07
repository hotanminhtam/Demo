using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnCompute.Click += btnCompute_Click;
        }

        void btnCompute_Click(object sender, EventArgs e)
        {
            double Height = double.Parse(txtH.Text);
            double Weight = double.Parse(txtW.Text);
            double Result = Weight / ((Height / 100) * (Height / 100));
            txtBMI.Text = string.Format("{0:0.##}", Result);
            if (Result < 18.5)
            {
                MessageBox.Show("Underweight", "BMI Categories:");
            }
            else if (Result > 18.5 && Result < 24.9)
            {
                MessageBox.Show("Normal weight", "BMI Categories:");
            }
            else if (Result > 25 && Result < 29.9)
            {
                MessageBox.Show("Overweight", "BMI Categories:");
            }
            else if (Result > 30)
            {
                MessageBox.Show("Obesity", "BMI Categories:");
            }
        }
    }
}
