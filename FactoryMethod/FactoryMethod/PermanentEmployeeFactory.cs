using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FactoryMethodDP.Managers;
using FactoryMethodDP.Models;

namespace FactoryMethodDP.FactoryMethod
{       //PRODUCT. SUBCLASS.
    public class PermanentEmployeeFactory : BaseEmployeeFactory
    {
        public PermanentEmployeeFactory(Employee emp) : base(emp)
        {
        }

        public override IEmployeeManager Create()
        {
            PermanentEmployeeManager permanent = new PermanentEmployeeManager();
            _emp.HouseAllowance = permanent.GetHouseAllowance();
            return permanent;
        }
    }
}