namespace TicketReservationApplication
{
    partial class AdminDashboard
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
            this.btn_AddFlight = new System.Windows.Forms.Button();
            this.btn_ViewFlights = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_AddFlight
            // 
            this.btn_AddFlight.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_AddFlight.Location = new System.Drawing.Point(129, 86);
            this.btn_AddFlight.Name = "btn_AddFlight";
            this.btn_AddFlight.Size = new System.Drawing.Size(119, 65);
            this.btn_AddFlight.TabIndex = 0;
            this.btn_AddFlight.Text = "Add Flight";
            this.btn_AddFlight.UseVisualStyleBackColor = false;
            this.btn_AddFlight.Click += new System.EventHandler(this.btn_AddFlight_Click);
            // 
            // btn_ViewFlights
            // 
            this.btn_ViewFlights.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_ViewFlights.Location = new System.Drawing.Point(332, 86);
            this.btn_ViewFlights.Name = "btn_ViewFlights";
            this.btn_ViewFlights.Size = new System.Drawing.Size(118, 65);
            this.btn_ViewFlights.TabIndex = 1;
            this.btn_ViewFlights.Text = "View Flights";
            this.btn_ViewFlights.UseVisualStyleBackColor = false;
            this.btn_ViewFlights.Click += new System.EventHandler(this.btn_ViewFlights_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.Location = new System.Drawing.Point(12, 12);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(75, 23);
            this.btn_Back.TabIndex = 2;
            this.btn_Back.Text = "BACK";
            this.btn_Back.UseVisualStyleBackColor = true;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "ADMIN PANEL";
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_ViewFlights);
            this.Controls.Add(this.btn_AddFlight);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddFlight;
        private System.Windows.Forms.Button btn_ViewFlights;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Label label1;
    }
}