using System;
using System.Collections.Generic;
using System.Text;
using Zeti.Core.Entities;
using Zeti.Core.ServiceEntities;

namespace Zeti.Core.Contracts
{
    public interface IOperatorService
    {
        public AssetOperator GetOperatorById(string Id);
        public ICollection<AssetOperator> GetAllOperators(GetAllOperatorsRequest Query);
    }
}
