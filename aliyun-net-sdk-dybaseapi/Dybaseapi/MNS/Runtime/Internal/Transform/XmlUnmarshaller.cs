using System;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Transform
{
    /// <summary>
    /// Deserializes specified object from XML stream.
    /// </summary>
    internal class XmlUnmarshaller<TResponse> : IUnmarshaller<TResponse, Stream>
    {
        private static readonly XmlSerializer _serializer = new XmlSerializer(typeof(TResponse));

        public TResponse Unmarshall(Stream responseStream)
        {
            return this.Unmarshall(responseStream, false);
        }

        public TResponse Unmarshall(Stream responseStream, bool keepOpenOnException = false)
        {
            bool dispose = true;
            try
            {
                return (TResponse)_serializer.Deserialize(responseStream);
            }
            catch (XmlException ex)
            {
                if (keepOpenOnException)
                {
                    dispose = false;
                }
                throw new ResponseUnmarshallException(ex.Message, ex);
            }
            catch (InvalidOperationException ex)
            {
                if (keepOpenOnException)
                {
                    dispose = false;
                }
                throw new ResponseUnmarshallException(ex.Message, ex);
            }
            finally
            {
                if (dispose)
                {
                    responseStream.Dispose();
                }
                else
                {
                    responseStream.Seek(0, SeekOrigin.Begin);
                }
            }
        }
    }
}
