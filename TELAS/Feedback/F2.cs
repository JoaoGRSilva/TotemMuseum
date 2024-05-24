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
    public partial class F2 : Form
    {


        public F2()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            btnOpenKeyboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOpenKeyboard.FlatAppearance.BorderSize = 0;
            btnOpenKeyboard.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnOpenKeyboard.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnOpenKeyboard.BackColor = Color.Transparent;

            btnProx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProx.FlatAppearance.BorderSize = 0;
            btnProx.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnProx.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnProx.BackColor = Color.Transparent;
        }




        private void btnOpenKeyboard_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            F3 f3 = new F3();
            f3.Show();
        }
    }
}
