using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.TELAS.Feedback
{
    public partial class F4 : Form
    {

        List<int> listaDeInteiros = new List<int>();


        public static int atendeuExpect { get; set; }
        public static int naoAtendeuExpect { get; set; }
        public static int recomenda { get; set; }
        public static int naoRecomenda { get; set; }
        public static List<int> respostas { get; set; } = new List<int>();


        public F4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            listaDeInteiros.Add(1);
            listaDeInteiros.Add(3);

            BtnSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnSim.FlatAppearance.BorderSize = 0;
            BtnSim.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnSim.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnSim.BackColor = Color.Transparent;

            BtnSim1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnSim1.FlatAppearance.BorderSize = 0;
            BtnSim1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnSim1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnSim1.BackColor = Color.Transparent;

            BtnNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnNao.FlatAppearance.BorderSize = 0;
            BtnNao.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnNao.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnNao.BackColor = Color.Transparent;

            BtnNao1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnNao1.FlatAppearance.BorderSize = 0;
            BtnNao1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnNao1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnNao1.BackColor = Color.Transparent;

            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            F5 f5 = new F5();
            f5.Show();
        }

        private void checkExpect(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (!listaDeInteiros.Contains(buttonTag))
            {
                naoAtendeuExpect++;
            }
            else
            {
                atendeuExpect++;
            }

        }

        private void checkRecomenda(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (!listaDeInteiros.Contains(buttonTag))
            {
                naoRecomenda++;
            }
            else
            {
                recomenda++;
            }

        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            btnUm.BackColor = Color.DarkBlue;
            BtnDois.BackColor = Color.White;
            BtnTres.BackColor = Color.White;
            BtnQuatro.BackColor = Color.White;
            BtnCinco.BackColor = Color.White;
            AdicionarResposta(1);
        }

        private void BtnDois_Click(object sender, EventArgs e)
        {
            btnUm.BackColor = Color.White;
            BtnDois.BackColor = Color.DarkBlue;
            BtnTres.BackColor = Color.White;
            BtnQuatro.BackColor = Color.White;
            BtnCinco.BackColor = Color.White;
            AdicionarResposta(2);
        }

        private void BtnTres_Click(object sender, EventArgs e)
        {
            btnUm.BackColor = Color.White;
            BtnDois.BackColor = Color.White;
            BtnTres.BackColor = Color.DarkBlue;
            BtnQuatro.BackColor = Color.White;
            BtnCinco.BackColor = Color.White;
            AdicionarResposta(3);
        }

        private void BtnQuatro_Click(object sender, EventArgs e)
        {
            btnUm.BackColor = Color.White;
            BtnDois.BackColor = Color.White;
            BtnTres.BackColor = Color.White;
            BtnQuatro.BackColor = Color.DarkBlue;
            BtnCinco.BackColor = Color.White;
            AdicionarResposta(4);
        }

        private void BtnCinco_Click(object sender, EventArgs e)
        {
            btnUm.BackColor = Color.White;
            BtnDois.BackColor = Color.White;
            BtnTres.BackColor = Color.White;
            BtnQuatro.BackColor = Color.White;
            BtnCinco.BackColor = Color.DarkBlue;
            AdicionarResposta(5);
        }

        private void AdicionarResposta(int resposta)
        {
            respostas.Add(resposta);
        }
    }
}

