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
    public class JokerTests
    {
        [Test]
        public void GetNumberOfDecksTest1()
        {
            Assert.That(Joker.GetNumberOfDecks(3, new long[] {10, 15}), Is.EqualTo(13));
        }

        [Test]
        public void GetNumberOfDecksTest2()
        {
            Assert.That(Joker.GetNumberOfDecks(4, new long[] { 1, 2, 3 }), Is.EqualTo(3));
        }

        [Test]
        public void GetNumberOfDecksTest3()
        {
            Assert.That(Joker.GetNumberOfDecks(5, new long[] { 1 }), Is.EqualTo(6));
        }

        [Test]
        public void GetNumberOfDecksTest4()
        {
            Assert.That(Joker.GetNumberOfDecks(3, new long[] { 2, 3, 4, 5, 6 }), Is.EqualTo(4));
        }

        [Test]
        public void GetNumberOfDecksTest5()
        {
            Assert.That(Joker.GetNumberOfDecks(4, new long[] { 2, 2 }), Is.EqualTo(4));
        }
    }
}
