using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteGo.SDK.Models.Orders
{
    public class OrderRequestOptions
    {
        public DateTime? FromOrderDate { get; set; }  
        public DateTime? ToOrderDate { get; set; }
        public DateTime? FromUpdateTime { get; set; }
        public DateTime? ToUpdateTime { get; set; }
        public List<int>? OrderIDs { get; set; }
        public List<string>? OrderCodes { get; set; }   
        public List<string>? PlantCodes { get; set; }
        public List<string>? CustomerCodes { get; set; }
        public List<string>? ProjectCodes { get; set; }
        public bool? Reviewed { get; set; }
        public bool? IncludeRemovedOrder { get; set; }
        //PRODUCT, SCHEDULE, SCHEDULELOAD, USERDEFINEDFIELD, ORDERNOTE
        public List<string>? IncludeRetElements { get; set; } 
        public bool? FailOnOrderLock { get; set; }

    }
}
