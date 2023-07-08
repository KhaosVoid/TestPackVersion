using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestPackVersion.UnitTest
{
    [TestClass]
    public class UtitlityTest
    {
        [TestMethod]
        public void CanCreateSample1()
        {
            var sampleData = Utility.CreateSample1();

            sampleData.Property1.Should().Be("TestValue1");
            sampleData.Property2.Should().BeNull();
            sampleData.Property3.Should().BeNull();
        }

        [TestMethod]
        public void CanCreateSample2()
        {
            var sampleData = Utility.CreateSample2();

            sampleData.Property1.Should().Be("TestValue1");
            sampleData.Property2.Should().Be("TestValue2");
            sampleData.Property3.Should().BeNull();
        }

        [TestMethod]
        public void CanCreateSample3()
        {
            var sampleData = Utility.CreateSample3();

            sampleData.Property1.Should().Be("TestValue1");
            sampleData.Property2.Should().Be("TestValue2");
            sampleData.Property3.Should().Be("TestValue3");
        }
    }
}
