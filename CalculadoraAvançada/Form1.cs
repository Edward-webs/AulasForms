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
            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty)
            {
                MessageBox.Show("Não foi possível calcular o seno de um valor!\nAmbas as caixas estão vazias. Favor preenche-las.");
            }
            else if (textBox2.Text == string.Empty)
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
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro inesperado: {ex.Message}", "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (textBox1.Text == string.Empty)
            {
                try
                {
                    double numero = Convert.ToDouble(textBox2.Text);
                    CalculadoraAvançada.Classes.Calculos calcSen = new CalculadoraAvançada.Classes.Calculos();
                    textBox3.Text = calcSen.Seno(numero).ToString();
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
            else if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                MessageBox.Show("Não foi possível calcular o seno dos dois valores!\nAmbas as caixas estão preenchidas. Favor preencha somente uma caixa de texto.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty)
            {
                MessageBox.Show("Não foi possível calcular o seno de um valor!\nAmbas as caixas estão vazias. Favor preenche-las.");
            }
            else if (textBox2.Text == string.Empty)
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
            else if (textBox1.Text == string.Empty)
            {
                try
                {
                    double numero = Convert.ToDouble(textBox2.Text);
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
            else if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                MessageBox.Show("Não foi possível calcular o seno dos dois valores!\nAmbas as caixas estão preenchidas. Favor preencha somente uma caixa de texto.");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty)
            {
                MessageBox.Show("Não foi possível calcular o seno de um valor!\nAmbas as caixas estão vazias. Favor preenche-las.");
            }
            else if (textBox2.Text == string.Empty)
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
            else if (textBox1.Text == string.Empty)
            {
                try
                {
                    double numero = Convert.ToDouble(textBox2.Text);
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
            else if (textBox1.Text != string.Empty && textBox2.Text != string.Empty)
            {
                MessageBox.Show("Não foi possível calcular o seno dos dois valores!\nAmbas as caixas estão preenchidas. Favor preencha somente uma caixa de texto.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty)
            {
                MessageBox.Show("Não foi possível calcular a soma de dois valores!\nAmbas as caixas estão vazias. Favor preenche-las.");
            }
            else if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Não foi possível somar os valores!\nA caixa número 1 está vazia. Favor preenche-lá.");
                textBox1.Focus();
            }
            else if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Não foi possível somar os valores!\nA caixa número 2 está vazia. Favor preenche-lá.");
                textBox2.Focus();
            }
            else
            {
                try
                {
                    double numero1 = Convert.ToDouble(textBox1.Text);
                    double numero2 = Convert.ToDouble(textBox2.Text);
                    CalculadoraAvançada.Classes.Calculos calcsoma = new CalculadoraAvançada.Classes.Calculos();

                    double resultadosoma = calcsoma.Soma(numero1, numero2);
                    textBox3.Text = resultadosoma.ToString();
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty)
            {
                MessageBox.Show("Não foi possível calcular a subtração de dois valores!\nAmbas as caixas estão vazias. Favor preenche-las.");
            }
            else if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Não foi possível subtrair os valores!\nA caixa número 1 está vazia. Favor preenche-lá.");
                textBox1.Focus();
            }
            else if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Não foi possível subtrair os valores!\nA caixa número 2 está vazia. Favor preenche-lá.");
                textBox2.Focus();
            }
            else
            {
                try
                {
                    double numero1 = Convert.ToDouble(textBox1.Text);
                    double numero2 = Convert.ToDouble(textBox2.Text);
                    CalculadoraAvançada.Classes.Calculos calcsubtracao = new CalculadoraAvançada.Classes.Calculos();

                    double resultadosubtracao = calcsubtracao.Subtracao(numero1, numero2);
                    textBox3.Text = resultadosubtracao.ToString();
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

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty)
            {
                MessageBox.Show("Não foi possível calcular a divisão de dois valores!\nAmbas as caixas estão vazias. Favor preenche-las.");
            }
            else if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Não foi possível dividir os valores!\nA caixa número 1 está vazia. Favor preenche-lá.");
                textBox1.Focus();
            }
            else if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Não foi possível dividir os valores!\nA caixa número 2 está vazia. Favor preenche-lá.");
                textBox2.Focus();
            }
            else
            {
                try
                {
                    double numero1 = Convert.ToDouble(textBox1.Text);
                    double numero2 = Convert.ToDouble(textBox2.Text);
                    CalculadoraAvançada.Classes.Calculos calcdivisao = new CalculadoraAvançada.Classes.Calculos();

                    double resultadodivisao = calcdivisao.Divisao(numero1, numero2);
                    textBox3.Text = resultadodivisao.ToString();
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

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty && textBox2.Text == string.Empty)
            {
                MessageBox.Show("Não foi possível calcular a multiplicação de dois valores!\nAmbas as caixas estão vazias. Favor preenche-las.");
            }
            else if (textBox1.Text == string.Empty)
            {
                MessageBox.Show("Não foi possível multiplicar os valores!\nA caixa número 1 está vazia. Favor preenche-lá.");
                textBox1.Focus();
            }
            else if (textBox2.Text == string.Empty)
            {
                MessageBox.Show("Não foi possível multiplicar os valores!\nA caixa número 2 está vazia. Favor preenche-lá.");
                textBox2.Focus();
            }
            else
            {
                try
                {
                    double numero1 = Convert.ToDouble(textBox1.Text);
                    double numero2 = Convert.ToDouble(textBox2.Text);
                    CalculadoraAvançada.Classes.Calculos calcmultiplicacao = new CalculadoraAvançada.Classes.Calculos();

                    double resultadomultiplicação = calcmultiplicacao.Multiplicação(numero1, numero2);
                    textBox3.Text = resultadomultiplicação.ToString();
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
}
