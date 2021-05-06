using System;
using System.Text.Json.Serialization;

namespace WebflowSharp.Services.Items.Models
{
    public class Image
    {
        [JsonPropertyName("fileId")]
        public string FileId { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }
    }
}