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
    public partial class Machine2 : Form
    {
        public Machine2()
        {
            InitializeComponent();
        }
        private void Machine2_Load(object sender, EventArgs e)
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

        private void confirmButton1_Click(object sender, EventArgs e)
        {
            MachineList machineList = new MachineList();
            machineList.Show();
            this.Hide();

        }
        private void chooseAct_SelectedIndexChanged(object sender, EventArgs e)
        {
            //asdasdasdasd//
        }
    }
}
