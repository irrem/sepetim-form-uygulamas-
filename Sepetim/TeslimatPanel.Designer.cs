namespace Sepetim
{
    partial class TeslimatPanel
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
            this.label5 = new System.Windows.Forms.Label();
            this.chooseTypeBox = new System.Windows.Forms.ComboBox();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.dgwSiparis = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.secilenSiparisLbl = new System.Windows.Forms.Label();
            this.dgwTeslimat = new System.Windows.Forms.DataGridView();
            this.siparisSilBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwSiparis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTeslimat)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 86;
            this.label5.Text = "Personeller\n";
            // 
            // chooseTypeBox
            // 
            this.chooseTypeBox.FormattingEnabled = true;
            this.chooseTypeBox.Location = new System.Drawing.Point(496, 71);
            this.chooseTypeBox.Name = "chooseTypeBox";
            this.chooseTypeBox.Size = new System.Drawing.Size(121, 21);
            this.chooseTypeBox.TabIndex = 77;
            this.chooseTypeBox.SelectedIndexChanged += new System.EventHandler(this.chooseTypeBox_SelectedIndexChanged);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(413, 210);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(99, 52);
            this.deleteBtn.TabIndex = 76;
            this.deleteBtn.Text = "İptal Edildi";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(518, 210);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(99, 49);
            this.updateBtn.TabIndex = 75;
            this.updateBtn.Text = "Teslim Edildi";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(518, 108);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(99, 55);
            this.addBtn.TabIndex = 74;
            this.addBtn.Text = "Teslimat Listesine Ekle";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // dgwSiparis
            // 
            this.dgwSiparis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwSiparis.Location = new System.Drawing.Point(12, 66);
            this.dgwSiparis.Name = "dgwSiparis";
            this.dgwSiparis.Size = new System.Drawing.Size(355, 125);
            this.dgwSiparis.TabIndex = 73;
            this.dgwSiparis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwSubeler_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 88;
            this.label4.Text = "Seçilen Sipariş";
            // 
            // secilenSiparisLbl
            // 
            this.secilenSiparisLbl.AutoSize = true;
            this.secilenSiparisLbl.Location = new System.Drawing.Point(125, 28);
            this.secilenSiparisLbl.Name = "secilenSiparisLbl";
            this.secilenSiparisLbl.Size = new System.Drawing.Size(76, 13);
            this.secilenSiparisLbl.TabIndex = 89;
            this.secilenSiparisLbl.Text = "Seçilen Sipariş";
            // 
            // dgwTeslimat
            // 
            this.dgwTeslimat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwTeslimat.Location = new System.Drawing.Point(12, 210);
            this.dgwTeslimat.Name = "dgwTeslimat";
            this.dgwTeslimat.Size = new System.Drawing.Size(355, 125);
            this.dgwTeslimat.TabIndex = 90;
            this.dgwTeslimat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwTeslimat_CellContentClick);
            // 
            // siparisSilBtn
            // 
            this.siparisSilBtn.Location = new System.Drawing.Point(413, 108);
            this.siparisSilBtn.Name = "siparisSilBtn";
            this.siparisSilBtn.Size = new System.Drawing.Size(99, 55);
            this.siparisSilBtn.TabIndex = 91;
            this.siparisSilBtn.Text = "Siparişi İptal Et";
            this.siparisSilBtn.UseVisualStyleBackColor = true;
            this.siparisSilBtn.Click += new System.EventHandler(this.siparisSilBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(518, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 49);
            this.button1.TabIndex = 92;
            this.button1.Text = "Rapor Görüntüle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TeslimatPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(697, 363);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.siparisSilBtn);
            this.Controls.Add(this.dgwTeslimat);
            this.Controls.Add(this.secilenSiparisLbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chooseTypeBox);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dgwSiparis);
            this.Name = "TeslimatPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeslimatPanel";
            this.Load += new System.EventHandler(this.TeslimatPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwSiparis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwTeslimat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox chooseTypeBox;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView dgwSiparis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label secilenSiparisLbl;
        private System.Windows.Forms.DataGridView dgwTeslimat;
        private System.Windows.Forms.Button siparisSilBtn;
        private System.Windows.Forms.Button button1;
    }
}