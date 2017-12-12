using System;

namespace BasicGP
{
    partial class DutyForm
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
            this.lblTitleDuty = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.dgvDuty = new System.Windows.Forms.DataGridView();
            this.mcDutyDate = new System.Windows.Forms.MonthCalendar();
            this.lblTitleAvailability = new System.Windows.Forms.Label();
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.lbl0800 = new System.Windows.Forms.Label();
            this.lblAvailable1 = new System.Windows.Forms.Label();
            this.lbl0830 = new System.Windows.Forms.Label();
            this.lblAvailable2 = new System.Windows.Forms.Label();
            this.lbl0900 = new System.Windows.Forms.Label();
            this.lblAvailable3 = new System.Windows.Forms.Label();
            this.lbl0930 = new System.Windows.Forms.Label();
            this.lblAvailable4 = new System.Windows.Forms.Label();
            this.lbl1000 = new System.Windows.Forms.Label();
            this.lblAvailable5 = new System.Windows.Forms.Label();
            this.lbl1030 = new System.Windows.Forms.Label();
            this.lblAvailable6 = new System.Windows.Forms.Label();
            this.lbl1100 = new System.Windows.Forms.Label();
            this.lblAvailable7 = new System.Windows.Forms.Label();
            this.lbl1130 = new System.Windows.Forms.Label();
            this.lblAvailable8 = new System.Windows.Forms.Label();
            this.lbl1200 = new System.Windows.Forms.Label();
            this.lblAvailable9 = new System.Windows.Forms.Label();
            this.lbl1230 = new System.Windows.Forms.Label();
            this.lblAvailable10 = new System.Windows.Forms.Label();
            this.lbl1300 = new System.Windows.Forms.Label();
            this.lblAvailable11 = new System.Windows.Forms.Label();
            this.lbl1330 = new System.Windows.Forms.Label();
            this.lblAvailable12 = new System.Windows.Forms.Label();
            this.lbl1400 = new System.Windows.Forms.Label();
            this.lblAvailable13 = new System.Windows.Forms.Label();
            this.lbl1430 = new System.Windows.Forms.Label();
            this.lblAvailable14 = new System.Windows.Forms.Label();
            this.lbl1500 = new System.Windows.Forms.Label();
            this.lblAvailable15 = new System.Windows.Forms.Label();
            this.lbl1530 = new System.Windows.Forms.Label();
            this.lblAvailable16 = new System.Windows.Forms.Label();
            this.lbl1600 = new System.Windows.Forms.Label();
            this.lblAvailable17 = new System.Windows.Forms.Label();
            this.lbl1630 = new System.Windows.Forms.Label();
            this.lblAvailable18 = new System.Windows.Forms.Label();
            this.lbl1700 = new System.Windows.Forms.Label();
            this.lblAvailable19 = new System.Windows.Forms.Label();
            this.lbl1730 = new System.Windows.Forms.Label();
            this.lblAvailable20 = new System.Windows.Forms.Label();
            this.lblSubTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuty)).BeginInit();
            this.tableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitleDuty
            // 
            this.lblTitleDuty.AutoSize = true;
            this.lblTitleDuty.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleDuty.ForeColor = Constants.TitleColor;
            this.lblTitleDuty.Location = new System.Drawing.Point(715, 37);
            this.lblTitleDuty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleDuty.Name = "lblTitleDuty";
            this.lblTitleDuty.Size = new System.Drawing.Size(151, 67);
            this.lblTitleDuty.TabIndex = 5;
            this.lblTitleDuty.Text = "Duty";
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Image = global::BasicGP.Properties.Resources.logo1;
            this.picLogo.InitialImage = global::BasicGP.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(1252, 15);
            this.picLogo.Margin = new System.Windows.Forms.Padding(4);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(169, 124);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 7;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.PicLogo_Click);
            // 
            // dgvDuty
            // 
            this.dgvDuty.AllowUserToAddRows = false;
            this.dgvDuty.AllowUserToDeleteRows = false;
            this.dgvDuty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDuty.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDuty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDuty.Location = new System.Drawing.Point(714, 367);
            this.dgvDuty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDuty.Name = "dgvDuty";
            this.dgvDuty.ReadOnly = true;
            this.dgvDuty.RowHeadersVisible = false;
            this.dgvDuty.RowHeadersWidth = 5;
            this.dgvDuty.RowTemplate.Height = 28;
            this.dgvDuty.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDuty.Size = new System.Drawing.Size(602, 439);
            this.dgvDuty.TabIndex = 8;
            this.dgvDuty.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvCellDoubleClick);
            // 
            // mcDutyDate
            // 
            this.mcDutyDate.Location = new System.Drawing.Point(714, 147);
            this.mcDutyDate.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.mcDutyDate.MinDate = new System.DateTime(2017, 12, 4, 0, 0, 0, 0);
            this.mcDutyDate.Name = "mcDutyDate";
            this.mcDutyDate.TabIndex = 9;
            this.mcDutyDate.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.McDutyDate_DateChanged);
            // 
            // lblTitleAvailability
            // 
            this.lblTitleAvailability.AutoSize = true;
            this.lblTitleAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAvailability.ForeColor = Constants.TitleColor;
            this.lblTitleAvailability.Location = new System.Drawing.Point(64, 37);
            this.lblTitleAvailability.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleAvailability.Name = "lblTitleAvailability";
            this.lblTitleAvailability.Size = new System.Drawing.Size(295, 67);
            this.lblTitleAvailability.TabIndex = 10;
            this.lblTitleAvailability.Text = "Availabilty";
            // 
            // tableLayout
            // 
            this.tableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableLayout.ColumnCount = 2;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 273F));
            this.tableLayout.Controls.Add(this.lbl0800, 0, 0);
            this.tableLayout.Controls.Add(this.lblAvailable1, 1, 0);
            this.tableLayout.Controls.Add(this.lbl0830, 0, 1);
            this.tableLayout.Controls.Add(this.lblAvailable2, 1, 1);
            this.tableLayout.Controls.Add(this.lbl0900, 0, 2);
            this.tableLayout.Controls.Add(this.lblAvailable3, 1, 2);
            this.tableLayout.Controls.Add(this.lbl0930, 0, 3);
            this.tableLayout.Controls.Add(this.lblAvailable4, 1, 3);
            this.tableLayout.Controls.Add(this.lbl1000, 0, 4);
            this.tableLayout.Controls.Add(this.lblAvailable5, 1, 4);
            this.tableLayout.Controls.Add(this.lbl1030, 0, 5);
            this.tableLayout.Controls.Add(this.lblAvailable6, 1, 5);
            this.tableLayout.Controls.Add(this.lbl1100, 0, 6);
            this.tableLayout.Controls.Add(this.lblAvailable7, 1, 6);
            this.tableLayout.Controls.Add(this.lbl1130, 0, 7);
            this.tableLayout.Controls.Add(this.lblAvailable8, 1, 7);
            this.tableLayout.Controls.Add(this.lbl1200, 0, 8);
            this.tableLayout.Controls.Add(this.lblAvailable9, 1, 8);
            this.tableLayout.Controls.Add(this.lbl1230, 0, 9);
            this.tableLayout.Controls.Add(this.lblAvailable10, 1, 9);
            this.tableLayout.Controls.Add(this.lbl1300, 0, 10);
            this.tableLayout.Controls.Add(this.lblAvailable11, 1, 10);
            this.tableLayout.Controls.Add(this.lbl1330, 0, 11);
            this.tableLayout.Controls.Add(this.lblAvailable12, 1, 11);
            this.tableLayout.Controls.Add(this.lbl1400, 0, 12);
            this.tableLayout.Controls.Add(this.lblAvailable13, 1, 12);
            this.tableLayout.Controls.Add(this.lbl1430, 0, 13);
            this.tableLayout.Controls.Add(this.lblAvailable14, 1, 13);
            this.tableLayout.Controls.Add(this.lbl1500, 0, 14);
            this.tableLayout.Controls.Add(this.lblAvailable15, 1, 14);
            this.tableLayout.Controls.Add(this.lbl1530, 0, 15);
            this.tableLayout.Controls.Add(this.lblAvailable16, 1, 15);
            this.tableLayout.Controls.Add(this.lbl1600, 0, 16);
            this.tableLayout.Controls.Add(this.lblAvailable17, 1, 16);
            this.tableLayout.Controls.Add(this.lbl1630, 0, 17);
            this.tableLayout.Controls.Add(this.lblAvailable18, 1, 17);
            this.tableLayout.Controls.Add(this.lbl1700, 0, 18);
            this.tableLayout.Controls.Add(this.lblAvailable19, 1, 18);
            this.tableLayout.Controls.Add(this.lbl1730, 0, 19);
            this.tableLayout.Controls.Add(this.lblAvailable20, 1, 19);
            this.tableLayout.Location = new System.Drawing.Point(76, 145);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 20;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.999399F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.999399F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.999399F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.999399F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.999399F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.999399F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.999399F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.999399F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.999399F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.999399F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.999399F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.999399F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.999399F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.999399F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.999399F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.999399F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.999399F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0034F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0034F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0034F));
            this.tableLayout.Size = new System.Drawing.Size(444, 665);
            this.tableLayout.TabIndex = 11;
            // 
            // lbl0800
            // 
            this.lbl0800.BackColor = System.Drawing.Color.Transparent;
            this.lbl0800.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl0800.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0800.ForeColor = Constants.lblColor;
            this.lbl0800.Location = new System.Drawing.Point(6, 3);
            this.lbl0800.Name = "lbl0800";
            this.lbl0800.Size = new System.Drawing.Size(156, 30);
            this.lbl0800.TabIndex = 0;
            this.lbl0800.Text = "08:00";
            this.lbl0800.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvailable1
            // 
            this.lblAvailable1.AutoSize = true;
            this.lblAvailable1.BackColor = System.Drawing.Color.PaleGreen;
            this.lblAvailable1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailable1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable1.ForeColor = Constants.lblColor;
            this.lblAvailable1.Location = new System.Drawing.Point(171, 3);
            this.lblAvailable1.Name = "lblAvailable1";
            this.lblAvailable1.Size = new System.Drawing.Size(267, 30);
            this.lblAvailable1.TabIndex = 1;
            this.lblAvailable1.Text = "Available";
            this.lblAvailable1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl0830
            // 
            this.lbl0830.BackColor = System.Drawing.Color.Transparent;
            this.lbl0830.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl0830.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0830.ForeColor = Constants.lblColor;
            this.lbl0830.Location = new System.Drawing.Point(6, 36);
            this.lbl0830.Name = "lbl0830";
            this.lbl0830.Size = new System.Drawing.Size(156, 30);
            this.lbl0830.TabIndex = 2;
            this.lbl0830.Text = "08:30";
            this.lbl0830.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvailable2
            // 
            this.lblAvailable2.AutoSize = true;
            this.lblAvailable2.BackColor = System.Drawing.Color.PaleGreen;
            this.lblAvailable2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailable2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable2.ForeColor = Constants.lblColor;
            this.lblAvailable2.Location = new System.Drawing.Point(171, 36);
            this.lblAvailable2.Name = "lblAvailable2";
            this.lblAvailable2.Size = new System.Drawing.Size(267, 30);
            this.lblAvailable2.TabIndex = 3;
            this.lblAvailable2.Text = "Available";
            this.lblAvailable2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl0900
            // 
            this.lbl0900.BackColor = System.Drawing.Color.Transparent;
            this.lbl0900.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl0900.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0900.ForeColor = Constants.lblColor;
            this.lbl0900.Location = new System.Drawing.Point(6, 69);
            this.lbl0900.Name = "lbl0900";
            this.lbl0900.Size = new System.Drawing.Size(156, 30);
            this.lbl0900.TabIndex = 22;
            this.lbl0900.Text = "09:00";
            this.lbl0900.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvailable3
            // 
            this.lblAvailable3.AutoSize = true;
            this.lblAvailable3.BackColor = System.Drawing.Color.PaleGreen;
            this.lblAvailable3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailable3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable3.ForeColor = Constants.lblColor;
            this.lblAvailable3.Location = new System.Drawing.Point(171, 69);
            this.lblAvailable3.Name = "lblAvailable3";
            this.lblAvailable3.Size = new System.Drawing.Size(267, 30);
            this.lblAvailable3.TabIndex = 4;
            this.lblAvailable3.Text = "Available";
            this.lblAvailable3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl0930
            // 
            this.lbl0930.BackColor = System.Drawing.Color.Transparent;
            this.lbl0930.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl0930.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0930.ForeColor = Constants.lblColor;
            this.lbl0930.Location = new System.Drawing.Point(6, 102);
            this.lbl0930.Name = "lbl0930";
            this.lbl0930.Size = new System.Drawing.Size(156, 30);
            this.lbl0930.TabIndex = 23;
            this.lbl0930.Text = "09:30";
            this.lbl0930.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvailable4
            // 
            this.lblAvailable4.AutoSize = true;
            this.lblAvailable4.BackColor = System.Drawing.Color.PaleGreen;
            this.lblAvailable4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailable4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable4.ForeColor = Constants.lblColor;
            this.lblAvailable4.Location = new System.Drawing.Point(171, 102);
            this.lblAvailable4.Name = "lblAvailable4";
            this.lblAvailable4.Size = new System.Drawing.Size(267, 30);
            this.lblAvailable4.TabIndex = 5;
            this.lblAvailable4.Text = "Available";
            this.lblAvailable4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl1000
            // 
            this.lbl1000.BackColor = System.Drawing.Color.Transparent;
            this.lbl1000.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1000.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1000.ForeColor = Constants.lblColor;
            this.lbl1000.Location = new System.Drawing.Point(6, 135);
            this.lbl1000.Name = "lbl1000";
            this.lbl1000.Size = new System.Drawing.Size(156, 30);
            this.lbl1000.TabIndex = 24;
            this.lbl1000.Text = "10:00";
            this.lbl1000.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvailable5
            // 
            this.lblAvailable5.AutoSize = true;
            this.lblAvailable5.BackColor = System.Drawing.Color.PaleGreen;
            this.lblAvailable5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailable5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable5.ForeColor = Constants.lblColor;
            this.lblAvailable5.Location = new System.Drawing.Point(171, 135);
            this.lblAvailable5.Name = "lblAvailable5";
            this.lblAvailable5.Size = new System.Drawing.Size(267, 30);
            this.lblAvailable5.TabIndex = 6;
            this.lblAvailable5.Text = "Available";
            this.lblAvailable5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl1030
            // 
            this.lbl1030.BackColor = System.Drawing.Color.Transparent;
            this.lbl1030.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1030.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1030.ForeColor = Constants.lblColor;
            this.lbl1030.Location = new System.Drawing.Point(6, 168);
            this.lbl1030.Name = "lbl1030";
            this.lbl1030.Size = new System.Drawing.Size(156, 30);
            this.lbl1030.TabIndex = 25;
            this.lbl1030.Text = "10:30";
            this.lbl1030.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvailable6
            // 
            this.lblAvailable6.AutoSize = true;
            this.lblAvailable6.BackColor = System.Drawing.Color.PaleGreen;
            this.lblAvailable6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailable6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable6.ForeColor = Constants.lblColor;
            this.lblAvailable6.Location = new System.Drawing.Point(171, 168);
            this.lblAvailable6.Name = "lblAvailable6";
            this.lblAvailable6.Size = new System.Drawing.Size(267, 30);
            this.lblAvailable6.TabIndex = 7;
            this.lblAvailable6.Text = "Available";
            this.lblAvailable6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl1100
            // 
            this.lbl1100.BackColor = System.Drawing.Color.Transparent;
            this.lbl1100.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1100.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1100.ForeColor = Constants.lblColor;
            this.lbl1100.Location = new System.Drawing.Point(6, 201);
            this.lbl1100.Name = "lbl1100";
            this.lbl1100.Size = new System.Drawing.Size(156, 30);
            this.lbl1100.TabIndex = 26;
            this.lbl1100.Text = "11:00";
            this.lbl1100.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvailable7
            // 
            this.lblAvailable7.AutoSize = true;
            this.lblAvailable7.BackColor = System.Drawing.Color.PaleGreen;
            this.lblAvailable7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailable7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable7.ForeColor = Constants.lblColor;
            this.lblAvailable7.Location = new System.Drawing.Point(171, 201);
            this.lblAvailable7.Name = "lblAvailable7";
            this.lblAvailable7.Size = new System.Drawing.Size(267, 30);
            this.lblAvailable7.TabIndex = 8;
            this.lblAvailable7.Text = "Available";
            this.lblAvailable7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl1130
            // 
            this.lbl1130.BackColor = System.Drawing.Color.Transparent;
            this.lbl1130.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1130.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1130.ForeColor = Constants.lblColor;
            this.lbl1130.Location = new System.Drawing.Point(6, 234);
            this.lbl1130.Name = "lbl1130";
            this.lbl1130.Size = new System.Drawing.Size(156, 30);
            this.lbl1130.TabIndex = 27;
            this.lbl1130.Text = "11:30";
            this.lbl1130.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvailable8
            // 
            this.lblAvailable8.AutoSize = true;
            this.lblAvailable8.BackColor = System.Drawing.Color.PaleGreen;
            this.lblAvailable8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailable8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable8.ForeColor = Constants.lblColor;
            this.lblAvailable8.Location = new System.Drawing.Point(171, 234);
            this.lblAvailable8.Name = "lblAvailable8";
            this.lblAvailable8.Size = new System.Drawing.Size(267, 30);
            this.lblAvailable8.TabIndex = 9;
            this.lblAvailable8.Text = "Available";
            this.lblAvailable8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl1200
            // 
            this.lbl1200.BackColor = System.Drawing.Color.Transparent;
            this.lbl1200.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1200.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1200.ForeColor = Constants.lblColor;
            this.lbl1200.Location = new System.Drawing.Point(6, 267);
            this.lbl1200.Name = "lbl1200";
            this.lbl1200.Size = new System.Drawing.Size(156, 30);
            this.lbl1200.TabIndex = 28;
            this.lbl1200.Text = "12:00";
            this.lbl1200.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvailable9
            // 
            this.lblAvailable9.AutoSize = true;
            this.lblAvailable9.BackColor = System.Drawing.Color.PaleGreen;
            this.lblAvailable9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailable9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable9.ForeColor = Constants.lblColor;
            this.lblAvailable9.Location = new System.Drawing.Point(171, 267);
            this.lblAvailable9.Name = "lblAvailable9";
            this.lblAvailable9.Size = new System.Drawing.Size(267, 30);
            this.lblAvailable9.TabIndex = 10;
            this.lblAvailable9.Text = "Available";
            this.lblAvailable9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl1230
            // 
            this.lbl1230.BackColor = System.Drawing.Color.Transparent;
            this.lbl1230.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1230.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1230.ForeColor = Constants.lblColor;
            this.lbl1230.Location = new System.Drawing.Point(6, 300);
            this.lbl1230.Name = "lbl1230";
            this.lbl1230.Size = new System.Drawing.Size(156, 30);
            this.lbl1230.TabIndex = 29;
            this.lbl1230.Text = "12:30";
            this.lbl1230.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvailable10
            // 
            this.lblAvailable10.AutoSize = true;
            this.lblAvailable10.BackColor = System.Drawing.Color.PaleGreen;
            this.lblAvailable10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailable10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable10.ForeColor = Constants.lblColor;
            this.lblAvailable10.Location = new System.Drawing.Point(171, 300);
            this.lblAvailable10.Name = "lblAvailable10";
            this.lblAvailable10.Size = new System.Drawing.Size(267, 30);
            this.lblAvailable10.TabIndex = 11;
            this.lblAvailable10.Text = "Available";
            this.lblAvailable10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl1300
            // 
            this.lbl1300.BackColor = System.Drawing.Color.Transparent;
            this.lbl1300.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1300.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1300.ForeColor = Constants.lblColor;
            this.lbl1300.Location = new System.Drawing.Point(6, 333);
            this.lbl1300.Name = "lbl1300";
            this.lbl1300.Size = new System.Drawing.Size(156, 30);
            this.lbl1300.TabIndex = 30;
            this.lbl1300.Text = "13:00";
            this.lbl1300.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvailable11
            // 
            this.lblAvailable11.AutoSize = true;
            this.lblAvailable11.BackColor = System.Drawing.Color.PaleGreen;
            this.lblAvailable11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailable11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable11.ForeColor = Constants.lblColor;
            this.lblAvailable11.Location = new System.Drawing.Point(171, 333);
            this.lblAvailable11.Name = "lblAvailable11";
            this.lblAvailable11.Size = new System.Drawing.Size(267, 30);
            this.lblAvailable11.TabIndex = 12;
            this.lblAvailable11.Text = "Available";
            this.lblAvailable11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl1330
            // 
            this.lbl1330.BackColor = System.Drawing.Color.Transparent;
            this.lbl1330.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1330.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1330.ForeColor = Constants.lblColor;
            this.lbl1330.Location = new System.Drawing.Point(6, 366);
            this.lbl1330.Name = "lbl1330";
            this.lbl1330.Size = new System.Drawing.Size(156, 30);
            this.lbl1330.TabIndex = 31;
            this.lbl1330.Text = "13:30";
            this.lbl1330.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvailable12
            // 
            this.lblAvailable12.AutoSize = true;
            this.lblAvailable12.BackColor = System.Drawing.Color.PaleGreen;
            this.lblAvailable12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailable12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable12.ForeColor = Constants.lblColor;
            this.lblAvailable12.Location = new System.Drawing.Point(171, 366);
            this.lblAvailable12.Name = "lblAvailable12";
            this.lblAvailable12.Size = new System.Drawing.Size(267, 30);
            this.lblAvailable12.TabIndex = 13;
            this.lblAvailable12.Text = "Available";
            this.lblAvailable12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl1400
            // 
            this.lbl1400.BackColor = System.Drawing.Color.Transparent;
            this.lbl1400.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1400.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1400.ForeColor = Constants.lblColor;
            this.lbl1400.Location = new System.Drawing.Point(6, 399);
            this.lbl1400.Name = "lbl1400";
            this.lbl1400.Size = new System.Drawing.Size(156, 30);
            this.lbl1400.TabIndex = 32;
            this.lbl1400.Text = "14:00";
            this.lbl1400.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvailable13
            // 
            this.lblAvailable13.AutoSize = true;
            this.lblAvailable13.BackColor = System.Drawing.Color.PaleGreen;
            this.lblAvailable13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailable13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable13.ForeColor = Constants.lblColor;
            this.lblAvailable13.Location = new System.Drawing.Point(171, 399);
            this.lblAvailable13.Name = "lblAvailable13";
            this.lblAvailable13.Size = new System.Drawing.Size(267, 30);
            this.lblAvailable13.TabIndex = 14;
            this.lblAvailable13.Text = "Available";
            this.lblAvailable13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl1430
            // 
            this.lbl1430.BackColor = System.Drawing.Color.Transparent;
            this.lbl1430.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1430.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1430.ForeColor = Constants.lblColor;
            this.lbl1430.Location = new System.Drawing.Point(6, 432);
            this.lbl1430.Name = "lbl1430";
            this.lbl1430.Size = new System.Drawing.Size(156, 30);
            this.lbl1430.TabIndex = 33;
            this.lbl1430.Text = "14:30";
            this.lbl1430.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvailable14
            // 
            this.lblAvailable14.AutoSize = true;
            this.lblAvailable14.BackColor = System.Drawing.Color.PaleGreen;
            this.lblAvailable14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailable14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable14.ForeColor = Constants.lblColor;
            this.lblAvailable14.Location = new System.Drawing.Point(171, 432);
            this.lblAvailable14.Name = "lblAvailable14";
            this.lblAvailable14.Size = new System.Drawing.Size(267, 30);
            this.lblAvailable14.TabIndex = 15;
            this.lblAvailable14.Text = "Available";
            this.lblAvailable14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl1500
            // 
            this.lbl1500.BackColor = System.Drawing.Color.Transparent;
            this.lbl1500.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1500.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1500.ForeColor = Constants.lblColor;
            this.lbl1500.Location = new System.Drawing.Point(6, 465);
            this.lbl1500.Name = "lbl1500";
            this.lbl1500.Size = new System.Drawing.Size(156, 30);
            this.lbl1500.TabIndex = 34;
            this.lbl1500.Text = "15:00";
            this.lbl1500.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvailable15
            // 
            this.lblAvailable15.AutoSize = true;
            this.lblAvailable15.BackColor = System.Drawing.Color.PaleGreen;
            this.lblAvailable15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailable15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable15.ForeColor = Constants.lblColor;
            this.lblAvailable15.Location = new System.Drawing.Point(171, 465);
            this.lblAvailable15.Name = "lblAvailable15";
            this.lblAvailable15.Size = new System.Drawing.Size(267, 30);
            this.lblAvailable15.TabIndex = 16;
            this.lblAvailable15.Text = "Available";
            this.lblAvailable15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl1530
            // 
            this.lbl1530.BackColor = System.Drawing.Color.Transparent;
            this.lbl1530.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1530.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1530.ForeColor = Constants.lblColor;
            this.lbl1530.Location = new System.Drawing.Point(6, 498);
            this.lbl1530.Name = "lbl1530";
            this.lbl1530.Size = new System.Drawing.Size(156, 30);
            this.lbl1530.TabIndex = 35;
            this.lbl1530.Text = "15:30";
            this.lbl1530.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvailable16
            // 
            this.lblAvailable16.AutoSize = true;
            this.lblAvailable16.BackColor = System.Drawing.Color.PaleGreen;
            this.lblAvailable16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailable16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable16.ForeColor = Constants.lblColor;
            this.lblAvailable16.Location = new System.Drawing.Point(171, 498);
            this.lblAvailable16.Name = "lblAvailable16";
            this.lblAvailable16.Size = new System.Drawing.Size(267, 30);
            this.lblAvailable16.TabIndex = 17;
            this.lblAvailable16.Text = "Available";
            this.lblAvailable16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl1600
            // 
            this.lbl1600.BackColor = System.Drawing.Color.Transparent;
            this.lbl1600.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1600.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1600.ForeColor = Constants.lblColor;
            this.lbl1600.Location = new System.Drawing.Point(6, 531);
            this.lbl1600.Name = "lbl1600";
            this.lbl1600.Size = new System.Drawing.Size(156, 30);
            this.lbl1600.TabIndex = 36;
            this.lbl1600.Text = "16:00";
            this.lbl1600.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvailable17
            // 
            this.lblAvailable17.AutoSize = true;
            this.lblAvailable17.BackColor = System.Drawing.Color.PaleGreen;
            this.lblAvailable17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailable17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable17.ForeColor = Constants.lblColor;
            this.lblAvailable17.Location = new System.Drawing.Point(171, 531);
            this.lblAvailable17.Name = "lblAvailable17";
            this.lblAvailable17.Size = new System.Drawing.Size(267, 30);
            this.lblAvailable17.TabIndex = 18;
            this.lblAvailable17.Text = "Available";
            this.lblAvailable17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl1630
            // 
            this.lbl1630.BackColor = System.Drawing.Color.Transparent;
            this.lbl1630.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1630.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1630.ForeColor = Constants.lblColor;
            this.lbl1630.Location = new System.Drawing.Point(6, 564);
            this.lbl1630.Name = "lbl1630";
            this.lbl1630.Size = new System.Drawing.Size(156, 30);
            this.lbl1630.TabIndex = 37;
            this.lbl1630.Text = "16:30";
            this.lbl1630.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvailable18
            // 
            this.lblAvailable18.AutoSize = true;
            this.lblAvailable18.BackColor = System.Drawing.Color.PaleGreen;
            this.lblAvailable18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailable18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable18.ForeColor = Constants.lblColor;
            this.lblAvailable18.Location = new System.Drawing.Point(171, 564);
            this.lblAvailable18.Name = "lblAvailable18";
            this.lblAvailable18.Size = new System.Drawing.Size(267, 30);
            this.lblAvailable18.TabIndex = 19;
            this.lblAvailable18.Text = "Available";
            this.lblAvailable18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl1700
            // 
            this.lbl1700.BackColor = System.Drawing.Color.Transparent;
            this.lbl1700.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1700.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1700.ForeColor = Constants.lblColor;
            this.lbl1700.Location = new System.Drawing.Point(6, 597);
            this.lbl1700.Name = "lbl1700";
            this.lbl1700.Size = new System.Drawing.Size(156, 30);
            this.lbl1700.TabIndex = 38;
            this.lbl1700.Text = "17:00";
            this.lbl1700.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvailable19
            // 
            this.lblAvailable19.AutoSize = true;
            this.lblAvailable19.BackColor = System.Drawing.Color.PaleGreen;
            this.lblAvailable19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailable19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable19.ForeColor = Constants.lblColor;
            this.lblAvailable19.Location = new System.Drawing.Point(171, 597);
            this.lblAvailable19.Name = "lblAvailable19";
            this.lblAvailable19.Size = new System.Drawing.Size(267, 30);
            this.lblAvailable19.TabIndex = 20;
            this.lblAvailable19.Text = "Available";
            this.lblAvailable19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl1730
            // 
            this.lbl1730.BackColor = System.Drawing.Color.Transparent;
            this.lbl1730.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl1730.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1730.ForeColor = Constants.lblColor;
            this.lbl1730.Location = new System.Drawing.Point(6, 630);
            this.lbl1730.Name = "lbl1730";
            this.lbl1730.Size = new System.Drawing.Size(156, 32);
            this.lbl1730.TabIndex = 39;
            this.lbl1730.Text = "17:30";
            this.lbl1730.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAvailable20
            // 
            this.lblAvailable20.AutoSize = true;
            this.lblAvailable20.BackColor = System.Drawing.Color.PaleGreen;
            this.lblAvailable20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAvailable20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailable20.ForeColor = Constants.lblColor;
            this.lblAvailable20.Location = new System.Drawing.Point(171, 630);
            this.lblAvailable20.Name = "lblAvailable20";
            this.lblAvailable20.Size = new System.Drawing.Size(267, 32);
            this.lblAvailable20.TabIndex = 21;
            this.lblAvailable20.Text = "Available";
            this.lblAvailable20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubTitle
            // 
            this.lblSubTitle.AutoSize = true;
            this.lblSubTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTitle.ForeColor = Constants.lblColor;
            this.lblSubTitle.Location = new System.Drawing.Point(73, 104);
            this.lblSubTitle.Name = "lblSubTitle";
            this.lblSubTitle.Size = new System.Drawing.Size(425, 17);
            this.lblSubTitle.TabIndex = 12;
            this.lblSubTitle.Text = "Please selected a day then double click on the desiered employee";
            // 
            // DutyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = Constants.BkColor;
            this.ClientSize = new System.Drawing.Size(1428, 836);
            this.Controls.Add(this.lblSubTitle);
            this.Controls.Add(this.tableLayout);
            this.Controls.Add(this.lblTitleAvailability);
            this.Controls.Add(this.mcDutyDate);
            this.Controls.Add(this.dgvDuty);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.lblTitleDuty);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1454, 957);
            this.MinimumSize = new System.Drawing.Size(1437, 829);
            this.Name = "DutyForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Over Surgery | Results";
            this.Load += new System.EventHandler(this.ResultsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDuty)).EndInit();
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTitleDuty;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.DataGridView dgvDuty;
        private System.Windows.Forms.MonthCalendar mcDutyDate;
        private System.Windows.Forms.Label lblTitleAvailability;
        private System.Windows.Forms.Label lbl0800;
        private System.Windows.Forms.Label lblAvailable2;
        private System.Windows.Forms.Label lbl0830;
        private System.Windows.Forms.Label lblAvailable1;
        private System.Windows.Forms.Label lblSubTitle;
        private System.Windows.Forms.Label lblAvailable3;
        private System.Windows.Forms.Label lblAvailable4;
        private System.Windows.Forms.Label lblAvailable5;
        private System.Windows.Forms.Label lblAvailable6;
        private System.Windows.Forms.Label lblAvailable7;
        private System.Windows.Forms.Label lblAvailable8;
        private System.Windows.Forms.Label lblAvailable9;
        private System.Windows.Forms.Label lblAvailable10;
        private System.Windows.Forms.Label lblAvailable11;
        private System.Windows.Forms.Label lblAvailable12;
        private System.Windows.Forms.Label lblAvailable13;
        private System.Windows.Forms.Label lblAvailable14;
        private System.Windows.Forms.Label lblAvailable15;
        private System.Windows.Forms.Label lblAvailable16;
        private System.Windows.Forms.Label lblAvailable17;
        private System.Windows.Forms.Label lblAvailable18;
        private System.Windows.Forms.Label lblAvailable19;
        private System.Windows.Forms.Label lblAvailable20;
        private System.Windows.Forms.Label lbl0900;
        private System.Windows.Forms.Label lbl1730;
        private System.Windows.Forms.Label lbl0930;
        private System.Windows.Forms.Label lbl1000;
        private System.Windows.Forms.Label lbl1030;
        private System.Windows.Forms.Label lbl1100;
        private System.Windows.Forms.Label lbl1130;
        private System.Windows.Forms.Label lbl1200;
        private System.Windows.Forms.Label lbl1230;
        private System.Windows.Forms.Label lbl1300;
        private System.Windows.Forms.Label lbl1330;
        private System.Windows.Forms.Label lbl1400;
        private System.Windows.Forms.Label lbl1430;
        private System.Windows.Forms.Label lbl1500;
        private System.Windows.Forms.Label lbl1530;
        private System.Windows.Forms.Label lbl1600;
        private System.Windows.Forms.Label lbl1630;
        private System.Windows.Forms.Label lbl1700;
        private System.Windows.Forms.TableLayoutPanel tableLayout;
    }
}