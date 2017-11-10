namespace BasicGP
{
    partial class Dashboard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnAvailability = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.picLogo);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.btnManage);
            this.panel1.Controls.Add(this.btnFind);
            this.panel1.Controls.Add(this.btnRegister);
            this.panel1.Controls.Add(this.btnAvailability);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 737);
            this.panel1.TabIndex = 0;
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Image = global::BasicGP.Properties.Resources.logo1;
            this.picLogo.InitialImage = global::BasicGP.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(842, 35);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(127, 101);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 20;
            this.picLogo.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(302, 46);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(457, 69);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "DASHBOARD";
            // 
            // btnManage
            // 
            this.btnManage.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnManage.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnManage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnManage.Location = new System.Drawing.Point(801, 518);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(190, 81);
            this.btnManage.TabIndex = 6;
            this.btnManage.Text = "Manage Appointments";
            this.btnManage.UseVisualStyleBackColor = false;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnFind.Location = new System.Drawing.Point(67, 174);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(190, 81);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "Find Patient";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnRegister.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRegister.Location = new System.Drawing.Point(801, 174);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(190, 81);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register Patient";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnAvailability
            // 
            this.btnAvailability.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAvailability.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvailability.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnAvailability.Location = new System.Drawing.Point(67, 518);
            this.btnAvailability.Name = "btnAvailability";
            this.btnAvailability.Size = new System.Drawing.Size(190, 81);
            this.btnAvailability.TabIndex = 1;
            this.btnAvailability.Text = "Check Availability";
            this.btnAvailability.UseVisualStyleBackColor = false;
            this.btnAvailability.Click += new System.EventHandler(this.btnAvailability_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 703);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximumSize = new System.Drawing.Size(1092, 820);
            this.MinimumSize = new System.Drawing.Size(1082, 704);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Over Surgery | Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Dashboard_FormClosing);
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnAvailability;
        private System.Windows.Forms.PictureBox picLogo;
    }
}