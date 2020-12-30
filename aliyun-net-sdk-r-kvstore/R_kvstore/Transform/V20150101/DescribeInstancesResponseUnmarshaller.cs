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
    public class DescribeInstancesResponseUnmarshaller
    {
        public static DescribeInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstancesResponse describeInstancesResponse = new DescribeInstancesResponse();

			describeInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeInstancesResponse.RequestId = _ctx.StringValue("DescribeInstances.RequestId");
			describeInstancesResponse.PageNumber = _ctx.IntegerValue("DescribeInstances.PageNumber");
			describeInstancesResponse.PageSize = _ctx.IntegerValue("DescribeInstances.PageSize");
			describeInstancesResponse.TotalCount = _ctx.IntegerValue("DescribeInstances.TotalCount");

			List<DescribeInstancesResponse.DescribeInstances_KVStoreInstance> describeInstancesResponse_instances = new List<DescribeInstancesResponse.DescribeInstances_KVStoreInstance>();
			for (int i = 0; i < _ctx.Length("DescribeInstances.Instances.Length"); i++) {
				DescribeInstancesResponse.DescribeInstances_KVStoreInstance kVStoreInstance = new DescribeInstancesResponse.DescribeInstances_KVStoreInstance();
				kVStoreInstance.ReplacateId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].ReplacateId");
				kVStoreInstance.InstanceId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].InstanceId");
				kVStoreInstance.InstanceName = _ctx.StringValue("DescribeInstances.Instances["+ i +"].InstanceName");
				kVStoreInstance.SearchKey = _ctx.StringValue("DescribeInstances.Instances["+ i +"].SearchKey");
				kVStoreInstance.ConnectionDomain = _ctx.StringValue("DescribeInstances.Instances["+ i +"].ConnectionDomain");
				kVStoreInstance.Port = _ctx.LongValue("DescribeInstances.Instances["+ i +"].Port");
				kVStoreInstance.UserName = _ctx.StringValue("DescribeInstances.Instances["+ i +"].UserName");
				kVStoreInstance.InstanceStatus = _ctx.StringValue("DescribeInstances.Instances["+ i +"].InstanceStatus");
				kVStoreInstance.RegionId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].RegionId");
				kVStoreInstance.Capacity = _ctx.LongValue("DescribeInstances.Instances["+ i +"].Capacity");
				kVStoreInstance.InstanceClass = _ctx.StringValue("DescribeInstances.Instances["+ i +"].InstanceClass");
				kVStoreInstance.QPS = _ctx.LongValue("DescribeInstances.Instances["+ i +"].QPS");
				kVStoreInstance.Bandwidth = _ctx.LongValue("DescribeInstances.Instances["+ i +"].Bandwidth");
				kVStoreInstance.Connections = _ctx.LongValue("DescribeInstances.Instances["+ i +"].Connections");
				kVStoreInstance.ZoneId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].ZoneId");
				kVStoreInstance.Config = _ctx.StringValue("DescribeInstances.Instances["+ i +"].Config");
				kVStoreInstance.ChargeType = _ctx.StringValue("DescribeInstances.Instances["+ i +"].ChargeType");
				kVStoreInstance.NetworkType = _ctx.StringValue("DescribeInstances.Instances["+ i +"].NetworkType");
				kVStoreInstance.VpcId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].VpcId");
				kVStoreInstance.VSwitchId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].VSwitchId");
				kVStoreInstance.PrivateIp = _ctx.StringValue("DescribeInstances.Instances["+ i +"].PrivateIp");
				kVStoreInstance.CreateTime = _ctx.StringValue("DescribeInstances.Instances["+ i +"].CreateTime");
				kVStoreInstance.EndTime = _ctx.StringValue("DescribeInstances.Instances["+ i +"].EndTime");
				kVStoreInstance.HasRenewChangeOrder = _ctx.BooleanValue("DescribeInstances.Instances["+ i +"].HasRenewChangeOrder");
				kVStoreInstance.IsRds = _ctx.BooleanValue("DescribeInstances.Instances["+ i +"].IsRds");
				kVStoreInstance.InstanceType = _ctx.StringValue("DescribeInstances.Instances["+ i +"].InstanceType");
				kVStoreInstance.ArchitectureType = _ctx.StringValue("DescribeInstances.Instances["+ i +"].ArchitectureType");
				kVStoreInstance.NodeType = _ctx.StringValue("DescribeInstances.Instances["+ i +"].NodeType");
				kVStoreInstance.PackageType = _ctx.StringValue("DescribeInstances.Instances["+ i +"].PackageType");
				kVStoreInstance.EngineVersion = _ctx.StringValue("DescribeInstances.Instances["+ i +"].EngineVersion");
				kVStoreInstance.DestroyTime = _ctx.StringValue("DescribeInstances.Instances["+ i +"].DestroyTime");
				kVStoreInstance.ConnectionMode = _ctx.StringValue("DescribeInstances.Instances["+ i +"].ConnectionMode");
				kVStoreInstance.VpcCloudInstanceId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].VpcCloudInstanceId");
				kVStoreInstance.ResourceGroupId = _ctx.StringValue("DescribeInstances.Instances["+ i +"].ResourceGroupId");
				kVStoreInstance.ShardCount = _ctx.IntegerValue("DescribeInstances.Instances["+ i +"].ShardCount");
				kVStoreInstance.ProxyCount = _ctx.IntegerValue("DescribeInstances.Instances["+ i +"].ProxyCount");

				List<DescribeInstancesResponse.DescribeInstances_KVStoreInstance.DescribeInstances_Tag> kVStoreInstance_tags = new List<DescribeInstancesResponse.DescribeInstances_KVStoreInstance.DescribeInstances_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeInstances.Instances["+ i +"].Tags.Length"); j++) {
					DescribeInstancesResponse.DescribeInstances_KVStoreInstance.DescribeInstances_Tag tag = new DescribeInstancesResponse.DescribeInstances_KVStoreInstance.DescribeInstances_Tag();
					tag.Key = _ctx.StringValue("DescribeInstances.Instances["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeInstances.Instances["+ i +"].Tags["+ j +"].Value");

					kVStoreInstance_tags.Add(tag);
				}
				kVStoreInstance.Tags = kVStoreInstance_tags;

				describeInstancesResponse_instances.Add(kVStoreInstance);
			}
			describeInstancesResponse.Instances = describeInstancesResponse_instances;
        
			return describeInstancesResponse;
        }
    }
}
