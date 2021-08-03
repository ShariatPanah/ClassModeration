using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Class_Moderation.BLL;
using Class_Moderation.DAL;

namespace ClassModeration
{
    public partial class frmAddNewClass : Form
    {
        public frmAddNewClass()
        {
            InitializeComponent();
        }

        public void FillGrid()
        {
            DataTable Table = ClassModerationDAL.GetEntries();
            dgvLessons.DataSource = null;
            dgvLessons.DataSource = Table;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnContinue_Click(object sender, EventArgs e)
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

            NewLesson.TheoricUnit=txtTheoricUnit.Text;
            NewLesson.WorkableUnit=txtWorkableUnit.Text;

            ClassModerationDAL.InsertLesson(NewLesson);

            txtLessonCode.Text = "";
            txtLessonName.Text = "";
            txtSubjectName.Text = "";
            txtTeacherName.Text = "";
            txtTheoricUnit.Text = "0.00";
            txtWorkableUnit.Text = "0.00";
            txtLecture.Text = "";
            cmbLessonType.SelectedItem = null;

            FillGrid();
        }

        private void frmAddNewClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classModerationDataSet.Book' table. You can move, or remove it, as needed.
            //this.bookTableAdapter.Fill(this.classModerationDataSet.Book);
            FillGrid();
            //if (dgvLessons.SelectedColumns.Count>0)
            //{
            //    btnDeleteLesson.Enabled = true;
            //    btnAddClassDetails.Enabled = true;
            //}
            //else
            //{
            //    btnDeleteLesson.Enabled = false;
            //    btnAddClassDetails.Enabled = false;
            //}
        }

        private void btnDeleteLesson_Click(object sender, EventArgs e)
        {
            DataRowView oDataRowView = (DataRowView)dgvLessons.SelectedRows[0].DataBoundItem;
            int Row_id = (int)oDataRowView.Row["ID"];
            ClassModerationDAL.DeleteLesson(Row_id);
            FillGrid();
        }

        private void btnAddClassDetails_Click(object sender, EventArgs e)
        {
            DataRowView oDataRowView = (DataRowView)dgvLessons.SelectedRows[0].DataBoundItem;
            int Book_id = (int)oDataRowView.Row["ID"];
            string LectureCount = (string)oDataRowView.Row["Lecture"];
            frmAddNewClassDetails oAddnewClassDetails = new frmAddNewClassDetails(Book_id, LectureCount);
            oAddnewClassDetails.Show();
        }

        private void dgvLessons_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvLessons.SelectedRows.Count > 0)
            {
                btnDeleteLesson.Enabled = true;
                btnAddClassDetails.Enabled = true;
            }
            else
            {
                btnDeleteLesson.Enabled = false;
                btnAddClassDetails.Enabled = false;
            }
        }
    }
}
