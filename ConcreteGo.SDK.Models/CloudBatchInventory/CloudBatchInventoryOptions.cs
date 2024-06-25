using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteGo.SDK.Models.CloudBatchInventory
{
    public class CloudBatchInventoryOptions
    {
        public List<int> ItemIDs { get; set; } = new List<int>();
        public List<string> ItemCodes { get; set; } = new List<string>();
        public List<int> PlantIDs { get; set; } = new List<int>();
        public List<string> PlantCodes { get; set; } = new List<string>();
        public List<int> LocationIDs { get; set; } = new List<int>();
        public List<string> LocationCodes { get; set; } = new List<string>();
        public DateTime? FromTransactionDate { get; set; }
        public DateTime? ToTransactionDate { get; set; }
        //SHIPMENT|USAGE|ADJUSTMENT|RECONCILIATION
        public List<string> TransactionTypes { get; set; } = new List<string>();
    }
}
