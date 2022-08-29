using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FactoryMethodDP.Managers;
using FactoryMethodDP.Models;

namespace FactoryMethodDP.FactoryMethod
{       //PRODUCT. SUBCLASS.
    public class ContractEmployeeFactory : BaseEmployeeFactory
    {
        public ContractEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            ContractEmployeeManager contract = new ContractEmployeeManager();
            _emp.MedicalAllowance = contract.GetMedicalAllowance();
            return contract;
        }
    }
}