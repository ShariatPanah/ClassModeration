using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Class_Moderation.BLL;
using Class_Moderation.DAL;
using System.IO;

namespace ClassModeration
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public void CheckStatus()
        {
            PersianCalendar P = new PersianCalendar();
            string Clock = P.AddHours(DateTime.Now, -5).ToString("HH") + ":00-" + P.AddHours(DateTime.Now, -3).ToString("HH") + ":00";
            Class_Moderation.DAL.ClassModerationDAL.UpdateClassStatus(Clock);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddClass_Click(object sender, EventArgs e)
        {
            frmAddNewClass oAddNewClass = new frmAddNewClass();
            oAddNewClass.ShowDialog();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            frmEdition oChangeClass = new frmEdition();
            oChangeClass.ShowDialog();
        }

        private void btnShowClass_Click(object sender, EventArgs e)
        {
            frmShowClass oShowClass = new frmShowClass();
            oShowClass.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PersianCalendar P = new PersianCalendar();

            this.label2.Text = string.Format("{0:HH:mm:ss}", DateTime.Now);
            this.lblclock.Text = string.Format("{0:HH:mm:ss}", DateTime.Now);
            //System.DateTime.Now.ToLongTimeString();
            
            Converting_Date.Converting C= new Converting_Date.Converting();
            this.label3.Text = C.ConvertDay() + " " + P.GetDayOfMonth(DateTime.Now) + " " + C.ConvertMonth() + " " + P.GetYear(DateTime.Now);
               // P.GetYear(DateTime.Now) + "/" + P.GetMonth(DateTime.Now) + "/" + P.GetDayOfMonth(DateTime.Now);
            CheckStatus();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReportOption ReportOption = new frmReportOption();
            ReportOption.ShowDialog();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            frmUser User = new frmUser();
            User.ShowDialog();
        }
    }
}
