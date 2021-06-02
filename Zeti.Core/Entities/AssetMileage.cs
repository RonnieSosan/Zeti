using System;
using System.Collections.Generic;
using System.Text;

namespace Zeti.Core.Entities
{
    public class AssetMileage
    {
        public string MileageId { get; set; }
        public Asset Asset { get; set; }
        public AssetOperator Operator { get; set; }
        public decimal Miles { get; set; }
        public DateTime Date { get; set; }
    }
}
