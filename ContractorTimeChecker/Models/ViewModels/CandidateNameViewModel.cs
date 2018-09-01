using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace ContractorTimeChecker.Models.ViewModels
{
    public class CandidateNameViewModel
    {
        [Display(Name = "User Role")]
        public int SelectedCandidateNameId { get; set; }

        public IEnumerable<SelectListItem> CandidateNames { get; set; }
    }
}