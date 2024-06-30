using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_final
{
    public partial class Form1 : Form
    {
        Funciones helper = new Funciones();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number = int.Parse(textBox1.Text);
            int maxDigit = 0;
            while (number > 0)
            {
                int digit = number % 10;
                if (digit > maxDigit)
                {
                    maxDigit = digit;
                }
                number /= 10;
            }
            TextoInicial.Text = maxDigit.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int suma = helper.SumarDigitosPares(textBox1.Text);
            TextoInicial.Text = suma.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string resultado = helper.MoverMayorDigitoAlFinal(textBox1.Text);
            TextoInicial.Text = "Resultado: " + resultado;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool estaOrdenado = helper.DigitosOrdenados(textBox1.Text);
            TextoInicial.Text = "¿Dígitos Ordenados?: " + (estaOrdenado ? "Sí" : "No");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int cantidad = helper.ContarImparesAntesDePar(textBox1.Text);
            TextoInicial.Text =cantidad.ToString ();
        }


    }
}
