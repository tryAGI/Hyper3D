
#nullable enable

namespace Hyper3D
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DownloadRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("task_uuid")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TaskUuid { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadRequest" /> class.
        /// </summary>
        /// <param name="taskUuid"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DownloadRequest(
            string taskUuid)
        {
            this.TaskUuid = taskUuid ?? throw new global::System.ArgumentNullException(nameof(taskUuid));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadRequest" /> class.
        /// </summary>
        public DownloadRequest()
        {
        }

    }
}