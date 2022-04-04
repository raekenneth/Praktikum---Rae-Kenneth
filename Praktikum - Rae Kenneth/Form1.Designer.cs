namespace Praktikum___Rae_Kenneth
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
            this.labelKalimat = new System.Windows.Forms.Label();
            this.labelHuruf = new System.Windows.Forms.Label();
            this.labelMenjadi = new System.Windows.Forms.Label();
            this.labelHasil = new System.Windows.Forms.Label();
            this.textBoxKalimat = new System.Windows.Forms.TextBox();
            this.textBoxMenjadi = new System.Windows.Forms.TextBox();
            this.textBoxHuruf = new System.Windows.Forms.TextBox();
            this.buttonKonversi = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelKalimat
            // 
            this.labelKalimat.AutoSize = true;
            this.labelKalimat.Location = new System.Drawing.Point(86, 48);
            this.labelKalimat.Name = "labelKalimat";
            this.labelKalimat.Size = new System.Drawing.Size(104, 15);
            this.labelKalimat.TabIndex = 0;
            this.labelKalimat.Text = "Masukkan Kalimat";
            // 
            // labelHuruf
            // 
            this.labelHuruf.AutoSize = true;
            this.labelHuruf.Location = new System.Drawing.Point(86, 89);
            this.labelHuruf.Name = "labelHuruf";
            this.labelHuruf.Size = new System.Drawing.Size(95, 15);
            this.labelHuruf.TabIndex = 1;
            this.labelHuruf.Text = "Masukkan Huruf";
            // 
            // labelMenjadi
            // 
            this.labelMenjadi.AutoSize = true;
            this.labelMenjadi.Location = new System.Drawing.Point(305, 89);
            this.labelMenjadi.Name = "labelMenjadi";
            this.labelMenjadi.Size = new System.Drawing.Size(50, 15);
            this.labelMenjadi.TabIndex = 2;
            this.labelMenjadi.Text = "Menjadi";
            // 
            // labelHasil
            // 
            this.labelHasil.AutoSize = true;
            this.labelHasil.Location = new System.Drawing.Point(86, 187);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(33, 15);
            this.labelHasil.TabIndex = 3;
            this.labelHasil.Text = "Hasil";
            // 
            // textBoxKalimat
            // 
            this.textBoxKalimat.Location = new System.Drawing.Point(196, 45);
            this.textBoxKalimat.Name = "textBoxKalimat";
            this.textBoxKalimat.Size = new System.Drawing.Size(331, 23);
            this.textBoxKalimat.TabIndex = 4;
            // 
            // textBoxMenjadi
            // 
            this.textBoxMenjadi.Location = new System.Drawing.Point(374, 86);
            this.textBoxMenjadi.Name = "textBoxMenjadi";
            this.textBoxMenjadi.Size = new System.Drawing.Size(153, 23);
            this.textBoxMenjadi.TabIndex = 5;
            this.textBoxMenjadi.TextChanged += new System.EventHandler(this.textBoxMenjadi_TextChanged);
            // 
            // textBoxHuruf
            // 
            this.textBoxHuruf.Location = new System.Drawing.Point(196, 86);
            this.textBoxHuruf.Name = "textBoxHuruf";
            this.textBoxHuruf.Size = new System.Drawing.Size(91, 23);
            this.textBoxHuruf.TabIndex = 6;
            this.textBoxHuruf.TextChanged += new System.EventHandler(this.textBoxHuruf_TextChanged);
            // 
            // buttonKonversi
            // 
            this.buttonKonversi.Location = new System.Drawing.Point(196, 136);
            this.buttonKonversi.Name = "buttonKonversi";
            this.buttonKonversi.Size = new System.Drawing.Size(331, 23);
            this.buttonKonversi.TabIndex = 7;
            this.buttonKonversi.Text = "Konversi";
            this.buttonKonversi.UseVisualStyleBackColor = true;
            this.buttonKonversi.Click += new System.EventHandler(this.buttonKonversi_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResult.Location = new System.Drawing.Point(196, 179);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(74, 25);
            this.labelResult.TabIndex = 8;
            this.labelResult.Text = "RESULT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonKonversi);
            this.Controls.Add(this.textBoxHuruf);
            this.Controls.Add(this.textBoxMenjadi);
            this.Controls.Add(this.textBoxKalimat);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.labelMenjadi);
            this.Controls.Add(this.labelHuruf);
            this.Controls.Add(this.labelKalimat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelKalimat;
        private Label labelHuruf;
        private Label labelMenjadi;
        private Label labelHasil;
        private TextBox textBoxKalimat;
        private TextBox textBoxMenjadi;
        private TextBox textBoxHuruf;
        private Button buttonKonversi;
        private Label labelResult;
    }
}