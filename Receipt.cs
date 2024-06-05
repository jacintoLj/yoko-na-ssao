using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LaundryManagementSystem
{
    public partial class Receipt : Form
    {
       
        public Receipt()
        {
      
            InitializeComponent();
        

        }

        public object NameReceipt { get; private set; }

        private void Receipt_Load(object sender, EventArgs e)
        {
            UserControl4 user = new UserControl4();
            string text = CName.Text;
            user.NameReceipt.Text = text;
        }

        private void OkayButton_Click(object sender, EventArgs e)
        {
            UserControl4 user = new UserControl4();
            user.Show();
            this.Hide();
        }
    }
}
