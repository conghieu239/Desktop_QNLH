namespace Win_QLNH.Forms
{
    partial class FormPNH
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
            this.dtg_NH = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.bt_xem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_NH)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtg_NH
            // 
            this.dtg_NH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_NH.BackgroundColor = System.Drawing.Color.White;
            this.dtg_NH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_NH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtg_NH.Location = new System.Drawing.Point(0, 121);
            this.dtg_NH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtg_NH.Name = "dtg_NH";
            this.dtg_NH.RowHeadersWidth = 51;
            this.dtg_NH.RowTemplate.Height = 24;
            this.dtg_NH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_NH.Size = new System.Drawing.Size(1063, 270);
            this.dtg_NH.TabIndex = 11;
            this.dtg_NH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_NH_CellContentClick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1063, 121);
            this.label1.TabIndex = 10;
            this.label1.Text = "NHẬP HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bt_xoa);
            this.panel1.Controls.Add(this.bt_sua);
            this.panel1.Controls.Add(this.bt_them);
            this.panel1.Controls.Add(this.bt_xem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 391);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 148);
            this.panel1.TabIndex = 9;
            // 
            // bt_xoa
            // 
            this.bt_xoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_xoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.bt_xoa.FlatAppearance.BorderSize = 0;
            this.bt_xoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.bt_xoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.bt_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xoa.ForeColor = System.Drawing.Color.White;
            this.bt_xoa.Location = new System.Drawing.Point(765, 50);
            this.bt_xoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(91, 39);
            this.bt_xoa.TabIndex = 3;
            this.bt_xoa.Text = "XÓA";
            this.bt_xoa.UseVisualStyleBackColor = false;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.bt_sua.FlatAppearance.BorderSize = 0;
            this.bt_sua.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.bt_sua.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.bt_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_sua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_sua.ForeColor = System.Drawing.Color.White;
            this.bt_sua.Location = new System.Drawing.Point(584, 50);
            this.bt_sua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(91, 39);
            this.bt_sua.TabIndex = 2;
            this.bt_sua.Text = "SỬA";
            this.bt_sua.UseVisualStyleBackColor = false;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.bt_them.FlatAppearance.BorderSize = 0;
            this.bt_them.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.bt_them.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.bt_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_them.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_them.ForeColor = System.Drawing.Color.White;
            this.bt_them.Location = new System.Drawing.Point(397, 50);
            this.bt_them.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(91, 39);
            this.bt_them.TabIndex = 1;
            this.bt_them.Text = "THÊM";
            this.bt_them.UseVisualStyleBackColor = false;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // bt_xem
            // 
            this.bt_xem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_xem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.bt_xem.FlatAppearance.BorderSize = 0;
            this.bt_xem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.bt_xem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.bt_xem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_xem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_xem.ForeColor = System.Drawing.Color.White;
            this.bt_xem.Location = new System.Drawing.Point(223, 50);
            this.bt_xem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_xem.Name = "bt_xem";
            this.bt_xem.Size = new System.Drawing.Size(91, 39);
            this.bt_xem.TabIndex = 0;
            this.bt_xem.Text = "XEM";
            this.bt_xem.UseVisualStyleBackColor = false;
            this.bt_xem.Click += new System.EventHandler(this.bt_xem_Click);
            // 
            // FormPNH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 539);
            this.Controls.Add(this.dtg_NH);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPNH";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPNH";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_NH)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtg_NH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.Button bt_xem;
    }
}