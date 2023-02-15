using System.Net.Http;
using Newtonsoft.Json;
using Xunit;
using DemoLibrary2.Models;
using DemoLibrary2;
using DemoLibrary;

namespace teleport_api.tests
{
    public class ScoresProcessorTests
    {
        [Theory]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:boston/scores/", "boston")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:toronto/scores/", "toronto")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:new-york/scores/", "new-york")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:vancouver/scores/", "vancouver")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:montreal/scores/", "montreal")]

        [InlineData("https://api.teleport.org/api/urban_areas/slug:cairo/scores/", "cairo")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:cape-town/scores/", "cape-town")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:johannesburg/scores/", "johannesburg")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:tunis/scores/", "tunis")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:nairobi/scores/", "nairobi")]

        [InlineData("https://api.teleport.org/api/urban_areas/slug:singapore/scores/", "singapore")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:seoul/scores/", "seoul")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:osaka/scores/", "osaka")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:hong-kong/scores/", "hong-kong")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:tokyo/scores/", "tokyo")]

        [InlineData("https://api.teleport.org/api/urban_areas/slug:bogota/scores/", "bogota")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:santiago/scores/", "santiago")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:medellin/scores/", "medellin")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:montevideo/scores/", "montevideo")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:buenos-aires/scores/", "buenos-aires")]

        [InlineData("https://api.teleport.org/api/urban_areas/slug:wellington/scores/", "wellington")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:adelaide/scores/", "adelaide")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:sydney/scores/", "sydney")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:melbourne/scores/", "melbourne")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:brisbane/scores/", "brisbane")]

        [InlineData("https://api.teleport.org/api/urban_areas/slug:munich/scores/", "munich")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:berlin/scores/", "berlin")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:amsterdam/scores/", "amsterdam")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:london/scores/", "london")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:copenhagen/scores/", "copenhagen")]

        public async Task LoadScores_ShouldReturnScores_WhenCalledWithValidInput(string url, string city)
        {
            // Arrange
            ApiHelper.InitializeClient();

            // Act
            var scores = await ScoresProcessor.LoadScores(url);

            // Assert
            Assert.NotNull(scores);
            Assert.IsType<ScoresModel.Scores.Root>(scores);
        }

        [Theory]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:boston/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:toronto/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:new-york/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:vancouver/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:montreal/scores/")]

        [InlineData("https://api.teleport.org/api/urban_areas/slug:cairo/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:cape-town/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:johannesburg/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:tunis/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:nairobi/scores/")]

        [InlineData("https://api.teleport.org/api/urban_areas/slug:singapore/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:seoul/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:osaka/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:hong-kong/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:tokyo/scores/")]

        [InlineData("https://api.teleport.org/api/urban_areas/slug:bogota/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:santiago/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:medellin/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:montevideo/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:buenos-aires/scores/")]

        [InlineData("https://api.teleport.org/api/urban_areas/slug:wellington/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:adelaide/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:sydney/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:melbourne/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:brisbane/scores/")]

        [InlineData("https://api.teleport.org/api/urban_areas/slug:munich/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:berlin/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:amsterdam/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:london/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:copenhagen/scores/")]

        public async Task LoadScores_ShouldThrowException_WhenCalledWithInvalidInput(string url)
        {
            // Arrange
            ApiHelper.InitializeClient();

            // Act
            Func<Task> act = async () => await ScoresProcessor.LoadScores("invalid-city");

            // Assert
            Exception ex = await Assert.ThrowsAsync<Exception>(() => ScoresProcessor.LoadScores("invalid-city"));
        }
    }
}
