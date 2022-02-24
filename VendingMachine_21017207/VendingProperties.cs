using System.Runtime.Serialization;


namespace VendingMachine_21017207
{
    [DataContract]
    public class VendingProperties
    {
        [DataMember]
        public string productName { get; set; }
        public int stock { get; set; }
        public double price { get; set; }
        public double balance { get; set; } 
        public double coinsInserted { get; set; } 
        public double balanceDue { get; set; }     
        public double AvailableCoins { get; set; } = 10; //AvailableCoins should be the balance after the operator removed money and he lef
        public double moneyRemoved { get; set; } 
        public double MoneyTotal { get; set; }  // MoneyTotal shows the total amount of money from vending machine
        public int quantity { get; set; }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Product Name", productName);
            info.AddValue("Price", price);
            info.AddValue("Stock", stock);
            info.AddValue("AvailableCoins", AvailableCoins);
            info.AddValue("MoneyTotal", MoneyTotal);
            info.AddValue("moneyRemoved", moneyRemoved);
            info.AddValue("balanceDue", balanceDue);
            info.AddValue("coinsInserted", coinsInserted);
            info.AddValue("balance", balance);
            info.AddValue("quantity", quantity);
        }
        public VendingProperties(SerializationInfo info, StreamingContext context)
        {
            productName = (string)info.GetValue("Product Name", typeof(string));
            price = (double)info.GetValue("Price", typeof(double));
            stock = (int)info.GetValue("Stock", typeof(int));
            AvailableCoins = (double)info.GetValue("AvailableCoins", typeof(double));
            MoneyTotal = (double)info.GetValue("MoneyTotal", typeof(double));
            moneyRemoved = (double)info.GetValue("moneyRemoved", typeof(double));
            balance = (double)info.GetValue("balance", typeof(double));
            coinsInserted = (double)info.GetValue("coinsInserted", typeof(double));
            balanceDue = (double)info.GetValue("balanceDue", typeof(double));
            quantity = (int)info.GetValue("quantity", typeof (int));
        }
        public VendingProperties()
        {
        }
    }
}
