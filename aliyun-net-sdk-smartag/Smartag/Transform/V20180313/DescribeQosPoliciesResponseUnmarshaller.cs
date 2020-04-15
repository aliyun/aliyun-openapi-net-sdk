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
    public class DescribeQosPoliciesResponseUnmarshaller
    {
        public static DescribeQosPoliciesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeQosPoliciesResponse describeQosPoliciesResponse = new DescribeQosPoliciesResponse();

			describeQosPoliciesResponse.HttpResponse = context.HttpResponse;
			describeQosPoliciesResponse.RequestId = context.StringValue("DescribeQosPolicies.RequestId");
			describeQosPoliciesResponse.TotalCount = context.IntegerValue("DescribeQosPolicies.TotalCount");
			describeQosPoliciesResponse.PageNumber = context.IntegerValue("DescribeQosPolicies.PageNumber");
			describeQosPoliciesResponse.PageSize = context.IntegerValue("DescribeQosPolicies.PageSize");

			List<DescribeQosPoliciesResponse.DescribeQosPolicies_QosPolicy> describeQosPoliciesResponse_qosPolicies = new List<DescribeQosPoliciesResponse.DescribeQosPolicies_QosPolicy>();
			for (int i = 0; i < context.Length("DescribeQosPolicies.QosPolicies.Length"); i++) {
				DescribeQosPoliciesResponse.DescribeQosPolicies_QosPolicy qosPolicy = new DescribeQosPoliciesResponse.DescribeQosPolicies_QosPolicy();
				qosPolicy.QosPolicyId = context.StringValue("DescribeQosPolicies.QosPolicies["+ i +"].QosPolicyId");
				qosPolicy.QosId = context.StringValue("DescribeQosPolicies.QosPolicies["+ i +"].QosId");
				qosPolicy.Priority = context.IntegerValue("DescribeQosPolicies.QosPolicies["+ i +"].Priority");
				qosPolicy.Description = context.StringValue("DescribeQosPolicies.QosPolicies["+ i +"].Description");
				qosPolicy.SourceCidr = context.StringValue("DescribeQosPolicies.QosPolicies["+ i +"].SourceCidr");
				qosPolicy.DestCidr = context.StringValue("DescribeQosPolicies.QosPolicies["+ i +"].DestCidr");
				qosPolicy.IpProtocol = context.StringValue("DescribeQosPolicies.QosPolicies["+ i +"].IpProtocol");
				qosPolicy.SourcePortRange = context.StringValue("DescribeQosPolicies.QosPolicies["+ i +"].SourcePortRange");
				qosPolicy.DestPortRange = context.StringValue("DescribeQosPolicies.QosPolicies["+ i +"].DestPortRange");
				qosPolicy.StartTime = context.StringValue("DescribeQosPolicies.QosPolicies["+ i +"].StartTime");
				qosPolicy.EndTime = context.StringValue("DescribeQosPolicies.QosPolicies["+ i +"].EndTime");
				qosPolicy.Name = context.StringValue("DescribeQosPolicies.QosPolicies["+ i +"].Name");

				describeQosPoliciesResponse_qosPolicies.Add(qosPolicy);
			}
			describeQosPoliciesResponse.QosPolicies = describeQosPoliciesResponse_qosPolicies;
        
			return describeQosPoliciesResponse;
        }
    }
}
