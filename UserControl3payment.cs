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
    public partial class UserControl3payment : UserControl
    {
        public UserControl3payment()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl4 CashPayment = new UserControl4();
            this.Show();
            CashPayment.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(value: CashPayment);
            CashPayment.BringToFront();
        }
    }
}
