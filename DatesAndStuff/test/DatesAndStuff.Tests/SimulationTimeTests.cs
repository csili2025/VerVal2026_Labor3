namespace DatesAndStuff.Tests
{
    public sealed class SimulationTimeTests
    {
        [OneTimeSetUp]
        public void OneTimeSetupStuff()
        {
            // Setup code that runs once before all tests, if needed.
        }

        [SetUp]
        public void Setup()
        {
            // Setup code that runs before each test, if needed.
        }

        [TearDown]
        public void TearDown()
        {
            // Cleanup code that runs after each test, if needed.
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            // Cleanup code that runs once after all tests, if needed.
        }

        private class Constructors
        {
            [Test]
            public void Constructor_DateOnly_DiffersFromExactCurrentTime()
            {
                // Arrange
                var sut = new SimulationTime(2026, 2, 26);
                var now = SimulationTime.Now;

                // Act

                // Assert
                Assert.That(now.TotalMilliseconds, Is.Not.EqualTo(sut.TotalMilliseconds), "Should not be equal");
            }

            [Test]
            // Default time is not current time.
            public void SimulationTime_DefaultConstructor_ShouldNotBeCurrentTime()
            {
                // Arrange
                var sut = new SimulationTime();

                // Act
                var now = SimulationTime.Now;

                // Assert
                Assert.That(now.TotalMilliseconds, Is.Not.EqualTo(sut.TotalMilliseconds), "Should not be equal");
            }
        }

        [Test]
        public void SimulationTime_EqualsOperator_ShouldReturnTrueForEqualInstances()
        {
            // Arrange
            var sut1 = new SimulationTime(2026, 2, 26);
            var sut2 = new SimulationTime(2026, 2, 26);
            // Act
            // Assert
            Assert.That(sut1, Is.EqualTo(sut2), "Should be equal");
        }

        [Test]
        public void SimulationTime_NotEqualsOperator_ShouldReturnFalseForEqualInstances()
        {
            // Arrange
            var sut1 = new SimulationTime(2026, 2, 26);
            var sut2 = new SimulationTime(2026, 2, 26);
            // Act
            // Assert
            Assert.That(sut1, Is.Not.EqualTo(sut2), "Should be equal");
        }

        [Test]
        public void SimulationTime_GreaterThanOperator_ShouldReturnFalseForEqualInstances()
        {
            // Arrange
            var sut1 = new SimulationTime(2026, 2, 26);
            var sut2 = new SimulationTime(2026, 2, 26);
            // Act
            // Assert
            Assert.That(sut1 > sut2, Is.False, "Should not be greater than");
        }

        [Test]
        public void SimulationTime_LessThanOperator_ShouldReturnFalseForEqualInstances()
        {
            // Arrange
            var sut1 = new SimulationTime(2026, 2, 26);
            var sut2 = new SimulationTime(2026, 2, 26);
            // Act
            // Assert
            Assert.That(sut1 < sut2, Is.False, "Should not be less than");
        }

        [Test]
        public void SimulationTime_GreaterThanOrEqualOperator_ShouldReturnTrueForEqualInstances()
        {
            // Arrange
            var sut1 = new SimulationTime(2026, 2, 26);
            var sut2 = new SimulationTime(2026, 2, 26);
            // Act
            // Assert
            Assert.That(sut1 >= sut2, Is.True, "Should be greater than or equal");
        }

        [Test]
        public void SimulationTime_MaxValue_ShouldBeGreaterThanAnyOtherInstance()
        {
            // Arrange
            var sut = SimulationTime.MaxValue;
            var other = new SimulationTime(2026, 2, 26);
            // Act
            // Assert
            Assert.That(sut > other, Is.True, "MaxValue should be greater than any other instance");
        }

        [Test]
        public void SimulationTime_MinValue_ShouldBeLessThanAnyOtherInstance()
        {
            // Arrange
            var sut = SimulationTime.MinValue;
            var other = new SimulationTime(2026, 2, 26);
            // Act
            // Assert
            Assert.That(sut < other, Is.True, "MinValue should be less than any other instance");
        }

        private class TimeSpanArithmeticTests
        {
            [Test]
            public void Addition_SimulationTimeIsShifted()
            {
                // Arrange
                DateTime baseDate = new DateTime(2010, 8, 23, 9, 4, 49);
                SimulationTime sut = new SimulationTime(baseDate);
                var ts = TimeSpan.FromMilliseconds(4544313);

                // Act
                var result = sut + ts;

                // Assert
                var expectedDateTime = baseDate + ts;
                Assert.That(result.ToAbsoluteDateTime(), Is.EqualTo(expectedDateTime));
            }

            [Test]
            public void Subtraction_SimulationTimeShifted()
            {
                // Arrange
                DateTime baseDate = new DateTime(2010, 8, 23, 9, 4, 49);
                SimulationTime sut = new SimulationTime(baseDate);
                var ts = TimeSpan.FromMilliseconds(4544313);

                // Act
                var result = sut - ts;

                // Assert
                var expectedDateTime = baseDate - ts;
                Assert.That(result.ToAbsoluteDateTime(), Is.EqualTo(expectedDateTime));
            }
        }

        [Test]
        // Next millisec calculation works
        public void GivenSimulationTime_WhenCalculatingNextMillisec_ThenReturnsCorrectValue()
        {
            throw new NotImplementedException();
        }

        [Test]
        // Create a SimulationTime from a DateTime, add the same milliseconds to both and check if they are still equal
        public void GivenDateTimeAndSimulationTime_WhenAddingMilliseconds_ThenTimesShouldBeEqual()
        {
            throw new NotImplementedException();
        }

        [Test]
        // The same as before just with seconds
        public void GiveDateTimeAndSimulationTime_WhenAddingSeconds_ThenTimesShouldBeEqual()
        {
            throw new NotImplementedException();
        }

        [Test]
        // Check string representation given by ToString
        public void SimulationTime_ToString_ReturnsExpectedString()
        {
            // Arrange
            var sut = new SimulationTime(2026, 2, 26);

            // Act
            var result = sut.ToString();

            // Assert
            Assert.That(result, Is.EqualTo("2026-02-26T00:00:00"));
        }
    }
}