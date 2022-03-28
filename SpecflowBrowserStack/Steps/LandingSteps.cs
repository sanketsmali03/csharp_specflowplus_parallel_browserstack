
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using SpecflowBrowserStack.pages;
namespace SpecflowBrowserStack.Steps
{
    [Binding]
    public class LandingSteps 
    {
        LandingPage landingPage;


        LandingSteps(LandingPage landingPage)
        {
            this.landingPage = landingPage;
    
        }


        [Given(@"I navigate to LandingPage")]
        [Obsolete]
        public void GivenINavigateToLandingPage()
        {
            landingPage.NavigateToLandingPage();
        }



        [Given(@"I navigate to Login Page")]
        [Obsolete]
        public void GivenINavigateToLoginPage()
        {
            landingPage.NavigateToLandingPage();
            
        }


        [Then(@"the user is successfully logged on and is on the Home Page")]
        [Obsolete]
        public void ThenTheUserIsSuccessfullyLoggedOnAndIsOnTheHomePage()
        {
            Assert.AreEqual("", landingPage.GetDisplayName());
        }

        [Then(@"the user logs off")]
        [Obsolete]
        public void WhenTheUserLogsOff()
        {
            landingPage.ClickOnLogOffButton();
        }

       









    }       
}
