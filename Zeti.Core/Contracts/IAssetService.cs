using System;
using System.Collections.Generic;
using System.Text;
using Zeti.Core.Entities;
using Zeti.Core.ServiceEntities;

namespace Zeti.Core.Contracts
{
    public interface IAssetService
    {
        public Asset GetAssetById(string Id);
        public ICollection<Asset> GetAllAssets(GetAllAssetsRequest Query);
    }
}
