﻿using System;
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
    public partial class F5 : Form
    {


        public List<string> F5List = new List<string>();


        public F5()
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

        private void button1_Click(object sender, EventArgs e)
        {
            string userinput = textBox1.Text;
            F5List.Add(userinput);

            this.Close();
            Feed_6 feed_6 = new Feed_6();
            feed_6.Show();
        }
    }
}
