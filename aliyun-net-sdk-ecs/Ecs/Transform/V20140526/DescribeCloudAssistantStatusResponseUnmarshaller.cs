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
        public static DescribeCloudAssistantStatusResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCloudAssistantStatusResponse describeCloudAssistantStatusResponse = new DescribeCloudAssistantStatusResponse();

			describeCloudAssistantStatusResponse.HttpResponse = context.HttpResponse;
			describeCloudAssistantStatusResponse.RequestId = context.StringValue("DescribeCloudAssistantStatus.RequestId");

			List<DescribeCloudAssistantStatusResponse.DescribeCloudAssistantStatus_InstanceCloudAssistantStatus> describeCloudAssistantStatusResponse_instanceCloudAssistantStatusSet = new List<DescribeCloudAssistantStatusResponse.DescribeCloudAssistantStatus_InstanceCloudAssistantStatus>();
			for (int i = 0; i < context.Length("DescribeCloudAssistantStatus.InstanceCloudAssistantStatusSet.Length"); i++) {
				DescribeCloudAssistantStatusResponse.DescribeCloudAssistantStatus_InstanceCloudAssistantStatus instanceCloudAssistantStatus = new DescribeCloudAssistantStatusResponse.DescribeCloudAssistantStatus_InstanceCloudAssistantStatus();
				instanceCloudAssistantStatus.InstanceId = context.StringValue("DescribeCloudAssistantStatus.InstanceCloudAssistantStatusSet["+ i +"].InstanceId");
				instanceCloudAssistantStatus.CloudAssistantStatus = context.StringValue("DescribeCloudAssistantStatus.InstanceCloudAssistantStatusSet["+ i +"].CloudAssistantStatus");
				instanceCloudAssistantStatus.CloudAssistantVersion = context.StringValue("DescribeCloudAssistantStatus.InstanceCloudAssistantStatusSet["+ i +"].CloudAssistantVersion");

				describeCloudAssistantStatusResponse_instanceCloudAssistantStatusSet.Add(instanceCloudAssistantStatus);
			}
			describeCloudAssistantStatusResponse.InstanceCloudAssistantStatusSet = describeCloudAssistantStatusResponse_instanceCloudAssistantStatusSet;
        
			return describeCloudAssistantStatusResponse;
        }
    }
}
