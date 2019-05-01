using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AppCenter.Api
{
    public class ApiKeyHttpClientHandler : HttpClientHandler
    {
        private readonly Func<Task<string>> _getHeaderValue;

        public ApiKeyHttpClientHandler(Func<Task<string>> headerValue)
        {
            _getHeaderValue = headerValue ?? throw new ArgumentNullException(nameof(headerValue));
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Remove("X-API-Token");
            request.Headers.Add("X-API-Token", await _getHeaderValue());

            return await base.SendAsync(request, cancellationToken);
        }
    }
}
