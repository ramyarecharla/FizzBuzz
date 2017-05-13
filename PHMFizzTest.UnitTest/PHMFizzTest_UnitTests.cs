using NUnit.Framework;
using PHMFizzTest.App;
using PHMFizzTest.Core.Services;

namespace PHMFizzTest.UnitTest
{
    [TestFixture]
    public class PHMFizzTest_UnitTests
    {
        private FizzBuzzService _service;

        [SetUp]
        public void PHMFizz_Service()
        {
            _service = new FizzBuzzService();
        }
        [Test]
        public void Multiple_of_Three_Should_beFizz()
        {
            string result = _service.Process(33);
            Assert.AreEqual(Helpers.Helpers.MULTIPLEOFTHREE, result);
        }

        [Test]
        public void Multiple_of_Five_Should_beBuzz()
        {
            string result = _service.Process(55);
            Assert.AreEqual(Helpers.Helpers.MULTIPLEOFFIVE, result);
        }

        [Test]
        public void Valid_Input_Test()
        {
            bool result = FizzBuzzApp.ValidateInput("1");
            Assert.AreEqual(true, result);
        }

        [Test]
        public void Invalid_Input_Test()
        {
            bool result = FizzBuzzApp.ValidateInput("abc");
            Assert.AreEqual(false, result);
        }

        [TestCase(1, "")]
        [TestCase(2, "")]
        [TestCase(3, Helpers.Helpers.MULTIPLEOFTHREE)]
        [TestCase(6, Helpers.Helpers.MULTIPLEOFTHREE)]
        [TestCase(5, Helpers.Helpers.MULTIPLEOFFIVE)]
        [TestCase(10, Helpers.Helpers.MULTIPLEOFFIVE)]
        public void ValidateFizzBuzz(int input, string expected)
        {
            string result = _service.Process(input);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
