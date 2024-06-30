using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Proyecto_final
{
    public partial class Form1 : Form
    {
        Funciones helper = new Funciones();
        Series ayuda = new Series();
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
            TextoInicial.Text = cantidad.ToString();
        }

        private void aToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cantidad = ayuda.ObtenerFibonacci(textBox1.Text);
            TextoInicial.Text = $"El número en la posición {textBox1.Text} de la serie de Fibonacci es: {cantidad.ToString()}";
        }

        private void bToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cantidad = ayuda.SumarTerminosSerie(textBox1.Text);
            TextoInicial.Text = $"La suma de los primeros {textBox1.Text} terminos de la serie es: {cantidad.ToString()}";

        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cantidad = ayuda.SeriePares(textBox1.Text);
            TextoInicial.Text = $"La suma de los primeros {textBox1.Text} terminos de la serie es: {cantidad.ToString()}";
        }

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cantidad = ayuda.TerminoSerie(textBox1.Text);
            TextoInicial.Text = $"El termino {textBox1.Text} de la serie es: {cantidad.ToString()}";
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cantidad = ayuda.SumarTerminosPares(textBox1.Text);
            TextoInicial.Text = $"La suma de los primeros {textBox1.Text} terminos de la serie es: {cantidad.ToString()}";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextoInicial_Click(object sender, EventArgs e)
        {

        }


    }
}
