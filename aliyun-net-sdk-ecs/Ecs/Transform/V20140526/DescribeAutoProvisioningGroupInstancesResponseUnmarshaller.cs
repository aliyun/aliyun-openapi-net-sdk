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
        public static DescribeAutoProvisioningGroupInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAutoProvisioningGroupInstancesResponse describeAutoProvisioningGroupInstancesResponse = new DescribeAutoProvisioningGroupInstancesResponse();

			describeAutoProvisioningGroupInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeAutoProvisioningGroupInstancesResponse.PageSize = _ctx.IntegerValue("DescribeAutoProvisioningGroupInstances.PageSize");
			describeAutoProvisioningGroupInstancesResponse.RequestId = _ctx.StringValue("DescribeAutoProvisioningGroupInstances.RequestId");
			describeAutoProvisioningGroupInstancesResponse.PageNumber = _ctx.IntegerValue("DescribeAutoProvisioningGroupInstances.PageNumber");
			describeAutoProvisioningGroupInstancesResponse.TotalCount = _ctx.IntegerValue("DescribeAutoProvisioningGroupInstances.TotalCount");

			List<DescribeAutoProvisioningGroupInstancesResponse.DescribeAutoProvisioningGroupInstances_Instance> describeAutoProvisioningGroupInstancesResponse_instances = new List<DescribeAutoProvisioningGroupInstancesResponse.DescribeAutoProvisioningGroupInstances_Instance>();
			for (int i = 0; i < _ctx.Length("DescribeAutoProvisioningGroupInstances.Instances.Length"); i++) {
				DescribeAutoProvisioningGroupInstancesResponse.DescribeAutoProvisioningGroupInstances_Instance instance = new DescribeAutoProvisioningGroupInstancesResponse.DescribeAutoProvisioningGroupInstances_Instance();
				instance.Status = _ctx.StringValue("DescribeAutoProvisioningGroupInstances.Instances["+ i +"].Status");
				instance.CreationTime = _ctx.StringValue("DescribeAutoProvisioningGroupInstances.Instances["+ i +"].CreationTime");
				instance.IsSpot = _ctx.BooleanValue("DescribeAutoProvisioningGroupInstances.Instances["+ i +"].IsSpot");
				instance.CPU = _ctx.IntegerValue("DescribeAutoProvisioningGroupInstances.Instances["+ i +"].CPU");
				instance.InstanceId = _ctx.StringValue("DescribeAutoProvisioningGroupInstances.Instances["+ i +"].InstanceId");
				instance.NetworkType = _ctx.StringValue("DescribeAutoProvisioningGroupInstances.Instances["+ i +"].NetworkType");
				instance.InstanceType = _ctx.StringValue("DescribeAutoProvisioningGroupInstances.Instances["+ i +"].InstanceType");
				instance.RegionId = _ctx.StringValue("DescribeAutoProvisioningGroupInstances.Instances["+ i +"].RegionId");
				instance.IoOptimized = _ctx.BooleanValue("DescribeAutoProvisioningGroupInstances.Instances["+ i +"].IoOptimized");
				instance.OsType = _ctx.StringValue("DescribeAutoProvisioningGroupInstances.Instances["+ i +"].OsType");
				instance.ZoneId = _ctx.StringValue("DescribeAutoProvisioningGroupInstances.Instances["+ i +"].ZoneId");
				instance.Memory = _ctx.IntegerValue("DescribeAutoProvisioningGroupInstances.Instances["+ i +"].Memory");

				describeAutoProvisioningGroupInstancesResponse_instances.Add(instance);
			}
			describeAutoProvisioningGroupInstancesResponse.Instances = describeAutoProvisioningGroupInstancesResponse_instances;
        
			return describeAutoProvisioningGroupInstancesResponse;
        }
    }
}
