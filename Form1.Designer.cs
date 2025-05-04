namespace YSA
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
            btnTemizle = new Button();
            panel1 = new Panel();
            e_label = new Label();
            d_label = new Label();
            c_label = new Label();
            b_label = new Label();
            a_label = new Label();
            egitim = new Button();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // btnTemizle
            // 
            btnTemizle.Location = new Point(520, 295);
            btnTemizle.Name = "btnTemizle";
            btnTemizle.Size = new Size(137, 67);
            btnTemizle.TabIndex = 1;
            btnTemizle.Text = "Temizle";
            btnTemizle.UseVisualStyleBackColor = true;
            btnTemizle.Click += btnTemizle_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(e_label);
            panel1.Controls.Add(d_label);
            panel1.Controls.Add(c_label);
            panel1.Controls.Add(b_label);
            panel1.Controls.Add(a_label);
            panel1.Location = new Point(275, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 255);
            panel1.TabIndex = 2;
            // 
            // e_label
            // 
            e_label.AutoSize = true;
            e_label.Location = new Point(117, 220);
            e_label.Name = "e_label";
            e_label.Size = new Size(0, 20);
            e_label.TabIndex = 4;
            // 
            // d_label
            // 
            d_label.AutoSize = true;
            d_label.Location = new Point(117, 186);
            d_label.Name = "d_label";
            d_label.Size = new Size(0, 20);
            d_label.TabIndex = 3;
            // 
            // c_label
            // 
            c_label.AutoSize = true;
            c_label.Location = new Point(117, 137);
            c_label.Name = "c_label";
            c_label.Size = new Size(0, 20);
            c_label.TabIndex = 2;
            // 
            // b_label
            // 
            b_label.AutoSize = true;
            b_label.Location = new Point(117, 73);
            b_label.Name = "b_label";
            b_label.Size = new Size(0, 20);
            b_label.TabIndex = 1;
            // 
            // a_label
            // 
            a_label.AutoSize = true;
            a_label.Location = new Point(117, 24);
            a_label.Name = "a_label";
            a_label.Size = new Size(0, 20);
            a_label.TabIndex = 0;
            // 
            // egitim
            // 
            egitim.Location = new Point(324, 295);
            egitim.Name = "egitim";
            egitim.Size = new Size(137, 67);
            egitim.TabIndex = 3;
            egitim.Text = "Eğit";
            egitim.UseVisualStyleBackColor = true;
            egitim.Click += egitim_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Cursor = Cursors.IBeam;
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            numericUpDown1.Location = new Point(156, 316);
            numericUpDown1.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(81, 27);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 131072 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(23, 318);
            label1.Name = "label1";
            label1.Size = new Size(110, 25);
            label1.TabIndex = 5;
            label1.Text = "Hata Oranı:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 378);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(egitim);
            Controls.Add(panel1);
            Controls.Add(btnTemizle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnTemizle;
        private Panel panel1;
        private Label a_label;
        private Label e_label;
        private Label d_label;
        private Label c_label;
        private Label b_label;
        private Button egitim;
        private NumericUpDown numericUpDown1;
        private Label label1;
    }
}
