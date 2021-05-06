    namespace WebflowSharp.Services.Sites
{
    public class SiteService : Service
    {
        public override string BasePath => "/sites";
        
        public SiteService() : base(null)
        {
        }
        
        public SiteService(IWebflowApiClient client) : base(client)
        {
        }
        
        
        // /// <summary>
        // /// List of all sites the provided access token is able to access.
        // /// </summary>
        // public virtual async Task<List<Entities.Site>> GetSites()
        // {
        //     var req = PrepareRequest("sites");
        //     return await ExecuteRequestAsync<List<Entities.Site>>(req, HttpMethod.Get);
        // }
        //
        // /// <summary>
        // /// Get Specific Site
        // /// </summary>
        // /// <param name="siteId">Unique identifier for the site</param>
        // /// <returns>The <see cref="Order"/>.</returns>
        // public virtual async Task<Entities.Site> GetSiteById(string siteId)
        // {
        //     var req = PrepareRequest($"sites/{siteId}");
        //     return await ExecuteRequestAsync<Entities.Site>(req, HttpMethod.Get);
        // }
        //
        // /// <summary>
        // /// Retrieve ecommerce settings for a site.
        // /// </summary>
        // /// <param name="siteId">Unique identifier for the site</param>
        // /// <returns>The <see cref="Order"/>.</returns>
        // public virtual async Task<EcommerceSettings> GetEcommerceSettings(string siteId)
        // {
        //     var req = PrepareRequest($"sites/{siteId}/ecommerce/settings");
        //     return await ExecuteRequestAsync<EcommerceSettings>(req, HttpMethod.Get);
        // }

        
    }
}
