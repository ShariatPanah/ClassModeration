namespace ClassModeration
{
    partial class frmAddNewClass
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
            this.grbAddNewClass = new System.Windows.Forms.GroupBox();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.txtTheoricUnit = new System.Windows.Forms.TextBox();
            this.txtWorkableUnit = new System.Windows.Forms.TextBox();
            this.cmbLessonType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLessonCode = new System.Windows.Forms.TextBox();
            this.txtLessonName = new System.Windows.Forms.TextBox();
            this.txtLecture = new System.Windows.Forms.TextBox();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnAddClassDetails = new System.Windows.Forms.Button();
            this.btnDeleteLesson = new System.Windows.Forms.Button();
            this.dgvLessons = new System.Windows.Forms.DataGridView();
            this.bookCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workableUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theoricUnitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lessonTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teacherNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lectureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classModerationDataSet = new ClassModeration.ClassModerationDataSet();
            this.bookTableAdapter = new ClassModeration.ClassModerationDataSetTableAdapters.BookTableAdapter();
            this.grbAddNewClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classModerationDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // grbAddNewClass
            // 
            this.grbAddNewClass.Controls.Add(this.txtSubjectName);
            this.grbAddNewClass.Controls.Add(this.txtTheoricUnit);
            this.grbAddNewClass.Controls.Add(this.txtWorkableUnit);
            this.grbAddNewClass.Controls.Add(this.cmbLessonType);
            this.grbAddNewClass.Controls.Add(this.label12);
            this.grbAddNewClass.Controls.Add(this.label11);
            this.grbAddNewClass.Controls.Add(this.label10);
            this.grbAddNewClass.Controls.Add(this.label9);
            this.grbAddNewClass.Controls.Add(this.label8);
            this.grbAddNewClass.Controls.Add(this.label7);
            this.grbAddNewClass.Controls.Add(this.label6);
            this.grbAddNewClass.Controls.Add(this.label5);
            this.grbAddNewClass.Controls.Add(this.txtLessonCode);
            this.grbAddNewClass.Controls.Add(this.txtLessonName);
            this.grbAddNewClass.Controls.Add(this.txtLecture);
            this.grbAddNewClass.Controls.Add(this.txtTeacherName);
            this.grbAddNewClass.Location = new System.Drawing.Point(12, 8);
            this.grbAddNewClass.Name = "grbAddNewClass";
            this.grbAddNewClass.Size = new System.Drawing.Size(845, 111);
            this.grbAddNewClass.TabIndex = 0;
            this.grbAddNewClass.TabStop = false;
            this.grbAddNewClass.Text = "افزودن درس جدید";
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(20, 24);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(138, 21);
            this.txtSubjectName.TabIndex = 3;
            // 
            // txtTheoricUnit
            // 
            this.txtTheoricUnit.Location = new System.Drawing.Point(20, 52);
            this.txtTheoricUnit.Name = "txtTheoricUnit";
            this.txtTheoricUnit.Size = new System.Drawing.Size(138, 21);
            this.txtTheoricUnit.TabIndex = 6;
            this.txtTheoricUnit.Text = "0.00";
            // 
            // txtWorkableUnit
            // 
            this.txtWorkableUnit.Location = new System.Drawing.Point(327, 52);
            this.txtWorkableUnit.Name = "txtWorkableUnit";
            this.txtWorkableUnit.Size = new System.Drawing.Size(138, 21);
            this.txtWorkableUnit.TabIndex = 5;
            this.txtWorkableUnit.Text = "0.00";
            // 
            // cmbLessonType
            // 
            this.cmbLessonType.FormattingEnabled = true;
            this.cmbLessonType.Items.AddRange(new object[] {
            "عمومی",
            "پایه",
            "اصلی",
            "تخصصی"});
            this.cmbLessonType.Location = new System.Drawing.Point(621, 52);
            this.cmbLessonType.Name = "cmbLessonType";
            this.cmbLessonType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbLessonType.Size = new System.Drawing.Size(138, 21);
            this.cmbLessonType.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(476, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "تعداد جلسات:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(770, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "نام استاد:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(169, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "رشته مربوطه:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(169, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "تعداد واحد تئوری:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(476, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "تعداد واحد عملی:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(770, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "نوع درس:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(476, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "نام درس:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(770, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "کد درس:";
            // 
            // txtLessonCode
            // 
            this.txtLessonCode.Location = new System.Drawing.Point(621, 24);
            this.txtLessonCode.Name = "txtLessonCode";
            this.txtLessonCode.Size = new System.Drawing.Size(138, 21);
            this.txtLessonCode.TabIndex = 1;
            // 
            // txtLessonName
            // 
            this.txtLessonName.Location = new System.Drawing.Point(327, 24);
            this.txtLessonName.Name = "txtLessonName";
            this.txtLessonName.Size = new System.Drawing.Size(138, 21);
            this.txtLessonName.TabIndex = 2;
            // 
            // txtLecture
            // 
            this.txtLecture.Location = new System.Drawing.Point(327, 79);
            this.txtLecture.Name = "txtLecture";
            this.txtLecture.Size = new System.Drawing.Size(138, 21);
            this.txtLecture.TabIndex = 8;
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(621, 79);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(138, 21);
            this.txtTeacherName.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(32, 125);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "انصراف";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(699, 125);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(127, 23);
            this.btnContinue.TabIndex = 9;
            this.btnContinue.Text = "افزودن درس";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnAddClassDetails
            // 
            this.btnAddClassDetails.Enabled = false;
            this.btnAddClassDetails.Location = new System.Drawing.Point(470, 125);
            this.btnAddClassDetails.Name = "btnAddClassDetails";
            this.btnAddClassDetails.Size = new System.Drawing.Size(127, 23);
            this.btnAddClassDetails.TabIndex = 10;
            this.btnAddClassDetails.Text = "افزودن برنامه کلاسی";
            this.btnAddClassDetails.UseVisualStyleBackColor = true;
            this.btnAddClassDetails.Click += new System.EventHandler(this.btnAddClassDetails_Click);
            // 
            // btnDeleteLesson
            // 
            this.btnDeleteLesson.Enabled = false;
            this.btnDeleteLesson.Location = new System.Drawing.Point(243, 125);
            this.btnDeleteLesson.Name = "btnDeleteLesson";
            this.btnDeleteLesson.Size = new System.Drawing.Size(127, 23);
            this.btnDeleteLesson.TabIndex = 11;
            this.btnDeleteLesson.Text = "حذف درس";
            this.btnDeleteLesson.UseVisualStyleBackColor = true;
            this.btnDeleteLesson.Click += new System.EventHandler(this.btnDeleteLesson_Click);
            // 
            // dgvLessons
            // 
            this.dgvLessons.AutoGenerateColumns = false;
            this.dgvLessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLessons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookCodeDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.workableUnitDataGridViewTextBoxColumn,
            this.theoricUnitDataGridViewTextBoxColumn,
            this.subjectDataGridViewTextBoxColumn,
            this.lessonTypeDataGridViewTextBoxColumn,
            this.teacherNameDataGridViewTextBoxColumn,
            this.lectureDataGridViewTextBoxColumn});
            this.dgvLessons.DataSource = this.bookBindingSource;
            this.dgvLessons.Location = new System.Drawing.Point(12, 154);
            this.dgvLessons.Name = "dgvLessons";
            this.dgvLessons.ReadOnly = true;
            this.dgvLessons.Size = new System.Drawing.Size(845, 349);
            this.dgvLessons.TabIndex = 14;
            this.dgvLessons.SelectionChanged += new System.EventHandler(this.dgvLessons_SelectionChanged);
            // 
            // bookCodeDataGridViewTextBoxColumn
            // 
            this.bookCodeDataGridViewTextBoxColumn.DataPropertyName = "BookCode";
            this.bookCodeDataGridViewTextBoxColumn.HeaderText = "کد درس";
            this.bookCodeDataGridViewTextBoxColumn.Name = "bookCodeDataGridViewTextBoxColumn";
            this.bookCodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "نام درس";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // workableUnitDataGridViewTextBoxColumn
            // 
            this.workableUnitDataGridViewTextBoxColumn.DataPropertyName = "WorkableUnit";
            this.workableUnitDataGridViewTextBoxColumn.HeaderText = "واحد عملی";
            this.workableUnitDataGridViewTextBoxColumn.Name = "workableUnitDataGridViewTextBoxColumn";
            this.workableUnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // theoricUnitDataGridViewTextBoxColumn
            // 
            this.theoricUnitDataGridViewTextBoxColumn.DataPropertyName = "TheoricUnit";
            this.theoricUnitDataGridViewTextBoxColumn.HeaderText = "واحد تئوری";
            this.theoricUnitDataGridViewTextBoxColumn.Name = "theoricUnitDataGridViewTextBoxColumn";
            this.theoricUnitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subjectDataGridViewTextBoxColumn
            // 
            this.subjectDataGridViewTextBoxColumn.DataPropertyName = "Subject";
            this.subjectDataGridViewTextBoxColumn.HeaderText = "رشته";
            this.subjectDataGridViewTextBoxColumn.Name = "subjectDataGridViewTextBoxColumn";
            this.subjectDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lessonTypeDataGridViewTextBoxColumn
            // 
            this.lessonTypeDataGridViewTextBoxColumn.DataPropertyName = "LessonType";
            this.lessonTypeDataGridViewTextBoxColumn.HeaderText = "نوع درس";
            this.lessonTypeDataGridViewTextBoxColumn.Name = "lessonTypeDataGridViewTextBoxColumn";
            this.lessonTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // teacherNameDataGridViewTextBoxColumn
            // 
            this.teacherNameDataGridViewTextBoxColumn.DataPropertyName = "TeacherName";
            this.teacherNameDataGridViewTextBoxColumn.HeaderText = "نام استاد";
            this.teacherNameDataGridViewTextBoxColumn.Name = "teacherNameDataGridViewTextBoxColumn";
            this.teacherNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lectureDataGridViewTextBoxColumn
            // 
            this.lectureDataGridViewTextBoxColumn.DataPropertyName = "Lecture";
            this.lectureDataGridViewTextBoxColumn.HeaderText = "تعداد جلسات";
            this.lectureDataGridViewTextBoxColumn.Name = "lectureDataGridViewTextBoxColumn";
            this.lectureDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "Book";
            this.bookBindingSource.DataSource = this.classModerationDataSet;
            // 
            // classModerationDataSet
            // 
            this.classModerationDataSet.DataSetName = "ClassModerationDataSet";
            this.classModerationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddNewClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 515);
            this.Controls.Add(this.dgvLessons);
            this.Controls.Add(this.btnDeleteLesson);
            this.Controls.Add(this.btnAddClassDetails);
            this.Controls.Add(this.grbAddNewClass);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnContinue);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddNewClass";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت دروس";
            this.Load += new System.EventHandler(this.frmAddNewClass_Load);
            this.grbAddNewClass.ResumeLayout(false);
            this.grbAddNewClass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classModerationDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAddNewClass;
        private System.Windows.Forms.TextBox txtLessonName;
        private System.Windows.Forms.TextBox txtLecture;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.TextBox txtLessonCode;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.TextBox txtTheoricUnit;
        private System.Windows.Forms.TextBox txtWorkableUnit;
        private System.Windows.Forms.ComboBox cmbLessonType;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAddClassDetails;
        private System.Windows.Forms.Button btnDeleteLesson;
        private System.Windows.Forms.DataGridView dgvLessons;
        private ClassModerationDataSet classModerationDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private ClassModerationDataSetTableAdapters.BookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workableUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn theoricUnitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lessonTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn teacherNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lectureDataGridViewTextBoxColumn;
    }
}