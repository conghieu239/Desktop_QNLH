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
            this.btnInHoaDon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChonBan
            // 
            this.btnChonBan.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnChonBan.FlatAppearance.BorderSize = 0;
            this.btnChonBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChonBan.ForeColor = System.Drawing.Color.White;
            this.btnChonBan.Location = new System.Drawing.Point(104, 37);
            this.btnChonBan.Name = "btnChonBan";
            this.btnChonBan.Size = new System.Drawing.Size(166, 40);
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
            this.btnDatBan.Location = new System.Drawing.Point(104, 112);
            this.btnDatBan.Name = "btnDatBan";
            this.btnDatBan.Size = new System.Drawing.Size(166, 39);
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
            this.btnXemMon.Location = new System.Drawing.Point(104, 190);
            this.btnXemMon.Name = "btnXemMon";
            this.btnXemMon.Size = new System.Drawing.Size(166, 39);
            this.btnXemMon.TabIndex = 2;
            this.btnXemMon.Text = "Xem món";
            this.btnXemMon.UseVisualStyleBackColor = false;
            // 
            // btnInHoaDon
            // 
            this.btnInHoaDon.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnInHoaDon.FlatAppearance.BorderSize = 0;
            this.btnInHoaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHoaDon.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnInHoaDon.Location = new System.Drawing.Point(104, 275);
            this.btnInHoaDon.Name = "btnInHoaDon";
            this.btnInHoaDon.Size = new System.Drawing.Size(166, 39);
            this.btnInHoaDon.TabIndex = 3;
            this.btnInHoaDon.Text = "In hóa đơn";
            this.btnInHoaDon.UseVisualStyleBackColor = false;
            // 
            // FormChonChucNangOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 368);
            this.Controls.Add(this.btnInHoaDon);
            this.Controls.Add(this.btnXemMon);
            this.Controls.Add(this.btnDatBan);
            this.Controls.Add(this.btnChonBan);
            this.Name = "FormChonChucNangOrder";
            this.Text = "FormChonChucNangOrder";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChonBan;
        private System.Windows.Forms.Button btnDatBan;
        private System.Windows.Forms.Button btnXemMon;
        private System.Windows.Forms.Button btnInHoaDon;
    }
}