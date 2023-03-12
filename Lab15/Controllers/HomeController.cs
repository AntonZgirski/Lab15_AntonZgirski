using Lab15.Models;
using Lab15.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Lab15.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    private readonly IConfiguration _configuration;

    public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
    {
      _logger = logger;
      _configuration = configuration;
    }
    [HttpGet]
    public IActionResult Index()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Create([FromForm] string roleName, [FromForm] decimal roleSalary)
    {
      using (var context = new AppDbContext(_configuration))
      {
        var role = new Role { RoleName = roleName, RoleSalary = roleSalary };
        context.Add(role);
        context.SaveChanges();
      }
      return RedirectToAction("Index");
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
  }
}