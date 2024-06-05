using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcreteGo.SDK.Models.Tickets
{
    public class TicketRequestOptions
    {
        public DateTime? FromOrderDate { get; set; }
        public DateTime? ToOrderDate { get; set; }
        public DateTime? FromTicketTime { get; set; }
        public DateTime? ToTicketTime { get; set; }
        public DateTime? FromUpdateTime { get; set; }
        public DateTime? ToUpdateTime { get; set; }
        public DateTime? FromLoadTime { get; set; }
        public DateTime? ToLoadTime { get; set; }
        public DateTime? FromCreatedDate { get; set; }
        public DateTime? ToCreatedDate { get; set; }
        public List<int>? OrderIDs { get; set; }
        public List<int>? TicketIDs { get; set; }
        public List<string>? TicketCodes { get; set; }
        public List<string>? PlantCodes { get; set; }
        public List<string>? CustomerCodes { get; set; }
        public List<string>? ProjectCodes { get; set; }
        public List<string>? MixCodes { get; set; }
        public bool? ListOnly { get; set; }
        public string? OrderBy { get; set; }
        public bool? Reviewed { get; set; }
        public bool? IncludeRemovedTicket { get; set; }
        public bool? IncludeSuspendedTicket { get; set; }
        public bool? IncludeInvoicedTicket { get; set; }
        public bool? WithBatchWeightsOnly { get; set; }
        public List<string>? IncludeRetElements { get; set; }
        public bool? MarkOrderAsInvoiced { get; set; }
        public bool? MarkTicketAsInvoiced { get; set; }
        public bool? FailOnOrderLock { get; set; }

    }
}
