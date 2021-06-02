using System;
using System.Collections.Generic;
using System.Linq;
using Zeti.Core.Entities;
using Zeti.Core.Repository;

namespace Zeti.Persistence
{
    public class AssetRepository : IAssetRepository
    {
        private ICollection<Asset> Assets = new List<Asset>
        {
            new Asset {
                AssetId = "829fj",
                AssetName = "Mercades_01",
                AssetType = Core.Utilities.AssetType.Coupe,
                AssetReference = "CBDH 789",
                Billing = "Miles",
                Brand = "Mercedes-Benz",
                Model = "C200",
                UnitCost = 0.207M

            },
            new Asset {
                AssetId = "3g89j",
                AssetName = "Mercades_02",
                AssetType = Core.Utilities.AssetType.Coupe,
                AssetReference = "CBDH 789",
                Billing = "Miles",
                Brand = "Mercedes-Benz",
                Model = "C200",
                UnitCost = 0.207M

            }
        };
        public Asset Get(string id)
        {
            var asset = Assets.Where(x => x.AssetId == id).FirstOrDefault();
            return asset;
        }

        public IQueryable<Asset> GetAll()
        {
            var assetsToReturn = Assets.AsQueryable();
            return assetsToReturn;
        }
    }
}
