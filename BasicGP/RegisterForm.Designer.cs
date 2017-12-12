using System;

namespace BasicGP
{
    partial class RegisterForm
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
            this.lblFName = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlDOB = new System.Windows.Forms.Panel();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblAddress3 = new System.Windows.Forms.Label();
            this.lblAddress2 = new System.Windows.Forms.Label();
            this.lblAddress1 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.lblSName = new System.Windows.Forms.Label();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.comboTitle = new System.Windows.Forms.ComboBox();
            this.txtAddress2 = new System.Windows.Forms.TextBox();
            this.txtAddress3 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtAllergies = new System.Windows.Forms.TextBox();
            this.lblAllergiesText = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbSmoker = new System.Windows.Forms.CheckBox();
            this.cbDiabetes = new System.Windows.Forms.CheckBox();
            this.cbAsthmatic = new System.Windows.Forms.CheckBox();
            this.lblFlagText = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblErrorMsg = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.tableLayoutPanel3.SuspendLayout();
            this.pnlDOB.SuspendLayout();
            this.pnlTitle.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFName
            // 
            this.lblFName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(130)))), ((int)(((byte)(177)))));
            this.lblFName.Location = new System.Drawing.Point(5, 1);
            this.lblFName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(280, 79);
            this.lblFName.TabIndex = 4;
            this.lblFName.Text = "First Name(s) *";
            this.lblFName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.307F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.693F));
            this.tableLayoutPanel3.Controls.Add(this.pnlDOB, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.lblAddress3, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.lblAddress2, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.lblAddress1, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.txtPhoneNumber, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblPhone, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.lblDOB, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.txtFName, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblFName, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblSName, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtSName, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblTitle, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtAddress1, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.pnlTitle, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtAddress2, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.txtAddress3, 1, 7);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(23, 68);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(601, 639);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // pnlDOB
            // 
            this.pnlDOB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDOB.Controls.Add(this.dtpDOB);
            this.pnlDOB.Location = new System.Drawing.Point(293, 238);
            this.pnlDOB.Name = "pnlDOB";
            this.pnlDOB.Size = new System.Drawing.Size(304, 39);
            this.pnlDOB.TabIndex = 21;
            this.pnlDOB.Tag = "DOB";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpDOB.Checked = false;
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(-3, 12);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDOB.MaxDate = new System.DateTime(2017, 11, 14, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(304, 22);
            this.dtpDOB.TabIndex = 12;
            this.dtpDOB.Tag = "DOB";
            this.dtpDOB.Value = new System.DateTime(2017, 11, 14, 0, 0, 0, 0);
            // 
            // lblAddress3
            // 
            this.lblAddress3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(130)))), ((int)(((byte)(177)))));
            this.lblAddress3.Location = new System.Drawing.Point(5, 536);
            this.lblAddress3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress3.Name = "lblAddress3";
            this.lblAddress3.Size = new System.Drawing.Size(280, 102);
            this.lblAddress3.TabIndex = 20;
            this.lblAddress3.Text = "Address Line 3";
            this.lblAddress3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddress2
            // 
            this.lblAddress2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(130)))), ((int)(((byte)(177)))));
            this.lblAddress2.Location = new System.Drawing.Point(5, 460);
            this.lblAddress2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress2.Name = "lblAddress2";
            this.lblAddress2.Size = new System.Drawing.Size(280, 75);
            this.lblAddress2.TabIndex = 18;
            this.lblAddress2.Text = "Address Line 2";
            this.lblAddress2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddress1
            // 
            this.lblAddress1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(130)))), ((int)(((byte)(177)))));
            this.lblAddress1.Location = new System.Drawing.Point(5, 386);
            this.lblAddress1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress1.Name = "lblAddress1";
            this.lblAddress1.Size = new System.Drawing.Size(280, 73);
            this.lblAddress1.TabIndex = 15;
            this.lblAddress1.Text = "Address Line 1 *";
            this.lblAddress1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(293, 314);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhoneNumber.MaxLength = 11;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(304, 22);
            this.txtPhoneNumber.TabIndex = 14;
            this.txtPhoneNumber.Tag = "Phone Number";
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(130)))), ((int)(((byte)(177)))));
            this.lblPhone.Location = new System.Drawing.Point(5, 312);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(280, 73);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Phone Number *";
            this.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDOB
            // 
            this.lblDOB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(130)))), ((int)(((byte)(177)))));
            this.lblDOB.Location = new System.Drawing.Point(5, 235);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(280, 76);
            this.lblDOB.TabIndex = 11;
            this.lblDOB.Text = "DOB *";
            this.lblDOB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFName
            // 
            this.txtFName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtFName.Location = new System.Drawing.Point(293, 3);
            this.txtFName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFName.MaxLength = 16;
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(304, 22);
            this.txtFName.TabIndex = 6;
            this.txtFName.Tag = "First Name";
            // 
            // lblSName
            // 
            this.lblSName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(130)))), ((int)(((byte)(177)))));
            this.lblSName.Location = new System.Drawing.Point(5, 81);
            this.lblSName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(280, 79);
            this.lblSName.TabIndex = 7;
            this.lblSName.Text = "Surname *";
            this.lblSName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSName
            // 
            this.txtSName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSName.Location = new System.Drawing.Point(293, 83);
            this.txtSName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSName.MaxLength = 16;
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(304, 22);
            this.txtSName.TabIndex = 8;
            this.txtSName.Tag = "Surname";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(130)))), ((int)(((byte)(177)))));
            this.lblTitle.Location = new System.Drawing.Point(5, 161);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(280, 73);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Title *";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress1.Location = new System.Drawing.Point(293, 388);
            this.txtAddress1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress1.MaxLength = 64;
            this.txtAddress1.Multiline = true;
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(304, 69);
            this.txtAddress1.TabIndex = 16;
            this.txtAddress1.Tag = "Address Line 1";
            // 
            // pnlTitle
            // 
            this.pnlTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTitle.Controls.Add(this.comboTitle);
            this.pnlTitle.Location = new System.Drawing.Point(293, 164);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(304, 36);
            this.pnlTitle.TabIndex = 21;
            this.pnlTitle.Tag = "Title";
            // 
            // comboTitle
            // 
            this.comboTitle.DisplayMember = "Mr";
            this.comboTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTitle.FormattingEnabled = true;
            this.comboTitle.Items.AddRange(new object[] {
            "Mrs",
            "Miss",
            "Mr",
            "Master",
            "Dr"});
            this.comboTitle.Location = new System.Drawing.Point(3, 8);
            this.comboTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboTitle.Name = "comboTitle";
            this.comboTitle.Size = new System.Drawing.Size(304, 24);
            this.comboTitle.TabIndex = 10;
            this.comboTitle.Tag = "Title";
            // 
            // txtAddress2
            // 
            this.txtAddress2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress2.Location = new System.Drawing.Point(293, 462);
            this.txtAddress2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress2.MaxLength = 64;
            this.txtAddress2.Multiline = true;
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Size = new System.Drawing.Size(304, 71);
            this.txtAddress2.TabIndex = 17;
            this.txtAddress2.Tag = "Address Line 2";
            // 
            // txtAddress3
            // 
            this.txtAddress3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAddress3.Location = new System.Drawing.Point(293, 538);
            this.txtAddress3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress3.MaxLength = 64;
            this.txtAddress3.Multiline = true;
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.Size = new System.Drawing.Size(304, 98);
            this.txtAddress3.TabIndex = 19;
            this.txtAddress3.Tag = "Address Line 3";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSubmit.Location = new System.Drawing.Point(1221, 503);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(136, 81);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.txtAllergies, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAllergiesText, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(661, 311);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(463, 273);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // txtAllergies
            // 
            this.txtAllergies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAllergies.Location = new System.Drawing.Point(6, 98);
            this.txtAllergies.Margin = new System.Windows.Forms.Padding(4);
            this.txtAllergies.Multiline = true;
            this.txtAllergies.Name = "txtAllergies";
            this.txtAllergies.Size = new System.Drawing.Size(451, 152);
            this.txtAllergies.TabIndex = 17;
            // 
            // lblAllergiesText
            // 
            this.lblAllergiesText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAllergiesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllergiesText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(130)))), ((int)(((byte)(177)))));
            this.lblAllergiesText.Location = new System.Drawing.Point(5, 1);
            this.lblAllergiesText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllergiesText.Name = "lblAllergiesText";
            this.lblAllergiesText.Size = new System.Drawing.Size(453, 75);
            this.lblAllergiesText.TabIndex = 17;
            this.lblAllergiesText.Text = "Please list any Allergies below:";
            this.lblAllergiesText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel2.Controls.Add(this.cbSmoker, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.cbDiabetes, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbAsthmatic, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lblFlagText, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(779, 68);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.48148F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.51852F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(344, 192);
            this.tableLayoutPanel2.TabIndex = 18;
            // 
            // cbSmoker
            // 
            this.cbSmoker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSmoker.AutoSize = true;
            this.cbSmoker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSmoker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(130)))), ((int)(((byte)(177)))));
            this.cbSmoker.Location = new System.Drawing.Point(129, 117);
            this.cbSmoker.Margin = new System.Windows.Forms.Padding(4);
            this.cbSmoker.Name = "cbSmoker";
            this.cbSmoker.Size = new System.Drawing.Size(86, 24);
            this.cbSmoker.TabIndex = 19;
            this.cbSmoker.Text = "Smoker";
            this.cbSmoker.UseVisualStyleBackColor = true;
            // 
            // cbDiabetes
            // 
            this.cbDiabetes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDiabetes.AutoSize = true;
            this.cbDiabetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiabetes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(130)))), ((int)(((byte)(177)))));
            this.cbDiabetes.Location = new System.Drawing.Point(127, 73);
            this.cbDiabetes.Margin = new System.Windows.Forms.Padding(4);
            this.cbDiabetes.Name = "cbDiabetes";
            this.cbDiabetes.Size = new System.Drawing.Size(89, 24);
            this.cbDiabetes.TabIndex = 18;
            this.cbDiabetes.Text = "Diabetic";
            this.cbDiabetes.UseVisualStyleBackColor = true;
            // 
            // cbAsthmatic
            // 
            this.cbAsthmatic.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbAsthmatic.AutoSize = true;
            this.cbAsthmatic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbAsthmatic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(130)))), ((int)(((byte)(177)))));
            this.cbAsthmatic.Location = new System.Drawing.Point(121, 159);
            this.cbAsthmatic.Margin = new System.Windows.Forms.Padding(4);
            this.cbAsthmatic.Name = "cbAsthmatic";
            this.cbAsthmatic.Size = new System.Drawing.Size(102, 24);
            this.cbAsthmatic.TabIndex = 20;
            this.cbAsthmatic.Text = "Asthmatic";
            this.cbAsthmatic.UseVisualStyleBackColor = true;
            // 
            // lblFlagText
            // 
            this.lblFlagText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFlagText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlagText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(130)))), ((int)(((byte)(177)))));
            this.lblFlagText.Location = new System.Drawing.Point(5, 1);
            this.lblFlagText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlagText.Name = "lblFlagText";
            this.lblFlagText.Size = new System.Drawing.Size(334, 60);
            this.lblFlagText.TabIndex = 17;
            this.lblFlagText.Text = "Are you any of the following?";
            this.lblFlagText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Image = global::BasicGP.Properties.Resources.logo1;
            this.picLogo.Location = new System.Drawing.Point(1188, 48);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(169, 124);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 19;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.ToDashboard);
            // 
            // lblErrorMsg
            // 
            this.lblErrorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorMsg.ForeColor = System.Drawing.Color.LightCoral;
            this.lblErrorMsg.Location = new System.Drawing.Point(661, 606);
            this.lblErrorMsg.Name = "lblErrorMsg";
            this.lblErrorMsg.Size = new System.Drawing.Size(684, 137);
            this.lblErrorMsg.TabIndex = 20;
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(130)))), ((int)(((byte)(177)))));
            this.lblRegister.Location = new System.Drawing.Point(21, -3);
            this.lblRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(250, 67);
            this.lblRegister.TabIndex = 21;
            this.lblRegister.Text = "Register";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(193)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1411, 752);
            this.Controls.Add(this.lblRegister);
            this.Controls.Add(this.lblErrorMsg);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tableLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1429, 799);
            this.MinimumSize = new System.Drawing.Size(1429, 799);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.pnlDOB.ResumeLayout(false);
            this.pnlTitle.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtAddress1;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.ComboBox comboTitle;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtAllergies;
        private System.Windows.Forms.Label lblAllergiesText;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblFlagText;
        private System.Windows.Forms.CheckBox cbAsthmatic;
        private System.Windows.Forms.CheckBox cbSmoker;
        private System.Windows.Forms.CheckBox cbDiabetes;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblAddress2;
        private System.Windows.Forms.TextBox txtAddress2;
        private System.Windows.Forms.Label lblAddress1;
        private System.Windows.Forms.Label lblAddress3;
        private System.Windows.Forms.TextBox txtAddress3;
        private System.Windows.Forms.Label lblErrorMsg;
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlDOB;
        private System.Windows.Forms.Label lblRegister;
    }
}