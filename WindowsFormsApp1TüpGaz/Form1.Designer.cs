namespace WindowsFormsApp1TüpGaz
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tuş1 = new System.Windows.Forms.Button();
            this.tuş10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(705, 130);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // tuş1
            // 
            this.tuş1.Location = new System.Drawing.Point(622, 226);
            this.tuş1.Name = "tuş1";
            this.tuş1.Size = new System.Drawing.Size(75, 23);
            this.tuş1.TabIndex = 2;
            this.tuş1.Text = "Sonraki ";
            this.tuş1.UseVisualStyleBackColor = true;
            this.tuş1.Click += new System.EventHandler(this.tuş1_Click);
            // 
            // tuş10
            // 
            this.tuş10.Location = new System.Drawing.Point(69, 225);
            this.tuş10.Name = "tuş10";
            this.tuş10.Size = new System.Drawing.Size(75, 23);
            this.tuş10.TabIndex = 3;
            this.tuş10.Text = "Üye girişi";
            this.tuş10.UseVisualStyleBackColor = true;
            this.tuş10.Click += new System.EventHandler(this.tuş10_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tuş10);
            this.Controls.Add(this.tuş1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button tuş1;
        private System.Windows.Forms.Button tuş10;
    }
}

