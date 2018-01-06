using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RaiderLeague.Models;

namespace RaiderLeague.Controllers
{
    public class UploadBattleLogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        String y = null;




        [HttpPost]
        public ActionResult Uploaded(BattleLogUpload model)
        {
            
            if (ModelState.IsValid)
            {
                BattleLog x = new BattleLog(model.battleLogUpload);
                if (x.getResult().Count < 2)
                {
                    ViewData["dps"] = "Invalid input!";
                }
                else
                {
                    ViewData["tps"] = "TPS= "+x.getResult().ElementAt(0);
                    ViewData["dps"] = "DPS= "+x.getResult().ElementAt(1);
                    ViewData["hps"] = "HPS= "+x.getResult().ElementAt(2);
                }
            }
            
            return View();
        }       
    }
}