using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaundryManagementSystem
{
    public partial class UClogout : UserControl
    {
        public UClogout()
        {
            InitializeComponent();
        }

        internal void BringToBack()
        {
            throw new NotImplementedException();
        }

        private void YesLogoutButton_Click(object sender, EventArgs e)
        {
            LoginHomepage home = new LoginHomepage();
            home.Show();
            this.Hide();


        }
    }
}
