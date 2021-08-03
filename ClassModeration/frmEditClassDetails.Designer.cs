namespace ClassModeration
{
    partial class frmEditClassDetails
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
            this.classDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classModerationDataSet1 = new ClassModeration.ClassModerationDataSet1();
            this.classModerationDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classDetailsTableAdapter = new ClassModeration.ClassModerationDataSet1TableAdapters.ClassDetailsTableAdapter();
            this.btnEditRow = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDeleteRow = new System.Windows.Forms.Button();
            this.dgvChangeForm = new System.Windows.Forms.DataGridView();
            this.classDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.classDetailsBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.classDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classModerationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classModerationDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangeForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDetailsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDetailsBindingSource2)).BeginInit();
            this.SuspendLayout();
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
            // classModerationDataSet1BindingSource
            // 
            this.classModerationDataSet1BindingSource.DataSource = this.classModerationDataSet1;
            this.classModerationDataSet1BindingSource.Position = 0;
            // 
            // classDetailsTableAdapter
            // 
            this.classDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // btnEditRow
            // 
            this.btnEditRow.Enabled = false;
            this.btnEditRow.Location = new System.Drawing.Point(381, 341);
            this.btnEditRow.Name = "btnEditRow";
            this.btnEditRow.Size = new System.Drawing.Size(102, 42);
            this.btnEditRow.TabIndex = 0;
            this.btnEditRow.Text = "ویرایش سطر";
            this.btnEditRow.UseVisualStyleBackColor = true;
            this.btnEditRow.Click += new System.EventHandler(this.btnEditRow_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(12, 341);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 42);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDeleteRow
            // 
            this.btnDeleteRow.Enabled = false;
            this.btnDeleteRow.Location = new System.Drawing.Point(195, 341);
            this.btnDeleteRow.Name = "btnDeleteRow";
            this.btnDeleteRow.Size = new System.Drawing.Size(102, 42);
            this.btnDeleteRow.TabIndex = 1;
            this.btnDeleteRow.Text = "حذف سطر";
            this.btnDeleteRow.UseVisualStyleBackColor = true;
            this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
            // 
            // dgvChangeForm
            // 
            this.dgvChangeForm.AutoGenerateColumns = false;
            this.dgvChangeForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChangeForm.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.bookIDDataGridViewTextBoxColumn,
            this.dayNameDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.dueTimeDataGridViewTextBoxColumn,
            this.classNoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvChangeForm.DataSource = this.classDetailsBindingSource2;
            this.dgvChangeForm.Location = new System.Drawing.Point(12, 12);
            this.dgvChangeForm.Name = "dgvChangeForm";
            this.dgvChangeForm.ReadOnly = true;
            this.dgvChangeForm.Size = new System.Drawing.Size(523, 323);
            this.dgvChangeForm.TabIndex = 2;
            this.dgvChangeForm.SelectionChanged += new System.EventHandler(this.dgvChangeForm_SelectionChanged);
            // 
            // classDetailsBindingSource1
            // 
            this.classDetailsBindingSource1.DataMember = "ClassDetails";
            this.classDetailsBindingSource1.DataSource = this.classModerationDataSet1;
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
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "تاریخ";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            this.dueDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dueTimeDataGridViewTextBoxColumn
            // 
            this.dueTimeDataGridViewTextBoxColumn.DataPropertyName = "DueTime";
            this.dueTimeDataGridViewTextBoxColumn.HeaderText = "ساعت برگزاری";
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
            // frmEditClassDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 395);
            this.Controls.Add(this.btnDeleteRow);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEditRow);
            this.Controls.Add(this.dgvChangeForm);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEditClassDetails";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویرایش برنامه کلاسی";
            this.Load += new System.EventHandler(this.frmEditClassDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classModerationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classModerationDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChangeForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDetailsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDetailsBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource classModerationDataSet1BindingSource;
        private ClassModerationDataSet1 classModerationDataSet1;
        private System.Windows.Forms.BindingSource classDetailsBindingSource;
        private ClassModerationDataSet1TableAdapters.ClassDetailsTableAdapter classDetailsTableAdapter;
        private System.Windows.Forms.Button btnEditRow;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDeleteRow;
        private System.Windows.Forms.DataGridView dgvChangeForm;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource classDetailsBindingSource2;
        private System.Windows.Forms.BindingSource classDetailsBindingSource1;
    }
}