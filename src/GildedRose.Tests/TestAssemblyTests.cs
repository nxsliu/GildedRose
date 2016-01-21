using System.Linq;
using GildedRose.Console;
using Xunit;

namespace GildedRose.Tests
{
    public class TestAssemblyTests
    {
        [Fact]
        public void TestTheTruth()
        {
            Assert.True(true);
        }

        [Fact]
        public void After1DaySellinAndQualityDecreasedBy1()
        {
            var qc = new QualityCalculator();

            qc.UpdateQuality();

            Assert.Equal(19, qc.Items.Single(i => i.Name == "+5 Dexterity Vest").Quality);
        }
    }
}