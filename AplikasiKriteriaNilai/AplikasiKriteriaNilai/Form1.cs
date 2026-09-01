using System;
using System.Windows.Forms;

namespace AplikasiKriteriaNilai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.labelHasil.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold);

            labelInfo.Text = "[*] Istimewa (90-100)\n" +
                           "['1] Sangat Baik (80-89)\n" +
                           "['2] Baik (70-79)\n" +
                           "['3] Cukup Baik (50-69)\n" +
                           "[!] Kurang Baik (35-49)\n" +
                           "[X] Buruk (10-34)\n" +
                           "[0] Gagal (0-9)";
            this.linkLabelEmail.AutoSize = true;
            this.linkLabelEmail.Font = new System.Drawing.Font("Arial", 9F);
            this.linkLabelEmail.Location = new System.Drawing.Point(30, 320);
            this.linkLabelEmail.Name = "linkLabelEmail";
            this.linkLabelEmail.Size = new System.Drawing.Size(200, 16);
            this.linkLabelEmail.TabIndex = 8;
            this.linkLabelEmail.TabStop = true;
            this.linkLabelEmail.Text = "📧 Contact: mhanchoraf0ankinjar@gmail.com\n📧 Contact: afifansyah269301@student.smkn1kandeman.sch.id";
            this.linkLabelEmail.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelEmail_LinkClicked);
            this.Controls.Add(this.linkLabelEmail);
        }

        private void buttonProses_Click(object sender, EventArgs e)
        {
            string input = textBoxNilai.Text;
            int nilai;
            bool berhasil = int.TryParse(input, out nilai);

            if (!berhasil || nilai < 0 || nilai > 100)
            {
                MessageBox.Show("Masukkan Hanya Angka Min 0 dan Maks 100!",
                    "Error Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                textBoxNilai.Focus();
                return;
            }

            string hasil = "";

            if (nilai >= 90 && nilai <= 100)
                hasil = "⭐ ISTIMEWA ⭐";
            else if (nilai >= 80 && nilai <= 89)
                hasil = "👍 SANGAT BAIK 👍";
            else if (nilai >= 70 && nilai <= 79)
                hasil = "✓ BAIK ✓";
            else if (nilai >= 50 && nilai <= 69)
                hasil = "CUKUP BAIK";
            else if (nilai >= 35 && nilai <= 49)
                hasil = "⚠️ KURANG BAIK ⚠️";
            else if (nilai >= 10 && nilai <= 34)
                hasil = "❌ BURUK ❌";
            else if (nilai >= 0 && nilai <= 9)
                hasil = "❌ GAGAL ❌";

            labelHasil.Text = $"Nilai: {nilai}\nKriteria: {hasil}";
            labelHasil.ForeColor = System.Drawing.Color.Green;
            labelHasil.Font = new System.Drawing.Font("Segoe UI Symbol", 12, System.Drawing.FontStyle.Bold);
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNilai.Clear();
            labelHasil.Text = "";
            textBoxNilai.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Yakin ingin keluar?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Terima kasih telah menggunakan aplikasi ini!\nBerikan Kritik & Saranmu agar saya dapat mengembangkan program ini!\nBy AfifFans1703",
                    "Keluar",
                    MessageBoxButtons.OK);
                Application.Exit();
            }
        }

        private void textBoxNilai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
            {
                e.Handled = true;
                buttonProses_Click(sender, EventArgs.Empty);
            }
        }
        private void linkLabelEmail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Buka email client dengan alamat email yang sudah ditentukan
            System.Diagnostics.Process.Start("mailto:mhanchoraf0ankinjar@gmail.com");
        }
    }
}