using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Zeti.Core.Contracts;
using Zeti.Core.ServiceEntities;

namespace Zeti.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BillingController : Controller
    {
        IBillingService BillingService;

        public BillingController(IBillingService _billingService)
        {
            BillingService = _billingService;
        }


        [HttpGet]
        [Route("GetTotalOperatorCost")]
        public IActionResult GetTotalOperatorCost([FromQuery]BillRequest Payload)
        {
            var response = BillingService.GetTotalOperatorCost(Payload);
            return Ok(response);
        }
    }
}
