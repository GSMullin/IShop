using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IShop.Client;

namespace IShop
{
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }
        
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // FormLoginRegistration formLoginRegistration = new FormLoginRegistration();
            // formLoginRegistration.Show();
            new FormLogin().ShowDialog();
        }
    }
}
