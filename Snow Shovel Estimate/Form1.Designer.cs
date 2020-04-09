namespace Snow_Shovel_Estimate
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblDateRequested = new System.Windows.Forms.Label();
            this.dteAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoCorner = new System.Windows.Forms.RadioButton();
            this.rdoSingle = new System.Windows.Forms.RadioButton();
            this.btnGetEstimate = new System.Windows.Forms.Button();
            this.grox2 = new System.Windows.Forms.GroupBox();
            this.lblSpecialRequests = new System.Windows.Forms.Label();
            this.btnAddSpecialRequests = new System.Windows.Forms.Button();
            this.lblEstimatedPrice = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(230, 33);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(517, 22);
            this.txtName.TabIndex = 0;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(230, 93);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(517, 22);
            this.txtAddress.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Location = new System.Drawing.Point(23, 38);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(114, 23);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // lblAddress
            // 
            this.lblAddress.Location = new System.Drawing.Point(23, 96);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 23);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "Address";
            // 
            // lblDateRequested
            // 
            this.lblDateRequested.Location = new System.Drawing.Point(23, 159);
            this.lblDateRequested.Name = "lblDateRequested";
            this.lblDateRequested.Size = new System.Drawing.Size(135, 23);
            this.lblDateRequested.TabIndex = 4;
            this.lblDateRequested.Text = "Date Requested";
            // 
            // dteAppointmentDate
            // 
            this.dteAppointmentDate.Location = new System.Drawing.Point(230, 160);
            this.dteAppointmentDate.Name = "dteAppointmentDate";
            this.dteAppointmentDate.Size = new System.Drawing.Size(517, 22);
            this.dteAppointmentDate.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoCorner);
            this.groupBox1.Controls.Add(this.rdoSingle);
            this.groupBox1.Location = new System.Drawing.Point(26, 223);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 100);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type of Sidewalk";
            // 
            // rdoCorner
            // 
            this.rdoCorner.AutoSize = true;
            this.rdoCorner.Location = new System.Drawing.Point(17, 58);
            this.rdoCorner.Name = "rdoCorner";
            this.rdoCorner.Size = new System.Drawing.Size(72, 21);
            this.rdoCorner.TabIndex = 1;
            this.rdoCorner.Text = "Corner";
            this.rdoCorner.UseVisualStyleBackColor = true;
            // 
            // rdoSingle
            // 
            this.rdoSingle.AutoSize = true;
            this.rdoSingle.Checked = true;
            this.rdoSingle.Location = new System.Drawing.Point(17, 22);
            this.rdoSingle.Name = "rdoSingle";
            this.rdoSingle.Size = new System.Drawing.Size(68, 21);
            this.rdoSingle.TabIndex = 0;
            this.rdoSingle.TabStop = true;
            this.rdoSingle.Text = "Single";
            this.rdoSingle.UseVisualStyleBackColor = true;
            // 
            // btnGetEstimate
            // 
            this.btnGetEstimate.Location = new System.Drawing.Point(26, 377);
            this.btnGetEstimate.Name = "btnGetEstimate";
            this.btnGetEstimate.Size = new System.Drawing.Size(147, 30);
            this.btnGetEstimate.TabIndex = 7;
            this.btnGetEstimate.Text = "Get Estimate";
            this.btnGetEstimate.UseVisualStyleBackColor = true;
            // 
            // grox2
            // 
            this.grox2.Controls.Add(this.lblSpecialRequests);
            this.grox2.Location = new System.Drawing.Point(407, 223);
            this.grox2.Name = "grox2";
            this.grox2.Size = new System.Drawing.Size(241, 100);
            this.grox2.TabIndex = 8;
            this.grox2.TabStop = false;
            this.grox2.Text = "Special Requests";
            // 
            // lblSpecialRequests
            // 
            this.lblSpecialRequests.AutoEllipsis = true;
            this.lblSpecialRequests.Location = new System.Drawing.Point(19, 22);
            this.lblSpecialRequests.Name = "lblSpecialRequests";
            this.lblSpecialRequests.Size = new System.Drawing.Size(190, 23);
            this.lblSpecialRequests.TabIndex = 0;
            this.lblSpecialRequests.Text = "No special requests entered";
            // 
            // btnAddSpecialRequests
            // 
            this.btnAddSpecialRequests.Location = new System.Drawing.Point(424, 341);
            this.btnAddSpecialRequests.Name = "btnAddSpecialRequests";
            this.btnAddSpecialRequests.Size = new System.Drawing.Size(192, 30);
            this.btnAddSpecialRequests.TabIndex = 9;
            this.btnAddSpecialRequests.Text = "Add Special Requests";
            this.btnAddSpecialRequests.UseVisualStyleBackColor = true;
            this.btnAddSpecialRequests.Click += new System.EventHandler(this.btnAddSpecialRequests_Click);
            // 
            // lblEstimatedPrice
            // 
            this.lblEstimatedPrice.Location = new System.Drawing.Point(261, 384);
            this.lblEstimatedPrice.Name = "lblEstimatedPrice";
            this.lblEstimatedPrice.Size = new System.Drawing.Size(144, 23);
            this.lblEstimatedPrice.TabIndex = 10;
            this.lblEstimatedPrice.Text = "Estimated Price";
            this.lblEstimatedPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEstimatedPrice.Click += new System.EventHandler(this.lblEstimatedPrice_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(442, 385);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(157, 22);
            this.txtPrice.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblEstimatedPrice);
            this.Controls.Add(this.btnAddSpecialRequests);
            this.Controls.Add(this.grox2);
            this.Controls.Add(this.btnGetEstimate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dteAppointmentDate);
            this.Controls.Add(this.lblDateRequested);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Snow Shovel Estimate";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblDateRequested;
        private System.Windows.Forms.DateTimePicker dteAppointmentDate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoCorner;
        private System.Windows.Forms.RadioButton rdoSingle;
        private System.Windows.Forms.Button btnGetEstimate;
        private System.Windows.Forms.GroupBox grox2;
        private System.Windows.Forms.Label lblSpecialRequests;
        private System.Windows.Forms.Button btnAddSpecialRequests;
        private System.Windows.Forms.Label lblEstimatedPrice;
        private System.Windows.Forms.TextBox txtPrice;
    }
}

