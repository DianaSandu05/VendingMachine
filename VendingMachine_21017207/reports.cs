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
    public partial class reports : Form
    {
       
        public reports()
        {
            InitializeComponent();
            
            VendingProperties product = new VendingProperties();
            XmlSerializer serializer = new XmlSerializer(typeof(List<VendingProperties>));
         //   OperatorManagement.product_list.OrderBy(item => item.productName, StringComparer.OrdinalIgnoreCase);

             OperatorManagement.product_list.Sort((x, y) => x.productName.CompareTo(y.productName));
            using (FileStream reader = new FileStream(Environment.CurrentDirectory + "\\product.txt", FileMode.Open, FileAccess.Read))
            {
                /*  OperatorManagement.product_list.Sort((x, y) => string.Compare(x.productName, y.productName));
                   var orderedAphabetically = OperatorManagement.product_list.OrderBy(x=>product.productName).ToList();*/

                // Call the Deserialize method to restore the object's state.
                OperatorManagement.product_list = (List<VendingProperties>)serializer.Deserialize(reader);
                
                
                
              
              //  OperatorManagement.product_list = OperatorManagement.product_list.OrderByDescending(x => product.stock).ToList();
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
