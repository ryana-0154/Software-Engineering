using System;

namespace BasicGP
{
    partial class AppointmentForm
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
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNHNumber = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtNHNumber = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.lblSName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblTitlePrompt = new System.Windows.Forms.Label();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.cbTitle = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblEmployee = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblInputPrompt = new System.Windows.Forms.Label();
            this.pnl = new System.Windows.Forms.Panel();
            this.dgvAppointments = new System.Windows.Forms.DataGridView();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4.SuspendLayout();
            this.pnlTime.SuspendLayout();
            this.pnlDate.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.307F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.693F));
            this.tableLayoutPanel4.Controls.Add(this.lblNHNumber, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.lblTime, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.lblDate, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.pnlTime, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.pnlDate, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtNHNumber, 1, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(45, 206);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(393, 128);
            this.tableLayoutPanel4.TabIndex = 4;
            // 
            // lblNHNumber
            // 
            this.lblNHNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNHNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNHNumber.Location = new System.Drawing.Point(5, 1);
            this.lblNHNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNHNumber.Name = "lblNHNumber";
            this.lblNHNumber.Size = new System.Drawing.Size(180, 41);
            this.lblNHNumber.TabIndex = 27;
            this.lblNHNumber.Text = "NH Number*";
            this.lblNHNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(5, 85);
            this.lblTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(180, 42);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "Time";
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(5, 43);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(180, 41);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTime
            // 
            this.pnlTime.Controls.Add(this.cbTime);
            this.pnlTime.Location = new System.Drawing.Point(194, 89);
            this.pnlTime.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(193, 34);
            this.pnlTime.TabIndex = 13;
            // 
            // cbTime
            // 
            this.cbTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Items.AddRange(new object[] {
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "15:30",
            "16:00",
            "16:30",
            "17:00",
            "17:30",
            "18:00"});
            this.cbTime.Location = new System.Drawing.Point(0, 0);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(193, 24);
            this.cbTime.TabIndex = 0;
            this.cbTime.Tag = "Time";
            // 
            // pnlDate
            // 
            this.pnlDate.Controls.Add(this.dtpDate);
            this.pnlDate.Location = new System.Drawing.Point(194, 47);
            this.pnlDate.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(193, 33);
            this.pnlDate.TabIndex = 14;
            // 
            // dtpDate
            // 
            this.dtpDate.Checked = false;
            this.dtpDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(0, 0);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtpDate.MinDate = DateTime.Today;
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(193, 22);
            this.dtpDate.TabIndex = 2;
            this.dtpDate.Tag = "DOB";
            // 
            // txtNHNumber
            // 
            this.txtNHNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNHNumber.Location = new System.Drawing.Point(193, 3);
            this.txtNHNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNHNumber.MaxLength = 10;
            this.txtNHNumber.Name = "txtNHNumber";
            this.txtNHNumber.Size = new System.Drawing.Size(196, 22);
            this.txtNHNumber.TabIndex = 1;
            this.txtNHNumber.Tag = "NH Number";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblTitle.Location = new System.Drawing.Point(23, 39);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(495, 67);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "New Appointment";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.307F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.693F));
            this.tableLayoutPanel5.Controls.Add(this.txtFName, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.txtSName, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.lblSName, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.lblFName, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblTitlePrompt, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.pnlTitle, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(45, 438);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.55245F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.44755F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(388, 218);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // txtFName
            // 
            this.txtFName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFName.Location = new System.Drawing.Point(190, 68);
            this.txtFName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFName.MaxLength = 16;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(194, 22);
            this.txtFName.TabIndex = 5;
            this.txtFName.Tag = "First Name";
            // 
            // txtSName
            // 
            this.txtSName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSName.Location = new System.Drawing.Point(190, 139);
            this.txtSName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSName.MaxLength = 16;
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(194, 22);
            this.txtSName.TabIndex = 6;
            this.txtSName.Tag = "Surname";
            // 
            // lblSName
            // 
            this.lblSName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSName.Location = new System.Drawing.Point(5, 137);
            this.lblSName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(177, 80);
            this.lblSName.TabIndex = 7;
            this.lblSName.Text = "Surname *";
            this.lblSName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFName
            // 
            this.lblFName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(5, 66);
            this.lblFName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(177, 70);
            this.lblFName.TabIndex = 4;
            this.lblFName.Text = "First Name(s) *";
            this.lblFName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitlePrompt
            // 
            this.lblTitlePrompt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitlePrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePrompt.Location = new System.Drawing.Point(5, 1);
            this.lblTitlePrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitlePrompt.Name = "lblTitlePrompt";
            this.lblTitlePrompt.Size = new System.Drawing.Size(177, 64);
            this.lblTitlePrompt.TabIndex = 9;
            this.lblTitlePrompt.Text = "Title *";
            this.lblTitlePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTitle
            // 
            this.pnlTitle.Controls.Add(this.cbTitle);
            this.pnlTitle.Location = new System.Drawing.Point(191, 5);
            this.pnlTitle.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(191, 55);
            this.pnlTitle.TabIndex = 10;
            this.pnlTitle.Tag = "Title";
            // 
            // cbTitle
            // 
            this.cbTitle.DisplayMember = "Mr";
            this.cbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTitle.FormattingEnabled = true;
            this.cbTitle.Items.AddRange(new object[] {
            "Mrs",
            "Miss",
            "Mr",
            "Master",
            "Dr"});
            this.cbTitle.Location = new System.Drawing.Point(0, 0);
            this.cbTitle.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Size = new System.Drawing.Size(191, 24);
            this.cbTitle.TabIndex = 4;
            this.cbTitle.Tag = "Title";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel6.Controls.Add(this.txtDescription, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.lblDescription, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(45, 686);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(388, 138);
            this.tableLayoutPanel6.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDescription.Location = new System.Drawing.Point(6, 43);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.MaxLength = 300;
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(376, 89);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.Tag = "Description";
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(5, 1);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(378, 37);
            this.lblDescription.TabIndex = 17;
            this.lblDescription.Text = "Description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSubmit.Location = new System.Drawing.Point(483, 742);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(136, 81);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblEmployee
            // 
            this.lblEmployee.AutoSize = true;
            this.lblEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployee.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEmployee.Location = new System.Drawing.Point(51, 375);
            this.lblEmployee.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmployee.Name = "lblEmployee";
            this.lblEmployee.Size = new System.Drawing.Size(169, 39);
            this.lblEmployee.TabIndex = 21;
            this.lblEmployee.Text = "Employee";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDelete.Location = new System.Drawing.Point(1197, 742);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 81);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(333, 2);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(51, 22);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // lblInputPrompt
            // 
            this.lblInputPrompt.AutoSize = true;
            this.lblInputPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputPrompt.Location = new System.Drawing.Point(3, 0);
            this.lblInputPrompt.Name = "lblInputPrompt";
            this.lblInputPrompt.Size = new System.Drawing.Size(290, 25);
            this.lblInputPrompt.TabIndex = 24;
            this.lblInputPrompt.Text = "Appointment ID or Employee ID:";
            // 
            // pnl
            // 
            this.pnl.Controls.Add(this.txtSearch);
            this.pnl.Controls.Add(this.lblInputPrompt);
            this.pnl.Location = new System.Drawing.Point(837, 183);
            this.pnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(417, 39);
            this.pnl.TabIndex = 25;
            // 
            // dgvAppointments
            // 
            this.dgvAppointments.AllowUserToAddRows = false;
            this.dgvAppointments.AllowUserToDeleteRows = false;
            this.dgvAppointments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointments.Location = new System.Drawing.Point(837, 229);
            this.dgvAppointments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvAppointments.Name = "dgvAppointments";
            this.dgvAppointments.ReadOnly = true;
            this.dgvAppointments.RowHeadersVisible = false;
            this.dgvAppointments.RowTemplate.Height = 24;
            this.dgvAppointments.Size = new System.Drawing.Size(487, 335);
            this.dgvAppointments.TabIndex = 26;
            this.dgvAppointments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCellDoubleClick);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.LightCoral;
            this.lblErrorMsg.Location = new System.Drawing.Point(480, 601);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(684, 137);
            this.lblErrorMsg.TabIndex = 27;
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Image = global::BasicGP.Properties.Resources.logo1;
            this.picLogo.Location = new System.Drawing.Point(1155, 26);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(169, 124);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 20;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // AppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 848);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.dgvAppointments);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblEmployee);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.pnl);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(1397, 895);
            this.MinimumSize = new System.Drawing.Size(1397, 852);
            this.Name = "AppointmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AppointmentForm";
            this.Load += new System.EventHandler(this.AppointmentForm_Load);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.pnlTime.ResumeLayout(false);
            this.pnlDate.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.pnlTitle.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.pnl.ResumeLayout(false);
            this.pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.ComboBox cbTitle;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblTitlePrompt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblEmployee;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblInputPrompt;
        private System.Windows.Forms.Panel pnl;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.Label lblNHNumber;
        private System.Windows.Forms.TextBox txtNHNumber;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.ComboBox cbTime;
    }
}