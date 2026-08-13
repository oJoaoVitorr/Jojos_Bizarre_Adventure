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
            if (listBox1.Text == "GOLDEN WIND")
            {
                this.BackgroundImage = Properties.Resources.WallpaperGoldenAll;
                label1.Text = "Golden Wind é a quinta parte de JoJo's Bizarre Adventure, serializada na Weekly Shōnen Jump de dezembro de" +
                    " 1995 a abril de 1999. O arco abrange um total de 155 capítulos e ocorre após Diamond is Unbreakable.";
            }
            else if (listBox1.Text == "STARDUST CRUSADERS")
            { 
                this.BackgroundImage = Properties.Resources.WallpaperStardust;

            }
            else if (listBox1.Text == "STONE OCEAN")
            {
                this.BackgroundImage = Properties.Resources.WallpaperStone;
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
                comboBox1.Items.Add("Gray Fly");
                comboBox1.Items.Add("Capitão Tennille");
                comboBox1.Items.Add("Forever");
                comboBox1.Items.Add("Devo");
                comboBox1.Items.Add("Rubber Soul");
                comboBox1.Items.Add("Hol Horse");
                comboBox1.Items.Add("J. Geil");
                comboBox1.Items.Add("Nena");
                comboBox1.Items.Add("ZZ");
                comboBox1.Items.Add("Enya");
                comboBox1.Items.Add("Steely Dan");
                comboBox1.Items.Add("Arabia Fats");
                comboBox1.Items.Add("Manish Boy");
                comboBox1.Items.Add("Cameo");
                comboBox1.Items.Add("Midler");
                comboBox1.Items.Add("N'Doul");
                comboBox1.Items.Add("Boingo");
                comboBox1.Items.Add("Oingo");
                comboBox1.Items.Add("Anubis");
                comboBox1.Items.Add("Mariah");
                comboBox1.Items.Add("Alessi");
                comboBox1.Items.Add("Daniel J. D'Arby");
                comboBox1.Items.Add("Pet Shop");
                comboBox1.Items.Add("Telence T. D'Arby");
                comboBox1.Items.Add("Vanilla Ice");
                comboBox1.Items.Add("DIO");


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
                comboBox1.Items.Add("Diavolo");
                comboBox1.Items.Add("Doppio");

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
            if (comboBox1.Text == "Jotaro Kujo" && listBox1.Text=="STARDUST CRUSADERS")
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
                pictureBox1.Image = Properties.Resources.jotaromanga;
                pictureBox2.Image = Properties.Resources.jotaroanime;
                pictureBox3.Image = Properties.Resources.jotaroanime2;
                pictureBox4.Image = Properties.Resources.jotaromangac;
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
                pictureBox1.Image = Properties.Resources.JosephManga;
                pictureBox2.Image = Properties.Resources.JosephAnime;
                pictureBox3.Image = Properties.Resources.JosephAnime2;
                pictureBox4.Image = Properties.Resources.JosephManga2;
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
                pictureBox1.Image = Properties.Resources.KakyoinManga;
                pictureBox2.Image = Properties.Resources.KakyoinAnime;
                pictureBox3.Image = Properties.Resources.KakyoinAnime2;
                pictureBox4.Image = Properties.Resources.KakyoinManga2;
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
                pictureBox1.Image = Properties.Resources.PolnareffManga;
                pictureBox2.Image = Properties.Resources.PolnareffAnime;
                pictureBox3.Image = Properties.Resources.PolnareffAnime2;
                pictureBox4.Image = Properties.Resources.PolnareffManga2;
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
                pictureBox1.Image = Properties.Resources.AvdolManga;
                pictureBox2.Image = Properties.Resources.AvdolAnime;
                pictureBox3.Image = Properties.Resources.AvdolAnime2;
                pictureBox4.Image = Properties.Resources.AvdolManga2;
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
                pictureBox1.Image = Properties.Resources.IggyManga;
                pictureBox2.Image = Properties.Resources.IggyAnime;
                pictureBox3.Image = Properties.Resources.IggyAnime2;
                pictureBox4.Image = Properties.Resources.IggyManga2;
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
                pictureBox1.Image = Properties.Resources.MidlerManga;
                pictureBox2.Image = Properties.Resources.MidlerAnime;
                pictureBox3.Image = Properties.Resources.MidlerManga2;
                pictureBox4.Image = Properties.Resources.MidlerJogo;
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
                pictureBox1.Image = Properties.Resources.NenaManga;
                pictureBox2.Image = Properties.Resources.NenaAnime;
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
                pictureBox1.Image = Properties.Resources.HolHorseManga;
                pictureBox2.Image = Properties.Resources.HolHorseAnime;
                pictureBox3.Image = Properties.Resources.HolHorseAnime2;
                pictureBox4.Image = Properties.Resources.HolHorseManga2;
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
                pictureBox1.Image = Properties.Resources.SteelyDanManga;
                pictureBox2.Image = Properties.Resources.SteelyDanAnime;
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
                pictureBox1.Image = Properties.Resources.ForeverManga;
                pictureBox2.Image = Properties.Resources.ForeverAnime ;
                pictureBox3.Image = Properties.Resources.ForeverAnime2 ;
                pictureBox4.Image = Properties.Resources.ForeverManga2 ;
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
                pictureBox1.Image = Properties.Resources.ZZManga;
                pictureBox2.Image = Properties.Resources.ZZAnime;
                pictureBox3.Image = Properties.Resources.ZZAnime2 ;
                pictureBox4.Image = Properties.Resources.ZZManga2 ;
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
                pictureBox1.Image = Properties.Resources.EnyaManga;
                pictureBox2.Image = Properties.Resources.EnyaAnime;
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
                pictureBox1.Image = Properties.Resources.JGeilManga;
                pictureBox2.Image = Properties.Resources.JGeilAnime ;
                pictureBox3.Image = Properties.Resources.JGeilAnime2;
                pictureBox4.Image = Properties.Resources.JGeilManga2;
                pictureBox5.Image = Properties.Resources.EnforcadoManga2;
                pictureBox6.Image = Properties.Resources.EnforcadoManga3;
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
                pictureBox1.Image = Properties.Resources.MannishBoyManga;
                pictureBox2.Image = Properties.Resources.MannishBoyAnime;
                pictureBox3.Image = Properties.Resources.MannishBoyManga2;
                pictureBox4.Image = Properties.Resources.MannishBoyAnime2;
                pictureBox5.Image = Properties.Resources.MorteManga;
                pictureBox6.Image = Properties.Resources.MorteMangaa;
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
                pictureBox1.Image = Properties.Resources.RubberSoulManga;
                pictureBox2.Image = Properties.Resources.RubberSoulAnime;
                pictureBox3.Image = Properties.Resources.RubberSoulAnime2;
                pictureBox4.Image = Properties.Resources.RubberSoulManga2;
                pictureBox5.Image = Properties.Resources.YellowTemperance;
                pictureBox6.Image = Properties.Resources.YellowTemperance2;
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
                pictureBox1.Image = Properties.Resources.DevoManga;
                pictureBox2.Image = Properties.Resources.DevoAnime;
                pictureBox3.Image = Properties.Resources.DevoAnime2;
                pictureBox4.Image = Properties.Resources.DevoManga2;
                pictureBox5.Image = Properties.Resources.Diabo;
                pictureBox6.Image = Properties.Resources.Diabo2;
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
                pictureBox1.Image = Properties.Resources.CapitaoTManga;
                pictureBox2.Image = Properties.Resources.CapitaoTAnime;
                pictureBox3.Image = Properties.Resources.CapitaoTAnime2;
                pictureBox4.Image = Properties.Resources.CapitaoTManga2;
                pictureBox5.Image = Properties.Resources.LuaAzul;
                pictureBox6.Image = Properties.Resources.LuaAzul2;
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
                pictureBox1.Image = Properties.Resources.ArabiaFatsManga;
                pictureBox2.Image = Properties.Resources.ArabiaFatsManga2;
                pictureBox3.Image = Properties.Resources.ArabiaFatsManga3;
                pictureBox4.Image = Properties.Resources.ArabiaFatsAnime;
                pictureBox5.Image = Properties.Resources.Sol;
                pictureBox6.Image = Properties.Resources.Sol2;
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
                pictureBox1.Image = Properties.Resources.CameoManga;
                pictureBox2.Image = Properties.Resources.CameoAnime;
                pictureBox3.Image = Properties.Resources.CameoAnime2;
                pictureBox4.Image = Properties.Resources.CameoManga2;
                pictureBox5.Image = Properties.Resources.Julgamento;
                pictureBox6.Image = Properties.Resources.Julgamento2;
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
                pictureBox1.Image = Properties.Resources.GrayFlyManga;
                pictureBox2.Image = Properties.Resources.GrayFlyAnime;
                pictureBox3.Image = Properties.Resources.GrayFlyAnime2;
                pictureBox4.Image = Properties.Resources.GrayFlyManga2;
                pictureBox5.Image = Properties.Resources.Torre;
                pictureBox6.Image = Properties.Resources.Torre2;
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
                label2.Text = "Vanilla Ice é o último vampiro criado por DIO e um dos últimos usuários de Stand que o Grupo Joestar encara ao se infiltrar na Mansão de DIO. Após o grupo ser dividido, ele é enviado a acabar com a equipe consistindo de Avdol, Polnareff, e Iggy. Vanilla Ice é um usuário de Stand controlando sua habilidade baseada no vazio, Cream, em batalha.";
                label4.Text = "Cream é um Stand humanóide com aparência monstruosa. Sua boca leva a uma dimensão de escuridão, e se Cream se engole, ela assume a forma de uma esfera do vazio destrutiva.\r\nCream consegue se tornar um portal para uma dimensão semelhante ao vazio, que Vanilla Ice usa principalmente para desintegrar tudo em seu caminho e se esconder.\r\nO portal real está situado na boca de Cream e o modus operandi de Cream é devorar a si mesma e seu usuário para se tornar um portal flutuante em forma de bola.\r\nAo entrar em seu estado vazio, Cream é invulnerável e quase indetectável, pois existe em outra dimensão: não pode ser vista.";
                label3.Text = "Cream é o único Stand imporante da parte 3 que não possui uma referência a uma carta de tarot.\r\n";
                pictureBox1.Image = Properties.Resources.VanillaManga;
                pictureBox2.Image = Properties.Resources.VanillaManga2;
                pictureBox3.Image = Properties.Resources.VanillaAnime2;
                pictureBox4.Image = Properties.Resources.VanillaManga3;
                pictureBox5.Image = Properties.Resources.Cream;
                pictureBox6.Image = Properties.Resources.Cream2;
                pictureBox8.Image = Properties.Resources.Carta_Cream;
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
                label2.Text = "Sendo um leal assassino de DIO e o usuário do Stand Geb, ele é o primeiro dos 9 Deuses Egípcios da Glória que o Grupo Joestar encontra ao chegar no Egito e tenta matá-los no meio do deserto do Saara.\r\nN'Doul é um homem cego que, graças ao seu Stand, nunca temeu nada em sua vida inteira, nem mesmo a morte.";
                label4.Text = "Geb é um Stand de água que pode ser pilotado remotamente à distância. Sua natureza como Stand controlador de água o torna muito ágil, mas mortal, pois pode materializar uma mão com garras capaz de rasgar carne e metal, além de arrancar a cabeça de um homem.\r\nA maior força de Geb é o alcance com que pode ser controlado com precisão, permitindo que N'Doul fique a quilômetros de distância do alvo.\r\nGeb, sendo um corpo d'água, é completamente amorfo e, portanto, excepcionalmente flexível e ágil, conseguindo escapar do soco de Star Platinum ao se torcer. \r\n";
                label3.Text = "O Stand de N'Doul é uma referência ao deus egípcio, Geb, o deus da terra.\r\n";
                pictureBox1.Image = Properties.Resources.NDoulManga;
                pictureBox2.Image = Properties.Resources.NDoulAnime;
                pictureBox3.Image = Properties.Resources.NDoulManga;
                pictureBox4.Image = Properties.Resources.NDoulManga3;
                pictureBox5.Image = Properties.Resources.Geb;
                pictureBox6.Image = Properties.Resources.Geb2;
                pictureBox8.Image = Properties.Resources.Carta_Geb;
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
                label2.Text = "Como portador do Khnum dos 9 Deuses da Glória do Egito, que lhe permite disfarçar-se de outra pessoa, Oingo tenta assassinar o Grupo Joestar junto com seu irmão mais novo, Boingo.\r\nomo todos os servos de DIO, Oingo é um personagem maligno, embora de uma forma mais mesquinha que a maioria. Ele é um assassino e, portanto, não tem problema em tentar matar os heróis.\r\n";
                label4.Text = "Khnum é apenas uma habilidade que permite Oingo moldar sua face para se disfarçar de qualquer ser.\r\nKhnum permite Oingo alterar sua aparência, altura, peso, cheiro e até sua voz como quiser.\r\nPara fazer isso, Oingo molda seu rosto como se fosse argila para modificá-la.Ele não pode alterar suas roupas, mas pode alterar seu cabelo, tendo feito isso para imitar o chapéu de Jotaro em certo ponto. Segundo Oingo, ele pode voltar ao normal quando quiser, embora nunca tenha sido mostrado ele fazer isso.";
                label3.Text = "O Stand de Oingo é uma referência ao deus egípcio, Khnum, o deus do renascimento e da criação.\r\n";
                pictureBox1.Image = Properties.Resources.OingoManga;
                pictureBox2.Image = Properties.Resources.OingoJotaro;
                pictureBox3.Image = Properties.Resources.OingoAnime;
                pictureBox4.Image = Properties.Resources.OingoManga2;
                pictureBox5.Image = Properties.Resources.Quenum;
                pictureBox6.Image = Properties.Resources.Quenum2;
                pictureBox8.Image = Properties.Resources.Carta_Quenum;
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
                label2.Text = "Boingo é um jovem usuário de Stand que empunha o Stand Tohth dos 9 Deuses da Glória do Egito. Ele tenta assassinar o Grupo Joestar no Egito junto com seu irmão mais velho Oingo, e depois se une a Hol Horse para completar sua missão.\r\nEle só se sente confortável perto do irmão, Oingo, ficando perto dele e sentindo-se sozinho quando está longe dele. Seu vínculo com o irmão é tão profundo que ele promete se vingar da derrota de Oingo sozinho, o que faz Oingo se emocionar.\r\n";
                label4.Text = "Como representação do deus egípcio Thoth, o Stand assume a forma de uma história em quadrinhos que permite ao usuário ver premonições do futuro próximo.\r\nComo mera história em quadrinhos que prediga, Tote não é adequada para combate direto, mas é uma ferramenta valiosa se alguém quiser levar vantagem em qualquer situação. Graças a isso, o Grupo Joestar quase foi morto em Assuã por Oingo e no Cairo por Hol Horse.\r\nA habilidade de Tohth é prever o futuro. O livro é preenchido principalmente com páginas em branco, mas com o passar do tempo, mais páginas vão se enchendo, prevendo eventos futuros até vários minutos à frente.\r\n";
                label3.Text = "O Stand de Boingo é uma referência ao deus egípcio, Thoth, o deus do conhecimento.\r\n";
                pictureBox1.Image = Properties.Resources.BoingoManga;
                pictureBox2.Image = Properties.Resources.BoingoAnime;
                pictureBox3.Image = Properties.Resources.BoingoAnime2;
                pictureBox4.Image = Properties.Resources.BoingoManga2;
                pictureBox5.Image = Properties.Resources.Tote;
                pictureBox6.Image = Properties.Resources.Tote2;
                pictureBox8.Image = Properties.Resources.Carta_Tote;
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
                label2.Text = "É um Stand humanoide lembrando o deus Anúbis, e preso a uma espada. Ele é um Stand feito para matar com um conjunto de habilidades permitindo com que ele ele possua qualquer um e aprimore suas habilidades de luta. Anubis é único no fato de ser um Stand sem usuário que obedece a DIO e repetidamente tenta matar os membros do grupo Joestar no Egito.\r\nSeguindo a morte de seu usuário original, Caravan Serai, Anubis lealmente serve a DIO, tanto por gratidão por ter sido liberto e por ele ter sido derrotado em uma batalha pelo Stand do vampiro.\r\n";
                label4.Text = "Anubis é um Stand surpreendentemente resiliente. Mesmo que a espada seja quebrada, Anubis continuará ativo na maior parte dele, retendo seu poder completo.\r\nSe alguém desembainhar a espada, eles ouvirão Anubis falando em sua mente, os encorajando a usá-la contra todos em seu caminho. Eventualmente, eles serão completamente controlados pelo próprio Anubis, permitindo com que o Stand controle seu corpo. Mesmo que outros usuários de Stand não sejam imunes a esse feito - se o Anubis controlá-los, ele também tomará controle de seus Stands.\r\n";
                label3.Text = "Anubis é um Stand sem usuário, e uma referência ao deus egípcio Anubis, o deus da morte.";
                pictureBox1.Image = Properties.Resources.AnubisUManga;
                pictureBox2.Image = Properties.Resources.AnubisChakaManga;
                pictureBox3.Image = Properties.Resources.AnubisKhanManga;
                pictureBox4.Image = Properties.Resources.AnubisPolnareffManga;
                pictureBox5.Image = Properties.Resources.AnubisStand;
                pictureBox6.Image = Properties.Resources.AnubisStand2;
                pictureBox8.Image = Properties.Resources.Carta_Anubis;
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
                label2.Text = "Enquanto Alessi ataca Jean Pierre Polnareff e Jotaro Kujo, Mariah tenta eliminar Joseph Joestar e Muhammad Avdol magnetizando seus corpos com seu Stand, Bastet dos 9 Deuses da Glória do Egito.\r\nMariah parece uma pessoa calma e sensata. Como a maioria dos usuários do Stand, Mariah tem grande confiança em seu Bastet, principalmente no fato de que todos acabarão sucumbindo a ele com o tempo. No entanto, ela perde a calma facilmente sempre que as coisas não saem conforme o planejado.\r\n";
                label4.Text = "Bastet é um suporte em formato de tomada com um cabo visível embaixo, que pode ser colocado em qualquer superfície.\r\nBastet foi criado para voltar a curiosidade das pessoas contra eles. Não tem nenhuma habilidade de combate direto e não serve além de prender vítimas, forçando Mariah a esperar até que suas vítimas morram sozinhas. Por outro lado, é adequado para assassinatos porque, a menos que Mariah se exponha, não há como pegá-la.\r\nQuando uma pessoa toca na tomada, ela recebe um choque e se torna um ímã que atrai objetos metálicos próximos.\r\nA força magnética gradualmente se tornará mais forte, a ponto de objetos atraídos pela pessoa serem esmagados pela massa ou simplesmente empalá-los.Uma desvantagem da habilidade deste Stand é que Mariah deve manter certa distância do alvo ou o magnetismo desaparecerá.\r\n";
                label3.Text = "O Stand de Mariah é uma referência a deusa egípcia Bastet, a deusa da proteção.\r\n";
                pictureBox1.Image = Properties.Resources.MariahManga;
                pictureBox2.Image = Properties.Resources.MariahAnime1;
                pictureBox3.Image = Properties.Resources.MariahAnime2;
                pictureBox4.Image = Properties.Resources.MariahManga2;
                pictureBox5.Image = Properties.Resources.Bastet;
                pictureBox6.Image = Properties.Resources.Bastet2;
                pictureBox8.Image = Properties.Resources.Carta_Bastet;
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
                label2.Text = "Alessi é um assassino covarde que tenta assassinar Polnareff em Luxor enquanto Mariah luta contra Joseph e Avdol. Ele é um usuário do Stand que empunha Sethan dos 9 Deuses da Glória do Egito.Alessi é um homem sádico, porém covarde, que só luta contra quem é mais fraco que ele. Ele sente um prazer extremo em provocar e humilhar seus oponentes antes de finalizá-los, e explora qualquer método desonesto para obter uma vantagem injusta.\r\n";
                label4.Text = "Pelo fato do Sethan assumir a forma da sombra de Alessi, ele imita e replica tudo o que ele faz e tem.\r\nor causa disso, qualquer arma que Alessi possua também é mantida por Sethan, permitindo que ele ataque o oponente com a sombra da arma. Além disso, a sombra pode se mover independentemente de seu possuidor e até mesmo sair parcialmente de uma superfície para atacar.\r\nQualquer um que estiver na sombra de Alessi rejuvenecerá em alta velocidade.\r\nA mente do alvo também rejuvenesce, levando suas memórias a se degradarem progressivamente em vagas lembranças de coisas que ele só saberia como adulto (como nomes de amigos ou como manifestar um Stand).\r\n";
                label3.Text = "O Stand de Alessi é uma referência ao deus Seth, o deus do caos e tempestade.";
                pictureBox1.Image = Properties.Resources.AlessiManga;
                pictureBox2.Image = Properties.Resources.AlessiAnime;
                pictureBox3.Image = Properties.Resources.AlessiManga2;
                pictureBox4.Image = Properties.Resources.AlessiManga3;
                pictureBox5.Image = Properties.Resources.Set;
                pictureBox6.Image = Properties.Resources.Set2;
                pictureBox8.Image = Properties.Resources.Carta_Set;
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
                label2.Text = "Daniel J. D'Arby é um apostador inveterado e seu Stand, Osiris, pode roubar almas. Ele é um membro dos 9 Deuses Egípcios da Glória e encontra o Grupo Joestar em Cairo. Lá, ele os convence a apostar suas almas em várias apostas. D'Arby também é o irmão mais velho de Telence T. D'Arby.\r\nA característica mais prominente de sua personalidade é seu amor por apostas. Ele afirma que vive pela emoção de apostar.\r\n";
                label4.Text = "Osíris é um Stand humanoide enorme e automático. Desde que o oponente de D'Arby concorde com suas regras, Osíris pode roubar a alma do oponente com apostas rápidas e simples.\r\nSe o perdedor apostar a alma de outra pessoa, Osíris pode tomá-la mesmo que essa pessoa não esteja presente ou concorde. Trapacear também é permitido ao apostar contra D'Arby, já que ele considera trapaça aceitável, desde que você não seja pego.\r\nQuando almas são roubadas de um corpo, esse corpo não tem mais pulso e cai em estado de morte a menos que D'Arby devolva a alma a eles.\r\nAs almas são comprimidas pelas mãos de Osíris e armazenadas na forma de fichas de pôquer, se D'Arby reconhecer a derrota, as almas que ele apostou são automaticamente liberadas.\r\n";
                label3.Text = "O Stand de Daniel J. D'Arby é uma referência ao deus egípcio Osíris, o deus da prosperidade e vida após a morte. \r\n";
                pictureBox1.Image = Properties.Resources.DanielManga;
                pictureBox2.Image = Properties.Resources.DanielAnime;
                pictureBox3.Image = Properties.Resources.DanielManga2;
                pictureBox4.Image = Properties.Resources.DanielManga3;
                pictureBox5.Image = Properties.Resources.Osiris;
                pictureBox6.Image = Properties.Resources.Osiris2;
                pictureBox8.Image = Properties.Resources.Carta_Osiris;
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
                label2.Text = "Telence é o irmão mais novo de Daniel J. D'Arby. Residindo na Mansão de DIO no Cairo e atuando como mordomo de DIO, ele isola e desafia Jotaro, Joseph e Kakyoin quando o Grupo Joestar entra na mansão e os força a lutar suas almas contra ele em vários desafios de videogame.\r\nelence é uma pessoa educada. No entanto, seu comportamento é uma fachada para sua personalidade distorcida e arrogante.\r\n";
                label4.Text = "Atum é um Stand humanoide com algumas características mecânicas.\r\nA habilidade primária de Atum permite que Telence roube almas de alguém que reconheceu derrota em um jogo, que Telence normalmente usa em vídeo-games.\r\nas vítimas devem apostar suas almas primeiro, mas Atum é sutil o suficiente para parcialmente pegar a alma de alguém surpreendido. Na teoria, Atum está livre para atacar a parte do corpo associada, mas nunca foi mostrado executando isso.\r\nA habilidade secundária de Atum permite que ele leia almas.\r\nPara executá-la, ele psíquicamente pergunta a alguém próximo uma pergunta de sim ou não, cuja a alma é obrigada a responder, sem que a pessoa que está sendo lida saiba, permitindo que Telence adivinhe as intenções de alguém.\r\n";
                label3.Text = "O Stand de Telence T. D'Arby é uma referência ao deus egípcio Atum, o deus primordial. ";
                pictureBox1.Image = Properties.Resources.TelenceManga;
                pictureBox2.Image = Properties.Resources.TelenceAnime;
                pictureBox3.Image = Properties.Resources.TelenceAnime2;
                pictureBox4.Image = Properties.Resources.TelenceManga2;
                pictureBox5.Image = Properties.Resources.Atum;
                pictureBox6.Image = Properties.Resources.Atum2;
                pictureBox8.Image = Properties.Resources.Carta_Atum;
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
                label2.Text = "Pet Shop é um falcão feroz e o guardião da mansão de DIO. Seu Stand, Horus dos 9 Deuses da Glória do Egito, permite que ele crie temperaturas criogênicas ao redor de si e forme armas a partir de gelo sólido. Quando Iggy acidentalmente encontra a mansão, a Pet Shop persegue o cachorro incansavelmente com a intenção de matar.\r\nUm sentinela implacável e leal ao seu posto, Pet Shop quase sempre exibe um olhar ameaçador e não discrimina quem invade a mansão de DIO.\r\n";
                label4.Text = "Horus raramente aparece em sua forma verdadeira, passando a maior parte do tempo preso diretamente ao corpo da Pet Shop. Quando se manifesta separadamente de seu mestre, aparece como uma grande criatura esquelética com cabeça de pterossauro.\r\nHórus dá ao seu mestre a habilidade de gerar gelo em grande quantidade e em ritmo acelerado. \r\nHorus é tão poderoso que pode gerar blocos de gelo grandes o suficiente para esmagar um carro e fazer a temperatura ao redor dele cair visivelmente apesar da atmosfera quente e seca do Egito. Em um ambiente úmido, seu verdadeiro potencial é liberado e a criocinese é ainda mais eficiente.\r\n";
                label3.Text = "O Stand de Pet Shop é uma referência ao deus egípcio Horus, o deus do céu.";
                pictureBox1.Image = Properties.Resources.PetShopManga;
                pictureBox2.Image = Properties.Resources.PetShopAnime;
                pictureBox3.Image = Properties.Resources.PetShopManga2;
                pictureBox4.Image = Properties.Resources.PetShopManga3;
                pictureBox5.Image = Properties.Resources.Horus;
                pictureBox6.Image = Properties.Resources.Horus2;
                pictureBox8.Image = Properties.Resources.Carta_Horus;
            }
            else if (comboBox1.Text == "DIO")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Morte";
                groupBox2.Text = "O Mundo";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Francisco Júnior";
                label2.Text = "Dio Brando, mais tarde simplesmente chamado de DIO, é o primeiro antagonista principal de JoJo's Bizarre Adventure. \r\nDepois de se tornar um vampiro e um usuário de Stand, Dio juntou muitos capangas entre ele e é responsável por muitos dos eventos principais da série, da morte de Jonathan Joestar à abrupta aquisição de poderes de Stand da Família Joestar, e seu legado persiste por toda a série.\r\nAs características mais reconhecíveis de Dio são sua ambição sem limites e seu amor pelo poder. \r\nDIO é um dos personagens mais poderosos na série.\r\n";
                label4.Text = "The World é um Stand extremamente poderoso e capaz de controlar o tempo manejado por um usuário igualmente poderoso, é um Stand esotérico, tanto reverenciado quanto temido por quase todos personagens em Stardust Crusaders.\r\nThe World é um Stand de curto-alcance exepcionalmente poderoso muito semelhante ao Star Platinum.\r\nO poder assinatura de O Mundo é sua habilidade de parar o tempo, permitindo que apenas ele, DIO e outra pessoa com o mesmo poder possam agir durante o tempo pausado.\r\nNo tempo parado, DIO pode mexer seu corpo livremente junto de qualquer objeto que ele toque e deseje que se mova, permitindo que ele golpeie seus inimigos indefesos, ir para uma posição melhor, e brincar com suas vítimas.\r\n";
                label3.Text = "O Stand de DIO é uma referência a carta 22 do tarot, O Mundo.";
                pictureBox1.Image = Properties.Resources.DioManga;
                pictureBox2.Image = Properties.Resources.DioAnime;
                pictureBox3.Image = Properties.Resources.DioManga2;
                pictureBox4.Image = Properties.Resources.DioManga3;
                pictureBox5.Image = Properties.Resources.OMundo;
                pictureBox6.Image = Properties.Resources.OMundo2;
                pictureBox8.Image = Properties.Resources.Carta_Mundo;
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
                label2.Text = "Giorno Giovanna é o protagonista da parte 5, é o filho ilegítimo de DIO, concebido com o corpo roubado de Jonathan Joestar. Um adolescente meio-japonês morando na Itália. Giorno fala da sua intenção de se juntar à poderosa gangue Passione e de seu sonho de se tornar um Gang-Star para trazer a virtude de volta à corrupta máfia italiana.\r\nNormalmente introvertido, Giorno frequentemente mantem uma fachada de ousadia confiante, apoiado pela sua inteligência e carisma natural, para fazê-lo parecer uma pessoa sem falhas para seus amigos.";
                label4.Text = "Gold Experience é um Stand de curto-alcance, com um alcance de 2 metros de seu usuário e pode dotar qualquer coisa que seus punhos toquem com vida, o que é traduzido para uma variedade de efeitos diferentes.\r\nO uso mais visto dessa habilidade é converter objetos inorgânicos para organismos vivos, seja um animal pequeno ou uma planta, ele pode transformar um pedaço de uma bagagem em um sapo ou um isqueiro em uma rosa.\r\nQuando qualquer um dos seres vivos criados por ele são atacados, o dano é refletido de volta para o atacante, incluindo habilidades de Stand.\r\nGold Experience pode acelerar a vida já existente de um ser vivo através de sua habilidade.\r\nGiorno descobriu que podia criar partes do corpo singulares e órgãos através de material inorgânico que faz ele capaz de curar ferimentos espantadores através de vários meios.\r\nQuando ele toca alguém ou alguma coisa, ele pode sentir outras formas de vida de dentro, o permitindo checar se alguém está vivo.\r\n";
                label3.Text = "Levando em conta os Stands até Vento Aureo, Araki lista o Gold Experience como o seu favorito em termos de design.\r\n";
                pictureBox1.Image = Properties.Resources.GiornoManga;
                pictureBox2.Image = Properties.Resources.GiornoAnime;
                pictureBox3.Image = Properties.Resources.GiornoAnime2;
                pictureBox4.Image = Properties.Resources.GiornoManga2;
                pictureBox5.Image = Properties.Resources.Goldenwind;
                pictureBox6.Image = Properties.Resources.Goldenwind2;
                pictureBox8.Image = Properties.Resources.Araki;
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
                label2.Text = "Bruno Bucciarati é o deuteragonista de Vento Aureo/Golden Wind. Ele é um mafioso e líder de seu próprio esquadrão dentro da poderosa gangue napolitana, Passione. Enviado para rastrear quem atacou Leaky-Eye Luca e estreando como  oponente de Giorno Giovanna, Bucciarati se torna o primeiro a dar apoio significativo a Giorno em sua ascensão nas fileiras de Passione.";
                label4.Text = "Sticky Fingers é um Stand humanoide de altura e constituição semelhante à de Bucciarati. Sticky Fingers é um Stand de curto alcance cuja excelente força e velocidade o tornam adequado para combate direto. A principal habilidade do Sticky Fingers é criar zíperes em qualquer superfície que toca com o punho, que pode abrir ou fechar remotamente quando quiser. Por exemplo, Sticky Fingers pode atingir uma parede, abri-la para criar uma abertura e passar por ela, depois fechar o zíper.";
                label3.Text = "";
                pictureBox1.Image = Properties.Resources.brunomanga;
                pictureBox2.Image = Properties.Resources.brunoanime;
                pictureBox3.Image = Properties.Resources.BrunoAnime2;
                pictureBox4.Image = Properties.Resources.brunomangaziper;
                pictureBox5.Image = Properties.Resources.StickyFingers;
                pictureBox6.Image = Properties.Resources.stickyfanime;
                
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
                label2.Text = "";
                label4.Text = "";
                label3.Text = "";
                pictureBox1.Image = Properties.Resources.NaranciaManga;
                pictureBox2.Image = Properties.Resources.NaranciaAnime;
                pictureBox3.Image = Properties.Resources.NaranciaAnime2;
                pictureBox4.Image = Properties.Resources.NaranciaManga2;
                pictureBox5.Image = Properties.Resources.Aerosmith;
                pictureBox6.Image = Properties.Resources.Aerosmith2;
            }
            else if (comboBox1.Text == "Pannacotta Fugo")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "Curiosidade";
                groupBox2.Text = "Purple Smoke";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Marcio Vaz";
                label2.Text = "Um jovem e esperto estrategista, Fugo é um membro da equipe de Bucciarati, e por extensão, da Passione. Ele segue Giorno e Bucciarati na sua missão para proteger Trish Una. Além de ser um dos membros mais calculistas da equipe, ele também possui um Stand particularmente letal.\r\nPannacotta Fugo é um jovem sério e gentil porém facilmente irritado, e por final um indivíduo inibido.\r\nApós sua equipe trair a Passione, Fugo não concorda com a atitude e decide sair da equipe.\r\n\r\n";
                label4.Text = "Purple Haze é um Stand instável que contem um vírus comedor de carne particularmente mortal em cada uma das três capsulas em cada uma de suas mãos.\r\nQuando uma capsula quebra, normalmente porque o Purple Haze soca algo, o vírus é liberado e cerca o Stand. Qualquer coisa que entre em seu alcance é infectado, e um humano adulto irá derreter e se transformar em uma gosma orgânica dentro de 30 segundos enquanto o vírus rapidamente se multiplica dentro de seu corpo, sobrepondo suas funções metabólicas e o fazendo apodrecer por dentro.\r\no Purple Haze se torna um Stand muito perigoso para os aliados de Fugo. Até mesmo seu usuário não é imune aos efeitos do vírus. Felizmente, o alcance do vírus é curto e é enfraquecido pela luz de qualquer fonte seja do sol ou de uma lâmpada.\r\n\r\n";
                label3.Text = "Fugo voltaria como vilão posteriormente, mas a ideia foi descartada.";
                pictureBox1.Image = Properties.Resources.FugoManga;
                pictureBox2.Image = Properties.Resources.FugoAnime;
                pictureBox3.Image = Properties.Resources.FugoAnime2;
                pictureBox4.Image = Properties.Resources.FugoManga2;
                pictureBox5.Image = Properties.Resources.PurpleSmoke;
                pictureBox6.Image = Properties.Resources.PurpleSmoke2;
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
                label2.Text = "Leone Abbacchio é um dos membros da Equipe Bucciarati e por extensão da Passione. Ele antigamente era um policial que aceitava subornos e foi subsequentemente demitido, apenas para ser recrutado pelo Bruno Bucciarati. Ele acompanha Bucciarati e Giorno Giovanna em sua missão para proteger Trish Una.\r\nDurante batalhas, Abbacchio expressa um lado agressivo, primeiramente o demonstrando em ameaças verbais e insultos quando falando sobre ou com o inimigo. Abbacchio é altamente dedicado a missão de seu grupo, almejando se absolver ou esquecer de seu erro passado.\r\n";
                label4.Text = "Moody Blues é um Stand humanoide de altura e porte parecido com o de Abbacchio.\r\nA habilidade primária do Moody Blues é retrocognição; em particular, a habilidade de reconstituir, ou \"reproduzir\" eventos passados com total precisão, permitindo que Abbacchio livremente investigue eventos. Todo evento acontecendo à uma localização particular ou pessoa será exatamente recriado pelo Moody Blues, mesmo se não fosse fisicamente possível.\r\nA \"reprodução\" pode ser controlada como se fosse um vídeo, logo Abbacchio pode acelerar sua velocidade e pular eventos desinteressantes ou pausá-los, permitindo que pessoas interajam com o evento pausado caso necessário.O quanto mais fundo no passado o evento é, mais tempo o Moody Blues permanecerá imóvel para alcançá-lo.\r\nJá que ele não pode atacar enquanto está \"retransmitindo\", Moody Blues fica vulnerável. Assim que terminado, entretanto, ele pode novamente atacar.\r\n";
                label3.Text = "De acordo com Araki porém nunca demonstrado na história, Abbacchio é o mais fisicamente forte da Equipe Bucciarati.\r\n";
                pictureBox1.Image = Properties.Resources.AbbacchioManga;
                pictureBox2.Image = Properties.Resources.AbbacchioAnime;
                pictureBox3.Image = Properties.Resources.AbbacchioAnime2;
                pictureBox4.Image = Properties.Resources.AbbacchioManga2;
                pictureBox5.Image = Properties.Resources.Moddyjazz;
                pictureBox6.Image = Properties.Resources.Moddyjazz2;
                pictureBox8.Image = Properties.Resources.Araki;
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
                label2.Text = "Guido Mista é um membro da equipe de Bucciarati e, por extensão, da Passione, ele segue Giorno e Bucciarati na sua missão de proteger a filha do Chefe, Trish Una. Ele é um pistoleiro e um usuário de Stand que atira em seus oponentes com a ajuda de seu Stand. Mista é percebido como um adolescente preguiçoso, sendo um dos membros menos sérios da equipe Bucciarati, mas não tão infantil quanto Narancia. Seu passado o descreve como um indivíduo sem cuidado, cujo objetivo era aproveitar prazeres diários e mundanos como comida e garotas bonitas.\r\n";
                label4.Text = "Sex Pistols ou Six Bullets é um grupo de seis pequenos Stands vivendo no revólver de Mista. Eles são numerados do 1 ao 7, pulando o número 4.\r\nA habilidade dos Pistols é de literalmente cavalgar as balas que Mista dispara para se posicionarem sobre uma área, e então violentamente chutar as balas para mudar seu trajeto.\r\nSe todos os 6 Sex Pistols estiverem em uma única bala, eles tem o poder de cortar dita bala em vários pedaços caso eles todos chutem-na, criando vários projéteis.Porém, o Stand é vulnerável a ataques enquanto ativo.\r\nDiferente da maioria dos Stands, cada Bullet tem uma personalidade distinta, muitas vezes interagindo um com o outro e com Mista.\r\nMista normalmente não recarrega sua própria arma mas faz os Sex Pistols fazerem isso por ele.\r\n";
                label3.Text = "Mista possui Tetrafobia, por isso não existe uma Bullet Nº4.";
                pictureBox1.Image = Properties.Resources.MistaManga;
                pictureBox2.Image = Properties.Resources.MistaAnime;
                pictureBox3.Image = Properties.Resources.MistaAnime2;
                pictureBox4.Image = Properties.Resources.MistaManga2;
                pictureBox5.Image = Properties.Resources.SixBullets;
                pictureBox6.Image = Properties.Resources.SixBullets2;
                pictureBox8.Image = Properties.Resources.Curiosidade_Mista;
            }
            else if (comboBox1.Text == "Trish Una")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dubladora";
                checkBox4.Text = "Curiosidade";
                groupBox2.Text = "Spice Lady";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Bianca Alencar";
                label2.Text = "Trish é a filha do Chefe da Passione. Sendo alvo dos numerosos inimigos do Chefe, ela é protegida pela gangue de Bucciarati. Ela eventualmente desperta seu próprio Stand, Spice Girl e se torna uma aliada valiosa da equipe.\r\nComo a filha de Diavolo, Trish tem uma conexão espiritual com ele. Ela pode notavelmente sentir sempre que ele está por perto.\r\n";
                label4.Text = "Spice Girl é um Stand consciente e capaz de suavizar qualquer material que ataca.\r\nQuando Spice Girl bate em algo com os punhos, pode suavizar o referido objeto em uma consistência de borracha. Qualquer material, mesmo metal ou pedra, será suavizado no mesmo estado. Esses objetos ganham consistência e elasticidade semelhantes à borracha ou uma massa, incapazes de serem esmagados por uma grande força ou serem perfurados por qualquer força, incluindo objetos pontiagudos, e assim tornando esse objeto realmente muitas vezes mais resiliente. Ele pode até mesmo suavizar objetos em movimento, como balas, fazendo com que os projéteis simplesmente se achatem ao contato.\r\n";
                label3.Text = "Trish é baseada na modelo americana Trish Goff, de quem Araki é um grande fã.\r\n";
                pictureBox1.Image = Properties.Resources.TrishManga;
                pictureBox2.Image = Properties.Resources.TrishAnime;
                pictureBox3.Image = Properties.Resources.TrishAnime2;
                pictureBox4.Image = Properties.Resources.TrishManga2;
                pictureBox5.Image = Properties.Resources.SpiceGirl;
                pictureBox6.Image = Properties.Resources.SpiceGirl2;
                pictureBox8.Image = Properties.Resources.Curiosidade_Trish;
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
                label2.Text = "Polpo é o primeiro dos capo da Passione que Giorno Giovanna encontra. Mantido na prisão em uma cela luxuosa, Polpo é responsável por recrutar novos membros para sua divisão. Ele atarefa Giorno com manter um isqueiro aceso por 24 horas como um teste. Polpo é um usuário de Stand e seu Black Sabbath automaticamente ataca Giorno durante dito teste.\r\n";
                label4.Text = "Black Sabbath é um Stand automático que segue comandos simples e já feitos. Como tal, ele é caracterizado por força de longo-alcance, ausência de transferência de dano.\r\nA habilidade principal do Black Sabbath é receber poder das sombras. O Stand é incrivelmente poderoso nas sombras; sua habilidade pode aumentar ao ponto de se tornar mais forte e veloz que o Gold Experience.\r\nAdemais, Black Sabbath pode se esconder nas sombras. Ele pode se afundar dentro de uma sombra como se ela fosse água e ir de um ponto para o outro instantaneamente desde que as sombras estejam ligadas.\r\nAo agarrar a sombra de um humano ordinário, Black Sabbath é capaz de puxar suas sombras à força, enquanto agarrar a sombra de um usuário de Stand puxaria seu Stand.\r\n";
                label3.Text = "Polpo significa polvo em italiano.";
                pictureBox1.Image = Properties.Resources.PolpoManga;
                pictureBox2.Image = Properties.Resources.PolpoAnime;
                pictureBox3.Image = Properties.Resources.PolpoAnime2;
                pictureBox4.Image = Properties.Resources.PolpoManga3;
                pictureBox5.Image = Properties.Resources.BlackSabbath;
                pictureBox6.Image = Properties.Resources.BlackSabbath2;
                pictureBox8.Image = Properties.Resources.Curiosidade_Polpo;
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
                label2.Text = "Mario Zucchero é um membro da Passione e o parceiro de Sale, assim como um usuário de Stand. Ele embosca a Equipe Bucciarati com seu Soft Machine pela posse do tesouro de Polpo.\r\nEm batalha, Zucchero é habilidoso com ataques sorrateiros e emboscadas, tendo conseguido esconder um barco em cima de outro para realizar seu ataque contra a equipe Bucciarati.\r\n";
                label4.Text = "Soft Machine é capaz de literalmente desinflar pessoas (incluindo seu próprio usuário) e objetos ao furá-los com sua pequena rapieira.\r\nO 'ar' visivelmente vaza do furo criado no corpo do alvo e seu corpo eventualmente fica desinflado, mole e elástico.\r\nVítimas são mantidas vivas, mas recobrarão sua consciência até que os efeitos da habilidade sejam cancelados.\r\nAs vítimas desinfladas podem então ser puxadas por espaços pequenos, como canos, muitas vezes ao esticá-los. Um dos melhores exemplos do uso da habilidade é quando o Soft Machine cobriu um barco com uma versão desinflada de um barco idêntico, permitindo com que seu usuário se escondesse entre duas camadas e permanecesse sem ser detectado.\r\n";
                label3.Text = "Zucchero significa açúcar em italiano.";
                pictureBox1.Image = Properties.Resources.MarioManga;
                pictureBox2.Image = Properties.Resources.MarioAnime;
                pictureBox3.Image = Properties.Resources.MarioAnime2;
                pictureBox4.Image = Properties.Resources.MarioManga2;
                pictureBox5.Image = Properties.Resources.SoftMachine;
                pictureBox6.Image = Properties.Resources.SoftMachine2;
                pictureBox8.Image = Properties.Resources.Curiosidade_Mario;
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
                label2.Text = "Sale é um membro da Passione aliado de Mario Zucchero, e usuário de Stand. Para tomar a fortuna de Polpo, ele segue a Equipe Bucciarati até Capri e luta contra Guido Mista e com seu Stand.\r\nSale também demonstra um certo grau de confiança excessiva em combate, explicando cada uma de suas ações ao Mista e abertamente declarando a superiodade de seu Stand.\r\n";
                label4.Text = "Kraft Work é um Stand de curto-alcance, sua habilidade primária é a manipulação de energia cinética, retirando a energia cinética de um objeto, o congelando no lugar, ou adicionando mais energia cinética em um objeto anteriormente congelado, o fazendo se mover novamente.\r\nO Kraft Work também permite que Sale deixe pessoas parcialmente travadas no lugar depois delas entrarem em contato com algo que o Kraft Work afetou.\r\nAo repetidamente tocar em um objeto travado vezes o suficiente, Sale pode criar energia cinética nele antes de liberá-lo; ele é então capaz de lançar uma bala com tanta força quanto uma arma real.\r\n";
                label3.Text = "Sale significa sal em italiano.";
                pictureBox1.Image = Properties.Resources.SaleManga;
                pictureBox2.Image = Properties.Resources.SaleAnime;
                pictureBox3.Image = Properties.Resources.SaleAnime2;
                pictureBox4.Image = Properties.Resources.SaleManga2;
                pictureBox5.Image = Properties.Resources.ArtsCrafts;
                pictureBox6.Image = Properties.Resources.ArtsCrafts2;
                pictureBox8.Image = Properties.Resources.Curiosidade_Sale;
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
                label2.Text = "Formaggio é um membro do La Squadra Esecuzioni e o primeiro a ser batalhado. Ele vai atrás do Narancia e eventualmente confronta-o quando o jovem sai para buscar suprimentos e tenta sobreviver a luta enquanto tentando descobrir aonde a a filha do Chefe, Trish Una, está.\r\nFormaggio é um indivíduo muito relaxado. Diferente da maioria dos assassinos perseguidores, Formaggio se introduz abertamente a Narancia, tenta conversar, e até ri de suas próprias piadas.\r\n";
                label4.Text = "Little Feet ou Tiny Feet pode encolher qualquer pessoa ou objeto ao cortá-los com seu longo e afiado dedo indicativo.\r\nUm carro é encolhido ao ponto dele caber em uma palma\r\nO alvo cortado irá gradualmente encolher com o passar do tempo junto de suas roupas, quaisquer itens que ele carregue, e seu possível Stand. O encolhimento é gradual e lento. Little Feet pode livremente controlar o seu próprio tamanho e o de Formaggio.\r\n";
                label3.Text = "Seu nome significa queijo em italiano.";
                pictureBox1.Image = Properties.Resources.FormaggioManga;
                pictureBox2.Image = Properties.Resources.FormaggioAnime;
                pictureBox3.Image = Properties.Resources.FormaggioAnime2;
                pictureBox4.Image = Properties.Resources.FormaggioManga2;
                pictureBox5.Image = Properties.Resources.TinyFeet;
                pictureBox6.Image = Properties.Resources.TinyFeet2;
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
                label2.Text = "Illuso, um membro da La Squadra Esecuzioni, confronta Pannacotta Fugo, Leone Abbacchio e Giorno Giovanna em Pompeia em uma corrida para obter uma chave importante deixada pelo Chefe. Ele é um usuário de Stand e aproveita seus poderes para emboscar seus inimigos.\r\nIlluso aparece como um assassino confiante e convencido, ele expressa grande confiança em sua vantagem já que seu poder torna seus oponentes indefesos perante ele.\r\n";
                label4.Text = "Man in the Mirror permite que seu usuário entre em um \"mundo do espelho\".\r\nAlém disso, o Man in the Mirror também pode levar qualquer coisa para o mundo do espelho ao usar superfícies refletivas como portais, selecionando qualquer coisa que possa entrar através das ordens de Illuso, e também pode fazer isso independente do quão pequeno o \"portal\" seja. Quebrar o espelho não para a habilidade e acaba criando mais aberturas levando ao mundo do espelho.\r\nCaso outro usuário de Stand seja levado para dentro do espelho, Illuso pode escolher proibir seu Stand de entrar com seu usuário e um Stand invocado se encontrará sozinho no mundo real, embora ele possa ser remotamente manipulado pelo usuário.\r\n";
                label3.Text = "Illuso significa iludido em italiano.";
                pictureBox1.Image = Properties.Resources.IllusoManga;
                pictureBox2.Image = Properties.Resources.IllusoAnime;
                pictureBox3.Image = Properties.Resources.IllusoAnime2;
                pictureBox4.Image = Properties.Resources.IllusoManga2;
                pictureBox5.Image = Properties.Resources.ManMirror;
                pictureBox6.Image = Properties.Resources.ManMirror2;
                pictureBox8.Image = Properties.Resources.Curiosidade_Illuso;
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
                label2.Text = "Prosciutto é um assassino da La Squadra Esecuzioni, que junto a Pesci, luta contra a Equipe Bucciarati dentro de um trem de alta-velocidade em direção à Florença.\r\nProsciutto é um homem sério. Ele sempre aparece focado em sua missão e aderindo ao lema da Squadra de manter sua posição, até quando mortalmente ferido.";
                label4.Text = "The Grateful Dead tem a habilidade de fazer com que organismos fisicamente e mentalmente envelheçam em um ritmo acelerado. Há duas maneiras nas quais o The Grateful Dead pode ativar seu poder. O primeiro modo é espalhar o envelhecimento por uma grande área e indiscriminadamente atacar aliados e oponentes, o que é perigoso para os companheiros de Prosciutto. O segundo modo é dirigir seu poder precisamente ao agarrar uma pessoa, nesse caso o envelhecimento sendo mais rápido do que pode-se reagir. A ativação dessa habilidade se manifesta como uma nevoa sendo espalhada pelo The Grateful Dead.\r\nO ritmo com o qual as pessoas envelhecem é dependente de seu calor corporal. O mais quente que o corpo de alguém está, o mais rápido eles envelhecerão.\r\nProsciutto é normalmente imune ao The Grateful Dead e pode permanecer jovem dentro de seu alcance.\r\n";
                label3.Text = "Prosciutto significa presunto curado em italiano.";
                pictureBox1.Image = Properties.Resources.ProsciuttoManga;
                pictureBox2.Image = Properties.Resources.ProsciuttoAnime;
                pictureBox3.Image = Properties.Resources.ProsciuttoAnime2;
                pictureBox4.Image = Properties.Resources.ProsciuttoManga2;
                pictureBox5.Image = Properties.Resources.ThankfulDeath;
                pictureBox6.Image = Properties.Resources.ThankfulDeath2;
                pictureBox8.Image = Properties.Resources.Curiosidade_Prosciutto;
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
                label2.Text = "Pesci é um membro da La Squadra Esecuzioni. Junto ao Prosciutto, Pesci batalha a Equipe Bucciarati dentro de um trem de alta-velocidade em direção à Florença.\r\nPesci é introduzido como um homem de pouca vontade, usando ameaças quando ele deveria agir, e é sobre tudo tímido.\r\nPesci demonstra muito respeito por Prosciutto, referindo-se a ele como irmão mais velho.\r\n";
                label4.Text = "Apesar de sua aparência inócua, o Beach Boy é um Stand notavelmente letal, tanto em curto quanto longo alcance.\r\nEle pode não apenas matar alguém ao fatiar seu coração com seu anzol intangível, mas também é quase impossível de se defender contra.\r\nA habilidade assinatura do Beach Boy é atravessar sua linha e anzol por qualquer objeto, incluindo paredes ou carne.\r\nA linha do Beach Boy é extremamente sensivel e transmite informações a vara para que Pesci veja.\r\nO fio do Beach Boy não pode ser destruído de maneiras comuns, já que qualquer dano causado ao fio em vez disso afetará aquele fisgado no fio.\r\n";
                label3.Text = "Pesci significa peixes em italiano.";
                pictureBox1.Image = Properties.Resources.PesciManga;
                pictureBox2.Image = Properties.Resources.PesciAnime;
                pictureBox3.Image = Properties.Resources.PesciAnime2;
                pictureBox4.Image = Properties.Resources.PesciManga2;
                pictureBox5.Image = Properties.Resources.BeachBoy;
                pictureBox6.Image = Properties.Resources.BeachBoy2;
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
                label2.Text = "Melone é um membro da Squadra Esecuzioni. Após a Equipe Bucciarati ser forçada a tomar a estrada, ele tenta sequestrar Trish Una e usa seu Stand automático para batalhar contra Giorno Giovanna.\r\nMelone se mostra ser um homem educado na maioria das circunstâncias.\r\nAbordando todas atividades com um profissionalismo frio, ele fisicamente inspeciona suas vítimas futuras, vendo elas mais como gado para criar seu Stand em vez de como outros seres humanos.\r\n";
                label4.Text = "Através de seu Stand computador, o Baby Face tem a habilidade de gerar um Stand secundário que lutará em seu lugar. Ao pesquisar sobre um alvo adequado através da pseudociência de examinar as características de uma mulher, Melone consegue informações e prevê o as predisposições futuras do junior.\r\nO Stand secundário (ou junior) que o Baby Face cria é um Stand independente de longo alcance e grande poder que age como um lutador que faz o trabalho para Melone.\r\no Stand secundário é capaz de quebrar matéria em cubos enquanto mantendo os seres vivos.\r\nEle pode dividir qualquer que ele toque em cubos a força, ou meramente extrair uma única parte cúbica de um alvo.\r\nAo retalhar alguém, o Baby Face consegue reorganizar e reconstituir a estrutura de ditos objetos para qualquer coisa que ele desejar.\r\n";
                label3.Text = "Melone significa melão em italiano.";
                pictureBox1.Image = Properties.Resources.MeloneManga;
                pictureBox2.Image = Properties.Resources.MeloneAnime;
                pictureBox3.Image = Properties.Resources.MeloneAnime2;
                pictureBox4.Image = Properties.Resources.MeloneManga2;
                pictureBox5.Image = Properties.Resources.Babyhead;
                pictureBox6.Image = Properties.Resources.Babyhead2;
                pictureBox8.Image = Properties.Resources.Curiosidade_Melone;
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
                label2.Text = "Ghiaccio é um membro da La Squadra Esecuzioni e persegue Giorno Giovanna e Guido Mista perto de Veneza com seu Stand.\r\nGhiaccio é um assassino confiante e de pavio curto que, apesar de suas peculiaridades, é bastante equilibrado.\r\nEle tem uma fixação com linguagem, expressando irritação com o fraseamento confuso de várias metáforas assim com como línguas estrangeiras não respeitam palavras italianas.\r\n";
                label4.Text = "White Album é raro dentre os Stands no fato dele ser um traje que Ghiaccio veste.\r\nQuando o assassino toca em algo, a temperatura do objeto afetado diminui dramaticamente. O poder do White Album é tão poderoso que ele pode chegar à temperaturas de cerca de -100 °C facilmente.\r\nWhite Album pode solidificar a humidade à sua volta para criar armadura de gelo.\r\nA armadura é invulnerável a balas uma vez que ela para seu movimento bem antes delas penetrarem-na.\r\nA única abertura na armadura é um buraco de ar atrás do pescoço do usuário, tornando ela a única grande fraqueza do Stand.";
                label3.Text = "Ghiaccio significa gelo em italiano.";
                pictureBox1.Image = Properties.Resources.GhiaccioManga;
                pictureBox2.Image = Properties.Resources.GhiaccioAnime;
                pictureBox3.Image = Properties.Resources.GhiaccioAnime2;
                pictureBox4.Image = Properties.Resources.GhiaccioManga2;
                pictureBox5.Image = Properties.Resources.WhiteAlbum;
                pictureBox6.Image = Properties.Resources.WhiteAlbum2;
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
                label2.Text = "Squalo trabalha com seu parceiro Tizzano em Veneza para assassinar a Equipe Bucciarati após sua deserção da Passione.\r\nSqualo é um indivíduo irritado, sendo o mais agressivo dentre sua parceria com Tizzano e deixando com que ele faça a maioria do raciocínio. Squalo é entretanto adepto a usar a maioria do seu ambiente em combate.\r\n";
                label4.Text = "Clash é um Stand de longa adistância que pode ser precisamente manipulado por Squalo de longe.\r\nClash é um Stand peixe, logo ele precisa ficar dentro de líquidos para persistir e só pode dar breve saltos para fora de líquidos para atacar.\r\nNo entanto, ele pode instantaneamente teletransportar-se para qualquer corpo de líquido de tamanho minímo perto daquele que esteja o ocupando no momento.\r\nClash não pode se teletransportar mais de 3 metros da sua posição atual.\r\n";
                label3.Text = "Squalo significa tubarão em italiano.\r\n";
                pictureBox1.Image = Properties.Resources.SqualoManga;
                pictureBox2.Image = Properties.Resources.SqualoAnime;
                pictureBox3.Image = Properties.Resources.SqualoAnime2;
                pictureBox4.Image = Properties.Resources.SqualoManga2;
                pictureBox5.Image = Properties.Resources.Clash;
                pictureBox6.Image = Properties.Resources.Clash2;
                pictureBox8.Image = Properties.Resources.Curiosidade_Squalo;
            }
            else if (comboBox1.Text == "Tizzano")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Talking Mouth";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Charles Dalla";
                label2.Text = "Tizzano trabalha com seu parceiro Squalo para assassinar a Equipe Bucciarati em Veneza após a equipe desertar a gangue.\r\nTizzano é um homem estrategista, notando o comportamento de seu alvo para aconselhar seu parceiro Squalo. Dos dois, ele é o mais calmo e atencioso. Ele tem um hábito de dizer \"de acordo com o plano\" sempre que algo dá certo para ele.\r\n";
                label4.Text = "Talking Head é um Stand de longa distância sem habilidades de combate que força suas vítimas a mentirem, permitindo com que Tizzano manipule seus inimigos e controle seus movimentos.\r\nPara surtir efeito, o Talking Head deve primeiro se prender à língua da vítima. Enquanto o Talking Head está preso, a vítima será automaticamente forçada a contar mentiras: sempre que a vítima falar, escrever, ou usar gestos, ela sempre expressará algo falso. Se Tizzano desejar, o Talking Head pode forçar uma vítima a falar alto e contar mentiras ou permanecer em silêncio, dependendo da resistência da vítima. Seguindo sua habilidade de forçar seu hospedeiro a mentir, o Talking Head também é capaz de controlar o corp oda vítima em um grau menor. Ele pode, por exemplo, forçar a vítima a realizar atos simples como acenar a cabeça e apontar.\r\n";
                label3.Text = "Seu nome vem de Ticiano Vecellio, pintor italiano.";
                pictureBox1.Image = Properties.Resources.TizzanoManga;
                pictureBox2.Image = Properties.Resources.TizzanoAnime;
                pictureBox3.Image = Properties.Resources.TizzanoManga2;
                pictureBox4.Image = Properties.Resources.TizzanoManga3;
                pictureBox5.Image = Properties.Resources.TalkingMouth;
                pictureBox6.Image = Properties.Resources.TalkingMouth2;
                pictureBox8.Image = Properties.Resources.Curiosidade_Tizzano;
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
                label2.Text = "Carne é enviado em uma missão suicída contra a Equipe Bucciarati e Trish Una. Embora ele morra, seu agora invencível Stand continua a existir e ataca a gangue durante sua viagem para a Sardenha.\r\nPode ser assumido que ele era leal o suficiente ao Diavolo a ponto de sacrificar sua vida por ele.\r\n";
                label4.Text = "Notorious B.I.G é um dos poucos Stands a serem capazes de seguir existindo após a morte de seu usuário.\r\nAo ser ativado, Notorious B.I.G lentamente infecta qualquer um que tocou nos restos de seu usuário e come sua carne e energia para criar um corpo; isso inclui a energia de Stands e a energia de objetos automáticos como um motor. Através dessa habilidade, Notorious B.I.G pode crescer à um grande volume com energia suficiente, eventualmente alcançando um tamanho comparável a um avião a jato. \r\nEm sua fase inicial de crescimento, Notorious B.I.G pode influenciar o corpo de seu hospedeiro, fazendo com que ele realize ações sem estar conscientemente ciente delas. \r\nEnquanto Notorious B.I.G é cego, ele pode detectar movimento em volta dele, o levando a automaticamente atacar o objeto mais rápido dentro de seu alcance.\r\n";
                label3.Text = "Por razões desconhecidas, o nome do Carne nunca é revelado na adaptação de anime.";
                pictureBox1.Image = Properties.Resources.CarneManga;
                pictureBox2.Image = Properties.Resources.CarneAnime;
                pictureBox3.Image = Properties.Resources.CarneAnime2;
                pictureBox4.Image = Properties.Resources.CarneManga2;
                pictureBox5.Image = Properties.Resources.NotoriousBIG;
                pictureBox6.Image = Properties.Resources.NotoriousBIG2;
                pictureBox8.Image = Properties.Resources.Curiosidade_Carne;
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
                label2.Text = "Risotto Nero é o líder da La Squadra Esecuzioni e envia seus companheiros para assassinar a Equipe Bucciarati; para tomar a filha Trish Una do Chefe da Passione e usá-la para chegar até ele. Após ele se tornar o único membro restante, Risotto persegue a Equipe Bucciarati até Sardenha e confronta Vinegar Doppio em uma praia na Costa Smeralda.\r\nEle vai às últimas consequências para descobrir a identidade do Chefe, e jura vingar as mortes de seus homens. Apesar de seu fracasso, o Chefe parabeniza Risotto por seu esforço e afirma que seus homens teriam orgulho de suas conquistas.\r\n";
                label4.Text = "Metallica tem a habilidade de livremente manipular ferro no ar e no chão através de magnetismo. O Stand é ativo em um círculo de 5 à 10 metros em volta de Risotto, e tem precisão suficiente para formar objetos ao juntar o ferro dentro do corpo de outra pessoa. Por padrão, ele naturalmente atrai ferro.\r\nO ferro é um dos elementos mais comuns a terra e por causa disso Metallica também pode manipular o ferro do ambiente para criar objetos, por exemplo criar facas do ferro da terra para jogá-las no seu alvo.\r\nCom sua habilidade, Metallica pode grudar partículas finas de ferro no corpo de Risotto, fazendo com que ele reflita luz e se misture com a redondeza.\r\n";
                label3.Text = "Risotto é o nome de um prato típico italiano.";
                pictureBox1.Image = Properties.Resources.RisottoManga;
                pictureBox2.Image = Properties.Resources.RisottoAnime;
                pictureBox3.Image = Properties.Resources.RisottoAnime2;
                pictureBox4.Image = Properties.Resources.RisottoManga2;
                pictureBox5.Image = Properties.Resources.Metallica;
                pictureBox6.Image = Properties.Resources.Metallica2;
                pictureBox8.Image = Properties.Resources.RisottoCuriosidade;
                pictureBox8.Image = Properties.Resources.Curiosidade_Risotto;
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
                label2.Text = "Cioccolata é enviado para perto de Roma junto de seu \"animal\" de estimação Secco para matar a Equipe Bucciarati. Ele subsequentemente batalha contra Giorno Giovanna e Guido Mista no topo de uma torre.\r\nCioccolata é um habilidoso manipulador sadista. Sua insanidade, brutalidade, e sadismo são fortes o suficiente para causar nojo até mesmo a Diavolo, que evita usá-lo em missões a menos que ele sinta que é absolutamente necessário.\r\n";
                label4.Text = "Green Day é um Stand humainóide, sua habilidade primária é de produzir um mofo potente que putrefica e destrói a carne daqueles que ele infecta em um instante. Dito mofo é espalhado no ar através de vários tubos que saem da cabeça, ombros, e mãos do Green Day.\r\nO crescimento do mofo é ativado quando as vítimas em potencial abaixam sua atual altitude, uma condição que se aplica a até mesmo membros individuais, forçando seus alvos a ficarem imóveis ou irem para cima.\r\nO mofo se espalha rapidamente de cadáver para cadáver, logo potencialmente tendo um alcance infinito e poderia matar um grande número de pessoas em áreas populadas, assim como deixando difícil de se encontrar seu usuário entre os cadáveres.\r\n";
                label3.Text = "Cioccolata é o primeiro e único antagonista a sofrer um espancamento de 7 páginas.";
                pictureBox1.Image = Properties.Resources.CiocolattaManga;
                pictureBox2.Image = Properties.Resources.CiocolattaAnime;
                pictureBox3.Image = Properties.Resources.CiocolattaAnime2;
                pictureBox4.Image = Properties.Resources.CiocolattaAnime3;
                pictureBox5.Image = Properties.Resources.GreenDay;
                pictureBox6.Image = Properties.Resources.GreenDay2;
                pictureBox8.Image = Properties.Resources.Curiosidade_Cioccolata;
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
                label2.Text = "Secco é despachado junto de seu mestre Cioccolata perto de Roma para matar a Equipe Bucciarati. Ele subsequentemente enfrenta Bruno Bucciarati pessoalmente nas ruas de Roma. \r\nPouco é conhecido sobre Secco, já que nem o próprio chefe foi capaz de encontrar informações concretas sobre seu passado. É conhecido que ele uma vez foi um paciente de Cioccolata; entretanto, já que ele compartilhava a mente e pensamentos deturpados de Cioccolata, eles formaram uma parceria.\r\n";
                label4.Text = "Oasis se manifesta como um traje o qual Secco usa para lutar, ele permite com que ele liquidifique o chão e lute em curto alcance com uma força física aprimorada.\r\nO uso principal dessa habilidade é permitir que Secco viaje pelo subterrâneo ao nadar nele, o mantendo escondido e seguro de ataques.\r\nO Oasis também derrete o corpo humano caso alguém fique no subterrâneo perto de Secco ou através de contato direto com ele.\r\nJá que após certa distancia o chao volta a solidificar, secco usa isso ao seu favor, cuspindo barro para atacar em forma de pedras ou fazendo uma chuva de espinhos de barro.\r\n";
                label3.Text = "Secco significa seco em italiano.";
                pictureBox1.Image = Properties.Resources.SeccoManga;
                pictureBox2.Image = Properties.Resources.SeccoAnime;
                pictureBox3.Image = Properties.Resources.SeccoAnime2;
                pictureBox4.Image = Properties.Resources.SeccoManga2;
                pictureBox5.Image = Properties.Resources.Sanctuary;
                pictureBox6.Image = Properties.Resources.Sanctuary2;
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
                label2.Text = "Doppio é o mais jovem, inocente, e ecêntrico subchefe do Chefe. Como um membro da Passione, ele acredita ser o mais leal subordinado de Diavolo, mas na realidade, os dois são almas separadas habitando o mesmo corpo.\r\nDoppio é uma pessoa muito mais normal em contraste com Diavolo: amigável, honesto, e um pouco covarde. Doppio regularmente alucina objetos aleatórios como \"telefones\" com os quais ele usa para falar com seu alter-ego, sem saber que eles compartilham o mesmo corpo.\r\n";
                label4.Text = "King Crimson ou Emperor Crimson ataca usando apenas um golpe ágil e que é sempre fatal, em vez de rápidas séries de socos. Doppio é capaz de usar apenas os braços de King Crimson, caso Diavolo permita. Outra habilidade emprestada é o Epitaph ou Eulogy que dá a habilidade de ver o futuro ao projetá-lo como imagens, que são normalmente projetadas no cabelo de Doppio.\r\n";
                label3.Text = "Doppio morre no corpo de Bucciaratti.";
                pictureBox1.Image = Properties.Resources.DoppioManga;
                pictureBox2.Image = Properties.Resources.DoppioAnime;
                pictureBox3.Image = Properties.Resources.DoppioAnime2;
                pictureBox4.Image = Properties.Resources.DoppioManga2;
                pictureBox5.Image = Properties.Resources.EmperorCrimson;
                pictureBox6.Image = Properties.Resources.EmperorCrimson2;
                pictureBox8.Image = Properties.Resources.Curiosidade_Doppio;
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
                label2.Text = "Diavolo mais conhecido como o \"Chefe\" da gangue Passione, corrompe Nápoles por vender drogas nas ruas, fazendo dele o superior e maior inimigo de Giorno Giovanna e Bruno Bucciarati. Por causa do seu sigilo obsessivo, quase ninguém sabe sobre sua aparência, nome ou passado. Diavolo possui outra personalidade é o pai de Trish Una.\r\nDiavolo tem uma tendência violenta de caçar e matar aqueles que tentam descobrir qualquer tipo de informação pessoal sobre ele.";
                label4.Text = "King Crimson ou Emperor Crimson ataca usando apenas um golpe ágil e que é sempre fatal, em vez de rápidas séries de socos.\r\nEle é capaz de apagar 10 segundos do tempo, na porção de tempo apagada, outras pessoas serão incapazes de passar por qualquer coisa que tenha acontecido e também não guardarão nenhuma memória do que aconteceu. Do outro lado, Diavolo permanece completamente consciente durante o tempo apagado e apenas ele pode reajustar suas ações.\r\nEm até dez segundos, Epitaph ou Eulogy dá a Diavolo a habilidade de ver o futuro ao projetá-lo como imagens, que são normalmente projetadas no cabelo de Diavolo.\r\n";
                label3.Text = "Diavolo possui outra personalidade, Vinegar Doppio.";
                pictureBox1.Image = Properties.Resources.DiavoloManga;
                pictureBox2.Image = Properties.Resources.DiavoloAnime;
                pictureBox3.Image = Properties.Resources.DiavoloAnime2;
                pictureBox4.Image = Properties.Resources.DiavoloManga2;
                pictureBox5.Image = Properties.Resources.EmperorCrimson;
                pictureBox6.Image = Properties.Resources.EmperorCrimson2;
                pictureBox8.Image = Properties.Resources.DoppioManga;
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
                label2.Text = "";
                label4.Text = "";
                label3.Text = "";
                pictureBox1.Image = Properties.Resources.JolyneManga;
                pictureBox2.Image = Properties.Resources.JolyneAnime;
                pictureBox3.Image = Properties.Resources.JolyneAnime2;
                pictureBox4.Image = Properties.Resources.JolyneManga2;
                pictureBox5.Image = Properties.Resources.StoneOcean;
                pictureBox6.Image = Properties.Resources.StoneOcean2;
                pictureBox8.Image = Properties.Resources.JotaroSOManga;
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
                label2.Text = "";
                label4.Text = "";
                label3.Text = "";
                pictureBox1.Image = Properties.Resources.JotaroSOManga;
                pictureBox2.Image = Properties.Resources.JotaroSOAnime;
                pictureBox3.Image = Properties.Resources.JotaroSOAnime2;
                pictureBox4.Image = Properties.Resources.JotaroSOManga2;
                pictureBox5.Image = Properties.Resources.StarPlatinumSO;
                pictureBox6.Image = Properties.Resources.StarPlatinumSO2;
                pictureBox8.Image = Properties.Resources.Curiosidade_Jotaro;
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
                label2.Text = "";
                label4.Text = "";
                label3.Text = "";
                pictureBox1.Image = Properties.Resources.ErmesManga;
                pictureBox2.Image = Properties.Resources.ErmesAnime;
                pictureBox3.Image = Properties.Resources.ErmesAnime2;
                pictureBox4.Image = Properties.Resources.ErmesManga2;
                pictureBox5.Image = Properties.Resources.Kiss;
                pictureBox6.Image = Properties.Resources.Kiss2;
                pictureBox8.Image = Properties.Resources.Curiosidade_Kiss;
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
                label2.Text = "";
                label4.Text = "";
                label3.Text = "";
                pictureBox1.Image = Properties.Resources.FFManga;
                pictureBox2.Image = Properties.Resources.FFAnime;
                pictureBox3.Image = Properties.Resources.FFAnime2;
                pictureBox4.Image = Properties.Resources.FFManga2;
                pictureBox5.Image = Properties.Resources.FF;
                pictureBox6.Image = Properties.Resources.FF2;
                pictureBox8.Image = Properties.Resources.Curiosidade_FF;
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
                label2.Text = "";
                label4.Text = "";
                label3.Text = "";
                pictureBox1.Image = Properties.Resources.AnasuiManga;
                pictureBox2.Image = Properties.Resources.AnasuiAnime;
                pictureBox3.Image = Properties.Resources.AnasuiAnime2;
                pictureBox4.Image = Properties.Resources.AnasuiManga2;
                pictureBox5.Image = Properties.Resources.DiverDown;
                pictureBox6.Image = Properties.Resources.DiverDown2;
               
            }
            else if (comboBox1.Text == "Weather Forecast")
            {
                checkBox1.Text = "Stand";
                checkBox2.Text = "Descrição do Stand";
                checkBox3.Text = "Dublador";
                checkBox4.Text = "";
                groupBox2.Text = "Wheather Forecast";
                groupBox3.Text = checkBox4.Text;
                groupBox4.Text = "Gabriel Noya";
                label2.Text = "";
                label4.Text = "";
                label3.Text = "";
                pictureBox1.Image = Properties.Resources.WeatherManga;
                pictureBox2.Image = Properties.Resources.WeatherAnime;
                pictureBox3.Image = Properties.Resources.WeatherAnime2;
                pictureBox4.Image = Properties.Resources.WeatherManga2;
                pictureBox5.Image = Properties.Resources.WeatherReport;
                pictureBox6.Image = Properties.Resources.WeatherReport2;
               // pictureBox8.Image = Properties.Resources.PucciManga;
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
                label2.Text = "";
                label4.Text = "";
                label3.Text = "";
                pictureBox1.Image = Properties.Resources.EmporioManga;
                pictureBox2.Image = Properties.Resources.EmporioAnime;
                pictureBox3.Image = Properties.Resources.EmporioAnime2;
                pictureBox4.Image = Properties.Resources.EmporioManga2;
                pictureBox5.Image = Properties.Resources.BurningDown;
                pictureBox6.Image = Properties.Resources.BurningDown2;
                pictureBox8.Image = Properties.Resources.Curiosidade_Emporio;
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
                label2.Text = "";
                label4.Text = "";
                label3.Text = "";
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
                label2.Text = "";
                label4.Text = "";
                label3.Text = "";
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
                label2.Text = "";
                label4.Text = "";
                label3.Text = "";
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
                label2.Text = "";
                label4.Text = "";
                label3.Text = "";
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
                label2.Text = "";
                label4.Text = "";
                label3.Text = "";
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
                label2.Text = "";
                label4.Text = "";
                label3.Text = "";
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
                label2.Text = "";
                label4.Text = "";
                label3.Text = "";
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
                label2.Text = "";
                label4.Text = "";
                label3.Text = "";
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
                label2.Text = "";
                label4.Text = "";
                label3.Text = "";
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
                label2.Text = "";
                label4.Text = "";
                label3.Text = "";
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
                label2.Text = "";
                label4.Text = "";
                label3.Text = "";
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
                label2.Text = "";
                label4.Text = "";
                label3.Text = "";
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
                label2.Text = "";
                label4.Text = "";
                label3.Text = "";
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
                label2.Text = "";
                label4.Text = "";
                label3.Text = "";
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
                label2.Text = "";
                label4.Text = "";
                label3.Text = "";
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
                label2.Text = "";
                label4.Text = "";
                label3.Text = "";
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

 
       
    }
}


