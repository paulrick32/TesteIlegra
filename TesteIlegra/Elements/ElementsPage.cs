using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestePraticoIlegra.Elements
{
    class ElementsPage : ElementsBase
    {
        [FindsBy(How = How.CssSelector, Using = "[href='contato.html']")]
        protected IWebElement contato { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='homefeatured']/li[2]/div/div[2]/h5/a")]
        protected IWebElement produto { get; set; }

        [FindsBy(How = How.Id, Using = "add_to_cart")]
        protected IWebElement addCarrinho { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='layer_cart_product_title']")]
        protected IWebElement produtoNoCarrinho { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Proceed to checkout')]")]
        protected IWebElement btnCheckout { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='button btn btn-default standard-checkout button-medium']")]
        protected IWebElement btnCheckoutCarrinho { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='email_create']")]
        protected IWebElement emailCadastro { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='icon-user left']")]
        protected IWebElement btnCriar { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='id_gender1']")]
        protected IWebElement genero { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='customer_firstname']")]
        protected IWebElement firstName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='customer_lastname']")]
        protected IWebElement lastName { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='passwd']")]
        protected IWebElement passwd { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='address1']")]
        protected IWebElement address { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='city']")]
        protected IWebElement city { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='state']")]
        protected IWebElement state { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='postcode']")]
        protected IWebElement zipCode { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='country']")]
        protected IWebElement country { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='phone_mobile']")]
        protected IWebElement phone { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='alias']")]
        protected IWebElement alias { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'Register')]")]
        protected IWebElement register { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='center_column']/form/p/button/span/i")]
        protected IWebElement btnProceed { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='uniform-cgv']")]
        protected IWebElement term { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class ='button btn btn-default standard-checkout button-medium']")]
        protected IWebElement btnproceedTo { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class ='bankwire']")]
        protected IWebElement bank { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[contains(text(),'I confirm my order')]")]
        protected IWebElement btnConfirm { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#address_delivery > li.address_address1.address_address2")]
        protected IWebElement addressCompare { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='total_price']")]
        protected IWebElement totalCheckout { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@class='ajax_block_cart_total']")]
        protected IWebElement totalCarrinho { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#center_column > div > p > strong")]
        protected IWebElement compraFinalizada { get; set; }






    }
}
