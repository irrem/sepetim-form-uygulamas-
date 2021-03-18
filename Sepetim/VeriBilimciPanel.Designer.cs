namespace Sepetim
{
    partial class VeriBilimciPanel
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
            this.editCategory = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // editCategory
            // 
            this.editCategory.Location = new System.Drawing.Point(12, 64);
            this.editCategory.Name = "editCategory";
            this.editCategory.Size = new System.Drawing.Size(111, 63);
            this.editCategory.TabIndex = 0;
            this.editCategory.Text = "Kategori Düzenle";
            this.editCategory.UseVisualStyleBackColor = true;
            this.editCategory.Click += new System.EventHandler(this.editCategory_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(154, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ürün Düzenle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(299, 64);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 63);
            this.button2.TabIndex = 2;
            this.button2.Text = "Müşteri Düzenle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // VeriBilimciPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(453, 207);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.editCategory);
            this.Name = "VeriBilimciPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VeriBilimciPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button editCategory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}