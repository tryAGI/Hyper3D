
#nullable enable

namespace Hyper3D
{
    /// <summary>
    /// 
    /// </summary>
    public enum StatusResponseVariant2JobStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Done,
        /// <summary>
        /// 
        /// </summary>
        Failed,
        /// <summary>
        /// 
        /// </summary>
        Generating,
        /// <summary>
        /// 
        /// </summary>
        Waiting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StatusResponseVariant2JobStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StatusResponseVariant2JobStatus value)
        {
            return value switch
            {
                StatusResponseVariant2JobStatus.Done => "Done",
                StatusResponseVariant2JobStatus.Failed => "Failed",
                StatusResponseVariant2JobStatus.Generating => "Generating",
                StatusResponseVariant2JobStatus.Waiting => "Waiting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StatusResponseVariant2JobStatus? ToEnum(string value)
        {
            return value switch
            {
                "Done" => StatusResponseVariant2JobStatus.Done,
                "Failed" => StatusResponseVariant2JobStatus.Failed,
                "Generating" => StatusResponseVariant2JobStatus.Generating,
                "Waiting" => StatusResponseVariant2JobStatus.Waiting,
                _ => null,
            };
        }
    }
}