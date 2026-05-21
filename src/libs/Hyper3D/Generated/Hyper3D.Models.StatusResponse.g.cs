#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Hyper3D
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct StatusResponse : global::System.IEquatable<StatusResponse>
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
        public global::Hyper3D.StatusResponseVariant2? StatusResponseVariant2 { get; init; }
#else
        public global::Hyper3D.StatusResponseVariant2? StatusResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(StatusResponseVariant2))]
#endif
        public bool IsStatusResponseVariant2 => StatusResponseVariant2 != null;

        /// <summary>
        /// 
        /// </summary>
        public bool TryPickStatusResponseVariant2(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::Hyper3D.StatusResponseVariant2? value)
        {
            value = StatusResponseVariant2;
            return IsStatusResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public global::Hyper3D.StatusResponseVariant2 PickStatusResponseVariant2() => IsStatusResponseVariant2
            ? StatusResponseVariant2!
            : throw new global::System.InvalidOperationException($"Expected union variant 'StatusResponseVariant2' but the value was {ToString()}.");
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StatusResponse(global::Hyper3D.CommonError value) => new StatusResponse((global::Hyper3D.CommonError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hyper3D.CommonError?(StatusResponse @this) => @this.CommonError;

        /// <summary>
        /// 
        /// </summary>
        public StatusResponse(global::Hyper3D.CommonError? value)
        {
            CommonError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StatusResponse FromCommonError(global::Hyper3D.CommonError? value) => new StatusResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator StatusResponse(global::Hyper3D.StatusResponseVariant2 value) => new StatusResponse((global::Hyper3D.StatusResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hyper3D.StatusResponseVariant2?(StatusResponse @this) => @this.StatusResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public StatusResponse(global::Hyper3D.StatusResponseVariant2? value)
        {
            StatusResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static StatusResponse FromStatusResponseVariant2(global::Hyper3D.StatusResponseVariant2? value) => new StatusResponse(value);

        /// <summary>
        /// 
        /// </summary>
        public StatusResponse(
            global::Hyper3D.CommonError? commonError,
            global::Hyper3D.StatusResponseVariant2? statusResponseVariant2
            )
        {
            CommonError = commonError;
            StatusResponseVariant2 = statusResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            StatusResponseVariant2 as object ??
            CommonError as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CommonError?.ToString() ??
            StatusResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCommonError && IsStatusResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Hyper3D.CommonError, TResult>? commonError = null,
            global::System.Func<global::Hyper3D.StatusResponseVariant2, TResult>? statusResponseVariant2 = null,
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
            else if (IsStatusResponseVariant2 && statusResponseVariant2 != null)
            {
                return statusResponseVariant2(StatusResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Hyper3D.CommonError>? commonError = null,

            global::System.Action<global::Hyper3D.StatusResponseVariant2>? statusResponseVariant2 = null,
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
            else if (IsStatusResponseVariant2)
            {
                statusResponseVariant2?.Invoke(StatusResponseVariant2!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Switch(
            global::System.Action<global::Hyper3D.CommonError>? commonError = null,
            global::System.Action<global::Hyper3D.StatusResponseVariant2>? statusResponseVariant2 = null,
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
            else if (IsStatusResponseVariant2)
            {
                statusResponseVariant2?.Invoke(StatusResponseVariant2!);
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
                StatusResponseVariant2,
                typeof(global::Hyper3D.StatusResponseVariant2),
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
        public bool Equals(StatusResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Hyper3D.CommonError?>.Default.Equals(CommonError, other.CommonError) &&
                global::System.Collections.Generic.EqualityComparer<global::Hyper3D.StatusResponseVariant2?>.Default.Equals(StatusResponseVariant2, other.StatusResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(StatusResponse obj1, StatusResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<StatusResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(StatusResponse obj1, StatusResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is StatusResponse o && Equals(o);
        }
    }
}
