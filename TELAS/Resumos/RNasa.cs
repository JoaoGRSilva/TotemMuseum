using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.TELAS.Resumo
{
    public partial class Resumo___Nasa : Form
    {
        public Resumo___Nasa()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

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

            BtnCuriosidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnCuriosidades.FlatAppearance.BorderSize = 0;
            BtnCuriosidades.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnCuriosidades.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnCuriosidades.BackColor = Color.Transparent;

            BtnResumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnResumo.FlatAppearance.BorderSize = 0;
            BtnResumo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnResumo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnResumo.BackColor = Color.Transparent;
        }


        private void BtnResumo_Click(object sender, EventArgs e)
        {
            this.Hide();
            R1 formResumo = new R1();
            formResumo.Show();
        }

        private void BtnAstronautas_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Resumo___Astronautas formAstrounauta = new Resumo___Astronautas();
            formAstrounauta.Show();
        }

        private void BtnGaleria_Click(object sender, EventArgs e)
        {
            this.Hide();
            Resumo___Galeria formGaleria = new Resumo___Galeria();
            formGaleria.Show();
        }

        private void BtnCuriosidades_Click(object sender, EventArgs e)
        {
            this.Hide();
            Resumo___Curiosidades formCuriosidades = new Resumo___Curiosidades();
            formCuriosidades.Show();
        }
    }
}
