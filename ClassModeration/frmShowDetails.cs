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
    public partial class frmShowDetails : Form
    {
        int _bookId;
        public frmShowDetails(int inID)
        {
            InitializeComponent();
            _bookId = inID;
        }

        public void FillGrid()
        {
            DataTable Table = ClassModerationDAL.GetClassDetailsEntries(_bookId);
            dgvShowDetails.DataSource = null;
            dgvShowDetails.DataSource = Table;
        }
        private void frmShowDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'classModerationDataSet1.ClassDetails' table. You can move, or remove it, as needed.
            //this.classDetailsTableAdapter.Fill(this.classModerationDataSet1.ClassDetails);
            FillGrid();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
