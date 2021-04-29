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
    public class DescribeInstanceAttributeResponseUnmarshaller
    {
        public static DescribeInstanceAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceAttributeResponse describeInstanceAttributeResponse = new DescribeInstanceAttributeResponse();

			describeInstanceAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceAttributeResponse.RequestId = _ctx.StringValue("DescribeInstanceAttribute.RequestId");

			List<DescribeInstanceAttributeResponse.DescribeInstanceAttribute_DBInstanceAttribute> describeInstanceAttributeResponse_instances = new List<DescribeInstanceAttributeResponse.DescribeInstanceAttribute_DBInstanceAttribute>();
			for (int i = 0; i < _ctx.Length("DescribeInstanceAttribute.Instances.Length"); i++) {
				DescribeInstanceAttributeResponse.DescribeInstanceAttribute_DBInstanceAttribute dBInstanceAttribute = new DescribeInstanceAttributeResponse.DescribeInstanceAttribute_DBInstanceAttribute();
				dBInstanceAttribute.InstanceId = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].InstanceId");
				dBInstanceAttribute.InstanceName = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].InstanceName");
				dBInstanceAttribute.ConnectionDomain = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].ConnectionDomain");
				dBInstanceAttribute.Port = _ctx.LongValue("DescribeInstanceAttribute.Instances["+ i +"].Port");
				dBInstanceAttribute.InstanceStatus = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].InstanceStatus");
				dBInstanceAttribute.RegionId = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].RegionId");
				dBInstanceAttribute.Capacity = _ctx.LongValue("DescribeInstanceAttribute.Instances["+ i +"].Capacity");
				dBInstanceAttribute.InstanceClass = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].InstanceClass");
				dBInstanceAttribute.QPS = _ctx.LongValue("DescribeInstanceAttribute.Instances["+ i +"].QPS");
				dBInstanceAttribute.Bandwidth = _ctx.LongValue("DescribeInstanceAttribute.Instances["+ i +"].Bandwidth");
				dBInstanceAttribute.Connections = _ctx.LongValue("DescribeInstanceAttribute.Instances["+ i +"].Connections");
				dBInstanceAttribute.ZoneId = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].ZoneId");
				dBInstanceAttribute.Config = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].Config");
				dBInstanceAttribute.ChargeType = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].ChargeType");
				dBInstanceAttribute.NodeType = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].NodeType");
				dBInstanceAttribute.NetworkType = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].NetworkType");
				dBInstanceAttribute.VpcId = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].VpcId");
				dBInstanceAttribute.VSwitchId = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].VSwitchId");
				dBInstanceAttribute.PrivateIp = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].PrivateIp");
				dBInstanceAttribute.CreateTime = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].CreateTime");
				dBInstanceAttribute.EndTime = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].EndTime");
				dBInstanceAttribute.HasRenewChangeOrder = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].HasRenewChangeOrder");
				dBInstanceAttribute.IsRds = _ctx.BooleanValue("DescribeInstanceAttribute.Instances["+ i +"].IsRds");
				dBInstanceAttribute.Engine = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].Engine");
				dBInstanceAttribute.EngineVersion = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].EngineVersion");
				dBInstanceAttribute.MaintainStartTime = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].MaintainStartTime");
				dBInstanceAttribute.MaintainEndTime = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].MaintainEndTime");
				dBInstanceAttribute.AvailabilityValue = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].AvailabilityValue");
				dBInstanceAttribute.SecurityIPList = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].SecurityIPList");
				dBInstanceAttribute.InstanceType = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].InstanceType");
				dBInstanceAttribute.ArchitectureType = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].ArchitectureType");
				dBInstanceAttribute.PackageType = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].PackageType");
				dBInstanceAttribute.ReplicaId = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].ReplicaId");
				dBInstanceAttribute.VpcAuthMode = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].VpcAuthMode");
				dBInstanceAttribute.AuditLogRetention = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].AuditLogRetention");
				dBInstanceAttribute.ReplicationMode = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].ReplicationMode");
				dBInstanceAttribute.VpcCloudInstanceId = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].VpcCloudInstanceId");
				dBInstanceAttribute.InstanceReleaseProtection = _ctx.BooleanValue("DescribeInstanceAttribute.Instances["+ i +"].InstanceReleaseProtection");
				dBInstanceAttribute.ResourceGroupId = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].ResourceGroupId");
				dBInstanceAttribute.ShardCount = _ctx.IntegerValue("DescribeInstanceAttribute.Instances["+ i +"].ShardCount");
				dBInstanceAttribute.Storage = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].Storage");
				dBInstanceAttribute.StorageType = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].StorageType");
				dBInstanceAttribute.GlobalInstanceId = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].GlobalInstanceId");
				dBInstanceAttribute.SecondaryZoneId = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].SecondaryZoneId");
				dBInstanceAttribute.ZoneType = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].ZoneType");

				List<DescribeInstanceAttributeResponse.DescribeInstanceAttribute_DBInstanceAttribute.DescribeInstanceAttribute_Tag> dBInstanceAttribute_tags = new List<DescribeInstanceAttributeResponse.DescribeInstanceAttribute_DBInstanceAttribute.DescribeInstanceAttribute_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeInstanceAttribute.Instances["+ i +"].Tags.Length"); j++) {
					DescribeInstanceAttributeResponse.DescribeInstanceAttribute_DBInstanceAttribute.DescribeInstanceAttribute_Tag tag = new DescribeInstanceAttributeResponse.DescribeInstanceAttribute_DBInstanceAttribute.DescribeInstanceAttribute_Tag();
					tag.Key = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeInstanceAttribute.Instances["+ i +"].Tags["+ j +"].Value");

					dBInstanceAttribute_tags.Add(tag);
				}
				dBInstanceAttribute.Tags = dBInstanceAttribute_tags;

				describeInstanceAttributeResponse_instances.Add(dBInstanceAttribute);
			}
			describeInstanceAttributeResponse.Instances = describeInstanceAttributeResponse_instances;
        
			return describeInstanceAttributeResponse;
        }
    }
}
