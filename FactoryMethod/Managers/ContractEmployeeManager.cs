using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryMethodDP.Managers
{       //CONCRETE PRODUCT.
    public class ContractEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 6;
        }

        public decimal GetPay()
        {
            return 3;
        }

        public decimal GetMedicalAllowance()
        {
            return 100;
        }
    }
}