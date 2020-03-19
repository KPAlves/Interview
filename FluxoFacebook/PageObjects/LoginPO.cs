using OpenQA.Selenium;

namespace FluxoFacebook.PageObjects
{
    public class LoginPO
    {
        private IWebDriver driver;
        private By byInputLogin;
        private By byInputSenha;
        private By byBtnLogin;

        public LoginPO(IWebDriver driver)
        {
            this.driver = driver;
            byInputLogin = By.Id("email");
            byInputSenha = By.Id("pass");
            byBtnLogin = By.Id("loginbutton");
        }

        public void Acessar()
        {
            driver.Navigate().GoToUrl("http://facebook.com.br");
        }

        public void PreencheLogin(string login, string senha)
        {
            driver.FindElement(byInputLogin).SendKeys(login);
            driver.FindElement(byInputSenha).SendKeys(senha);
        }

        public void ClicarEntrar()
        {
            driver.FindElement(byBtnLogin).Submit();
        }
    }
}
