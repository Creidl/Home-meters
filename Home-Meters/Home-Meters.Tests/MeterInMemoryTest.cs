using Home_Meters.Meters;

namespace Home_Meters.Tests
{
    public class Tests
    {
        [Test]
        public void MaxConsumptionTest()
        {
            MeterInMemory meter = new MeterInMemory();
            meter.AddValue("100");
            meter.AddValue(102);
            meter.AddValue(106);
            Statistics statistics = meter.GetStatistics();

            Assert.That(statistics.MaxConsumption, Is.EqualTo(4));
        }

        [Test]
        public void MinConsumptionTest()
        {
            MeterInMemory meter = new MeterInMemory();
            meter.AddValue("100");
            meter.AddValue(102);
            meter.AddValue(106);
            Statistics statistics = meter.GetStatistics();

            Assert.That(statistics.MinConsumption, Is.EqualTo(2));
        }

        [Test]
        public void AverageConsumptionTest()
        {
            MeterInMemory meter = new MeterInMemory();
            meter.AddValue("100");
            meter.AddValue(102);
            meter.AddValue(106);
            Statistics statistics = meter.GetStatistics();

            Assert.That(statistics.AverageConsumption, Is.EqualTo(3));
        }

        [Test]
        public void CurrentConsumptionTest()
        {
            MeterInMemory meter = new MeterInMemory();
            meter.AddValue("100");
            meter.AddValue(102);
            meter.AddValue(106);
            Statistics statistics = meter.GetStatistics();

            Assert.That(statistics.CurrentConsumption, Is.EqualTo("Maximum"));
        }

        [Test]
        public void MeterValueTest()
        {
            MeterInMemory meter = new MeterInMemory();
            meter.AddValue("100");
            meter.AddValue(102);
            meter.AddValue(106);
            Statistics statistics = meter.GetStatistics();

            Assert.That(statistics.Value, Is.EqualTo(106));
        }

        [Test]
        public void MeterLastValueTest()
        {
            MeterInMemory meter = new MeterInMemory();
            meter.AddValue("100");
            meter.AddValue(102);
            meter.AddValue(106);
            Statistics statistics = meter.GetStatistics();

            Assert.That(statistics.LastValue, Is.EqualTo(102));
        }

    }
}