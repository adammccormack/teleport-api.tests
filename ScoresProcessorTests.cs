using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xunit;
using Moq;
using DemoLibrary2.Models;
using DemoLibrary2;
using DemoLibrary;

namespace teleport_api.tests
{
    public class ScoresProcessorTests
    {
        [Theory]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:boston/scores/", "boston")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:las-vegas/scores/", "las-vegas")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:new-york/scores/", "new-york")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:washington-dc/scores/", "washington-dc")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:miami/scores/", "miami")]

        public async Task LoadScores_ShouldReturnScores_WhenCalledWithValidInput(string url, string city)
        {
            // Arrange
            ApiHelper.InitializeClient();

            // Act
            var scores = await ScoresProcessor.NorthAmerica.LoadScoresByCity(city);

            // Assert
            Assert.NotNull(scores);
            Assert.IsType<ScoresModel.Scores.Root>(scores);
        }

        [Theory]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:boston/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:las-vegas/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:new-york/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:washington-dc/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:miami/scores/")]
        public async Task LoadScores_ShouldThrowException_WhenCalledWithInvalidInput(string url)
        {
            // Arrange
            ApiHelper.InitializeClient();

            // Act
            Func<Task> act = async () => await ScoresProcessor.NorthAmerica.LoadScoresByCity("invalid-city");

            // Assert
            Exception ex = await Assert.ThrowsAsync<Exception>(() => ScoresProcessor.NorthAmerica.LoadScoresByCity("invalid-city"));
        }
    }
}
            //    // North America
            //    [Fact]
            //    public async Task LoadBostonScores_ShouldReturnBostonScoresObject()
            //    {
            //        // Arrange
            //        ApiHelper.InitializeClient();

//        // Act
//        ScoresModel.Scores.Root result = await ScoresProcessor.NorthAmerica.LoadBostonScores();

//        // Assert
//        Assert.NotNull(result);
//        Assert.IsAssignableFrom<ScoresModel.Scores.Root>(result);
//    }

//    [Fact]
//    public async Task LoadBostonScores_ShouldThrowException_WhenResponseIsNotSuccessful()
//    {
//        // Arrange
//        var httpClient = new HttpClient(new HttpMessageHandlerMock(false));
//        ApiHelper.ApiClient = httpClient;

//        // Act
//        Exception ex = await Assert.ThrowsAsync<Exception>(() => ScoresProcessor.NorthAmerica.LoadBostonScores());

//        // Assert
//        Assert.NotNull(ex);
//        Assert.IsType<Exception>(ex);
//    }

//    [Fact]
//    public async Task LoadLasVegasScores_ShouldReturnLasVegasObject()
//    {
//        // Arrange
//        ApiHelper.InitializeClient();

//        // Act
//        ScoresModel.Scores.Root result = await ScoresProcessor.NorthAmerica.LoadLasVegasScores();

//        // Assert
//        Assert.NotNull(result);
//        Assert.IsAssignableFrom<ScoresModel.Scores.Root>(result);
//    }

//    [Fact]
//    public async Task LoadLasVegasScores_ShouldThrowException_WhenResponseIsNotSuccessful()
//    {
//        // Arrange
//        var httpClient = new HttpClient(new HttpMessageHandlerMock(false));
//        ApiHelper.ApiClient = httpClient;

//        // Act
//        Exception ex = await Assert.ThrowsAsync<Exception>(() => ScoresProcessor.NorthAmerica.LoadLasVegasScores());

//        // Assert
//        Assert.NotNull(ex);
//        Assert.IsType<Exception>(ex);
//    }

//    [Fact]
//    public async Task LoadNewYorkScores_ShouldReturnNewYorkScoresObject()
//    {
//        // Arrange
//        ApiHelper.InitializeClient();

//        // Act
//        ScoresModel.Scores.Root result = await ScoresProcessor.NorthAmerica.LoadNewYorkScores();

//        // Assert
//        Assert.NotNull(result);
//        Assert.IsAssignableFrom<ScoresModel.Scores.Root>(result);
//    }

//    [Fact]
//    public async Task LoadNewYorkScores_ShouldThrowException_WhenResponseIsNotSuccessful()
//    {
//        // Arrange
//        var httpClient = new HttpClient(new HttpMessageHandlerMock(false));
//        ApiHelper.ApiClient = httpClient;

//        // Act
//        Exception ex = await Assert.ThrowsAsync<Exception>(() => ScoresProcessor.NorthAmerica.LoadNewYorkScores());

