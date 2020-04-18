namespace WindowsFormsApp1TüpGaz
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.tuş2 = new System.Windows.Forms.Button();
            this.tuş3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 156);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // tuş2
            // 
            this.tuş2.Location = new System.Drawing.Point(636, 253);
            this.tuş2.Name = "tuş2";
            this.tuş2.Size = new System.Drawing.Size(75, 23);
            this.tuş2.TabIndex = 1;
            this.tuş2.Text = "Sonraki";
            this.tuş2.UseVisualStyleBackColor = true;
            this.tuş2.Click += new System.EventHandler(this.tuş2_Click);
            // 
            // tuş3
            // 
            this.tuş3.Location = new System.Drawing.Point(636, 294);
            this.tuş3.Name = "tuş3";
            this.tuş3.Size = new System.Drawing.Size(75, 23);
            this.tuş3.TabIndex = 2;
            this.tuş3.Text = "Anasayfa";
            this.tuş3.UseVisualStyleBackColor = true;
            this.tuş3.Click += new System.EventHandler(this.tuş3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tuş3);
            this.Controls.Add(this.tuş2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button tuş2;
        private System.Windows.Forms.Button tuş3;
    }
}