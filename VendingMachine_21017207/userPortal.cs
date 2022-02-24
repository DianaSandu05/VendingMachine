using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace VendingMachine_21017207
{
    
    public partial class userPortal : Form
    {
        OperatorManagement product_transfer;
        public userPortal(main_Menu product)
        {
            InitializeComponent();
          
        }
        private void buyBtn_Click(object sender, EventArgs e)
        {
            VendingProperties product = new VendingProperties();
            XmlSerializer serializer = new XmlSerializer(typeof(List<VendingProperties>));
            if (product.productName == Convert.ToString(comboBox1.SelectedItem))
            {
                Stream stream = File.OpenWrite(Environment.CurrentDirectory + "\\product.txt");
                serializer.Serialize(stream, OperatorManagement.product_list);
                stream.Close();
                using (FileStream reader = new FileStream(Environment.CurrentDirectory + "\\product.txt", FileMode.Open, FileAccess.Read))
                {
                    // Call the Deserialize method to restore the object's state.
                    OperatorManagement.product_list = (List<VendingProperties>)serializer.Deserialize(reader);                 
                }
                var obj = OperatorManagement.product_list.FindLast(x => product.productName == comboBox1.SelectedItem);
                if(obj == null)
                {
                    OperatorManagement.product_list.Remove(obj);
                }              
            }
            product.balanceDue = Convert.ToDouble(TxtBoxDueBalance.Text);
            product.balance = Convert.ToDouble(TxtBoxBalance.Text);
            if (Convert.ToDouble(TxtBoxCoinInserted.Text) >= product.balanceDue && product.balance > 0)
            {
                product.productName = Convert.ToString(comboBox1.SelectedItem);
                product.quantity = Convert.ToInt32(QuantityComboBox.SelectedItem);
                product.stock = Convert.ToInt32(TxtBoxStock.Text) - Convert.ToInt32(QuantityComboBox.SelectedItem);
                product.price = Convert.ToDouble(TxtBoxPrice.Text);
                product.balance = Convert.ToDouble(TxtBoxBalance.Text);
                product.balanceDue = Convert.ToDouble(TxtBoxDueBalance.Text);
                product.coinsInserted = Convert.ToDouble(TxtBoxCoinInserted.Text);
                product.MoneyTotal = product.AvailableCoins + (product.coinsInserted - product.balance);
                product.moneyRemoved = product.balanceDue + (product.coinsInserted - product.balanceDue);
                OperatorManagement.product_list.Add(product);
                OperatorManagement.product_list.Sort((x, y) => x.productName.CompareTo(y.productName));
                foreach (var item in OperatorManagement.product_list)
                {
                    Stream stream = File.OpenWrite(Environment.CurrentDirectory + "\\product.txt");
                    serializer.Serialize(stream, OperatorManagement.product_list);
                    stream.Close();
                }
                MessageBox.Show("Item purchased successfully!" + product.balance + "pounds are your change");
                main_Menu menus = new main_Menu();
                menus.Show();
                this.Hide();
            }
           else if (Convert.ToDouble(TxtBoxCoinInserted.Text) < product.balanceDue && product.balance < 0)
            {
                product.moneyRemoved = Convert.ToDouble(TxtBoxCoinInserted.Text);
                MessageBox.Show("Ooops! Insuficient funds!" + "The cost of the products is " + product.balanceDue);
                main_Menu mainMenu = new main_Menu();
                mainMenu.Show();
                this.Close();

            }

        }
        private void priceTxtBox_TextChanged(object sender, EventArgs e)
        {

        }


        private void TotalCost_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void userPortal_Load(object sender, EventArgs e)
        {
          

            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            
            XmlSerializer serializer = new XmlSerializer(typeof(List<VendingProperties>));
            using (FileStream stream = new FileStream(Environment.CurrentDirectory + "\\product.txt", FileMode.Open, FileAccess.Read))
            {

                // Call the Deserialize method to restore the object's state.
                OperatorManagement.product_list = (List<VendingProperties>)serializer.Deserialize(stream);
               
            }

            foreach (var product in OperatorManagement.product_list)
                {
                    if (product.productName == Convert.ToString(comboBox1.SelectedItem))
                    {
                        TxtBoxPrice.Text = product.price.ToString();
                        TxtBoxStock.Text = product.stock.ToString();
                        TxtBoxDueBalance.Text = product.price.ToString();
                    if (QuantityComboBox.SelectedIndex == 0)
                    {
                        TxtBoxDueBalance.Text = product.price.ToString();
                    }
                    else if (QuantityComboBox.SelectedIndex == 1)
                    {
                        TxtBoxDueBalance.Text = (product.price + product.price).ToString();
                    }
                    else if (QuantityComboBox.SelectedIndex == 2)
                    {
                        TxtBoxDueBalance.Text = (product.price + product.price + product.price).ToString();
                    }
                    else

                    break;

                    }
                      else if(product.productName == null)
                     {
                     MessageBox.Show("Sorry no record found");
                     }
                       
                }
            }



        

        private void TxtBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn005p_Click(object sender, EventArgs e)
        {

        }

        private void TxtBoxCoinInserted_TextChanged(object sender, EventArgs e)
        {
            VendingProperties product = new VendingProperties();
            product.coinsInserted = Convert.ToDouble(TxtBoxCoinInserted.Text);
            product.price = Convert.ToDouble(TxtBoxDueBalance.Text);
            
            if (product.price != null)
            {
                product.balance = product.coinsInserted - product.price;
            }
            TxtBoxBalance.Text = product.balance.ToString();
        }

       

        private void TxtBoxDueBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtBoxBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void BtnMainMenu_Click(object sender, EventArgs e)
        {
            main_Menu main_Menu = new main_Menu();
            main_Menu.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
