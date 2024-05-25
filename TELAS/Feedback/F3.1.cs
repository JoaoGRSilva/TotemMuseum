using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1.TELAS.Feedback
{

    public partial class F3C : Form, IKeyboardTarget
    {
        public List<string> sugestoes = new List<string>();


        public F3C()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            textBox1.BackColor = System.Drawing.ColorTranslator.FromHtml("#8C64A0");
            textBox1.ForeColor = Color.White; // Define a cor do texto como branco para melhor visualização
            textBox1.BorderStyle = BorderStyle.None; // Remove a borda do TextBox

            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;

        }

        public void AddTextToTextBox(string text)
        {
            textBox1.Text += text;
        }

        public void RemoveLastCharacterFromTextBox()
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void opemKeyboard(object sender, MouseEventArgs e)
        {
            Teclado teclado = new Teclado(this);
            teclado.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userInput = textBox1.Text;
            sugestoes.Add(userInput);


            this.Close();
        }

    }
}
