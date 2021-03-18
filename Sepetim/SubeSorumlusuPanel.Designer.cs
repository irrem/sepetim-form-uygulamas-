namespace Sepetim
{
    partial class SubeSorumlusuPanel
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
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.personelControl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(340, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 63);
            this.button2.TabIndex = 5;
            this.button2.Text = "Rapor";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(195, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 63);
            this.button1.TabIndex = 4;
            this.button1.Text = "Sipariş Teslimat Kontrolü";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // personelControl
            // 
            this.personelControl.Location = new System.Drawing.Point(53, 66);
            this.personelControl.Name = "personelControl";
            this.personelControl.Size = new System.Drawing.Size(111, 63);
            this.personelControl.TabIndex = 3;
            this.personelControl.Text = "Personel Görüntüle";
            this.personelControl.UseVisualStyleBackColor = true;
            this.personelControl.Click += new System.EventHandler(this.personelControl_Click);
            // 
            // SubeSorumlusuPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(532, 179);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.personelControl);
            this.Name = "SubeSorumlusuPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubeSorumlusuPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button personelControl;
    }
}