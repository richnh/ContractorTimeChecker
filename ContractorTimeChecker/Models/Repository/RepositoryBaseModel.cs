using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractorTimeChecker.Models.Repository
{
    public class RepositoryReponseBaseModel
    {
        public bool State { get; protected set; }

        public string Message { get; protected set; }

        public RepositoryReponseBaseModel(bool state, string msg)
        {
            this.State = state;
            this.Message = Message;
        }
    }
}
