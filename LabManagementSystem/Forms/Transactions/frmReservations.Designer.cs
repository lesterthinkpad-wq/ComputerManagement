namespace LabManagementSystem.Forms.Transactions
{
    partial class frmReservations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.components = new System.ComponentModel.Container();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.pnlFormLine = new System.Windows.Forms.Panel();
            this.lblStudent = new System.Windows.Forms.Label();
            this.cboStudent = new System.Windows.Forms.ComboBox();
            this.lblLaboratory = new System.Windows.Forms.Label();
            this.cboLaboratory = new System.Windows.Forms.ComboBox();
            this.lblComputer = new System.Windows.Forms.Label();
            this.cboComputer = new System.Windows.Forms.ComboBox();
            this.lblReservationDate = new System.Windows.Forms.Label();
            this.dtpReservationDate = new System.Windows.Forms.DateTimePicker();
            this.lblStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.lblTimeFrom = new System.Windows.Forms.Label();
            this.dtpTimeFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTimeTo = new System.Windows.Forms.Label();
            this.dtpTimeTo = new System.Windows.Forms.DateTimePicker();
            this.lblPurpose = new System.Windows.Forms.Label();
            this.txtPurpose = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pnlList = new System.Windows.Forms.Panel();
            this.lblListTitle = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pnlListLine = new System.Windows.Forms.Panel();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.lblRecordCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlList.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGridView cell styles
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(24, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(130, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Reservations";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(203, 213, 225);
            this.lblSubtitle.Location = new System.Drawing.Point(26, 42);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(270, 17);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Schedule and manage laboratory and computer reservations";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(30, 41, 59);
            this.pnlHeader.Controls.Add(this.lblSubtitle);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1100, 70);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblFormTitle.Location = new System.Drawing.Point(24, 18);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(150, 21);
            this.lblFormTitle.TabIndex = 3;
            this.lblFormTitle.Text = "Reservation Details";
            // 
            // pnlFormLine
            // 
            this.pnlFormLine.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.pnlFormLine.Location = new System.Drawing.Point(0, 54);
            this.pnlFormLine.Name = "pnlFormLine";
            this.pnlFormLine.Size = new System.Drawing.Size(360, 1);
            this.pnlFormLine.TabIndex = 4;
            // 
            // lblStudent
            // 
            this.lblStudent.AutoSize = true;
            this.lblStudent.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblStudent.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblStudent.Location = new System.Drawing.Point(24, 68);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.Size = new System.Drawing.Size(80, 17);
            this.lblStudent.TabIndex = 5;
            this.lblStudent.Text = "Student";
            // 
            // cboStudent
            // 
            this.cboStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStudent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboStudent.FormattingEnabled = true;
            this.cboStudent.Location = new System.Drawing.Point(24, 88);
            this.cboStudent.Name = "cboStudent";
            this.cboStudent.Size = new System.Drawing.Size(312, 25);
            this.cboStudent.TabIndex = 6;
            // 
            // lblLaboratory
            // 
            this.lblLaboratory.AutoSize = true;
            this.lblLaboratory.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblLaboratory.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblLaboratory.Location = new System.Drawing.Point(24, 130);
            this.lblLaboratory.Name = "lblLaboratory";
            this.lblLaboratory.Size = new System.Drawing.Size(80, 17);
            this.lblLaboratory.TabIndex = 7;
            this.lblLaboratory.Text = "Laboratory";
            // 
            // cboLaboratory
            // 
            this.cboLaboratory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLaboratory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboLaboratory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboLaboratory.FormattingEnabled = true;
            this.cboLaboratory.Location = new System.Drawing.Point(24, 150);
            this.cboLaboratory.Name = "cboLaboratory";
            this.cboLaboratory.Size = new System.Drawing.Size(150, 25);
            this.cboLaboratory.TabIndex = 8;
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblComputer.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblComputer.Location = new System.Drawing.Point(186, 130);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(80, 17);
            this.lblComputer.TabIndex = 9;
            this.lblComputer.Text = "Computer";
            // 
            // cboComputer
            // 
            this.cboComputer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboComputer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboComputer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboComputer.FormattingEnabled = true;
            this.cboComputer.Location = new System.Drawing.Point(186, 150);
            this.cboComputer.Name = "cboComputer";
            this.cboComputer.Size = new System.Drawing.Size(150, 25);
            this.cboComputer.TabIndex = 10;
            // 
            // lblReservationDate
            // 
            this.lblReservationDate.AutoSize = true;
            this.lblReservationDate.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblReservationDate.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblReservationDate.Location = new System.Drawing.Point(24, 192);
            this.lblReservationDate.Name = "lblReservationDate";
            this.lblReservationDate.Size = new System.Drawing.Size(110, 17);
            this.lblReservationDate.TabIndex = 11;
            this.lblReservationDate.Text = "Reservation Date";
            // 
            // dtpReservationDate
            // 
            this.dtpReservationDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpReservationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpReservationDate.Location = new System.Drawing.Point(24, 212);
            this.dtpReservationDate.Name = "dtpReservationDate";
            this.dtpReservationDate.Size = new System.Drawing.Size(150, 25);
            this.dtpReservationDate.TabIndex = 12;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblStatus.Location = new System.Drawing.Point(186, 192);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(80, 17);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Status";
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboStatus.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Pending",
            "Approved",
            "Completed",
            "Cancelled"});
            this.cboStatus.Location = new System.Drawing.Point(186, 212);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(150, 25);
            this.cboStatus.TabIndex = 14;
            // 
            // lblTimeFrom
            // 
            this.lblTimeFrom.AutoSize = true;
            this.lblTimeFrom.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTimeFrom.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblTimeFrom.Location = new System.Drawing.Point(24, 254);
            this.lblTimeFrom.Name = "lblTimeFrom";
            this.lblTimeFrom.Size = new System.Drawing.Size(80, 17);
            this.lblTimeFrom.TabIndex = 15;
            this.lblTimeFrom.Text = "Time From";
            // 
            // dtpTimeFrom
            // 
            this.dtpTimeFrom.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTimeFrom.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeFrom.Location = new System.Drawing.Point(24, 274);
            this.dtpTimeFrom.Name = "dtpTimeFrom";
            this.dtpTimeFrom.ShowUpDown = true;
            this.dtpTimeFrom.Size = new System.Drawing.Size(150, 25);
            this.dtpTimeFrom.TabIndex = 16;
            // 
            // lblTimeTo
            // 
            this.lblTimeTo.AutoSize = true;
            this.lblTimeTo.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblTimeTo.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblTimeTo.Location = new System.Drawing.Point(186, 254);
            this.lblTimeTo.Name = "lblTimeTo";
            this.lblTimeTo.Size = new System.Drawing.Size(80, 17);
            this.lblTimeTo.TabIndex = 17;
            this.lblTimeTo.Text = "Time To";
            // 
            // dtpTimeTo
            // 
            this.dtpTimeTo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dtpTimeTo.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeTo.Location = new System.Drawing.Point(186, 274);
            this.dtpTimeTo.Name = "dtpTimeTo";
            this.dtpTimeTo.ShowUpDown = true;
            this.dtpTimeTo.Size = new System.Drawing.Size(150, 25);
            this.dtpTimeTo.TabIndex = 18;
            // 
            // lblPurpose
            // 
            this.lblPurpose.AutoSize = true;
            this.lblPurpose.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblPurpose.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblPurpose.Location = new System.Drawing.Point(24, 316);
            this.lblPurpose.Name = "lblPurpose";
            this.lblPurpose.Size = new System.Drawing.Size(120, 17);
            this.lblPurpose.TabIndex = 19;
            this.lblPurpose.Text = "Purpose / Remarks";
            // 
            // txtPurpose
            // 
            this.txtPurpose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPurpose.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtPurpose.Location = new System.Drawing.Point(24, 336);
            this.txtPurpose.Multiline = true;
            this.txtPurpose.Name = "txtPurpose";
            this.txtPurpose.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPurpose.Size = new System.Drawing.Size(312, 120);
            this.txtPurpose.TabIndex = 20;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(37, 99, 235);
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(24, 476);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 40);
            this.btnSave.TabIndex = 21;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(254, 226, 226);
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(185, 28, 28);
            this.btnDelete.Location = new System.Drawing.Point(132, 476);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(96, 40);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.btnClear.Location = new System.Drawing.Point(240, 476);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 40);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // pnlForm
            // 
            this.pnlForm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.Controls.Add(this.btnClear);
            this.pnlForm.Controls.Add(this.btnDelete);
            this.pnlForm.Controls.Add(this.btnSave);
            this.pnlForm.Controls.Add(this.txtPurpose);
            this.pnlForm.Controls.Add(this.lblPurpose);
            this.pnlForm.Controls.Add(this.dtpTimeTo);
            this.pnlForm.Controls.Add(this.lblTimeTo);
            this.pnlForm.Controls.Add(this.dtpTimeFrom);
            this.pnlForm.Controls.Add(this.lblTimeFrom);
            this.pnlForm.Controls.Add(this.cboStatus);
            this.pnlForm.Controls.Add(this.lblStatus);
            this.pnlForm.Controls.Add(this.dtpReservationDate);
            this.pnlForm.Controls.Add(this.lblReservationDate);
            this.pnlForm.Controls.Add(this.cboComputer);
            this.pnlForm.Controls.Add(this.lblComputer);
            this.pnlForm.Controls.Add(this.cboLaboratory);
            this.pnlForm.Controls.Add(this.lblLaboratory);
            this.pnlForm.Controls.Add(this.cboStudent);
            this.pnlForm.Controls.Add(this.lblStudent);
            this.pnlForm.Controls.Add(this.pnlFormLine);
            this.pnlForm.Controls.Add(this.lblFormTitle);
            this.pnlForm.Location = new System.Drawing.Point(24, 94);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(360, 540);
            this.pnlForm.TabIndex = 24;
            // 
            // lblListTitle
            // 
            this.lblListTitle.AutoSize = true;
            this.lblListTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblListTitle.ForeColor = System.Drawing.Color.FromArgb(15, 23, 42);
            this.lblListTitle.Location = new System.Drawing.Point(24, 18);
            this.lblListTitle.Name = "lblListTitle";
            this.lblListTitle.Size = new System.Drawing.Size(150, 21);
            this.lblListTitle.TabIndex = 25;
            this.lblListTitle.Text = "Reservation List";
            // 
            // lblSearch
            // 
            this.lblSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSearch.ForeColor = System.Drawing.Color.FromArgb(51, 65, 85);
            this.lblSearch.Location = new System.Drawing.Point(344, 22);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(48, 17);
            this.lblSearch.TabIndex = 26;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(396, 16);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(248, 25);
            this.txtSearch.TabIndex = 27;
            // 
            // pnlListLine
            // 
            this.pnlListLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlListLine.BackColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.pnlListLine.Location = new System.Drawing.Point(0, 54);
            this.pnlListLine.Name = "pnlListLine";
            this.pnlListLine.Size = new System.Drawing.Size(668, 1);
            this.pnlListLine.TabIndex = 28;
            // 
            // dgvReservations
            // 
            this.dgvReservations.AllowUserToAddRows = false;
            this.dgvReservations.AllowUserToDeleteRows = false;
            this.dgvReservations.AllowUserToResizeRows = false;
            this.dgvReservations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReservations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReservations.BackgroundColor = System.Drawing.Color.White;
            this.dgvReservations.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReservations.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReservations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReservations.ColumnHeadersHeight = 38;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReservations.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReservations.EnableHeadersVisualStyles = false;
            this.dgvReservations.GridColor = System.Drawing.Color.FromArgb(226, 232, 240);
            this.dgvReservations.Location = new System.Drawing.Point(24, 70);
            this.dgvReservations.MultiSelect = false;
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.RowHeadersVisible = false;
            this.dgvReservations.RowTemplate.Height = 34;
            this.dgvReservations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservations.Size = new System.Drawing.Size(620, 420);
            this.dgvReservations.TabIndex = 29;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblRecordCount.ForeColor = System.Drawing.Color.FromArgb(100, 116, 139);
            this.lblRecordCount.Location = new System.Drawing.Point(24, 506);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(98, 17);
            this.lblRecordCount.TabIndex = 30;
            this.lblRecordCount.Text = "Total records: 0";
            // 
            // pnlList
            // 
            this.pnlList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlList.BackColor = System.Drawing.Color.White;
            this.pnlList.Controls.Add(this.lblRecordCount);
            this.pnlList.Controls.Add(this.dgvReservations);
            this.pnlList.Controls.Add(this.pnlListLine);
            this.pnlList.Controls.Add(this.txtSearch);
            this.pnlList.Controls.Add(this.lblSearch);
            this.pnlList.Controls.Add(this.lblListTitle);
            this.pnlList.Location = new System.Drawing.Point(408, 94);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(668, 540);
            this.pnlList.TabIndex = 31;
            // 
            // frmReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(241, 245, 249);
            this.ClientSize = new System.Drawing.Size(1100, 660);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlHeader);
            this.MinimumSize = new System.Drawing.Size(1000, 640);
            this.Name = "frmReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservations";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlList.ResumeLayout(false);
            this.pnlList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Panel pnlFormLine;
        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.ComboBox cboStudent;
        private System.Windows.Forms.Label lblLaboratory;
        private System.Windows.Forms.ComboBox cboLaboratory;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.ComboBox cboComputer;
        private System.Windows.Forms.Label lblReservationDate;
        private System.Windows.Forms.DateTimePicker dtpReservationDate;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label lblTimeFrom;
        private System.Windows.Forms.DateTimePicker dtpTimeFrom;
        private System.Windows.Forms.Label lblTimeTo;
        private System.Windows.Forms.DateTimePicker dtpTimeTo;
        private System.Windows.Forms.Label lblPurpose;
        private System.Windows.Forms.TextBox txtPurpose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Panel pnlList;
        private System.Windows.Forms.Label lblListTitle;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel pnlListLine;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Label lblRecordCount;
    }
}