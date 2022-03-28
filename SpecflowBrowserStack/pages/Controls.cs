namespace SpecflowBrowserStack.pages
{
    public static class Controls
    {
        private static LandingPage _landingPage;

        [System.Obsolete]
        public static LandingPage LandingPage
        {
            //get { return _landingPage ?? (_landingPage = new LandingPage()); }
            get {return new LandingPage(); }
        }

        
    }
}
