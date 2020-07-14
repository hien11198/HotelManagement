namespace HotelManagement
{
    partial class fReceiveRoom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbIDBookRoom = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbRoom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txbDateCheckIn = new System.Windows.Forms.TextBox();
            this.txbIDCard = new System.Windows.Forms.TextBox();
            this.txbRoomName = new System.Windows.Forms.TextBox();
            this.txbRoomTypeName = new System.Windows.Forms.TextBox();
            this.txbDateCheckOut = new System.Windows.Forms.TextBox();
            this.txbAmountPeople = new System.Windows.Forms.TextBox();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.txbFullName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReceiveRoom = new System.Windows.Forms.Button();
            this.btnClose_ = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridViewReceiveRoom = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceiveRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhận phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txbIDBookRoom);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(19, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 150);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(26, 99);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(203, 29);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbIDBookRoom
            // 
            this.txbIDBookRoom.Location = new System.Drawing.Point(26, 55);
            this.txbIDBookRoom.Name = "txbIDBookRoom";
            this.txbIDBookRoom.Size = new System.Drawing.Size(203, 29);
            this.txbIDBookRoom.TabIndex = 6;
            this.txbIDBookRoom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbIDBookRoom_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã đặt phòng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbRoom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbRoomType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(277, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(252, 150);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phòng trống";
            // 
            // cbRoom
            // 
            this.cbRoom.FormattingEnabled = true;
            this.cbRoom.Location = new System.Drawing.Point(23, 105);
            this.cbRoom.Name = "cbRoom";
            this.cbRoom.Size = new System.Drawing.Size(203, 29);
            this.cbRoom.TabIndex = 5;
            this.cbRoom.SelectedIndexChanged += new System.EventHandler(this.cbRoom_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phòng";
            // 
            // cbRoomType
            // 
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Location = new System.Drawing.Point(23, 49);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(203, 29);
            this.cbRoomType.TabIndex = 1;
            this.cbRoomType.SelectedIndexChanged += new System.EventHandler(this.cbRoomType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại phòng:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txbDateCheckIn);
            this.groupBox3.Controls.Add(this.txbIDCard);
            this.groupBox3.Controls.Add(this.txbRoomName);
            this.groupBox3.Controls.Add(this.txbRoomTypeName);
            this.groupBox3.Controls.Add(this.txbDateCheckOut);
            this.groupBox3.Controls.Add(this.txbAmountPeople);
            this.groupBox3.Controls.Add(this.txbPrice);
            this.groupBox3.Controls.Add(this.txbFullName);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox3.Location = new System.Drawing.Point(19, 208);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 253);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin khách hàng";
            // 
            // txbDateCheckIn
            // 
            this.txbDateCheckIn.Location = new System.Drawing.Point(281, 45);
            this.txbDateCheckIn.Name = "txbDateCheckIn";
            this.txbDateCheckIn.Size = new System.Drawing.Size(203, 29);
            this.txbDateCheckIn.TabIndex = 20;
            // 
            // txbIDCard
            // 
            this.txbIDCard.Location = new System.Drawing.Point(26, 101);
            this.txbIDCard.Name = "txbIDCard";
            this.txbIDCard.Size = new System.Drawing.Size(203, 29);
            this.txbIDCard.TabIndex = 19;
            // 
            // txbRoomName
            // 
            this.txbRoomName.Location = new System.Drawing.Point(26, 155);
            this.txbRoomName.Name = "txbRoomName";
            this.txbRoomName.Size = new System.Drawing.Size(203, 29);
            this.txbRoomName.TabIndex = 18;
            // 
            // txbRoomTypeName
            // 
            this.txbRoomTypeName.Location = new System.Drawing.Point(26, 208);
            this.txbRoomTypeName.Name = "txbRoomTypeName";
            this.txbRoomTypeName.Size = new System.Drawing.Size(203, 29);
            this.txbRoomTypeName.TabIndex = 17;
            // 
            // txbDateCheckOut
            // 
            this.txbDateCheckOut.Location = new System.Drawing.Point(281, 101);
            this.txbDateCheckOut.Name = "txbDateCheckOut";
            this.txbDateCheckOut.Size = new System.Drawing.Size(203, 29);
            this.txbDateCheckOut.TabIndex = 16;
            // 
            // txbAmountPeople
            // 
            this.txbAmountPeople.Location = new System.Drawing.Point(281, 155);
            this.txbAmountPeople.Name = "txbAmountPeople";
            this.txbAmountPeople.Size = new System.Drawing.Size(203, 29);
            this.txbAmountPeople.TabIndex = 15;
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(281, 208);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(203, 29);
            this.txbPrice.TabIndex = 14;
            // 
            // txbFullName
            // 
            this.txbFullName.Location = new System.Drawing.Point(26, 45);
            this.txbFullName.Name = "txbFullName";
            this.txbFullName.Size = new System.Drawing.Size(203, 29);
            this.txbFullName.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 77);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 21);
            this.label14.TabIndex = 12;
            this.label14.Text = "Thẻ căn cước/CMND:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(277, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(164, 21);
            this.label13.TabIndex = 11;
            this.label13.Text = "Số lượng người tối đa:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(85, 21);
            this.label12.TabIndex = 10;
            this.label12.Text = "Tên phòng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 21);
            this.label11.TabIndex = 9;
            this.label11.Text = "Tên loại phòng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(277, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "Ngày nhận:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "Ngày trả:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(277, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Giá:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Họ và tên:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCancel);
            this.groupBox4.Controls.Add(this.btnReceiveRoom);
            this.groupBox4.Controls.Add(this.btnClose_);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox4.Location = new System.Drawing.Point(19, 467);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(510, 110);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chức năng";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(26, 65);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(203, 29);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // btnReceiveRoom
            // 
            this.btnReceiveRoom.Location = new System.Drawing.Point(26, 28);
            this.btnReceiveRoom.Name = "btnReceiveRoom";
            this.btnReceiveRoom.Size = new System.Drawing.Size(203, 29);
            this.btnReceiveRoom.TabIndex = 10;
            this.btnReceiveRoom.Text = "Nhận phòng";
            this.btnReceiveRoom.UseVisualStyleBackColor = true;
            this.btnReceiveRoom.Click += new System.EventHandler(this.btnReceiveRoom_Click);
            // 
            // btnClose_
            // 
            this.btnClose_.Location = new System.Drawing.Point(281, 65);
            this.btnClose_.Name = "btnClose_";
            this.btnClose_.Size = new System.Drawing.Size(203, 29);
            this.btnClose_.TabIndex = 9;
            this.btnClose_.Text = "Đóng";
            this.btnClose_.UseVisualStyleBackColor = true;
            this.btnClose_.Click += new System.EventHandler(this.btnClose__Click_1);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridViewReceiveRoom);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox5.Location = new System.Drawing.Point(535, 52);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(665, 525);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Danh sách nhận phòng trong ngày";
            // 
            // dataGridViewReceiveRoom
            // 
            this.dataGridViewReceiveRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceiveRoom.Location = new System.Drawing.Point(6, 25);
            this.dataGridViewReceiveRoom.Name = "dataGridViewReceiveRoom";
            this.dataGridViewReceiveRoom.Size = new System.Drawing.Size(653, 382);
            this.dataGridViewReceiveRoom.TabIndex = 0;
            // 
            // fReceiveRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 589);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Name = "fReceiveRoom";
            this.Text = "fReceiveRoom";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceiveRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbIDBookRoom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txbDateCheckIn;
        private System.Windows.Forms.TextBox txbIDCard;
        private System.Windows.Forms.TextBox txbRoomName;
        private System.Windows.Forms.TextBox txbRoomTypeName;
        private System.Windows.Forms.TextBox txbDateCheckOut;
        private System.Windows.Forms.TextBox txbAmountPeople;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.TextBox txbFullName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReceiveRoom;
        private System.Windows.Forms.Button btnClose_;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridViewReceiveRoom;
    }
}