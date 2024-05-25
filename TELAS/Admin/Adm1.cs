using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.TELAS.Feedback;

namespace WinFormsApp1.TELAS.Admin
{
    public partial class Adm1 : Form
    {
        public Adm1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void Adm1_Load(object sender, EventArgs e)
        {
            int totalRespondentes = Feed_6.respondentes;
            qtdResponde.Text = totalRespondentes.ToString();

            int gostouEspaco = F3.gostouEspaco;
            lblGostoEspaco.Text = gostouEspaco.ToString();

            int naoGostoEspaco = F3.naoGostouEspaco;
            lblnaoGostouEspaco.Text = naoGostoEspaco.ToString();

            int gostouObra = F3.gostouObra;
            lblagrado.Text = gostouObra.ToString();

            int naoGostouObra = F3.naoGostouObra;
            lblnaoagrado.Text = naoGostouObra.ToString();

            int quisAlgo = F3.quisAlgo;
            lblAlgoMais.Text = quisAlgo.ToString();

            int naoQuisAlgo = F3.naoQuisAlgo;
            lblNaoAlgoMais.Text = naoQuisAlgo.ToString();


            int atendeuExpect = F4.atendeuExpect;
            lblExpct.Text = atendeuExpect.ToString();

            int naoAtendeuExpect = F4.naoAtendeuExpect;
            lblNaoExpct.Text = atendeuExpect.ToString();

            int recomendaMuseu = F4.recomenda;
            lblRecomenda.Text = recomendaMuseu.ToString();

            int naorecomendaMuseu = F4.naoRecomenda;
            lblNaoRecomenda.Text = naorecomendaMuseu.ToString();

            int museuMedia = CalcularMedia();
            lblMedia.Text = museuMedia.ToString();

        }

        private int CalcularMedia()
        {
            List<int> respostas = F4.respostas;

            if (respostas.Count > 0)
            {
                double media = respostas.Average();
                return (int)Math.Round(media); 
            }
            else
            {
                MessageBox.Show("Nenhuma resposta foi inserida ainda.", "Média");
                return 0;
            }
        }

    }



}
