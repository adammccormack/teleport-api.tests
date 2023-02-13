using System;
using System.Net.Http;
using System.Threading.Tasks;
using DemoLibrary;
using DemoLibrary2;
using DemoLibrary2.Models;
using Moq;
using Newtonsoft.Json;
using teleport_api.tests;
using Xunit;

namespace DemoLibrary2.Tests
{
    public class UrbanAreasProcessorTests
    {   
        [Fact]
        public async Task LoadAfricaUrbanAreas_ShouldReturnAfricaUrbanAreasObject()
        {
            // Arrange
            ApiHelper.InitializeClient();

            // Act
            UrbanAreasModel.UrbanAreas.Root result = await UrbanAreasProcessor.LoadAfricaUrbanAreas();

            // Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<UrbanAreasModel.UrbanAreas.Root>(result);
        }

        [Fact]
        public async Task LoadAfricaUrbanAreas_ShouldThrowException_WhenResponseIsNotSuccessful()
        {
            // Arrange
            var httpClient = new HttpClient(new HttpMessageHandlerMock(false));
            ApiHelper.ApiClient = httpClient;

            // Act
            Exception ex = await Assert.ThrowsAsync<Exception>(() => UrbanAreasProcessor.LoadAfricaUrbanAreas());

            // Assert
            Assert.NotNull(ex);
            Assert.IsType<Exception>(ex);
        }

        [Fact]
        public async Task LoadAsiaUrbanAreas_ShouldReturnAsiaUrbanAreasObject()
        {
            // Arrange
            ApiHelper.InitializeClient();

            // Act
            UrbanAreasModel.UrbanAreas.Root result = await UrbanAreasProcessor.LoadAsiaUrbanAreas();

            // Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<UrbanAreasModel.UrbanAreas.Root>(result);
        }

        [Fact]
        public async Task LoadAsiaUrbanAreas_ShouldThrowException_WhenResponseIsNotSuccessful()
        {
            // Arrange
            var httpClient = new HttpClient(new HttpMessageHandlerMock(false));
            ApiHelper.ApiClient = httpClient;

            // Act
            Exception ex = await Assert.ThrowsAsync<Exception>(() => UrbanAreasProcessor.LoadAsiaUrbanAreas());

            // Assert
            Assert.NotNull(ex);
            Assert.IsType<Exception>(ex);
        }

        [Fact]
        public async Task LoadSouthAmericaUrbanAreas_ShouldReturnSouthAmericaUrbanAreasObject()
        {
            // Arrange
            ApiHelper.InitializeClient();

            // Act
            UrbanAreasModel.UrbanAreas.Root result = await UrbanAreasProcessor.LoadSouthAmericaUrbanAreas();

            // Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<UrbanAreasModel.UrbanAreas.Root>(result);
        }

        [Fact]
        public async Task LoadSouthAmericaUrbanAreas_ShouldThrowException_WhenResponseIsNotSuccessful()
        {
            // Arrange
            var httpClient = new HttpClient(new HttpMessageHandlerMock(false));
            ApiHelper.ApiClient = httpClient;

            // Act
            Exception ex = await Assert.ThrowsAsync<Exception>(() => UrbanAreasProcessor.LoadSouthAmericaUrbanAreas());

            // Assert
            Assert.NotNull(ex);
            Assert.IsType<Exception>(ex);
        }

        [Fact]
        public async Task LoadNorthAmericaUrbanAreas_ShouldReturnNorthAmericaUrbanAreasObject()
        {
            // Arrange
            ApiHelper.InitializeClient();

            // Act
            UrbanAreasModel.UrbanAreas.Root result = await UrbanAreasProcessor.LoadNorthAmericaUrbanAreas();

            // Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<UrbanAreasModel.UrbanAreas.Root>(result);
        }

        [Fact]
        public async Task LoadNorthAmericaUrbanAreas_ShouldThrowException_WhenResponseIsNotSuccessful()
        {
            // Arrange
            var httpClient = new HttpClient(new HttpMessageHandlerMock(false));
            ApiHelper.ApiClient = httpClient;

            // Act
            Exception ex = await Assert.ThrowsAsync<Exception>(() => UrbanAreasProcessor.LoadNorthAmericaUrbanAreas());

            // Assert
            Assert.NotNull(ex);
            Assert.IsType<Exception>(ex);
        }

        [Fact]
        public async Task LoadOceaniaUrbanAreas_ShouldReturnOceaniaUrbanAreasObject()
        {
            // Arrange
            ApiHelper.InitializeClient();

            // Act
            UrbanAreasModel.UrbanAreas.Root result = await UrbanAreasProcessor.LoadOceaniaUrbanAreas();

            // Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<UrbanAreasModel.UrbanAreas.Root>(result);
        }

        [Fact]
        public async Task LoadOceaniaUrbanAreas_ShouldThrowException_WhenResponseIsNotSuccessful()
        {
            // Arrange
            var httpClient = new HttpClient(new HttpMessageHandlerMock(false));
            ApiHelper.ApiClient = httpClient;

            // Act
            Exception ex = await Assert.ThrowsAsync<Exception>(() => UrbanAreasProcessor.LoadOceaniaUrbanAreas());

            // Assert
            Assert.NotNull(ex);
            Assert.IsType<Exception>(ex);
        }

        [Fact]
        public async Task LoadEuropeUrbanAreas_ShouldReturnEuropeUrbanAreasObject()
        {
            // Arrange
            ApiHelper.InitializeClient();

            // Act
            UrbanAreasModel.UrbanAreas.Root result = await UrbanAreasProcessor.LoadEuropeUrbanAreas();

            // Assert
            Assert.NotNull(result);
            Assert.IsAssignableFrom<UrbanAreasModel.UrbanAreas.Root>(result);
        }

        [Fact]
        public async Task LoadEuropeUrbanAreas_ShouldThrowException_WhenResponseIsNotSuccessful()
        {
            // Arrange
            var httpClient = new HttpClient(new HttpMessageHandlerMock(false));
            ApiHelper.ApiClient = httpClient;

            // Act
            Exception ex = await Assert.ThrowsAsync<Exception>(() => UrbanAreasProcessor.LoadEuropeUrbanAreas());

            // Assert
            Assert.NotNull(ex);
            Assert.IsType<Exception>(ex);
        }
    }
}
