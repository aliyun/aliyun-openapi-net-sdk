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
        public static DescribeDBInstancesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstancesResponse describeDBInstancesResponse = new DescribeDBInstancesResponse();

			describeDBInstancesResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstancesResponse.RequestId = _ctx.StringValue("DescribeDBInstances.RequestId");
			describeDBInstancesResponse.PageNumber = _ctx.IntegerValue("DescribeDBInstances.PageNumber");
			describeDBInstancesResponse.TotalRecordCount = _ctx.IntegerValue("DescribeDBInstances.TotalRecordCount");
			describeDBInstancesResponse.PageRecordCount = _ctx.IntegerValue("DescribeDBInstances.PageRecordCount");

			List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance> describeDBInstancesResponse_items = new List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstances.Items.Length"); i++) {
				DescribeDBInstancesResponse.DescribeDBInstances_DBInstance dBInstance = new DescribeDBInstancesResponse.DescribeDBInstances_DBInstance();
				dBInstance.InsId = _ctx.IntegerValue("DescribeDBInstances.Items["+ i +"].InsId");
				dBInstance.DBInstanceId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceId");
				dBInstance.DBInstanceDescription = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceDescription");
				dBInstance.PayType = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].PayType");
				dBInstance.DBInstanceType = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceType");
				dBInstance.RegionId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].RegionId");
				dBInstance.ExpireTime = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].ExpireTime");
				dBInstance.DestroyTime = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DestroyTime");
				dBInstance.DBInstanceStatus = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceStatus");
				dBInstance.Engine = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].Engine");
				dBInstance.DBInstanceNetType = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceNetType");
				dBInstance.ConnectionMode = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].ConnectionMode");
				dBInstance.LockMode = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].LockMode");
				dBInstance.Category = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].Category");
				dBInstance.DBInstanceStorageType = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceStorageType");
				dBInstance.DBInstanceClass = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DBInstanceClass");
				dBInstance.InstanceNetworkType = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].InstanceNetworkType");
				dBInstance.VpcCloudInstanceId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].VpcCloudInstanceId");
				dBInstance.LockReason = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].LockReason");
				dBInstance.ZoneId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].ZoneId");
				dBInstance.MutriORsignle = _ctx.BooleanValue("DescribeDBInstances.Items["+ i +"].MutriORsignle");
				dBInstance.CreateTime = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].CreateTime");
				dBInstance.EngineVersion = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].EngineVersion");
				dBInstance.GuardDBInstanceId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].GuardDBInstanceId");
				dBInstance.TempDBInstanceId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].TempDBInstanceId");
				dBInstance.MasterInstanceId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].MasterInstanceId");
				dBInstance.VpcId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].VpcId");
				dBInstance.VSwitchId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].VSwitchId");
				dBInstance.ReplicateId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].ReplicateId");
				dBInstance.ResourceGroupId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].ResourceGroupId");
				dBInstance.AutoUpgradeMinorVersion = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].AutoUpgradeMinorVersion");
				dBInstance.DedicatedHostGroupId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DedicatedHostGroupId");
				dBInstance.DedicatedHostIdForMaster = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DedicatedHostIdForMaster");
				dBInstance.DedicatedHostIdForSlave = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DedicatedHostIdForSlave");
				dBInstance.DedicatedHostIdForLog = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DedicatedHostIdForLog");
				dBInstance.DedicatedHostNameForMaster = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DedicatedHostNameForMaster");
				dBInstance.DedicatedHostNameForSlave = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DedicatedHostNameForSlave");
				dBInstance.DedicatedHostNameForLog = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DedicatedHostNameForLog");
				dBInstance.DedicatedHostZoneIdForMaster = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DedicatedHostZoneIdForMaster");
				dBInstance.DedicatedHostZoneIdForSlave = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DedicatedHostZoneIdForSlave");
				dBInstance.DedicatedHostZoneIdForLog = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DedicatedHostZoneIdForLog");
				dBInstance.VpcName = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].VpcName");
				dBInstance.DedicatedHostGroupName = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].DedicatedHostGroupName");
				dBInstance.ConnectionString = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].ConnectionString");

				List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_ReadOnlyDBInstanceId> dBInstance_readOnlyDBInstanceIds = new List<DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_ReadOnlyDBInstanceId>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstances.Items["+ i +"].ReadOnlyDBInstanceIds.Length"); j++) {
					DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_ReadOnlyDBInstanceId readOnlyDBInstanceId = new DescribeDBInstancesResponse.DescribeDBInstances_DBInstance.DescribeDBInstances_ReadOnlyDBInstanceId();
					readOnlyDBInstanceId.DBInstanceId = _ctx.StringValue("DescribeDBInstances.Items["+ i +"].ReadOnlyDBInstanceIds["+ j +"].DBInstanceId");

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
