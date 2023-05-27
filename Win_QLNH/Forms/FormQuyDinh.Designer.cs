namespace Win_QLNH.Forms
{
    partial class FormQuyDinh
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
            this.panelQuyDinh = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Del = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Xem = new System.Windows.Forms.Button();
            this.dgv_QuyDinh = new System.Windows.Forms.DataGridView();
            this.txt_MaQD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_TenQD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_MaPhat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_HinhThuc = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelQuyDinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QuyDinh)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelQuyDinh
            // 
            this.panelQuyDinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelQuyDinh.Controls.Add(this.label1);
            this.panelQuyDinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelQuyDinh.Location = new System.Drawing.Point(0, 0);
            this.panelQuyDinh.Margin = new System.Windows.Forms.Padding(4);
            this.panelQuyDinh.Name = "panelQuyDinh";
            this.panelQuyDinh.Size = new System.Drawing.Size(855, 121);
            this.panelQuyDinh.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(334, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quy định";
            // 
            // btn_Del
            // 
            this.btn_Del.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Del.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_Del.FlatAppearance.BorderSize = 0;
            this.btn_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Del.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Del.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Del.Location = new System.Drawing.Point(690, 46);
            this.btn_Del.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Del.Name = "btn_Del";
            this.btn_Del.Size = new System.Drawing.Size(90, 40);
            this.btn_Del.TabIndex = 1;
            this.btn_Del.Text = "XÓA";
            this.btn_Del.UseVisualStyleBackColor = false;
            this.btn_Del.Click += new System.EventHandler(this.btn_Del_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_Sua.FlatAppearance.BorderSize = 0;
            this.btn_Sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sua.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Sua.Location = new System.Drawing.Point(489, 46);
            this.btn_Sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(90, 40);
            this.btn_Sua.TabIndex = 2;
            this.btn_Sua.Text = "SỬA";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Add.Location = new System.Drawing.Point(286, 46);
            this.btn_Add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(90, 40);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "THÊM";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Xem
            // 
            this.btn_Xem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Xem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btn_Xem.FlatAppearance.BorderSize = 0;
            this.btn_Xem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xem.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Xem.Location = new System.Drawing.Point(93, 46);
            this.btn_Xem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.Size = new System.Drawing.Size(90, 40);
            this.btn_Xem.TabIndex = 4;
            this.btn_Xem.Text = "XEM";
            this.btn_Xem.UseVisualStyleBackColor = false;
            this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
            // 
            // dgv_QuyDinh
            // 
            this.dgv_QuyDinh.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_QuyDinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QuyDinh.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgv_QuyDinh.Location = new System.Drawing.Point(239, 0);
            this.dgv_QuyDinh.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_QuyDinh.Name = "dgv_QuyDinh";
            this.dgv_QuyDinh.RowHeadersWidth = 51;
            this.dgv_QuyDinh.Size = new System.Drawing.Size(616, 296);
            this.dgv_QuyDinh.TabIndex = 6;
            this.dgv_QuyDinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QuyDinh_CellContentClick);
            // 
            // txt_MaQD
            // 
            this.txt_MaQD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaQD.Location = new System.Drawing.Point(124, 37);
            this.txt_MaQD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaQD.Name = "txt_MaQD";
            this.txt_MaQD.Size = new System.Drawing.Size(101, 22);
            this.txt_MaQD.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Mã quy định";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tên quy định";
            // 
            // txt_TenQD
            // 
            this.txt_TenQD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_TenQD.Location = new System.Drawing.Point(124, 97);
            this.txt_TenQD.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TenQD.Name = "txt_TenQD";
            this.txt_TenQD.Size = new System.Drawing.Size(101, 22);
            this.txt_TenQD.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Mã NV phạt";
            // 
            // txt_MaPhat
            // 
            this.txt_MaPhat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_MaPhat.Location = new System.Drawing.Point(124, 169);
            this.txt_MaPhat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaPhat.Name = "txt_MaPhat";
            this.txt_MaPhat.Size = new System.Drawing.Size(101, 22);
            this.txt_MaPhat.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hình thức phạt";
            // 
            // txt_HinhThuc
            // 
            this.txt_HinhThuc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_HinhThuc.Location = new System.Drawing.Point(124, 233);
            this.txt_HinhThuc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HinhThuc.Name = "txt_HinhThuc";
            this.txt_HinhThuc.Size = new System.Drawing.Size(101, 22);
            this.txt_HinhThuc.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Del);
            this.panel1.Controls.Add(this.btn_Xem);
            this.panel1.Controls.Add(this.btn_Add);
            this.panel1.Controls.Add(this.btn_Sua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 137);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txt_HinhThuc);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txt_MaPhat);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_TenQD);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_MaQD);
            this.panel2.Controls.Add(this.dgv_QuyDinh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 121);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(855, 296);
            this.panel2.TabIndex = 16;
            // 
            // FormQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(855, 554);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelQuyDinh);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormQuyDinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQuyDinh";
            this.panelQuyDinh.ResumeLayout(false);
            this.panelQuyDinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QuyDinh)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelQuyDinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Del;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Xem;
        private System.Windows.Forms.DataGridView dgv_QuyDinh;
        private System.Windows.Forms.TextBox txt_MaQD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_TenQD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_MaPhat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_HinhThuc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}