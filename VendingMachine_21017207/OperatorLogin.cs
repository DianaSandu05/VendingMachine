using System;
using System.Windows.Forms;

namespace VendingMachine_21017207
{
    public partial class OperatorLogin : Form
    {

        public OperatorLogin(main_Menu product)
        {
            InitializeComponent();
        }

        public OperatorLogin(OperatorManagement oM)
        {
        }

        public OperatorLogin()
        {
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            String username = usernameTxtBox.Text;
            String password = passwordTxtBox.Text;
            if ((username == "DS") && (password == "1234"))
            {
                OperatorManagement oM = new OperatorManagement(this);
                oM.Show();
                this.Hide();

            }
            else if (username == "" || password == "")
                MessageBox.Show("You need to fill the id as well as password");
            else
                MessageBox.Show("You enter a wrong password or username! Please try again!");

        }

        private void OperatorLogin_Load(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            main_Menu transfer = new main_Menu();
            transfer.Show();
            this.Hide();
        }
    }
}
