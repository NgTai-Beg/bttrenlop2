using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bttrenlop2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Tao 1 dong du lieu
            ListViewItem lvi = new ListViewItem(txtLastName.Text);
            //add cac cot con lai vao lvi
            lvi.SubItems.Add(txtFirstName.Text);
            lvi.SubItems.Add(txtPhone.Text);
            //dua du lieu len listview
            listView1.Items.Add(lvi);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listView1.SelectedItems)
                {
                    item.Text = txtLastName.Text;
                    item.SubItems[1].Text = txtFirstName.Text;
                    item.SubItems[2].Text = txtPhone.Text;
                }

                txtLastName.Clear();
                txtFirstName.Clear();
                txtPhone.Clear();
            }
            else
            {
                MessageBox.Show("Hay don dong can sua");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
         
            
                if (listView1.SelectedItems.Count > 0)
                {
                    listView1.Items.Remove(listView1.SelectedItems[0]);
                }
                else
                {
                    MessageBox.Show("Vui 1  lòng chọn một hàng để xóa!");
                }
            
        }
    }
}
