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
            this.lblNHNumber = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtNHNumber = new System.Windows.Forms.TextBox();
            this.lblSName = new System.Windows.Forms.Label();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.comboTitle = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtAllergies = new System.Windows.Forms.TextBox();
            this.lblAllergiesText = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.cbSmoker = new System.Windows.Forms.CheckBox();
            this.lblFlagText = new System.Windows.Forms.Label();
            this.cbDiabetes = new System.Windows.Forms.CheckBox();
            this.cbAsthmatic = new System.Windows.Forms.CheckBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
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
            this.lblNHNumber.Size = new System.Drawing.Size(260, 54);
            this.lblNHNumber.TabIndex = 1;
            this.lblNHNumber.Text = "NHS Number *";
            this.lblNHNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFName
            // 
            this.lblFName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(5, 56);
            this.lblFName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(260, 53);
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
            this.tableLayoutPanel3.Controls.Add(this.txtAddress, 1, 6);
            this.tableLayoutPanel3.Controls.Add(this.lblAddress, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.txtPhoneNumber, 1, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblPhone, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.lblDOB, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.txtFName, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblFName, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lblNHNumber, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtNHNumber, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.lblSName, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txtSName, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.lblTitle, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.comboTitle, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.dtpDOB, 1, 4);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 11);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 7;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.81967F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.18033F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(558, 361);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.Location = new System.Drawing.Point(274, 263);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(279, 86);
            this.txtAddress.TabIndex = 16;
            // 
            // lblAddress
            // 
            this.lblAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(5, 252);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(260, 108);
            this.lblAddress.TabIndex = 15;
            this.lblAddress.Text = "Address *";
            this.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPhoneNumber.Location = new System.Drawing.Point(274, 222);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(279, 22);
            this.txtPhoneNumber.TabIndex = 14;
            this.txtPhoneNumber.Leave += new System.EventHandler(this.txtNumber_validation);
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(5, 215);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(260, 36);
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
            this.lblDOB.Location = new System.Drawing.Point(5, 180);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(260, 34);
            this.lblDOB.TabIndex = 11;
            this.lblDOB.Text = "DOB *";
            this.lblDOB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFName
            // 
            this.txtFName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFName.Location = new System.Drawing.Point(274, 71);
            this.txtFName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(279, 22);
            this.txtFName.TabIndex = 6;
            // 
            // txtNHNumber
            // 
            this.txtNHNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNHNumber.Location = new System.Drawing.Point(274, 17);
            this.txtNHNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNHNumber.MaxLength = 10;
            this.txtNHNumber.Name = "txtNHNumber";
            this.txtNHNumber.Size = new System.Drawing.Size(279, 22);
            this.txtNHNumber.TabIndex = 5;
            this.txtNHNumber.Leave += new System.EventHandler(this.txtNumber_validation);
            // 
            // lblSName
            // 
            this.lblSName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSName.Location = new System.Drawing.Point(5, 110);
            this.lblSName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(260, 32);
            this.lblSName.TabIndex = 7;
            this.lblSName.Text = "Surname *";
            this.lblSName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSName
            // 
            this.txtSName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSName.Location = new System.Drawing.Point(274, 115);
            this.txtSName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(279, 22);
            this.txtSName.TabIndex = 8;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(5, 143);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(260, 36);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Title *";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboTitle
            // 
            this.comboTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboTitle.DisplayMember = "Mr";
            this.comboTitle.FormattingEnabled = true;
            this.comboTitle.Items.AddRange(new object[] {
            "Mrs",
            "Miss",
            "Mr",
            "Master"});
            this.comboTitle.Location = new System.Drawing.Point(274, 149);
            this.comboTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboTitle.Name = "comboTitle";
            this.comboTitle.Size = new System.Drawing.Size(279, 24);
            this.comboTitle.TabIndex = 10;
            this.comboTitle.Text = "Please Select";
            // 
            // dtpDOB
            // 
            this.dtpDOB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(274, 186);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDOB.MaxDate = new System.DateTime(2017, 11, 24, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(279, 22);
            this.dtpDOB.TabIndex = 12;
            this.dtpDOB.Value = new System.DateTime(2000, 1, 1, 19, 53, 0, 0);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSubmit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnSubmit.Location = new System.Drawing.Point(798, 502);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(136, 82);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Controls.Add(this.txtAllergies, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAllergiesText, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(100, 421);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(462, 171);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // txtAllergies
            // 
            this.txtAllergies.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAllergies.Location = new System.Drawing.Point(6, 53);
            this.txtAllergies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAllergies.Multiline = true;
            this.txtAllergies.Name = "txtAllergies";
            this.txtAllergies.Size = new System.Drawing.Size(450, 112);
            this.txtAllergies.TabIndex = 17;
            // 
            // lblAllergiesText
            // 
            this.lblAllergiesText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAllergiesText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllergiesText.Location = new System.Drawing.Point(5, 1);
            this.lblAllergiesText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllergiesText.Name = "lblAllergiesText";
            this.lblAllergiesText.Size = new System.Drawing.Size(452, 47);
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
            this.tableLayoutPanel2.Controls.Add(this.lblFlagText, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbDiabetes, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbAsthmatic, 0, 3);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(601, 154);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.cbSmoker.Location = new System.Drawing.Point(129, 117);
            this.cbSmoker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSmoker.Name = "cbSmoker";
            this.cbSmoker.Size = new System.Drawing.Size(86, 24);
            this.cbSmoker.TabIndex = 19;
            this.cbSmoker.Text = "Smoker";
            this.cbSmoker.UseVisualStyleBackColor = true;
            // 
            // lblFlagText
            // 
            this.lblFlagText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFlagText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlagText.Location = new System.Drawing.Point(5, 1);
            this.lblFlagText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlagText.Name = "lblFlagText";
            this.lblFlagText.Size = new System.Drawing.Size(334, 60);
            this.lblFlagText.TabIndex = 17;
            this.lblFlagText.Text = "Are you any of the following?";
            this.lblFlagText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbDiabetes
            // 
            this.cbDiabetes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbDiabetes.AutoSize = true;
            this.cbDiabetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDiabetes.Location = new System.Drawing.Point(127, 73);
            this.cbDiabetes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.cbAsthmatic.Location = new System.Drawing.Point(121, 159);
            this.cbAsthmatic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAsthmatic.Name = "cbAsthmatic";
            this.cbAsthmatic.Size = new System.Drawing.Size(102, 24);
            this.cbAsthmatic.TabIndex = 20;
            this.cbAsthmatic.Text = "Asthmatic";
            this.cbAsthmatic.UseVisualStyleBackColor = true;
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Image = global::BasicGP.Properties.Resources.logo1;
            this.picLogo.InitialImage = global::BasicGP.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(765, 13);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(169, 124);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 19;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 595);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tableLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNHNumber;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtNHNumber;
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
    }
}