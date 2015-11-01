using System;
using Microsoft.Owin.Builder;
using Microsoft.Owin.Hosting;

namespace HttpStubServer
{
    public class HttpStub
    {
        private IDisposable _app;

        private readonly string _baseUrl;
        private readonly ILogger _logger;

        public HttpStub(string url)
            : this(url, NullLogger.Instance)
        {
        }

        public HttpStub(string url, ILogger logger)
        {
            _logger = logger;
            _baseUrl = url;
        }

        public void Start()
        {
            _app = WebApp.Start<Startup>(url: _baseUrl);

            var builder = new AppBuilder();


        }

        public void Stop()
        {
            if (_app == null)
                return;

            _app.Dispose();
            _app = null;
        }

        public void Tell(string apiValues, Func<string, string> func)
        {
            throw new NotImplementedException();
        }
    }
}