using Microsoft.AspNetCore.Mvc;
using IronOcrWebApi.Contracts;
using System.Text.Json;
using System.Diagnostics;
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
    public JsonContent JsonTester()
    {
        var purchase = new MyClass
        {
            Name = "san",
            OrderItem = "order"
        };
        

        try
        {
            var json1 = JsonSerializer.Serialize(purchase);
            //var rr = "{"Name":"san","OrderItem":"order"}";
            //var json = JsonSerializer.Deserialize<string>(json1);
            //return json1;
            // 	
            // {"Name":"san","OrderItem":"order"}
            var jc = JsonContent.Create("Test");
            return jc;
        }
        catch(Exception e)
        {
            Debug.WriteLine($"{e.Message}");
        }  
        return JsonContent.Create("");
    }
}