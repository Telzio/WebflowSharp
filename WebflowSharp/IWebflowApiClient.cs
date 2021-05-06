using WebflowSharp.Services.Collections;
using WebflowSharp.Services.Items;
using WebflowSharp.Services.Sites;

namespace WebflowSharp
{
    public interface IWebflowApiClient
    {
        string ApiToken { get; }
        string ApiBase { get; }
                
        SiteService Sites { get; }
        CollectionService Collections { get; }
        ItemService Items { get; }
    }
}