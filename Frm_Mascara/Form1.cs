using System.Globalization;

namespace Frm_Mascara
{
    public partial class Form1 : Form
    {

        private string FormatarTelefone(string numeros)
        {
            if (numeros.Length == 0)
                return "(00) 00000-0000";

            if (numeros.Length <= 2)
                return "(00) " + numeros;

            if (numeros.Length <= 7)
                return "(00) " + numeros.Substring(0, numeros.Length - 1)
                    + "-" + numeros.Substring(numeros.Length - 1);

            return "(00) " +
                   numeros.Substring(0, Math.Min(5, numeros.Length)) +
                   "-" +
                   numeros.Substring(Math.Min(5, numeros.Length));
        }

        bool VerConteudotxt = false;

        string digitosMoeda = "";
        string digitosTelefone = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Hora_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00:00";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
        }

        private void Btn_VerConteudo_Click(object sender, EventArgs e)
        {
            if (Msk_TextBox.Mask == "00:00")
            {
                if (!DateTime.TryParseExact(
                    Msk_TextBox.Text,
                    "HH:mm",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime hora))
                {
                    MessageBox.Show("Digite uma hora válida!");
                    Msk_TextBox.Focus();
                    return;
                }
            }

            if (Msk_TextBox.Mask == "00/00/0000")
            {
                if (!DateTime.TryParseExact(
                    Msk_TextBox.Text,
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime data))
                {
                    MessageBox.Show("Digite uma data válida!");
                    Msk_TextBox.Focus();
                    return;
                }
            }

            Lbl_Conteudo.Text = Msk_TextBox.Text;

            if (VerConteudotxt == false)
            {
                Msk_TextBox.PasswordChar = '\0';
                VerConteudotxt = true;
            }
            else
            {
                Msk_TextBox.PasswordChar = '*';
                VerConteudotxt = false;
            }
        }

        private void Btn_CEP_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00000-000";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
        }

        private void Btn_Moeda_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "";
            Msk_TextBox.Text = "R$ 0,00";
            Lbl_MascaraAtiva.Text = "R$ 0,00";
            digitosMoeda = "";
            Msk_TextBox.Focus();
        }

        private void Btn_Data_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "00/00/0000";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
            Msk_TextBox.Focus();
        }

        private void Btn_Telefone_Click(object sender, EventArgs e)
        {
            Msk_TextBox.UseSystemPasswordChar = false;
            Lbl_Conteudo.Text = "";
            Msk_TextBox.Mask = "";
            Msk_TextBox.Text = "(00) 0000-0000";
            Lbl_MascaraAtiva.Text = "(00) 0000-0000";
            digitosTelefone = "";
            Msk_TextBox.Focus();
        }

        private void Msk_TextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Btn_Senha_Click(object sender, EventArgs e)
        {

        }

        private void Msk_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Msk_TextBox.Mask == "")
            {
                if (Msk_TextBox.Text.StartsWith("R$"))
                {
                    if (char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;

                        digitosMoeda += e.KeyChar;

                        if (digitosMoeda.Length > 11)
                            digitosMoeda = digitosMoeda.Substring(1);

                        decimal valor = decimal.Parse(digitosMoeda) / 100;

                        Msk_TextBox.Text = valor.ToString("C2");
                        Msk_TextBox.SelectionStart = Msk_TextBox.Text.Length;
                    }

                    if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = true;

                        if (digitosMoeda.Length > 0)
                            digitosMoeda = digitosMoeda.Substring(0, digitosMoeda.Length - 1);

                        if (digitosMoeda.Length == 0)
                        {
                            Msk_TextBox.Text = "R$ 0,00";
                        }
                        else
                        {
                            decimal valor = decimal.Parse(digitosMoeda) / 100;
                            Msk_TextBox.Text = valor.ToString("C2");
                        }

                        Msk_TextBox.SelectionStart = Msk_TextBox.Text.Length;
                    }
                }

                else if (Msk_TextBox.Text.StartsWith("(00)"))
                {
                    if (char.IsDigit(e.KeyChar))
                    {
                        e.Handled = true;

                        digitosTelefone += e.KeyChar;

                        if (digitosTelefone.Length > 11)
                            digitosTelefone = digitosTelefone.Substring(1);

                        Msk_TextBox.Text = FormatarTelefone(digitosTelefone);
                        Msk_TextBox.SelectionStart = Msk_TextBox.Text.Length;
                    }

                    if (e.KeyChar == (char)Keys.Back)
                    {
                        e.Handled = true;

                        if (digitosTelefone.Length > 0)
                            digitosTelefone = digitosTelefone.Substring(
                                0,
                                digitosTelefone.Length - 1
                            );

                        Msk_TextBox.Text = FormatarTelefone(digitosTelefone);
                        Msk_TextBox.SelectionStart = Msk_TextBox.Text.Length;
                    }
                }
            }
        }
    }
}
