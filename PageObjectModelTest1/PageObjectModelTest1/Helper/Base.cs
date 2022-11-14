
using PageObjectModelTest1.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModelTest1.Helper
{
    public class Base
    {
        [SetUp]
        public static void BeforeScenario()
        {
            WebDriver.Initialization();
        }

        [TearDown] 
        public static void AfterScenario()
        {
            WebDriver.CleanUp();
        }
    }
}
