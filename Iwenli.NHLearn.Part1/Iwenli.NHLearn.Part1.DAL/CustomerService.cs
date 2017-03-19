using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using Iwenli.NHLearn.Part1.Model;
using NHibernate.Linq;

namespace Iwenli.NHLearn.Part1.DAL
{
    public class CustomerService
    {
        private SessionManager _sessionManager;

        public CustomerService()
        {
            _sessionManager = new SessionManager();
        }

        public void Insert(Customer customer)
        {
            using (var _session = _sessionManager.GetSession())
            {
                _session.Save(customer);
            }
        }

        public IList<Customer> LoadAll() {
            using (var _session = _sessionManager.GetSession())
            {
                return _session.Query<Customer>().ToList();
            }
        }


    }
}
