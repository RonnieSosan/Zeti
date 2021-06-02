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
    public class OperatorController : Controller
    {
        IOperatorService OperatorService;

        public OperatorController(IOperatorService _operatorService)
        {
            OperatorService = _operatorService;
        }

        [HttpGet]
        [Route("GetOperatorById")]
        public IActionResult GetOperatorById(string AssetId)
        {
            var response = OperatorService.GetOperatorById(AssetId);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetAllOperators")]
        public IActionResult GetAllOperators([FromQuery] GetAllOperatorsRequest query)
        {
            var response = OperatorService.GetAllOperators(query);
            return Ok(response);
        }
    }
}
