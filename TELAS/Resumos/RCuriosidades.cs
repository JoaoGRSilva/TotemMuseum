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

namespace WinFormsApp1.TELAS
{
    public partial class Resumo___Curiosidades : Form
    {
        public Resumo___Curiosidades()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            BtnResumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnResumo.FlatAppearance.BorderSize = 0;
            BtnResumo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnResumo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnResumo.BackColor = Color.Transparent;

            BtnAstronautas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnAstronautas.FlatAppearance.BorderSize = 0;
            BtnAstronautas.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnAstronautas.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnAstronautas.BackColor = Color.Transparent;

            BtnGaleria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnGaleria.FlatAppearance.BorderSize = 0;
            BtnGaleria.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnGaleria.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnGaleria.BackColor = Color.Transparent;

            BtnFeedBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnFeedBack.FlatAppearance.BorderSize = 0;
            BtnFeedBack.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnFeedBack.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnFeedBack.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            R1 formResumo = new R1();
            formResumo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Resumo___Galeria formGaleria = new Resumo___Galeria();
            formGaleria.Show();
        }

        private void BtnAstronautas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Resumo___Astronautas formAstrounauta = new Resumo___Astronautas();
            formAstrounauta.Show();
        }

        private void BtnFeedBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            F1 formFeed = new F1();
            formFeed.Show();
        }
    }
}
