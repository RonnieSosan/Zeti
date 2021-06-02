using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zeti.Core.Entities;
using Zeti.Core.Repository;

namespace Zeti.Persistence
{
    public class OperatorRepository : IOperatorRepository
    {
        protected static readonly IAssetRepository _assetRepository = RepositoryFactory.GetAssetRepository();

        protected ICollection<AssetOperator> AssetsOperators = new List<AssetOperator>
        {
            new AssetOperator {
                OperatorID = "nd92jdno2",
                OperatorName = "Bob's Taxis",
                Assets = _assetRepository.GetAll().ToList()
            }
        };
        public AssetOperator Get(string id)
        {
            var asset = AssetsOperators.Where(x => x.OperatorID == id).FirstOrDefault();
            return asset;
        }

        public IQueryable<AssetOperator> GetAll()
        {
            var assetsToReturn = AssetsOperators.AsQueryable();
            return assetsToReturn;
        }
    }
}
