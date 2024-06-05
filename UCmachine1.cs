using System;
using System.Collections;
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
    public partial class UCmachine1 : UserControl
    {
        public UCmachine1()
        {
            InitializeComponent();
        }

        private void BackButton1_Click(object sender, EventArgs e)
        {
            UCmachinelist back = new UCmachinelist();
            this.Show();
            back.Dock = DockStyle.Fill;
            panelmachine.Controls.Clear();
            panelmachine.Controls.Add(back);
            back.BringToFront();
        }

        private void panelmachine_Paint(object sender, PaintEventArgs e)
        {
           
            ArrayList ChooseAction = new ArrayList();
            {

                ChooseAction.Add("On Process");              
                ChooseAction.Add("Reserved");
               
           };

            foreach (string chooseAction in ChooseAction)
            {
                chooseAct.Items.Add(chooseAction);
            }


          
        }
    }
}
