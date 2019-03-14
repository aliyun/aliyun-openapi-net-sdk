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
        public static DescribeDBInstanceAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBInstanceAttributeResponse describeDBInstanceAttributeResponse = new DescribeDBInstanceAttributeResponse();

			describeDBInstanceAttributeResponse.HttpResponse = context.HttpResponse;
			describeDBInstanceAttributeResponse.RequestId = context.StringValue("DescribeDBInstanceAttribute.RequestId");

			List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute> describeDBInstanceAttributeResponse_items = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute>();
			for (int i = 0; i < context.Length("DescribeDBInstanceAttribute.Items.Length"); i++) {
				DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute dBInstanceAttribute = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute();
				dBInstanceAttribute.DBInstanceId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceId");
				dBInstanceAttribute.PayType = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].PayType");
				dBInstanceAttribute.DBInstanceClassType = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceClassType");
				dBInstanceAttribute.RegionId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].RegionId");
				dBInstanceAttribute.ConnectionString = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ConnectionString");
				dBInstanceAttribute.Port = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Port");
				dBInstanceAttribute.Engine = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Engine");
				dBInstanceAttribute.EngineVersion = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].EngineVersion");
				dBInstanceAttribute.DBInstanceClass = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceClass");
				dBInstanceAttribute.DBInstanceCpuCores = context.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceCpuCores");
				dBInstanceAttribute.DBInstanceMemory = context.LongValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceMemory");
				dBInstanceAttribute.DBInstanceStorage = context.LongValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceStorage");
				dBInstanceAttribute.DBInstanceDiskMBPS = context.LongValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceDiskMBPS");
				dBInstanceAttribute.HostType = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].HostType");
				dBInstanceAttribute.DBInstanceGroupCount = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceGroupCount");
				dBInstanceAttribute.DBInstanceNetType = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceNetType");
				dBInstanceAttribute.DBInstanceStatus = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceStatus");
				dBInstanceAttribute.DBInstanceDescription = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceDescription");
				dBInstanceAttribute.LockMode = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].LockMode");
				dBInstanceAttribute.LockReason = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].LockReason");
				dBInstanceAttribute.ReadDelayTime = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ReadDelayTime");
				dBInstanceAttribute.CreationTime = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].CreationTime");
				dBInstanceAttribute.ExpireTime = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ExpireTime");
				dBInstanceAttribute.MaintainStartTime = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].MaintainStartTime");
				dBInstanceAttribute.MaintainEndTime = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].MaintainEndTime");
				dBInstanceAttribute.AvailabilityValue = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].AvailabilityValue");
				dBInstanceAttribute.MaxConnections = context.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].MaxConnections");
				dBInstanceAttribute.SecurityIPList = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].SecurityIPList");
				dBInstanceAttribute.ZoneId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ZoneId");
				dBInstanceAttribute.InstanceNetworkType = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].InstanceNetworkType");
				dBInstanceAttribute.VpcId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].VpcId");
				dBInstanceAttribute.ConnectionMode = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ConnectionMode");

				List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_Tag> dBInstanceAttribute_tags = new List<DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_Tag>();
				for (int j = 0; j < context.Length("DescribeDBInstanceAttribute.Items["+ i +"].Tags.Length"); j++) {
					DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_Tag tag = new DescribeDBInstanceAttributeResponse.DescribeDBInstanceAttribute_DBInstanceAttribute.DescribeDBInstanceAttribute_Tag();
					tag.Key = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Tags["+ j +"].Key");
					tag._Value = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Tags["+ j +"].Value");

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
