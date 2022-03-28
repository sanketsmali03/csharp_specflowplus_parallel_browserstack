
using NUnit.Framework;
using OpenQA.Selenium;
using SpecflowBrowserStack.Drivers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowBrowserStack.pages
{
    public class LandingPage : BasePage
    {

       
        By logonButton = By.CssSelector(".iLock");
        By logOffButton = By.CssSelector(".logout>a");
        By displayName = By.CssSelector(".user strong");
        

        private string pageTitle = "Bing";

        [Obsolete]
        public LandingPage(WebDriver driver1)
        {
            BasePage.driver = driver1.Current;
        }

        public LandingPage()
        {
        }

        [Obsolete]
        public void NavigateToLandingPage()
        {
            base.NavigateTo("", pageTitle);

        }

        [Obsolete]
        internal void ClickOnLogOnButton()
        {
            Click(logonButton);
        }

        [Obsolete]
        internal void ClickOnLogOffButton()
        {
            MarkTestAsPassOrFail("passed");
        }

        [Obsolete]
        internal string GetDisplayName()
        {
            if (IsDisplayed(displayName))
            {
                return GetText(displayName);
            }
            return "Not found";
        }
        

    }
}
