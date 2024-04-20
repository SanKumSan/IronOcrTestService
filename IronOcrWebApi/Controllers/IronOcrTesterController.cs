using IronOcrWebApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace IronOcrWebApi.Controllers;

public class IronOcrTesterController : ControllerBase
{
    // GET
    [Route(""), HttpGet]
    public string Test()
    {
        return new IronOcrService().BarcodeTester();
    }
}