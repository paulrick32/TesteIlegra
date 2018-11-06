using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TestePraticoIlegra.Pages;
using TestePraticoIlegra.Steps;

namespace ProjetoPraticoDb
{
    [Binding]
    public class ComprarUmProdutoSteps : StepsBase
    {
        [Given(@"eu comprei um produto")]
        public void GivenEuCompreiUmProduto()
        {
            ClassPage page = new ClassPage(Driver);
            page.RealizarCompra("paulo.test@test.com.br");
        }

        [When(@"os dados da compra estão corretos")]
        public void WhenOsDadosDaCompraEstaoCorretos()
        {
            ClassPage page = new ClassPage(Driver);
            page.RealizarCadastro("Paulo", "Pereira", "12345", "Rua teste", "Porto Alegre", "RS", "00000", "Brasil", "0000000", "teste");
        }

        [Then(@"eu finalizo a compra")]
        public void ThenEuFinalizoACompra()
        {
            ClassPage page = new ClassPage(Driver);
            page.CompraFinalizada();
        }
    }
}
