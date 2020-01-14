using System;
using System.Data;
using System.Windows.Forms;
using BLL;
using System.Xml.Serialization;

namespace _3TierWindowsApp
{
    public partial class rocket : Form
    {
        public rocket()
        {
            InitializeComponent();
            
        }
        //SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["myconn"].ConnectionString);
        protected void btnSave_Click(object sender, EventArgs e)
        {
            clsBussLayer objBLL = new clsBussLayer();
            objBLL.InsertRocket(Convert.ToInt32(txtId.Text),txtName.Text,txtVehicleType.Text,txtPurpose.Text);
            MessageBox.Show("Inserted");
            dataGridView1.DataSource = objBLL.SelectRocket();
            Reset();
            //dataGridView1.DataBind();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            clsBussLayer objBLL = new clsBussLayer();
            objBLL.UpdateRocket(txtName.Text, txtVehicleType.Text, txtPurpose.Text, Convert.ToInt32(txtId.Text));
            MessageBox.Show("Updated");
            dataGridView1.DataSource = objBLL.SelectRocket();
            Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clsBussLayer objBLL = new clsBussLayer();
            objBLL.DeleteRocket(Convert.ToInt32(txtId.Text));
            MessageBox.Show("Deleted");
            dataGridView1.DataSource = objBLL.SelectRocket();
            Reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            clsBussLayer objBLL = new clsBussLayer();
            objBLL.SelectRocket();
            dataGridView1.DataSource = objBLL.SelectRocket();

        }
        public void Reset()
        {
            txtId.Clear();
            txtName.Clear();
            txtVehicleType.Clear();
            txtPurpose.Clear();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
           
        }
    }
}
