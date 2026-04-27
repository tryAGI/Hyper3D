
#nullable enable

namespace Hyper3D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StatusResponseVariant2Job
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Hyper3D.JsonConverters.StatusResponseVariant2JobStatusJsonConverter))]
        public global::Hyper3D.StatusResponseVariant2JobStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusResponseVariant2Job" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="status"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public StatusResponseVariant2Job(
            string? uuid,
            global::Hyper3D.StatusResponseVariant2JobStatus? status)
        {
            this.Uuid = uuid;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StatusResponseVariant2Job" /> class.
        /// </summary>
        public StatusResponseVariant2Job()
        {
        }
    }
}