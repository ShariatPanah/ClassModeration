using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_Moderation.DAL;
using Class_Moderation.BLL;

namespace ClassModeration
{
    public partial class frmEditMyLesson : Form
    {
        int _id;
        public frmEditMyLesson(int inId)
        {
            InitializeComponent();
            _id = inId;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditMyLesson_Load(object sender, EventArgs e)
        {
            Lesson obj = new Lesson();
            obj = ClassModerationDAL.RetrieveLesson(_id);
            txtLessonCode.Text = obj.BookCode;
            txtLessonName.Text = obj.BookName;
            txtSubjectName.Text = obj.SubjectName;
            txtTeacherName.Text = obj.TeacherName;
            txtLecture.Text = obj.Lecture;
            txtTheoricUnit.Text = obj.TheoricUnit;
            txtWorkableUnit.Text = obj.WorkableUnit;
            cmbLessonType.Text = obj.LessonType;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Lesson NewLesson = new Lesson();

            if (!String.IsNullOrEmpty(txtLessonCode.Text))
            {
                NewLesson.BookCode = txtLessonCode.Text;
            }
            else
                MessageBox.Show("کد درس را وارد کنید");

            if (!String.IsNullOrEmpty(txtLessonName.Text))
            {
                NewLesson.BookName = txtLessonName.Text;
            }
            else
                MessageBox.Show("نام درس را وارد کنید");

            if (!String.IsNullOrEmpty(txtSubjectName.Text))
            {
                NewLesson.SubjectName = txtSubjectName.Text;
            }
            else
                MessageBox.Show("رشته را وارد کنید");

            if (!String.IsNullOrEmpty(txtTeacherName.Text))
            {
                NewLesson.TeacherName = txtTeacherName.Text;
            }
            else
                MessageBox.Show("نام استاد مربوطه را وارد کنید");

            if (!String.IsNullOrEmpty(txtLecture.Text))
            {
                NewLesson.Lecture = txtLecture.Text;
            }
            else
                MessageBox.Show("تعداد جلسات را مشخص کنید");

            if (!(cmbLessonType.SelectedItem == null))
            {
                NewLesson.LessonType = cmbLessonType.SelectedItem.ToString();
            }
            else
                MessageBox.Show("نوع درس را انتخاب کنید");

            NewLesson.TheoricUnit = txtTheoricUnit.Text;
            NewLesson.WorkableUnit = txtWorkableUnit.Text;

            ClassModerationDAL.UpdateLesson(_id, NewLesson);

            MessageBox.Show("تغییرات با موفقیت ثبت گردید");
            this.Close();
        }

    }
}
