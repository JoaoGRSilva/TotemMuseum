using System;
using System.Drawing;
using System.Windows.Forms;
using WinFormsApp1.TELAS.Admin;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.TELAS.Resumos
{
    public partial class AdmLogin : Form
    {
        public AdmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            // Configurar o botão de login
            btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLogin.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLogin.BackColor = Color.Transparent;

            this.KeyPreview = true;
            this.KeyDown += AdmLogin_KeyDownLogin;

            this.KeyPreview = true;
            this.KeyDown += AdmLogin_KeyDownPW;

            btnLogin.Click += new EventHandler(BtnLogin_Click);
        }

        private void AdmLogin_KeyDownLogin(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) // Verifica se a tecla pressionada não é Enter
            {
                txtUsername.Text += e.KeyCode.ToString(); // Adiciona o código da tecla pressionada ao TextBox
            }
        }

        private void AdmLogin_KeyDownPW(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) // Verifica se a tecla pressionada não é Enter
            {
                txtPassword.Text += e.KeyCode.ToString(); // Adiciona o código da tecla pressionada ao TextBox
            }
        }

        private void ShowKeyboard(object sender, EventArgs e)
        {
            // Calcular a posição Y para o teclado
            int tecladoPosY = this.Top + this.Height / 2 + 50; // 50 é uma distância específica abaixo do centro

            // Criar o formulário do teclado com a posição calculada
            Teclado teclado = new Teclado(txtUsername);
            teclado.StartPosition = FormStartPosition.Manual; // Definir a posição manualmente

            // Calcular a posição X para o teclado (centralizado horizontalmente)
            int tecladoPosX = this.Left + (this.Width - teclado.Width) / 2;
            teclado.Location = new Point(tecladoPosX, tecladoPosY); // Definir a posição calculada

            teclado.Show();
        }

        private void ShowKeyboardPW(object sender, EventArgs e)
        {
            // Calcular a posição Y para o teclado
            int tecladoPosY = this.Top + this.Height / 2 + 50; // 50 é uma distância específica abaixo do centro

            // Criar o formulário do teclado com a posição calculada
            TecladoPW tecladoPW = new TecladoPW(txtPassword); // Declaração da variável tecladoPW
            tecladoPW.StartPosition = FormStartPosition.Manual; // Definir a posição manualmente

            // Calcular a posição X para o teclado (centralizado horizontalmente)
            int tecladoPosX = this.Left + (this.Width - tecladoPW.Width) / 2;
            tecladoPW.Location = new Point(tecladoPosX, tecladoPosY); // Definir a posição calculada

            tecladoPW.Show();
        }


        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Credenciais de exemplo (em um cenário real, você deve verificar em um banco de dados ou outro serviço seguro)
            string validUsername = "ADMIN";
            string validPassword = "ADMIN";

            if (username == validUsername && password == validPassword)
            {
                this.Hide();
                Adm1 adm = new Adm1();
                adm.Show();
            }
            else
            {
                MessageBox.Show("O usuário ou senha estão incorretos!");
            }
        }


    }
}
