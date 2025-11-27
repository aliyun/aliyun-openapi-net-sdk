using Aliyun.Acs.Dybaseapi.MNS.Runtime;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal;
using Aliyun.Acs.Dybaseapi.MNS.Runtime.Internal.Transform;
using Aliyun.Acs.Dybaseapi.MNS.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aliyun.Acs.Dybaseapi.MNS.Model.Internal.MarshallTransformations
{
    class BatchReceiveMessageRequestMarshaller : IMarshaller<IRequest, BatchReceiveMessageRequest>, IMarshaller<IRequest, WebServiceRequest>
    {
        public IRequest Marshall(WebServiceRequest input)
        {
            return this.Marshall((BatchReceiveMessageRequest)input);
        }

        public IRequest Marshall(BatchReceiveMessageRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, MNSConstants.MNS_SERVICE_NAME);
            request.HttpMethod = HttpMethod.GET.ToString();
            request.ResourcePath = MNSConstants.MNS_MESSAGE_PRE_RESOURCE + publicRequest.QueueName
                + MNSConstants.MNS_MESSAGE_SUB_RESOURCE;
            PopulateSpecialParameters(publicRequest, request.Parameters);
            return request;
        }

        private static void PopulateSpecialParameters(BatchReceiveMessageRequest request, IDictionary<string, string> paramters)
        {
            if (request.IsSetWaitSeconds())
            {
                paramters.Add(MNSConstants.MNS_PARAMETER_WAIT_SECONDS, request.WaitSeconds.ToString());
            }
            paramters.Add(MNSConstants.MNS_PARAMETER_BATCH_SIZE, request.BatchSize.ToString());
        }
    }
}
