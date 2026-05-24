
#nullable enable

namespace Hyper3D
{
    public partial class GenerationClient
    {


        private static readonly global::Hyper3D.EndPointSecurityRequirement s_CreateRodinTaskSecurityRequirement0 =
            new global::Hyper3D.EndPointSecurityRequirement
            {
                Authorizations = new global::Hyper3D.EndPointAuthorizationRequirement[]
                {                    new global::Hyper3D.EndPointAuthorizationRequirement
                    {
                        Type = "Http",
                        SchemeId = "BearerAuth",
                        Location = "Header",
                        Name = "Bearer",
                        FriendlyName = "Bearer",
                    },
                },
            };
        private static readonly global::Hyper3D.EndPointSecurityRequirement[] s_CreateRodinTaskSecurityRequirements =
            new global::Hyper3D.EndPointSecurityRequirement[]
            {                s_CreateRodinTaskSecurityRequirement0,
            };
        partial void PrepareCreateRodinTaskArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Hyper3D.RodinGenerationRequest request);
        partial void PrepareCreateRodinTaskRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Hyper3D.RodinGenerationRequest request);
        partial void ProcessCreateRodinTaskResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateRodinTaskResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

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
        public async global::System.Threading.Tasks.Task<global::Hyper3D.TaskSubmissionResponse> CreateRodinTaskAsync(

            global::Hyper3D.RodinGenerationRequest request,
            global::Hyper3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateRodinTaskAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
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
        public async global::System.Threading.Tasks.Task<global::Hyper3D.AutoSDKHttpResponse<global::Hyper3D.TaskSubmissionResponse>> CreateRodinTaskAsResponseAsync(

            global::Hyper3D.RodinGenerationRequest request,
            global::Hyper3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateRodinTaskArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Hyper3D.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateRodinTaskSecurityRequirements,
                operationName: "CreateRodinTaskAsync");

            using var __timeoutCancellationTokenSource = global::Hyper3D.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Hyper3D.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Hyper3D.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: false);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Hyper3D.PathBuilder(
                                path: "/api/v2/rodin",
                                baseUri: HttpClient.BaseAddress);
                            var __path = __pathBuilder.ToString();
                __path = global::Hyper3D.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2" ||
                    __authorization.Type == "OpenIdConnect")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                } 
            }

                            var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
                            if (request.Tier != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Tier ?? string.Empty),
                                    name: "\"tier\"");

                            }
                            if (request.Images != default)
                            {

                                var __contentImages = new global::System.Net.Http.ByteArrayContent(request.Images ?? global::System.Array.Empty<byte>());
                                __contentImages.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.Imagesname is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.Imagesname) ?? string.Empty).ToLowerInvariant() switch
                                        {
                                            ".aac" => "audio/aac",
                                            ".flac" => "audio/flac",
                                            ".gif" => "image/gif",
                                            ".jpeg" => "image/jpeg",
                                            ".jpg" => "image/jpeg",
                                            ".json" => "application/json",
                                            ".m4a" => "audio/mp4",
                                            ".mp3" => "audio/mpeg",
                                            ".mp4" => "video/mp4",
                                            ".mpeg" => "audio/mpeg",
                                            ".mpga" => "audio/mpeg",
                                            ".oga" => "audio/ogg",
                                            ".ogg" => "audio/ogg",
                                            ".opus" => "audio/ogg",
                                            ".pdf" => "application/pdf",
                                            ".png" => "image/png",
                                            ".txt" => "text/plain",
                                            ".wav" => "audio/wav",
                                            ".weba" => "audio/webm",
                                            ".webm" => "video/webm",
                                            ".webp" => "image/webp",
                                            _ => "application/octet-stream",
                                        });
                                __httpRequestContent.Add(
                                    content: __contentImages,
                                    name: "\"images\"",
                                    fileName: request.Imagesname != null ? $"\"{request.Imagesname}\"" : string.Empty);
                                if (__contentImages.Headers.ContentDisposition != null)
                                {
                                    __contentImages.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.Prompt != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Prompt ?? string.Empty),
                                    name: "\"prompt\"");

                            }
                            if (request.UseOriginalAlpha != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.UseOriginalAlpha, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"use_original_alpha\"");

                            }
                            if (request.ConditionMode != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.ConditionMode).HasValue ? (request.ConditionMode).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"condition_mode\"");

                            }
                            if (request.Seed != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.Seed, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"seed\"");

                            }
                            if (request.GeometryFileFormat != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.GeometryFileFormat).HasValue ? (request.GeometryFileFormat).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"geometry_file_format\"");

                            }
                            if (request.Material != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.Material).HasValue ? (request.Material).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"material\"");

                            }
                            if (request.Quality != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.Quality).HasValue ? (request.Quality).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"quality\"");

                            }
                            if (request.QualityOverride != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.QualityOverride, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"quality_override\"");

                            }
                            if (request.TAPose != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.TAPose, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"TAPose\"");

                            }
                            if (request.BboxCondition != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.BboxCondition, x => global::System.Convert.ToString(x, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty))}]"),
                                    name: "\"bbox_condition\"");

                            }
                            if (request.MeshMode != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.MeshMode).HasValue ? (request.MeshMode).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"mesh_mode\"");

                            }
                            if (request.MeshSimplify != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.MeshSimplify, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"mesh_simplify\"");

                            }
                            if (request.MeshSmooth != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.MeshSmooth, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"mesh_smooth\"");

                            }
                            if (request.Addons != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.Addons, x => x))}]"),
                                    name: "\"addons\"");

                            }
                            if (request.PreviewRender != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.PreviewRender, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"preview_render\"");

                            }
                            if (request.HdTexture != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((global::System.Convert.ToString(request.HdTexture, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty).ToLowerInvariant()),
                                    name: "\"hd_texture\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::Hyper3D.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateRodinTaskRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Hyper3D.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Hyper3D.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateRodinTask",
                                methodName: "CreateRodinTaskAsync",
                                pathTemplate: "\"/api/v2/rodin\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Hyper3D.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Hyper3D.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Hyper3D.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateRodinTask",
                                methodName: "CreateRodinTaskAsync",
                                pathTemplate: "\"/api/v2/rodin\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Hyper3D.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Hyper3D.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Hyper3D.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Hyper3D.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Hyper3D.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateRodinTask",
                                methodName: "CreateRodinTaskAsync",
                                pathTemplate: "\"/api/v2/rodin\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Hyper3D.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessCreateRodinTaskResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Hyper3D.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Hyper3D.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateRodinTask",
                                methodName: "CreateRodinTaskAsync",
                                pathTemplate: "\"/api/v2/rodin\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Hyper3D.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Hyper3D.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateRodinTask",
                                methodName: "CreateRodinTaskAsync",
                                pathTemplate: "\"/api/v2/rodin\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessCreateRodinTaskResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Hyper3D.TaskSubmissionResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Hyper3D.AutoSDKHttpResponse<global::Hyper3D.TaskSubmissionResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Hyper3D.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw global::Hyper3D.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Hyper3D.TaskSubmissionResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Hyper3D.AutoSDKHttpResponse<global::Hyper3D.TaskSubmissionResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Hyper3D.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw global::Hyper3D.ApiException.Create(
                                        statusCode: __response.StatusCode,
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        responseBody: __content,
                                        responseHeaders: global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value));
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
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
        public async global::System.Threading.Tasks.Task<global::Hyper3D.TaskSubmissionResponse> CreateRodinTaskAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Hyper3D.RodinGenerationRequest
            {
                Tier = tier,
                Images = images,
                Imagesname = imagesname,
                Prompt = prompt,
                UseOriginalAlpha = useOriginalAlpha,
                ConditionMode = conditionMode,
                Seed = seed,
                GeometryFileFormat = geometryFileFormat,
                Material = material,
                Quality = quality,
                QualityOverride = qualityOverride,
                TAPose = tAPose,
                BboxCondition = bboxCondition,
                MeshMode = meshMode,
                MeshSimplify = meshSimplify,
                MeshSmooth = meshSmooth,
                Addons = addons,
                PreviewRender = previewRender,
                HdTexture = hdTexture,
            };

            return await CreateRodinTaskAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}