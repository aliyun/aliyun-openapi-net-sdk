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
        public static DescribeInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstancesResponse describeInstancesResponse = new DescribeInstancesResponse();

			describeInstancesResponse.HttpResponse = context.HttpResponse;
			describeInstancesResponse.RequestId = context.StringValue("DescribeInstances.RequestId");
			describeInstancesResponse.PageNumber = context.IntegerValue("DescribeInstances.PageNumber");
			describeInstancesResponse.PageSize = context.IntegerValue("DescribeInstances.PageSize");
			describeInstancesResponse.TotalCount = context.IntegerValue("DescribeInstances.TotalCount");

			List<DescribeInstancesResponse.DescribeInstances_KVStoreInstance> describeInstancesResponse_instances = new List<DescribeInstancesResponse.DescribeInstances_KVStoreInstance>();
			for (int i = 0; i < context.Length("DescribeInstances.Instances.Length"); i++) {
				DescribeInstancesResponse.DescribeInstances_KVStoreInstance kVStoreInstance = new DescribeInstancesResponse.DescribeInstances_KVStoreInstance();
				kVStoreInstance.ReplacateId = context.StringValue("DescribeInstances.Instances["+ i +"].ReplacateId");
				kVStoreInstance.InstanceId = context.StringValue("DescribeInstances.Instances["+ i +"].InstanceId");
				kVStoreInstance.InstanceName = context.StringValue("DescribeInstances.Instances["+ i +"].InstanceName");
				kVStoreInstance.SearchKey = context.StringValue("DescribeInstances.Instances["+ i +"].SearchKey");
				kVStoreInstance.ConnectionDomain = context.StringValue("DescribeInstances.Instances["+ i +"].ConnectionDomain");
				kVStoreInstance.Port = context.LongValue("DescribeInstances.Instances["+ i +"].Port");
				kVStoreInstance.UserName = context.StringValue("DescribeInstances.Instances["+ i +"].UserName");
				kVStoreInstance.InstanceStatus = context.StringValue("DescribeInstances.Instances["+ i +"].InstanceStatus");
				kVStoreInstance.RegionId = context.StringValue("DescribeInstances.Instances["+ i +"].RegionId");
				kVStoreInstance.Capacity = context.LongValue("DescribeInstances.Instances["+ i +"].Capacity");
				kVStoreInstance.InstanceClass = context.StringValue("DescribeInstances.Instances["+ i +"].InstanceClass");
				kVStoreInstance.QPS = context.LongValue("DescribeInstances.Instances["+ i +"].QPS");
				kVStoreInstance.Bandwidth = context.LongValue("DescribeInstances.Instances["+ i +"].Bandwidth");
				kVStoreInstance.Connections = context.LongValue("DescribeInstances.Instances["+ i +"].Connections");
				kVStoreInstance.ZoneId = context.StringValue("DescribeInstances.Instances["+ i +"].ZoneId");
				kVStoreInstance.Config = context.StringValue("DescribeInstances.Instances["+ i +"].Config");
				kVStoreInstance.ChargeType = context.StringValue("DescribeInstances.Instances["+ i +"].ChargeType");
				kVStoreInstance.NetworkType = context.StringValue("DescribeInstances.Instances["+ i +"].NetworkType");
				kVStoreInstance.VpcId = context.StringValue("DescribeInstances.Instances["+ i +"].VpcId");
				kVStoreInstance.VSwitchId = context.StringValue("DescribeInstances.Instances["+ i +"].VSwitchId");
				kVStoreInstance.PrivateIp = context.StringValue("DescribeInstances.Instances["+ i +"].PrivateIp");
				kVStoreInstance.CreateTime = context.StringValue("DescribeInstances.Instances["+ i +"].CreateTime");
				kVStoreInstance.EndTime = context.StringValue("DescribeInstances.Instances["+ i +"].EndTime");
				kVStoreInstance.HasRenewChangeOrder = context.BooleanValue("DescribeInstances.Instances["+ i +"].HasRenewChangeOrder");
				kVStoreInstance.IsRds = context.BooleanValue("DescribeInstances.Instances["+ i +"].IsRds");
				kVStoreInstance.InstanceType = context.StringValue("DescribeInstances.Instances["+ i +"].InstanceType");
				kVStoreInstance.ArchitectureType = context.StringValue("DescribeInstances.Instances["+ i +"].ArchitectureType");
				kVStoreInstance.NodeType = context.StringValue("DescribeInstances.Instances["+ i +"].NodeType");
				kVStoreInstance.PackageType = context.StringValue("DescribeInstances.Instances["+ i +"].PackageType");
				kVStoreInstance.EngineVersion = context.StringValue("DescribeInstances.Instances["+ i +"].EngineVersion");
				kVStoreInstance.DestroyTime = context.StringValue("DescribeInstances.Instances["+ i +"].DestroyTime");
				kVStoreInstance.ConnectionMode = context.StringValue("DescribeInstances.Instances["+ i +"].ConnectionMode");
				kVStoreInstance.VpcCloudInstanceId = context.StringValue("DescribeInstances.Instances["+ i +"].VpcCloudInstanceId");
				kVStoreInstance.ResourceGroupId = context.StringValue("DescribeInstances.Instances["+ i +"].ResourceGroupId");
				kVStoreInstance.ShardCount = context.IntegerValue("DescribeInstances.Instances["+ i +"].ShardCount");
				kVStoreInstance.ProxyCount = context.IntegerValue("DescribeInstances.Instances["+ i +"].ProxyCount");

				List<DescribeInstancesResponse.DescribeInstances_KVStoreInstance.DescribeInstances_Tag> kVStoreInstance_tags = new List<DescribeInstancesResponse.DescribeInstances_KVStoreInstance.DescribeInstances_Tag>();
				for (int j = 0; j < context.Length("DescribeInstances.Instances["+ i +"].Tags.Length"); j++) {
					DescribeInstancesResponse.DescribeInstances_KVStoreInstance.DescribeInstances_Tag tag = new DescribeInstancesResponse.DescribeInstances_KVStoreInstance.DescribeInstances_Tag();
					tag.Key = context.StringValue("DescribeInstances.Instances["+ i +"].Tags["+ j +"].Key");
					tag._Value = context.StringValue("DescribeInstances.Instances["+ i +"].Tags["+ j +"].Value");

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
