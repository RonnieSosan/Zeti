using System;
using System.Collections.Generic;
using System.Text;

namespace Zeti.Core.ServiceEntities
{
    public class GetAllOperatorsRequest : GetAllAssetsRequest
    {
        public string OperatorName { get; set; }
    }
}
