using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryMethodDP.Managers
{       //CONCRETE PRODUCT.
    public class PermanentEmployeeManager : IEmployeeManager
    {
        public decimal GetBonus()
        {
            return 10;
        }

        public decimal GetPay()
        {
            return 5;
        }

        public decimal GetHouseAllowance()
        {
            return 150;
        }
    }
}