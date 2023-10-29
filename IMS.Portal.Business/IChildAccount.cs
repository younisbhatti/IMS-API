using IMS.Portal.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IMS.Portal.Business
{
    public interface IChildAccount
    {
        Task<ChildAccount> GetAccount();    
    }
}
