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
using System.Data.SqlClient;

namespace ClassModeration
{
    public partial class frmShowClass : Form
    {
        public frmShowClass()
        {
            InitializeComponent();
        }
        public void FillGrid()
        {
            DataTable Table = ClassModerationDAL.GetEntries();
            dgvShow.DataSource = null;
            dgvShow.DataSource = Table;
        }

        private void frmShowClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classModerationDataSet.Book' table. You can move, or remove it, as needed.
            this.bookTableAdapter.Fill(this.classModerationDataSet.Book);
            #region MyCode
            //SqlConnection Connection = new SqlConnection(ClassModerationDAL.ConnectionString);
            //SqlCommand Command = Connection.CreateCommand();
            //try
            //{
            //    Command.Connection.Open();
            //    Command.CommandType = CommandType.Text;
            //    Command.CommandText = "Select * From ClassDetails";
            //    SqlDataReader Reader = Command.ExecuteReader();
            //    DataTable Table = new DataTable();
            //    Table.Load(Reader);
            //    dgvShow.DataSource = Table;
            //}
            //finally
            //{
            //    if (Command.Connection.State==ConnectionState.Open)
            //    {
            //        Command.Connection.Close();
            //    }
            //}
            #endregion
            FillGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvShow_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvShow.SelectedRows.Count > 0)
            {
                btnShow.Enabled = true;
            }
            else
            {
                btnShow.Enabled = false;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            DataRowView oData = (DataRowView)dgvShow.SelectedRows[0].DataBoundItem;
            int id = (int)oData.Row["ID"];
            frmShowDetails oShow = new frmShowDetails(id);
            oShow.Show();
        }
    }
}
