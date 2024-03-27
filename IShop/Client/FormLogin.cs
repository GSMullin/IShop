using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IShop.Client
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();

            //this.PassField.AutoSize = false;
            //this.PassField.Size = new Size(this.PassField.Size.Width, 64);
        }

        private void BtnRegistration_Click(object sender, EventArgs e)
        {
            new FormRegistration().ShowDialog();
        }
                
    }
}
