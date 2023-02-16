using ITMO.ASP.StudentRecords.DAL;
using ITMO.ASP.StudentRecords.DAL.Models;
using ITMO.ASP.StudentRecords.DAL.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ITMO.ASP.StudentRecords.PL.Controllers
{
    public class HomeController : Controller
    {
        const string dataNotAvalible = "The data is not available";
        const string notAvalible = "not available";

        private readonly ApplicationContext _db = new ApplicationContext();

        public RedirectResult Index()
        {
            return RedirectPermanent("/Home/AllInfo");
        }

        [HttpGet]
        public async Task<ActionResult> AllInfo()
        {
            using (StudentQuery studentQuery = new StudentQuery(_db))
            {
                var result = await studentQuery.GetAllAsync();
                if (result == null)
                {
                    ViewBag.Message = dataNotAvalible;
                }
                return View(result);
            }
        }

        [HttpGet]
        public async Task<ActionResult> Add()
        {
            await GetScoreInfo();
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Add(StudentAddModel studentAddModel)
        {
            if (ModelState.IsValid)
            {
                using (StudentQuery studentQuery = new StudentQuery(_db))
                {
                    ViewBag.Message = await studentQuery.AddAsync(studentAddModel);
                    if (ViewBag.Message != String.Empty)
                    {
                        await GetScoreInfo();
                        return View(studentAddModel);
                    }
                }
                return RedirectToAction("AllInfo");
            }
            await GetScoreInfo();
            return View(studentAddModel);
        }

        private async Task GetScoreInfo()
        {
            using (ScoreQuery scoreQuery = new ScoreQuery(_db))
            {
                var scores = await scoreQuery.GetAllAsync();
                if (scores == null)
                {
                    ViewBag.Message = dataNotAvalible;
                }
                ViewBag.Scores = scores;
            }
        }

        [HttpGet]
        public async Task<ActionResult> Delete()
        {
            using (StudentQuery studentQuery = new StudentQuery(_db))
            {
                var result = await studentQuery.GetDeleteInfoAsync();
                if (result == null)
                {
                    ViewBag.Message = dataNotAvalible;
                }
                return View(result);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Delete(int id)
        {
            if (ModelState.IsValid)
            {
                using (StudentQuery studentQuery = new StudentQuery(_db))
                {
                    ViewBag.Message = await studentQuery.DeleteInfoAsync(id);
                    if (ViewBag.Message != String.Empty)
                    {
                        return View();
                    }
                }
                return RedirectToAction("AllInfo");
            }
            return RedirectToAction("Delete");
        }

        [HttpGet]
        public async Task<ActionResult> Sum()
        {
            using (StudentQuery studentQuery = new StudentQuery(_db))
            {
                var result = await studentQuery.SumAsync();
                if (result == -999)
                {
                    ViewBag.Sum = notAvalible;
                }
                else
                {
                    ViewBag.Sum = result;
                }
            }
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Rating(string type = "best")
        {
            ViewBag.TypeRating = type;
            using (StudentQuery studentQuery = new StudentQuery(_db))
            {
                var result = await studentQuery.GetTopAsync(type);
                if (result == null)
                {
                    ViewBag.Message = dataNotAvalible;
                }
                return View(result);
            }
        }
    }
}