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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeInstancesOverviewResponseUnmarshaller
    {
        public static DescribeInstancesOverviewResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstancesOverviewResponse describeInstancesOverviewResponse = new DescribeInstancesOverviewResponse();

			describeInstancesOverviewResponse.HttpResponse = _ctx.HttpResponse;
			describeInstancesOverviewResponse.RequestId = _ctx.StringValue("DescribeInstancesOverview.RequestId");
			describeInstancesOverviewResponse.TotalCount = _ctx.IntegerValue("DescribeInstancesOverview.TotalCount");

			List<DescribeInstancesOverviewResponse.DescribeInstancesOverview_KVStoreInstance> describeInstancesOverviewResponse_instances = new List<DescribeInstancesOverviewResponse.DescribeInstancesOverview_KVStoreInstance>();
			for (int i = 0; i < _ctx.Length("DescribeInstancesOverview.Instances.Length"); i++) {
				DescribeInstancesOverviewResponse.DescribeInstancesOverview_KVStoreInstance kVStoreInstance = new DescribeInstancesOverviewResponse.DescribeInstancesOverview_KVStoreInstance();
				kVStoreInstance.VpcId = _ctx.StringValue("DescribeInstancesOverview.Instances["+ i +"].VpcId");
				kVStoreInstance.PrivateIp = _ctx.StringValue("DescribeInstancesOverview.Instances["+ i +"].PrivateIp");
				kVStoreInstance.Capacity = _ctx.LongValue("DescribeInstancesOverview.Instances["+ i +"].Capacity");
				kVStoreInstance.CreateTime = _ctx.StringValue("DescribeInstancesOverview.Instances["+ i +"].CreateTime");
				kVStoreInstance.ConnectionDomain = _ctx.StringValue("DescribeInstancesOverview.Instances["+ i +"].ConnectionDomain");
				kVStoreInstance.ChargeType = _ctx.StringValue("DescribeInstancesOverview.Instances["+ i +"].ChargeType");
				kVStoreInstance.ArchitectureType = _ctx.StringValue("DescribeInstancesOverview.Instances["+ i +"].ArchitectureType");
				kVStoreInstance.NetworkType = _ctx.StringValue("DescribeInstancesOverview.Instances["+ i +"].NetworkType");
				kVStoreInstance.EngineVersion = _ctx.StringValue("DescribeInstancesOverview.Instances["+ i +"].EngineVersion");
				kVStoreInstance.InstanceName = _ctx.StringValue("DescribeInstancesOverview.Instances["+ i +"].InstanceName");
				kVStoreInstance.GlobalInstanceId = _ctx.StringValue("DescribeInstancesOverview.Instances["+ i +"].GlobalInstanceId");
				kVStoreInstance.InstanceClass = _ctx.StringValue("DescribeInstancesOverview.Instances["+ i +"].InstanceClass");
				kVStoreInstance.InstanceId = _ctx.StringValue("DescribeInstancesOverview.Instances["+ i +"].InstanceId");
				kVStoreInstance.InstanceType = _ctx.StringValue("DescribeInstancesOverview.Instances["+ i +"].InstanceType");
				kVStoreInstance.RegionId = _ctx.StringValue("DescribeInstancesOverview.Instances["+ i +"].RegionId");
				kVStoreInstance.EndTime = _ctx.StringValue("DescribeInstancesOverview.Instances["+ i +"].EndTime");
				kVStoreInstance.VSwitchId = _ctx.StringValue("DescribeInstancesOverview.Instances["+ i +"].VSwitchId");
				kVStoreInstance.ResourceGroupId = _ctx.StringValue("DescribeInstancesOverview.Instances["+ i +"].ResourceGroupId");
				kVStoreInstance.ZoneId = _ctx.StringValue("DescribeInstancesOverview.Instances["+ i +"].ZoneId");
				kVStoreInstance.InstanceStatus = _ctx.StringValue("DescribeInstancesOverview.Instances["+ i +"].InstanceStatus");
				kVStoreInstance.SecondaryZoneId = _ctx.StringValue("DescribeInstancesOverview.Instances["+ i +"].SecondaryZoneId");

				describeInstancesOverviewResponse_instances.Add(kVStoreInstance);
			}
			describeInstancesOverviewResponse.Instances = describeInstancesOverviewResponse_instances;
        
			return describeInstancesOverviewResponse;
        }
    }
}
