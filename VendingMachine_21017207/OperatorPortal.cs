using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

namespace VendingMachine_21017207
{
    [Serializable()]
    class OperatorPortal : ISerializable
    {
        //Product Name for restocking & report
        public string productName { get; set; }
        // restockNo to get the number of products the operator wants to add
        public int restockNo { get; set; }
        // moneyRemoved to be displayed in the report to show how much money the operator removed
        public int moneyRemoved { get; set; }

        // MoneyTotal shows the total amount of money from vending machine
        public int MoneyTotal { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {

        }
    }
}
