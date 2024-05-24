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
    public partial class F1 : Form
    {
        public F1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            BtnNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnNao.FlatAppearance.BorderSize = 0;
            BtnNao.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnNao.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnNao.BackColor = Color.Transparent;

            BtnSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BtnSim.FlatAppearance.BorderSize = 0;
            BtnSim.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BtnSim.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BtnSim.BackColor = Color.Transparent;
        }

        private void BtnNao_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inicial formInicial = new Inicial();
            formInicial.Show();
        }

        private void BtnSim_Click(object sender, EventArgs e)
        {
            this.Hide();
            F2 formF2 = new F2();
            formF2.Show();
        }
    }
}
