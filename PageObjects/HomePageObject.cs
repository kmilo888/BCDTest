using OpenQA.Selenium;

namespace BCDTest.PageObjects
{
    /// <summary>
    /// Home Page Object
    /// </summary>
    public class HomePageObject
    {
        //The URL of the Home to be opened in the browser
        private const string HomeUrl = "https://berlincontemporarydance.com/";

        //The Selenium web driver to automate the browser
        private readonly IWebDriver _webDriver;


        public HomePageObject(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void OpenPage()
        {
            //Open the calculator page in the browser if not opened yet
            if (_webDriver.Url != HomeUrl)
            {
                _webDriver.Url = HomeUrl;
            }
        }
    }
}
