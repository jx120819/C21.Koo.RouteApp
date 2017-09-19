using C21.Koo.RouteApp.SearchConditionParsingEngine;
using Newtonsoft.Json;
using System.Web.Mvc;

namespace C21.Koo.RouteApp.Controllers
{
    public class HouseController : Controller
    {
        // GET: House
        public ContentResult Index(DefaultConditionModel conditionDto)
        {
            return Content(JsonConvert.SerializeObject(conditionDto));
        }
    }
}