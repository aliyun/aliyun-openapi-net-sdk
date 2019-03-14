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
    public class DescribeDBInstancesResponseUnmarshaller
    {
        public static DescribeDBInstancesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBInstancesResponse describeDBInstancesResponse = new DescribeDBInstancesResponse();

			describeDBInstancesResponse.HttpResponse = context.HttpResponse;
			describeDBInstancesResponse.RequestId = context.StringValue("DescribeDBInstances.RequestId");
			describeDBInstancesResponse.PageNumber = context.IntegerValue("DescribeDBInstances.PageNumber");
			describeDBInstancesResponse.TotalRecordCount = context.IntegerValue("DescribeDBInstances.TotalRecordCount");
			describeDBInstancesResponse.PageRecordCount = context.IntegerValue("DescribeDBInstances.PageRecordCount");

			List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance> describeDBInstancesResponse_items = new List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance>();
			for (int i = 0; i < context.Length("DescribeDBInstances.Items.Length"); i++) {
				DescribeDBInstancesResponse.DescribeDBInstances_DBInstance dBInstance = new DescribeDBInstancesResponse.DescribeDBInstances_DBInstance();
				dBInstance.DBInstanceId = context.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceId");
				dBInstance.DBInstanceDescription = context.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceDescription");
				dBInstance.PayType = context.StringValue("DescribeDBInstances.Items["+ i +"].PayType");
				dBInstance.InstanceNetworkType = context.StringValue("DescribeDBInstances.Items["+ i +"].InstanceNetworkType");
				dBInstance.ConnectionMode = context.StringValue("DescribeDBInstances.Items["+ i +"].ConnectionMode");
				dBInstance.RegionId = context.StringValue("DescribeDBInstances.Items["+ i +"].RegionId");
				dBInstance.ZoneId = context.StringValue("DescribeDBInstances.Items["+ i +"].ZoneId");
				dBInstance.ExpireTime = context.StringValue("DescribeDBInstances.Items["+ i +"].ExpireTime");
				dBInstance.DBInstanceStatus = context.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceStatus");
				dBInstance.Engine = context.StringValue("DescribeDBInstances.Items["+ i +"].Engine");
				dBInstance.EngineVersion = context.StringValue("DescribeDBInstances.Items["+ i +"].EngineVersion");
				dBInstance.DBInstanceNetType = context.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceNetType");
				dBInstance.LockMode = context.StringValue("DescribeDBInstances.Items["+ i +"].LockMode");
				dBInstance.LockReason = context.StringValue("DescribeDBInstances.Items["+ i +"].LockReason");
				dBInstance.CreateTime = context.StringValue("DescribeDBInstances.Items["+ i +"].CreateTime");
				dBInstance.VpcId = context.StringValue("DescribeDBInstances.Items["+ i +"].VpcId");
				dBInstance.VSwitchId = context.StringValue("DescribeDBInstances.Items["+ i +"].VSwitchId");

				List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_Tag> dBInstance_tags = new List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_Tag>();
				for (int j = 0; j < context.Length("DescribeDBInstances.Items["+ i +"].Tags.Length"); j++) {
					DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_Tag tag = new DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_Tag();
					tag.Key = context.StringValue("DescribeDBInstances.Items["+ i +"].Tags["+ j +"].Key");
					tag._Value = context.StringValue("DescribeDBInstances.Items["+ i +"].Tags["+ j +"].Value");

					dBInstance_tags.Add(tag);
				}
				dBInstance.Tags = dBInstance_tags;

				describeDBInstancesResponse_items.Add(dBInstance);
			}
			describeDBInstancesResponse.Items = describeDBInstancesResponse_items;
        
			return describeDBInstancesResponse;
        }
    }
}
