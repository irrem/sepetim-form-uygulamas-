namespace Sepetim
{
    partial class SubePanel
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
            this.chooseTypeBox = new System.Windows.Forms.ComboBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.dgwSubeler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSubeler)).BeginInit();
            this.SuspendLayout();
            // 
            // chooseTypeBox
            // 
            this.chooseTypeBox.FormattingEnabled = true;
            this.chooseTypeBox.Location = new System.Drawing.Point(456, 85);
            this.chooseTypeBox.Name = "chooseTypeBox";
            this.chooseTypeBox.Size = new System.Drawing.Size(121, 21);
            this.chooseTypeBox.TabIndex = 24;
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(659, 327);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(90, 38);
            this.deleteBtn.TabIndex = 23;
            this.deleteBtn.Text = "SİL";
            this.deleteBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(553, 327);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(90, 38);
            this.updateBtn.TabIndex = 22;
            this.updateBtn.Text = "GÜNCELLE";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(445, 327);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(90, 38);
            this.addBtn.TabIndex = 21;
            this.addBtn.Text = "EKLE";
            this.addBtn.UseVisualStyleBackColor = true;
            // 
            // dgwSubeler
            // 
            this.dgwSubeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSubeler.Location = new System.Drawing.Point(51, 85);
            this.dgwSubeler.Name = "dgwSubeler";
            this.dgwSubeler.Size = new System.Drawing.Size(365, 280);
            this.dgwSubeler.TabIndex = 20;
            // 
            // SubePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 393);
            this.Controls.Add(this.chooseTypeBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dgwSubeler);
            this.Name = "SubePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubePanel";
            this.Load += new System.EventHandler(this.SubePanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSubeler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox chooseTypeBox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView dgwSubeler;
    }
}