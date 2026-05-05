#nullable enable

namespace Hyper3D
{
    public partial interface IGenerationClient
    {
        /// <summary>
        /// Submit a texture-only task
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hyper3D.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Hyper3D.TaskSubmissionResponse> CreateTextureTaskAsync(

            global::Hyper3D.TextureOnlyRequest request,
            global::Hyper3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit a texture-only task
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hyper3D.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Hyper3D.AutoSDKHttpResponse<global::Hyper3D.TaskSubmissionResponse>> CreateTextureTaskAsResponseAsync(

            global::Hyper3D.TextureOnlyRequest request,
            global::Hyper3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit a texture-only task
        /// </summary>
        /// <param name="image"></param>
        /// <param name="imagename"></param>
        /// <param name="model"></param>
        /// <param name="modelname"></param>
        /// <param name="prompt"></param>
        /// <param name="seed"></param>
        /// <param name="referenceScale"></param>
        /// <param name="geometryFileFormat"></param>
        /// <param name="material"></param>
        /// <param name="resolution"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Hyper3D.TaskSubmissionResponse> CreateTextureTaskAsync(
            byte[]? image = default,
            string? imagename = default,
            byte[]? model = default,
            string? modelname = default,
            string? prompt = default,
            int? seed = default,
            double? referenceScale = default,
            global::Hyper3D.GeometryFileFormat? geometryFileFormat = default,
            global::Hyper3D.TextureOnlyRequestMaterial? material = default,
            global::Hyper3D.TextureOnlyRequestResolution? resolution = default,
            global::Hyper3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Submit a texture-only task
        /// </summary>
        /// <param name="image">
        /// The stream to send as the multipart 'image' file part.
        /// </param>
        /// <param name="imagename"></param>
        /// <param name="model">
        /// The stream to send as the multipart 'model' file part.
        /// </param>
        /// <param name="modelname"></param>
        /// <param name="prompt"></param>
        /// <param name="seed"></param>
        /// <param name="referenceScale"></param>
        /// <param name="geometryFileFormat"></param>
        /// <param name="material"></param>
        /// <param name="resolution"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hyper3D.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Hyper3D.TaskSubmissionResponse> CreateTextureTaskAsync(
            global::System.IO.Stream? image = default,
            string? imagename = default,
            global::System.IO.Stream? model = default,
            string? modelname = default,
            string? prompt = default,
            int? seed = default,
            double? referenceScale = default,
            global::Hyper3D.GeometryFileFormat? geometryFileFormat = default,
            global::Hyper3D.TextureOnlyRequestMaterial? material = default,
            global::Hyper3D.TextureOnlyRequestResolution? resolution = default,
            global::Hyper3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit a texture-only task
        /// </summary>
        /// <param name="image">
        /// The stream to send as the multipart 'image' file part.
        /// </param>
        /// <param name="imagename"></param>
        /// <param name="model">
        /// The stream to send as the multipart 'model' file part.
        /// </param>
        /// <param name="modelname"></param>
        /// <param name="prompt"></param>
        /// <param name="seed"></param>
        /// <param name="referenceScale"></param>
        /// <param name="geometryFileFormat"></param>
        /// <param name="material"></param>
        /// <param name="resolution"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hyper3D.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Hyper3D.AutoSDKHttpResponse<global::Hyper3D.TaskSubmissionResponse>> CreateTextureTaskAsResponseAsync(
            global::System.IO.Stream? image = default,
            string? imagename = default,
            global::System.IO.Stream? model = default,
            string? modelname = default,
            string? prompt = default,
            int? seed = default,
            double? referenceScale = default,
            global::Hyper3D.GeometryFileFormat? geometryFileFormat = default,
            global::Hyper3D.TextureOnlyRequestMaterial? material = default,
            global::Hyper3D.TextureOnlyRequestResolution? resolution = default,
            global::Hyper3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}