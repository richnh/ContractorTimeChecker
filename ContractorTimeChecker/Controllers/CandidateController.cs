using ContractorTimeChecker.Repository;
using System.Web.Mvc;

namespace ContractorTimeChecker.Controllers
{
    public class CandidateController : Controller
    {
        readonly IRepository<EntityBase> repository;

        public CandidateController(IRepository<EntityBase> repository)
        {
            this.repository = repository;
        }

        // GET: Candidate
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Create(EntityBase form)
        {
            repository.Create(form);

            return new JsonResult();
        }
    }
}