namespace WebflowSharp.Services
{
    public abstract class Service
    {
        private readonly IWebflowApiClient _client;

        protected Service(IWebflowApiClient client)
        {
            this._client = client;
        }

        public abstract string BasePath { get; }

        public virtual string BaseUrl => this._client.ApiBase;
    }
}