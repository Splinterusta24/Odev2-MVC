using Odev2_MVC.Business.Football;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Odev2_MVC.Controllers
{
    public class TeamsController : Controller
    {
        // GET: Teams
        public ActionResult Futbol()
        {
            return View();
        }
        [HttpPost]
        public JsonResult AddPlayer(string name, int age, int sportgear, decimal salary, DateTime contract, string position)
        {
            Players players = new Players{
                NameSurname = name,
                Age = age,
                SportsgearNo = sportgear,
                Salary = salary,
                ContractDeadline = contract,
                MatchPosition = position
            };

            players.Ekle();
            

            return Json(null);
        }
        public ActionResult Basketbol()
        {
            return View();
        }
        public ActionResult Voleybol()
        {
            return View();
        }
    }
}