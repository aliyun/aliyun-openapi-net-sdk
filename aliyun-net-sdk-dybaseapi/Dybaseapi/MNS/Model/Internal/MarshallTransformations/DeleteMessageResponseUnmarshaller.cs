using System;
using System.Net;
using Aliyun.Acs.Dybaseapi.MNS.Runtime;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Transform;

namespace Aliyun.Acs.Dybaseapi.MNS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for DeleteMessage operation
    /// </summary>  
    internal class DeleteMessageResponseUnmarshaller : XmlResponseUnmarshaller
    {
        public override WebServiceResponse Unmarshall(XmlUnmarshallerContext context)
        {
            var response = new DeleteMessageResponse();
            // Nothing need to do with this response here
            return response;
        }

        public override AliyunServiceException UnmarshallException(XmlUnmarshallerContext context, Exception innerException, HttpStatusCode statusCode)
        {
            ErrorResponse errorResponse = ErrorResponseUnmarshaller.Instance.Unmarshall(context);
            if (errorResponse.Code != null && errorResponse.Code.Equals(MNSErrorCode.QueueNotExist))
            {
                return new QueueNotExistException(errorResponse.Message, innerException, errorResponse.Code, errorResponse.RequestId, errorResponse.HostId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals(MNSErrorCode.InvalidArgument))
            {
                return new InvalidArgumentException(errorResponse.Message, innerException, errorResponse.Code, errorResponse.RequestId, errorResponse.HostId, statusCode);
            }
            if (errorResponse.Code != null && errorResponse.Code.Equals(MNSErrorCode.ReceiptHandleError))
            {
                return new ReceiptHandleErrorException(errorResponse.Message, innerException, errorResponse.Code, errorResponse.RequestId, errorResponse.HostId, statusCode);
            }
            return new MNSException(errorResponse.Message, innerException, errorResponse.Code, errorResponse.RequestId, errorResponse.HostId, statusCode);
        }

        private static DeleteMessageResponseUnmarshaller _instance = new DeleteMessageResponseUnmarshaller();        
        public static DeleteMessageResponseUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}