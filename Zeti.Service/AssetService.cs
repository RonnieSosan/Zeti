using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zeti.Core.Contracts;
using Zeti.Core.Entities;
using Zeti.Core.Repository;
using Zeti.Core.ServiceEntities;
using Zeti.Persistence;

namespace Zeti.Service
{
    public class AssetService : IAssetService
    {
        protected static readonly IAssetRepository _assetRepository = RepositoryFactory.GetAssetRepository();

        /// <summary>
        /// This Api all the available assets that fits the category
        /// </summary>
        /// <param name="Query"> This request take in a list of variables to determine the final retured collection</param>
        /// <returns>A collection of assets</returns>
        public ICollection<Asset> GetAllAssets(GetAllAssetsRequest Query)
        {
            var availableAssets = _assetRepository.GetAll();

            if (Query.Brand != null && Query.Brand != string.Empty)
                availableAssets = availableAssets.Where(x => x.Brand == Query.Brand);

            if (Query.Model != null && Query.Model != string.Empty)
                availableAssets = availableAssets.Where(x => x.Model == Query.Model);

            if (Query.Type != null)
                availableAssets = availableAssets.Where(x => x.AssetType == Query.Type);

            return availableAssets.ToList();

        }

        /// <summary>
        /// Get an asset by its Id
        /// </summary>
        /// <param name="Id">A string value representing the unique identifier of the asset.</param>
        /// <returns>An Asset Entity</returns>
        public Asset GetAssetById(string Id)
        {
            var asset = _assetRepository.Get(Id);

            return asset;
        }
    }
}
