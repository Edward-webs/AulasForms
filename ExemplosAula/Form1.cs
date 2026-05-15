namespace ExemplosAula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtValor1.Text == string.Empty && TxtValor2.Text == string.Empty)
            {
                MessageBox.Show("Não foi possível trocar os valores!\nAmbas as caixas estão vazias. Favor preenche-las.");
            }
            else if (TxtValor1.Text == string.Empty)
            {
                MessageBox.Show("Não foi possível trocar os valores!\nA caixa número 1 está vazia. Favor preenche-lá.");
                TxtValor1.Focus();
            }
            else if (TxtValor2.Text == string.Empty)
            {
                MessageBox.Show("Não foi possível trocar os valores!\nA caixa número 2 está vazia. Favor preenche-lá.");
                TxtValor2.Focus();
            }
            else
            {
                string temp;
                temp = TxtValor1.Text;
                TxtValor1.Text = TxtValor2.Text;
                TxtValor2.Text = temp;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtValor1.BackColor = SystemColors.Info;
            TxtValor2.BackColor = SystemColors.Info;
            MessageBox.Show("Bem vindo(a)!");
        }

        private void TxtValor1_Enter(object sender, EventArgs e)
        {
            TxtValor1.BackColor = SystemColors.Info;
        }

        private void TxtValor1_Leave(object sender, EventArgs e)
        {
            TxtValor1.BackColor = SystemColors.Info;
        }

        private void TxtValor2_Enter(object sender, EventArgs e)
        {
            TxtValor2.BackColor = SystemColors.Info;
        }

        private void TxtValor2_Leave(object sender, EventArgs e)
        {
            TxtValor2.BackColor = SystemColors.Info;
        }
    }
}
