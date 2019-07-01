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
    public class DescribeAutoProvisioningGroupInstancesResponseUnmarshaller
    {
        public static DescribeAutoProvisioningGroupInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAutoProvisioningGroupInstancesResponse describeAutoProvisioningGroupInstancesResponse = new DescribeAutoProvisioningGroupInstancesResponse();

			describeAutoProvisioningGroupInstancesResponse.HttpResponse = context.HttpResponse;
			describeAutoProvisioningGroupInstancesResponse.RequestId = context.StringValue("DescribeAutoProvisioningGroupInstances.RequestId");
			describeAutoProvisioningGroupInstancesResponse.TotalCount = context.IntegerValue("DescribeAutoProvisioningGroupInstances.TotalCount");
			describeAutoProvisioningGroupInstancesResponse.PageNumber = context.IntegerValue("DescribeAutoProvisioningGroupInstances.PageNumber");
			describeAutoProvisioningGroupInstancesResponse.PageSize = context.IntegerValue("DescribeAutoProvisioningGroupInstances.PageSize");

			List<DescribeAutoProvisioningGroupInstancesResponse.DescribeAutoProvisioningGroupInstances_Instance> describeAutoProvisioningGroupInstancesResponse_instances = new List<DescribeAutoProvisioningGroupInstancesResponse.DescribeAutoProvisioningGroupInstances_Instance>();
			for (int i = 0; i < context.Length("DescribeAutoProvisioningGroupInstances.Instances.Length"); i++) {
				DescribeAutoProvisioningGroupInstancesResponse.DescribeAutoProvisioningGroupInstances_Instance instance = new DescribeAutoProvisioningGroupInstancesResponse.DescribeAutoProvisioningGroupInstances_Instance();
				instance.InstanceId = context.StringValue("DescribeAutoProvisioningGroupInstances.Instances["+ i +"].InstanceId");
				instance.Status = context.StringValue("DescribeAutoProvisioningGroupInstances.Instances["+ i +"].Status");
				instance.RegionId = context.StringValue("DescribeAutoProvisioningGroupInstances.Instances["+ i +"].RegionId");
				instance.ZoneId = context.StringValue("DescribeAutoProvisioningGroupInstances.Instances["+ i +"].ZoneId");
				instance.CPU = context.IntegerValue("DescribeAutoProvisioningGroupInstances.Instances["+ i +"].CPU");
				instance.Memory = context.IntegerValue("DescribeAutoProvisioningGroupInstances.Instances["+ i +"].Memory");
				instance.InstanceType = context.StringValue("DescribeAutoProvisioningGroupInstances.Instances["+ i +"].InstanceType");
				instance.IsSpot = context.BooleanValue("DescribeAutoProvisioningGroupInstances.Instances["+ i +"].IsSpot");
				instance.IoOptimized = context.BooleanValue("DescribeAutoProvisioningGroupInstances.Instances["+ i +"].IoOptimized");
				instance.NetworkType = context.StringValue("DescribeAutoProvisioningGroupInstances.Instances["+ i +"].NetworkType");
				instance.OsType = context.StringValue("DescribeAutoProvisioningGroupInstances.Instances["+ i +"].OsType");
				instance.CreationTime = context.StringValue("DescribeAutoProvisioningGroupInstances.Instances["+ i +"].CreationTime");

				describeAutoProvisioningGroupInstancesResponse_instances.Add(instance);
			}
			describeAutoProvisioningGroupInstancesResponse.Instances = describeAutoProvisioningGroupInstancesResponse_instances;
        
			return describeAutoProvisioningGroupInstancesResponse;
        }
    }
}
