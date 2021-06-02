using System;
using System.Collections.Generic;
using System.Text;
using Zeti.Core.ServiceEntities;

namespace Zeti.Core.Contracts
{
    public interface IBillingService
    {
        public GetOperatorBillingResponse GetTotalOperatorCost(BillRequest BillRequest);
    }
}
