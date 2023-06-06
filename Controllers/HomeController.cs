using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Controllers.Models;

namespace WebApplication1.Controllers;
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
       
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    // GET: api/<ValuesController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
      
        return new string[] { "value1", "value2" };
    }
     [HttpDelete]
    public IEnumerable<string> Delete()
    {
      
        return new string[] { };
    }


    // GET api/<ValuesController>/5
    [HttpGet("/Home/Privacy/{get}")]
    public string Get(int id)
    {
       
        return id.ToString();
    }

    // POST api/<ValuesController>
    [HttpPost("/Home/post")]
    public void Post([FromBody] string value)
    {


        Post(value);
    }

    // PUT api/<ValuesController>/5
    [HttpPut("/Home/Privacy/{put}")]
    public void Put(int id, [FromBody] string value)
    {
    }
 
    [HttpDelete("/Home/Privacy/{delete}")]
    public string Delete(int id)
    {
       return id.ToString();
    }


}
