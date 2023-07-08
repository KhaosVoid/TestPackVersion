using TestPackVersion.Data;

namespace TestPackVersion
{
    public static class Utility
    {
        public static SampleData CreateSample1()
        {
            return new SampleData()
            {
                Property1 = "TestValue1"
            };
        }

        public static SampleData CreateSample2()
        {
            return new SampleData()
            {
                Property1 = "TestValue1",
                Property2 = "TestValue2"
            };
        }

        public static SampleData CreateSample3()
        {
            return new SampleData()
            {
                Property1 = "TestValue1",
                Property2 = "TestValue2",
                Property3 = "TestValue3"
            };
        }
    }
}
