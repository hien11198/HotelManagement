using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class fManagement : Form
    {
        public fManagement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!mainpanel.Controls.Contains(BookRoom.Instance))
            {
                mainpanel.Controls.Add(BookRoom.Instance);
                BookRoom.Instance.Dock = DockStyle.Fill;
                BookRoom.Instance.BringToFront();
            }
            else
                BookRoom.Instance.BringToFront();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            fReceiveRoom f = new fReceiveRoom();
            f.ShowDialog();
            Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog();
            Show();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
