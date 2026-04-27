#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Hyper3D
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct TaskSubmissionResponse : global::System.IEquatable<TaskSubmissionResponse>
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
#if NET6_0_OR_GREATER
        public global::Hyper3D.TaskSubmissionResponseVariant2? TaskSubmissionResponseVariant2 { get; init; }
#else
        public global::Hyper3D.TaskSubmissionResponseVariant2? TaskSubmissionResponseVariant2 { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(TaskSubmissionResponseVariant2))]
#endif
        public bool IsTaskSubmissionResponseVariant2 => TaskSubmissionResponseVariant2 != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TaskSubmissionResponse(global::Hyper3D.CommonError value) => new TaskSubmissionResponse((global::Hyper3D.CommonError?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hyper3D.CommonError?(TaskSubmissionResponse @this) => @this.CommonError;

        /// <summary>
        /// 
        /// </summary>
        public TaskSubmissionResponse(global::Hyper3D.CommonError? value)
        {
            CommonError = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator TaskSubmissionResponse(global::Hyper3D.TaskSubmissionResponseVariant2 value) => new TaskSubmissionResponse((global::Hyper3D.TaskSubmissionResponseVariant2?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::Hyper3D.TaskSubmissionResponseVariant2?(TaskSubmissionResponse @this) => @this.TaskSubmissionResponseVariant2;

        /// <summary>
        /// 
        /// </summary>
        public TaskSubmissionResponse(global::Hyper3D.TaskSubmissionResponseVariant2? value)
        {
            TaskSubmissionResponseVariant2 = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public TaskSubmissionResponse(
            global::Hyper3D.CommonError? commonError,
            global::Hyper3D.TaskSubmissionResponseVariant2? taskSubmissionResponseVariant2
            )
        {
            CommonError = commonError;
            TaskSubmissionResponseVariant2 = taskSubmissionResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            TaskSubmissionResponseVariant2 as object ??
            CommonError as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            CommonError?.ToString() ??
            TaskSubmissionResponseVariant2?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsCommonError && IsTaskSubmissionResponseVariant2;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::Hyper3D.CommonError?, TResult>? commonError = null,
            global::System.Func<global::Hyper3D.TaskSubmissionResponseVariant2?, TResult>? taskSubmissionResponseVariant2 = null,
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
            else if (IsTaskSubmissionResponseVariant2 && taskSubmissionResponseVariant2 != null)
            {
                return taskSubmissionResponseVariant2(TaskSubmissionResponseVariant2!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::Hyper3D.CommonError?>? commonError = null,
            global::System.Action<global::Hyper3D.TaskSubmissionResponseVariant2?>? taskSubmissionResponseVariant2 = null,
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
            else if (IsTaskSubmissionResponseVariant2)
            {
                taskSubmissionResponseVariant2?.Invoke(TaskSubmissionResponseVariant2!);
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
                TaskSubmissionResponseVariant2,
                typeof(global::Hyper3D.TaskSubmissionResponseVariant2),
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
        public bool Equals(TaskSubmissionResponse other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::Hyper3D.CommonError?>.Default.Equals(CommonError, other.CommonError) &&
                global::System.Collections.Generic.EqualityComparer<global::Hyper3D.TaskSubmissionResponseVariant2?>.Default.Equals(TaskSubmissionResponseVariant2, other.TaskSubmissionResponseVariant2) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(TaskSubmissionResponse obj1, TaskSubmissionResponse obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<TaskSubmissionResponse>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(TaskSubmissionResponse obj1, TaskSubmissionResponse obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is TaskSubmissionResponse o && Equals(o);
        }
    }
}
