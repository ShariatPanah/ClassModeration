namespace ClassModeration
{
    partial class frmShowDetails
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
            this.dgvShowDetails = new System.Windows.Forms.DataGridView();
            this.classDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classModerationDataSet1 = new ClassModeration.ClassModerationDataSet1();
            this.classDetailsTableAdapter = new ClassModeration.ClassModerationDataSet1TableAdapters.ClassDetailsTableAdapter();
            this.btnClose = new System.Windows.Forms.Button();
            this.classDetailsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classModerationDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDetailsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShowDetails
            // 
            this.dgvShowDetails.AutoGenerateColumns = false;
            this.dgvShowDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.bookIDDataGridViewTextBoxColumn,
            this.dayNameDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.dueTimeDataGridViewTextBoxColumn,
            this.classNoDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dgvShowDetails.DataSource = this.classDetailsBindingSource1;
            this.dgvShowDetails.Location = new System.Drawing.Point(12, 12);
            this.dgvShowDetails.Name = "dgvShowDetails";
            this.dgvShowDetails.ReadOnly = true;
            this.dgvShowDetails.Size = new System.Drawing.Size(523, 296);
            this.dgvShowDetails.TabIndex = 3;
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
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(31, 317);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 41);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // classDetailsBindingSource1
            // 
            this.classDetailsBindingSource1.DataMember = "ClassDetails";
            this.classDetailsBindingSource1.DataSource = this.classModerationDataSet1;
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
            // frmShowDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 370);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvShowDetails);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmShowDetails";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "برنامه کلاسی";
            this.Load += new System.EventHandler(this.frmShowDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classModerationDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classDetailsBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvShowDetails;
        private ClassModerationDataSet1 classModerationDataSet1;
        private System.Windows.Forms.BindingSource classDetailsBindingSource;
        private ClassModerationDataSet1TableAdapters.ClassDetailsTableAdapter classDetailsTableAdapter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dayNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn classNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource classDetailsBindingSource1;
    }
}