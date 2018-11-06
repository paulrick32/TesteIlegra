using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System;
using TestePraticoIlegra.Elements;
using System.IO;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace TestePraticoIlegra.Pages
{
    class ClassPage : ElementsPage
    {


        public ClassPage(IWebDriver driver)
        {
            PageFactory.InitElements(this, new RetryingElementLocator(driver, TimeSpan.FromSeconds(20)));
        }

        public void AcessarHome()
        {
            Driver.Url = "http://automationpractice.com/index.php?";
        }

        public void RealizarCompra(string emailCadastros)
        {
            var produtoText = produto.Text;
            produto.Click();
            addCarrinho.Click();
            var produtoCarrinhotext = produtoNoCarrinho.Text;
            btnCheckout.Click();
            btnCheckoutCarrinho.Click();
            emailCadastro.SendKeys(emailCadastros);
            btnCriar.Click();
            Assert.AreEqual(produtoText, produtoCarrinhotext);

        }

        public void RealizarCadastro(string fisrtNameCustomer, string lastNameCustomer, string passwordCustomer,
            string addressCustomer, string cityCustomer, string stateCustomer, string zipCodeCustomer, string countryCustomer,
            string phoneCustomer, string aliasCustomer)
        {
            genero.Click();
            firstName.SendKeys(fisrtNameCustomer);
            lastName.SendKeys(lastNameCustomer);
            passwd.SendKeys(passwordCustomer);
            address.SendKeys(addressCustomer);
            city.SendKeys(cityCustomer);
            var selectElementState = new SelectElement(state);
            selectElementState.SelectByText(stateCustomer);
            zipCode.SendKeys(zipCodeCustomer);
            var selectElementCountry = new SelectElement(state);
            selectElementCountry.SelectByText(countryCustomer);
            phone.SendKeys(phoneCustomer);
            alias.SendKeys(aliasCustomer);
            register.Click();
            var addressToCompare = addressCompare.Text;
            Assert.AreEqual(addressCustomer, addressToCompare);
            term.Click();
            Assert.AreEqual("$29.00", totalCheckout);
            btnproceedTo.Click();
            bank.Click();
            btnConfirm.Click();
            btnProceed.Click();
        }
        
        public void CompraFinalizada()
        {
            Assert.AreEqual("Your order on My Store is complete.", compraFinalizada);
        }
    }
}
