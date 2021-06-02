using System;
using System.Collections.Generic;
using System.Text;

namespace Zeti.Core.Entities
{
    public class AssetOperator
    {
        //The uniwue identifier of the asset owner
        public string OperatorID { get; set; }
        //The name used to identify the asset owner
        public string OperatorName { get; set; }
        //The list of assets owned by this Operator
        public ICollection<Asset> Assets { get; set; }
    }
}
