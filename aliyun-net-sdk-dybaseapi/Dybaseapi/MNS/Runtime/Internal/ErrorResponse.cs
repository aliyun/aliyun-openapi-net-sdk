namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal
{
    /// <summary>
    /// Error information returned by MNS.
    /// </summary>
    public class ErrorResponse
    {
        private string _code;
        private string _message;
        private string _requestId;
        private string _hostId;

        public string Code
        {
            get { return _code; }
            set { _code = value; }
        }

        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        public string RequestId
        {
            get { return _requestId; }
            set { _requestId = value; }
        }

        public string HostId
        {
            get { return _hostId; }
            set { _hostId = value; }
        }
    }
}
