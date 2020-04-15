/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Smartag.Model.V20180313;

namespace Aliyun.Acs.Smartag.Transform.V20180313
{
    public class CreateQosPolicyResponseUnmarshaller
    {
        public static CreateQosPolicyResponse Unmarshall(UnmarshallerContext context)
        {
			CreateQosPolicyResponse createQosPolicyResponse = new CreateQosPolicyResponse();

			createQosPolicyResponse.HttpResponse = context.HttpResponse;
			createQosPolicyResponse.RequestId = context.StringValue("CreateQosPolicy.RequestId");
			createQosPolicyResponse.QosId = context.StringValue("CreateQosPolicy.QosId");
			createQosPolicyResponse.QosPolicyId = context.StringValue("CreateQosPolicy.QosPolicyId");
			createQosPolicyResponse.Description = context.StringValue("CreateQosPolicy.Description");
			createQosPolicyResponse.Priority = context.IntegerValue("CreateQosPolicy.Priority");
			createQosPolicyResponse.SourceCidr = context.StringValue("CreateQosPolicy.SourceCidr");
			createQosPolicyResponse.DestCidr = context.StringValue("CreateQosPolicy.DestCidr");
			createQosPolicyResponse.IpProtocol = context.StringValue("CreateQosPolicy.IpProtocol");
			createQosPolicyResponse.SourcePortRange = context.StringValue("CreateQosPolicy.SourcePortRange");
			createQosPolicyResponse.DestPortRange = context.StringValue("CreateQosPolicy.DestPortRange");
			createQosPolicyResponse.StartTime = context.StringValue("CreateQosPolicy.StartTime");
			createQosPolicyResponse.EndTime = context.StringValue("CreateQosPolicy.EndTime");
			createQosPolicyResponse.Name = context.StringValue("CreateQosPolicy.Name");
        
			return createQosPolicyResponse;
        }
    }
}
