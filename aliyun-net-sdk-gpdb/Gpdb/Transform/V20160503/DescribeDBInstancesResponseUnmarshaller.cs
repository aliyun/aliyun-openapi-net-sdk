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
        public static DescribeDBInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstancesResponse describeDBInstancesResponse = new DescribeDBInstancesResponse();

			describeDBInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstancesResponse.TotalRecordCount = _ctx.IntegerValue("DescribeDBInstances.TotalRecordCount");
			describeDBInstancesResponse.PageRecordCount = _ctx.IntegerValue("DescribeDBInstances.PageRecordCount");
			describeDBInstancesResponse.RequestId = _ctx.StringValue("DescribeDBInstances.RequestId");
			describeDBInstancesResponse.PageNumber = _ctx.IntegerValue("DescribeDBInstances.PageNumber");

			List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance> describeDBInstancesResponse_items = new List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstances.Items.Length"); i++) {
				DescribeDBInstancesResponse.DescribeDBInstances_DBInstance dBInstance = new DescribeDBInstancesResponse.DescribeDBInstances_DBInstance();
				dBInstance.VpcId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].VpcId");
				dBInstance.ExpireTime = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].ExpireTime");
				dBInstance.DBInstanceNetType = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceNetType");
				dBInstance.InstanceDeployType = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].InstanceDeployType");
				dBInstance.StorageType = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].StorageType");
				dBInstance.CreateTime = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].CreateTime");
				dBInstance.PayType = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].PayType");
				dBInstance.LockReason = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].LockReason");
				dBInstance.DBInstanceStatus = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceStatus");
				dBInstance.ConnectionMode = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].ConnectionMode");
				dBInstance.LockMode = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].LockMode");
				dBInstance.EngineVersion = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].EngineVersion");
				dBInstance.RegionId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].RegionId");
				dBInstance.VSwitchId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].VSwitchId");
				dBInstance.InstanceNetworkType = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].InstanceNetworkType");
				dBInstance.ZoneId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].ZoneId");
				dBInstance.DBInstanceId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceId");
				dBInstance.Engine = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].Engine");
				dBInstance.DBInstanceDescription = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceDescription");
				dBInstance.SegNodeNum = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].SegNodeNum");
				dBInstance.StorageSize = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].StorageSize");
				dBInstance.MasterNodeNum = _ctx.IntegerValue("DescribeDBInstances.Items["+ i +"].MasterNodeNum");
				dBInstance.DBInstanceCategory = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceCategory");
				dBInstance.DBInstanceMode = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceMode");

				List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_Tag> dBInstance_tags = new List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstances.Items["+ i +"].Tags.Length"); j++) {
					DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_Tag tag = new DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_Tag();
					tag.Key = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].Tags["+ j +"].Value");

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
