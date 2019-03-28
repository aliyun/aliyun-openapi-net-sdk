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
    public class DescribeInstanceStatusResponseUnmarshaller
    {
        public static DescribeInstanceStatusResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceStatusResponse describeInstanceStatusResponse = new DescribeInstanceStatusResponse();

			describeInstanceStatusResponse.HttpResponse = context.HttpResponse;
			describeInstanceStatusResponse.RequestId = context.StringValue("DescribeInstanceStatus.RequestId");
			describeInstanceStatusResponse.TotalCount = context.IntegerValue("DescribeInstanceStatus.TotalCount");
			describeInstanceStatusResponse.PageNumber = context.IntegerValue("DescribeInstanceStatus.PageNumber");
			describeInstanceStatusResponse.PageSize = context.IntegerValue("DescribeInstanceStatus.PageSize");

			List<DescribeInstanceStatusResponse.DescribeInstanceStatus_InstanceStatus> describeInstanceStatusResponse_instanceStatuses = new List<DescribeInstanceStatusResponse.DescribeInstanceStatus_InstanceStatus>();
			for (int i = 0; i < context.Length("DescribeInstanceStatus.InstanceStatuses.Length"); i++) {
				DescribeInstanceStatusResponse.DescribeInstanceStatus_InstanceStatus instanceStatus = new DescribeInstanceStatusResponse.DescribeInstanceStatus_InstanceStatus();
				instanceStatus.InstanceId = context.StringValue("DescribeInstanceStatus.InstanceStatuses["+ i +"].InstanceId");
				instanceStatus.Status = context.StringValue("DescribeInstanceStatus.InstanceStatuses["+ i +"].Status");

				describeInstanceStatusResponse_instanceStatuses.Add(instanceStatus);
			}
			describeInstanceStatusResponse.InstanceStatuses = describeInstanceStatusResponse_instanceStatuses;
        
			return describeInstanceStatusResponse;
        }
    }
}
