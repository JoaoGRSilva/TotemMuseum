using System;
using System.Windows.Forms;

namespace WinFormsApp1.TELAS
{
    public partial class Teclado : Form
    {
        private TextBox externalTextBox;

        public Teclado(TextBox textBox)
        {
            InitializeComponent();
            externalTextBox = textBox;

            // Associa o evento Click aos botões existentes
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.Click += new EventHandler(Char_Click);
                }
            }
        }

        private void Char_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                string character = button.Text;
                switch (character)
                {
                    case "Backspace":
                        RemoveLastCharacterFromTextBox();
                        break;
                    case "Space":
                        AddTextToTextBox(" ");
                        break;
                    default:
                        AddTextToTextBox(character);
                        break;
                }
            }
        }

        private void AddTextToTextBox(string text)
        {
            if (externalTextBox != null)
            {
                externalTextBox.Text += text;
            }
        }

        private void RemoveLastCharacterFromTextBox()
        {
            if (externalTextBox != null && externalTextBox.Text.Length > 0)
            {
                externalTextBox.Text = externalTextBox.Text.Substring(0, externalTextBox.Text.Length - 1);
            }
        }

    }
}
