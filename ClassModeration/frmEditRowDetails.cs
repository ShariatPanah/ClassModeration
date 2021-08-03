using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Class_Moderation.BLL;
using Class_Moderation.DAL;

namespace ClassModeration
{
    public partial class frmEditRowDetails : Form
    {
        int _id;
        public frmEditRowDetails(int inId)
        {
            InitializeComponent();
            _id = inId;
        }

        private void frmEditRowDetails_Load(object sender, EventArgs e)
        {
            Class_Moderation.BLL.ClassDetails Obj = new Class_Moderation.BLL.ClassDetails();
            Obj = ClassModerationDAL.Retrieve(_id);
            txtClassNo.Text = Obj.ClassNo;
            mtbDate.Text = Obj.ClassDate;
            mtbTime.Text = Obj.ClassTime;
            cmbDay.Text = Obj.DayName;
            cmbStatus.Text = Obj.Status;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
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

            NewClassDetails.Status = cmbStatus.SelectedItem.ToString();

            ClassModerationDAL.UpdateDetails(_id, NewClassDetails);
            MessageBox.Show("تغییرات با موفقیت ثبت گردید");

            this.Close();
        }
    }
}
