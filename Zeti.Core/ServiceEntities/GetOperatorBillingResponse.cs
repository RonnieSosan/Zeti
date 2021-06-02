using System;
using System.Collections.Generic;
using System.Text;
using Zeti.Core.Entities;

namespace Zeti.Core.ServiceEntities
{
    public class GetOperatorBillingResponse : BaseResponse
    {
        public string TotalCost { get; set; }
        public decimal TotalMileage { get; set; }
        public ICollection<Asset> OperatorAssets { get; set; }
    }
}
