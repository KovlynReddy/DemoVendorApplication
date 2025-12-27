using Microsoft.AspNetCore.Mvc;

namespace DemoVendorApplicationAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class HomeController : Controller
{
    [HttpGet]
    public string Index()
    {
        return "hello";
    }
}
