using System;
using Microsoft.Owin.Hosting;

namespace HttpStubServer
{
    public class HttpStub
    {
        private IDisposable _app;

        private readonly string _baseUrl;

        public HttpStub(string url)
        {
            _baseUrl = url;
        }

        public void Start()
        {
            _app = WebApp.Start<Startup>(url: _baseUrl);

        }

        public void Stop()
        {
            if (_app == null)
                return;

            _app.Dispose();
            _app = null;
        }

        public void Tell(string apiValues, Func<string,string> func)
        {
            throw new NotImplementedException();
        }
    }
}