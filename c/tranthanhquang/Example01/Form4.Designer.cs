namespace Example01
{
    partial class Form4
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
            this.btncong = new System.Windows.Forms.Button();
            this.btnnhan = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.lbsox = new System.Windows.Forms.Label();
            this.lbsốy = new System.Windows.Forms.Label();
            this.lbketqua = new System.Windows.Forms.Label();
            this.tbSox = new System.Windows.Forms.TextBox();
            this.tbSoy = new System.Windows.Forms.TextBox();
            this.txtketqua = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btncong
            // 
            this.btncong.Location = new System.Drawing.Point(64, 206);
            this.btncong.Name = "btncong";
            this.btncong.Size = new System.Drawing.Size(75, 47);
            this.btncong.TabIndex = 0;
            this.btncong.Text = "Cộng";
            this.btncong.UseVisualStyleBackColor = true;
            this.btncong.Click += new System.EventHandler(this.btncong_Click);
            // 
            // btnnhan
            // 
            this.btnnhan.Location = new System.Drawing.Point(165, 206);
            this.btnnhan.Name = "btnnhan";
            this.btnnhan.Size = new System.Drawing.Size(75, 47);
            this.btnnhan.TabIndex = 1;
            this.btnnhan.Text = "Nhân";
            this.btnnhan.UseVisualStyleBackColor = true;
            this.btnnhan.Click += new System.EventHandler(this.btnnhan_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(265, 206);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 47);
            this.btnthoat.TabIndex = 2;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // lbsox
            // 
            this.lbsox.AutoSize = true;
            this.lbsox.Location = new System.Drawing.Point(62, 53);
            this.lbsox.Name = "lbsox";
            this.lbsox.Size = new System.Drawing.Size(35, 17);
            this.lbsox.TabIndex = 3;
            this.lbsox.Text = "Số x";
            // 
            // lbsốy
            // 
            this.lbsốy.AutoSize = true;
            this.lbsốy.Location = new System.Drawing.Point(61, 85);
            this.lbsốy.Name = "lbsốy";
            this.lbsốy.Size = new System.Drawing.Size(36, 17);
            this.lbsốy.TabIndex = 4;
            this.lbsốy.Text = "Số y";
            // 
            // lbketqua
            // 
            this.lbketqua.AutoSize = true;
            this.lbketqua.Location = new System.Drawing.Point(61, 115);
            this.lbketqua.Name = "lbketqua";
            this.lbketqua.Size = new System.Drawing.Size(60, 17);
            this.lbketqua.TabIndex = 5;
            this.lbketqua.Text = "Kết Quả";
            // 
            // tbSox
            // 
            this.tbSox.Location = new System.Drawing.Point(165, 53);
            this.tbSox.Name = "tbSox";
            this.tbSox.Size = new System.Drawing.Size(175, 22);
            this.tbSox.TabIndex = 6;
            // 
            // tbSoy
            // 
            this.tbSoy.Location = new System.Drawing.Point(165, 85);
            this.tbSoy.Name = "tbSoy";
            this.tbSoy.Size = new System.Drawing.Size(175, 22);
            this.tbSoy.TabIndex = 7;
            // 
            // txtketqua
            // 
            this.txtketqua.Location = new System.Drawing.Point(165, 115);
            this.txtketqua.Name = "txtketqua";
            this.txtketqua.Size = new System.Drawing.Size(175, 22);
            this.txtketqua.TabIndex = 8;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 295);
            this.Controls.Add(this.txtketqua);
            this.Controls.Add(this.tbSoy);
            this.Controls.Add(this.tbSox);
            this.Controls.Add(this.lbketqua);
            this.Controls.Add(this.lbsốy);
            this.Controls.Add(this.lbsox);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnnhan);
            this.Controls.Add(this.btncong);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncong;
        private System.Windows.Forms.Button btnnhan;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label lbsox;
        private System.Windows.Forms.Label lbsốy;
        private System.Windows.Forms.Label lbketqua;
        private System.Windows.Forms.TextBox tbSox;
        private System.Windows.Forms.TextBox tbSoy;
        private System.Windows.Forms.TextBox txtketqua;
    }
}