using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.TELAS.Feedback
{
    public partial class F4 : Form
    {

        List<int> sim = new List<int>();

        public F4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            sim.Add(1);
            buttons = new Button[] { button1, button2, button3, button4, button5 };
            ConfigureButtons();
        }

        private void ConfigureButtons()
        {
            ConfigureButton(BtnExpectSim);
            ConfigureButton(BtnExpectNao);
            ConfigureButton(BtnRecomendaNao);
            ConfigureButton(BtnRecomendaSim);
            ConfigureButton(BtnProx);
            ConfigureButton(BtnVolta);
        }

        private void ConfigureButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.BackColor = Color.Transparent;
        }


        private bool todasPerguntasRespondidas = false;

        private void checarresposta()
        {
            todasPerguntasRespondidas = (naoAtendeuExpectativa != 0 || atendeuExpectativa != 0) &&
                                        (naorecomenda != 0 || recomendaSim != 0);
        }

        public static List<int> respostas { get; private set; } = new List<int>();
        public static int naoAtendeuExpectativa { get; private set; }
        public static int atendeuExpectativa { get; private set; }
        public static int naorecomenda { get; private set; }
        public static int recomendaSim { get; private set; }
        private int resposta1a5;
        private Button[] buttons;

        private void checkExpectativa(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (!sim.Contains(buttonTag))
            {
                naoAtendeuExpectativa++;

            }
            else
            {
                atendeuExpectativa++;
            }

            checarresposta();

            BtnExpectSim.Enabled = false;
            BtnExpectNao.Enabled = false;
        }

        private void checkRecomendacao(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);
            if (!sim.Contains(buttonTag))
            {
                naorecomenda++;
            }
            else
            {
                recomendaSim++;
            }

            checarresposta();

            BtnRecomendaNao.Enabled = false;
            BtnRecomendaSim.Enabled = false;
        }

        private void BtnProx_Click(object sender, EventArgs e)
        {
            if (todasPerguntasRespondidas)
            {
                AdicionarResposta(resposta1a5);
                this.Hide();
                F5 f5 = new F5();
                f5.Show();
            }
            else
            {
                MessageBox.Show("Por favor, responda todas as perguntas antes de prosseguir.");
            }
        }

        private void BtnVolta_Click(object sender, EventArgs e)
        {
            this.Hide();
            F3 f3 = new F3();
            f3.Show();
        }

        private void AdicionarResposta(int resposta)
        {
            respostas.Add(resposta);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.DarkBlue;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            resposta1a5 = 1;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.DarkBlue;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            resposta1a5 = 2;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.DarkBlue;
            button4.BackColor = Color.White;
            button5.BackColor = Color.White;
            resposta1a5 = 3;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.DarkBlue;
            button5.BackColor = Color.White;
            resposta1a5 = 4;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
            button2.BackColor = Color.White;
            button3.BackColor = Color.White;
            button4.BackColor = Color.White;
            button5.BackColor = Color.DarkBlue;
            resposta1a5 = 5;
        }
    }
}