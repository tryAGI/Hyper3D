
#nullable enable

namespace Hyper3D
{
    public partial class GenerationClient
    {


        private static readonly global::Hyper3D.EndPointSecurityRequirement s_CreateTextureTaskSecurityRequirement0 =
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
        private static readonly global::Hyper3D.EndPointSecurityRequirement[] s_CreateTextureTaskSecurityRequirements =
            new global::Hyper3D.EndPointSecurityRequirement[]
            {                s_CreateTextureTaskSecurityRequirement0,
            };
        partial void PrepareCreateTextureTaskArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Hyper3D.TextureOnlyRequest request);
        partial void PrepareCreateTextureTaskRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Hyper3D.TextureOnlyRequest request);
        partial void ProcessCreateTextureTaskResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessCreateTextureTaskResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Submit a texture-only task
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hyper3D.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Hyper3D.TaskSubmissionResponse> CreateTextureTaskAsync(

            global::Hyper3D.TextureOnlyRequest request,
            global::Hyper3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await CreateTextureTaskAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Submit a texture-only task
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Hyper3D.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Hyper3D.AutoSDKHttpResponse<global::Hyper3D.TaskSubmissionResponse>> CreateTextureTaskAsResponseAsync(

            global::Hyper3D.TextureOnlyRequest request,
            global::Hyper3D.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareCreateTextureTaskArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Hyper3D.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateTextureTaskSecurityRequirements,
                operationName: "CreateTextureTaskAsync");

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
                                path: "/api/v2/rodin_texture_only",
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
                            if (request.Image != default)
                            {

                                var __contentImage = new global::System.Net.Http.ByteArrayContent(request.Image ?? global::System.Array.Empty<byte>());
                                __contentImage.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.Imagename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.Imagename) ?? string.Empty).ToLowerInvariant() switch
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
                                    content: __contentImage,
                                    name: "\"image\"",
                                    fileName: request.Imagename != null ? $"\"{request.Imagename}\"" : string.Empty);
                                if (__contentImage.Headers.ContentDisposition != null)
                                {
                                    __contentImage.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.Model != default)
                            {

                                var __contentModel = new global::System.Net.Http.ByteArrayContent(request.Model ?? global::System.Array.Empty<byte>());
                                __contentModel.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.Modelname is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.Modelname) ?? string.Empty).ToLowerInvariant() switch
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
                                    content: __contentModel,
                                    name: "\"model\"",
                                    fileName: request.Modelname != null ? $"\"{request.Modelname}\"" : string.Empty);
                                if (__contentModel.Headers.ContentDisposition != null)
                                {
                                    __contentModel.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.Prompt != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Prompt ?? string.Empty),
                                    name: "\"prompt\"");

                            }
                            if (request.Seed != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.Seed, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"seed\"");

                            }
                            if (request.ReferenceScale != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.ReferenceScale, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"reference_scale\"");

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
                            if (request.Resolution != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.Resolution).HasValue ? (request.Resolution).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"resolution\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::Hyper3D.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateTextureTaskRequest(
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
                                operationId: "CreateTextureTask",
                                methodName: "CreateTextureTaskAsync",
                                pathTemplate: "\"/api/v2/rodin_texture_only\"",
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
                                operationId: "CreateTextureTask",
                                methodName: "CreateTextureTaskAsync",
                                pathTemplate: "\"/api/v2/rodin_texture_only\"",
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
                                operationId: "CreateTextureTask",
                                methodName: "CreateTextureTaskAsync",
                                pathTemplate: "\"/api/v2/rodin_texture_only\"",
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
                ProcessCreateTextureTaskResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Hyper3D.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Hyper3D.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateTextureTask",
                                methodName: "CreateTextureTaskAsync",
                                pathTemplate: "\"/api/v2/rodin_texture_only\"",
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
                                operationId: "CreateTextureTask",
                                methodName: "CreateTextureTaskAsync",
                                pathTemplate: "\"/api/v2/rodin_texture_only\"",
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
                                ProcessCreateTextureTaskResponseContent(
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
                                    throw new global::Hyper3D.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
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

                                    throw new global::Hyper3D.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
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
        public async global::System.Threading.Tasks.Task<global::Hyper3D.TaskSubmissionResponse> CreateTextureTaskAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Hyper3D.TextureOnlyRequest
            {
                Image = image,
                Imagename = imagename,
                Model = model,
                Modelname = modelname,
                Prompt = prompt,
                Seed = seed,
                ReferenceScale = referenceScale,
                GeometryFileFormat = geometryFileFormat,
                Material = material,
                Resolution = resolution,
            };

            return await CreateTextureTaskAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }

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
        public async global::System.Threading.Tasks.Task<global::Hyper3D.TaskSubmissionResponse> CreateTextureTaskAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var request = new global::Hyper3D.TextureOnlyRequest
            {
                Image = global::System.Array.Empty<byte>(),
                Imagename = imagename,
                Model = global::System.Array.Empty<byte>(),
                Modelname = modelname,
                Prompt = prompt,
                Seed = seed,
                ReferenceScale = referenceScale,
                GeometryFileFormat = geometryFileFormat,
                Material = material,
                Resolution = resolution,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareCreateTextureTaskArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Hyper3D.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateTextureTaskSecurityRequirements,
                operationName: "CreateTextureTaskAsync");

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
                                path: "/api/v2/rodin_texture_only",
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
                            if (image != default)
                            {

                                var __contentImage = new global::System.Net.Http.StreamContent(image);
                                __contentImage.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.Imagename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.Imagename) ?? string.Empty).ToLowerInvariant() switch
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
                                    content: __contentImage,
                                    name: "\"image\"",
                                    fileName: request.Imagename != null ? $"\"{request.Imagename}\"" : string.Empty);
                                if (__contentImage.Headers.ContentDisposition != null)
                                {
                                    __contentImage.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (model != default)
                            {

                                var __contentModel = new global::System.Net.Http.StreamContent(model);
                                __contentModel.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.Modelname is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.Modelname) ?? string.Empty).ToLowerInvariant() switch
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
                                    content: __contentModel,
                                    name: "\"model\"",
                                    fileName: request.Modelname != null ? $"\"{request.Modelname}\"" : string.Empty);
                                if (__contentModel.Headers.ContentDisposition != null)
                                {
                                    __contentModel.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.Prompt != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Prompt ?? string.Empty),
                                    name: "\"prompt\"");

                            }
                            if (request.Seed != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.Seed, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"seed\"");

                            }
                            if (request.ReferenceScale != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.ReferenceScale, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"reference_scale\"");

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
                            if (request.Resolution != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.Resolution).HasValue ? (request.Resolution).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"resolution\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::Hyper3D.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateTextureTaskRequest(
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
                                operationId: "CreateTextureTask",
                                methodName: "CreateTextureTaskAsync",
                                pathTemplate: "\"/api/v2/rodin_texture_only\"",
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
                                operationId: "CreateTextureTask",
                                methodName: "CreateTextureTaskAsync",
                                pathTemplate: "\"/api/v2/rodin_texture_only\"",
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
                                operationId: "CreateTextureTask",
                                methodName: "CreateTextureTaskAsync",
                                pathTemplate: "\"/api/v2/rodin_texture_only\"",
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
                ProcessCreateTextureTaskResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Hyper3D.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Hyper3D.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateTextureTask",
                                methodName: "CreateTextureTaskAsync",
                                pathTemplate: "\"/api/v2/rodin_texture_only\"",
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
                                operationId: "CreateTextureTask",
                                methodName: "CreateTextureTaskAsync",
                                pathTemplate: "\"/api/v2/rodin_texture_only\"",
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
                                ProcessCreateTextureTaskResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Hyper3D.TaskSubmissionResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::Hyper3D.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
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

                                    return
                                        await global::Hyper3D.TaskSubmissionResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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

                                    throw new global::Hyper3D.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
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
        public async global::System.Threading.Tasks.Task<global::Hyper3D.AutoSDKHttpResponse<global::Hyper3D.TaskSubmissionResponse>> CreateTextureTaskAsResponseAsync(
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
            global::System.Threading.CancellationToken cancellationToken = default)
        {

            var request = new global::Hyper3D.TextureOnlyRequest
            {
                Image = global::System.Array.Empty<byte>(),
                Imagename = imagename,
                Model = global::System.Array.Empty<byte>(),
                Modelname = modelname,
                Prompt = prompt,
                Seed = seed,
                ReferenceScale = referenceScale,
                GeometryFileFormat = geometryFileFormat,
                Material = material,
                Resolution = resolution,
            };
            PrepareArguments(
                client: HttpClient);
            PrepareCreateTextureTaskArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Hyper3D.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_CreateTextureTaskSecurityRequirements,
                operationName: "CreateTextureTaskAsync");

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
                                path: "/api/v2/rodin_texture_only",
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
                            if (image != default)
                            {

                                var __contentImage = new global::System.Net.Http.StreamContent(image);
                                __contentImage.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.Imagename is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.Imagename) ?? string.Empty).ToLowerInvariant() switch
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
                                    content: __contentImage,
                                    name: "\"image\"",
                                    fileName: request.Imagename != null ? $"\"{request.Imagename}\"" : string.Empty);
                                if (__contentImage.Headers.ContentDisposition != null)
                                {
                                    __contentImage.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (model != default)
                            {

                                var __contentModel = new global::System.Net.Http.StreamContent(model);
                                __contentModel.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(
                                    request.Modelname is null
                                        ? "application/octet-stream"
                                        : (global::System.IO.Path.GetExtension(request.Modelname) ?? string.Empty).ToLowerInvariant() switch
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
                                    content: __contentModel,
                                    name: "\"model\"",
                                    fileName: request.Modelname != null ? $"\"{request.Modelname}\"" : string.Empty);
                                if (__contentModel.Headers.ContentDisposition != null)
                                {
                                    __contentModel.Headers.ContentDisposition.FileNameStar = null;
                                }

                            }
                            if (request.Prompt != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(request.Prompt ?? string.Empty),
                                    name: "\"prompt\"");

                            }
                            if (request.Seed != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.Seed, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"seed\"");

                            }
                            if (request.ReferenceScale != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent(global::System.Convert.ToString(request.ReferenceScale, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty),
                                    name: "\"reference_scale\"");

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
                            if (request.Resolution != default)
                            {

                                __httpRequestContent.Add(
                                    content: new global::System.Net.Http.StringContent((request.Resolution).HasValue ? (request.Resolution).GetValueOrDefault().ToValueString() : string.Empty),
                                    name: "\"resolution\"");

                            }

                            __httpRequest.Content = __httpRequestContent;

                global::Hyper3D.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareCreateTextureTaskRequest(
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
                                operationId: "CreateTextureTask",
                                methodName: "CreateTextureTaskAsync",
                                pathTemplate: "\"/api/v2/rodin_texture_only\"",
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
                                operationId: "CreateTextureTask",
                                methodName: "CreateTextureTaskAsync",
                                pathTemplate: "\"/api/v2/rodin_texture_only\"",
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
                                operationId: "CreateTextureTask",
                                methodName: "CreateTextureTaskAsync",
                                pathTemplate: "\"/api/v2/rodin_texture_only\"",
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
                ProcessCreateTextureTaskResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Hyper3D.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Hyper3D.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "CreateTextureTask",
                                methodName: "CreateTextureTaskAsync",
                                pathTemplate: "\"/api/v2/rodin_texture_only\"",
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
                                operationId: "CreateTextureTask",
                                methodName: "CreateTextureTaskAsync",
                                pathTemplate: "\"/api/v2/rodin_texture_only\"",
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
                                ProcessCreateTextureTaskResponseContent(
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
                                    throw new global::Hyper3D.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
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

                                    throw new global::Hyper3D.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
    }
}