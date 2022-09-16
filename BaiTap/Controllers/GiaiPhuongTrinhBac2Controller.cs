using Microsoft.AspNetCore.Mvc;
using BaiTap.Models;

namespace BaiTap.Controllers;
public class GiaiPhuongTrinhBac2Controller : Controller
{   
    GiaiPhuongTrinhBac2 gpt = new GiaiPhuongTrinhBac2();
    public IActionResult GiaiPhuongTrinhBac2(){
        return View();
    }
    [HttpPost]
    public IActionResult GiaiPhuongTrinhBac2(string hesoA, string hesoB, string hesoC){
        string KetQua = gpt.GiaiPTBac2(hesoA,hesoB, hesoC);
        ViewBag.ThongBaoKetQua = KetQua;
        return View();
    }
}