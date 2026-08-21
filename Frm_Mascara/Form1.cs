using System.Globalization;

namespace Frm_Mascara
{
    public partial class Form1 : Form
    {
        bool VerConteudotxt = false;
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
            Msk_TextBox.Mask = "$ 000,000,000.00";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
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
            Msk_TextBox.Mask = "(00) 0000-0000";
            Lbl_MascaraAtiva.Text = Msk_TextBox.Mask;
            Msk_TextBox.Text = "";
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
    }
}
