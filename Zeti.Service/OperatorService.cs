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
    public class OperatorService : IOperatorService
    {
        protected static readonly IOperatorRepository _operatorRepository = RepositoryFactory.GetOperatorRepository();

        public ICollection<AssetOperator> GetAllOperators(GetAllOperatorsRequest Query)
        {
            var operators = _operatorRepository.GetAll();

            if (Query.Brand != null && Query.Brand != string.Empty)
                operators = operators.Where(x => x.Assets.Any(x => x.Brand.Contains(Query.Brand)));

            if (Query.Model != null && Query.Model != string.Empty)
                operators = operators.Where(x => x.Assets.Any(x => x.Model == Query.Model));

            if (Query.Type != null)
                operators = operators.Where(x => x.Assets.Any(x => x.AssetType == Query.Type));

            if (Query.OperatorName != null)
                operators = operators.Where(x => x.OperatorName == Query.OperatorName);

            return operators.ToList();
        }

        public AssetOperator GetOperatorById(string Id)
        {
            var assetOperator = _operatorRepository.Get(Id);
            return assetOperator;
        }
    }
}
