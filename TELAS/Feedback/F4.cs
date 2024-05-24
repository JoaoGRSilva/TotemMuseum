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


        int atendeuExpect, naoAtendeuExpect;
        int recomenda, naoRecomenda;

        public F4()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            listaDeInteiros.Add(1);
            listaDeInteiros.Add(3);
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
    }
}

