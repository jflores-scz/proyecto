namespace Proyecto_Final_Donaldo
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
            string texto = textBox1.Text;
            int cantidadPalabras = helper.ContarPalabras(texto);
            label1.Text = $"Cantidad de palabras: {cantidadPalabras}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            string textoSinVocales = helper.EliminarVocales(texto);
            label1.Text = $"Texto sin vocales: {textoSinVocales}";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cadena = textBox1.Text;
            string palabraMasLarga = helper.EncontrarPalabraMasLarga(cadena);
            label1.Text = $"Palabra más larga: {palabraMasLarga}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            string textoModificado = helper.EliminarPrimeraLetraDeCadaPalabra(texto);
            label1.Text = $"Texto modificado: {textoModificado}";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text;
            string textoInvertido = helper.InvertirCadaPalabra(texto);
            label1.Text = $"Texto invertido: {textoInvertido}";
        }
    }
}
