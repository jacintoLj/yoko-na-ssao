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
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void computeChange_Click(object sender, EventArgs e)
        {

            
            double recievePayment = double.Parse(RPayment.Text);
            double totalBalance = double.Parse(textBox1.Text);
            double change = (recievePayment) - (totalBalance);
            label5.Text = RPayment.Text;
            label6.Text = textBox1.Text;
            label7.Text = Convert.ToString(change);
            Receipt receipt = new Receipt();
            receipt.Show();
            



 
            

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserControl3payment UserControl3payment = new UserControl3payment();
            this.Show();
            UserControl3payment.Dock = DockStyle.Fill;
            panel2.Controls.Clear();
            panel2.Controls.Add(UserControl3payment);
            UserControl3payment.BringToFront();
        }

        private void NameReceipt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
