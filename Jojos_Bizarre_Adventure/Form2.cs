using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jojos_Bizarre_Adventure
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "STARDUST CRUSADERS" && radioButton1.Checked) {

                comboBox1.Items.Clear();
                comboBox1.Items.Add("Jotaro Kujo");
                comboBox1.Items.Add("Joseph Joestar");
                comboBox1.Items.Add("Kakyoin");
                comboBox1.Items.Add("Polnareff");
                comboBox1.Items.Add("Avdol");
                comboBox1.Items.Add("Iggy");
            }
           
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "STARDUST CRUSADERS" && radioButton2.Checked)
            {

                comboBox1.Items.Clear();
                comboBox1.Items.Add("Dio");
                comboBox1.Items.Add("Midler");
                comboBox1.Items.Add("Nena");
                comboBox1.Items.Add("Hol Horse");
                comboBox1.Items.Add("Steely Dan");
                comboBox1.Items.Add("Forever");
                comboBox1.Items.Add("ZZ");
                comboBox1.Items.Add("Enya");
                comboBox1.Items.Add("J. Geil");
                comboBox1.Items.Add("Manish Boy");
                comboBox1.Items.Add("Rubber Soul");
                comboBox1.Items.Add("Devo");
                comboBox1.Items.Add("Forever");
                comboBox1.Items.Add("Forever");
                comboBox1.Items.Add("Forever");
                comboBox1.Items.Add("Forever");
                comboBox1.Items.Add("Forever");
                comboBox1.Items.Add("Forever");

            }
        }
    }
}
