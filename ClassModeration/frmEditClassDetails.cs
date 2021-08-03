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
    public partial class frmEditClassDetails : Form
    {
        int _bookID;
        public frmEditClassDetails(int inbook_ID)
        {
            InitializeComponent();
            _bookID = inbook_ID;
        }

        public void FillGrid()
        {
            DataTable Table = ClassModerationDAL.GetClassDetailsEntries(_bookID);
            dgvChangeForm.DataSource = null;
            dgvChangeForm.DataSource = Table;
        }

        private void frmEditClassDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classModerationDataSet1.ClassDetails' table. You can move, or remove it, as needed.
            //this.classDetailsTableAdapter.Fill(this.classModerationDataSet1.ClassDetails);
            FillGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvChangeForm_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvChangeForm.SelectedRows.Count > 0)
            {
                btnEditRow.Enabled = true;
                btnDeleteRow.Enabled = true;
            }
            else
            {
                btnEditRow.Enabled = false;
                btnDeleteRow.Enabled = false;
            }
        }

        private void btnEditRow_Click(object sender, EventArgs e)
        {
            DataRowView oDataRow = (DataRowView)dgvChangeForm.SelectedRows[0].DataBoundItem;
            int id = (int)oDataRow.Row["ID"];
            frmEditRowDetails oEditRow = new frmEditRowDetails(id);
            oEditRow.Show();
            oEditRow.FormClosed += oEditRow_FormClosed;
        }

        void oEditRow_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillGrid();
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            DataRowView oDataRow = (DataRowView)dgvChangeForm.SelectedRows[0].DataBoundItem;
            int id = (int)oDataRow.Row["ID"];
            ClassModerationDAL.DeleteRowDetails(id);
            FillGrid();
        }
    }
}
