using FactoryMethodDP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryMethodDP.FactoryMethod
{
    //CONCRETE CREATOR. FACTORY. The way in wich you can create Employee Types. Can create different types of Employees depend on the logic of this METHOD.
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory(Employee emp)
        {
            BaseEmployeeFactory returnValue = null;

            if (emp.EmployeeTypeID == 1)
            {
                returnValue = new PermanentEmployeeFactory(emp);
            }

            if (emp.EmployeeTypeID == 2)
            {
                returnValue = new ContractEmployeeFactory(emp);
            }

            return returnValue;
        }
    }
}