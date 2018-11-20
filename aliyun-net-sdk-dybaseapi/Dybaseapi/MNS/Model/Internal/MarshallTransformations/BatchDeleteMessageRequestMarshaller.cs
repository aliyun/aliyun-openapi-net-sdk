using Aliyun.Acs.Dybaseapi.MNS.Runtime;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Transform;
using Aliyun.Acs.Dybaseapi.MNS.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Aliyun.Acs.Dybaseapi.MNS.Model.Internal.MarshallTransformations
{
    public partial class BatchDeleteMessageRequestMarshaller : IMarshaller<IRequest, BatchDeleteMessageRequest>, IMarshaller<IRequest, WebServiceRequest>
    {
        public IRequest Marshall(WebServiceRequest input)
        {
            return this.Marshall((BatchDeleteMessageRequest)input);
        }

        public IRequest Marshall(BatchDeleteMessageRequest publicRequest)
        {
            MemoryStream stream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(stream, Encoding.UTF8);
            writer.WriteStartDocument();
            writer.WriteStartElement(MNSConstants.XML_ROOT_RECEIPT_HANDLES, MNSConstants.MNS_XML_NAMESPACE);
            foreach (string receiptHandle in publicRequest.ReceiptHandles)
            {
                writer.WriteElementString(MNSConstants.XML_ELEMENT_RECEIPT_HANDLE, receiptHandle);
            }
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            stream.Seek(0, SeekOrigin.Begin);

            IRequest request = new DefaultRequest(publicRequest, MNSConstants.MNS_SERVICE_NAME);
            request.HttpMethod = HttpMethod.DELETE.ToString();
            request.ContentStream = stream;
            request.ResourcePath = MNSConstants.MNS_MESSAGE_PRE_RESOURCE + publicRequest.QueueName
                + MNSConstants.MNS_MESSAGE_SUB_RESOURCE;
            return request;
        }
    }
}
