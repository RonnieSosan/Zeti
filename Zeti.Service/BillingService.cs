using System;
using System.Collections.Generic;
using System.Linq;
using Zeti.Core.Contracts;
using Zeti.Core.Entities;
using Zeti.Core.Repository;
using Zeti.Core.ServiceEntities;
using Zeti.Persistence;

namespace Zeti.Service
{
    public class BillingService : IBillingService
    {
        protected static readonly IAssetRepository _assetRepository = RepositoryFactory.GetAssetRepository();
        protected static readonly IMileageRepository _mileageRepository = RepositoryFactory.GetMileageRepository();

        /// <summary>
        /// Calculates Operators billable
        /// </summary>
        /// <param name="OperatorId">The ID of the operator to be calculated</param>
        /// <returns>A break down of the bill on rthe operator</returns>
        public GetOperatorBillingResponse GetTotalOperatorCost(BillRequest BillRequest)
        {
            GetOperatorBillingResponse response = new GetOperatorBillingResponse();

            try
            {

                var mileageRecords = _mileageRepository.GetAll().Where(x => x.Operator.OperatorID == BillRequest.OperatorId && x.Date <= BillRequest.startDate || x.Date >= BillRequest.EndDate);

                if (mileageRecords == null)
                {
                    response.ResponseCode = "06";
                    response.ResponseDescription = "No record found for this operator Id";

                    return response;
                }

                response.OperatorAssets = new List<Asset>();

                foreach (var item in mileageRecords)
                {
                    response.TotalMileage += item.Miles;
                    response.OperatorAssets.Add(item.Asset);
                }

                //if the cost of the asset is £0.207 per mile
                response.TotalCost = Math.Round(response.TotalMileage * 0.207M, 2).ToString();
                response.ResponseCode = "00";
                response.ResponseDescription = "SUCCESSFUL";
            }
            catch (Exception ex)
            {
                //preferrably log the exception with a preffered logging tool
                response.ResponseDescription = "An error occured while processing request";
                response.ResponseCode = "06";
            }

            return response;
        }
    }
}
