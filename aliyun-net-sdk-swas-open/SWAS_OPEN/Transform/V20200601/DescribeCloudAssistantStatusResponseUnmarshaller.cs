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
using Aliyun.Acs.SWAS_OPEN.Model.V20200601;

namespace Aliyun.Acs.SWAS_OPEN.Transform.V20200601
{
    public class DescribeCloudAssistantStatusResponseUnmarshaller
    {
        public static DescribeCloudAssistantStatusResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCloudAssistantStatusResponse describeCloudAssistantStatusResponse = new DescribeCloudAssistantStatusResponse();

			describeCloudAssistantStatusResponse.HttpResponse = _ctx.HttpResponse;
			describeCloudAssistantStatusResponse.RequestId = _ctx.StringValue("DescribeCloudAssistantStatus.RequestId");
			describeCloudAssistantStatusResponse.TotalCount = _ctx.IntegerValue("DescribeCloudAssistantStatus.TotalCount");
			describeCloudAssistantStatusResponse.PageSize = _ctx.IntegerValue("DescribeCloudAssistantStatus.PageSize");
			describeCloudAssistantStatusResponse.PageNumber = _ctx.IntegerValue("DescribeCloudAssistantStatus.PageNumber");

			List<DescribeCloudAssistantStatusResponse.DescribeCloudAssistantStatus_Status> describeCloudAssistantStatusResponse_cloudAssistantStatus = new List<DescribeCloudAssistantStatusResponse.DescribeCloudAssistantStatus_Status>();
			for (int i = 0; i < _ctx.Length("DescribeCloudAssistantStatus.CloudAssistantStatus.Length"); i++) {
				DescribeCloudAssistantStatusResponse.DescribeCloudAssistantStatus_Status status = new DescribeCloudAssistantStatusResponse.DescribeCloudAssistantStatus_Status();
				status.InstanceId = _ctx.StringValue("DescribeCloudAssistantStatus.CloudAssistantStatus["+ i +"].InstanceId");
				status.Status = _ctx.BooleanValue("DescribeCloudAssistantStatus.CloudAssistantStatus["+ i +"].Status");

				describeCloudAssistantStatusResponse_cloudAssistantStatus.Add(status);
			}
			describeCloudAssistantStatusResponse.CloudAssistantStatus = describeCloudAssistantStatusResponse_cloudAssistantStatus;
        
			return describeCloudAssistantStatusResponse;
        }
    }
}
