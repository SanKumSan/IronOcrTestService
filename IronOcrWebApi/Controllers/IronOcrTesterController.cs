using Microsoft.AspNetCore.Mvc;
using IronOcrWebApi.Contracts;
using System.Text.Json;
using IronOcrWebApi.Services;

namespace IronOcrWebApi.Controllers;

public class IronOcrTesterController : ControllerBase
{
    // GET
    [Route(""), HttpGet]
    public string Test()
    {
        return new MyService().BarcodeTester();
    }

    // GET
    [Route("JsonTester"), HttpGet]
    public string JsonTester()
    {
        var purchase = new MyClass
        {
            Name = "san",
            Title = "Admin"
        };

        return JsonSerializer.Serialize(purchase);
    }
}