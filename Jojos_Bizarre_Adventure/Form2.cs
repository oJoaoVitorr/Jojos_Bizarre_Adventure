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
            if (listBox1.Text == "STARDUST CRUSADERS" || listBox1.Text == "GOLDEN WIND" || listBox1.Text == "STONE OCEAN")
            {
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                label1.Visible = true;
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                comboBox1.Visible = true;
            }
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
           groupBox1.Visible = true;
           pictureBox1.Visible = true;
           pictureBox2.Visible = true;
           pictureBox3.Visible = true;
           pictureBox4.Visible = true;
           label2.Visible = true;

            //STARDUST HEROIS
                if (comboBox1.Text == "Jotaro Kujo")
                {
                    checkBox1.Text = "Stand";
                    checkBox2.Text = "Descrição do Stand";
                    checkBox3.Text = "Dublador";
                    checkBox4.Text = "Curiosidade";
                    groupBox1.Text = comboBox1.Text;
                    pictureBox1.Image =  Properties.Resources.Jotaro;
                    pictureBox2.Image =  Properties.Resources.JotaroManga;

                }
                else if (comboBox1.Text == "Joseph Joestar")
                {
                    checkBox1.Text = "Stand";
                    checkBox2.Text = "Descrição do Stand";
                    checkBox3.Text = "Dublador";
                    checkBox4.Text = "Curiosidade";
                pictureBox1.Image = Properties.Resources.Josepph;
            }
                else if (comboBox1.Text == "Kakyoin")
                {
                    checkBox1.Text = "Stand";
                    checkBox2.Text = "Descrição do Stand";
                    checkBox3.Text = "Dublador";
                    checkBox4.Text = "Morte";
                }
                else if (comboBox1.Text == "Polnareff")
                {
                    checkBox1.Text = "Stand";
                    checkBox2.Text = "Descrição do Stand";
                    checkBox3.Text = "Dublador";
                    checkBox4.Text = "Curiosidade";
                }
                else if (comboBox1.Text == "Avdol")
                {
                    checkBox1.Text = "Stand";
                    checkBox2.Text = "Descrição do Stand";
                    checkBox3.Text = "Dublador";
                    checkBox4.Text = "Morte";
                }
                else if (comboBox1.Text == "Iggy")
                {
                    checkBox1.Text = "Stand";
                    checkBox2.Text = "Descrição do Stand";
                    checkBox3.Text = "Dublador";
                    checkBox4.Text = "Morte";
                }
                
            //STARDUST VILOES
            if (comboBox1.Text == "Midler")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dubladora";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Nena")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Hol Horse")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Steely Dan")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Forever")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "ZZ")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Enya")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "J. Geil")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Manish Boy")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Rubber Soul")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Devo")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Arabia Fats")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Cameo")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Vanilla Ice")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "N'Doul")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Oingo")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Boingo")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Anubis")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Mariah")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Alessi")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Daniel J. D'arby")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Telence T. D'arby")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Pet Shop")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Dio")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Morte";
            }
            //GOLDEN WIND HEROIS
            if (comboBox1.Text == "Giorno Giovanna")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Curiosidade";
            }
            else if (comboBox1.Text == "Bruno Bucciaratti")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Morte";
            }
            else if (comboBox1.Text == "Narancia Ghirga")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Morte";
            }
            else if (comboBox1.Text == "Pannacota Fugo")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Curiosidade";
            }
            else if (comboBox1.Text == "Leone Abbacchio")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Morte";
            }
            else if (comboBox1.Text == "Guido Mista")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Curiosidade";
            }
            else if (comboBox1.Text == "Trish")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Curiosidade";
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                comboBox1.Visible = true;
            }
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
    }
}


