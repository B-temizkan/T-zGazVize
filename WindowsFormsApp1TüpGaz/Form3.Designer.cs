namespace WindowsFormsApp1TüpGaz
{
    partial class Form3
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
            this.tuş4 = new System.Windows.Forms.Button();
            this.tuş5 = new System.Windows.Forms.Button();
            this.tuş6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "TüpGaz ailesine katılıp kampanyalarımızdan yararlanmak istiyorsanız \nlütfen TüpGa" +
    "z web sitesine üye olmayı unutmayınız.\nHali hazırda sitemize üye olduysanız lütf" +
    "en giriş yapınız.\n\n\n";
            // 
            // tuş4
            // 
            this.tuş4.Location = new System.Drawing.Point(266, 161);
            this.tuş4.Name = "tuş4";
            this.tuş4.Size = new System.Drawing.Size(75, 23);
            this.tuş4.TabIndex = 1;
            this.tuş4.Text = "Kayıt ol ";
            this.tuş4.UseVisualStyleBackColor = true;
            this.tuş4.Click += new System.EventHandler(this.tuş4_Click);
            // 
            // tuş5
            // 
            this.tuş5.Location = new System.Drawing.Point(110, 161);
            this.tuş5.Name = "tuş5";
            this.tuş5.Size = new System.Drawing.Size(75, 23);
            this.tuş5.TabIndex = 2;
            this.tuş5.Text = "Üye girişi";
            this.tuş5.UseVisualStyleBackColor = true;
            this.tuş5.Click += new System.EventHandler(this.tuş5_Click);
            // 
            // tuş6
            // 
            this.tuş6.Location = new System.Drawing.Point(597, 265);
            this.tuş6.Name = "tuş6";
            this.tuş6.Size = new System.Drawing.Size(75, 23);
            this.tuş6.TabIndex = 3;
            this.tuş6.Text = "Anasayfa";
            this.tuş6.UseVisualStyleBackColor = true;
            this.tuş6.Click += new System.EventHandler(this.tuş6_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tuş6);
            this.Controls.Add(this.tuş5);
            this.Controls.Add(this.tuş4);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tuş4;
        private System.Windows.Forms.Button tuş5;
        private System.Windows.Forms.Button tuş6;
    }
}