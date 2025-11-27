using Aliyun.Acs.Dybaseapi.MNS.Runtime;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Transform;
using Aliyun.Acs.Dybaseapi.MNS.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Aliyun.Acs.Dybaseapi.MNS.Model.Internal.MarshallTransformations
{
    public class BatchDeleteMessageResponseUnmarshaller : XmlResponseUnmarshaller
    {
        public override WebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            return new BatchDeleteMessageResponse();
        }

        public override AliyunServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            XmlTextReader reader = new XmlTextReader(context.ResponseStream);

            ErrorResponse errorResponse = new ErrorResponse();
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (reader.LocalName == MNSConstants.XML_ROOT_ERROR_RESPONSE)
                        {
                            return UnmarshallNormalError(reader, innerException, statusCode);
                        }
                        else
                        {
                            return UnmarshallBatchDeleteError(reader);
                        }
                }
            }
            return new MNSException(errorResponse.Message, innerException, errorResponse.Code, errorResponse.RequestId, errorResponse.HostId, statusCode);
        }

        private BatchDeleteFailException UnmarshallBatchDeleteError(XmlTextReader reader)
        {
            BatchDeleteFailException batchDeleteFailException = new BatchDeleteFailException();
            BatchDeleteErrorItem item = null;
 
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        switch (reader.LocalName)
                        {
                            case MNSConstants.XML_ROOT_ERROR_RESPONSE:
                                item = new BatchDeleteErrorItem();
                                break;
                            case MNSConstants.XML_ELEMENT_ERROR_CODE:
                                reader.Read();
                                item.ErrorCode = reader.Value;
                                break;
                            case MNSConstants.XML_ELEMENT_ERROR_MESSAGE:
                                reader.Read();
                                item.ErrorMessage = reader.Value;
                                break;
                            case MNSConstants.XML_ELEMENT_RECEIPT_HANDLE:
                                reader.Read();
                                item.ReceiptHandle = reader.Value;
                                break;
                        }
                        break;
                    case XmlNodeType.EndElement:
                        if (reader.LocalName == MNSConstants.XML_ROOT_ERROR_RESPONSE)
                        {
                            batchDeleteFailException.ErrorItems.Add(item);
                        }
                        break;
                }
            }
            reader.Close();
            return batchDeleteFailException;
        }

        private AliyunServiceException UnmarshallNormalError(XmlTextReader reader, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.Instance.Unmarshall(reader);
            if (errorResponse.Code != null)
            {
                switch (errorResponse.Code)
                {
                    case MNSErrorCode.QueueNotExist:
                        return new QueueNotExistException(errorResponse.Message, innerException, errorResponse.Code, errorResponse.RequestId, errorResponse.HostId, statusCode);
                    case MNSErrorCode.InvalidArgument:
                        return new InvalidArgumentException(errorResponse.Message, innerException, errorResponse.Code, errorResponse.RequestId, errorResponse.HostId, statusCode);
                    case MNSErrorCode.ReceiptHandleError:
                        return new ReceiptHandleErrorException(errorResponse.Message, innerException, errorResponse.Code, errorResponse.RequestId, errorResponse.HostId, statusCode);
                }
            }
            return new MNSException(errorResponse.Message, innerException, errorResponse.Code, errorResponse.RequestId, errorResponse.HostId, statusCode);
        }

        private static BatchDeleteMessageResponseUnmarshaller _instance = new BatchDeleteMessageResponseUnmarshaller();
        public static BatchDeleteMessageResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
