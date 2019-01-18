using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Transform;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aliyun.Acs.Dybaseapi.MNS.Runtime;
using System.Net;
using Aliyun.Acs.Dybaseapi.MNS.Util;
using System.Xml.Serialization;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal;

namespace Aliyun.Acs.Dybaseapi.MNS.Model.Internal.MarshallTransformations
{
    class BatchReceiveMessageResponseUnmarshaller : XmlResponseUnmarshaller
    {
        public override WebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            System.Xml.XmlTextReader reader = new System.Xml.XmlTextReader(context.ResponseStream);
            BatchReceiveMessageResponse batchReceiveMessageResponse = new BatchReceiveMessageResponse();
            Message message = null;

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case System.Xml.XmlNodeType.Element:
                        switch (reader.LocalName)
                        {
                            case MNSConstants.XML_ROOT_MESSAGE:
                                message = new Message();
                                break;
                            case MNSConstants.XML_ELEMENT_MESSAGE_ID:
                                reader.Read();
                                message.Id = reader.Value;
                                break;
                            case MNSConstants.XML_ELEMENT_RECEIPT_HANDLE:
                                reader.Read();
                                message.ReceiptHandle = reader.Value;
                                break;
                            case MNSConstants.XML_ELEMENT_MESSAGE_BODY_MD5:
                                reader.Read();
                                message.BodyMD5 = reader.Value;
                                break;
                            case MNSConstants.XML_ELEMENT_MESSAGE_BODY:
                                reader.Read();
                                message.Body = reader.Value;
                                break;
                            case MNSConstants.XML_ELEMENT_ENQUEUE_TIME:
                                reader.Read();
                                message.EnqueueTime = AliyunSDKUtils.ConvertFromUnixEpochSeconds(long.Parse(reader.Value));
                                break;
                            case MNSConstants.XML_ELEMENT_NEXT_VISIBLE_TIME:
                                reader.Read();
                                message.NextVisibleTime = AliyunSDKUtils.ConvertFromUnixEpochSeconds(long.Parse(reader.Value));
                                break;
                            case MNSConstants.XML_ELEMENT_FIRST_DEQUEUE_TIME:
                                reader.Read();
                                message.FirstDequeueTime = AliyunSDKUtils.ConvertFromUnixEpochSeconds(long.Parse(reader.Value));
                                break;
                            case MNSConstants.XML_ELEMENT_DEQUEUE_COUNT:
                                reader.Read();
                                message.DequeueCount = uint.Parse(reader.Value);
                                break;
                            case MNSConstants.XML_ELEMENT_PRIORITY:
                                reader.Read();
                                message.Priority = uint.Parse(reader.Value);
                                break;
                        }
                        break;
                    case System.Xml.XmlNodeType.EndElement:
                        if (reader.LocalName == MNSConstants.XML_ROOT_MESSAGE)
                        {
                            batchReceiveMessageResponse.Messages.Add(message);
                        }
                        break;
                }
            }
            reader.Close();
            return batchReceiveMessageResponse;
        }

        public override AliyunServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.Instance.Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals(MNSErrorCode.QueueNotExist))
            {
                return new QueueNotExistException(errorResponse.Message, innerException, errorResponse.Code, errorResponse.RequestId, errorResponse.HostId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals(MNSErrorCode.MessageNotExist))
            {
                return new MessageNotExistException(errorResponse.Message, innerException, errorResponse.Code, errorResponse.RequestId, errorResponse.HostId, statusCode);
            }
            return new MNSException(errorResponse.Message, innerException, errorResponse.Code, errorResponse.RequestId, errorResponse.HostId, statusCode);
        }

        private static BatchReceiveMessageResponseUnmarshaller _instance = new BatchReceiveMessageResponseUnmarshaller();
        public static BatchReceiveMessageResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}
