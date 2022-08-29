using FactoryMethodDP.Managers;
using FactoryMethodDP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FactoryMethodDP.FactoryMethod
{       //ABSTRACT CREATOR. INTERFACE. DEFER SUBCLASESS INTANTIATION.
    public abstract class BaseEmployeeFactory
    {
        protected Employee _emp;

        public BaseEmployeeFactory(Employee emp)
        {
            _emp = emp;
        }

        public abstract IEmployeeManager Create(); 

        public Employee ApllySalary()
        {
            IEmployeeManager manager = this.Create();
            _emp.HourlyPay = manager.GetPay();
            _emp.Bonus = manager.GetBonus();
            return _emp;
        }
    }
}