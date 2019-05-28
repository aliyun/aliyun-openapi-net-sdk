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
using Aliyun.Acs.Rds.Model.V20140815;

namespace Aliyun.Acs.Rds.Transform.V20140815
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
				dBInstance.InsId = context.IntegerValue("DescribeDBInstances.Items["+ i +"].InsId");
				dBInstance.DBInstanceId = context.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceId");
				dBInstance.DBInstanceDescription = context.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceDescription");
				dBInstance.PayType = context.StringValue("DescribeDBInstances.Items["+ i +"].PayType");
				dBInstance.DBInstanceType = context.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceType");
				dBInstance.RegionId = context.StringValue("DescribeDBInstances.Items["+ i +"].RegionId");
				dBInstance.ExpireTime = context.StringValue("DescribeDBInstances.Items["+ i +"].ExpireTime");
				dBInstance.DestroyTime = context.StringValue("DescribeDBInstances.Items["+ i +"].DestroyTime");
				dBInstance.DBInstanceStatus = context.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceStatus");
				dBInstance.Engine = context.StringValue("DescribeDBInstances.Items["+ i +"].Engine");
				dBInstance.DBInstanceNetType = context.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceNetType");
				dBInstance.ConnectionMode = context.StringValue("DescribeDBInstances.Items["+ i +"].ConnectionMode");
				dBInstance.LockMode = context.StringValue("DescribeDBInstances.Items["+ i +"].LockMode");
				dBInstance.Category = context.StringValue("DescribeDBInstances.Items["+ i +"].Category");
				dBInstance.DBInstanceStorageType = context.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceStorageType");
				dBInstance.DBInstanceClass = context.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceClass");
				dBInstance.InstanceNetworkType = context.StringValue("DescribeDBInstances.Items["+ i +"].InstanceNetworkType");
				dBInstance.VpcCloudInstanceId = context.StringValue("DescribeDBInstances.Items["+ i +"].VpcCloudInstanceId");
				dBInstance.LockReason = context.StringValue("DescribeDBInstances.Items["+ i +"].LockReason");
				dBInstance.ZoneId = context.StringValue("DescribeDBInstances.Items["+ i +"].ZoneId");
				dBInstance.MutriORsignle = context.BooleanValue("DescribeDBInstances.Items["+ i +"].MutriORsignle");
				dBInstance.CreateTime = context.StringValue("DescribeDBInstances.Items["+ i +"].CreateTime");
				dBInstance.EngineVersion = context.StringValue("DescribeDBInstances.Items["+ i +"].EngineVersion");
				dBInstance.GuardDBInstanceId = context.StringValue("DescribeDBInstances.Items["+ i +"].GuardDBInstanceId");
				dBInstance.TempDBInstanceId = context.StringValue("DescribeDBInstances.Items["+ i +"].TempDBInstanceId");
				dBInstance.MasterInstanceId = context.StringValue("DescribeDBInstances.Items["+ i +"].MasterInstanceId");
				dBInstance.VpcId = context.StringValue("DescribeDBInstances.Items["+ i +"].VpcId");
				dBInstance.VSwitchId = context.StringValue("DescribeDBInstances.Items["+ i +"].VSwitchId");
				dBInstance.ReplicateId = context.StringValue("DescribeDBInstances.Items["+ i +"].ReplicateId");
				dBInstance.ResourceGroupId = context.StringValue("DescribeDBInstances.Items["+ i +"].ResourceGroupId");

				List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_ReadOnlyDBInstanceId> dBInstance_readOnlyDBInstanceIds = new List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_ReadOnlyDBInstanceId>();
				for (int j = 0; j < context.Length("DescribeDBInstances.Items["+ i +"].ReadOnlyDBInstanceIds.Length"); j++) {
					DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_ReadOnlyDBInstanceId readOnlyDBInstanceId = new DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_ReadOnlyDBInstanceId();
					readOnlyDBInstanceId.DBInstanceId = context.StringValue("DescribeDBInstances.Items["+ i +"].ReadOnlyDBInstanceIds["+ j +"].DBInstanceId");

					dBInstance_readOnlyDBInstanceIds.Add(readOnlyDBInstanceId);
				}
				dBInstance.ReadOnlyDBInstanceIds = dBInstance_readOnlyDBInstanceIds;

				describeDBInstancesResponse_items.Add(dBInstance);
			}
			describeDBInstancesResponse.Items = describeDBInstancesResponse_items;
        
			return describeDBInstancesResponse;
        }
    }
}
