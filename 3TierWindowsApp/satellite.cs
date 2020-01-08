using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace _3TierWindowsApp
{
    public partial class satellite : Form
    {
        public satellite()
        {
            InitializeComponent();
        }

        private void satellite_Load(object sender, EventArgs e)
        {
            satelliteBLL objSBLL = new satelliteBLL();
            objSBLL.selectdata();
            dataGridView1.DataSource = objSBLL.selectdata();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            satelliteBLL objSBLL = new satelliteBLL();
            objSBLL.insertdata(Convert.ToInt32(txtId.Text),txtPlace.Text, Convert.ToInt32(txtStationCode.Text));
            MessageBox.Show("Inserted");
            dataGridView1.DataSource = objSBLL.selectdata();
            Reset();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            satelliteBLL objSBLL = new satelliteBLL();
            objSBLL.updatedata(txtPlace.Text, Convert.ToInt32(txtId.Text),Convert.ToInt32(txtId.Text));
            MessageBox.Show("Updated");
            dataGridView1.DataSource = objSBLL.selectdata();
            Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            satelliteBLL objSBLL = new satelliteBLL();
            objSBLL.deletedata(Convert.ToInt32(txtId.Text));
            MessageBox.Show("Deleted");
            dataGridView1.DataSource = objSBLL.selectdata();
            Reset();
            
        }
        public void Reset()
        {
            txtId.Clear();
            txtPlace.Clear();
            txtStationCode.Clear();
        }
    }
}
