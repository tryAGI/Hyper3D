#nullable enable

namespace Hyper3D
{
    public partial interface ITasksClient
    {
        /// <summary>
        /// Get result download URLs
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hyper3D.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Hyper3D.DownloadResponse> DownloadTaskResultsAsync(

            global::Hyper3D.DownloadRequest request,
            global::Hyper3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get result download URLs
        /// </summary>
        /// <param name="taskUuid"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Hyper3D.DownloadResponse> DownloadTaskResultsAsync(
            string taskUuid,
            global::Hyper3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}