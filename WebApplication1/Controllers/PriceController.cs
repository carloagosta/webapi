using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Resources;

namespace WebApplication1.Controllers
{
    [Route("api/prices")]
    [ApiController]
    public class PriceController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Dictionary<string, object>>> Get()
        {
            return PriceResource.GetPricesList().Select(o => new Dictionary<string, object>()  {
                                                                            {"dateISO8601", o.Date.ToString("yyyy'-'MM'-'dd")}
                                                                            ,{"price", o.Price }
                                                                        }).ToList(); ;
        }

        [HttpGet("GetOilPriceTrend")]
        public ActionResult<List<Dictionary<string, object>>> Get(DateTime startDateISO8601, DateTime endDateISO8601)
        {
            List<Point> points = PriceResource.GetPricesListRange(startDateISO8601, endDateISO8601);

            return points.Select(o => new Dictionary<string, object>()  {
                                                                            {"dateISO8601", o.Date.ToString("yyyy-MM-dd")}
                                                                            ,{"price", o.Price }
                                                                        }).ToList();
        }
    }
}
