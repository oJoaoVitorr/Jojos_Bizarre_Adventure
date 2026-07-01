using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
           if(listBox1.Text == "GOLDEN WIND")
            {
                label1.Text = "Vento Aureo, traduzido em inglês como Golden Wind é a quinta parte de JoJo's Bizarre Adventure, serializada na Weekly Shōnen Jump de dezembro de" +
                    " 1995 a abril de 1999. O arco abrange um total de 155 capítulos e ocorre após Diamond is Unbreakable.";
            }
            radioButton1.Visible = true; radioButton1.Checked = false;
            radioButton2.Visible = true; radioButton2.Checked = false;
            label1.Visible = true;
            comboBox1.Visible = false;
            checkBox1.Visible = false;
            checkBox2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = true; comboBox1.SelectedIndex = -1;
            checkBox1.Visible = false; checkBox1.Checked = false;
            checkBox2.Visible = false; checkBox2.Checked = false;
            checkBox3.Visible = false; checkBox3.Checked = false;
            checkBox4.Visible = false; checkBox4.Checked = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            pictureBox5.Visible = false;
            pictureBox6.Visible = false;
            pictureBox7.Visible = false;
            pictureBox8.Visible = false;
            pictureBox9.Visible = false;
            pictureBox11.Visible = false;
            
            
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
                comboBox1.Items.Add("Versus");
                comboBox1.Items.Add("Enrico Pucci");

            } // FIM STONE OCEAN

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Visible = true; groupBox1.Text = comboBox1.Text;
            pictureBox1.Visible = true;
            pictureBox2.Visible = true;
            pictureBox3.Visible = true;
            pictureBox4.Visible = true;
            label2.Visible = true;
            checkBox1.Visible = true; checkBox1.Checked = false;
            checkBox2.Visible = true; checkBox2.Checked = false;
            checkBox3.Visible = true; checkBox3.Checked = false;
            checkBox4.Visible = true; checkBox4.Checked = false;

            //STARDUST HEROIS
            if (comboBox1.Text == "Jotaro Kujo")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Curiosidade";
                pictureBox1.Image = Properties.Resources.Jotaro;
                pictureBox2.Image = Properties.Resources.JotaroManga;
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
            else if (comboBox1.Text == "Midler")
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
                checkBox3.Text = "Dubladora";
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
                checkBox3.Text = "Dubladora";
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
                checkBox3.Text = "Dubladora";
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
                checkBox3.Text = "Dubladora";
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
            else if (comboBox1.Text == "Giorno Giovanna")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Curiosidade";
            }
            else if (comboBox1.Text == "Bruno Bucciarati")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Morte";
                groupBox2.Text = "Sticky Fingers";
                groupBox3.Text = "Morte";
                groupBox4.Text = "Lucas Gama";
                pictureBox1.Image = Properties.Resources.brunoanime;
                pictureBox2.Image = Properties.Resources.brunomanga;
                pictureBox3.Image = Properties.Resources.brunochangec;
                pictureBox4.Image = Properties.Resources.brunomangaziper;
                pictureBox5.Image = Properties.Resources.stickyfanime;
                pictureBox6.Image = Properties.Resources.stickyfmanga;
                label2.Text = "Bruno Bucciarati é o deuteragonista de Vento Aureo/Golden Wind. Ele é um mafioso e líder de seu próprio esquadrão dentro da poderosa gangue napolitana," +
                    " Passione. Enviado para rastrear quem atacou Leaky-Eye Luca e estreando como  oponente de Giorno Giovanna, Bucciarati se torna o primeiro a dar apoio significativo" +
                    " a Giorno em sua ascensão nas fileiras de Passione.";
                label4.Text = "Sticky Fingers é um Stand humanoide de altura e constituição semelhante à de Bucciarati. Sticky Fingers é um Stand de curto alcance cuja excelente força e" +
                    " velocidade o tornam adequado para combate direto. A principal habilidade do Sticky Fingers é" +
                    " criar zíperes em qualquer superfície que toca com o punho, que pode abrir ou fechar remotamente quando quiser. Por exemplo, Sticky Fingers pode atingir uma parede, abri-la" +
                    " para criar uma abertura e passar por ela, depois fechar o zíper.";
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
                checkBox3.Text = "Dubladora";
                checkBox4.Text = "Curiosidade";
            }
            //GOLDEN WIND VILÕES
            else if (comboBox1.Text == "Polpo")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Morte";
            }
            else if (comboBox1.Text == "Mario Zucherro")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Sale")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Formaggio")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Illuso")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Prosciutto")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Pesci")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Melone")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Ghiaccio")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Squalo")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Tiziano")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Carne")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Morte";
            }
            else if (comboBox1.Text == "Risotto Nero")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Cioccolatta")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Secco")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Doppio")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Morte";
            }
            else if (comboBox1.Text == "Diavolo")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Morte";
            }
            //STONE OCEAN HEROIS
            else if (comboBox1.Text == "Jolyne Kujo")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dubladora";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Jotaro Kujo")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Ermes Costello")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dubladora";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "F.F")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dubladora";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Anastasia")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Wheater Forecast")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Emporio Alnino")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            //STONCE OCEAN VILÕES
            else if (comboBox1.Text == "Gwess")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dubladora";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Jongalli A")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Thunder McQueen")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Miraschon")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dubladora";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Lang Rangler")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Sports Maximum")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Viviano Westwood")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Kenzou")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Gucci")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "D&G")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Bêbe verde")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Miu Miu")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dubladora";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Ungalo")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Rikiel")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Versus")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
            }
            else if (comboBox1.Text == "Enrico Pucci")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Morte";
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Visible = true; comboBox1.SelectedIndex = -1;
            checkBox1.Visible = false; checkBox1.Checked = false;
            checkBox2.Visible = false; checkBox2.Checked = false;
            checkBox3.Visible = false; checkBox3.Checked = false;
            checkBox4.Visible = false; checkBox4.Checked = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;

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
            } //FIM STONE OCEAN
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            pictureBox5.Visible = true;
            pictureBox6.Visible = true;
            pictureBox7.Visible = true;
            if (checkBox1.Checked == false)
            {
                groupBox2.Visible = false;

            }
            if (comboBox1.Text == "Jotaro Kujo")
            {
                pictureBox5.Image = Properties.Resources.Jotaro;
            }
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            if (checkBox1.Checked == false)
            {
                label4.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
            if(checkBox1.Checked == false)
            {
                groupBox4.Visible = false;


            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            groupBox3.Visible = true; groupBox3.Text = checkBox4.Text;
            pictureBox8.Visible = true;
            pictureBox9.Visible = true;
            label4.Visible = true;

            if(checkBox1.Checked == false){
             groupBox3.Visible = false;
             pictureBox8.Visible = false;
             pictureBox9.Visible = false;
             label4.Visible = false;
            }

        }
    }
}


