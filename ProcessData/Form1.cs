namespace ProcessData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public (double, double, double) ProcesarDatos(double[] unidimensional, double[,] bidimensional, double[,,] tridimensional)
        {
            double promedioUnidimensional = unidimensional.Average();
            double sumaBidimensional = bidimensional.Cast<double>().Sum();
            double multiplicacionTridimensional = 1;
            foreach (double num in tridimensional)
            {
                multiplicacionTridimensional *= num;
            }

            return (promedioUnidimensional, sumaBidimensional, multiplicacionTridimensional);
        }

   

        private void btnProcesar_Click_1(object sender, EventArgs e)
        {
            double[] unidimensional = { 1, 2, 3, 4, 5 };
            double[,] bidimensional = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            double[,,] tridimensional = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };

            var resultados = ProcesarDatos(unidimensional, bidimensional, tridimensional);

            MessageBox.Show($"Promedio unidimensional: {resultados.Item1}\nSuma bidimensional: {resultados.Item2}\nMultiplicación tridimensional: {resultados.Item3}", "Resultados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
