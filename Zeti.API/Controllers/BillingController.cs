using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Zeti.Core.Contracts;

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
        public IActionResult GetTotalOperatorCost(string OperatorId)
        {
            var response = BillingService.GetTotalOperatorCost(OperatorId);
            return Ok(response);
        }
    }
}
