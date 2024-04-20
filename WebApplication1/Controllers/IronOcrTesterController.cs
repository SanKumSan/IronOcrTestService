using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

public class IronOcrTesterController : ControllerBase
{
    // GET
    [Route(""), HttpGet]
    public string Test()
    {
        return new IronOcrService().BarcodeTester();
    }
}