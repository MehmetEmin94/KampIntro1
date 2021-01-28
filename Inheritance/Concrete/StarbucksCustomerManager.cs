using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concrete
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        private IPersonCheckService _personCheckService;
        public override void Save(Customer customer)
        {
            CheckIfRealPerson(customer);
            base.Save(customer);
        }

        private void CheckIfRealPerson(Customer customer)
        {
            
        }

        void IPersonCheckService.CheckIfRealPerson(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
