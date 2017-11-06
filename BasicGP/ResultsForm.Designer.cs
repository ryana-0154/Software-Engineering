namespace BasicGP
{
    partial class ResultsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPrompt = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvPrescriptions = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.tcResults = new System.Windows.Forms.TabControl();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            this.tcResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(257, 127);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(192, 22);
            this.txtInput.TabIndex = 4;
            this.txtInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtInput_KeyPress);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitle.Location = new System.Drawing.Point(60, 26);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(343, 67);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Find Patient";
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrompt.Location = new System.Drawing.Point(73, 119);
            this.lblPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(174, 29);
            this.lblPrompt.TabIndex = 6;
            this.lblPrompt.Text = "Patient Name:";
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Image = global::BasicGP.Properties.Resources.logo1;
            this.picLogo.InitialImage = global::BasicGP.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(1252, 15);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(169, 124);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvResults);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(1292, 582);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tests";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvTests
            // 
            this.dgvResults.AllowUserToAddRows = false;
            this.dgvResults.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvResults.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResults.Location = new System.Drawing.Point(4, 4);
            this.dgvResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvResults.Name = "dgvTests";
            this.dgvResults.ReadOnly = true;
            this.dgvResults.RowHeadersVisible = false;
            this.dgvResults.RowHeadersWidth = 5;
            this.dgvResults.Size = new System.Drawing.Size(1284, 574);
            this.dgvResults.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvPrescriptions);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1292, 582);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Medications";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvMedications
            // 
            this.dgvPrescriptions.AllowUserToAddRows = false;
            this.dgvPrescriptions.AllowUserToDeleteRows = false;
            this.dgvPrescriptions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPrescriptions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescriptions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrescriptions.Location = new System.Drawing.Point(4, 4);
            this.dgvPrescriptions.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPrescriptions.Name = "dgvMedications";
            this.dgvPrescriptions.ReadOnly = true;
            this.dgvPrescriptions.RowHeadersVisible = false;
            this.dgvPrescriptions.RowHeadersWidth = 5;
            this.dgvPrescriptions.Size = new System.Drawing.Size(1284, 574);
            this.dgvPrescriptions.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvAppointments);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1292, 582);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Appointments";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Location = new System.Drawing.Point(4, 4);
            this.dgvAppointments.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.RowHeadersWidth = 5;
            this.dgvAppointments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvAppointments.Size = new System.Drawing.Size(1285, 577);
            this.dgvAppointments.TabIndex = 2;
            // 
            // tcResults
            // 
            this.tcResults.Controls.Add(this.tabPage1);
            this.tcResults.Controls.Add(this.tabPage2);
            this.tcResults.Controls.Add(this.tabPage3);
            this.tcResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcResults.Location = new System.Drawing.Point(73, 167);
            this.tcResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tcResults.Name = "tcResults";
            this.tcResults.SelectedIndex = 0;
            this.tcResults.Size = new System.Drawing.Size(1300, 624);
            this.tcResults.TabIndex = 3;
            this.tcResults.Visible = false;
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.AllowUserToDeleteRows = false;
            this.dgvPatients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.2F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPatients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Location = new System.Drawing.Point(76, 208);
            this.dgvPatients.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.RowHeadersVisible = false;
            this.dgvPatients.RowHeadersWidth = 5;
            this.dgvPatients.RowTemplate.Height = 28;
            this.dgvPatients.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPatients.Size = new System.Drawing.Size(1285, 577);
            this.dgvPatients.TabIndex = 8;
            this.dgvPatients.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellDoubleClick);
            // 
            // ResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1439, 914);
            this.Controls.Add(this.dgvPatients);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblPrompt);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.tcResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1457, 961);
            this.MinimumSize = new System.Drawing.Size(1457, 961);
            this.Name = "ResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Over Surgery | Results";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptions)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            this.tcResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvPrescriptions;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.TabControl tcResults;
        private System.Windows.Forms.DataGridView dgvPatients;
    }
}