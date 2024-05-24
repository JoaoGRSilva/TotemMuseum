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
using WinFormsApp1.TELAS.Resumo;
using WinFormsApp1.TELAS.Resumos;

namespace WinFormsApp1.TELAS
{
    public partial class Resumo___Astronautas : Form
    {
        public Resumo___Astronautas()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            #region

            BtnResumo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnResumo.FlatAppearance.BorderSize = 0;
            BtnResumo.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnResumo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnResumo.BackColor = Color.Transparent;


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

            BtnMichael.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnMichael.FlatAppearance.BorderSize = 0;
            BtnMichael.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnMichael.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnMichael.BackColor = Color.Transparent;

            BtnBuzz.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnBuzz.FlatAppearance.BorderSize = 0;
            BtnBuzz.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnBuzz.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnBuzz.BackColor = Color.Transparent;

            BtnNeil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnNeil.FlatAppearance.BorderSize = 0;
            BtnNeil.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnNeil.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnNeil.BackColor = Color.Transparent;

            BtnFeedBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnFeedBack.FlatAppearance.BorderSize = 0;
            BtnFeedBack.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnFeedBack.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnFeedBack.BackColor = Color.Transparent;

            #endregion
        }

        private void BtnResumo_Click(object sender, EventArgs e)
        {
            this.Hide();
            R1 formResumo = new R1();
            formResumo.Show();
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

        private void BtnMichael_Click(object sender, EventArgs e)
        {
            this.Hide();
            RMichael formMichael = new RMichael();
            formMichael.Show();
        }

        private void BtnBuzz_Click(object sender, EventArgs e)
        {
            this.Hide();
            RBuzz formBuzz = new RBuzz();
            formBuzz.Show();
        }

        private void BtnNeil_Click(object sender, EventArgs e)
        {
            this.Hide();
            resumo_neil formNeil = new resumo_neil();
            formNeil.Show();
        }

        private void BtnFeedBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            F1 formFeed = new F1();
            formFeed.Show();
        }
    }
}