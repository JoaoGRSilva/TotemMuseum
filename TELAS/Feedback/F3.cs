using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1.TELAS.Feedback;

public partial class F3 : Form
{
    List<int> listaDeInteiros = new List<int>();



    public static int gostouEspaco  { get; set; }
    public static int naoGostouEspaco { get; set; }
    public static int gostouObra { get; set; }
    public static int naoGostouObra { get; set; }
    public static int quisAlgo { get; set; }
    public static int naoQuisAlgo { get; set; }
    public static int numeroQuestao = 1;





    public F3()
    {
        InitializeComponent();
        this.StartPosition = FormStartPosition.CenterScreen;
        listaDeInteiros.Add(1);
        listaDeInteiros.Add(3);
        listaDeInteiros.Add(5);




        BtnSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        BtnSim.FlatAppearance.BorderSize = 0;
        BtnSim.FlatAppearance.MouseDownBackColor = Color.Transparent;
        BtnSim.FlatAppearance.MouseOverBackColor = Color.Transparent;
        BtnSim.BackColor = Color.Transparent;

        BtnNao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        BtnNao.FlatAppearance.BorderSize = 0;
        BtnNao.FlatAppearance.MouseDownBackColor = Color.Transparent;
        BtnNao.FlatAppearance.MouseOverBackColor = Color.Transparent;
        BtnNao.BackColor = Color.Transparent;

        button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button3.FlatAppearance.BorderSize = 0;
        button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
        button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
        button3.BackColor = Color.Transparent;

        button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button4.FlatAppearance.BorderSize = 0;
        button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
        button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
        button4.BackColor = Color.Transparent;

        button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button5.FlatAppearance.BorderSize = 0;
        button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
        button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
        button5.BackColor = Color.Transparent;

        button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button6.FlatAppearance.BorderSize = 0;
        button6.FlatAppearance.MouseDownBackColor = Color.Transparent;
        button6.FlatAppearance.MouseOverBackColor = Color.Transparent;
        button6.BackColor = Color.Transparent;


        button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        button1.FlatAppearance.BorderSize = 0;
        button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
        button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
        button1.BackColor = Color.Transparent;
    }

    private void checarEspaco(object sender, EventArgs e)
    {
        var senderObject = (Button)sender;
        int buttonTag = Convert.ToInt32(senderObject.Tag);

        if (!listaDeInteiros.Contains(buttonTag))
        {
            naoGostouEspaco++;
        }
        else
        {
            gostouEspaco++;
        }

    }

    private void checarObra(object sender, EventArgs e)
    {
        var senderObject = (Button)sender;
        int buttonTag = Convert.ToInt32(senderObject.Tag);

        if (!listaDeInteiros.Contains(buttonTag))
        {
            naoGostouObra++;
        }
        else
        {
            gostouObra++;

        }
    }

    private void checarAlgo(object sender, EventArgs e)
    {
        var senderObject = (Button)sender;
        int buttonTag = Convert.ToInt32(senderObject.Tag);

        if (!listaDeInteiros.Contains(buttonTag))
        {
            naoQuisAlgo++;
        }
        else
        {
            quisAlgo++;
            F3C f3C = new F3C();
            f3C.Show();

        }
    }

    


    private void button1_Click(object sender, EventArgs e)
    {
        this.Hide();
        F4 f4 = new F4();
        f4.Show();
    }
}
