namespace RestoDivisão
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
                int dividendo = Convert.ToInt32(textBoxDividendo.Text);
                int divisor = Convert.ToInt32(textBoxDivisor.Text);
                RestoDivisão.Utilitario.Calculadora calc = new RestoDivisão.Utilitario.Calculadora();
                int resto = calc.RestoDivisao(dividendo, divisor);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira somente números inteiros válidos!", "Erro de Formato!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("Não é possível realizar uma divisão por zero!", "Erro de Divisão!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
