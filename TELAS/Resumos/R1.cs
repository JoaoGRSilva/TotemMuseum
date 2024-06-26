﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.TELAS.Feedback;
using WinFormsApp1.TELAS.Resumo;
using WinFormsApp1.TELAS.Resumos;

namespace WinFormsApp1.TELAS
{
    public partial class R1 : Form
    {
        public R1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

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

            BtnFeedBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnFeedBack.FlatAppearance.BorderSize = 0;
            BtnFeedBack.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnFeedBack.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnFeedBack.BackColor = Color.Transparent;

            BtnAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnAdm.FlatAppearance.BorderSize = 0;
            BtnAdm.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnAdm.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnAdm.BackColor = Color.Transparent;

            #endregion
        }

        private void BtnAstronautas_Click(object sender, EventArgs e)
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

            // Cria uma instância 
            Resumo___Nasa formNasa = new Resumo___Nasa();

            // Exibe o formGaleria
            formNasa.Show();
        }

        private void BtnFeedBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            F1 formFeed = new F1();
            formFeed.Show();
        }

        private void BtnAdm_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdmLogin adm = new AdmLogin();
            adm.Show();
        }
    }

}
