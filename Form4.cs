using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace Project_SW
{
    public partial class Form4 : Form
    {

        CrystalReport2 CR;

        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport2();
            foreach (ParameterDiscreteValue v in CR.ParameterFields[0].DefaultValues)
            {
                comboBox1.Items.Add(v.Value);
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, comboBox1.Text);
            crystalReportViewer1.ReportSource = CR;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
