using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoItX3Lib;

namespace adressbook_tests_autoit
{
   public class HelperBase
    {
        protected ApplicationManager manager;
        protected string WINTITLE;
        protected IAutoItX3 aux;
        
       
       protected HelperBase(ApplicationManager manager)
        {
            // TODO: Complete member initialization
            this.manager = manager;
            WINTITLE = ApplicationManager.WINTITLE;
            this.aux = manager.Aux;
        }

    }
}
