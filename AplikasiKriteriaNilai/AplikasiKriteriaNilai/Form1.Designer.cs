namespace AplikasiKriteriaNilai
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelNilai = new System.Windows.Forms.Label();
            this.textBoxNilai = new System.Windows.Forms.TextBox();
            this.buttonProses = new System.Windows.Forms.Button();
            this.labelHasil = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.linkLabelEmail = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.labelTitle.Location = new System.Drawing.Point(100, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(354, 22);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "PROGRAM EVALUASI KRITERIA NILAI";
            // 
            // labelNilai
            // 
            this.labelNilai.AutoSize = true;
            this.labelNilai.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNilai.Location = new System.Drawing.Point(29, 67);
            this.labelNilai.Name = "labelNilai";
            this.labelNilai.Size = new System.Drawing.Size(133, 21);
            this.labelNilai.TabIndex = 1;
            this.labelNilai.Text = "Masukkan Nilai :";
            // 
            // textBoxNilai
            // 
            this.textBoxNilai.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.textBoxNilai.Location = new System.Drawing.Point(168, 67);
            this.textBoxNilai.Name = "textBoxNilai";
            this.textBoxNilai.Size = new System.Drawing.Size(72, 23);
            this.textBoxNilai.TabIndex = 2;
            this.textBoxNilai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNilai_KeyPress);
            // 
            // buttonProses
            // 
            this.buttonProses.BackColor = System.Drawing.Color.Green;
            this.buttonProses.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonProses.ForeColor = System.Drawing.Color.White;
            this.buttonProses.Location = new System.Drawing.Point(284, 61);
            this.buttonProses.Name = "buttonProses";
            this.buttonProses.Size = new System.Drawing.Size(80, 35);
            this.buttonProses.TabIndex = 3;
            this.buttonProses.Text = "PROCESS";
            this.buttonProses.UseVisualStyleBackColor = false;
            this.buttonProses.Click += new System.EventHandler(this.buttonProses_Click);
            // 
            // labelHasil
            //
            this.labelHasil.AutoSize = true;
            this.labelHasil.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold);
            this.labelHasil.ForeColor = System.Drawing.Color.Green;
            this.labelHasil.Location = new System.Drawing.Point(30, 165);
            this.labelHasil.Name = "labelHasil";
            this.labelHasil.Size = new System.Drawing.Size(0, 19);
            this.labelHasil.TabIndex = 6;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Orange;
            this.buttonClear.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.buttonClear.ForeColor = System.Drawing.Color.White;
            this.buttonClear.Location = new System.Drawing.Point(446, 393);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(80, 35);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.Red;
            this.buttonExit.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.buttonExit.ForeColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(532, 394);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(80, 35);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(369, 65);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(102, 21);
            this.labelInfo.TabIndex = 7;
            this.labelInfo.Text = "Kriteria Nilai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Kriteria :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelNilai);
            this.Controls.Add(this.textBoxNilai);
            this.Controls.Add(this.buttonProses);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.labelHasil);
            this.Controls.Add(this.labelInfo);
            this.Name = "Form1";
            this.Text = "Aplikasi Kriteria Nilai v1.0 By AfifFans1703";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelNilai;
        private System.Windows.Forms.TextBox textBoxNilai;
        private System.Windows.Forms.Button buttonProses;
        private System.Windows.Forms.Label labelHasil;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabelEmail;
    }
}