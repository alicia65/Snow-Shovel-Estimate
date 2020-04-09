﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snow_Shovel_Estimate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Configure earliest and latest dates possible in DateTimPicker
            // Earliest is today, latest in seven days time
            dteAppointmentDate.MinDate = DateTime.Today;
            dteAppointmentDate.MaxDate = DateTime.Today.AddDays(7);
        }

        private void btnAddSpecialRequests_Click(object sender, EventArgs e)
        {
            //Create new FormSpecialRequests form
            FormSpecialRequests frmSpecialRequests = new FormSpecialRequests();
            //Set the Tag to the currect text in lblSpecialRequests
            frmSpecialRequests.Tag = lblSpecialRequests.Text;
            //Show the FormSpecialRequests form as a dialog
            DialogResult specialRequestsResults = frmSpecialRequests.ShowDialog();
        }
    }
}
