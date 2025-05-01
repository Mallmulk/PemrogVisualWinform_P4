namespace Ntahlah
{
    partial class FormStart
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMulai;

     
        private void InitializeComponent()
        {
            label1 = new Label();
            btnMulai = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 50);
            label1.Name = "label1";
            label1.Size = new Size(199, 25);
            label1.TabIndex = 0;
            label1.Text = "Selamat datang di quiz!";
            // 
            // btnMulai
            // 
            btnMulai.Location = new Point(100, 100);
            btnMulai.Name = "btnMulai";
            btnMulai.Size = new Size(75, 40);
            btnMulai.TabIndex = 1;
            btnMulai.Text = "Mulai";
            btnMulai.UseVisualStyleBackColor = true;
            btnMulai.Click += btnMulai_Click;
            // 
            // FormStart
            // 
            ClientSize = new Size(323, 238);
            Controls.Add(label1);
            Controls.Add(btnMulai);
            Name = "FormStart";
            Text = "FormStart";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
