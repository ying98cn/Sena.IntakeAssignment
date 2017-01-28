using Sena.IntakeAssignment.Data.Interface;
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

    }
}