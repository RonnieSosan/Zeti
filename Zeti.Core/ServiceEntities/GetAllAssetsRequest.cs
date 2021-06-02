using System;
using System.Collections.Generic;
using System.Text;
using Zeti.Core.Utilities;

namespace Zeti.Core.ServiceEntities
{
    public class GetAllAssetsRequest
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public AssetType? Type { get; set; }
    }
}
