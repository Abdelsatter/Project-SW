using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using CrystalDecisions.Shared;
namespace Project_SW
{
    public partial class Form3 : Form
    {

        CrystalReport1 CR;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport1();
            foreach (ParameterDiscreteValue v in CR.ParameterFields[2].DefaultValues)
            {
                comboBox1.Items.Add(v.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CR.SetParameterValue(0, Convert.ToDateTime(dateTimePicker1.Value));
            CR.SetParameterValue(1, Convert.ToDateTime(dateTimePicker2.Value));
            CR.SetParameterValue(2, comboBox1.Text);
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
