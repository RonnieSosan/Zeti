using System;
using System.Collections.Generic;
using System.Text;

namespace Zeti.Core.ServiceEntities
{
    public class BillRequest
    {
        public string OperatorId { get; set; }
        public DateTime startDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
