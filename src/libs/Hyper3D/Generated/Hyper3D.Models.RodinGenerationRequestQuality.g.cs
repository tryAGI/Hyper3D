
#nullable enable

namespace Hyper3D
{
    /// <summary>
    ///
    /// </summary>
    public enum RodinGenerationRequestQuality
    {
        /// <summary>
        ///
        /// </summary>
        ExtraLow,
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RodinGenerationRequestQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RodinGenerationRequestQuality value)
        {
            return value switch
            {
                RodinGenerationRequestQuality.ExtraLow => "extra-low",
                RodinGenerationRequestQuality.High => "high",
                RodinGenerationRequestQuality.Low => "low",
                RodinGenerationRequestQuality.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RodinGenerationRequestQuality? ToEnum(string value)
        {
            return value switch
            {
                "extra-low" => RodinGenerationRequestQuality.ExtraLow,
                "high" => RodinGenerationRequestQuality.High,
                "low" => RodinGenerationRequestQuality.Low,
                "medium" => RodinGenerationRequestQuality.Medium,
                _ => null,
            };
        }
    }
}