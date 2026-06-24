using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
           if(listBox1.Text == "STARDUST CRUSADERS" || listBox1.Text == "GOLDEN WIND" || listBox1.Text == "STONE OCEAN")
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                label4.Visible = true;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "STARDUST CRUSADERS" && radioButton2.Checked)
            {

                comboBox1.Items.Clear();
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
                comboBox1.Items.Add("Arabia Fats");
                comboBox1.Items.Add("Cameo");
                comboBox1.Items.Add("Vanilla Ice");
                comboBox1.Items.Add("N'Doul");
                comboBox1.Items.Add("Oingo");
                comboBox1.Items.Add("Boingo");
                comboBox1.Items.Add("Anubis");
                comboBox1.Items.Add("Mariah");
                comboBox1.Items.Add("Alessi");
                comboBox1.Items.Add("Daniel J. D'arby");
                comboBox1.Items.Add("Telence T. D'arby");
                comboBox1.Items.Add("Pet Shop");
                comboBox1.Items.Add("Dio");
               

            } // FIM STARDUST CRUSADERS

            else if (listBox1.Text == "GOLDEN WIND" && radioButton2.Checked)
            {

                comboBox1.Items.Clear();
                comboBox1.Items.Add("Polpo");
                comboBox1.Items.Add("Mario Zucherro");
                comboBox1.Items.Add("Sale");
                comboBox1.Items.Add("Formaggio");
                comboBox1.Items.Add("Illuso");
                comboBox1.Items.Add("Prosciutto");
                comboBox1.Items.Add("Pesci");
                comboBox1.Items.Add("Melone");
                comboBox1.Items.Add("Ghiaccio");
                comboBox1.Items.Add("Squalo");
                comboBox1.Items.Add("Tiziano");
                comboBox1.Items.Add("Carne");
                comboBox1.Items.Add("Risotto Nero");
                comboBox1.Items.Add("Cioccolatta");
                comboBox1.Items.Add("Secco");
                comboBox1.Items.Add("Doppio");
                comboBox1.Items.Add("Diavolo");

            } // FIM GOLDEN WIND

            else if (listBox1.Text == "STONE OCEAN" && radioButton2.Checked)
            {

                comboBox1.Items.Clear();
                comboBox1.Items.Add("Gwess");
                comboBox1.Items.Add("Jongalli A");
                comboBox1.Items.Add("Thunder McQueen");
                comboBox1.Items.Add("Miraschon");
                comboBox1.Items.Add("Lang Rangler");
                comboBox1.Items.Add("Sports Maximum");
                comboBox1.Items.Add("Viviano Westwood");
                comboBox1.Items.Add("Kenzou");
                comboBox1.Items.Add("Guccio");
                comboBox1.Items.Add("D&G");
                comboBox1.Items.Add("Bêbe Verde");
                comboBox1.Items.Add("Miu Miu");
                comboBox1.Items.Add("Ungalo");
                comboBox1.Items.Add("Rikiel");
                comboBox1.Items.Add("Donatello Versus");
                comboBox1.Items.Add("Enrico Pucci");
              
            } // FIM STONE OCEAN

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (listBox1.Text == "STARDUST CRUSADERS" && radioButton1.Checked)
            {

                comboBox1.Items.Clear();
                comboBox1.Items.Add("Jotaro Kujo");
                comboBox1.Items.Add("Joseph Joestar");
                comboBox1.Items.Add("Kakyoin");
                comboBox1.Items.Add("Polnareff");
                comboBox1.Items.Add("Avdol");
                comboBox1.Items.Add("Iggy");
            } //FIM STARDUST CRUSADERS

            else if (listBox1.Text == "GOLDEN WIND" && radioButton1.Checked)
            {

                comboBox1.Items.Clear();
                comboBox1.Items.Add("Giorno Giovanna");
                comboBox1.Items.Add("Bruno Bucciarati");
                comboBox1.Items.Add("Narancia Ghirga");
                comboBox1.Items.Add("Pannacotta Fugo");
                comboBox1.Items.Add("Leone Abbacchio");
                comboBox1.Items.Add("Guido Mista");
                comboBox1.Items.Add("Trish Una");
            } //FIM GOLDEN WIND

            else if (listBox1.Text == "STONE OCEAN" && radioButton1.Checked)
            {

                comboBox1.Items.Clear();
                comboBox1.Items.Add("Jolyne Kujo");
                comboBox1.Items.Add("Jotaro Kujo");
                comboBox1.Items.Add("Ermes Costello");
                comboBox1.Items.Add("F.F");
                comboBox1.Items.Add("Anastasia");
                comboBox1.Items.Add("Weather Forecast");
                comboBox1.Items.Add("Emporio Alnino");
            } //FIM GOLDEN WIND

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
