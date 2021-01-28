using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personelFinanceCredit = new PersonelFinanceCredit();
           
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            
            ICreditManager housingCreditManager = new HousingCreditManager();

            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            RecourseManager recourseManager = new RecourseManager();
            recourseManager.DoRecourse(personelFinanceCredit, dataBaseLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() { personelFinanceCredit, vehicleCreditManager };

            //recourseManager.DoCreditPreinformation(credits);
        }
    }
}
