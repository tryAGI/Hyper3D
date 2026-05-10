#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Hyper3D
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct DownloadResponse : global::System.IEquatable<DownloadResponse>
    {
        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hyper3D.CommonError? CommonError { get; init; }
#else
        public global::Hyper3D.CommonError? CommonError { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(CommonError))]
#endif
        public bool IsCommonError => CommonError != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickCommonError(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Hyper3D.CommonError? value)
        {
            value = CommonError;
            return IsCommonError;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Hyper3D.CommonError PickCommonError() => IsCommonError
            ? CommonError!
            : throw new global::System.InvalidOperationException($"Expected union variant 'CommonError' but the value was {ToString()}.");

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        public global::Hyper3D.DownloadResponseVariant2? DownloadResponseVariant2 { get; init; }
#else
        public global::Hyper3D.DownloadResponseVariant2? DownloadResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(DownloadResponseVariant2))]
#endif
        public bool IsDownloadResponseVariant2 => DownloadResponseVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickDownloadResponseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Hyper3D.DownloadResponseVariant2? value)
        {
            value = DownloadResponseVariant2;
            return IsDownloadResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Hyper3D.DownloadResponseVariant2 PickDownloadResponseVariant2() => IsDownloadResponseVariant2
            ? DownloadResponseVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'DownloadResponseVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DownloadResponse(global::Hyper3D.CommonError value) => new DownloadResponse((global::Hyper3D.CommonError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hyper3D.CommonError?(DownloadResponse @this) => @this.CommonError;

        /// <summary>
        /// 
        /// </summary>
        public DownloadResponse(global::Hyper3D.CommonError? value)
        {
            CommonError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DownloadResponse FromCommonError(global::Hyper3D.CommonError? value) => new DownloadResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator DownloadResponse(global::Hyper3D.DownloadResponseVariant2 value) => new DownloadResponse((global::Hyper3D.DownloadResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hyper3D.DownloadResponseVariant2?(DownloadResponse @this) => @this.DownloadResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public DownloadResponse(global::Hyper3D.DownloadResponseVariant2? value)
        {
            DownloadResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static DownloadResponse FromDownloadResponseVariant2(global::Hyper3D.DownloadResponseVariant2? value) => new DownloadResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public DownloadResponse(
            global::Hyper3D.CommonError? commonError,
            global::Hyper3D.DownloadResponseVariant2? downloadResponseVariant2
            )
        {
            CommonError = commonError;
            DownloadResponseVariant2 = downloadResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            DownloadResponseVariant2 as object ??
            CommonError as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CommonError?.ToString() ??
            DownloadResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCommonError && IsDownloadResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Hyper3D.CommonError, TResult>? commonError = null,
            global::System.Func<global::Hyper3D.DownloadResponseVariant2, TResult>? downloadResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCommonError && commonError != null)
            {
                return commonError(CommonError!);
            }
            else if (IsDownloadResponseVariant2 && downloadResponseVariant2 != null)
            {
                return downloadResponseVariant2(DownloadResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Hyper3D.CommonError>? commonError = null,

            global::System.Action<global::Hyper3D.DownloadResponseVariant2>? downloadResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCommonError)
            {
                commonError?.Invoke(CommonError!);
            }
            else if (IsDownloadResponseVariant2)
            {
                downloadResponseVariant2?.Invoke(DownloadResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Hyper3D.CommonError>? commonError = null,
            global::System.Action<global::Hyper3D.DownloadResponseVariant2>? downloadResponseVariant2 = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsCommonError)
            {
                commonError?.Invoke(CommonError!);
            }
            else if (IsDownloadResponseVariant2)
            {
                downloadResponseVariant2?.Invoke(DownloadResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                CommonError,
                typeof(global::Hyper3D.CommonError),
                DownloadResponseVariant2,
                typeof(global::Hyper3D.DownloadResponseVariant2),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(DownloadResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Hyper3D.CommonError?>.Default.Equals(CommonError, other.CommonError) &&
                global::System.Collections.Generic.EqualityComparer<global::Hyper3D.DownloadResponseVariant2?>.Default.Equals(DownloadResponseVariant2, other.DownloadResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(DownloadResponse obj1, DownloadResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<DownloadResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(DownloadResponse obj1, DownloadResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is DownloadResponse o && Equals(o);
        }
    }
}
