using System;
using System.Collections.Generic;
using System.Text;
using Zeti.Core.Repository;

namespace Zeti.Persistence
{
    public static class RepositoryFactory
    {
        public static IAssetRepository GetAssetRepository()
        {
            return new AssetRepository();
        }

        public static IOperatorRepository GetOperatorRepository()
        {
            return new OperatorRepository();
        }

        public static IMileageRepository GetMileageRepository()
        {
            return new MileageRepository();
        }
    }
}