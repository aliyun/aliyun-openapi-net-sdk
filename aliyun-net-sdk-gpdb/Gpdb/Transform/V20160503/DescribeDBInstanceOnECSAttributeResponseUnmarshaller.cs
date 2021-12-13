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
    public class DescribeDBInstanceOnECSAttributeResponseUnmarshaller
    {
        public static DescribeDBInstanceOnECSAttributeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstanceOnECSAttributeResponse describeDBInstanceOnECSAttributeResponse = new DescribeDBInstanceOnECSAttributeResponse();

			describeDBInstanceOnECSAttributeResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstanceOnECSAttributeResponse.RequestId = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.RequestId");

			List<DescribeDBInstanceOnECSAttributeResponse.DescribeDBInstanceOnECSAttribute_DBInstanceAttribute> describeDBInstanceOnECSAttributeResponse_items = new List<DescribeDBInstanceOnECSAttributeResponse.DescribeDBInstanceOnECSAttribute_DBInstanceAttribute>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstanceOnECSAttribute.Items.Length"); i++) {
				DescribeDBInstanceOnECSAttributeResponse.DescribeDBInstanceOnECSAttribute_DBInstanceAttribute dBInstanceAttribute = new DescribeDBInstanceOnECSAttributeResponse.DescribeDBInstanceOnECSAttribute_DBInstanceAttribute();
				dBInstanceAttribute.CreationTime = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].CreationTime");
				dBInstanceAttribute.VpcId = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].VpcId");
				dBInstanceAttribute.EncryptionType = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].EncryptionType");
				dBInstanceAttribute.InstanceDeployType = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].InstanceDeployType");
				dBInstanceAttribute.PayType = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].PayType");
				dBInstanceAttribute.StorageType = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].StorageType");
				dBInstanceAttribute.ConnectionMode = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].ConnectionMode");
				dBInstanceAttribute.Port = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].Port");
				dBInstanceAttribute.LockMode = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].LockMode");
				dBInstanceAttribute.EngineVersion = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].EngineVersion");
				dBInstanceAttribute.MemorySize = _ctx.IntegerValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].MemorySize");
				dBInstanceAttribute.SegNodeNum = _ctx.IntegerValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].SegNodeNum");
				dBInstanceAttribute.ConnectionString = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].ConnectionString");
				dBInstanceAttribute.InstanceNetworkType = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].InstanceNetworkType");
				dBInstanceAttribute.EncryptionKey = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].EncryptionKey");
				dBInstanceAttribute.DBInstanceDescription = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].DBInstanceDescription");
				dBInstanceAttribute.CpuCores = _ctx.IntegerValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].CpuCores");
				dBInstanceAttribute.ExpireTime = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].ExpireTime");
				dBInstanceAttribute.DBInstanceStatus = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].DBInstanceStatus");
				dBInstanceAttribute.StorageSize = _ctx.IntegerValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].StorageSize");
				dBInstanceAttribute.RegionId = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].RegionId");
				dBInstanceAttribute.VSwitchId = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].VSwitchId");
				dBInstanceAttribute.ZoneId = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].ZoneId");
				dBInstanceAttribute.DBInstanceId = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].DBInstanceId");
				dBInstanceAttribute.Engine = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].Engine");
				dBInstanceAttribute.DBInstanceClass = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].DBInstanceClass");
				dBInstanceAttribute.SupportRestore = _ctx.BooleanValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].SupportRestore");
				dBInstanceAttribute.MinorVersion = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].MinorVersion");
				dBInstanceAttribute.MasterNodeNum = _ctx.IntegerValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].MasterNodeNum");
				dBInstanceAttribute.DBInstanceCategory = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].DBInstanceCategory");

				List<DescribeDBInstanceOnECSAttributeResponse.DescribeDBInstanceOnECSAttribute_DBInstanceAttribute.DescribeDBInstanceOnECSAttribute_Tag> dBInstanceAttribute_tags = new List<DescribeDBInstanceOnECSAttributeResponse.DescribeDBInstanceOnECSAttribute_DBInstanceAttribute.DescribeDBInstanceOnECSAttribute_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstanceOnECSAttribute.Items["+ i +"].Tags.Length"); j++) {
					DescribeDBInstanceOnECSAttributeResponse.DescribeDBInstanceOnECSAttribute_DBInstanceAttribute.DescribeDBInstanceOnECSAttribute_Tag tag = new DescribeDBInstanceOnECSAttributeResponse.DescribeDBInstanceOnECSAttribute_DBInstanceAttribute.DescribeDBInstanceOnECSAttribute_Tag();
					tag.Key = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeDBInstanceOnECSAttribute.Items["+ i +"].Tags["+ j +"].Value");

					dBInstanceAttribute_tags.Add(tag);
				}
				dBInstanceAttribute.Tags = dBInstanceAttribute_tags;

				describeDBInstanceOnECSAttributeResponse_items.Add(dBInstanceAttribute);
			}
			describeDBInstanceOnECSAttributeResponse.Items = describeDBInstanceOnECSAttributeResponse_items;
        
			return describeDBInstanceOnECSAttributeResponse;
        }
    }
}
