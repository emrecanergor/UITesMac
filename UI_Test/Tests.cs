using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace UI_Test
{
    //[TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            //app.Screenshot("First_Screen");
            //app.Repl();
            app.EnterText(c => c.Marked("entry_xyz"), "Deneme1-2-3-1");
            app.Tap(c => c.Marked("buton_xyz"));
            app.Tap(c => c.Marked("buton_xyz"));

        }
    }
}
