using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class RecourseManager
    {
        public void DoRecourse(ICreditManager creditManager, ILoggerService loggerService) 
        {
            
            creditManager.Calculate();
            loggerService.Log();
        }
        public void DoCreditPreinformation(List<ICreditManager> credits)
        {
            foreach(var credit in credits)
            {
                credit.Calculate();
            }
        }
    }
}
