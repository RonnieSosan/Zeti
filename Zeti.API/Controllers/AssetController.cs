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
    public class AssetController : Controller
    {
        IAssetService AssetService;

        public AssetController(IAssetService _assetService)
        {
            AssetService = _assetService;
        }

        [HttpGet]
        [Route("GetAssetById")]
        public IActionResult GetAssetById(string AssetId)
        {
            var response = AssetService.GetAssetById(AssetId);
            return Ok(response);
        }

        [HttpGet]
        [Route("GetAllAssets")]
        public IActionResult GetAllAssets([FromQuery] GetAllAssetsRequest query)
        {
            var response = AssetService.GetAllAssets(query);
            return Ok(response);
        }
    }
}
