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
    public partial class frmAddNewClassDetails : Form
    {
        int _bookId, Counter = 0;
        int _lectureNum;
        public frmAddNewClassDetails(int inID, string inLecture)
        {
            InitializeComponent();
            _bookId = inID;
            _lectureNum = Convert.ToInt32(inLecture);
        }
        public void FillGrid()
        {
            DataTable Table = ClassModerationDAL.GetClassDetailsEntries(_bookId);
            dgvDetails.DataSource = null;
            dgvDetails.DataSource = Table;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (Counter <= _lectureNum) 
            {
                ClassDetails NewClassDetails = new ClassDetails();
                if (!String.IsNullOrEmpty(txtClassNo.Text))
                {
                    NewClassDetails.ClassNo = txtClassNo.Text;
                }
                else
                    MessageBox.Show("شماره کلاس را وارد کنید");

                if (mtbDate.Text != null)
                {
                    NewClassDetails.ClassDate = mtbDate.Text;
                }
                else
                    MessageBox.Show("تاریخ را وارد کنید");

                if (mtbTime.Text != null)
                {
                    NewClassDetails.ClassTime = mtbTime.Text;
                }
                else
                    MessageBox.Show("ساعت برگزاری کلاس را وارد کنید");

                if (cmbDay.SelectedItem != null) 
                {
                    NewClassDetails.DayName = cmbDay.SelectedItem.ToString();
                }

                NewClassDetails.Status = "ــــ";
                ClassModerationDAL.InsertClassDetails(_bookId, NewClassDetails);
                cmbDay.SelectedItem = null;
                mtbTime.Text = "";
                mtbDate.Text = "";
                txtClassNo.Text = "";

                FillGrid();
                Counter++;
            }
            else
            {
                MessageBox.Show("برنامه با موفقیت اضافه گردید");
            }
        }

        private void frmAddNewClassDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classModerationDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.classModerationDataSet.Book);
            FillGrid();
        }
    }
}
