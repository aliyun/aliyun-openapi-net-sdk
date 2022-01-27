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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeActivationsResponseUnmarshaller
    {
        public static DescribeActivationsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeActivationsResponse describeActivationsResponse = new DescribeActivationsResponse();

			describeActivationsResponse.HttpResponse = _ctx.HttpResponse;
			describeActivationsResponse.PageSize = _ctx.LongValue("DescribeActivations.PageSize");
			describeActivationsResponse.RequestId = _ctx.StringValue("DescribeActivations.RequestId");
			describeActivationsResponse.PageNumber = _ctx.LongValue("DescribeActivations.PageNumber");
			describeActivationsResponse.TotalCount = _ctx.LongValue("DescribeActivations.TotalCount");

			List<DescribeActivationsResponse.DescribeActivations_Activation> describeActivationsResponse_activationList = new List<DescribeActivationsResponse.DescribeActivations_Activation>();
			for (int i = 0; i < _ctx.Length("DescribeActivations.ActivationList.Length"); i++) {
				DescribeActivationsResponse.DescribeActivations_Activation activation = new DescribeActivationsResponse.DescribeActivations_Activation();
				activation.CreationTime = _ctx.StringValue("DescribeActivations.ActivationList["+ i +"].CreationTime");
				activation.DeregisteredCount = _ctx.IntegerValue("DescribeActivations.ActivationList["+ i +"].DeregisteredCount");
				activation.InstanceCount = _ctx.IntegerValue("DescribeActivations.ActivationList["+ i +"].InstanceCount");
				activation.Description = _ctx.StringValue("DescribeActivations.ActivationList["+ i +"].Description");
				activation.RegisteredCount = _ctx.IntegerValue("DescribeActivations.ActivationList["+ i +"].RegisteredCount");
				activation.InstanceName = _ctx.StringValue("DescribeActivations.ActivationList["+ i +"].InstanceName");
				activation.Disabled = _ctx.BooleanValue("DescribeActivations.ActivationList["+ i +"].Disabled");
				activation.IpAddressRange = _ctx.StringValue("DescribeActivations.ActivationList["+ i +"].IpAddressRange");
				activation.TimeToLiveInHours = _ctx.LongValue("DescribeActivations.ActivationList["+ i +"].TimeToLiveInHours");
				activation.ActivationId = _ctx.StringValue("DescribeActivations.ActivationList["+ i +"].ActivationId");

				describeActivationsResponse_activationList.Add(activation);
			}
			describeActivationsResponse.ActivationList = describeActivationsResponse_activationList;
        
			return describeActivationsResponse;
        }
    }
}