//        // Assert
//        Assert.NotNull(ex);
//        Assert.IsType<Exception>(ex);
//    }

//    [Fact]
//    public async Task LoadWashingtonDCScores_ShouldReturnWashingtonDCScoresObject()
//    {
//        // Arrange
//        ApiHelper.InitializeClient();

//        // Act
//        ScoresModel.Scores.Root result = await ScoresProcessor.NorthAmerica.LoadWashingtonDCScores();

//        // Assert
//        Assert.NotNull(result);
//        Assert.IsAssignableFrom<ScoresModel.Scores.Root>(result);
//    }

//    [Fact]
//    public async Task LoadWashingtonDCScores_ShouldThrowException_WhenResponseIsNotSuccessful()
//    {
//        // Arrange
//        var httpClient = new HttpClient(new HttpMessageHandlerMock(false));
//        ApiHelper.ApiClient = httpClient;

//        // Act
//        Exception ex = await Assert.ThrowsAsync<Exception>(() => ScoresProcessor.NorthAmerica.LoadWashingtonDCScores());

//        // Assert
//        Assert.NotNull(ex);
//        Assert.IsType<Exception>(ex);
//    }

//    [Fact]
//    public async Task LoadMiamiScores_ShouldReturnMiamiObject()
//    {
//        // Arrange
//        ApiHelper.InitializeClient();

//        // Act
//        ScoresModel.Scores.Root result = await ScoresProcessor.NorthAmerica.LoadMiamiScores();

//        // Assert
//        Assert.NotNull(result);
//        Assert.IsAssignableFrom<ScoresModel.Scores.Root>(result);
//    }

//    [Fact]
//    public async Task LoadMiamiScores_ShouldThrowException_WhenResponseIsNotSuccessful()
//    {
//        // Arrange
//        var httpClient = new HttpClient(new HttpMessageHandlerMock(false));
//        ApiHelper.ApiClient = httpClient;

//        // Act
//        Exception ex = await Assert.ThrowsAsync<Exception>(() => ScoresProcessor.NorthAmerica.LoadMiamiScores());

//        // Assert
//        Assert.NotNull(ex);
//        Assert.IsType<Exception>(ex);
//    }

//    [Fact]
//    public async Task NorthAmericaProcessNameAndScores_ShouldReturnTeleportViewModelObject()
//    {
//        // Arrange
//        ApiHelper.InitializeClient();

//        // Act
//        TeleportViewModel result = await ScoresProcessor.NorthAmerica.ProcessNameAndScores();

//        // Assert
//        Assert.NotNull(result);
//        Assert.IsAssignableFrom<TeleportViewModel>(result);
//    }

//    [Fact]
//    public async Task ProcessNameAndScores_ShouldThrowException_WhenResponseIsNotSuccessful()
//    {
//        // Arrange
//        var httpClient = new HttpClient(new HttpMessageHandlerMock(false));
//        ApiHelper.ApiClient = httpClient;

//        // Act
//        Exception ex = await Assert.ThrowsAsync<Exception>(() => ScoresProcessor.NorthAmerica.ProcessNameAndScores());

//        // Assert
//        Assert.NotNull(ex);
//        Assert.IsType<Exception>(ex);
//    }

//    // Africa
//    [Fact]
//    public async Task LoadCairoScores_ShouldReturnBostonScoresObject()
//    {
//        // Arrange
//        ApiHelper.InitializeClient();

//        // Act
//        ScoresModel.Scores.Root result = await ScoresProcessor.Africa.LoadCairoScores();

//        // Assert
//        Assert.NotNull(result);
//        Assert.IsAssignableFrom<ScoresModel.Scores.Root>(result);
//    }

//    [Fact]
//    public async Task LoadCairoScores_ShouldThrowException_WhenResponseIsNotSuccessful()
//    {
//        // Arrange
//        var httpClient = new HttpClient(new HttpMessageHandlerMock(false));
//        ApiHelper.ApiClient = httpClient;

//        // Act
//        Exception ex = await Assert.ThrowsAsync<Exception>(() => ScoresProcessor.Africa.LoadCairoScores());

//        // Assert
//        Assert.NotNull(ex);
//        Assert.IsType<Exception>(ex);
//    }

//    [Fact]
//    public async Task LoadCapeTownScores_ShouldReturnBostonScoresObject()
//    {
//        // Arrange
//        ApiHelper.InitializeClient();

