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
using System.Data.SqlClient;

namespace ClassModeration
{
    public partial class frmEdition : Form
    {
        int _id;
        public frmEdition()
        {
            InitializeComponent();
        }

        public void FillGrid()
        {
            DataTable Table = ClassModerationDAL.GetEntries();
            dgvEdit.DataSource = null;
            dgvEdit.DataSource = Table;
        }

        public void UpdateLecture(int id)
        {
            SqlConnection Connection = new SqlConnection(ClassModerationDAL.ConnectionString);
            SqlCommand Command = new SqlCommand();
            try
            {
                Connection.Open();
                Command.Connection = Connection;
                Command.CommandText = string.Format
                    ("update Book Set Lecture=(select COUNT([DayName]) from ClassDetails where Book_ID={0}) Where ID={0}", id);

                Command.ExecuteNonQuery();
            }
            finally
            {
                if (Connection.State == ConnectionState.Open)
                {
                    Connection.Close();
                }
            }
        }

        private void frmEditClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classModerationDataSet.Book' table. You can move, or remove it, as needed.
            //this.bookTableAdapter.Fill(this.classModerationDataSet.Book);
            FillGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvEdit_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEdit.SelectedRows.Count > 0)
            {
                btnEditLesson.Enabled = true;
                btnEditDetails.Enabled = true;
            }
            else
            {
                btnEditLesson.Enabled = false;
                btnEditDetails.Enabled = false;
            }
        }

        private void btnEditDetails_Click(object sender, EventArgs e)
        {
            DataRowView oDataRowView = (DataRowView)dgvEdit.SelectedRows[0].DataBoundItem;
            int Book_id = (int)oDataRowView.Row["ID"];
            frmEditClassDetails oEditClassDetails = new frmEditClassDetails(Book_id);
            oEditClassDetails.Show();

            UpdateLecture(Book_id);
            FillGrid();
        }

        private void btnEditLesson_Click(object sender, EventArgs e)
        {
            DataRowView oDataRowView = (DataRowView)dgvEdit.SelectedRows[0].DataBoundItem;
            _id = (int)oDataRowView.Row["ID"];
            frmEditMyLesson oEditMy = new frmEditMyLesson(_id);
            oEditMy.Show();
            oEditMy.FormClosed+=oEditMy_FormClosed;

        }

        void oEditMy_FormClosed(object sender, FormClosedEventArgs e)
        {
            FillGrid();
        }
    }
}
