namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Transform
{
    /// <summary>
    /// Interface for unmarshallers which unmarshall objects from response data.
    /// </summary>
    public interface IUnmarshaller<T, R>
    {
        /// <summary>
        /// Given the current position in the XML stream, extract a T.
        /// </summary>
        /// <param name="input">The XML parsing context</param>
        /// <returns>An object of type T populated with data from the XML stream.</returns>
        T Unmarshall(R input);
    }
}
