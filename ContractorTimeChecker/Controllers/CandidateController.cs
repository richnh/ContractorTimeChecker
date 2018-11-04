using ContractorTimeChecker.Repository;
using System.Web.Mvc;

namespace ContractorTimeChecker.Controllers
{
    public class CandidateController : Controller
    {
        // GET: Candidate
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Create(EntityBase form)
        {
            return new JsonResult();
        }
    }
}