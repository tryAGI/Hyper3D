#nullable enable

namespace Hyper3D
{
    public partial interface IGenerationClient
    {
        /// <summary>
        /// Submit a Rodin generation task<br/>
        /// Submit an asynchronous Rodin task. Use tier=Gen-2 for Gen-2 generation.<br/>
        /// For image-to-3D, include an images file. For text-to-3D, include prompt<br/>
        /// and omit image files.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hyper3D.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Hyper3D.TaskSubmissionResponse> CreateRodinTaskAsync(

            global::Hyper3D.RodinGenerationRequest request,
            global::Hyper3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit a Rodin generation task<br/>
        /// Submit an asynchronous Rodin task. Use tier=Gen-2 for Gen-2 generation.<br/>
        /// For image-to-3D, include an images file. For text-to-3D, include prompt<br/>
        /// and omit image files.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hyper3D.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Hyper3D.AutoSDKHttpResponse<global::Hyper3D.TaskSubmissionResponse>> CreateRodinTaskAsResponseAsync(

            global::Hyper3D.RodinGenerationRequest request,
            global::Hyper3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Submit a Rodin generation task<br/>
        /// Submit an asynchronous Rodin task. Use tier=Gen-2 for Gen-2 generation.<br/>
        /// For image-to-3D, include an images file. For text-to-3D, include prompt<br/>
        /// and omit image files.
        /// </summary>
        /// <param name="tier">
        /// Generation tier, such as Gen-2, Regular, Detail, Smooth, or Sketch.
        /// </param>
        /// <param name="images">
        /// Image input. Repeat this multipart field for multi-view input.
        /// </param>
        /// <param name="imagesname">
        /// Image input. Repeat this multipart field for multi-view input.
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="useOriginalAlpha"></param>
        /// <param name="conditionMode"></param>
        /// <param name="seed"></param>
        /// <param name="geometryFileFormat"></param>
        /// <param name="material"></param>
        /// <param name="quality"></param>
        /// <param name="qualityOverride"></param>
        /// <param name="tAPose"></param>
        /// <param name="bboxCondition"></param>
        /// <param name="meshMode"></param>
        /// <param name="meshSimplify"></param>
        /// <param name="meshSmooth"></param>
        /// <param name="addons"></param>
        /// <param name="previewRender"></param>
        /// <param name="hdTexture"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Hyper3D.TaskSubmissionResponse> CreateRodinTaskAsync(
            string? tier = default,
            byte[]? images = default,
            string? imagesname = default,
            string? prompt = default,
            bool? useOriginalAlpha = default,
            global::Hyper3D.RodinGenerationRequestConditionMode? conditionMode = default,
            int? seed = default,
            global::Hyper3D.GeometryFileFormat? geometryFileFormat = default,
            global::Hyper3D.RodinGenerationRequestMaterial? material = default,
            global::Hyper3D.RodinGenerationRequestQuality? quality = default,
            int? qualityOverride = default,
            bool? tAPose = default,
            global::System.Collections.Generic.IList<int>? bboxCondition = default,
            global::Hyper3D.RodinGenerationRequestMeshMode? meshMode = default,
            bool? meshSimplify = default,
            bool? meshSmooth = default,
            global::System.Collections.Generic.IList<string>? addons = default,
            bool? previewRender = default,
            bool? hdTexture = default,
            global::Hyper3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}