using TestePraticoIlegra.Setup;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestePraticoIlegra.Elements
{
    public abstract class ElementsBase
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