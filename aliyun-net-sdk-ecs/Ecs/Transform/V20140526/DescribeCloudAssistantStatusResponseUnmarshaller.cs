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
    public class DescribeCloudAssistantStatusResponseUnmarshaller
    {
        public static DescribeCloudAssistantStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCloudAssistantStatusResponse describeCloudAssistantStatusResponse = new DescribeCloudAssistantStatusResponse();

			describeCloudAssistantStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeCloudAssistantStatusResponse.RequestId = _ctx.StringValue("DescribeCloudAssistantStatus.RequestId");
			describeCloudAssistantStatusResponse.TotalCount = _ctx.LongValue("DescribeCloudAssistantStatus.TotalCount");
			describeCloudAssistantStatusResponse.PageNumber = _ctx.LongValue("DescribeCloudAssistantStatus.PageNumber");
			describeCloudAssistantStatusResponse.PageSize = _ctx.LongValue("DescribeCloudAssistantStatus.PageSize");

			List<DescribeCloudAssistantStatusResponse.DescribeCloudAssistantStatus_InstanceCloudAssistantStatus> describeCloudAssistantStatusResponse_instanceCloudAssistantStatusSet = new List<DescribeCloudAssistantStatusResponse.DescribeCloudAssistantStatus_InstanceCloudAssistantStatus>();
			for (int i = 0; i < _ctx.Length("DescribeCloudAssistantStatus.InstanceCloudAssistantStatusSet.Length"); i++) {
				DescribeCloudAssistantStatusResponse.DescribeCloudAssistantStatus_InstanceCloudAssistantStatus instanceCloudAssistantStatus = new DescribeCloudAssistantStatusResponse.DescribeCloudAssistantStatus_InstanceCloudAssistantStatus();
				instanceCloudAssistantStatus.InstanceId = _ctx.StringValue("DescribeCloudAssistantStatus.InstanceCloudAssistantStatusSet["+ i +"].InstanceId");
				instanceCloudAssistantStatus.OSType = _ctx.StringValue("DescribeCloudAssistantStatus.InstanceCloudAssistantStatusSet["+ i +"].OSType");
				instanceCloudAssistantStatus.CloudAssistantStatus = _ctx.StringValue("DescribeCloudAssistantStatus.InstanceCloudAssistantStatusSet["+ i +"].CloudAssistantStatus");
				instanceCloudAssistantStatus.CloudAssistantVersion = _ctx.StringValue("DescribeCloudAssistantStatus.InstanceCloudAssistantStatusSet["+ i +"].CloudAssistantVersion");
				instanceCloudAssistantStatus.InvocationCount = _ctx.LongValue("DescribeCloudAssistantStatus.InstanceCloudAssistantStatusSet["+ i +"].InvocationCount");
				instanceCloudAssistantStatus.ActiveTaskCount = _ctx.LongValue("DescribeCloudAssistantStatus.InstanceCloudAssistantStatusSet["+ i +"].ActiveTaskCount");
				instanceCloudAssistantStatus.LastInvokedTime = _ctx.StringValue("DescribeCloudAssistantStatus.InstanceCloudAssistantStatusSet["+ i +"].LastInvokedTime");
				instanceCloudAssistantStatus.LastHeartbeatTime = _ctx.StringValue("DescribeCloudAssistantStatus.InstanceCloudAssistantStatusSet["+ i +"].LastHeartbeatTime");

				describeCloudAssistantStatusResponse_instanceCloudAssistantStatusSet.Add(instanceCloudAssistantStatus);
			}
			describeCloudAssistantStatusResponse.InstanceCloudAssistantStatusSet = describeCloudAssistantStatusResponse_instanceCloudAssistantStatusSet;
        
			return describeCloudAssistantStatusResponse;
        }
    }
}
