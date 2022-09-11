using Microsoft.AspNetCore.Mvc;
using BaiTap.Models;
namespace BaiTap.Controllers;
public class EmployeeController : Controller 
{
    public IActionResult Index(Employee std)
    {
       string message = std.EmployeeID + "-";
       message += std.EmployeeName + "-";
       message += std.EmployeePosition;
       ViewBag.ThongTin = message;
        return View();
    }
}