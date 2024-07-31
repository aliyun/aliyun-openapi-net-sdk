namespace Aliyun.Acs.Dybaseapi.MNS.Runtime
{
    /// <summary>
    /// The valid hashing algorithm supported by MNS for request signing.
    /// </summary>
    public enum SigningAlgorithm 
    { 
        HmacSHA1, 
        HmacSHA256 
    };

    /// <summary>
    /// The http methods supported by MNS.
    /// </summary>
    public enum HttpMethod
    {
        GET,
        PUT,
        POST,
        DELETE
    }
}
