namespace Restorant_Payment
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            gBAdet = new GroupBox();
            btnVazgec = new Button();
            btnkaydet = new Button();
            txtAdet = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            gBAdet.SuspendLayout();
            SuspendLayout();
            // 
            // gBAdet
            // 
            gBAdet.Controls.Add(btnVazgec);
            gBAdet.Controls.Add(btnkaydet);
            gBAdet.Controls.Add(txtAdet);
            gBAdet.Controls.Add(label1);
            gBAdet.Location = new Point(65, 42);
            gBAdet.Name = "gBAdet";
            gBAdet.Size = new Size(190, 219);
            gBAdet.TabIndex = 13;
            gBAdet.TabStop = false;
            // 
            // btnVazgec
            // 
            btnVazgec.Location = new Point(6, 155);
            btnVazgec.Name = "btnVazgec";
            btnVazgec.Size = new Size(101, 42);
            btnVazgec.TabIndex = 4;
            btnVazgec.Text = "Vazgec";
            btnVazgec.UseVisualStyleBackColor = true;
            // 
            // btnkaydet
            // 
            btnkaydet.Location = new Point(6, 105);
            btnkaydet.Name = "btnkaydet";
            btnkaydet.Size = new Size(101, 44);
            btnkaydet.TabIndex = 3;
            btnkaydet.Text = "Kaydet";
            btnkaydet.UseVisualStyleBackColor = true;
            btnkaydet.Click += btnkaydet_Click;
            // 
            // txtAdet
            // 
            txtAdet.Cursor = Cursors.No;
            txtAdet.Location = new Point(6, 60);
            txtAdet.Name = "txtAdet";
            txtAdet.Size = new Size(118, 39);
            txtAdet.TabIndex = 2;
            txtAdet.Text = "1";
            txtAdet.TextAlign = HorizontalAlignment.Center;
            txtAdet.TextChanged += txtAdet_TextChanged;
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(6, 25);
            label1.Name = "label1";
            label1.Size = new Size(89, 31);
            label1.TabIndex = 1;
            label1.Text = "Adet";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(412, 253);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(8, 8);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 296);
            Controls.Add(gBAdet);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(6);
            Name = "Form2";
            Text = "Ürün Adedi";
            Load += Form2_Load;
            gBAdet.ResumeLayout(false);
            gBAdet.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gBAdet;
        private Button btnVazgec;
        private Button btnkaydet;
        private TextBox txtAdet;
        private Label label1;
        private GroupBox groupBox1;
    }
}