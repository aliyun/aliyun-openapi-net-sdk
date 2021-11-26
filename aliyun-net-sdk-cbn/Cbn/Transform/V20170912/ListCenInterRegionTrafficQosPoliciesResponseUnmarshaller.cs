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
using Aliyun.Acs.Cbn.Model.V20170912;

namespace Aliyun.Acs.Cbn.Transform.V20170912
{
    public class ListCenInterRegionTrafficQosPoliciesResponseUnmarshaller
    {
        public static ListCenInterRegionTrafficQosPoliciesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListCenInterRegionTrafficQosPoliciesResponse listCenInterRegionTrafficQosPoliciesResponse = new ListCenInterRegionTrafficQosPoliciesResponse();

			listCenInterRegionTrafficQosPoliciesResponse.HttpResponse = _ctx.HttpResponse;
			listCenInterRegionTrafficQosPoliciesResponse.NextToken = _ctx.StringValue("ListCenInterRegionTrafficQosPolicies.NextToken");
			listCenInterRegionTrafficQosPoliciesResponse.RequestId = _ctx.StringValue("ListCenInterRegionTrafficQosPolicies.RequestId");
			listCenInterRegionTrafficQosPoliciesResponse.TotalCount = _ctx.IntegerValue("ListCenInterRegionTrafficQosPolicies.TotalCount");
			listCenInterRegionTrafficQosPoliciesResponse.MaxResults = _ctx.IntegerValue("ListCenInterRegionTrafficQosPolicies.MaxResults");

			List<ListCenInterRegionTrafficQosPoliciesResponse.ListCenInterRegionTrafficQosPolicies_TrafficQosPolicy> listCenInterRegionTrafficQosPoliciesResponse_trafficQosPolicies = new List<ListCenInterRegionTrafficQosPoliciesResponse.ListCenInterRegionTrafficQosPolicies_TrafficQosPolicy>();
			for (int i = 0; i < _ctx.Length("ListCenInterRegionTrafficQosPolicies.TrafficQosPolicies.Length"); i++) {
				ListCenInterRegionTrafficQosPoliciesResponse.ListCenInterRegionTrafficQosPolicies_TrafficQosPolicy trafficQosPolicy = new ListCenInterRegionTrafficQosPoliciesResponse.ListCenInterRegionTrafficQosPolicies_TrafficQosPolicy();
				trafficQosPolicy.TrafficQosPolicyName = _ctx.StringValue("ListCenInterRegionTrafficQosPolicies.TrafficQosPolicies["+ i +"].TrafficQosPolicyName");
				trafficQosPolicy.TrafficQosPolicyStatus = _ctx.StringValue("ListCenInterRegionTrafficQosPolicies.TrafficQosPolicies["+ i +"].TrafficQosPolicyStatus");
				trafficQosPolicy.TrafficQosPolicyId = _ctx.StringValue("ListCenInterRegionTrafficQosPolicies.TrafficQosPolicies["+ i +"].TrafficQosPolicyId");
				trafficQosPolicy.TrafficQosPolicyDescription = _ctx.StringValue("ListCenInterRegionTrafficQosPolicies.TrafficQosPolicies["+ i +"].TrafficQosPolicyDescription");

				List<ListCenInterRegionTrafficQosPoliciesResponse.ListCenInterRegionTrafficQosPolicies_TrafficQosPolicy.ListCenInterRegionTrafficQosPolicies_TrafficQosQueue> trafficQosPolicy_trafficQosQueues = new List<ListCenInterRegionTrafficQosPoliciesResponse.ListCenInterRegionTrafficQosPolicies_TrafficQosPolicy.ListCenInterRegionTrafficQosPolicies_TrafficQosQueue>();
				for (int j = 0; j < _ctx.Length("ListCenInterRegionTrafficQosPolicies.TrafficQosPolicies["+ i +"].TrafficQosQueues.Length"); j++) {
					ListCenInterRegionTrafficQosPoliciesResponse.ListCenInterRegionTrafficQosPolicies_TrafficQosPolicy.ListCenInterRegionTrafficQosPolicies_TrafficQosQueue trafficQosQueue = new ListCenInterRegionTrafficQosPoliciesResponse.ListCenInterRegionTrafficQosPolicies_TrafficQosPolicy.ListCenInterRegionTrafficQosPolicies_TrafficQosQueue();
					trafficQosQueue.QosQueueName = _ctx.StringValue("ListCenInterRegionTrafficQosPolicies.TrafficQosPolicies["+ i +"].TrafficQosQueues["+ j +"].QosQueueName");
					trafficQosQueue.RemainBandwidthPercent = _ctx.IntegerValue("ListCenInterRegionTrafficQosPolicies.TrafficQosPolicies["+ i +"].TrafficQosQueues["+ j +"].RemainBandwidthPercent");
					trafficQosQueue.QosQueueId = _ctx.StringValue("ListCenInterRegionTrafficQosPolicies.TrafficQosPolicies["+ i +"].TrafficQosQueues["+ j +"].QosQueueId");
					trafficQosQueue.QosQueueDescription = _ctx.StringValue("ListCenInterRegionTrafficQosPolicies.TrafficQosPolicies["+ i +"].TrafficQosQueues["+ j +"].QosQueueDescription");

					List<string> trafficQosQueue_dscps = new List<string>();
					for (int k = 0; k < _ctx.Length("ListCenInterRegionTrafficQosPolicies.TrafficQosPolicies["+ i +"].TrafficQosQueues["+ j +"].Dscps.Length"); k++) {
						trafficQosQueue_dscps.Add(_ctx.StringValue("ListCenInterRegionTrafficQosPolicies.TrafficQosPolicies["+ i +"].TrafficQosQueues["+ j +"].Dscps["+ k +"]"));
					}
					trafficQosQueue.Dscps = trafficQosQueue_dscps;

					trafficQosPolicy_trafficQosQueues.Add(trafficQosQueue);
				}
				trafficQosPolicy.TrafficQosQueues = trafficQosPolicy_trafficQosQueues;

				listCenInterRegionTrafficQosPoliciesResponse_trafficQosPolicies.Add(trafficQosPolicy);
			}
			listCenInterRegionTrafficQosPoliciesResponse.TrafficQosPolicies = listCenInterRegionTrafficQosPoliciesResponse_trafficQosPolicies;
        
			return listCenInterRegionTrafficQosPoliciesResponse;
        }
    }
}
