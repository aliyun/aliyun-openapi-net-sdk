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
using Aliyun.Acs.gpdb.Model.V20160503;

namespace Aliyun.Acs.gpdb.Transform.V20160503
{
    public class DescribeDBInstanceAttributeResponseUnmarshaller
    {
        public static DescribeDBInstanceAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstanceAttributeResponse describeDBInstanceAttributeResponse = new DescribeDBInstanceAttributeResponse();

			describeDBInstanceAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstanceAttributeResponse.RequestId = _ctx.StringValue("DescribeDBInstanceAttribute.RequestId");

			List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute> describeDBInstanceAttributeResponse_items = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceAttribute.Items.Length"); i++) {
				DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute dBInstanceAttribute = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute();
				dBInstanceAttribute.VpcId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].VpcId");
				dBInstanceAttribute.CreationTime = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].CreationTime");
				dBInstanceAttribute.DBInstanceCpuCores = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceCpuCores");
				dBInstanceAttribute.SegmentCounts = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].SegmentCounts");
				dBInstanceAttribute.StoragePerNode = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].StoragePerNode");
				dBInstanceAttribute.DBInstanceMemory = _ctx.LongValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceMemory");
				dBInstanceAttribute.HostType = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].HostType");
				dBInstanceAttribute.PayType = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].PayType");
				dBInstanceAttribute.StorageType = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].StorageType");
				dBInstanceAttribute.AvailabilityValue = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].AvailabilityValue");
				dBInstanceAttribute.ReadDelayTime = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ReadDelayTime");
				dBInstanceAttribute.CpuCoresPerNode = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].CpuCoresPerNode");
				dBInstanceAttribute.Port = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Port");
				dBInstanceAttribute.ConnectionMode = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ConnectionMode");
				dBInstanceAttribute.LockMode = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].LockMode");
				dBInstanceAttribute.EngineVersion = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].EngineVersion");
				dBInstanceAttribute.StorageUnit = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].StorageUnit");
				dBInstanceAttribute.MemoryPerNode = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].MemoryPerNode");
				dBInstanceAttribute.ConnectionString = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ConnectionString");
				dBInstanceAttribute.InstanceNetworkType = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].InstanceNetworkType");
				dBInstanceAttribute.SecurityIPList = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].SecurityIPList");
				dBInstanceAttribute.MemoryUnit = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].MemoryUnit");
				dBInstanceAttribute.DBInstanceClassType = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceClassType");
				dBInstanceAttribute.DBInstanceDescription = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceDescription");
				dBInstanceAttribute.DBInstanceGroupCount = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceGroupCount");
				dBInstanceAttribute.ExpireTime = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ExpireTime");
				dBInstanceAttribute.DBInstanceNetType = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceNetType");
				dBInstanceAttribute.MaintainStartTime = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].MaintainStartTime");
				dBInstanceAttribute.MaintainEndTime = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].MaintainEndTime");
				dBInstanceAttribute.LockReason = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].LockReason");
				dBInstanceAttribute.DBInstanceStatus = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceStatus");
				dBInstanceAttribute.RegionId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].RegionId");
				dBInstanceAttribute.DBInstanceDiskMBPS = _ctx.LongValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceDiskMBPS");
				dBInstanceAttribute.DBInstanceStorage = _ctx.LongValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceStorage");
				dBInstanceAttribute.ZoneId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ZoneId");
				dBInstanceAttribute.MaxConnections = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].MaxConnections");
				dBInstanceAttribute.DBInstanceId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceId");
				dBInstanceAttribute.DBInstanceClass = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceClass");
				dBInstanceAttribute.Engine = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Engine");
				dBInstanceAttribute.DBInstanceCategory = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceCategory");
				dBInstanceAttribute.CpuCores = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].CpuCores");
				dBInstanceAttribute.MemorySize = _ctx.LongValue("DescribeDBInstanceAttribute.Items["+ i +"].MemorySize");
				dBInstanceAttribute.StorageSize = _ctx.LongValue("DescribeDBInstanceAttribute.Items["+ i +"].StorageSize");
				dBInstanceAttribute.SegNodeNum = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].SegNodeNum");
				dBInstanceAttribute.MasterNodeNum = _ctx.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].MasterNodeNum");
				dBInstanceAttribute.DBInstanceMode = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceMode");
				dBInstanceAttribute.MinorVersion = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].MinorVersion");
				dBInstanceAttribute.SupportRestore = _ctx.BooleanValue("DescribeDBInstanceAttribute.Items["+ i +"].SupportRestore");
				dBInstanceAttribute.VSwitchId = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].VSwitchId");
				dBInstanceAttribute.EncryptionKey = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].EncryptionKey");
				dBInstanceAttribute.EncryptionType = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].EncryptionType");

				List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_Tag> dBInstanceAttribute_tags = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstanceAttribute.Items["+ i +"].Tags.Length"); j++) {
					DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_Tag tag = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_Tag();
					tag.Key = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Tags["+ j +"].Value");

					dBInstanceAttribute_tags.Add(tag);
				}
				dBInstanceAttribute.Tags = dBInstanceAttribute_tags;

				describeDBInstanceAttributeResponse_items.Add(dBInstanceAttribute);
			}
			describeDBInstanceAttributeResponse.Items = describeDBInstanceAttributeResponse_items;
        
			return describeDBInstanceAttributeResponse;
        }
    }
}
