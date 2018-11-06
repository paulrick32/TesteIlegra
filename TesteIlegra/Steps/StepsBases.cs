using OpenQA.Selenium;
using TestePraticoIlegra.Setup;

namespace TestePraticoIlegra.Steps
{
    public abstract class StepsBase
    {
        public IWebDriver Driver
        {
            get
            {
                return SetUp.Driver;
            }
        }
    }
}