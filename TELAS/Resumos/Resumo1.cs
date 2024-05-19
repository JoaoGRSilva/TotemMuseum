using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.TELAS.Resumo;

namespace WinFormsApp1.TELAS
{
    public partial class Resumo1 : Form
    {
        public Resumo1()
        {
            InitializeComponent();

            #region
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

            BtnNeil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnNeil.FlatAppearance.BorderSize = 0;
            BtnNeil.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnNeil.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnNeil.BackColor = Color.Transparent;

            BtnApollo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnApollo.FlatAppearance.BorderSize = 0;
            BtnApollo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnApollo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnApollo.BackColor = Color.Transparent;

            BtnNasa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnNasa.FlatAppearance.BorderSize = 0;
            BtnNasa.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnNasa.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnNasa.BackColor = Color.Transparent;



            #endregion
        }

        private void BtnAstronautas_Click(object sender, EventArgs e)
        {
            // Oculta o FormInicial
            this.Hide();

            // Cria uma instância 
            Resumo___Astronautas formAstrounauta = new Resumo___Astronautas();

            // Exibe o formAstrounauta
            formAstrounauta.Show();
        }

        private void BtnGaleria_Click(object sender, EventArgs e)
        {
            // Oculta o FormInicial
            this.Hide();

            // Cria uma instância 
            Resumo___Galeria formGaleria = new Resumo___Galeria();

            // Exibe o formGaleria
            formGaleria.Show();
        }

        private void BtnCuriosidades_Click(object sender, EventArgs e)
        {
            // Oculta o FormInicial
            this.Hide();

            // Cria uma instância 
            Resumo___Curiosidades formCuriosidades = new Resumo___Curiosidades();

            // Exibe o formGaleria
            formCuriosidades.Show();
        }

        private void BtnNeil_Click(object sender, EventArgs e)
        {
            // Oculta o FormInicial
            this.Hide();

            // Cria uma instância 
            resumo_neil formNeil = new resumo_neil();

            // Exibe o formGaleria
            formNeil.Show();
        }

        private void BtnApollo_Click(object sender, EventArgs e)
        {
            // Oculta o FormInicial
            this.Hide();

            // Cria uma instância 
            resumo___apolo formApolo = new resumo___apolo();

            // Exibe o formGaleria
            formApolo.Show();
        }

        private void BtnNasa_Click(object sender, EventArgs e)
        {
            // Oculta o FormInicial
            this.Hide();
            Resumo___Nasa formNasa = new Resumo___Nasa();
            formNasa.Show();
        }
    }

}
