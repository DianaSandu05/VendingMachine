using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace VendingMachine_21017207
{

    public partial class main_Menu : Form
    {

        public main_Menu()
        {
            InitializeComponent();

        }

        public main_Menu(userPortal user)
        {

        }

        private void main_Menu_Load(object sender, EventArgs e) 
        {

         }

      

        private void button1_Click(object sender, EventArgs e)
        {
            OperatorLogin operatorLogin = new OperatorLogin(this);
            this.Hide();
            operatorLogin.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            userPortal UserPortal = new userPortal(this);
            this.Hide();
            UserPortal.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
