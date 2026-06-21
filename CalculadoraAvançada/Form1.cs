using System.Data;
namespace CalculadoraAvançada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Olá! Seja bem-vindo(a)!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double numero = Convert.ToDouble(textBox3.Text);
                CalculadoraAvançada.Classes.Calculos calcSen = new CalculadoraAvançada.Classes.Calculos();
                textBox3.Text = calcSen.Seno(numero).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double numero = Convert.ToDouble(textBox3.Text);
                CalculadoraAvançada.Classes.Calculos calcCos = new CalculadoraAvançada.Classes.Calculos();
                textBox3.Text = calcCos.Cosseno(numero).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double numero = Convert.ToDouble(textBox3.Text);
                CalculadoraAvançada.Classes.Calculos calcTan = new CalculadoraAvançada.Classes.Calculos();
                textBox3.Text = calcTan.Tangente(numero).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox3.Text += "1";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox3.Text += "2";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox3.Text += "3";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox3.Text += "4";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox3.Text += "5";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox3.Text += "6";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox3.Text += "7";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox3.Text += "8";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox3.Text += "9";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox3.Text += "0";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox3.Text += "+";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox3.Text += "*";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox3.Text += "-";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox3.Text += "/";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                var resultado = dt.Compute(textBox3.Text, "");
                textBox3.Text = resultado.ToString();
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("É impossível realizar uma divisão por 0.", "Divisão por 0!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox3.Text = textBox3.Text.Remove(textBox3.Text.Length - 1);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = Convert.ToInt32(textBox3.Text);
                CalculadoraAvançada.Classes.Calculos calcBi = new CalculadoraAvançada.Classes.Calculos();
                textBox3.Text = calcBi.Binario(numero).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(textBox3.Text);
                CalculadoraAvançada.Classes.Calculos calcFa = new CalculadoraAvançada.Classes.Calculos();
                long resultado = calcFa.Fatorial(numero);
                textBox3.Text = resultado.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}