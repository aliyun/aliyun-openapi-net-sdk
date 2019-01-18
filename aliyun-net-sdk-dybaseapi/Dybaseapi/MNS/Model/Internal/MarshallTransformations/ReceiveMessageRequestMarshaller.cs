using System.Collections.Generic;
using Aliyun.Acs.Dybaseapi.MNS.Runtime;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Transform;
using Aliyun.Acs.Dybaseapi.MNS.Util;

namespace Aliyun.Acs.Dybaseapi.MNS.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// ReceiveMessage Request Marshaller
    /// </summary>       
    public class ReceiveMessageRequestMarshaller : IMarshaller<IRequest, ReceiveMessageRequest> , IMarshaller<IRequest,WebServiceRequest>
    {
        public IRequest Marshall(WebServiceRequest input)
        {
            return this.Marshall((ReceiveMessageRequest)input);
        }
    
        public IRequest Marshall(ReceiveMessageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, MNSConstants.MNS_SERVICE_NAME);
            request.HttpMethod = HttpMethod.GET.ToString();
            request.ResourcePath = MNSConstants.MNS_MESSAGE_PRE_RESOURCE + publicRequest.QueueName 
                + MNSConstants.MNS_MESSAGE_SUB_RESOURCE;
            PopulateSpecialParameters(publicRequest, request.Parameters);
            return request;
        }

        private static void PopulateSpecialParameters(ReceiveMessageRequest request, IDictionary<string, string> paramters)
        {
            if (request.IsSetWaitSeconds())
            {
                paramters.Add(MNSConstants.MNS_PARAMETER_WAIT_SECONDS, request.WaitSeconds.ToString());
            }
        }
    }
}