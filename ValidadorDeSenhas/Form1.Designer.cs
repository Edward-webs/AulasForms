namespace ValidadorDeSenhas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Btn_Reset = new Button();
            Btn_Valida = new Button();
            Lbl_Resultado = new Label();
            Txt_Senha = new TextBox();
            SuspendLayout();
            // 
            // Btn_Reset
            // 
            Btn_Reset.Location = new Point(281, 35);
            Btn_Reset.Name = "Btn_Reset";
            Btn_Reset.Size = new Size(75, 23);
            Btn_Reset.TabIndex = 0;
            Btn_Reset.Text = "Limpar";
            Btn_Reset.UseVisualStyleBackColor = true;
            Btn_Reset.Click += Btn_Reset_Click;
            // 
            // Btn_Valida
            // 
            Btn_Valida.Location = new Point(281, 94);
            Btn_Valida.Name = "Btn_Valida";
            Btn_Valida.Size = new Size(75, 23);
            Btn_Valida.TabIndex = 1;
            Btn_Valida.Text = "Ver Senha";
            Btn_Valida.UseVisualStyleBackColor = true;
            Btn_Valida.Click += Btn_Valida_Click;
            // 
            // Lbl_Resultado
            // 
            Lbl_Resultado.AutoSize = true;
            Lbl_Resultado.Location = new Point(36, 98);
            Lbl_Resultado.Name = "Lbl_Resultado";
            Lbl_Resultado.Size = new Size(0, 15);
            Lbl_Resultado.TabIndex = 2;
            // 
            // Txt_Senha
            // 
            Txt_Senha.Location = new Point(12, 36);
            Txt_Senha.Name = "Txt_Senha";
            Txt_Senha.PasswordChar = '*';
            Txt_Senha.Size = new Size(234, 23);
            Txt_Senha.TabIndex = 3;
            Txt_Senha.KeyDown += Txt_Senha_KeyDown;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(368, 154);
            Controls.Add(Txt_Senha);
            Controls.Add(Lbl_Resultado);
            Controls.Add(Btn_Valida);
            Controls.Add(Btn_Reset);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ValidadorDeSenhas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Btn_Reset;
        private Button Btn_Valida;
        private Label Lbl_Resultado;
        private TextBox Txt_Senha;
    }
}
