namespace ClassModeration
{
    partial class frmAddNewClassDetails
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbTime = new System.Windows.Forms.MaskedTextBox();
            this.txtClassNo = new System.Windows.Forms.TextBox();
            this.mtbDate = new System.Windows.Forms.MaskedTextBox();
            this.cmbDay = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.classModerationDataSet = new ClassModeration.ClassModerationDataSet();
            this.classModerationDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classModerationDataSet1 = new ClassModeration.ClassModerationDataSet1();
            this.classDetailsTableAdapter = new ClassModeration.ClassModerationDataSet1TableAdapters.ClassDetailsTableAdapter();
            this.classDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookTableAdapter = new ClassModeration.ClassModerationDataSetTableAdapters.BookTableAdapter();
            this.classDetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classModerationDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classModerationDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classModerationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDetailsBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbTime);
            this.groupBox1.Controls.Add(this.txtClassNo);
            this.groupBox1.Controls.Add(this.mtbDate);
            this.groupBox1.Controls.Add(this.cmbDay);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جزییات برگزاری کلاس";
            // 
            // mtbTime
            // 
            this.mtbTime.Location = new System.Drawing.Point(275, 53);
            this.mtbTime.Mask = "00:00-00:00";
            this.mtbTime.Name = "mtbTime";
            this.mtbTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbTime.Size = new System.Drawing.Size(137, 21);
            this.mtbTime.TabIndex = 2;
            this.toolTip1.SetToolTip(this.mtbTime, "برای مثال:\r\n08:30-10:30");
            // 
            // txtClassNo
            // 
            this.txtClassNo.Location = new System.Drawing.Point(26, 53);
            this.txtClassNo.Name = "txtClassNo";
            this.txtClassNo.Size = new System.Drawing.Size(137, 21);
            this.txtClassNo.TabIndex = 3;
            // 
            // mtbDate
            // 
            this.mtbDate.Location = new System.Drawing.Point(26, 26);
            this.mtbDate.Mask = "00/00/0000";
            this.mtbDate.Name = "mtbDate";
            this.mtbDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbDate.Size = new System.Drawing.Size(137, 21);
            this.mtbDate.TabIndex = 1;
            this.toolTip1.SetToolTip(this.mtbDate, "مثال:\r\n19/12/1393");
            // 
            // cmbDay
            // 
            this.cmbDay.FormattingEnabled = true;
            this.cmbDay.Items.AddRange(new object[] {
            "شنبه",
            "یک شنبه",
            "دو شنبه",
            "سه شنبه",
            "چهار شنبه",
            "پنج شنبه",
            "جمعه"});
            this.cmbDay.Location = new System.Drawing.Point(275, 26);
            this.cmbDay.Name = "cmbDay";
            this.cmbDay.Size = new System.Drawing.Size(137, 21);
            this.cmbDay.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "شماره کلاس:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ساعت برگزاری:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "تاریخ:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(428, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام روز:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(38, 91);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 23);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "بازگشت صفحه قبل";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(414, 91);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(103, 23);
            this.btnAddToList.TabIndex = 4;
            this.btnAddToList.Text = "افزودن به لیست";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Click += new System.EventHandler(this.btnAddToList_Click);
            // 
            // dgvDetails
            // 
            this.dgvDetails.AutoGenerateColumns = false;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.bookIDDataGridViewTextBoxColumn,
            this.dayNameDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.dueTimeDataGridViewTextBoxColumn,
            this.classNoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvDetails.DataSource = this.classDetailsBindingSource2;
            this.dgvDetails.Location = new System.Drawing.Point(12, 120);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.Size = new System.Drawing.Size(523, 263);
            this.dgvDetails.TabIndex = 6;
            // 
            // classModerationDataSet
            // 
            this.classModerationDataSet.DataSetName = "ClassModerationDataSet";
            this.classModerationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classModerationDataSetBindingSource
            // 
            this.classModerationDataSetBindingSource.DataSource = this.classModerationDataSet;
            this.classModerationDataSetBindingSource.Position = 0;
            // 
            // classDetailsBindingSource
            // 
            this.classDetailsBindingSource.DataMember = "ClassDetails";
            this.classDetailsBindingSource.DataSource = this.classModerationDataSet1;
            // 
            // classModerationDataSet1
            // 
            this.classModerationDataSet1.DataSetName = "ClassModerationDataSet1";
            this.classModerationDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classDetailsTableAdapter
            // 
            this.classDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // classDetailsBindingSource1
            // 
            this.classDetailsBindingSource1.DataMember = "ClassDetails";
            this.classDetailsBindingSource1.DataSource = this.classModerationDataSet1;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.classModerationDataSetBindingSource;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // classDetailsBindingSource2
            // 
            this.classDetailsBindingSource2.DataMember = "ClassDetails";
            this.classDetailsBindingSource2.DataSource = this.classModerationDataSet1;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "Book_ID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "Book_ID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // dayNameDataGridViewTextBoxColumn
            // 
            this.dayNameDataGridViewTextBoxColumn.DataPropertyName = "DayName";
            this.dayNameDataGridViewTextBoxColumn.HeaderText = "روز";
            this.dayNameDataGridViewTextBoxColumn.Name = "dayNameDataGridViewTextBoxColumn";
            this.dayNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.dayNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "تاریخ برگزاری";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            this.dueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dueTimeDataGridViewTextBoxColumn
            // 
            this.dueTimeDataGridViewTextBoxColumn.DataPropertyName = "DueTime";
            this.dueTimeDataGridViewTextBoxColumn.HeaderText = "ساعت تشکیل";
            this.dueTimeDataGridViewTextBoxColumn.Name = "dueTimeDataGridViewTextBoxColumn";
            this.dueTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classNoDataGridViewTextBoxColumn
            // 
            this.classNoDataGridViewTextBoxColumn.DataPropertyName = "ClassNo";
            this.classNoDataGridViewTextBoxColumn.HeaderText = "شماره کلاس";
            this.classNoDataGridViewTextBoxColumn.Name = "classNoDataGridViewTextBoxColumn";
            this.classNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.classNoDataGridViewTextBoxColumn.Width = 90;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "وضعیت برگزاری";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Width = 110;
            // 
            // frmAddNewClassDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 395);
            this.Controls.Add(this.btnAddToList);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddNewClassDetails";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "افزودن جزییات برگزاری کلاس";
            this.Load += new System.EventHandler(this.frmAddNewClassDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classModerationDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classModerationDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classModerationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDetailsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDay;
        private System.Windows.Forms.MaskedTextBox mtbDate;
        private System.Windows.Forms.TextBox txtClassNo;
        private System.Windows.Forms.MaskedTextBox mtbTime;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnAddToList;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.BindingSource classModerationDataSetBindingSource;
        private ClassModerationDataSet classModerationDataSet;
        private ClassModerationDataSet1 classModerationDataSet1;
        private System.Windows.Forms.BindingSource classDetailsBindingSource;
        private ClassModerationDataSet1TableAdapters.ClassDetailsTableAdapter classDetailsTableAdapter;
        private System.Windows.Forms.BindingSource classDetailsBindingSource1;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private ClassModerationDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource classDetailsBindingSource2;
    }
}