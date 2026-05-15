namespace ExemplosAula
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
            TxtValor1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxtValor2 = new TextBox();
            BtnTroca = new Button();
            SuspendLayout();
            // 
            // TxtValor1
            // 
            TxtValor1.BackColor = SystemColors.Window;
            TxtValor1.Location = new Point(63, 6);
            TxtValor1.Name = "TxtValor1";
            TxtValor1.Size = new Size(147, 23);
            TxtValor1.TabIndex = 0;
            TxtValor1.TextChanged += textBox1_TextChanged;
            TxtValor1.Enter += TxtValor1_Enter;
            TxtValor1.Leave += TxtValor1_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.ForeColor = Color.Red;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Valor 1:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.ForeColor = Color.Red;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 3;
            label2.Text = "Valor 2:";
            // 
            // TxtValor2
            // 
            TxtValor2.Location = new Point(63, 67);
            TxtValor2.Name = "TxtValor2";
            TxtValor2.Size = new Size(147, 23);
            TxtValor2.TabIndex = 2;
            TxtValor2.Enter += TxtValor2_Enter;
            TxtValor2.Leave += TxtValor2_Leave;
            // 
            // BtnTroca
            // 
            BtnTroca.BackColor = SystemColors.ActiveCaption;
            BtnTroca.ForeColor = Color.Red;
            BtnTroca.Location = new Point(251, 12);
            BtnTroca.Name = "BtnTroca";
            BtnTroca.Size = new Size(189, 70);
            BtnTroca.TabIndex = 4;
            BtnTroca.Text = "Trocar Valores";
            BtnTroca.UseVisualStyleBackColor = false;
            BtnTroca.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1465, 641);
            Controls.Add(BtnTroca);
            Controls.Add(label2);
            Controls.Add(TxtValor2);
            Controls.Add(label1);
            Controls.Add(TxtValor1);
            Name = "Form1";
            Text = "Troca de Valores";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtValor1;
        private Label label1;
        private Label label2;
        private TextBox TxtValor2;
        private Button BtnTroca;
    }
}
