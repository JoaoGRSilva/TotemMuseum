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
    public partial class Admin2 : Form
    {
        List<string> listaRespostasF3 = F3C.respostas;

        List<string> listaRespostaF5 = F5.F5List;

        public Admin2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ConfigureButtons();
        }

        private void ConfigureButtons()
        {
            ConfigureButton(button2);
            ConfigureButton(button1);
        }

        private void ConfigureButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.BackColor = Color.Transparent;
        }

        private void Admin2_Load(object sender, EventArgs e)
        {
            displayListaF3(listaRespostasF3);


        }

        private void displayListaF3(List<string> listaRespostasF3)
        {
            lblF3.Text = string.Join(Environment.NewLine, listaRespostasF3);
        }

        private void displayListaF5(List<string> listaRespostaF5)
        {
            lblf5.Text = string.Join(Environment.NewLine, listaRespostaF5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Adm1 adm = new Adm1();
            adm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            R1 r1 = new R1();
            r1.Show();
        }
    }
}
