namespace TicketReservationApplication
{
    partial class MainForm
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
            this.btn_AdminPanal = new System.Windows.Forms.Button();
            this.btn_UserPanel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_AdminPanal
            // 
            this.btn_AdminPanal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_AdminPanal.Location = new System.Drawing.Point(196, 130);
            this.btn_AdminPanal.Margin = new System.Windows.Forms.Padding(0);
            this.btn_AdminPanal.Name = "btn_AdminPanal";
            this.btn_AdminPanal.Size = new System.Drawing.Size(96, 58);
            this.btn_AdminPanal.TabIndex = 0;
            this.btn_AdminPanal.Text = "Admin Panel";
            this.btn_AdminPanal.UseVisualStyleBackColor = false;
            this.btn_AdminPanal.Click += new System.EventHandler(this.btn_AdminPanal_Click);
            // 
            // btn_UserPanel
            // 
            this.btn_UserPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_UserPanel.Location = new System.Drawing.Point(315, 185);
            this.btn_UserPanel.Margin = new System.Windows.Forms.Padding(0);
            this.btn_UserPanel.Name = "btn_UserPanel";
            this.btn_UserPanel.Size = new System.Drawing.Size(99, 56);
            this.btn_UserPanel.TabIndex = 2;
            this.btn_UserPanel.Text = "User Panel";
            this.btn_UserPanel.UseVisualStyleBackColor = false;
            this.btn_UserPanel.Click += new System.EventHandler(this.btn_UserPanel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "LOGIN AS:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(102, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(422, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "PIA TICKET RESERVATION SYSTEM";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_UserPanel);
            this.Controls.Add(this.btn_AdminPanal);
            this.Name = "MainForm";
            this.Text = "Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AdminPanal;
        private System.Windows.Forms.Button btn_UserPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}