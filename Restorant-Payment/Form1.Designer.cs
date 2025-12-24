namespace Restorant_Payment
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnCocaCola = new Button();
            btnFanta = new Button();
            btnDondurma = new Button();
            btnPatlican = new Button();
            btnBiber = new Button();
            btndomates = new Button();
            btnNakit = new Button();
            btnKrediKarti = new Button();
            dG1 = new DataGridView();
            Sil = new DataGridViewButtonColumn();
            lbToplam = new Label();
            groupBox1 = new GroupBox();
            gBAdet = new GroupBox();
            btnVazgec = new Button();
            btnkaydet = new Button();
            txtAdet = new TextBox();
            label1 = new Label();
            btnKapat = new Button();
            ((System.ComponentModel.ISupportInitialize)dG1).BeginInit();
            gBAdet.SuspendLayout();
            SuspendLayout();
            // 
            // btnCocaCola
            // 
            btnCocaCola.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnCocaCola.Location = new Point(-10, 3);
            btnCocaCola.Name = "btnCocaCola";
            btnCocaCola.Size = new Size(227, 114);
            btnCocaCola.TabIndex = 0;
            btnCocaCola.TabStop = false;
            btnCocaCola.Text = "CocaCola";
            btnCocaCola.UseVisualStyleBackColor = true;
            btnCocaCola.Click += btnCocaCola_Click;
            // 
            // btnFanta
            // 
            btnFanta.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnFanta.Location = new Point(223, 3);
            btnFanta.Name = "btnFanta";
            btnFanta.Size = new Size(227, 114);
            btnFanta.TabIndex = 1;
            btnFanta.TabStop = false;
            btnFanta.Text = "Fanta";
            btnFanta.UseVisualStyleBackColor = true;
            btnFanta.Click += btnFanta_Click;
            // 
            // btnDondurma
            // 
            btnDondurma.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnDondurma.Location = new Point(456, 3);
            btnDondurma.Name = "btnDondurma";
            btnDondurma.Size = new Size(227, 114);
            btnDondurma.TabIndex = 2;
            btnDondurma.TabStop = false;
            btnDondurma.Text = "Dondurma";
            btnDondurma.UseVisualStyleBackColor = true;
            btnDondurma.Click += btnDondurma_Click;
            // 
            // btnPatlican
            // 
            btnPatlican.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnPatlican.Location = new Point(456, 123);
            btnPatlican.Name = "btnPatlican";
            btnPatlican.Size = new Size(227, 114);
            btnPatlican.TabIndex = 5;
            btnPatlican.TabStop = false;
            btnPatlican.Text = "Patlican";
            btnPatlican.UseVisualStyleBackColor = true;
            btnPatlican.Click += btnPatlican_Click;
            // 
            // btnBiber
            // 
            btnBiber.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnBiber.Location = new Point(223, 123);
            btnBiber.Name = "btnBiber";
            btnBiber.Size = new Size(227, 114);
            btnBiber.TabIndex = 4;
            btnBiber.TabStop = false;
            btnBiber.Text = "Biber";
            btnBiber.UseVisualStyleBackColor = true;
            btnBiber.Click += btnBiber_Click;
            // 
            // btndomates
            // 
            btndomates.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btndomates.Location = new Point(-10, 121);
            btndomates.Name = "btndomates";
            btndomates.Size = new Size(227, 114);
            btndomates.TabIndex = 3;
            btndomates.TabStop = false;
            btndomates.Text = "Domates";
            btndomates.UseVisualStyleBackColor = true;
            btndomates.Click += btndomates_Click;
            // 
            // btnNakit
            // 
            btnNakit.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnNakit.Location = new Point(242, 529);
            btnNakit.Name = "btnNakit";
            btnNakit.Size = new Size(227, 114);
            btnNakit.TabIndex = 7;
            btnNakit.TabStop = false;
            btnNakit.Text = "Nakit";
            btnNakit.UseVisualStyleBackColor = true;
            btnNakit.Click += btnNakit_Click;
            // 
            // btnKrediKarti
            // 
            btnKrediKarti.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnKrediKarti.Location = new Point(9, 529);
            btnKrediKarti.Name = "btnKrediKarti";
            btnKrediKarti.Size = new Size(227, 114);
            btnKrediKarti.TabIndex = 6;
            btnKrediKarti.TabStop = false;
            btnKrediKarti.Text = "Kredi Karti";
            btnKrediKarti.UseVisualStyleBackColor = true;
            btnKrediKarti.Click += btnKrediKarti_Click;
            // 
            // dG1
            // 
            dG1.AllowUserToAddRows = false;
            dG1.AllowUserToDeleteRows = false;
            dG1.AllowUserToResizeRows = false;
            dG1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dG1.Columns.AddRange(new DataGridViewColumn[] { Sil });
            dG1.Location = new Point(689, 12);
            dG1.Name = "dG1";
            dG1.RowHeadersVisible = false;
            dG1.RowTemplate.Height = 25;
            dG1.Size = new Size(628, 471);
            dG1.TabIndex = 8;
            dG1.TabStop = false;
            dG1.CellContentClick += dG1_CellContentClick;
            // 
            // Sil
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Sil";
            Sil.DefaultCellStyle = dataGridViewCellStyle1;
            Sil.HeaderText = "Sil";
            Sil.Name = "Sil";
            Sil.Text = "Sil";
            // 
            // lbToplam
            // 
            lbToplam.AutoSize = true;
            lbToplam.Font = new Font("Segoe UI", 60F, FontStyle.Regular, GraphicsUnit.Point);
            lbToplam.Location = new Point(934, 508);
            lbToplam.Name = "lbToplam";
            lbToplam.Size = new Size(191, 106);
            lbToplam.TabIndex = 9;
            lbToplam.Text = "0,00";
            lbToplam.Click += lbToplam_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(300, 319);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(8, 8);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // gBAdet
            // 
            gBAdet.Controls.Add(btnVazgec);
            gBAdet.Controls.Add(btnkaydet);
            gBAdet.Controls.Add(txtAdet);
            gBAdet.Controls.Add(label1);
            gBAdet.Location = new Point(300, 293);
            gBAdet.Name = "gBAdet";
            gBAdet.Size = new Size(135, 146);
            gBAdet.TabIndex = 11;
            gBAdet.TabStop = false;
            gBAdet.Visible = false;
            gBAdet.Enter += groupBox2_Enter;
            // 
            // btnVazgec
            // 
            btnVazgec.Location = new Point(10, 103);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.Size = new Size(51, 27);
            btnVazgec.TabIndex = 4;
            btnVazgec.Text = "Vazgec";
            btnVazgec.UseVisualStyleBackColor = true;
            btnVazgec.Click += btnVazgec_Click;
            // 
            // btnkaydet
            // 
            btnkaydet.Location = new Point(10, 64);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(51, 33);
            btnkaydet.TabIndex = 3;
            btnkaydet.Text = "Kaydet";
            btnkaydet.UseVisualStyleBackColor = true;
            btnkaydet.Click += button1_Click_1;
            // 
            // txtAdet
            // 
            txtAdet.Cursor = Cursors.No;
            txtAdet.Location = new Point(10, 38);
            txtAdet.Name = "txtAdet";
            txtAdet.Size = new Size(69, 20);
            txtAdet.TabIndex = 2;
            txtAdet.Text = "1";
            txtAdet.TextAlign = HorizontalAlignment.Center;
            txtAdet.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(0, 13);
            label1.Name = "label1";
            label1.Size = new Size(89, 21);
            label1.TabIndex = 1;
            label1.Text = "Adet";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnKapat
            // 
            btnKapat.BackColor = Color.Red;
            btnKapat.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnKapat.Location = new Point(475, 529);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(227, 114);
            btnKapat.TabIndex = 12;
            btnKapat.TabStop = false;
            btnKapat.Text = "Cıkış Yap";
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += button1_Click_2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1339, 643);
            Controls.Add(btnKapat);
            Controls.Add(gBAdet);
            Controls.Add(groupBox1);
            Controls.Add(lbToplam);
            Controls.Add(dG1);
            Controls.Add(btnNakit);
            Controls.Add(btnKrediKarti);
            Controls.Add(btnPatlican);
            Controls.Add(btnBiber);
            Controls.Add(btndomates);
            Controls.Add(btnDondurma);
            Controls.Add(btnFanta);
            Controls.Add(btnCocaCola);
            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dG1).EndInit();
            gBAdet.ResumeLayout(false);
            gBAdet.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCocaCola;
        private Button btnFanta;
        private Button btnDondurma;
        private Button btnPatlican;
        private Button btnBiber;
        private Button btndomates;
        private Button btnNakit;
        private Button btnKrediKarti;
        private DataGridView dG1;
        public Label lbToplam;
        private GroupBox groupBox1;
        private GroupBox gBAdet;
        private Label label1;
        private TextBox txtAdet;
        private Button btnkaydet;
        private Button btnVazgec;
        private Button btnKapat;
        private DataGridViewButtonColumn Sil;
    }
}
