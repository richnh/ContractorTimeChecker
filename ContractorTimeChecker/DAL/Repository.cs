using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ContractorTimeChecker.Models;

namespace ContractorTimeChecker.DAL
{
    public class Repository : IRepository
    {
        private ApplicationContext context;

        public Repository(ApplicationContext context)
        {
            this.context = context;
        }

        public IEnumerable<SelectListItem> GetCandidateNames()
        {
            var list = new List<SelectListItem>();

            foreach (var entry in context.Timesheets.ToList())
            {
                list.Add(new SelectListItem() { Value = entry.Id.ToString(), Text = entry.CandidateName });
            }

            return list;
        }

        public IEnumerable<TimesheetSummary> GetCandidateSummary(string candidateName)
        {
            var list = context.Timesheets.Where(x => x.CandidateName == candidateName).ToList();

            return list;
        }

        public List<TimesheetSummary> GetCandidateEmploymentSummary(TimesheetSummaryModel model)
        {
            var queryPlacementStartDate = false;
            var queryJobTitle = false;

            var contractorSummary = new List<TimesheetSummary>();

            var candidateName = model.CandidateNamesVM.CandidateNames.ElementAt(model.CandidateNameIndex - 1);

            if (string.IsNullOrEmpty(candidateName.Text))
            {
                throw new Exception("Invalid Candidate Name");
            }

            if (model.PlacementStartDate != null)
            {
                queryPlacementStartDate = true;
            }

            if (model.PlacementEndDate != null)
            {
                queryJobTitle = true;
            }

            if (queryPlacementStartDate && queryJobTitle)
            {
                contractorSummary = context.Timesheets.Where(x => x.CandidateName == candidateName.Text).Where(x => x.Date > model.PlacementStartDate).Where(x => x.JobTitle == model.JobTitle).ToList();
            }
            else
            {
                if (queryPlacementStartDate)
                {
                    contractorSummary = context.Timesheets.Where(x => x.CandidateName == candidateName.Text).Where(x => x.Date > model.PlacementStartDate).ToList();
                }
                else
                {
                    contractorSummary = context.Timesheets.Where(x => x.CandidateName == candidateName.Text).Where(x => x.JobTitle == model.JobTitle).ToList();
                }
            }

            return contractorSummary;
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}