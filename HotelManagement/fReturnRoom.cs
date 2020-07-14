using HotelManagement.DAO;
using HotelManagement.DTO;
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
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            LoadData();
            
        }
        public void LoadData()
        {
            LoadListFullRoom();
            
        }
        public void LoadListFullRoom()
        {
            dataGridView1.DataSource = RoomDAO.Instance.LoadFullRoom2();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txbID.Text = row.Cells["ID"].Value.ToString();
                txbName.Text = row.Cells["Name"].Value.ToString();
                txbnameRoomType.Text = row.Cells["nameRoomType"].Value.ToString();
                txbPrice.Text = row.Cells["Price"].Value.ToString();
                txbLimitPerson.Text = row.Cells["LimitPerson"].Value.ToString();
                txbnameStatusRoom.Text = row.Cells["nameStatusRoom"].Value.ToString();
            }
        }
        public bool ReturnRoom(int idRoom)
        {
            return ReceiveRoomDAO.Instance.ReturnRoom(idRoom);
        }
        private void btnReturnRoom_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn trả phòng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (txbID.Text != string.Empty)
                {
                    if (ReturnRoom(int.Parse(txbID.Text)))
                    {
                        btnReturnRoom.Tag = txbID.Text;
                        LoadListFullRoom();
                        ClearData();
                    }
                    else
                        MessageBox.Show("Mã đặt phòng không tồn tại.\nVui lòng nhập lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        public void ClearData()
        {
            txbID.Text = txbName.Text =  txbnameRoomType.Text = txbPrice.Text = txbLimitPerson.Text = txbnameStatusRoom.Text = string.Empty;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void txbIDCardSearch_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
