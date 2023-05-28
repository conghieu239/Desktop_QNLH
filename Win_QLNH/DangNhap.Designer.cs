namespace Win_QLNH
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pnDN = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDK = new System.Windows.Forms.Button();
            this.btnDN = new System.Windows.Forms.Button();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnDN.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnDN
            // 
            this.pnDN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pnDN.Controls.Add(this.panel2);
            this.pnDN.Controls.Add(this.panel1);
            this.pnDN.Controls.Add(this.label2);
            this.pnDN.Controls.Add(this.btnDK);
            this.pnDN.Controls.Add(this.btnDN);
            this.pnDN.Controls.Add(this.txtMK);
            this.pnDN.Controls.Add(this.txtTK);
            this.pnDN.Controls.Add(this.label1);
            this.pnDN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDN.Location = new System.Drawing.Point(0, 0);
            this.pnDN.Name = "pnDN";
            this.pnDN.Size = new System.Drawing.Size(917, 562);
            this.pnDN.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(693, 429);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 38);
            this.panel2.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(621, 429);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 38);
            this.panel1.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(576, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "___________Hoặc___________";
            // 
            // btnDK
            // 
            this.btnDK.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDK.FlatAppearance.BorderSize = 0;
            this.btnDK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDK.Location = new System.Drawing.Point(693, 325);
            this.btnDK.Name = "btnDK";
            this.btnDK.Size = new System.Drawing.Size(107, 33);
            this.btnDK.TabIndex = 4;
            this.btnDK.Text = "Đăng ký";
            this.btnDK.UseVisualStyleBackColor = false;
            this.btnDK.Click += new System.EventHandler(this.btnDK_Click);
            // 
            // btnDN
            // 
            this.btnDN.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnDN.FlatAppearance.BorderSize = 0;
            this.btnDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDN.Location = new System.Drawing.Point(554, 325);
            this.btnDN.Name = "btnDN";
            this.btnDN.Size = new System.Drawing.Size(107, 33);
            this.btnDN.TabIndex = 3;
            this.btnDN.Text = "Đăng nhập";
            this.btnDN.UseVisualStyleBackColor = false;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // txtMK
            // 
            this.txtMK.BackColor = System.Drawing.Color.White;
            this.txtMK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtMK.Location = new System.Drawing.Point(554, 247);
            this.txtMK.Multiline = true;
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(246, 30);
            this.txtMK.TabIndex = 2;
            // 
            // txtTK
            // 
            this.txtTK.BackColor = System.Drawing.Color.White;
            this.txtTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTK.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtTK.Location = new System.Drawing.Point(554, 185);
            this.txtTK.Multiline = true;
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(246, 30);
            this.txtTK.TabIndex = 1;
            this.txtTK.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(572, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng nhập";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(917, 562);
            this.Controls.Add(this.pnDN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DangNhap";
            this.pnDN.ResumeLayout(false);
            this.pnDN.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnDN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDK;
        private System.Windows.Forms.Button btnDN;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}