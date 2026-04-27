
#nullable enable

namespace Hyper3D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class DownloadResponseVariant2ListItem
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadResponseVariant2ListItem" /> class.
        /// </summary>
        /// <param name="url"></param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DownloadResponseVariant2ListItem(
            string? url,
            string? name)
        {
            this.Url = url;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadResponseVariant2ListItem" /> class.
        /// </summary>
        public DownloadResponseVariant2ListItem()
        {
        }
    }
}