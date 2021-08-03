namespace ClassModeration
{
    partial class frmEditMyLesson
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
            this.grbAddNewClass = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtLessonName = new System.Windows.Forms.TextBox();
            this.cmbLessonType = new System.Windows.Forms.ComboBox();
            this.txtTheoricUnit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtLessonCode = new System.Windows.Forms.TextBox();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.txtWorkableUnit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLecture = new System.Windows.Forms.TextBox();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grbAddNewClass.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAddNewClass
            // 
            this.grbAddNewClass.Controls.Add(this.label12);
            this.grbAddNewClass.Controls.Add(this.txtLessonName);
            this.grbAddNewClass.Controls.Add(this.cmbLessonType);
            this.grbAddNewClass.Controls.Add(this.txtTheoricUnit);
            this.grbAddNewClass.Controls.Add(this.label8);
            this.grbAddNewClass.Controls.Add(this.label11);
            this.grbAddNewClass.Controls.Add(this.label9);
            this.grbAddNewClass.Controls.Add(this.label10);
            this.grbAddNewClass.Controls.Add(this.txtLessonCode);
            this.grbAddNewClass.Controls.Add(this.txtSubjectName);
            this.grbAddNewClass.Controls.Add(this.txtWorkableUnit);
            this.grbAddNewClass.Controls.Add(this.label7);
            this.grbAddNewClass.Controls.Add(this.label5);
            this.grbAddNewClass.Controls.Add(this.txtLecture);
            this.grbAddNewClass.Controls.Add(this.txtTeacherName);
            this.grbAddNewClass.Controls.Add(this.label6);
            this.grbAddNewClass.Location = new System.Drawing.Point(12, 2);
            this.grbAddNewClass.Name = "grbAddNewClass";
            this.grbAddNewClass.Size = new System.Drawing.Size(551, 178);
            this.grbAddNewClass.TabIndex = 12;
            this.grbAddNewClass.TabStop = false;
            this.grbAddNewClass.Text = "افزودن درس جدید";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(169, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "تعداد جلسات:";
            // 
            // txtLessonName
            // 
            this.txtLessonName.Location = new System.Drawing.Point(20, 29);
            this.txtLessonName.Name = "txtLessonName";
            this.txtLessonName.Size = new System.Drawing.Size(138, 21);
            this.txtLessonName.TabIndex = 1;
            // 
            // cmbLessonType
            // 
            this.cmbLessonType.FormattingEnabled = true;
            this.cmbLessonType.Items.AddRange(new object[] {
            "عمومی",
            "پایه",
            "اصلی",
            "تخصصی"});
            this.cmbLessonType.Location = new System.Drawing.Point(20, 65);
            this.cmbLessonType.Name = "cmbLessonType";
            this.cmbLessonType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbLessonType.Size = new System.Drawing.Size(138, 21);
            this.cmbLessonType.TabIndex = 3;
            // 
            // txtTheoricUnit
            // 
            this.txtTheoricUnit.Location = new System.Drawing.Point(20, 101);
            this.txtTheoricUnit.Name = "txtTheoricUnit";
            this.txtTheoricUnit.Size = new System.Drawing.Size(138, 21);
            this.txtTheoricUnit.TabIndex = 5;
            this.txtTheoricUnit.Text = "0.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(446, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 13);
            this.label8.TabIndex = 45;
            this.label8.Text = "تعداد واحد عملی:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(446, 140);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 48;
            this.label11.Text = "نام استاد:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(169, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 46;
            this.label9.Text = "تعداد واحد تئوری:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(446, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 13);
            this.label10.TabIndex = 47;
            this.label10.Text = "رشته مربوطه:";
            // 
            // txtLessonCode
            // 
            this.txtLessonCode.Location = new System.Drawing.Point(297, 29);
            this.txtLessonCode.Name = "txtLessonCode";
            this.txtLessonCode.Size = new System.Drawing.Size(138, 21);
            this.txtLessonCode.TabIndex = 0;
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(297, 65);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(138, 21);
            this.txtSubjectName.TabIndex = 2;
            // 
            // txtWorkableUnit
            // 
            this.txtWorkableUnit.Location = new System.Drawing.Point(297, 101);
            this.txtWorkableUnit.Name = "txtWorkableUnit";
            this.txtWorkableUnit.Size = new System.Drawing.Size(138, 21);
            this.txtWorkableUnit.TabIndex = 4;
            this.txtWorkableUnit.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "نوع درس:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 42;
            this.label5.Text = "کد درس:";
            // 
            // txtLecture
            // 
            this.txtLecture.Location = new System.Drawing.Point(20, 137);
            this.txtLecture.Name = "txtLecture";
            this.txtLecture.Size = new System.Drawing.Size(138, 21);
            this.txtLecture.TabIndex = 7;
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.Location = new System.Drawing.Point(297, 137);
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(138, 21);
            this.txtTeacherName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 43;
            this.label6.Text = "نام درس:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(443, 192);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(102, 42);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "اِعمال تغییرات";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(32, 192);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 42);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "خروج";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmEditMyLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 246);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.grbAddNewClass);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEditMyLesson";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویرایش اطلاعات درس";
            this.Load += new System.EventHandler(this.frmEditMyLesson_Load);
            this.grbAddNewClass.ResumeLayout(false);
            this.grbAddNewClass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAddNewClass;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtLessonName;
        private System.Windows.Forms.ComboBox cmbLessonType;
        private System.Windows.Forms.TextBox txtTheoricUnit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtLessonCode;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.TextBox txtWorkableUnit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLecture;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClose;

    }
}