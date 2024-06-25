using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteGo.SDK.Models.InventoryTransactions
{
    public class InventoryTransactionOptions
    {
        public List<int> IDs { get; set; } = new List<int>();
        public List<string> DocumentNumbers { get; set; } = new List<string>();
        public List<int> LocationIDs { get; set; } = new List<int>();
        public List<string> LocationCodes { get; set; } = new List<string>();
        public DateTime? FromTransactionDate { get; set; }
        public DateTime? ToTransactionDate { get; set; }
        //RAWMATERIALRECEIPT|PURCHASEORDERRECEIPT|USAGE|TRANSFER|ITEMCONVERSION|QUANTITYADJUSTMENT
        public List<string> TransactionTypes { get; set; } = new List<string>();
        //QUANTITYPOSTED|RELEASED|ONHOLD|POSTED|ABORTEDORREJECTED
        public List<string> PostStatuses { get; set; } = new List<string>();
    }
}
