using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sportsmans;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sportsmans.Tests
{
    [TestClass()]
    public class ApplicationViewModelTests
    {
        [TestMethod()]
        public void ApplicationViewModelTest()
        {
            ApplicationViewModel sport = new ApplicationViewModel();
            int count = sport.GetSportsmansCount();
            Assert.IsTrue(count == 20);
        }
    }
}
