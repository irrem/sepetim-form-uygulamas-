namespace Sepetim
{
    partial class AdminPanel
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
            this.viewWorkerBtn = new System.Windows.Forms.Button();
            this.viewWorkPlaceBtn = new System.Windows.Forms.Button();
            this.viewCategory = new System.Windows.Forms.Button();
            this.productListBtn = new System.Windows.Forms.Button();
            this.viewCostumersBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewWorkerBtn
            // 
            this.viewWorkerBtn.Location = new System.Drawing.Point(190, 42);
            this.viewWorkerBtn.Name = "viewWorkerBtn";
            this.viewWorkerBtn.Size = new System.Drawing.Size(120, 100);
            this.viewWorkerBtn.TabIndex = 0;
            this.viewWorkerBtn.Text = "Personel Görüntüle";
            this.viewWorkerBtn.UseVisualStyleBackColor = true;
            this.viewWorkerBtn.Click += new System.EventHandler(this.viewWorkerBtn_Click);
            // 
            // viewWorkPlaceBtn
            // 
            this.viewWorkPlaceBtn.Location = new System.Drawing.Point(45, 42);
            this.viewWorkPlaceBtn.Name = "viewWorkPlaceBtn";
            this.viewWorkPlaceBtn.Size = new System.Drawing.Size(120, 100);
            this.viewWorkPlaceBtn.TabIndex = 1;
            this.viewWorkPlaceBtn.Text = "Şube Görüntüle";
            this.viewWorkPlaceBtn.UseVisualStyleBackColor = true;
            this.viewWorkPlaceBtn.Click += new System.EventHandler(this.viewWorkPlaceBtn_Click);
            // 
            // viewCategory
            // 
            this.viewCategory.Location = new System.Drawing.Point(45, 161);
            this.viewCategory.Name = "viewCategory";
            this.viewCategory.Size = new System.Drawing.Size(120, 100);
            this.viewCategory.TabIndex = 2;
            this.viewCategory.Text = "Kategori Görüntüle";
            this.viewCategory.UseVisualStyleBackColor = true;
            this.viewCategory.Click += new System.EventHandler(this.viewCategory_Click);
            // 
            // productListBtn
            // 
            this.productListBtn.Location = new System.Drawing.Point(190, 161);
            this.productListBtn.Name = "productListBtn";
            this.productListBtn.Size = new System.Drawing.Size(120, 100);
            this.productListBtn.TabIndex = 3;
            this.productListBtn.Text = "Ürün Listele";
            this.productListBtn.UseVisualStyleBackColor = true;
            this.productListBtn.Click += new System.EventHandler(this.productListBtn_Click);
            // 
            // viewCostumersBtn
            // 
            this.viewCostumersBtn.Location = new System.Drawing.Point(332, 42);
            this.viewCostumersBtn.Name = "viewCostumersBtn";
            this.viewCostumersBtn.Size = new System.Drawing.Size(120, 100);
            this.viewCostumersBtn.TabIndex = 4;
            this.viewCostumersBtn.Text = "Müşteri Görüntüle";
            this.viewCostumersBtn.UseVisualStyleBackColor = true;
            this.viewCostumersBtn.Click += new System.EventHandler(this.viewCostumersBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(332, 161);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(120, 100);
            this.button4.TabIndex = 5;
            this.button4.Text = "Siparişleri Görüntüle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(511, 309);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.viewCostumersBtn);
            this.Controls.Add(this.productListBtn);
            this.Controls.Add(this.viewCategory);
            this.Controls.Add(this.viewWorkPlaceBtn);
            this.Controls.Add(this.viewWorkerBtn);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminPanel";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button viewWorkerBtn;
        private System.Windows.Forms.Button viewWorkPlaceBtn;
        private System.Windows.Forms.Button viewCategory;
        private System.Windows.Forms.Button productListBtn;
        private System.Windows.Forms.Button viewCostumersBtn;
        private System.Windows.Forms.Button button4;
    }
}