using System;
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
    public partial class FormSpecialRequests : Form
    {
        private bool Saved = false;
        
        public FormSpecialRequests()
        {
            InitializeComponent();
        }

        private void FormSpecialRequests_Load(object sender, EventArgs e)
        {
            txtRequests.Text = Tag.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Store the user's special requests in this form's Tag property
            // The form that created this form will be able to access the data
            Tag = txtRequests.Text;
            DialogResult = DialogResult.OK;
            Close();  // Initiate Form close process, to return control to form that opened this one
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close(); // Initiate form close process
        }

        private void frmSpecialRequest_Close(object sender, FormClosingEventArgs e) 
        {
           bool userMadeChanges = Tag.ToString () != txtRequests.Text;

           if (!Saved && userMadeChanges)
            {
                DialogResult closeResult = MessageBox.Show("Your changes are not saved, close anyway?",
                     "Unsaved Chages",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Warning
                 );

                if (closeResult == DialogResult.No) 
                {
                    e.Cancel = true; // prevent form closing
                }
            }
        }

        private void txtRequests_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
