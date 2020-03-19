using FluxoFacebook.Fixtures;
using FluxoFacebook.PageObjects;
using OpenQA.Selenium;
using Xunit;

namespace FluxoFacebook.Tests
{
    [Collection("Chrome Driver")]
    public class LoginNoFacebook
    {
        private IWebDriver driver;

        public LoginNoFacebook(TestFixture fixture)
        {
            driver = fixture.Driver;
        }

        [Fact]
        public void DadoEmailIncorretoDeveExibirAlerta()
        {
            var loginPO = new LoginPO(driver);
            loginPO.Acessar();
            loginPO.PreencheLogin("emailIncorreto@gmail.com", "12345");

            loginPO.ClicarEntrar();

            Assert.Contains("Entrar no Facebook", driver.PageSource);
        }
    }
}
