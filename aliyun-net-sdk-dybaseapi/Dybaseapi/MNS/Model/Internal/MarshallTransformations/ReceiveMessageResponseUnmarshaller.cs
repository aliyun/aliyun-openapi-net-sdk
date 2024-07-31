using System;
using System.Net;
using System.Xml.Serialization;
using Aliyun.Acs.Dybaseapi.MNS.Runtime;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Transform;
using Aliyun.Acs.Dybaseapi.MNS.Util;

namespace Aliyun.Acs.Dybaseapi.MNS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for ReceiveMessage operation
    /// </summary>  
    public class ReceiveMessageResponseUnmarshaller : XmlResponseUnmarshaller
    {
        public override WebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            System.Xml.XmlTextReader reader = new System.Xml.XmlTextReader(context.ResponseStream);
            Message message = new Message();

            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case System.Xml.XmlNodeType.Element:
                        switch (reader.LocalName)
                        {
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
                }
            }
            reader.Close();
            return new ReceiveMessageResponse()
            {
                Message = message
            };
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

        private static ReceiveMessageResponseUnmarshaller _instance = new ReceiveMessageResponseUnmarshaller();        
        public static ReceiveMessageResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}