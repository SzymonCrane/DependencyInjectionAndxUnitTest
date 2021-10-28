using AutoFixture;
using DependencyInjectionTest;
using Moq;
using Xunit;

namespace UnitTests
{
    public class WorkerTests
    {
        private readonly Fixture fixture;
        public WorkerTests()
        {
            fixture = new Fixture();
        }
        [Fact]
        public void GetText_When_Should()
        {
            // Arrange
            var message = new Mock<IMessageWriter>();
            message.Setup(x => x.GetText(It.IsAny<string>())).Returns("Hej");
            var worker = new Worker(message.Object);
            var car = fixture.Create<Car>();
            
            // Act
            var hello = worker.GetText("Hello");

            // Assert
            message.Verify(x => x.GetText("Wilkommen"));
        }

    }
}
