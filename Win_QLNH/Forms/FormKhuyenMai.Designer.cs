namespace Win_QLNH.Forms
{
    partial class FormKhuyenMai
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
            this.panelKM = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_GiamGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenKM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_IDKM = new System.Windows.Forms.TextBox();
            this.dgv_KhuyenMai = new System.Windows.Forms.DataGridView();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Xem = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dtp_Start = new System.Windows.Forms.DateTimePicker();
            this.dtp_End = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelKM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhuyenMai)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelKM
            // 
            this.panelKM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelKM.Controls.Add(this.label1);
            this.panelKM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelKM.Location = new System.Drawing.Point(0, 0);
            this.panelKM.Margin = new System.Windows.Forms.Padding(4);
            this.panelKM.Name = "panelKM";
            this.panelKM.Size = new System.Drawing.Size(843, 121);
            this.panelKM.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(313, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Khuyến mãi";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 218);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 16);
            this.label5.TabIndex = 29;
            this.label5.Text = "Ngày bắt đầu";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Giảm giá";
            // 
            // txt_GiamGia
            // 
            this.txt_GiamGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_GiamGia.Location = new System.Drawing.Point(124, 158);
            this.txt_GiamGia.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GiamGia.Name = "txt_GiamGia";
            this.txt_GiamGia.Size = new System.Drawing.Size(129, 22);
            this.txt_GiamGia.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Tên khuyến mãi";
            // 
            // txt_TenKM
            // 
            this.txt_TenKM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenKM.Location = new System.Drawing.Point(124, 107);
            this.txt_TenKM.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenKM.Name = "txt_TenKM";
            this.txt_TenKM.Size = new System.Drawing.Size(129, 22);
            this.txt_TenKM.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "ID Khuyến mãi";
            // 
            // txt_IDKM
            // 
            this.txt_IDKM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_IDKM.Location = new System.Drawing.Point(124, 56);
            this.txt_IDKM.Margin = new System.Windows.Forms.Padding(4);
            this.txt_IDKM.Name = "txt_IDKM";
            this.txt_IDKM.Size = new System.Drawing.Size(129, 22);
            this.txt_IDKM.TabIndex = 22;
            // 
            // dgv_KhuyenMai
            // 
            this.dgv_KhuyenMai.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_KhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhuyenMai.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgv_KhuyenMai.Location = new System.Drawing.Point(270, 0);
            this.dgv_KhuyenMai.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_KhuyenMai.Name = "dgv_KhuyenMai";
            this.dgv_KhuyenMai.RowHeadersWidth = 51;
            this.dgv_KhuyenMai.Size = new System.Drawing.Size(573, 495);
            this.dgv_KhuyenMai.TabIndex = 21;
            this.dgv_KhuyenMai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_KhuyenMai_CellContentClick);
            // 
            // btn_Del
            // 
            this.btn_Del.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_Del.FlatAppearance.BorderSize = 0;
            this.btn_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Del.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Del.Location = new System.Drawing.Point(609, 33);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(90, 40);
            this.btn_Del.TabIndex = 16;
            this.btn_Del.Text = "XÓA";
            this.btn_Del.UseVisualStyleBackColor = false;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Xem
            // 
            this.btn_Xem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Xem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_Xem.FlatAppearance.BorderSize = 0;
            this.btn_Xem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xem.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Xem.Location = new System.Drawing.Point(126, 33);
            this.btn_Xem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.Size = new System.Drawing.Size(90, 40);
            this.btn_Xem.TabIndex = 19;
            this.btn_Xem.Text = "XEM";
            this.btn_Xem.UseVisualStyleBackColor = false;
            this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Add.Location = new System.Drawing.Point(298, 33);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(90, 40);
            this.btn_Add.TabIndex = 18;
            this.btn_Add.Text = "THÊM";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Sua.Location = new System.Drawing.Point(456, 33);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(90, 40);
            this.btn_Sua.TabIndex = 17;
            this.btn_Sua.Text = "SỬA";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 273);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Ngày kết thúc";
            // 
            // dtp_Start
            // 
            this.dtp_Start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Start.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_Start.Location = new System.Drawing.Point(124, 211);
            this.dtp_Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_Start.Name = "dtp_Start";
            this.dtp_Start.Size = new System.Drawing.Size(129, 23);
            this.dtp_Start.TabIndex = 39;
            // 
            // dtp_End
            // 
            this.dtp_End.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtp_End.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_End.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_End.Location = new System.Drawing.Point(124, 266);
            this.dtp_End.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtp_End.Name = "dtp_End";
            this.dtp_End.Size = new System.Drawing.Size(129, 23);
            this.dtp_End.TabIndex = 40;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtp_End);
            this.panel1.Controls.Add(this.dgv_KhuyenMai);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_IDKM);
            this.panel1.Controls.Add(this.dtp_Start);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txt_GiamGia);
            this.panel1.Controls.Add(this.txt_TenKM);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 495);
            this.panel1.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Sua);
            this.panel2.Controls.Add(this.btn_Add);
            this.panel2.Controls.Add(this.btn_Xem);
            this.panel2.Controls.Add(this.btn_Del);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 491);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 125);
            this.panel2.TabIndex = 42;
            // 
            // FormKhuyenMai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 616);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelKM);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormKhuyenMai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKhuyenMai";
            this.panelKM.ResumeLayout(false);
            this.panelKM.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhuyenMai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelKM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_GiamGia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenKM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_IDKM;
        private System.Windows.Forms.DataGridView dgv_KhuyenMai;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Xem;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtp_Start;
        private System.Windows.Forms.DateTimePicker dtp_End;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}