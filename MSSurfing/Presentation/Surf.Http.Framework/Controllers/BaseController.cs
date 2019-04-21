using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Surf.Http.Framework.Controllers
{
    public abstract class BaseController : ControllerBase
    {
        protected virtual string Json2(object data)
        {
            return JsonConvert.SerializeObject(data);
        }
        protected virtual string Ok2(string Msg = null, object Data = null)
        {
            return Json2(new { Msg, Data });
        }
    }
}
