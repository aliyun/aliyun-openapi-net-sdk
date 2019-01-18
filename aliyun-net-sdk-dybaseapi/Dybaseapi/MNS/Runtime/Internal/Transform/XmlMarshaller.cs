using Aliyun.Acs.Dybaseapi.MNS.Util;
using System;
using System.IO;
using System.Xml.Serialization;

namespace Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Transform
{
    /// <summary>
    /// XML marshaller used for marshalling specfied object to XML content stream.
    /// </summary>
    internal class XmlMarshaller<TRequest> : IMarshaller<Stream, TRequest>
    {
        private static readonly XmlSerializer _serializer = new XmlSerializer(typeof(TRequest));

        public Stream Marshall(TRequest requestObject)
        {
            MemoryStream stream = null;
            var gotException = false;
            try
            {
                stream = new MemoryStream();
                var namespaces = new XmlSerializerNamespaces();
                namespaces.Add(string.Empty, MNSConstants.MNS_XML_NAMESPACE);
                _serializer.Serialize(stream, requestObject, namespaces);
                stream.Seek(0, SeekOrigin.Begin);
            }
            catch (InvalidOperationException ex)
            {
                gotException = true;
                throw new RequestMarshallException(ex.Message, ex);
            }
            finally
            {
                if (gotException && stream != null)
                {
                    stream.Close();
                }
            }
            return stream;
        }
    }
}
