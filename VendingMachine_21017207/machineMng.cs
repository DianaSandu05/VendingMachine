using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine_21017207
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buyBtn_Click(object sender, EventArgs e)
        {
            buyProducts buyProd = new buyProducts();
            buyProd.Show();
        }

        private void machineMng_Click(object sender, EventArgs e)
        {
            ManageMachine mngMachine = new ManageMachine();
            mngMachine.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
