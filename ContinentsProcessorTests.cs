using System.Net.Http;
using Newtonsoft.Json;
using Xunit;
using DemoLibrary2.Models;
using DemoLibrary2;
using DemoLibrary;

namespace teleport_api.tests
{
    public class ContinentsProcessorTests
    {
        [Fact]
        public async Task LoadContinents_ShouldReturnContinentsObject()
        {
            // Arrange
            ApiHelper.InitializeClient();

            // Act
            ContinentsModel.Root result = await ContinentsProcessor.LoadContinents();

            // Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<ContinentsModel.Root>(result);
        }

        [Fact]
        public async Task LoadContinents_ShouldThrowException_WhenResponseIsNotSuccessful()
        {
            // Arrange
            var httpClient = new HttpClient(new HttpMessageHandlerMock(false));
            ApiHelper.ApiClient = httpClient;

            // Act
            Exception ex = await Assert.ThrowsAsync<Exception>(() => ContinentsProcessor.LoadContinents());

            // Assert
            Assert.NotNull(ex);
            Assert.IsType<Exception>(ex);
        }
    }
}
