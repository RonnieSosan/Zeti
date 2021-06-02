using System;
using Zeti.Core.Utilities;

namespace Zeti.Core.Entities
{
    //This identifies the asset owned by the operator 
    public class Asset
    {
        //unique Identifier of the reference
        public string AssetId { get; set; }
        //Name used to identify the asset
        public string AssetName { get; set; }
        //A unique code used to identify the asset
        public string AssetReference { get; set; }
        //The category of the asset
        public AssetType AssetType { get; set; }
        //The brand associated witht he asset
        public string Brand { get; set; }
        //The model specified by the brand for this asset
        public string Model { get; set; }
        //The type of billing attached to the asset i.e Miles, Kilometres
        public string Billing { get; set; }
        //The unit cost attached to the asset per billing
        public decimal UnitCost { get; set; }
        public bool Active { get; set; }
    }
}
