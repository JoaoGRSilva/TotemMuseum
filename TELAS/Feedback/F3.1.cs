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
    public partial class F3C : Form
    {
        public List<string> sugestoes = new List<string>();

        public F3C()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            textBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#8C649F");
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.ForeColor = System.Drawing.Color.White;

            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;

            this.KeyPreview = true; // Permite que o formulário capture os eventos de teclado antes dos controles
            this.KeyDown += F3C_KeyDown; // Associa o evento KeyDown do formulário à função F3C_KeyDown
        }

        private void F3C_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) // Verifica se a tecla pressionada não é Enter
            {
                textBox1.Text += e.KeyCode.ToString(); // Adiciona o código da tecla pressionada ao TextBox
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;
            sugestoes.Add(userInput);
            this.Close();
        }

        private void ShowKeyboard(object sender, EventArgs e)
        {
            Teclado teclado = new Teclado(textBox1);
            teclado.Show();
        }
    }
}
