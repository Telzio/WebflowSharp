using System.Text.Json.Serialization;

namespace WebflowSharp.Services.Collections.Models
{
    public class SiteCollection
    {
        /// <summary>
        /// The unique identifier for the Collection
        /// </summary>
        [JsonPropertyName("_id")]
        public string Id { get; set; }

        /// <summary>
        /// Date Collection was last updated
        /// </summary>
        [JsonPropertyName("lastUpdated")]
        public string LastUpdated { get; set; }

        /// <summary>
        /// Date Collection was created
        /// </summary>
        [JsonPropertyName("createdOn")]
        public string CreatedOn { get; set; }

        /// <summary>
        /// Name given to Collection
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Slug of Collection in Site URL structure
        /// </summary>
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// The name of one Item in Collection (e.g. “post” if the Collection is called “Posts”)
        /// </summary>
        [JsonPropertyName("singularName")]
        public string SingularName { get; set; }
    }

    public class Validations
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("singleLine")]
        public bool? SingleLine { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("collectionId")]
        public string CollectionId { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("maxLength")]
        public long? MaxLength { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("messages")]
        public Messages Messages { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("pattern")]
        public Pattern Pattern { get; set; }
    }

    public class Messages
    {
        [JsonPropertyName("maxLength")]
        public string MaxLength { get; set; }

        [JsonPropertyName("pattern")]
        public string Pattern { get; set; }
    }

    public class Pattern
    {
    }
}
