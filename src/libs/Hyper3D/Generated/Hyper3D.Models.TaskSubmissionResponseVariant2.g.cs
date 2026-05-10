
#nullable enable

namespace Hyper3D
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TaskSubmissionResponseVariant2
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uuid")]
        public string? Uuid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("jobs")]
        public global::Hyper3D.TaskSubmissionResponseVariant2Jobs? Jobs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskSubmissionResponseVariant2" /> class.
        /// </summary>
        /// <param name="uuid"></param>
        /// <param name="jobs"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TaskSubmissionResponseVariant2(
            string? uuid,
            global::Hyper3D.TaskSubmissionResponseVariant2Jobs? jobs)
        {
            this.Uuid = uuid;
            this.Jobs = jobs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskSubmissionResponseVariant2" /> class.
        /// </summary>
        public TaskSubmissionResponseVariant2()
        {
        }

    }
}