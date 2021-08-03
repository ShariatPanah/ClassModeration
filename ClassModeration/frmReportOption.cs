using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Converting_Date;

namespace ClassModeration
{
    public partial class frmReportOption : Form
    {
        public frmReportOption()
        {
            InitializeComponent();
        }

        private void btnToday_Click(object sender, EventArgs e)
        {
            mtbDate.Text = Converting.PersianDate(DateTime.Now.ToString(), false, true);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MyReport oMyReport = new MyReport();
            //{ClassDetails.DueDate} = "03/10/1393"
            string Formula = "{ClassDetails.DueDate} = \"" + mtbDate.Text + "\"";
            oMyReport.DataDefinition.RecordSelectionFormula = Formula;

            frmReport Report = new frmReport(oMyReport);
            Report.Show();
        }
    }
}