//        // Act
//        ScoresModel.Scores.Root result = await ScoresProcessor.Africa.LoadCapeTownScores();

//        // Assert
//        Assert.NotNull(result);
//        Assert.IsAssignableFrom<ScoresModel.Scores.Root>(result);
//    }

//    [Fact]
//    public async Task LoadCapeTownScores_ShouldThrowException_WhenResponseIsNotSuccessful()
//    {
//        // Arrange
//        var httpClient = new HttpClient(new HttpMessageHandlerMock(false));
//        ApiHelper.ApiClient = httpClient;

//        // Act
//        Exception ex = await Assert.ThrowsAsync<Exception>(() => ScoresProcessor.Africa.LoadCapeTownScores());

//        // Assert
//        Assert.NotNull(ex);
//        Assert.IsType<Exception>(ex);
//    }

//    [Fact]
//    public async Task LoadCasablancaScores_ShouldReturnBostonScoresObject()
//    {
//        // Arrange
//        ApiHelper.InitializeClient();

//        // Act
//        ScoresModel.Scores.Root result = await ScoresProcessor.Africa.LoadCasablancaScores();

//        // Assert
//        Assert.NotNull(result);
//        Assert.IsAssignableFrom<ScoresModel.Scores.Root>(result);
//    }

//    [Fact]
//    public async Task LoadCasablancaScores_ShouldThrowException_WhenResponseIsNotSuccessful()
//    {
//        // Arrange
//        var httpClient = new HttpClient(new HttpMessageHandlerMock(false));
//        ApiHelper.ApiClient = httpClient;

//        // Act
//        Exception ex = await Assert.ThrowsAsync<Exception>(() => ScoresProcessor.Africa.LoadCasablancaScores());

//        // Assert
//        Assert.NotNull(ex);
//        Assert.IsType<Exception>(ex);
//    }

//    [Fact]
//    public async Task LoadLagosScores_ShouldReturnBostonScoresObject()
//    {
//        // Arrange
//        ApiHelper.InitializeClient();

//        // Act
//        ScoresModel.Scores.Root result = await ScoresProcessor.Africa.LoadLagosScores();

//        // Assert
//        Assert.NotNull(result);
//        Assert.IsAssignableFrom<ScoresModel.Scores.Root>(result);
//    }

//    [Fact]
//    public async Task LoadLagosScores_ShouldThrowException_WhenResponseIsNotSuccessful()
//    {
//        // Arrange
//        var httpClient = new HttpClient(new HttpMessageHandlerMock(false));
//        ApiHelper.ApiClient = httpClient;

//        // Act
//        Exception ex = await Assert.ThrowsAsync<Exception>(() => ScoresProcessor.Africa.LoadLagosScores());

//        // Assert
//        Assert.NotNull(ex);
//        Assert.IsType<Exception>(ex);
//    }

//    [Fact]
//    public async Task LoadNairobiScores_ShouldReturnBostonScoresObject()
//    {
//        // Arrange
//        ApiHelper.InitializeClient();

//        // Act
//        ScoresModel.Scores.Root result = await ScoresProcessor.Africa.LoadNairobiScores();

//        // Assert
//        Assert.NotNull(result);
//        Assert.IsAssignableFrom<ScoresModel.Scores.Root>(result);
//    }

//    [Fact]
//    public async Task LoadNairobiScores_ShouldThrowException_WhenResponseIsNotSuccessful()
//    {
//        // Arrange
//        var httpClient = new HttpClient(new HttpMessageHandlerMock(false));
//        ApiHelper.ApiClient = httpClient;

//        // Act
//        Exception ex = await Assert.ThrowsAsync<Exception>(() => ScoresProcessor.Africa.LoadNairobiScores());

//        // Assert
//        Assert.NotNull(ex);
//        Assert.IsType<Exception>(ex);
//    }

//    [Fact]
//    public async Task AfricaProcessNameAndScores_ShouldThrowException_WhenResponseIsNotSuccessful()
//    {
//        // Arrange
//        var httpClient = new HttpClient(new HttpMessageHandlerMock(false));
//        ApiHelper.ApiClient = httpClient;

//        // Act
//        Exception ex = await Assert.ThrowsAsync<Exception>(() => ScoresProcessor.Africa.ProcessNameAndScores());

//        // Assert
//        Assert.NotNull(ex);
//        Assert.IsType<Exception>(ex);
//    }
//}


