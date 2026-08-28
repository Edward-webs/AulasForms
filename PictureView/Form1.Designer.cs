namespace PictureView
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
            tableLayoutPanel1 = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            BtnFechar = new Button();
            BtnLimpar = new Button();
            BtnCorDeFundo = new Button();
            BtnExibir = new Button();
            openFileDialog1 = new OpenFileDialog();
            colorDialog1 = new ColorDialog();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(checkBox1, 0, 1);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(1108, 558);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            tableLayoutPanel1.SetColumnSpan(pictureBox1, 2);
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1102, 496);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(3, 505);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(63, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "Stretch";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(BtnFechar);
            flowLayoutPanel1.Controls.Add(BtnLimpar);
            flowLayoutPanel1.Controls.Add(BtnCorDeFundo);
            flowLayoutPanel1.Controls.Add(BtnExibir);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(169, 505);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(936, 50);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // BtnFechar
            // 
            BtnFechar.AutoSize = true;
            BtnFechar.Location = new Point(858, 3);
            BtnFechar.Name = "BtnFechar";
            BtnFechar.Size = new Size(75, 25);
            BtnFechar.TabIndex = 3;
            BtnFechar.Text = "Fechar";
            BtnFechar.UseVisualStyleBackColor = true;
            BtnFechar.Click += BtnFechar_Click;
            // 
            // BtnLimpar
            // 
            BtnLimpar.AutoSize = true;
            BtnLimpar.Location = new Point(742, 3);
            BtnLimpar.Name = "BtnLimpar";
            BtnLimpar.Size = new Size(110, 25);
            BtnLimpar.TabIndex = 2;
            BtnLimpar.Text = "Limpar a Imagem";
            BtnLimpar.UseVisualStyleBackColor = true;
            BtnLimpar.Click += BtnLimpar_Click;
            // 
            // BtnCorDeFundo
            // 
            BtnCorDeFundo.AutoSize = true;
            BtnCorDeFundo.Location = new Point(613, 3);
            BtnCorDeFundo.Name = "BtnCorDeFundo";
            BtnCorDeFundo.Size = new Size(123, 25);
            BtnCorDeFundo.TabIndex = 1;
            BtnCorDeFundo.Text = "Definir cor de fundo";
            BtnCorDeFundo.UseVisualStyleBackColor = true;
            BtnCorDeFundo.Click += BtnCorDeFundo_Click;
            // 
            // BtnExibir
            // 
            BtnExibir.AutoSize = true;
            BtnExibir.Location = new Point(488, 3);
            BtnExibir.Name = "BtnExibir";
            BtnExibir.Size = new Size(119, 25);
            BtnExibir.TabIndex = 0;
            BtnExibir.Text = "Exibir uma imagem";
            BtnExibir.UseVisualStyleBackColor = true;
            BtnExibir.Click += BtnExibir_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Filter = "JPEG Files (*.jpg)|*jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*bmp|All files (*.*)|*.*";
            openFileDialog1.Title = "Selecionar um arquivo de imagem";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 558);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Picture View";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button BtnFechar;
        private Button BtnLimpar;
        private Button BtnCorDeFundo;
        private Button BtnExibir;
        private OpenFileDialog openFileDialog1;
        private ColorDialog colorDialog1;
    }
}
