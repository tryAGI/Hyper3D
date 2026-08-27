
#nullable enable

namespace Hyper3D
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DownloadResponseVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("list")]
        public global::System.Collections.Generic.IList<global::Hyper3D.DownloadResponseVariant2ListItem>? List { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadResponseVariant2" /> class.
        /// </summary>
        /// <param name="list"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DownloadResponseVariant2(
            global::System.Collections.Generic.IList<global::Hyper3D.DownloadResponseVariant2ListItem>? list)
        {
            this.List = list;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadResponseVariant2" /> class.
        /// </summary>
        public DownloadResponseVariant2()
        {
        }

    }
}