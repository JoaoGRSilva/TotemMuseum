namespace WinFormsApp1.TELAS
{
    public partial class Teclado : Form
    {
        private IKeyboardTarget _targetForm;

        public Teclado(IKeyboardTarget targetForm)
        {
            InitializeComponent();
            _targetForm = targetForm;
        }

        private void SendKeyCode(string text)
        {
            _targetForm.AddTextToTextBox(text);
        }



        private void Char_Click(object sender, EventArgs e)
        {
            string cr = ((Button)sender).Text;
            Console.WriteLine("Caractere clicado: " + cr); // Instrução de depuração
            switch (cr)
            
            {
                case "A":
                case "a":
                    SendKeyCode("A");
                    break;
                case "B":
                case "b":
                    SendKeyCode("B");
                    break;
                case "C":
                case "c":
                    SendKeyCode("C");
                    break;
                case "D":
                case "d":
                    SendKeyCode("D");
                    break;
                case "E":
                case "e":
                    SendKeyCode("E");
                    break;
                case "F":
                case "f":
                    SendKeyCode("F");
                    break;
                case "G":
                case "g":
                    SendKeyCode("G");
                    break;
                case "H":
                case "h":
                    SendKeyCode("H");
                    break;
                case "I":
                case "i":
                    SendKeyCode("I");
                    break;
                case "J":
                case "j":
                    SendKeyCode("J");
                    break;
                case "K":
                case "k":
                    SendKeyCode("K");
                    break;
                case "L":
                case "l":
                    SendKeyCode("L");
                    break;
                case "M":
                case "m":
                    SendKeyCode("M");
                    break;
                case "N":
                case "n":
                    SendKeyCode("N");
                    break;
                case "O":
                case "o":
                    SendKeyCode("O");
                    break;
                case "P":
                case "p":
                    SendKeyCode("P");
                    break;
                case "Q":
                case "q":
                    SendKeyCode("Q");
                    break;
                case "R":
                case "r":
                    SendKeyCode("R");
                    break;
                case "S":
                case "s":
                    SendKeyCode("S");
                    break;
                case "T":
                case "t":
                    SendKeyCode("T");
                    break;
                case "U":
                case "u":
                    SendKeyCode("U");
                    break;
                case "V":
                case "v":
                    SendKeyCode("V");
                    break;
                case "W":
                case "w":
                    SendKeyCode("W");
                    break;
                case "X":
                case "x":
                    SendKeyCode("X");
                    break;
                case "Y":
                case "y":
                    SendKeyCode("Y");
                    break;
                case "Z":
                case "z":
                    SendKeyCode("Z");
                    break;
                case "0":
                    SendKeyCode("0");
                    break;
                case "1":
                    SendKeyCode("1");
                    break;
                case "2":
                    SendKeyCode("2");
                    break;
                case "3":
                    SendKeyCode("3");
                    break;
                case "4":
                    SendKeyCode("4");
                    break;
                case "5":
                    SendKeyCode("5");
                    break;
                case "6":
                    SendKeyCode("6");
                    break;
                case "7":
                    SendKeyCode("7");
                    break;
                case "8":
                    SendKeyCode("8");
                    break;
                case "9":
                    SendKeyCode("9");
                    break;
                case "Enter":
                    SendKeyCode("\r\n");
                    break;
                case "BackSpace":
                    _targetForm.RemoveLastCharacterFromTextBox();
                    break;
                case " ":
                    SendKeyCode(" ");
                    break;
            }
        }
    }
}
