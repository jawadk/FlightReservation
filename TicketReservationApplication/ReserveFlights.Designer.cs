namespace TicketReservationApplication
{
    partial class ReserveFlights
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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label_Arrival = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label_Departure = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radio_btn_TwoWay = new System.Windows.Forms.RadioButton();
            this.radio_btn_Oneway = new System.Windows.Forms.RadioButton();
            this.lable_Firstname = new System.Windows.Forms.Label();
            this.btn_Back = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.btn_SearchFight = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(478, 169);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 30;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 169);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(196, 20);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // label_Arrival
            // 
            this.label_Arrival.AutoSize = true;
            this.label_Arrival.Location = new System.Drawing.Point(474, 153);
            this.label_Arrival.Name = "label_Arrival";
            this.label_Arrival.Size = new System.Drawing.Size(36, 13);
            this.label_Arrival.TabIndex = 28;
            this.label_Arrival.Text = "Arrival";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "No. of Passenger";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox4.Location = new System.Drawing.Point(477, 212);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(201, 21);
            this.comboBox4.TabIndex = 26;
            // 
            // label_Departure
            // 
            this.label_Departure.AutoSize = true;
            this.label_Departure.Location = new System.Drawing.Point(102, 153);
            this.label_Departure.Name = "label_Departure";
            this.label_Departure.Size = new System.Drawing.Size(80, 13);
            this.label_Departure.TabIndex = 25;
            this.label_Departure.Text = "Departure Date";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(478, 126);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "To City:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "From City:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(197, 21);
            this.comboBox1.TabIndex = 21;
            // 
            // radio_btn_TwoWay
            // 
            this.radio_btn_TwoWay.AutoSize = true;
            this.radio_btn_TwoWay.Location = new System.Drawing.Point(209, 81);
            this.radio_btn_TwoWay.Name = "radio_btn_TwoWay";
            this.radio_btn_TwoWay.Size = new System.Drawing.Size(57, 17);
            this.radio_btn_TwoWay.TabIndex = 20;
            this.radio_btn_TwoWay.TabStop = true;
            this.radio_btn_TwoWay.Text = "Return";
            this.radio_btn_TwoWay.UseVisualStyleBackColor = true;
            // 
            // radio_btn_Oneway
            // 
            this.radio_btn_Oneway.AutoSize = true;
            this.radio_btn_Oneway.Location = new System.Drawing.Point(104, 81);
            this.radio_btn_Oneway.Name = "radio_btn_Oneway";
            this.radio_btn_Oneway.Size = new System.Drawing.Size(70, 17);
            this.radio_btn_Oneway.TabIndex = 19;
            this.radio_btn_Oneway.TabStop = true;
            this.radio_btn_Oneway.Text = "One Way";
            this.radio_btn_Oneway.UseVisualStyleBackColor = true;
            // 
            // lable_Firstname
            // 
            this.lable_Firstname.AutoSize = true;
            this.lable_Firstname.Font = new System.Drawing.Font("Algerian", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_Firstname.Location = new System.Drawing.Point(157, 22);
            this.lable_Firstname.Name = "lable_Firstname";
            this.lable_Firstname.Size = new System.Drawing.Size(538, 35);
            this.lable_Firstname.TabIndex = 17;
            this.lable_Firstname.Text = "PIA Ticket Resevation System";
            this.lable_Firstname.Click += new System.EventHandler(this.lable_Firstname_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 28);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(97, 35);
            this.btn_Back.TabIndex = 31;
            this.btn_Back.Text = "BACK";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Flight Type";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "ALL",
            "Economy",
            "Business"});
            this.comboBox5.Location = new System.Drawing.Point(104, 212);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 34;
            // 
            // btn_SearchFight
            // 
            this.btn_SearchFight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_SearchFight.Location = new System.Drawing.Point(732, 192);
            this.btn_SearchFight.Name = "btn_SearchFight";
            this.btn_SearchFight.Size = new System.Drawing.Size(139, 41);
            this.btn_SearchFight.TabIndex = 18;
            this.btn_SearchFight.Text = "Search Fight";
            this.btn_SearchFight.UseVisualStyleBackColor = false;
            this.btn_SearchFight.Click += new System.EventHandler(this.btn_SearchFight_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 253);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(892, 241);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ReserveFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 506);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label_Arrival);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label_Departure);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.radio_btn_TwoWay);
            this.Controls.Add(this.radio_btn_Oneway);
            this.Controls.Add(this.btn_SearchFight);
            this.Controls.Add(this.lable_Firstname);
            this.Name = "ReserveFlights";
            this.Text = "ReserveFlights";
            this.Load += new System.EventHandler(this.ReserveFlights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label_Arrival;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label_Departure;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radio_btn_TwoWay;
        private System.Windows.Forms.RadioButton radio_btn_Oneway;
        private System.Windows.Forms.Label lable_Firstname;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button btn_SearchFight;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}