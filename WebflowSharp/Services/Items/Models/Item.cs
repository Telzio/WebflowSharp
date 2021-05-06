using System;
using System.Text.Json.Serialization;
using WebflowSharp.Entities;

namespace WebflowSharp.Services.Items.Models
{
    public class Item
    {
        /// <summary>
        /// Boolean determining if the Item is set to archived
        /// </summary>
        [JsonPropertyName("_archived")]
        public bool Archived { get; set; }

        /// <summary>
        /// Boolean determining if the Item is set to draft
        /// </summary>
        [JsonPropertyName("_draft")]
        public bool Draft { get; set; }

        [JsonPropertyName("color")]
        public string Color { get; set; }

        [JsonPropertyName("featured")]
        public bool Featured { get; set; }

        /// <summary>
        /// Name given to the Item
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("post-body")]
        public string PostBody { get; set; }

        [JsonPropertyName("post-summary")]
        public string PostSummary { get; set; }

        [JsonPropertyName("thumbnail-image")]
        public Image ThumbnailImage { get; set; }

        [JsonPropertyName("main-image")]
        public Image MainImage { get; set; }

        /// <summary>
        /// URL structure of the Item in your site. Note: Updates to an item slug will break all links referencing the old slug.
        /// </summary>
        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        /// <summary>
        /// Date Item was last updated
        /// </summary>
        [JsonPropertyName("updated-on")]
        public DateTimeOffset UpdatedOn { get; set; }

        /// <summary>
        /// User who made last change to Item
        /// </summary>
        [JsonPropertyName("updated-by")]
        public string UpdatedBy { get; set; }

        /// <summary>
        /// Date Item was created
        /// </summary>
        [JsonPropertyName("created-on")]
        public DateTimeOffset CreatedOn { get; set; }

        /// <summary>
        /// User who created Item
        /// </summary>
        [JsonPropertyName("created-by")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Date Item was last published
        /// </summary>
        [JsonPropertyName("published-on")]
        public DateTimeOffset PublishedOn { get; set; }

        /// <summary>
        /// User who last published Item
        /// </summary>
        [JsonPropertyName("published-by")]
        public string PublishedBy { get; set; }

        [JsonPropertyName("author")]
        public string Author { get; set; }

        /// <summary>
        /// Unique identifier for the Collection the Item belongs within
        /// </summary>
        [JsonPropertyName("_cid")]
        public string CollectionId { get; set; }

        /// <summary>
        /// Unique identifier for the Item
        /// </summary>
        [JsonPropertyName("_id")]
        public string Id { get; set; }

        [JsonIgnore]
        public ItemInventoryResponse Inventory { get; set; }

        [JsonIgnore]
        public string SiteId { get; set; }
    }
}
