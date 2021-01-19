using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using NSubstitute;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Phone;
using System.ComponentModel;

namespace Sportsmans.Tests
{
    [TestClass()]
    public class SportsmansTests
    {
        private Sportsmans db;

        [TestInitialize()]
        public void Setup()
        {
            db = Substitute.For<Sportsmans>();

            var data = new List<Sportsmans> { new Sportsmans { Name = "Антонов Антон", Birth = 2004, Type1 = "Отжимания", Res1 = 56, Type2 = "Спринт 60м", Res2 = 7.7, Type3 = "Спринт 200м", Res3 = 40.1, Type4 = "Прыжки в длину с места", Res4 = 2.39 } }.AsQueryable();
            var sportsman = Substitute.For<DbSet<Sportsmans>, IQueryable<Sportsmans>>();
            ((IQueryable<Sportsmans>)sportsman).Provider.Returns(data.Provider);
            ((IQueryable<Sportsmans>)sportsman).Expression.Returns(data.Expression);
            ((IQueryable<Sportsmans>)sportsman).ElementType.Returns(data.ElementType);
            ((IQueryable<Sportsmans>)sportsman).GetEnumerator().Returns(_ => data.GetEnumerator());
            sportsman.AsNoTracking().Returns(sportsman);

            db.Sportsman = sportsman;
        }

        [TestMethod()]
        public void Sportsman()
        {
            var sport = new Sportsmans();
            int birth = 2004;
            var result = sport.Sportsmans(birth);
            Assert.AreEqual(sport, result.ViewData[2004]);
        }
    }
}