using System;
using InterfaceAbstractDemo.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InterfaceAbstractDemo.Entities;

namespace InterfaceAbstractDemo.Concrete
{
    internal class StarbucksCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }

        
    }
}
