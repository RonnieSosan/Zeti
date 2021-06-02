using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Zeti.Core.Entities;
using Zeti.Core.Repository;

namespace Zeti.Persistence
{
    public class MileageRepository : IMileageRepository
    {
        protected static readonly IAssetRepository _assetRepository = RepositoryFactory.GetAssetRepository();
        protected static readonly IOperatorRepository _operatorRepository = RepositoryFactory.GetOperatorRepository();

        ICollection<AssetMileage> mileageRecords = new List<AssetMileage>
        {
            new AssetMileage{
                MileageId = "1",
                Asset = _assetRepository.Get("829fj"),
                Operator = _operatorRepository.Get("nd92jdno2"),
                Miles = 50,
                Date = DateTime.Now.Date.AddMonths(-1)
            },
            new AssetMileage{
                MileageId = "2",
                Asset = _assetRepository.Get("3g89j"),
                Operator = _operatorRepository.Get("nd92jdno2"),
                Miles = 150,
                Date = DateTime.Now.Date.AddMonths(-2)
            },
            new AssetMileage{
                MileageId = "2",
                Asset = _assetRepository.Get("3g89j"),
                Operator = _operatorRepository.Get("nd92jdno2"),
                Miles = 150,
                Date = DateTime.Now.Date.AddMonths(-3)
            },
            new AssetMileage{
                MileageId = "2",
                Asset = _assetRepository.Get("3g89j"),
                Operator = _operatorRepository.Get("nd92jdno2"),
                Miles = 150,
                Date = DateTime.Now.Date.AddMonths(-4)
            }
        };
        public AssetMileage Get(string id)
        {
            var record = mileageRecords.Where(x => x.MileageId == id).FirstOrDefault();
            return record;
        }

        public IQueryable<AssetMileage> GetAll()
        {
            var records = mileageRecords;

            return records.AsQueryable();
        }
    }
}
