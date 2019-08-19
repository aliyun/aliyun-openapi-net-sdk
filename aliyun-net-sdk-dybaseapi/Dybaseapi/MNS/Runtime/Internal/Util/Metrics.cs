using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;

using Aliyun.Acs.Dybaseapi.MNS.Util;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Util
{
    public class RequestMetrics
    {
        #region Private members

        private object metricsLock = new object();
        private Stopwatch stopWatch;
        private Dictionary<Metric, Timing> inFlightTimings;
        private List<MetricError> errors = new List<MetricError>();
        private long CurrentTime { get { return stopWatch.GetElapsedDateTimeTicks(); } }
        private void LogError_Locked(Metric metric, string messageFormat, params object[] args)
        {
            errors.Add(new MetricError(metric, messageFormat, args));
        }
        private static void Log(StringBuilder builder, Metric metric, object metricValue)
        {
            LogHelper(builder, metric, metricValue);
        }
        private static void Log(StringBuilder builder, Metric metric, List<object> metricValues)
        {
            if (metricValues == null || metricValues.Count == 0)
                LogHelper(builder, metric);
            else
                LogHelper(builder, metric, metricValues.ToArray());
        }
        private static void LogHelper(StringBuilder builder, Metric metric, params object[] metricValues)
        {
            builder.AppendFormat(CultureInfo.InvariantCulture, "{0} = ", metric);
            if (metricValues == null)
            {
                builder.Append(ObjectToString(metricValues));
            }
            else
            {
                for (int i = 0; i < metricValues.Length; i++)
                {
                    object metricValue = metricValues[i];
                    string metricValueString = ObjectToString(metricValue);
                    if (i > 0)
                        builder.Append(", ");
                    builder.Append(metricValueString);
                }
            }
            builder.Append("; ");
        }
        private static string ObjectToString(object data)
        {
            if (data == null)
                return "NULL";
            return data.ToString();
        }

        #endregion

        #region Properties

        /// <summary>
        /// Collection of properties being tracked
        /// </summary>
        private Dictionary<Metric, List<object>> Properties { get; set; }

        /// <summary>
        /// Timings for metrics being tracked
        /// </summary>
        private Dictionary<Metric, List<Timing>> Timings { get; set; }

        /// <summary>
        /// Counters being tracked
        /// </summary>
        private Dictionary<Metric, long> Counters { get; set; }

        /// <summary>
        /// Whether metrics are enabled for the request
        /// </summary>
        public static bool IsEnabled { get; internal set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Constructs an empty, disabled metrics object
        /// </summary>
        public RequestMetrics()
        {
            stopWatch = Stopwatch.StartNew();
            Properties = new Dictionary<Metric, List<object>>();
            Timings = new Dictionary<Metric, List<Timing>>();
            Counters = new Dictionary<Metric, long>();
            inFlightTimings = new Dictionary<Metric, Timing>();
        }

        #endregion

        #region Internal methods

        /// <summary>
        /// Starts timing an event. Logs an exception if an event
        /// of the same type was started but not stopped.
        /// </summary>
        /// <param name="metric"></param>
        /// <returns></returns>
        internal void StartEvent(Metric metric)
        {
            if (IsEnabled)
            {
                lock(metricsLock)
                {
                    if (inFlightTimings.ContainsKey(metric))
                        LogError_Locked(metric, "Starting multiple events for the same metric");
                    inFlightTimings[metric] = new Timing(CurrentTime);
                }
            }
        }

        /// <summary>
        /// Stops timing an event. Logs an exception if the event wasn't started.
        /// </summary>
        /// <param name="metric"></param>
        /// <returns></returns>
        internal void StopEvent(Metric metric)
        {
            if (IsEnabled)
            {
                Timing timing;
                lock(metricsLock)
                {
                    if (!inFlightTimings.TryGetValue(metric, out timing))
                    {
                        LogError_Locked(metric, "Trying to stop event that has not been started");
                        return;
                    }
                    inFlightTimings.Remove(metric);
                    timing.Stop(CurrentTime);

                    if (IsEnabled)
                    {
                        List<Timing> list;
                        if (!Timings.TryGetValue(metric, out list))
                        {
                            list = new List<Timing>();
                            Timings[metric] = list;
                        }
                        list.Add(timing);
                    }
                }
                return;
            }
            else
            {
                return;
            }

        }

        /// <summary>
        /// Adds a property for a metric. If there are multiple, the
        /// object is added as a new item in a list.
        /// </summary>
        /// <param name="metric"></param>
        /// <param name="property"></param>
        internal void AddProperty(Metric metric, object property)
        {
            if (!IsEnabled) return;

            List<object> list;
            lock(metricsLock)
            {
                if (!Properties.TryGetValue(metric, out list))
                {
                    list = new List<object>();
                    Properties[metric] = list;
                }
                list.Add(property);
            }
        }

        /// <summary>
        /// Sets a counter for a specific metric.
        /// </summary>
        /// <param name="metric"></param>
        /// <param name="value"></param>
        internal void SetCounter(Metric metric, long value)
        {
            if (!IsEnabled) return;

            lock(metricsLock)
            {
                Counters[metric] = value;
            }
        }
        /// <summary>
        /// Increments a specific metric counter.
        /// If counter doesn't exist yet, it is set to 1.
        /// </summary>
        /// <param name="metric"></param>
        internal void IncrementCounter(Metric metric)
        {
            if (!IsEnabled) return;

            lock(metricsLock)
            {
                long value;
                if (!Counters.TryGetValue(metric, out value))
                {
                    value = 1;
                }
                else
                {
                    value++;
                }
                Counters[metric] = value;
            }
        }

        /// <summary>
        /// Returns errors associated with the metric, including
        /// if there are still any timing events in-flight.
        /// </summary>
        /// <returns></returns>
        internal string GetErrors()
        {
            if (!IsEnabled) return null;

            using(StringWriter writer = new StringWriter(CultureInfo.InvariantCulture))
            {
                lock(metricsLock)
                {
                    if (inFlightTimings.Count > 0)
                    {
                        string inFlightTimingsValue = string.Join(", ", inFlightTimings.Keys.Select(k => k.ToString()).ToArray());
                        writer.Write("Timings are still in flight: {0}.", inFlightTimingsValue);
                    }
                    if (errors.Count > 0)
                    {
                        writer.Write("Logged {0} metrics errors: ", errors.Count);
                        foreach (MetricError error in errors)
                        {
                            // skip empty errors
                            if (error.Exception == null && string.IsNullOrEmpty(error.Message))
                                continue;

                            writer.Write("{0} - {1} - ",
                                error.Time.ToString(AliyunSDKUtils.ISO8601DateFormat, CultureInfo.InvariantCulture),
                                error.Metric);
                            if (!string.IsNullOrEmpty(error.Message))
                            {
                                writer.Write(error.Message);
                                writer.Write(";");
                            }
                            if (error.Exception != null)
                            {
                                writer.Write(error.Exception);
                                writer.Write("; ");
                            }
                        }
                    }
                }

                return writer.ToString();
            }
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Returns a string representation of the current metrics.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (!IsEnabled)
            {
                return "Metrics logging disabled";
            }

            StringBuilder builder = new StringBuilder();
            lock(metricsLock)
            {
                foreach (var kvp in Properties)
                {
                    Metric metric = kvp.Key;
                    List<object> values = kvp.Value;
                    Log(builder, metric, values);
                }
                foreach (var kvp in Timings)
                {
                    Metric metric = kvp.Key;
                    List<Timing> list = kvp.Value;
                    foreach (var timing in list)
                    {
                        if (timing.IsFinished)
                            Log(builder, metric, timing.ElapsedTime);
                    }
                }
                foreach (var kvp in Counters)
                {
                    Metric metric = kvp.Key;
                    long value = kvp.Value;
                    Log(builder, metric, value);
                }
            }
            builder.Replace("\r", "\\r").Replace("\n", "\\n");
            return builder.ToString();
        }

        #endregion
    }

    // Set of predefined Metrics.
    internal enum Metric
    {
        // response enums
        ErrorCode,
        RequestId,
        BytesProcessed,
        Exception,
        RedirectLocation,
        RequestMarshallTime,
        ResponseProcessingTime,
        ResponseUnmarshallTime,
        ResponseReadTime,
        StatusCode,

        // request enums
        AttemptCount,
        CredentialsRequestTime,
        HttpRequestTime,
        ProxyHost,
        ProxyPort,
        RequestSigningTime,
        RetryPauseTime,
        StringToSign,
        CanonicalRequest,

        // overall enums
        AsyncCall,
        ClientExecuteTime,
        MethodName,
        ServiceEndpoint,
        ServiceName,
        RequestSize,
    }

    /// <summary>
    /// Timing information for a metric
    /// </summary>
    internal class Timing
    {
        private long startTime;
        private long endTime;

        /// <summary>
        /// Empty, stopped timing object
        /// </summary>
        public Timing()
        {
            startTime = endTime = 0;
            IsFinished = true;
        }

        /// <summary>
        /// Timing object in a started state
        /// </summary>
        /// <param name="currentTime"></param>
        public Timing(long currentTime)
        {
            startTime = currentTime;
            IsFinished = false;
        }

        /// <summary>
        /// Stops timing
        /// </summary>
        /// <param name="currentTime"></param>
        public void Stop(long currentTime)
        {
            endTime = currentTime;
            IsFinished = true;
        }

        /// <summary>
        /// Whether the timing has been stopped
        /// </summary>
        public bool IsFinished { get; private set; }

        /// <summary>
        /// Elapsed ticks from start to stop.
        /// If timing hasn't been stopped yet, returns 0.
        /// </summary>
        public long ElapsedTicks { get { return !IsFinished ? 0 : endTime - startTime; } }

        /// <summary>
        /// Elapsed time from start to stop.
        /// If timing hasn't been stopped yet, returns TimeSpan.Zero
        /// </summary>
        public TimeSpan ElapsedTime { get { return TimeSpan.FromTicks(ElapsedTicks); } }
    }

    /// <summary>
    /// Timing event, stops timing of a metric when disposed
    /// </summary>
    internal class TimingEvent : IDisposable
    {
        private Metric metric;
        private RequestMetrics metrics;
        private bool disposed;

        internal TimingEvent(RequestMetrics metrics, Metric metric)
        {
            this.metrics = metrics;
            this.metric = metric;
        }

        #region Dispose Pattern Implementation

        /// <summary>
        /// Implements the Dispose pattern
        /// </summary>
        /// <param name="disposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    metrics.StopEvent(metric);
                }
                this.disposed = true;
            }
        }

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// The destructor for the client class.
        /// </summary>
        ~TimingEvent()
        {
            this.Dispose(false);
        }

        #endregion
    }

    // Error encountered in metrics logging
    internal class MetricError
    {
        public Metric Metric { get; private set; }
        public string Message { get; private set; }
        public Exception Exception { get; private set; }
        public DateTime Time { get; private set; }

        public MetricError(Metric metric, string messageFormat, params object[] args) : this(metric, null, messageFormat, args) { }
        public MetricError(Metric metric, Exception exception, string messageFormat, params object[] args)
        {
            Time = DateTime.UtcNow;
            try
            {
                Message = string.Format(CultureInfo.InvariantCulture, messageFormat, args);
            }
            catch
            {
                Message = string.Format(CultureInfo.InvariantCulture, "Error message: {0}", messageFormat);
            }
            Exception = exception;
            Metric = metric;
        }
    }
}
