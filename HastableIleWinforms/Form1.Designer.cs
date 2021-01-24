namespace HastableIleWinforms
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_alan = new System.Windows.Forms.TextBox();
            this.tb_isim = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.tb_ara = new System.Windows.Forms.TextBox();
            this.btn_ara = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alan Kodu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İl Adı:";
            // 
            // tb_alan
            // 
            this.tb_alan.Location = new System.Drawing.Point(89, 18);
            this.tb_alan.Name = "tb_alan";
            this.tb_alan.Size = new System.Drawing.Size(100, 20);
            this.tb_alan.TabIndex = 2;
            // 
            // tb_isim
            // 
            this.tb_isim.Location = new System.Drawing.Point(89, 53);
            this.tb_isim.Name = "tb_isim";
            this.tb_isim.Size = new System.Drawing.Size(100, 20);
            this.tb_isim.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(220, 18);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(198, 207);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(114, 79);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_ekle.TabIndex = 5;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // tb_ara
            // 
            this.tb_ara.Location = new System.Drawing.Point(17, 130);
            this.tb_ara.Name = "tb_ara";
            this.tb_ara.Size = new System.Drawing.Size(100, 20);
            this.tb_ara.TabIndex = 6;
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(123, 127);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(66, 23);
            this.btn_ara.TabIndex = 7;
            this.btn_ara.Text = "Ara";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 237);
            this.Controls.Add(this.btn_ara);
            this.Controls.Add(this.tb_ara);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.tb_isim);
            this.Controls.Add(this.tb_alan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_alan;
        private System.Windows.Forms.TextBox tb_isim;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox tb_ara;
        private System.Windows.Forms.Button btn_ara;
    }
}

