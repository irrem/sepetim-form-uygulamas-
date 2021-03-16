namespace Sepetim
{
    partial class Kategori
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
            this.dgwCategory = new System.Windows.Forms.DataGridView();
            this.categoryTxt = new System.Windows.Forms.TextBox();
            this.addCategoryBtn = new System.Windows.Forms.Button();
            this.updateCategoryBtn = new System.Windows.Forms.Button();
            this.deleteCategoryBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwCategory
            // 
            this.dgwCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCategory.Location = new System.Drawing.Point(12, 12);
            this.dgwCategory.Name = "dgwCategory";
            this.dgwCategory.Size = new System.Drawing.Size(273, 305);
            this.dgwCategory.TabIndex = 0;
            this.dgwCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCategory_CellContentClick);
            // 
            // categoryTxt
            // 
            this.categoryTxt.Location = new System.Drawing.Point(320, 82);
            this.categoryTxt.Name = "categoryTxt";
            this.categoryTxt.Size = new System.Drawing.Size(104, 20);
            this.categoryTxt.TabIndex = 1;
            this.categoryTxt.TextChanged += new System.EventHandler(this.categoryTxt_TextChanged);
            // 
            // addCategoryBtn
            // 
            this.addCategoryBtn.Location = new System.Drawing.Point(320, 127);
            this.addCategoryBtn.Name = "addCategoryBtn";
            this.addCategoryBtn.Size = new System.Drawing.Size(104, 39);
            this.addCategoryBtn.TabIndex = 2;
            this.addCategoryBtn.Text = "EKLE";
            this.addCategoryBtn.UseVisualStyleBackColor = true;
            this.addCategoryBtn.Click += new System.EventHandler(this.addCategoryBtn_Click);
            // 
            // updateCategoryBtn
            // 
            this.updateCategoryBtn.Location = new System.Drawing.Point(320, 182);
            this.updateCategoryBtn.Name = "updateCategoryBtn";
            this.updateCategoryBtn.Size = new System.Drawing.Size(104, 39);
            this.updateCategoryBtn.TabIndex = 3;
            this.updateCategoryBtn.Text = "GÜNCELLE";
            this.updateCategoryBtn.UseVisualStyleBackColor = true;
            this.updateCategoryBtn.Click += new System.EventHandler(this.updateCategoryBtn_Click);
            // 
            // deleteCategoryBtn
            // 
            this.deleteCategoryBtn.Location = new System.Drawing.Point(320, 227);
            this.deleteCategoryBtn.Name = "deleteCategoryBtn";
            this.deleteCategoryBtn.Size = new System.Drawing.Size(104, 39);
            this.deleteCategoryBtn.TabIndex = 4;
            this.deleteCategoryBtn.Text = "SİL";
            this.deleteCategoryBtn.UseVisualStyleBackColor = true;
            this.deleteCategoryBtn.Click += new System.EventHandler(this.deleteCategoryBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Eklemek İstediğiniz\r\nKategori Adı Giriniz\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Kategori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(466, 333);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteCategoryBtn);
            this.Controls.Add(this.updateCategoryBtn);
            this.Controls.Add(this.addCategoryBtn);
            this.Controls.Add(this.categoryTxt);
            this.Controls.Add(this.dgwCategory);
            this.Name = "Kategori";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kategori";
            this.Load += new System.EventHandler(this.Kategori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwCategory;
        private System.Windows.Forms.TextBox categoryTxt;
        private System.Windows.Forms.Button addCategoryBtn;
        private System.Windows.Forms.Button updateCategoryBtn;
        private System.Windows.Forms.Button deleteCategoryBtn;
        private System.Windows.Forms.Label label1;
    }
}