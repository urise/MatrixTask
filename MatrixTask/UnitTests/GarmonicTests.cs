using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class GarmonicTests
    {
        [Test]
        public void CountNumbersLessOfTest()
        {
            Assert.That(Garmonic.CountNumbersLessOrEqualThan(1, 15), Is.EqualTo(1));
            Assert.That(Garmonic.CountNumbersLessOrEqualThan(2, 15), Is.EqualTo(3));
            Assert.That(Garmonic.CountNumbersLessOrEqualThan(12, 15), Is.EqualTo(35));
            Assert.That(Garmonic.CountNumbersLessOrEqualThan(200, 15), Is.EqualTo(222));
        }

        [Test]
        public void SearchTest()
        {
            Assert.That(Garmonic.Search(1, 15), Is.EqualTo(1));
            Assert.That(Garmonic.Search(2, 15), Is.EqualTo(2));
            Assert.That(Garmonic.Search(3, 15), Is.EqualTo(2));
            Assert.That(Garmonic.Search(4, 15), Is.EqualTo(3));
            Assert.That(Garmonic.Search(10, 15), Is.EqualTo(5));
            Assert.That(Garmonic.Search(37, 15), Is.EqualTo(13));
            Assert.That(Garmonic.Search(225, 15), Is.EqualTo(225));
            Assert.That(Garmonic.Search(224, 15), Is.EqualTo(210));
            Assert.That(Garmonic.Search(223, 15), Is.EqualTo(210));
            Assert.That(Garmonic.Search(222, 15), Is.EqualTo(196));
            Assert.That(Garmonic.Search(221, 15), Is.EqualTo(195));
            Assert.That(Garmonic.Search(220, 15), Is.EqualTo(195));
        }
    }
}
