namespace Aliyun.Acs.Dybaseapi.MNS.Util
{
    internal abstract class HttpHeader
    {
        public const string ContentTypeHeader = "Content-Type";
        public const string ContentLengthHeader = "Content-Length";
        public const string ContentMD5Header = "Content-MD5";
        public const string AuthorizationHeader = "Authorization";
		public const string SecurityToken = "security-token";

        
        public const string UserAgentHeader = "User-Agent";
        public const string LocationHeader = "Location";
        public const string HostHeader = "Host";
        public const string DateHeader = "Date";
        public const string AcceptHeader = "Accept";

        public const string XMnsVersionHeader = "x-mns-version";
        public const string XMnsMarkerHeader = "x-mns-marker";
        public const string XMnsMaxReturnsHeader = "x-mns-ret-number";
        public const string XMnsPrefixHeader = "x-mns-prefix";
    }
}
