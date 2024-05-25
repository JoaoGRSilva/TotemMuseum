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



    public static int gostouEspaco { get; set; }
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

        ConfigureButtons();
    }

    private void ConfigureButtons()
    {
        ConfigureButton(button1);
        ConfigureButton(button6);
        ConfigureButton(button5);
        ConfigureButton(button4);
        ConfigureButton(button3);
        ConfigureButton(BtnNao);
        ConfigureButton(BtnSim);
    }

    private void ConfigureButton(Button button)
    {
        button.FlatStyle = FlatStyle.Flat;
        button.FlatAppearance.BorderSize = 0;
        button.FlatAppearance.MouseDownBackColor = Color.Transparent;
        button.FlatAppearance.MouseOverBackColor = Color.Transparent;
        button.BackColor = Color.Transparent;
    }

    private bool todasPerguntasRespondidas = false;

    private void checarRespostas()
    {
        todasPerguntasRespondidas = (gostouEspaco != 0 || naoGostouEspaco != 0) &&
                                    (gostouObra != 0 || naoGostouObra != 0) &&
                                    (quisAlgo != 0 || naoQuisAlgo != 0);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (todasPerguntasRespondidas)
        {
            this.Hide();
            F4 f4 = new F4();
            f4.Show();
        }
        else
        {
            MessageBox.Show("Por favor, responda todas as perguntas antes de prosseguir.");
        }
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

        checarRespostas();

        // Desabilitar apenas os botões relacionados à pergunta de espaço
        BtnSim.Enabled = false;
        BtnNao.Enabled = false;
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

        checarRespostas();

        // Desabilitar apenas os botões relacionados à pergunta sobre a obra
        button3.Enabled = false;
        button4.Enabled = false;
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

        checarRespostas();

        // Desabilitar apenas os botões relacionados à pergunta sobre algo
        button5.Enabled = false;
        button6.Enabled = false;
    }
}
