namespace HotelManagement
{
    partial class fBookRoom
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dpkDateCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dpkDateCheckIn = new System.Windows.Forms.DateTimePicker();
            this.txbDays = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txbIDCardSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.cbNationality = new System.Windows.Forms.ComboBox();
            this.txbAddress = new System.Windows.Forms.TextBox();
            this.dpkDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.txbPhoneNumber = new System.Windows.Forms.TextBox();
            this.cbCustomerType = new System.Windows.Forms.ComboBox();
            this.txbIDCard = new System.Windows.Forms.TextBox();
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
            this.txbRoomTypeID = new System.Windows.Forms.TextBox();
            this.txbAmountPeople = new System.Windows.Forms.TextBox();
            this.txbPrice = new System.Windows.Forms.TextBox();
            this.txbRoomTypeName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btnClose_ = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnBookRoom = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridViewBookRoom = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookRoom)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đặt Phòng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dpkDateCheckOut);
            this.groupBox1.Controls.Add(this.dpkDateCheckIn);
            this.groupBox1.Controls.Add(this.txbDays);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbRoomType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox1.Location = new System.Drawing.Point(19, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 155);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đăng kí";
            // 
            // dpkDateCheckOut
            // 
            this.dpkDateCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkDateCheckOut.Location = new System.Drawing.Point(197, 105);
            this.dpkDateCheckOut.Name = "dpkDateCheckOut";
            this.dpkDateCheckOut.Size = new System.Drawing.Size(200, 29);
            this.dpkDateCheckOut.TabIndex = 7;
            this.dpkDateCheckOut.ValueChanged += new System.EventHandler(this.dpkDateCheckOut_ValueChanged);
            // 
            // dpkDateCheckIn
            // 
            this.dpkDateCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkDateCheckIn.Location = new System.Drawing.Point(198, 49);
            this.dpkDateCheckIn.Name = "dpkDateCheckIn";
            this.dpkDateCheckIn.Size = new System.Drawing.Size(200, 29);
            this.dpkDateCheckIn.TabIndex = 6;
            this.dpkDateCheckIn.ValueChanged += new System.EventHandler(this.dpkDateCheckIn_ValueChanged);
            // 
            // txbDays
            // 
            this.txbDays.Location = new System.Drawing.Point(10, 105);
            this.txbDays.Name = "txbDays";
            this.txbDays.Size = new System.Drawing.Size(164, 29);
            this.txbDays.TabIndex = 5;
            this.txbDays.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDays_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số đêm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày nhận:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày trả:";
            // 
            // cbRoomType
            // 
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Location = new System.Drawing.Point(10, 49);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(164, 29);
            this.cbRoomType.TabIndex = 1;
            this.cbRoomType.SelectedIndexChanged += new System.EventHandler(this.cbRoomType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại phòng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txbIDCardSearch);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox2.Location = new System.Drawing.Point(19, 213);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 99);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm khách hàng";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(198, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(200, 29);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txbIDCardSearch
            // 
            this.txbIDCardSearch.Location = new System.Drawing.Point(6, 56);
            this.txbIDCardSearch.Name = "txbIDCardSearch";
            this.txbIDCardSearch.Size = new System.Drawing.Size(164, 29);
            this.txbIDCardSearch.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Thẻ căn cước/CMND:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbSex);
            this.groupBox3.Controls.Add(this.cbNationality);
            this.groupBox3.Controls.Add(this.txbAddress);
            this.groupBox3.Controls.Add(this.dpkDateOfBirth);
            this.groupBox3.Controls.Add(this.txbPhoneNumber);
            this.groupBox3.Controls.Add(this.cbCustomerType);
            this.groupBox3.Controls.Add(this.txbIDCard);
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
            this.groupBox3.Location = new System.Drawing.Point(19, 324);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(407, 253);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin khách hàng";
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Location = new System.Drawing.Point(197, 152);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(201, 29);
            this.cbSex.TabIndex = 20;
            // 
            // cbNationality
            // 
            this.cbNationality.FormattingEnabled = true;
            this.cbNationality.Location = new System.Drawing.Point(197, 208);
            this.cbNationality.Name = "cbNationality";
            this.cbNationality.Size = new System.Drawing.Size(200, 29);
            this.cbNationality.TabIndex = 19;
            // 
            // txbAddress
            // 
            this.txbAddress.Location = new System.Drawing.Point(197, 96);
            this.txbAddress.Name = "txbAddress";
            this.txbAddress.Size = new System.Drawing.Size(201, 29);
            this.txbAddress.TabIndex = 18;
            // 
            // dpkDateOfBirth
            // 
            this.dpkDateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dpkDateOfBirth.Location = new System.Drawing.Point(197, 45);
            this.dpkDateOfBirth.Name = "dpkDateOfBirth";
            this.dpkDateOfBirth.Size = new System.Drawing.Size(200, 29);
            this.dpkDateOfBirth.TabIndex = 17;
            // 
            // txbPhoneNumber
            // 
            this.txbPhoneNumber.Location = new System.Drawing.Point(10, 207);
            this.txbPhoneNumber.Name = "txbPhoneNumber";
            this.txbPhoneNumber.Size = new System.Drawing.Size(164, 29);
            this.txbPhoneNumber.TabIndex = 16;
            // 
            // cbCustomerType
            // 
            this.cbCustomerType.FormattingEnabled = true;
            this.cbCustomerType.Location = new System.Drawing.Point(10, 152);
            this.cbCustomerType.Name = "cbCustomerType";
            this.cbCustomerType.Size = new System.Drawing.Size(164, 29);
            this.cbCustomerType.TabIndex = 15;
            // 
            // txbIDCard
            // 
            this.txbIDCard.Location = new System.Drawing.Point(10, 96);
            this.txbIDCard.Name = "txbIDCard";
            this.txbIDCard.Size = new System.Drawing.Size(164, 29);
            this.txbIDCard.TabIndex = 14;
            // 
            // txbFullName
            // 
            this.txbFullName.Location = new System.Drawing.Point(10, 45);
            this.txbFullName.Name = "txbFullName";
            this.txbFullName.Size = new System.Drawing.Size(164, 29);
            this.txbFullName.TabIndex = 13;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 72);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(156, 21);
            this.label14.TabIndex = 12;
            this.label14.Text = "Thẻ căn cước/CMND:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(193, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 21);
            this.label13.TabIndex = 11;
            this.label13.Text = "Giới tính:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 21);
            this.label12.TabIndex = 10;
            this.label12.Text = "Loại khách hàng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 184);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(104, 21);
            this.label11.TabIndex = 9;
            this.label11.Text = "Số điện thoại:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(193, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 21);
            this.label10.TabIndex = 8;
            this.label10.Text = "Ngày sinh:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 21);
            this.label9.TabIndex = 7;
            this.label9.Text = "Địa chỉ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Quốc tịch:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 21);
            this.label7.TabIndex = 5;
            this.label7.Text = "Họ và tên:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txbRoomTypeID);
            this.groupBox4.Controls.Add(this.txbAmountPeople);
            this.groupBox4.Controls.Add(this.txbPrice);
            this.groupBox4.Controls.Add(this.txbRoomTypeName);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox4.Location = new System.Drawing.Point(441, 52);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(227, 260);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin loại phòng";
            // 
            // txbRoomTypeID
            // 
            this.txbRoomTypeID.Location = new System.Drawing.Point(24, 49);
            this.txbRoomTypeID.Name = "txbRoomTypeID";
            this.txbRoomTypeID.Size = new System.Drawing.Size(182, 29);
            this.txbRoomTypeID.TabIndex = 8;
            // 
            // txbAmountPeople
            // 
            this.txbAmountPeople.Location = new System.Drawing.Point(24, 161);
            this.txbAmountPeople.Name = "txbAmountPeople";
            this.txbAmountPeople.Size = new System.Drawing.Size(182, 29);
            this.txbAmountPeople.TabIndex = 7;
            // 
            // txbPrice
            // 
            this.txbPrice.Location = new System.Drawing.Point(24, 217);
            this.txbPrice.Name = "txbPrice";
            this.txbPrice.Size = new System.Drawing.Size(182, 29);
            this.txbPrice.TabIndex = 6;
            // 
            // txbRoomTypeName
            // 
            this.txbRoomTypeName.Location = new System.Drawing.Point(24, 105);
            this.txbRoomTypeName.Name = "txbRoomTypeName";
            this.txbRoomTypeName.Size = new System.Drawing.Size(182, 29);
            this.txbRoomTypeName.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 21);
            this.label15.TabIndex = 4;
            this.label15.Text = "Tên loại phòng:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(8, 193);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 21);
            this.label16.TabIndex = 3;
            this.label16.Text = "Giá:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 137);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(164, 21);
            this.label17.TabIndex = 2;
            this.label17.Text = "Số lượng người tối đa:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 25);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(113, 21);
            this.label18.TabIndex = 0;
            this.label18.Text = "Mã loại phòng:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.checkBox1);
            this.groupBox5.Controls.Add(this.btnClose_);
            this.groupBox5.Controls.Add(this.btnCancel);
            this.groupBox5.Controls.Add(this.btnBookRoom);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox5.Location = new System.Drawing.Point(441, 324);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(227, 250);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Chức năng";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(200, 25);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "Chuyển đến nhận phòng";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btnClose_
            // 
            this.btnClose_.Location = new System.Drawing.Point(45, 184);
            this.btnClose_.Name = "btnClose_";
            this.btnClose_.Size = new System.Drawing.Size(161, 35);
            this.btnClose_.TabIndex = 3;
            this.btnClose_.Text = "Đóng";
            this.btnClose_.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(45, 128);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(161, 38);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnBookRoom
            // 
            this.btnBookRoom.Location = new System.Drawing.Point(45, 78);
            this.btnBookRoom.Name = "btnBookRoom";
            this.btnBookRoom.Size = new System.Drawing.Size(161, 35);
            this.btnBookRoom.TabIndex = 1;
            this.btnBookRoom.Text = "Đặt phòng";
            this.btnBookRoom.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridViewBookRoom);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.Color.SeaGreen;
            this.groupBox6.Location = new System.Drawing.Point(685, 52);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(656, 522);
            this.groupBox6.TabIndex = 10;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Danh sách đặt phòng trong ngày";
            // 
            // dataGridViewBookRoom
            // 
            this.dataGridViewBookRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBookRoom.Location = new System.Drawing.Point(6, 26);
            this.dataGridViewBookRoom.Name = "dataGridViewBookRoom";
            this.dataGridViewBookRoom.Size = new System.Drawing.Size(648, 490);
            this.dataGridViewBookRoom.TabIndex = 0;
            // 
            // fBookRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1341, 586);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "fBookRoom";
            this.Text = "fBookRoom";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBookRoom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dpkDateCheckOut;
        private System.Windows.Forms.DateTimePicker dpkDateCheckIn;
        private System.Windows.Forms.TextBox txbDays;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txbIDCardSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.ComboBox cbNationality;
        private System.Windows.Forms.TextBox txbAddress;
        private System.Windows.Forms.DateTimePicker dpkDateOfBirth;
        private System.Windows.Forms.TextBox txbPhoneNumber;
        private System.Windows.Forms.ComboBox cbCustomerType;
        private System.Windows.Forms.TextBox txbIDCard;
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
        private System.Windows.Forms.TextBox txbRoomTypeID;
        private System.Windows.Forms.TextBox txbAmountPeople;
        private System.Windows.Forms.TextBox txbPrice;
        private System.Windows.Forms.TextBox txbRoomTypeName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button btnClose_;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnBookRoom;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dataGridViewBookRoom;
    }
}