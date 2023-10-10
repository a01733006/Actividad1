using Actividad1.Algoritmos;
using Actividad1.Models;


namespace Actividad1
{
    public partial class Form1 : Form
    {
        public Form1()
        {


            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Paso 0: Condicíon de vacío
            if (textBox1.Text.Equals("") ||
                textBox2.Text.Equals("") || textBox3.Text.Equals("") ||
                textBox4.Text.Equals("") ||
                textBox5.Text.Equals(""))
            {
                MessageBox.Show("Los números tienen que ser  NO VACÍOS");
                return;

            }
            int a = Convert.ToInt32(textBox1.Text);
            int c = Convert.ToInt32(textBox2.Text);
            int m = Convert.ToInt32(textBox3.Text);
            int x0 = Convert.ToInt32(textBox4.Text);
            int total = Convert.ToInt32(textBox5.Text);
            // Paso 0: Condicíon de vacío
            if (a <= 0 ||
                c <= 0 || m <= 0 ||
                x0 <= 0 ||
                total <= 0)
            {
                MessageBox.Show("Los números deben ser mayor que CERO");
                return;
            }



            AlgortimoGenerador algoritmo = new AlgortimoGenerador();
            List<int> listaValoresPseudoAleatorios = algoritmo.
                AlgoritmoCongruenciaLineal(a, m, c, x0, total);
            //textBox2.Text = media.ToString();

            llenarGrid3(listaValoresPseudoAleatorios);
        }

        public void llenarGrid2(List<Viaje> lista)
        {
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";


            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Id");
            dataGridView1.Columns.Add(numeroColumna2, "Valor");

            //int i = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (i + 1).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = lista[i].Costo.ToString();
            }

        }
        public void llenarGrid3(List<int> lista)
        {
            string numeroColumna1 = "1";
            string numeroColumna2 = "2";


            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add(numeroColumna1, "Id");
            dataGridView1.Columns.Add(numeroColumna2, "Valor");

            //int i = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna1) - 1].Value = (i + 1).ToString();
                dataGridView1.Rows[i].Cells[Int32.Parse(numeroColumna2) - 1].Value = lista[i].ToString();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}