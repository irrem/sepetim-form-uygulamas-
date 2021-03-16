namespace Sepetim
{
    partial class MusteriPanel
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
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.categoryTxt = new System.Windows.Forms.TextBox();
            this.dgwCostumers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCostumers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "Eklemek İstediğiniz\r\nKategori Adı Giriniz\r\n";
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(633, 305);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(90, 38);
            this.deleteBtn.TabIndex = 16;
            this.deleteBtn.Text = "SİL";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(527, 305);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(90, 38);
            this.updateBtn.TabIndex = 15;
            this.updateBtn.Text = "GÜNCELLE";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(419, 305);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(90, 38);
            this.addBtn.TabIndex = 14;
            this.addBtn.Text = "EKLE";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // categoryTxt
            // 
            this.categoryTxt.Location = new System.Drawing.Point(560, 128);
            this.categoryTxt.Name = "categoryTxt";
            this.categoryTxt.Size = new System.Drawing.Size(90, 20);
            this.categoryTxt.TabIndex = 13;
            // 
            // dgwCostumers
            // 
            this.dgwCostumers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCostumers.Location = new System.Drawing.Point(25, 63);
            this.dgwCostumers.Name = "dgwCostumers";
            this.dgwCostumers.Size = new System.Drawing.Size(365, 280);
            this.dgwCostumers.TabIndex = 12;
            this.dgwCostumers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCostumers_CellContentClick);
            // 
            // MusteriPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 395);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.categoryTxt);
            this.Controls.Add(this.dgwCostumers);
            this.Name = "MusteriPanel";
            this.Text = "MusteriPanel";
            this.Load += new System.EventHandler(this.MusteriPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCostumers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox categoryTxt;
        private System.Windows.Forms.DataGridView dgwCostumers;
    }
}