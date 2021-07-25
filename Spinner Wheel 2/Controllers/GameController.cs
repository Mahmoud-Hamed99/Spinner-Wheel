using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Spinner_Wheel_2.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Game()
        {
            return View();

        }

        [HttpGet]
        public string GetPrize()
        {
            return GetPrizeList();
        }



        public string GetPrizeList()
        {

            int surprise = 0;
            int giveawayTotal = 100;
            int voucherTotal = 50;

            int giveaway1 = 30;
            int giveaway2 = 20;
            int giveaway3 = 50;
            int voucher1 = 30;
            int voucher2 = 20;


            if (surprise > 0)
            {
                //res = new KeyValuePair<int, string>(1,"Surprise");
                return "1;Surprise";
            }

            Random rd = new Random();
            if (rd.Next(0, 100) < 25)
            {
                //res = new KeyValuePair<int, string>(2, "HardLuck");
                return "2;HardLuck";
            }
            else
            {
                List<int> prizesPool = new List<int>();
                for (int i = 0; i < giveawayTotal; i++)
                {
                    prizesPool.Add(3);
                }
                for (int i = 0; i < voucherTotal; i++)
                {
                    prizesPool.Add(0);
                }

                int selectedRandom = rd.Next(0, prizesPool.Count);
                int prizeOrVoucher = prizesPool[selectedRandom];
                if (prizeOrVoucher == 3)
                {
                    //giveaway
                    List<string> prizesPoolImage = new List<string>();
                    for (int i = 0; i < giveaway1; i++)
                    {
                        prizesPoolImage.Add("04.jpg");
                    }
                    for (int i = 0; i < giveaway2; i++)
                    {
                        prizesPoolImage.Add("05.jpg");
                    }
                    for (int i = 0; i < giveaway3; i++)
                    {
                        prizesPoolImage.Add("06.jpg");
                    }
                    int selectedGiveaway = rd.Next(0, prizesPoolImage.Count);
                    string picName = prizesPoolImage[selectedGiveaway];
                    var x = new string[] { };
                    return "3;" + "/img\\" + picName;
                    // return res;
                }
                else
                {
                    //vouchers
                    List<string> vouchersPoolImage = new List<string>();
                    for (int i = 0; i < voucher1; i++)
                    {
                        vouchersPoolImage.Add("016.jpg");
                    }
                    for (int i = 0; i < voucher2; i++)
                    {
                        vouchersPoolImage.Add("04.jpg");
                    }

                    int selectedvoucher = rd.Next(0, vouchersPoolImage.Count);
                    string picName = vouchersPoolImage[selectedvoucher];
                   
                    return "0;" + "/img\\" + picName;
                   
                }
            }
        }
    }
}