namespace WindowsFormsApp2
{
    partial class Form1
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
            this.orderCode = new System.Windows.Forms.Label();
            this.senderName = new System.Windows.Forms.Label();
            this.senderAddress = new System.Windows.Forms.Label();
            this.recipientAddress = new System.Windows.Forms.Label();
            this.orderWeight = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.orderLong = new System.Windows.Forms.Label();
            this.orderWidth = new System.Windows.Forms.Label();
            this.oderHeight = new System.Windows.Forms.Label();
            this.inputCode = new System.Windows.Forms.TextBox();
            this.inputSenderName = new System.Windows.Forms.TextBox();
            this.inputSenderAddress = new System.Windows.Forms.TextBox();
            this.inputRecipientAddress = new System.Windows.Forms.TextBox();
            this.inputOrderWeight = new System.Windows.Forms.TextBox();
            this.inputOrderLong = new System.Windows.Forms.TextBox();
            this.inputOrderWidth = new System.Windows.Forms.TextBox();
            this.inputOderHeight = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFix = new System.Windows.Forms.Button();
            this.infoOrder = new System.Windows.Forms.GroupBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            this.infoOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // orderCode
            // 
            this.orderCode.AutoSize = true;
            this.orderCode.Location = new System.Drawing.Point(98, 198);
            this.orderCode.Name = "orderCode";
            this.orderCode.Size = new System.Drawing.Size(65, 13);
            this.orderCode.TabIndex = 0;
            this.orderCode.Text = "Mã vận đơn";
            this.orderCode.Click += new System.EventHandler(this.label1_Click);
            // 
            // senderName
            // 
            this.senderName.AutoSize = true;
            this.senderName.Location = new System.Drawing.Point(98, 246);
            this.senderName.Name = "senderName";
            this.senderName.Size = new System.Drawing.Size(72, 13);
            this.senderName.TabIndex = 0;
            this.senderName.Text = "Tên người gửi";
            // 
            // senderAddress
            // 
            this.senderAddress.AutoSize = true;
            this.senderAddress.Location = new System.Drawing.Point(98, 297);
            this.senderAddress.Name = "senderAddress";
            this.senderAddress.Size = new System.Drawing.Size(57, 13);
            this.senderAddress.TabIndex = 0;
            this.senderAddress.Text = "Địa chỉ gửi";
            // 
            // recipientAddress
            // 
            this.recipientAddress.AutoSize = true;
            this.recipientAddress.Location = new System.Drawing.Point(98, 345);
            this.recipientAddress.Name = "recipientAddress";
            this.recipientAddress.Size = new System.Drawing.Size(67, 13);
            this.recipientAddress.TabIndex = 0;
            this.recipientAddress.Text = "Địa chỉ nhận";
            // 
            // orderWeight
            // 
            this.orderWeight.AutoSize = true;
            this.orderWeight.Location = new System.Drawing.Point(98, 389);
            this.orderWeight.Name = "orderWeight";
            this.orderWeight.Size = new System.Drawing.Size(64, 13);
            this.orderWeight.TabIndex = 0;
            this.orderWeight.Text = "Trọng lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 433);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "label1";
            // 
            // orderLong
            // 
            this.orderLong.AutoSize = true;
            this.orderLong.Location = new System.Drawing.Point(98, 434);
            this.orderLong.Name = "orderLong";
            this.orderLong.Size = new System.Drawing.Size(51, 13);
            this.orderLong.TabIndex = 0;
            this.orderLong.Text = "Chiều dài";
            // 
            // orderWidth
            // 
            this.orderWidth.AutoSize = true;
            this.orderWidth.Location = new System.Drawing.Point(98, 485);
            this.orderWidth.Name = "orderWidth";
            this.orderWidth.Size = new System.Drawing.Size(58, 13);
            this.orderWidth.TabIndex = 0;
            this.orderWidth.Text = "Chiều rộng";
            // 
            // oderHeight
            // 
            this.oderHeight.AutoSize = true;
            this.oderHeight.Location = new System.Drawing.Point(98, 532);
            this.oderHeight.Name = "oderHeight";
            this.oderHeight.Size = new System.Drawing.Size(55, 13);
            this.oderHeight.TabIndex = 0;
            this.oderHeight.Text = "Chiều cao";
            // 
            // inputCode
            // 
            this.inputCode.Location = new System.Drawing.Point(180, 195);
            this.inputCode.Name = "inputCode";
            this.inputCode.Size = new System.Drawing.Size(322, 20);
            this.inputCode.TabIndex = 1;
            // 
            // inputSenderName
            // 
            this.inputSenderName.Location = new System.Drawing.Point(180, 243);
            this.inputSenderName.Name = "inputSenderName";
            this.inputSenderName.Size = new System.Drawing.Size(322, 20);
            this.inputSenderName.TabIndex = 1;
            this.inputSenderName.TextChanged += new System.EventHandler(this.changeCode);
            // 
            // inputSenderAddress
            // 
            this.inputSenderAddress.Location = new System.Drawing.Point(180, 294);
            this.inputSenderAddress.Name = "inputSenderAddress";
            this.inputSenderAddress.Size = new System.Drawing.Size(322, 20);
            this.inputSenderAddress.TabIndex = 1;
            // 
            // inputRecipientAddress
            // 
            this.inputRecipientAddress.Location = new System.Drawing.Point(180, 342);
            this.inputRecipientAddress.Name = "inputRecipientAddress";
            this.inputRecipientAddress.Size = new System.Drawing.Size(322, 20);
            this.inputRecipientAddress.TabIndex = 1;
            this.inputRecipientAddress.Text = " ";
            // 
            // inputOrderWeight
            // 
            this.inputOrderWeight.Location = new System.Drawing.Point(180, 386);
            this.inputOrderWeight.Name = "inputOrderWeight";
            this.inputOrderWeight.Size = new System.Drawing.Size(322, 20);
            this.inputOrderWeight.TabIndex = 1;
            // 
            // inputOrderLong
            // 
            this.inputOrderLong.Location = new System.Drawing.Point(180, 431);
            this.inputOrderLong.Name = "inputOrderLong";
            this.inputOrderLong.Size = new System.Drawing.Size(322, 20);
            this.inputOrderLong.TabIndex = 1;
            // 
            // inputOrderWidth
            // 
            this.inputOrderWidth.Location = new System.Drawing.Point(180, 482);
            this.inputOrderWidth.Name = "inputOrderWidth";
            this.inputOrderWidth.Size = new System.Drawing.Size(322, 20);
            this.inputOrderWidth.TabIndex = 1;
            // 
            // inputOderHeight
            // 
            this.inputOderHeight.Location = new System.Drawing.Point(180, 529);
            this.inputOderHeight.Name = "inputOderHeight";
            this.inputOderHeight.Size = new System.Drawing.Size(322, 20);
            this.inputOderHeight.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(187, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "không hợp lệ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(273, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "bạn chưa nhập";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(273, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "bạn chưa nhập";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(273, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "bạn chưa nhập";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(273, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "bạn chưa nhập";
            this.label5.Click += new System.EventHandler(this.label2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(273, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "bạn chưa nhập";
            this.label7.Click += new System.EventHandler(this.label2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(273, 454);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "bạn chưa nhập";
            this.label8.Click += new System.EventHandler(this.label2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(273, 505);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "bạn chưa nhập";
            this.label9.Click += new System.EventHandler(this.label2_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(187, 266);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "không hợp lệ";
            this.label10.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(187, 317);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "không hợp lệ";
            this.label11.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(187, 365);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(69, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "không hợp lệ";
            this.label12.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(187, 409);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "không hợp lệ";
            this.label13.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(187, 454);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "không hợp lệ";
            this.label14.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(187, 505);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(69, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "không hợp lệ";
            this.label15.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(187, 552);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "không hợp lệ";
            this.label16.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(273, 552);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "bạn chưa nhập";
            this.label17.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(180, 158);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAddClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(346, 158);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDeleteClick);
            // 
            // btnFix
            // 
            this.btnFix.Location = new System.Drawing.Point(265, 158);
            this.btnFix.Name = "btnFix";
            this.btnFix.Size = new System.Drawing.Size(75, 23);
            this.btnFix.TabIndex = 4;
            this.btnFix.Text = "Sữa";
            this.btnFix.UseVisualStyleBackColor = true;
            this.btnFix.Click += new System.EventHandler(this.btnFIxClick);
            // 
            // infoOrder
            // 
            this.infoOrder.Controls.Add(this.dgv);
            this.infoOrder.Location = new System.Drawing.Point(51, 12);
            this.infoOrder.Name = "infoOrder";
            this.infoOrder.Size = new System.Drawing.Size(525, 129);
            this.infoOrder.TabIndex = 5;
            this.infoOrder.TabStop = false;
            this.infoOrder.Text = "Thông tin đơn vận chuyển";
            this.infoOrder.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(6, 19);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(513, 104);
            this.dgv.TabIndex = 6;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(427, 158);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 6;
            this.btnCreate.Text = "Khởi tạo";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreateClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(630, 576);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.infoOrder);
            this.Controls.Add(this.btnFix);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputOderHeight);
            this.Controls.Add(this.inputOrderWidth);
            this.Controls.Add(this.inputOrderLong);
            this.Controls.Add(this.inputOrderWeight);
            this.Controls.Add(this.inputRecipientAddress);
            this.Controls.Add(this.inputSenderAddress);
            this.Controls.Add(this.inputSenderName);
            this.Controls.Add(this.inputCode);
            this.Controls.Add(this.oderHeight);
            this.Controls.Add(this.orderWidth);
            this.Controls.Add(this.orderLong);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.orderWeight);
            this.Controls.Add(this.recipientAddress);
            this.Controls.Add(this.senderAddress);
            this.Controls.Add(this.senderName);
            this.Controls.Add(this.orderCode);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn Vận Chuyển";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.infoOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label orderCode;
        private System.Windows.Forms.Label senderName;
        private System.Windows.Forms.Label senderAddress;
        private System.Windows.Forms.Label recipientAddress;
        private System.Windows.Forms.Label orderWeight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label orderLong;
        private System.Windows.Forms.Label orderWidth;
        private System.Windows.Forms.Label oderHeight;
        private System.Windows.Forms.TextBox inputCode;
        private System.Windows.Forms.TextBox inputSenderName;
        private System.Windows.Forms.TextBox inputSenderAddress;
        private System.Windows.Forms.TextBox inputRecipientAddress;
        private System.Windows.Forms.TextBox inputOrderWeight;
        private System.Windows.Forms.TextBox inputOrderLong;
        private System.Windows.Forms.TextBox inputOrderWidth;
        private System.Windows.Forms.TextBox inputOderHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFix;
        private System.Windows.Forms.GroupBox infoOrder;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnCreate;
    }
}

