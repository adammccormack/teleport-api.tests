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

        [InlineData("https://api.teleport.org/api/urban_areas/slug:cairo/scores/", "cairo")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:cape-town/scores/", "cape-town")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:casablanca/scores/", "casablanca")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:lagos/scores/", "lagos")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:nairobi/scores/", "nairobi")]

        [InlineData("https://api.teleport.org/api/urban_areas/slug:doha/scores/", "doha")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:manila/scores/", "manila")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:taipei/scores/", "taipei")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:hong-kong/scores/", "hong-kong")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:tokyo/scores/", "tokyo")]

        [InlineData("https://api.teleport.org/api/urban_areas/slug:bogota/scores/", "doha")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:caracas/scores/", "manila")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:medellin/scores/", "taipei")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:sao-paulo/scores/", "sao-paulo")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:porto-alegre/scores/", "porto-alegre")]

        [InlineData("https://api.teleport.org/api/urban_areas/slug:wellington/scores/", "wellington")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:adelaide/scores/", "adelaide")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:christ-church/scores/", "christ-church")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:melbourne/scores/", "melbourne")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:brisbane/scores/", "brisbane")]

        [InlineData("https://api.teleport.org/api/urban_areas/slug:aarhus/scores/", "aarhus")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:chisinau/scores/", "chisinau")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:lille/scores/", "lille")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:naples/scores/", "naples")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:vilnius/scores/", "vilnius")]
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
        [InlineData("https://api.teleport.org/api/urban_areas/slug:las-vegas/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:new-york/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:washington-dc/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:miami/scores/")]

        [InlineData("https://api.teleport.org/api/urban_areas/slug:cairo/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:cape-town/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:casablanca/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:lagos/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:nairobi/scores/")]

        [InlineData("https://api.teleport.org/api/urban_areas/slug:doha/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:manila/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:taipei/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:hong-kong/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:tokyo/scores/")]

        [InlineData("https://api.teleport.org/api/urban_areas/slug:bogota/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:caracas/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:medellin/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:sao-paulo/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:porto-alegre/scores/")]

        [InlineData("https://api.teleport.org/api/urban_areas/slug:wellington/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:adelaide/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:christ-church/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:melbourne/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:brisbane/scores/")]

        [InlineData("https://api.teleport.org/api/urban_areas/slug:aarhus/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:chisinau/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:lille/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:naples/scores/")]
        [InlineData("https://api.teleport.org/api/urban_areas/slug:vilnius/scores/")]
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
