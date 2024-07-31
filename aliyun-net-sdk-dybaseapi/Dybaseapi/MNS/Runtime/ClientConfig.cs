using System;
using System.Net;
using Aliyun.Acs.Dybaseapi.MNS.Util;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime
{
    /// <summary>
    /// Base class of all configurations of MNS.
    /// </summary>
    public abstract partial class ClientConfig
    {
        private Uri _regionEndpoint;

        private readonly string _userAgent = AliyunSDKUtils.SDKUserAgent;
        private int _maxErrorRetry = 3;
        private bool _logMetrics = false;
        private int _bufferSize = AliyunSDKUtils.DefaultBufferSize;
        private bool _resignRetries = false;
        private ICredentials _proxyCredentials;
        private bool _disableLogging = true;
        private TimeSpan? _timeout = null;
        private bool _allowAutoRedirect = false;

        private string _proxyHost;
        private int _proxyPort = -1;
        private int? _connectionLimit = 200;
        private int? _maxIdleTime;
        private TimeSpan? _readWriteTimeout = null;

        private static readonly TimeSpan InfiniteTimeout = TimeSpan.FromMilliseconds(-1);
        private static readonly TimeSpan MaxTimeout = TimeSpan.FromMilliseconds(int.MaxValue);

        /// <summary>
        /// Gets Service Version.
        /// </summary>
        public abstract string ServiceVersion
        {
            get;
        }

        /// <summary>
        /// Gets Service Name.
        /// </summary>
        public abstract string ServiceName
        {
            get;
        }

        /// <summary>
        /// Gets of the UserAgent property.
        /// </summary>
        public string UserAgent
        {
            get { return this._userAgent; }
        }

        /// <summary>
        /// Gets and sets the RegionEndpoint property. 
        /// </summary>
        public Uri RegionEndpoint
        {
            get
            {
                if (_regionEndpoint == null)
                {
                    throw new ArgumentException("Endpoint of MNSConfig must be specified.");
                }
                return _regionEndpoint;
            }
            set { _regionEndpoint = value; }
        }

        /// <summary>
        /// Gets and sets of the MaxErrorRetry property.
        /// </summary>
        public int MaxErrorRetry
        {
            get { return this._maxErrorRetry; }
            set { this._maxErrorRetry = value; }
        }

        /// <summary>
        /// Flag on whether to log metrics for service calls.
        /// </summary>
        public bool LogMetrics
        {
            get { return this._logMetrics; }
            set { this._logMetrics = value; }
        }

        /// <summary>
        /// Gets and Sets the BufferSize property.
        /// The BufferSize controls the buffer used to read in from input streams and write 
        /// out to the request.
        /// </summary>
        public int BufferSize
        {
            get { return this._bufferSize; }
            set { this._bufferSize = value; }
        }

        /// <summary>
        /// Flag on whether to resign requests on retry or not.
        /// </summary>
        internal bool ResignRetries
        {
            get { return this._resignRetries; }
            set { this._resignRetries = value; }
        }

        /// <summary>
        /// This flag controls if .NET HTTP infrastructure should follow redirection responses.
        /// </summary>
        internal bool AllowAutoRedirect
        {
            get
            {
                return this._allowAutoRedirect;
            }
            set
            {
                this._allowAutoRedirect = value;
            }
        }

        /// <summary>
        /// Flag on whether to completely disable logging for this client or not.
        /// </summary>
        internal bool DisableLogging
        {
            get { return this._disableLogging; }
            set { this._disableLogging = value; }
        }

        /// <summary>
        /// Credentials to use with a proxy.
        /// </summary>
        public ICredentials ProxyCredentials
        {
            get { return this._proxyCredentials; }
            set { this._proxyCredentials = value; }
        }

        #region Constructor 
        public ClientConfig()
        {
            Initialize();
        }
        #endregion

        protected virtual void Initialize()
        {
        }

        /// <summary>
        /// Gets and sets of the ProxyHost property.
        /// </summary>
        public string ProxyHost
        {
            get { return this._proxyHost; }
            set { this._proxyHost = value; }
        }


        /// <summary>
        /// Gets and sets of the ProxyPort property.
        /// </summary>
        public int ProxyPort
        {
            get { return this._proxyPort; }
            set { this._proxyPort = value; }
        }

        /// <summary>
        /// Gets and sets the max idle time set on the ServicePoint for the WebRequest.
        /// </summary>
        public int MaxIdleTime
        {
            get { return AliyunSDKUtils.GetMaxIdleTime(this._maxIdleTime); }
            set { this._maxIdleTime = value; }
        }

        /// <summary>
        /// Gets and sets the connection limit set on the ServicePoint for the WebRequest.
        /// </summary>
        public int ConnectionLimit
        {
            get { return AliyunSDKUtils.GetConnectionLimit(this._connectionLimit); }
            set { this._connectionLimit = value; }
        }

        /// <summary>
        /// Overrides the default read-write timeout value.
        /// </summary>
        public TimeSpan? ReadWriteTimeout
        {
            get { return this._readWriteTimeout; }
            set
            {
                ValidateTimeout(value);
                this._readWriteTimeout = value;
            }
        }

        /// <summary>
        /// Overrides the default request timeout value.
        /// </summary>
        public TimeSpan? Timeout
        {
            get { return this._timeout; }
            set
            {
                ValidateTimeout(value);
                this._timeout = value;
            }
        }

        internal static void ValidateTimeout(TimeSpan? timeout)
        {
            if (!timeout.HasValue)
            {
                throw new ArgumentNullException("timeout");
            }

            if (timeout != InfiniteTimeout && (timeout <= TimeSpan.Zero || timeout > MaxTimeout))
            {
                throw new ArgumentOutOfRangeException("timeout");
            }
        }

        /// <summary>
        /// Returns the request timeout value if its value is set, 
        /// else returns client timeout value.
        /// </summary>        
        internal static TimeSpan? GetTimeoutValue(TimeSpan? clientTimeout, TimeSpan? requestTimeout)
        {
            return requestTimeout.HasValue ? requestTimeout
                : (clientTimeout.HasValue ? clientTimeout : null);
        }
    }
}
