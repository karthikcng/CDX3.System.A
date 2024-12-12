using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace CDX3.System.A.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccessController : ControllerBase
    {     

        [HttpPost]
        [Route("Feature1")]
        public JsonResult Feature1(Base ip)
        {
            var actionName = MethodBase.GetCurrentMethod().Name; 
            
            var op = new
            {                
                Action = actionName,                
            };

            return new JsonResult(op);
        }

        [HttpPost]
        [Route("Feature2")]
        public JsonResult Feature2(Base ip)
        {
            var actionName = MethodBase.GetCurrentMethod().Name;

            var op = new
            {
                Action = actionName,
            };

            return new JsonResult(op);
        }
    }
}
