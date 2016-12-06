// This file was generated automatically by GenerateFromSchema.  Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer

using CesiumLanguageWriter.Advanced;
using System;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <c>Clock</c> to a <see cref="CesiumOutputStream" />.  A <c>Clock</c> is initial settings for a simulated clock when a document is loaded.  The start and stop time are configured using the interval property.
    /// </summary>
    public class ClockCesiumWriter : CesiumPropertyWriter<ClockCesiumWriter>
    {
        /// <summary>
        /// The name of the <c>currentTime</c> property.
        /// </summary>
        public const string CurrentTimePropertyName = "currentTime";

        /// <summary>
        /// The name of the <c>multiplier</c> property.
        /// </summary>
        public const string MultiplierPropertyName = "multiplier";

        /// <summary>
        /// The name of the <c>range</c> property.
        /// </summary>
        public const string RangePropertyName = "range";

        /// <summary>
        /// The name of the <c>step</c> property.
        /// </summary>
        public const string StepPropertyName = "step";


        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public ClockCesiumWriter(string propertyName)
            : base(propertyName)
        {
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected ClockCesiumWriter(ClockCesiumWriter existingInstance)
            : base(existingInstance)
        {
        }

        /// <inheritdoc />
        public override ClockCesiumWriter Clone()
        {
            return new ClockCesiumWriter(this);
        }

        /// <summary>
        /// Writes the value expressed as a <c>currentTime</c>, which is the current time, specified in ISO8601 format.
        /// </summary>
        /// <param name="value">The time.</param>
        public void WriteCurrentTime(JulianDate value)
        {
            const string PropertyName = CurrentTimePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteDate(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>multiplier</c>, which is the multiplier.  When <c>step</c> is set to <c>TICK_DEPENDENT</c>, this is the number of seconds to advance each tick.  When <c>step</c> is set to <c>SYSTEM_CLOCK_DEPENDENT</c>, this is multiplied by the elapsed system time between ticks.  This value is ignored in <c>SYSTEM_CLOCK</c> mode.  The default value is 1.0.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteMultiplier(double value)
        {
            const string PropertyName = MultiplierPropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            Output.WriteValue(value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>range</c>, which is the behavior when the current time reaches its start or end times.  The default value is <c>LOOP_STOP</c>.
        /// </summary>
        /// <param name="value">The clock range.</param>
        public void WriteRange(ClockRange value)
        {
            const string PropertyName = RangePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            Output.WriteValue(CesiumFormattingHelper.ClockRangeToString(value));
        }

        /// <summary>
        /// Writes the value expressed as a <c>step</c>, which is how the current time advances each tick.  The default value is <c>SYSTEM_CLOCK_MULTIPLIER</c>.
        /// </summary>
        /// <param name="value">The clock step.</param>
        public void WriteStep(ClockStep value)
        {
            const string PropertyName = StepPropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            Output.WriteValue(CesiumFormattingHelper.ClockStepToString(value));
        }

    }
}
