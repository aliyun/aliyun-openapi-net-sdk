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
    public class DescribeDBInstancesForCloneResponseUnmarshaller
    {
        public static DescribeDBInstancesForCloneResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstancesForCloneResponse describeDBInstancesForCloneResponse = new DescribeDBInstancesForCloneResponse();

			describeDBInstancesForCloneResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstancesForCloneResponse.RequestId = _ctx.StringValue("DescribeDBInstancesForClone.RequestId");
			describeDBInstancesForCloneResponse.PageNumber = _ctx.IntegerValue("DescribeDBInstancesForClone.PageNumber");
			describeDBInstancesForCloneResponse.TotalRecordCount = _ctx.IntegerValue("DescribeDBInstancesForClone.TotalRecordCount");
			describeDBInstancesForCloneResponse.PageRecordCount = _ctx.IntegerValue("DescribeDBInstancesForClone.PageRecordCount");

			List<DescribeDBInstancesForCloneResponse.DescribeDBInstancesForClone_DBInstance> describeDBInstancesForCloneResponse_items = new List<DescribeDBInstancesForCloneResponse.DescribeDBInstancesForClone_DBInstance>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstancesForClone.Items.Length"); i++) {
				DescribeDBInstancesForCloneResponse.DescribeDBInstancesForClone_DBInstance dBInstance = new DescribeDBInstancesForCloneResponse.DescribeDBInstancesForClone_DBInstance();
				dBInstance.InsId = _ctx.IntegerValue("DescribeDBInstancesForClone.Items["+ i +"].InsId");
				dBInstance.DBInstanceId = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].DBInstanceId");
				dBInstance.DBInstanceDescription = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].DBInstanceDescription");
				dBInstance.PayType = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].PayType");
				dBInstance.DBInstanceType = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].DBInstanceType");
				dBInstance.RegionId = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].RegionId");
				dBInstance.ExpireTime = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].ExpireTime");
				dBInstance.DestroyTime = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].DestroyTime");
				dBInstance.DBInstanceStatus = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].DBInstanceStatus");
				dBInstance.Engine = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].Engine");
				dBInstance.DBInstanceNetType = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].DBInstanceNetType");
				dBInstance.ConnectionMode = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].ConnectionMode");
				dBInstance.LockMode = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].LockMode");
				dBInstance.Category = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].Category");
				dBInstance.DBInstanceStorageType = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].DBInstanceStorageType");
				dBInstance.DBInstanceClass = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].DBInstanceClass");
				dBInstance.InstanceNetworkType = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].InstanceNetworkType");
				dBInstance.VpcCloudInstanceId = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].VpcCloudInstanceId");
				dBInstance.LockReason = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].LockReason");
				dBInstance.ZoneId = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].ZoneId");
				dBInstance.MutriORsignle = _ctx.BooleanValue("DescribeDBInstancesForClone.Items["+ i +"].MutriORsignle");
				dBInstance.CreateTime = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].CreateTime");
				dBInstance.EngineVersion = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].EngineVersion");
				dBInstance.GuardDBInstanceId = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].GuardDBInstanceId");
				dBInstance.TempDBInstanceId = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].TempDBInstanceId");
				dBInstance.MasterInstanceId = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].MasterInstanceId");
				dBInstance.VpcId = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].VpcId");
				dBInstance.VSwitchId = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].VSwitchId");
				dBInstance.ReplicateId = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].ReplicateId");
				dBInstance.ResourceGroupId = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].ResourceGroupId");

				List<DescribeDBInstancesForCloneResponse.DescribeDBInstancesForClone_DBInstance.DescribeDBInstancesForClone_ReadOnlyDBInstanceId> dBInstance_readOnlyDBInstanceIds = new List<DescribeDBInstancesForCloneResponse.DescribeDBInstancesForClone_DBInstance.DescribeDBInstancesForClone_ReadOnlyDBInstanceId>();
				for (int j = 0; j < _ctx.Length("DescribeDBInstancesForClone.Items["+ i +"].ReadOnlyDBInstanceIds.Length"); j++) {
					DescribeDBInstancesForCloneResponse.DescribeDBInstancesForClone_DBInstance.DescribeDBInstancesForClone_ReadOnlyDBInstanceId readOnlyDBInstanceId = new DescribeDBInstancesForCloneResponse.DescribeDBInstancesForClone_DBInstance.DescribeDBInstancesForClone_ReadOnlyDBInstanceId();
					readOnlyDBInstanceId.DBInstanceId = _ctx.StringValue("DescribeDBInstancesForClone.Items["+ i +"].ReadOnlyDBInstanceIds["+ j +"].DBInstanceId");

					dBInstance_readOnlyDBInstanceIds.Add(readOnlyDBInstanceId);
				}
				dBInstance.ReadOnlyDBInstanceIds = dBInstance_readOnlyDBInstanceIds;

				describeDBInstancesForCloneResponse_items.Add(dBInstance);
			}
			describeDBInstancesForCloneResponse.Items = describeDBInstancesForCloneResponse_items;
        
			return describeDBInstancesForCloneResponse;
        }
    }
}
