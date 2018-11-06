using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace TestePraticoIlegra.Setup
{
    [Binding]
    public class SetUp
    {
        public static IWebDriver Driver { get; private set; }

        [BeforeScenario]
        public static void Inicializa()
        {
            if (ScenarioContext.Current.ScenarioInfo.Title.Contains("Realizar"))
            {
                ChromeOptions options = new ChromeOptions();
                options.AddArgument("--disable-extensions");
                options.AddArguments("--no-sandbox");
                Driver = new ChromeDriver(options);
                Driver.Manage().Window.Maximize();
            }
        }

        [AfterScenario]
        public static void finaliza()
        {
            if (ScenarioContext.Current.ScenarioInfo.Title.Contains("Realizar"))
            {
                Driver.Quit();
            }
        }
    }
}
