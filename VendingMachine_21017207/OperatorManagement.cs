using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using DynamicData;

namespace VendingMachine_21017207
{
    public partial class OperatorManagement : Form
    {
        main_Menu product_transfer;
        VendingProperties product;
        
        static public List<VendingProperties> product_list;

        public OperatorManagement(OperatorLogin operatorLogin)
        {
            InitializeComponent();

            product_list = new List<VendingProperties>();
            
        }
        public OperatorManagement(AddProduct product)
        {

        }

        public OperatorManagement(main_Menu products)
        {
            product_transfer = products;
            product = new VendingProperties();
        }
      

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void OperatorManagement_Load(object sender, EventArgs e)
        {

        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            Boolean product_found = false;           
            XmlSerializer serializer = new XmlSerializer(typeof(List<VendingProperties>));
            using (FileStream stream = new FileStream(Environment.CurrentDirectory + "\\product.txt", FileMode.Open, FileAccess.Read))
            {
                // Call the Deserialize method to restore the object's state.
                OperatorManagement.product_list = (List<VendingProperties>)serializer.Deserialize(stream);

            }          
                foreach (var product in OperatorManagement.product_list)
                {
                if (product.MoneyTotal != 0)
                {
                    OperatorManagement.product_list.Where(x => SearchTxtBox.Text == x.productName && product.MoneyTotal != 0);
                    product_found = true;
                    // SearchTxtBox.Text = product.productName;
                    TxtBoxPrice.Text = product.price.ToString();
                    TxtBoxStock.Text = product.stock.ToString();
                    balanceDueTxtBox.Text = product.balanceDue.ToString();
                    balanceTxtBox.Text = product.balance.ToString();
                    moneyRemovedTxtBox.Text = product.moneyRemoved.ToString();
                    moneyTotalTxtBox.Text = product.MoneyTotal.ToString();
                    coinsAvailableTxtBox.Text = product.AvailableCoins.ToString();
                    coinsInsertedTxtBox.Text = product.coinsInserted.ToString();
                    quantityTxtBox.Text = product.quantity.ToString();

                }
                else if (product == null)
                {
                    product_found = false;
                    MessageBox.Show("Sorry no record found");
                }
            }
                
          

        }

        private void TxtBoxStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }


        private void BtnUpdate_Save_Click(object sender, EventArgs e)
        {
           //I created an instance of Vending properties
           VendingProperties product = new VendingProperties();
            //I created an instance of XMLSerializer of type List<VendingProperties>
            XmlSerializer serializer = new XmlSerializer(typeof(List<VendingProperties>));
            using (FileStream reader = new FileStream(Environment.CurrentDirectory + "\\product.txt", FileMode.Open, FileAccess.Read))
            {

                // Call the Deserialize method to restore the object's state.
                OperatorManagement.product_list = (List<VendingProperties>)serializer.Deserialize(reader);
                OperatorManagement.product_list.Remove(product);
            }
           
                if (product.productName == Convert.ToString(SearchTxtBox.Text))
                {
                product.stock = Convert.ToInt32(TxtBoxStock.Text);
                product.price = Convert.ToDouble(TxtBoxPrice.Text);
                product.quantity = Convert.ToInt32(quantityTxtBox.Text);
                product.moneyRemoved = Convert.ToDouble(moneyRemovedTxtBox.Text);
                product.MoneyTotal = Convert.ToDouble(moneyTotalTxtBox.Text);
                product.AvailableCoins = Convert.ToDouble(coinsAvailableTxtBox.Text);
                product.coinsInserted = Convert.ToDouble(coinsInsertedTxtBox.Text);
                product.balance = Convert.ToDouble(balanceTxtBox.Text);
                product.productName = SearchTxtBox.Text;
                product.balanceDue = Convert.ToDouble(balanceDueTxtBox.Text);

                OperatorManagement.product_list.Add(product);
                    Stream stream = File.OpenWrite(Environment.CurrentDirectory + "\\product.txt");
                   
                     serializer.Serialize(stream, OperatorManagement.product_list);
                   stream.Close();
                    MessageBox.Show("The product was updated successfully!");
            }
         

            main_Menu transfer = new main_Menu();
            transfer.Show();
            this.Hide();
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct(this);
            addProduct.Show();
            this.Hide();
        }

        private void MainMenuBtn_Click(object sender, EventArgs e)
        {
            main_Menu transfer = new main_Menu();
            transfer.Show();
            this.Hide();
        }

        private void generateReport_Click(object sender, EventArgs e)
        {
            reports report_transfer = new reports();
            report_transfer.Show();
            this.Hide();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

       
       
          


        private void button2_Click(object sender, EventArgs e)
        {
            reportsSortedByStock rsbs = new reportsSortedByStock();
            rsbs.Show();
            this.Hide();
        }
    }
}
