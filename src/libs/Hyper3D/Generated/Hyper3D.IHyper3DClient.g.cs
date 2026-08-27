
#nullable enable

namespace Hyper3D
{
    /// <summary>
    /// API for Hyper3D Rodin 3D generation, status polling, result downloads,<br/>
    /// balance checks, and texture-only generation.<br/>
    /// This OpenAPI document is manually maintained from the public Hyper3D<br/>
    /// developer documentation because the provider publishes endpoint docs but<br/>
    /// not a stable top-level OpenAPI document.<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface IHyper3DClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::Hyper3D.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::Hyper3D.AutoSDKClientOptions Options { get; }


        /// <summary>
        ///
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        ///
        /// </summary>
        public AccountClient Account { get; }

        /// <summary>
        ///
        /// </summary>
        public GenerationClient Generation { get; }

        /// <summary>
        ///
        /// </summary>
        public TasksClient Tasks { get; }

    }
}