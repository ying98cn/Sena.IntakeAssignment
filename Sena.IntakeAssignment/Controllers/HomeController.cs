using Sena.IntakeAssignment.Data.Interface;
using Sena.IntakeAssignment.Data.Model;
using System;
using System.Web.Mvc;

namespace Sena.IntakeAssignment.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// The IRecordRepository.
        /// </summary>
        private IRecordRepository _recordRepository;

        /// <summary>
        /// Initizlizes a new instance of the HomeController class.
        /// </summary>
        /// <param name="recordRepository"></param>
        public HomeController(IRecordRepository recordRepository)
        {
            _recordRepository = recordRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Records()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetRecords()
        {
            var records = _recordRepository.FetchRecordList();
            return Json(records, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult UpdateRecord(Record record)
        {
            try
            {
                var records = _recordRepository.Update(record);
                return Json(new { message = "The existing user is updated." });
            }
            catch(Exception ex)
            {
                // todo: add to log

                return Json(new { message = string.Format("Something went wrong. Due to {0}.", ex.Message) });
            }
        }

    }
}