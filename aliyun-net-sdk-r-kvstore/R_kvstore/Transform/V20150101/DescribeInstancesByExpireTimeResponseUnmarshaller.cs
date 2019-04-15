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
    public class DescribeInstancesByExpireTimeResponseUnmarshaller
    {
        public static DescribeInstancesByExpireTimeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstancesByExpireTimeResponse describeInstancesByExpireTimeResponse = new DescribeInstancesByExpireTimeResponse();

			describeInstancesByExpireTimeResponse.HttpResponse = context.HttpResponse;
			describeInstancesByExpireTimeResponse.RequestId = context.StringValue("DescribeInstancesByExpireTime.RequestId");
			describeInstancesByExpireTimeResponse.PageNumber = context.IntegerValue("DescribeInstancesByExpireTime.PageNumber");
			describeInstancesByExpireTimeResponse.PageSize = context.IntegerValue("DescribeInstancesByExpireTime.PageSize");
			describeInstancesByExpireTimeResponse.TotalCount = context.IntegerValue("DescribeInstancesByExpireTime.TotalCount");

			List<DescribeInstancesByExpireTimeResponse.DescribeInstancesByExpireTime_KVStoreInstance> describeInstancesByExpireTimeResponse_instances = new List<DescribeInstancesByExpireTimeResponse.DescribeInstancesByExpireTime_KVStoreInstance>();
			for (int i = 0; i < context.Length("DescribeInstancesByExpireTime.Instances.Length"); i++) {
				DescribeInstancesByExpireTimeResponse.DescribeInstancesByExpireTime_KVStoreInstance kVStoreInstance = new DescribeInstancesByExpireTimeResponse.DescribeInstancesByExpireTime_KVStoreInstance();
				kVStoreInstance.ReplacateId = context.StringValue("DescribeInstancesByExpireTime.Instances["+ i +"].ReplacateId");
				kVStoreInstance.InstanceId = context.StringValue("DescribeInstancesByExpireTime.Instances["+ i +"].InstanceId");
				kVStoreInstance.InstanceName = context.StringValue("DescribeInstancesByExpireTime.Instances["+ i +"].InstanceName");
				kVStoreInstance.ConnectionDomain = context.StringValue("DescribeInstancesByExpireTime.Instances["+ i +"].ConnectionDomain");
				kVStoreInstance.Port = context.LongValue("DescribeInstancesByExpireTime.Instances["+ i +"].Port");
				kVStoreInstance.UserName = context.StringValue("DescribeInstancesByExpireTime.Instances["+ i +"].UserName");
				kVStoreInstance.InstanceStatus = context.StringValue("DescribeInstancesByExpireTime.Instances["+ i +"].InstanceStatus");
				kVStoreInstance.RegionId = context.StringValue("DescribeInstancesByExpireTime.Instances["+ i +"].RegionId");
				kVStoreInstance.Capacity = context.LongValue("DescribeInstancesByExpireTime.Instances["+ i +"].Capacity");
				kVStoreInstance.InstanceClass = context.StringValue("DescribeInstancesByExpireTime.Instances["+ i +"].InstanceClass");
				kVStoreInstance.QPS = context.LongValue("DescribeInstancesByExpireTime.Instances["+ i +"].QPS");
				kVStoreInstance.Bandwidth = context.LongValue("DescribeInstancesByExpireTime.Instances["+ i +"].Bandwidth");
				kVStoreInstance.Connections = context.LongValue("DescribeInstancesByExpireTime.Instances["+ i +"].Connections");
				kVStoreInstance.ZoneId = context.StringValue("DescribeInstancesByExpireTime.Instances["+ i +"].ZoneId");
				kVStoreInstance.Config = context.StringValue("DescribeInstancesByExpireTime.Instances["+ i +"].Config");
				kVStoreInstance.ChargeType = context.StringValue("DescribeInstancesByExpireTime.Instances["+ i +"].ChargeType");
				kVStoreInstance.NetworkType = context.StringValue("DescribeInstancesByExpireTime.Instances["+ i +"].NetworkType");
				kVStoreInstance.VpcId = context.StringValue("DescribeInstancesByExpireTime.Instances["+ i +"].VpcId");
				kVStoreInstance.VSwitchId = context.StringValue("DescribeInstancesByExpireTime.Instances["+ i +"].VSwitchId");
				kVStoreInstance.PrivateIp = context.StringValue("DescribeInstancesByExpireTime.Instances["+ i +"].PrivateIp");
				kVStoreInstance.CreateTime = context.StringValue("DescribeInstancesByExpireTime.Instances["+ i +"].CreateTime");
				kVStoreInstance.EndTime = context.StringValue("DescribeInstancesByExpireTime.Instances["+ i +"].EndTime");
				kVStoreInstance.HasRenewChangeOrder = context.StringValue("DescribeInstancesByExpireTime.Instances["+ i +"].HasRenewChangeOrder");
				kVStoreInstance.IsRds = context.BooleanValue("DescribeInstancesByExpireTime.Instances["+ i +"].IsRds");
				kVStoreInstance.InstanceType = context.StringValue("DescribeInstancesByExpireTime.Instances["+ i +"].InstanceType");
				kVStoreInstance.ArchitectureType = context.StringValue("DescribeInstancesByExpireTime.Instances["+ i +"].ArchitectureType");
				kVStoreInstance.NodeType = context.StringValue("DescribeInstancesByExpireTime.Instances["+ i +"].NodeType");
				kVStoreInstance.PackageType = context.StringValue("DescribeInstancesByExpireTime.Instances["+ i +"].PackageType");
				kVStoreInstance.EngineVersion = context.StringValue("DescribeInstancesByExpireTime.Instances["+ i +"].EngineVersion");

				describeInstancesByExpireTimeResponse_instances.Add(kVStoreInstance);
			}
			describeInstancesByExpireTimeResponse.Instances = describeInstancesByExpireTimeResponse_instances;
        
			return describeInstancesByExpireTimeResponse;
        }
    }
}
