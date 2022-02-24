using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;


namespace VendingMachine_21017207
{
    public partial class AddProduct : Form
    {

        OperatorManagement product_transfer;
        public AddProduct(OperatorManagement products)
        {
            product_transfer = products;
            InitializeComponent();

        }
        public AddProduct(main_Menu products)
        {

        }
        private void AddProduct_Load(object sender, EventArgs e)
        {

        }
      
  
    private void AddBtn_Click(object sender, EventArgs e)
        {
            List<VendingProperties> VP = new List<VendingProperties>();
            VendingProperties product = new VendingProperties();
            XmlSerializer serializer = new XmlSerializer(typeof(List<VendingProperties>));
            OperatorManagement.product_list.Add(product);
            product.productName = ProductName.Text;
            product.price = Convert.ToDouble(PriceTxtBox.Text);
            product.stock = Convert.ToInt32(TxtBoxStock.Text);
            OperatorManagement.product_list.Sort((x, y) => x.productName.CompareTo(y.productName));
            MessageBox.Show("You successfully added a product");
            foreach (var item in OperatorManagement.product_list)
            {
              
                Stream stream = File.OpenWrite(Environment.CurrentDirectory + "\\product.txt");
              
                serializer.Serialize(stream, OperatorManagement.product_list);
                stream.Close();
            }
            using (FileStream reader = new FileStream(Environment.CurrentDirectory + "\\product.txt", FileMode.Open, FileAccess.Read))
            {

                // Call the Deserialize method to restore the object's state.
                VP = (List<VendingProperties>)serializer.Deserialize(reader);

            }

            this.Hide();
            product_transfer.Show();




        }

        private void TxtBoxStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void PriceTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductName_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainMenuBtn_Click(object sender, EventArgs e)
        {
            main_Menu mains =new main_Menu();
            mains.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

      
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
