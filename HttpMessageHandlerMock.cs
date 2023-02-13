using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace teleport_api.tests;

public class HttpMessageHandlerMock : HttpMessageHandler
{
    private readonly bool _isSuccessStatusCode;

    public HttpMessageHandlerMock(bool isSuccessStatusCode)
    {
        _isSuccessStatusCode = isSuccessStatusCode;
    }

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var response = new HttpResponseMessage
        {
            StatusCode = _isSuccessStatusCode ? System.Net.HttpStatusCode.OK : System.Net.HttpStatusCode.BadRequest,
        };

        return Task.FromResult(response);
    }
}
