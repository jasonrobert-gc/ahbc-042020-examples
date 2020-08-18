using Class54.Services;
using Moq;
using Moq.Protected;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mime;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Class54Tests
{
    public class ApiPersonServiceTests
    {
        [Fact]
        public async Task Forbidden_Throws_Exception()
        {
            // Arrange
            var httpHandlerMock = new Mock<HttpMessageHandler>();
            var httpResponse = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.Forbidden
            };

            httpHandlerMock.Protected()
                .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>())
            .Returns(Task.FromResult(httpResponse));

            var httpClient = new HttpClient(httpHandlerMock.Object)
            {
                BaseAddress = new Uri("https://test.com")
            };

            // Act
            var sut = new ApiPersonService(httpClient);

            // Assert
            await Assert.ThrowsAsync<HttpRequestException>(() => sut.GetAll());
        }

        [Fact]
        public async Task SingleResult_Serializes_Correctly()
        {
            // Arrange
            var httpHandlerMock = new Mock<HttpMessageHandler>();
            var httpResponse = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent("{ \"count\": 1, \"results\": [ { \"name\": \"Jason\" } ] }"),
            };
            httpResponse.Content.Headers.Remove("Content-Type");
            httpResponse.Content.Headers.Add("Content-Type", "application/json");
            httpHandlerMock.Protected()
                .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>())
            .Returns(Task.FromResult(httpResponse));

            var httpClient = new HttpClient(httpHandlerMock.Object)
            {
                BaseAddress = new Uri("https://test.com")
            };

            // Act
            var sut = new ApiPersonService(httpClient);
            var response = await sut.GetAll();

            // Assert
            Assert.Single(response);
            Assert.Equal("Jason", response.Single().Name);
        }

        [Theory]
        [InlineData("{ \"count\": 0, \"results\": [ ] }")]
        [InlineData("{ \"results\": [ ] }")]
        [InlineData("{ }")]
        public async Task EmptyResult_Serializes_Correctly(string json)
        {
            // Arrange
            var httpHandlerMock = new Mock<HttpMessageHandler>();
            var httpResponse = new HttpResponseMessage
            {
                StatusCode = HttpStatusCode.OK,
                Content = new StringContent(json),
            };
            httpResponse.Content.Headers.Remove("Content-Type");
            httpResponse.Content.Headers.Add("Content-Type", "application/json");
            httpHandlerMock.Protected()
                .Setup<Task<HttpResponseMessage>>(
                "SendAsync",
                ItExpr.IsAny<HttpRequestMessage>(),
                ItExpr.IsAny<CancellationToken>())
            .Returns(Task.FromResult(httpResponse));

            var httpClient = new HttpClient(httpHandlerMock.Object)
            {
                BaseAddress = new Uri("https://test.com")
            };

            // Act
            var sut = new ApiPersonService(httpClient);
            var response = await sut.GetAll();

            // Assert
            Assert.Empty(response);
        }
    }
}

