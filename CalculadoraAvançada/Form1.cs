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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double numero = Convert.ToDouble(textBox1.Text);
                CalculadoraAvançada.Classes.Calculos calcSen = new CalculadoraAvançada.Classes.Calculos();
                textBox3.Text = calcSen.Seno(numero).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira somente números.", "Erro de Formato!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double numero = Convert.ToDouble(textBox1.Text);
                CalculadoraAvançada.Classes.Calculos calcCos = new CalculadoraAvançada.Classes.Calculos();
                textBox3.Text = calcCos.Cosseno(numero).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira somente números.", "Erro de Formato!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                double numero = Convert.ToDouble(textBox1.Text);
                CalculadoraAvançada.Classes.Calculos calcTan = new CalculadoraAvançada.Classes.Calculos();
                textBox3.Text = calcTan.Tangente(numero).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira somente números.", "Erro de Formato!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
