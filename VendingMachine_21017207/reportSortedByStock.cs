using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace VendingMachine_21017207
{
    public partial class reportsSortedByStock : Form
    {
       
        public reportsSortedByStock()
        {
            InitializeComponent();
            
            VendingProperties product = new VendingProperties();
            XmlSerializer serializer = new XmlSerializer(typeof(List<VendingProperties>));
            OperatorManagement.product_list.Sort((x, y) => x.stock.CompareTo(y.stock));
            using (FileStream reader = new FileStream(Environment.CurrentDirectory + "\\product.txt", FileMode.Open, FileAccess.Read))
            {
                
                OperatorManagement.product_list = (List<VendingProperties>)serializer.Deserialize(reader);              
            }

           dataGridView1.DataSource = OperatorManagement.product_list;
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
           
        }

        private void operatorMenuBtn_Click(object sender, EventArgs e)
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
