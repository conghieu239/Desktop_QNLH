namespace Win_QLNH.Forms
{
    partial class FormChonChucNangOrder
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
            this.btnChonBan = new System.Windows.Forms.Button();
            this.btnDatBan = new System.Windows.Forms.Button();
            this.btnXemMon = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChonBan
            // 
            this.btnChonBan.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnChonBan.FlatAppearance.BorderSize = 0;
            this.btnChonBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonBan.ForeColor = System.Drawing.Color.White;
            this.btnChonBan.Location = new System.Drawing.Point(139, 68);
            this.btnChonBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChonBan.Name = "btnChonBan";
            this.btnChonBan.Size = new System.Drawing.Size(221, 49);
            this.btnChonBan.TabIndex = 0;
            this.btnChonBan.Text = "Chọn bàn";
            this.btnChonBan.UseVisualStyleBackColor = false;
            this.btnChonBan.Click += new System.EventHandler(this.btnChonBan_Click);
            // 
            // btnDatBan
            // 
            this.btnDatBan.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnDatBan.FlatAppearance.BorderSize = 0;
            this.btnDatBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDatBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatBan.ForeColor = System.Drawing.Color.White;
            this.btnDatBan.Location = new System.Drawing.Point(139, 158);
            this.btnDatBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDatBan.Name = "btnDatBan";
            this.btnDatBan.Size = new System.Drawing.Size(221, 48);
            this.btnDatBan.TabIndex = 1;
            this.btnDatBan.Text = "Đặt bàn";
            this.btnDatBan.UseVisualStyleBackColor = false;
            this.btnDatBan.Click += new System.EventHandler(this.btnDatBan_Click);
            // 
            // btnXemMon
            // 
            this.btnXemMon.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnXemMon.FlatAppearance.BorderSize = 0;
            this.btnXemMon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemMon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemMon.ForeColor = System.Drawing.Color.White;
            this.btnXemMon.Location = new System.Drawing.Point(139, 255);
            this.btnXemMon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXemMon.Name = "btnXemMon";
            this.btnXemMon.Size = new System.Drawing.Size(221, 48);
            this.btnXemMon.TabIndex = 2;
            this.btnXemMon.Text = "Xem món";
            this.btnXemMon.UseVisualStyleBackColor = false;
            this.btnXemMon.Click += new System.EventHandler(this.btnXemMon_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnXacNhan.FlatAppearance.BorderSize = 0;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXacNhan.ForeColor = System.Drawing.Color.White;
            this.btnXacNhan.Location = new System.Drawing.Point(139, 352);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(221, 48);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // FormChonChucNangOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 453);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.btnXemMon);
            this.Controls.Add(this.btnDatBan);
            this.Controls.Add(this.btnChonBan);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormChonChucNangOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChonChucNangOrder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChonBan;
        private System.Windows.Forms.Button btnDatBan;
        private System.Windows.Forms.Button btnXemMon;
        private System.Windows.Forms.Button btnXacNhan;
    }
}