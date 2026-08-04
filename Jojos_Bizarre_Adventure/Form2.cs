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
                comboBox1.Items.Add("Capitão Tennille");
                comboBox1.Items.Add("Devo");
                comboBox1.Items.Add("Arabia Fats");
                comboBox1.Items.Add("Cameo");
                comboBox1.Items.Add("Gray Fly");
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
                groupBox2.Text = "Star Platinum";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Wilken Mazzei";
                label2.Text = "Jotaro Kujo é o protagonista da terceira parte de JoJo's Bizarre Adventure, e o terceiro JoJo da série. Sendo o portador do todo-poderoso Star Platinum, Jotaro é o primeiro JoJo introduzido com um Stand, e está entre um dos mais bem-conhecidos personagens da série.\r\nÉ um delinquente mestiço que embarca em uma jornada pelo mundo junto ao seu avô, Joseph Joestar, e um grupo de amigos para salvar sua mãe e derrotar DIO, o vampiro, de uma vez por todas";
                label4.Text = "Star Platinum é um Stand de curto-alcance com força e velocidade excepcional, assim como a habilidade de parar o tempo que foi ganha durante a batalha contra DIO. Seu poder esmagador, junto da habilidade em lutas de Jotaro, o torna um dos Stands mais fortes e icônicos da obra.\r\nStar Platinum é um Stand de Curto Alcance com um alcance básico de apenas dois metros do corpo de Jotaro, mas ostenta velocidade, poder, e precisão inigualáveis.\r\nO Star Platinum pode estender seus dedos indicativos e do meio, permitindo que ele realize ataques sorrateiros e cortar oponentes um pouco fora de seu alcance.";
                label3.Text = "O Stand de Jotaro é uma referência a carta 17 do Tarot, A Estrela.";
                pictureBox1.Image = Properties.Resources.jotaroanime;
                pictureBox2.Image = Properties.Resources.jotaromanga;
                pictureBox3.Image = Properties.Resources.jotaromangac;
                pictureBox4.Image = Properties.Resources.jotaroanime2;
                pictureBox5.Image = Properties.Resources.starpanime;
                pictureBox6.Image = Properties.Resources.starpmanga;
                pictureBox8.Image = Properties.Resources.Carta_Estrela;
               

            }
            else if (comboBox1.Text == "Joseph Joestar")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Curiosidade";
                groupBox2.Text = "Hermit Purple";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Mauro Ramos";
                label2.Text = "Joseph Joestar é o protagonista da segunda parte de JoJo's Bizarre Adventure, Battle Tendency, e o segundo JoJo da série.\r\noseph é um usuário natural de Hamon e um eventual usuário de Stand, tendo Hermit Purple como seu Stand. Um encrenqueiro exuberante com um talento excepcional para trapaças, Joseph encontra várias ameaças fantásticas aproximando-se dele durante sua vida com iniciativa e uma ingenuidade impressionante, batalhando contra vampiros, os Homens do Pilar, e usuários malevolentes de Stand.\r\n";
                label4.Text = "Hermit Purple é um Stand parecido com vinhas que Joseph invoca em suas mãos. Ele permite que o usuário adivinhe informações e mensagens de outras localizações.\r\nAs vinhas são fortes o suficiente para suportar seu próprio peso e longas o suficiente para amarrar alguém completamente.\r\nAs vinhas de Hermit Purple são relativamente fracas em combate direto, mas podem providenciar a Joseph com uma habilidade de adivinhação considerável, fazendo com que ele possa materializar qualquer tipo de informação, como uma imagem, uma localização ou até mesmo pensamentos.";
                label3.Text = "O Stand de Joseph é uma referência a carta 9 do tarot, O Eremita.";
                pictureBox1.Image = Properties.Resources.JosephAnime;
                pictureBox2.Image = Properties.Resources.JosephManga;
                pictureBox3.Image = Properties.Resources.JosephManga2;
                pictureBox4.Image = Properties.Resources.JosephAnime2;
                pictureBox5.Image = Properties.Resources.HermitManga;
                pictureBox6.Image = Properties.Resources.HermitManga2;
                //pictureBox7.Image = Properties.Resources.;//
               
                pictureBox8.Image = Properties.Resources.Carta_Hermit;
            }
            else if (comboBox1.Text == "Kakyoin")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Morte";
                groupBox2.Text = "Hierophant Green";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Thiago Longo";
                label2.Text = "Kakyoin é um estudante japonês que foi manipulado por DIO durante uma viagem ao Egito e enviado para matar Jotaro Kujo. Após ser livrado da influência de DIO, ele decide se juntar a Jotaro para salvar a mãe dele e se redimir. Kakyoin é um usuário de Stand e portador do Hierophant Green.c";
                label4.Text = "O primeiro Stand de longo-alcance revelado na obra, o Hierophant Green luta a distância e é capaz de se desenrolar em tentáculos e liberar uma resplandecente rajada de esmeraldas conhecida como o Emerald Splash. O Hierophant Green é capaz de deslizar seus tentáculos para dentro do corpo de alguém, permitindo que Kakyoin completamente controle essa pessoa. Isso serve para proteger o Hierophant Green e Kakyoin de ataques caso seu oponente seja alguém indisposto a ferir inocentes.";
                label3.Text = "O Stand de Kakyoin é uma referência a carta 5 do tarot, O Hierofante/Papa.";
                pictureBox1.Image = Properties.Resources.KakyoinAnime;
                pictureBox2.Image = Properties.Resources.KakyoinManga;
                pictureBox3.Image = Properties.Resources.KakyoinManga2;
                pictureBox4.Image = Properties.Resources.KakyoinAnime2;
                pictureBox5.Image = Properties.Resources.Hierophant;
                pictureBox6.Image = Properties.Resources.Hierophant2;
                /*/pictureBox7.Image =  Properties.Resources.;
                pictureBox7.Image =  Properties.Resources.;/*/
                pictureBox8.Image = Properties.Resources.Carta_Hierofante;

            }
            else if (comboBox1.Text == "Polnareff")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Curiosidade";
                groupBox2.Text = "Silver Chariot";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Fernando Mendonça";
                label2.Text = "Jean Pierre Polnareff é um aliado principal na terceira parte de JoJo's Bizarre Adventure, o francês Polnareff viaja com Jotaro e Joseph para vingar sua irmã, que foi assasinada por um homem com duas mãos direitas.\r\nPolnareff é o membro menos sério do grupo, servindo como o oposto de Jotaro.Ele pode ser o que mais se liga aos seus companheiros, casualmente brincando com Kakyoin, Joseph, e até mesmo com Jotaro.\r\n";
                label4.Text = "Silver Chariot é um Stand humanoide revestido por armadura e armado com uma rapieira. Ele é particularmente mortal em curto-alcance devido a sua velocidade e precisão. O Silver Chariot é um Stand incrivelmente rápido, já que ele é capaz de aparecer em vários lugares de uma vez só, devido a se mover a uma velocidade mais rápida que olhos humanos possam processar, criando pós-imagens ilusórias.";
                label3.Text = "O Stand de Polnareff é uma referência a carta 7 do tarot, O Carro.";
                pictureBox1.Image = Properties.Resources.PolnareffAnime;
                pictureBox2.Image = Properties.Resources.PolnareffManga;
                pictureBox3.Image = Properties.Resources.PolnareffManga2;
                pictureBox4.Image = Properties.Resources.PolnareffAnime2;
                pictureBox5.Image = Properties.Resources.SilverChariot;
                pictureBox6.Image = Properties.Resources.SilverChariot1;
                //pictureBox7.Image = Properties.Resources.;
                pictureBox8.Image = Properties.Resources.Carta_Silver_Chariot;
            }
            else if (comboBox1.Text == "Avdol")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Morte";
                groupBox2.Text = "Mago Vermelho";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Duda Ribeiro";
                label2.Text = "Introduzido como um amigo egípcio de Joseph Joestar, ele se junta ao grupo em sua jornada para derrotar DIO, provendo conhecimento e os guiando sobre usuários de Stand inimigos e culturas locais ao longo da viagem. Avdol é um usuário de Stand e porta o Stand manipulador de fogo, Magician's Red.";
                label4.Text = "O Mago Vermelho, ou originalmente Magician's Red é um Stand humanoide cuja aparência é a de um híbrido de humano e pássaro, com a habilidade de produzir e manipular fogo de várias maneiras.\r\nMagician's Red é um Stand de curto alcance com e fisicamente poderoso, sua habilidade assinatura é de livremente gerar e controlar o fogo. As chamas resultantes são intensas o suficiente para evaporar projéteis de metal no meio do ar e também fatiar trilhos de trem.";
                label3.Text = "O Stand de Avdol é uma referência a primeira carta do tarot, O Mago.";
                pictureBox8.Image = Properties.Resources.Carta_Mago;
                pictureBox1.Image = Properties.Resources.AvdolAnime;
                pictureBox2.Image = Properties.Resources.AvdolManga;
                pictureBox3.Image = Properties.Resources.AvdolManga2;
                pictureBox4.Image = Properties.Resources.AvdolAnime2;
                pictureBox5.Image = Properties.Resources.MagoVerm;
                pictureBox6.Image = Properties.Resources.MagoVerm2;
                //pictureBox7.Image = Properties.Resources.;

            }
            else if (comboBox1.Text == "Iggy")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Morte";
                groupBox2.Text = "O Louco";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Pedro Alcântara";
                label2.Text = "O rei dos vira-latas de Nova York, Iggy, é levado ao grupo Joestar após chegar ao Egito e relutantemente se junta a eles em sua jornada final à Cairo para derrotar DIO. Iggy é um usuário de Stand que empunha o Stand de areia, The Fool.\r\nIggy é um cão altamente inteligente porém rebelde, orgulhoso, auto-indulgente descrito como tendo uma personalidade \"terrível\".\r\n";
                label4.Text = "The Fool ou O Louco é um Stand vínculado a uma massa de areia que geralmente tem a aparência de uma besta mecânica.The Fool manifesta-se como uma pilha de areia que Iggy pode controlar a vontade até criar estruturas de areia em combate. Como O Louco é somente vínculado a areia que manipula, ele não pode ser ferido de qualquer maneira. Também pode se transformar no que desejar.";
                label3.Text = "O Stand de Iggy é uma referência a carta 0 do tarot, O Louco.";
                pictureBox1.Image = Properties.Resources.IggyAnime;
                pictureBox2.Image = Properties.Resources.IggyManga;
                pictureBox3.Image = Properties.Resources.IggyManga2;
                pictureBox4.Image = Properties.Resources.IggyAnime2;
                pictureBox5.Image = Properties.Resources.Louco;
                pictureBox6.Image = Properties.Resources.Louco2;
                //pictureBox7.Image = Properties.Resources.;
                pictureBox8.Image = Properties.Resources.Carta_Louco;
            }

            //STARDUST VILOES
            else if (comboBox1.Text == "Midler")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dubladora";
                checkBox4.Text = "";
                groupBox2.Text = "Sacerdotisa";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Gisele Vechin";
                label2.Text = "Midler é a última dos assassinos de DIO que os heróis encontram antes de entrar no Egito. Ela é uma usuária de Stand, e sua High Priestess ataca o grupo enquanto viajam de submarino no Mar Vermelho. A aparência de Midler é em grande parte obscurecida na história, porém ela é descrita como bonita.";
                label4.Text = "A Sacerdotisa tem a problemática capacidade de se transformar ou assimilar em qualquer coisa composta por minerais, até mesmo algo tão grande quanto um leito marinho.\r\nSeu tamanho pequeno e agilidade dificultam os golpes, e suas garras são muito perigosas. A High Priestess possui a habilidade de mudar de forma e assimilar-se em qualquer tipo de matéria inorgânica, seja metal, vidro ou plástico. Além disso, ele também pode replicar estruturas bastante complexas.";
                label3.Text = "O Stand de Midler é uma referência a carta 2 do tarot, A Sacerdotisa.";
                pictureBox1.Image = Properties.Resources.MidlerAnime;
                pictureBox2.Image = Properties.Resources.MidlerManga ;
                pictureBox3.Image = Properties.Resources.MidlerJogo ;
                pictureBox4.Image = Properties.Resources.MidlerManga2;
                pictureBox5.Image = Properties.Resources.SacerdotisaAnime2 ;
                pictureBox6.Image = Properties.Resources.SacerdotisaManga;
               // pictureBox7.Image = Properties.Resources.;
                pictureBox8.Image = Properties.Resources.Carta_Sacerdotisa;
            }
            else if (comboBox1.Text == "Nena")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dubladora";
                checkBox4.Text = "";
                groupBox2.Text = "Imperatriz";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Glaucia Franchi";
                label2.Text = "Nena aparece pela primeira vez na Índia ao lado de Hol Horse e tenta assassinar Joseph Joestar enquanto se passa por uma mulher comum. Ela é uma usuária de Stand que empunha a Imperatriz. Nena também esconde sua verdadeira forma assimilando a pele de outra mulher mais bonita com seu Stand e usa sua boa aparência para enganar seus alvos fazendo-os pensar que ela é uma mulher inocente e se aproximar deles para plantar a Imperatriz neles.";
                label4.Text = "Empress é um Stand parasita que cresce a partir da carne de sua vítima, eventualmente dominando-a.\r\nA Imperatriz deve primeiro ser plantada em outra pessoa por contato direto com o sangue de Nena, mas pode ser controlada remotamente por ela.\r\nA zona respingada de sangue desenvolverá um botão carnudo, semelhante em aparência a uma verruga. A Imperatriz então cresce lenta e continuamente a partir da carne da vítima, alimentando-se de fontes externas em relação ao seu tamanho, sejam pequenos insetos, frutas ou galinhas inteiras quando for forte o suficiente. A Imperatriz eventualmente alcançará uma pequena forma humanóide e tentará constantemente atrapalhar, ferir ou matar seu hospedeiro.";
                label3.Text = "O Stand de Nena é uma referência a carta 3 do tarot, A Imperatriz.";
                pictureBox8.Image = Properties.Resources.Carta_Imperatirz;
                pictureBox1.Image = Properties.Resources.NenaAnime;
                pictureBox2.Image = Properties.Resources.NenaManga;
                pictureBox3.Image = Properties.Resources.NenaAnime2;
                pictureBox4.Image = Properties.Resources.NenaManga2;
                pictureBox5.Image = Properties.Resources.ImperatrizAnime;
                pictureBox6.Image = Properties.Resources.ImperatrizManga;
               // pictureBox7.Image = Properties.Resources.;
            }
            else if (comboBox1.Text == "Hol Horse")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Imperador";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Thiago Zambrano";
                label2.Text = "Hol Horse é um assassino contratado por DIO que trabalha junto de seu parceiro, J. Geil, para eliminar o Grupo Joestar. Empunhando o Stand arma, Emperor, Hol Horse é capaz de disparar em seus oponentes com balas que ele pode controlar. \r\nHol Horse é retratado como um pistoleiro ocidental, sendo corajoso e mulherengo. Em contraste, seu medo se manifesta quando ele está sob pressão. Ele é um enganador astuto e ótimo oportunista, tendendo a depender dos outros assim como de sorte para salvar a si mesmo.\r\n";
                label4.Text = "O Imperador assume a forma de uma arma que o usuário pode invocar em sua mão, permitindo que ele atire em seus inimigos com balas controláveis.\r\nO aspecto característico e mais perigoso de Emperor é sua capacidade de controlar livremente a trajetória de suas balas, já que elas também fazem parte do Stand. Embora tenha um alcance melhor que a média para um Stand de Curto Alcance, a eficácia do Imperador ainda cai rapidamente à medida que as balas atingem os limites desse alcance.";
                label3.Text = "O Stand de Hol Horse é uma referência a carta 4 do tarot, O Imperador.";
                pictureBox1.Image = Properties.Resources.HolHorseAnime;
                pictureBox2.Image = Properties.Resources.HolHorseManga;
                pictureBox3.Image = Properties.Resources.HolHorseManga2;
                pictureBox4.Image = Properties.Resources.HolHorseAnime2;
                pictureBox5.Image = Properties.Resources.Imperador;
                pictureBox6.Image = Properties.Resources.Imperador2;
               // pictureBox7.Image = Properties.Resources.;
                pictureBox8.Image = Properties.Resources.Carta_Imperador;
            }
            else if (comboBox1.Text == "Steely Dan")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Amantes";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Marcelo Campos";
                label2.Text = "Steely Dan é um mercenário trabalhando para DIO enviado para matar Enya a Velha. Um usuário de Stand portador do microscópico Lovers, ele confronta o Grupo Joestar no Paquistão.\r\nEle cruelmente mata Enya, dizendo em sua cara que DIO ordenou sua execução, o que a chocou.\r\n\r\n";
                label4.Text = "Lovers é um Stand humanoide minúsculo com características insectoides. A habilidade primária do Lovers é entrar no cérebro de sua vítima e manipular seus receptores de dor Quando Steely Dan sente qualquer estimulo físico, seja a dor de um soco, ou até a sensação de estralar seus dedos, Lovers irá enlouquecer dentro do cérebro e retornar a dor vezes mais à sua vítima, fazendo com que eles fiquem agoniados.\r\nPor causa de seu tamanho microscópico, Lovers é muito vulnerável por si só. Entretanto, sua habilidade de infiltrar o cérebro o torna um Stand formidável e elusivo que é muito difícil de alcançar e seu alcance de centenas de quilômetros torna qualquer fuga em uma impossibilidade.\r\n";
                label3.Text = "O Stand de Steely Dan é uma referência a carta 6 do tarot, Os Amantes.";
                pictureBox1.Image = Properties.Resources.SteelyDanAnime;
                pictureBox2.Image = Properties.Resources.SteelyDanManga;
                pictureBox3.Image = Properties.Resources.SteelyDanManga2;
                pictureBox4.Image = Properties.Resources.SteelyDanManga3;
                pictureBox5.Image = Properties.Resources.Lovers;
                pictureBox6.Image = Properties.Resources.Lovers2;
                //pictureBox7.Image = Properties.Resources.;
                pictureBox8.Image = Properties.Resources.Carta_Amantes;

            }
            else if (comboBox1.Text == "Forever")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Força";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Paulo Ávila";
                label2.Text = "Forever é um orangotango malicioso sob o serviço de DIO que confronta o grupo no Mar da China Meridional à bordo de um navio cargueiro. Dito navio é revelado estar possuido pelo Stand do Forever: Strength. Forever irá algumas vezes agir como um ser humano. Ele parece sentir atração por fêmeas humanas - ele vê revistas pornográficas e parece desejar a Merlai Anne. Ele também fuma cigarros e pode cortar suas próprias maçãs, mostrando uma inteligência anormalmente alta para um orangotango. Além disso, ele pode ler e resolver quebra-cabeças como um cubo mágico.\r\n";
                label4.Text = "Como um Stand Materializado, Força tem a habilidade de se fundir a um barco e o transformar em um cargueiro. Seu usuário então é capaz de manipular o navio como quiser.\r\nStrength é um Stand incrivelmente poderoso usado para pegar seus inimigos de surpresa.\r\n";
                label3.Text = "O Stand de Forever é uma referência a carta 8 do tarot, A Força.";
                pictureBox1.Image = Properties.Resources.ForeverAnime;
                pictureBox2.Image = Properties.Resources.ForeverManga ;
                pictureBox3.Image = Properties.Resources.ForeverManga2 ;
                pictureBox4.Image = Properties.Resources.ForeverAnime2 ;
                pictureBox5.Image = Properties.Resources.Forca;
                pictureBox6.Image = Properties.Resources.Forca2;
                //pictureBox7.Image = Properties.Resources.;
                pictureBox8.Image = Properties.Resources.Carta_Forca;
            }
            else if (comboBox1.Text == "ZZ")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Roda da Fortuna";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Rodrigo Araújo";
                label2.Text = "ZZ é um dos mercenários do DIO que enfrenta o Grupo Joestar na estrada para o Paquistão. Ele é um usuário de Stand que dirige seu Stand veicular, Wheel of Fortune.\r\n Ele parece ser um inimigo perigoso e inteligente, e com apenas os braços estendidos para fora do carro, também pode parecer fisicamente imponente. No entanto, ZZ é simplesmente um usuário arrogante e covarde.\r\n";
                label4.Text = "Whell of Fortune é um Stand que se manifesta usando um carro como catalisador, melhorando dramaticamente a aparência e as capacidades do veículo. Ela permite que até um carro comum e caindo aos pedaços se transforme em uma carroceria potente. O carro também é capaz de se reparar, distorcer seu casco para se espremer dentro de uma fenda, orientar as rodas horizontalmente para passar entre paredes, criar espinhos nas rodas para escalar um penhasco e até separar sua fiação interna para criar faíscas perigosas.\r\nWheel of Fortune pode disparar sua própria gasolina nos oponentes como um tiro disperso de alta pressão. ";
                label3.Text = "O Stand de ZZ é uma referência a carta 10 do tarot, A Roda da Fortuna.";
                pictureBox1.Image = Properties.Resources.ZZAnime;
                pictureBox2.Image = Properties.Resources.ZZManga;
                pictureBox3.Image = Properties.Resources.ZZManga2 ;
                pictureBox4.Image = Properties.Resources.ZZAnime2 ;
                pictureBox5.Image = Properties.Resources.RodaDaFortuna ;
                pictureBox6.Image = Properties.Resources.RodaDaFortuna2 ;
               // pictureBox7.Image = Properties.Resources.;
                pictureBox8.Image = Properties.Resources.Carta_Roda_da_Fortuna;
            }
            else if (comboBox1.Text == "Enya")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dubladora";
                checkBox4.Text = "";
                groupBox2.Text = "Justiça";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Cecília Lemes";
                label2.Text = "Enya tem uma posição alta entre as pessoas de confiança de DIO. Ela é a mãe de J. Geil; e após a morte de seu filho, embosca o grupo de Jotaro sozinha com a ajuda de seu Stand de névoa, Justice.É revelado que ela teve um papel chave em desenvolver a população de usuários de Stand quando ela adquiriu o Arco e Flecha, e em Vento Aureo é revelado que ela comprou ditas flechas de Diavolo.\r\n";
                label4.Text = "Justiça é um Stand de neblina comumente na forma de uma caveira coroada e mãos. É terrivelmente poderoso por causa de sua natureza e poder. Justice é um dos Stands mais poderosos da série devido à sua semi-invulnerabilidade, como um Stand de neblina, e sua habilidade de controlar o corpo de alguém por meio de uma ferida aberta.\r\nustice pode manifestar ilusões incrivelmente detalhadas e realistas em qualquer lugar dentro de seu alcance.\r\nEnya foi capaz de gerar uma cidade ilusória inteira sobre um cemitério, com a impressão de construções sólidas e reais, que só sumiram quando ela foi derrotada.\r\n";
                label3.Text = "O Stand de Enya é uma referência a carta 11 do tarot, A Justiça.";
                pictureBox1.Image = Properties.Resources.EnyaAnime;
                pictureBox2.Image = Properties.Resources.EnyaManga;
                pictureBox3.Image = Properties.Resources.EnyaManga2;
                pictureBox4.Image = Properties.Resources.EnyaManga3;
                pictureBox5.Image = Properties.Resources.Justica;
                pictureBox6.Image = Properties.Resources.Justica2;
                //pictureBox7.Image = Properties.Resources.;
                pictureBox8.Image = Properties.Resources.Carta_Justica;
            }
            else if (comboBox1.Text == "J. Geil")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Enforcado";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Sidney César";
                label2.Text = "J. Geil é um assassino, filho da conselheira de DIO, Enya, enviado junto de Hol Horse para matar o Grupo Joestar. Ele também é o assassino de Chérie Polnareff e o homem que Jean Pierre Polnareff busca para vingá-la. J. Geil é um usuário de Stand e o portador do Hanged Man.\r\nÉ conhecido que J. Geil estuprou e matou várias mulheres durante sua vida, incluindo Chérie Polnareff, a irmã de Jean Pierre Polnareff. Pode ser assumido que ele também é bastante sádico já que ele alega que os gritos de Chérie foram como música para seus ouvidos.\r\n";
                label4.Text = "Hanged Man é um Stand humanoide com a aparência de um ghoul enfaixado. Hanged Man é um Stand que ataca por reflexos. Em vez de atacar uma pessoa diretamente, ele aparecerá em uma superfície reflexiva e atacará seu reflexo. O Enforcado pode se mover através de qualquer tipo de superfície refletora na velocidade da luz. Ele possui um alcance incrivelmente longo.\r\nSua fraqueza é que ele só pode se mover entre superfícies refletoras em um padrão linear e é forçado a se mover para outro reflexo à sua frente se sua localização atual parar de refletir.";
                label3.Text = "O Stand de J.Geil é uma referência a carta 12 do tarot, O Enforcado/O Pendurado.";
                pictureBox8.Image = Properties.Resources.Carta__Enforcado;
            }
            else if (comboBox1.Text == "Manish Boy")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Morte Treze";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Vii Zedek";
                label2.Text = "Mannish Boy é um bebê gênio do mal e usuário do Stand a serviço de DIO. Ele tenta assassinar o Grupo Joestar dentro do mundo de pesadelo do seu Death Thirteen.\r\nMannish Boy é um gênio impossível: embora seja um bebê, ele pensa e se comporta como muito mais velho. Em público, Mannish Boy esconde seu verdadeiro eu e age como um bebê comum para despistar as pessoas.\r\n";
                label4.Text = "Ele tem o poder formidável de atacar suas vítimas em seus sonhos, atraindo seus espíritos para seu próprio mundo de pesadelo, onde elas não têm poder para retaliar.\r\nMorte Treze é única porque só pode existir dentro de um mundo de sonhos e, portanto, exige que suas vítimas estejam dormindo.\r\nDeath Thirteen tem controle total sobre esse mundo dos sonhos. Ele é capaz de criar máquinas de morte com itens mecânicos, invocar objetos do nada, manipular o cabelo de Polnareff ou a mão de Joseph, basicamente moldando tudo como achar melhor. No entanto, a característica mais notável desse mundo dos sonhos é que os usuários de Stand não podem invocar seu Stand dentro do mundo dos sonhos e ficam indefesos.\r\n";
                label3.Text = "O Stand de Mannish Boy é uma referência a carta 13 do tarot, A Morte.";
                pictureBox8.Image = Properties.Resources.Carta_Morte;
            }
            else if (comboBox1.Text == "Rubber Soul")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Yellow Temperance";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Raphael Rossatto";
                label2.Text = "Passando por Kakyoin, Rubber Soul isola e ataca Jotaro e Merlai Anne em Singapura. Rubber Soul é o usuário de Stand do Yellow Temperance.\r\nRubber Soul é um mercenário grosseiro e narcisista. Ele se orgulha da aparente invencibilidade de seu Stand, chegando a comprometer sua identidade só para irritar Jotaro. Ao contrário da maioria dos agentes de DIO, Rubber Soul não tem lealdade real ao vampiro e foi atraído com a promessa de ganhar 100 milhões de dólares como recompensa por atacar o Grupo Joestar.";
                label4.Text = "Yellow Temperance é um Stand em forma de massa que consome carne para crescer de tamanho. Ele pode se enrolar ao redor do usuário para fornecer tanto um disfarce quanto uma defesa impenetrável.O tamanho do disfarce aumenta proporcionalmente ao quanto o stand consome. Apesar de quase invencivel, Yellow Temperance é limitado pelas vulnerabilidades humanas de seu próprio usuário, a ponto de se dizer que seu único ponto fraco é Rubber Soul.\r\n";
                label3.Text = "O Stand de Rubber Soul é uma referência a carta 14 do tarot, A Temperança.\r\n";
                pictureBox8.Image = Properties.Resources.Carta_Temperanca;
            }
            else if (comboBox1.Text == "Devo")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "O Diabo";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Glauco Marques";
                label2.Text = "Devo, o Amaldiçoado, é um infame xamã nativo americano e assassino que trabalha para o DIO, ele embosca Jean Pierre Polnareff em seu quarto de hotel em Singapura. Devo é o usuário do Stand Ebony Devil.\r\nQuando atacado, ele demonstra uma espécie de masoquismo, rindo e se deleitando com a dor excruciante porque adora se vingar de ferimentos.";
                label4.Text = "Ebony Devil é capaz de possuir um boneco, concedendo ao usuário seu controle remoto. O poder e velocidade do boneco aumentam com base no ressentimento que Devo sente pelo seu alvo.\r\nA forma original do Stand tem um alcance extremamente curto e limitado. Porém, quando ativado, ele pode agir independentemente e longe de Devo, tornando-se um bom assassino autômono\r\n";
                label3.Text = "O Stand de Devo é uma referência a carta 15 do tarot, O Diabo.";
                pictureBox8.Image = Properties.Resources.Carta_Diabo;
            }
            else if (comboBox1.Text == "Capitão Tennille")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Lua Azul Escura";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Mauro Eduardo Lima";
                label2.Text = "O Falso Capitão Tennille é um assassino enviado por DIO que luta contra o Grupo Joestar no meio do oceano à caminho do Egito. Ele é um usuário de Stand e o portador do Dark Blue Moon. Embora o verdadeiro Capitão Tennille nunca é visto, pode se assumir que possuía uma aparência praticamente idêntica a do impostor.\r\n";
                label4.Text = "Dark Blue Moon é um Stand humanoide poderoso com um físico parecido ao de um peixe, cujas capacidades são maximizadas debaixo d'água. Suas habilidades vão desde criar cracas drenadoras de poder até criar redemoinhos.\r\nDark Blue Moon é um Stand marinho e, devido a isso, suas habilidades são mais efetivas em um ambiente aquático.\r\nDark Blue Moon é capaz de criar cracas que grudam e absorvem a energia da vítima e também cedem a Dark Blue Moon um pequeno controle sob a parte infectada, o permitindo trazer seus inimigos de volta à água caso eles tentem fugir.\r\n";
                label3.Text = "O Stand do Falso Capitão é uma referência a carta 18 do tarot, A Lua.";
                pictureBox8.Image = Properties.Resources.Carta_Lua;
            }
            else if (comboBox1.Text == "Arabia Fats")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Sol";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Manabu Sakamaki";
                label2.Text = "Arabia Fats é um agente de DIO, que embosca o Grupo Joestar no meio do deserto árabe com seu Stand, Sun.\r\nA personalidade de Arabia Fats nunca é totalmente mostrada devido à rapidez com que ele é derrotado, mas ele é mostrado como um usuário de Stand bem preparado, paciente e imoral, disposto a esperar o tempo que for necessário para que o Grupo Joestar morra por causa de seu Stand.";
                label4.Text = "Sun assume a aparência de um pequeno sol que irradia calor escaldante e pode disparar feixes concentrados contra suas vítimas.\r\nSun é um Stand incrivelmente poderoso, com uma grande variedade de ação. No entanto, não faz nada para proteger seu usuário, que deve permanecer por perto e se esconder.\r\nO poder principal do Sol é emitir luz e calor em níveis letais por uma grande área.\r\nAlém de brilhar forte o suficiente para dar a impressão de estar no meio de um dia claro, apesar do horário indicar que é noite, ele também eleva as temperaturas ao redor até 80 °C. Além disso, pode manter esse nível de poder por um longo período, já que Arabia Fats estava disposto a perseguir o grupo Joestar e deixá-los morrer pelo calor do Sol.";
                label3.Text = "O Stand de Arabia Fats é uma referência a carta 19 do tarot, O Sol.";
                pictureBox8.Image = Properties.Resources.Carta_Sol;
            }
            else if (comboBox1.Text == "Cameo")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Julgamento";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Fábio Moura";
                label2.Text = "Cameo isola Polnareff do Grupo Joestar em uma ilha isolada no Mar Vermelho enquanto estão lá para resgatar Avdol. Cameo é um dos capangas de DIO e usuário de Stand que empunha o gênio Stand, Judgement.\r\nCameo é um homem cruel que finge ser um gênio usando seu Stand, Judgement.\r\n";
                label4.Text = "Julgamento é um robusto Stand humanoide mecânico bastante poderoso, com força e velocidade acima da média no que diz respeito aos Stands.\r\nO principal poder do julgamento é conceder desejos falsificados àqueles que o solicitam. Ele cria construções de argila com tudo o que o decorrente pedir. Essas construções de argila são quase perfeitas em relação ao original, como moedas de ouro falsas que têm peso, aparência e sensação semelhantes ao ouro real.Judgement usa suas construções de argila para enganar alvos ingênuos e fazê-los confiar nele, mas também para atacá-los enquanto eles não conseguem revidar.\r\n";
                label3.Text = "O Stand de Cameo é uma referência a carta 20 do tarot, O Julgamento.";
                pictureBox8.Image = Properties.Resources.Carta_Julgamento;
            }
            else if (comboBox1.Text == "Gray Fly")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "A Torre de Cinzas";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Carlos Campanile";
                label2.Text = "Gray Fly é um assassino enviado por DIO que ataca o grupo a bordo de um avião que viaja de Tóquio para o Cairo, eventualmente caindo no oceano próximo a Hong Kong. Ele é um usuário de Stand e possui a Torre de Cinzas.\r\nEmbora pareça um velho desavisado, Gray Fly é um dos muitos mercenários sádicos de DIO, ele é um ladrão responsável por inúmeros acidentes fatais e planeja todos os seus crimes para parecer acidentes.\r\n";
                label4.Text = "Especializado em fazer com que ataques pareçam acidentes, detém a forma de um lucano gigante com uma segunda mandíbula e a habilidade de se locomover em alta velocidade.\r\nTower of Gray é um Stand pequeno e frágil. Porém, ele também é absurdamente rápido e ágil, e sua mandíbula secundária lhe garante um mega poder destrutivo oculto bem discreto.\r\n";
                label3.Text = "O Stand de Gray Fly é uma referência a carta 16 do tarot, A Torre.";
                pictureBox8.Image = Properties.Resources.Carta_Torre;
            }

            else if (comboBox1.Text == "Vanilla Ice")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Cream";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Alfredo Rollo";
                label2.Text = "";
                label4.Text = "";
                label3.Text = "";
            }
            else if (comboBox1.Text == "N'Doul")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Geb";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Wellington Lima";
            }
            else if (comboBox1.Text == "Oingo")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Quenum";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Rodrigo Nanal";
            }
            else if (comboBox1.Text == "Boingo")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dubladora";
                checkBox4.Text = "";
                groupBox2.Text = "Tote";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Angélica Santos";
            }
            else if (comboBox1.Text == "Anubis")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Anubis";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Wesley Santana";
            }
            else if (comboBox1.Text == "Mariah")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dubladora";
                checkBox4.Text = "";
                groupBox2.Text = "Bastet";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Carla Martelli";
            }
            else if (comboBox1.Text == "Alessi")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Set";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Fábio de Castro";
            }
            else if (comboBox1.Text == "Daniel J. D'arby")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Osiris";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Hélio Ribeiro";
            }
            else if (comboBox1.Text == "Telence T. D'arby")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Atum";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Marcelo Garcia";
            }
            else if (comboBox1.Text == "Pet Shop")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Hórus";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Não possui dublador";
            }
            else if (comboBox1.Text == "Dio")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Morte";
                groupBox2.Text = "O Mundo";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Francisco Júnior";
            }
            //GOLDEN WIND HEROIS
            else if (comboBox1.Text == "Giorno Giovanna")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Curiosidade";
                groupBox2.Text = "Golden Wind";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Vagner Fagundes";
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
                groupBox2.Text = "Li'l Bomber";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Marcus Pejon";
            }
            else if (comboBox1.Text == "Pannacota Fugo")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Curiosidade";
                groupBox2.Text = "Purple Smoke";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Marcio Vaz";
            }
            else if (comboBox1.Text == "Leone Abbacchio")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Morte";
                groupBox2.Text = "Moody Jazz";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "André Sauer";
            }
            else if (comboBox1.Text == "Guido Mista")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Curiosidade";
                groupBox2.Text = "Six Bullets";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "William Viana";
            }
            else if (comboBox1.Text == "Trish")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dubladora";
                checkBox4.Text = "Curiosidade";
                groupBox2.Text = "Spice Lady";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Bianca Alencar";
            }
            //GOLDEN WIND VILÕES
            else if (comboBox1.Text == "Polpo")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Morte";
                groupBox2.Text = "Shadow Sabbath";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Luiz Carlos Persy";
            }
            else if (comboBox1.Text == "Mario Zucherro")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Tender Machine";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Renato Soares";
            }
            else if (comboBox1.Text == "Sale")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Arts & Crafts";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Rodrigo Andreatto";
            }
            else if (comboBox1.Text == "Formaggio")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Tiny Feet";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Márcio Araújo";
            }
            else if (comboBox1.Text == "Illuso")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Mirror Man";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Douglas Guedes";
            }
            else if (comboBox1.Text == "Prosciutto")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "The Thankful Dead";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Guilherme Marques";
            }
            else if (comboBox1.Text == "Pesci")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Fisher Man";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Rogério César";
            }
            else if (comboBox1.Text == "Melone")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Babyhead";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Robson Kumode";
            }
            else if (comboBox1.Text == "Ghiaccio")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "White Ice";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Vinícius Fagundes";
            }
            else if (comboBox1.Text == "Squalo")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Crush";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Gustavo Vergani";
            }
            else if (comboBox1.Text == "Tiziano")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Talking Mouth";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Charles Dalla";
            }
            else if (comboBox1.Text == "Carne")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Morte";
                groupBox2.Text = "Notorious Chase";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Miguel de Britto";
            }
            else if (comboBox1.Text == "Risotto Nero")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Metallic";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Reginaldo Primo";
            }
            else if (comboBox1.Text == "Cioccolatta")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Green Tea";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Glauco Marques";
            }
            else if (comboBox1.Text == "Secco")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Sanctuary";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Wallace Raj";
            }
            else if (comboBox1.Text == "Doppio")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Morte";
                groupBox2.Text = "Emperor Crimson";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Ítalo Luiz";
            }
            else if (comboBox1.Text == "Diavolo")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Morte";
                groupBox2.Text = "Emperor Crimson";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Felipe Zilse";
            }
            //STONE OCEAN HEROIS
            else if (comboBox1.Text == "Jolyne Kujo")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dubladora";
                checkBox4.Text = "";
                groupBox2.Text = "Stone Ocean";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Patt Souza";
            }
            else if (comboBox1.Text == "Jotaro Kujo")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Star Platinum";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Wilken Mazzai";
            }
            else if (comboBox1.Text == "Ermes Costello")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dubladora";
                checkBox4.Text = "";
                groupBox2.Text = "Smack";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Tatiane Keplmair";
            }
            else if (comboBox1.Text == "F.F")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dubladora";
                checkBox4.Text = "";
                groupBox2.Text = "F.F";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Vii Zedek";
            }
            else if (comboBox1.Text == "Anastasia")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Diver Drive";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Márcio Araújo";
            }
            else if (comboBox1.Text == "Wheater Forecast")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Wheather Forecast";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Gabriel Noya";
            }
            else if (comboBox1.Text == "Emporio Alnino")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Burn the House Down";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Gabriel Martins";
            }
            //STONCE OCEAN VILÕES
            else if (comboBox1.Text == "Gwess")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dubladora";
                checkBox4.Text = "";
                groupBox2.Text = "GG Dolls";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Flora Paulita";
            }
            else if (comboBox1.Text == "Jongalli A")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Downtown Transfer";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Fernando Lopes";
            }
            else if (comboBox1.Text == "Thunder McQueen")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Freeway Thru Hell";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Clécio Souto";
            }
            else if (comboBox1.Text == "Miraschon")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dubladora";
                checkBox4.Text = "";
                groupBox2.Text = "Mary Lynn Manson";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Fernanda Bellara";
            }
            else if (comboBox1.Text == "Lang Rangler")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Jumping Jack Spark";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Philippe Maia";
            }
            else if (comboBox1.Text == "Sports Maximum")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Limp Viscuit";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Rodrigo Nanal";
            }
            else if (comboBox1.Text == "Viviano Westwood")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Starlight Waves";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Glauco Marques";
            }
            else if (comboBox1.Text == "Kenzou")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Drake's Dream";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Hélio Vaccari";
            }
            else if (comboBox1.Text == "Gucci")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Survivor";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Marco Aurélio Campos";
            }
            else if (comboBox1.Text == "D&G")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "YA-YA MA";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Marco Antônio Abreu";
            }
            else if (comboBox1.Text == "Bêbe verde")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Green, Green, Green Home";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "";
            }
            else if (comboBox1.Text == "Miu Miu")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dubladora";
                checkBox4.Text = "";
                groupBox2.Text = "Jailhouse Lock";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Rebeca Zadra";
            }
            else if (comboBox1.Text == "Ungalo")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Bohemian Ecstatic";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Yan Gesteira";
            }
            else if (comboBox1.Text == "Rikiel")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Sky Guy";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Fábio Lucindo";
            }
            else if (comboBox1.Text == "Versus")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "NetherWorld";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Renan Freitas";
            }
            else if (comboBox1.Text == "Enrico Pucci")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Morte";
                groupBox2.Text = "Pale Snake - Madein Heaven";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Duda Espinoza";
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
            
            label4.Visible = true;

            if(checkBox1.Checked == false){
             groupBox3.Visible = false;
             pictureBox8.Visible = false;
            
             label4.Visible = false;
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}


