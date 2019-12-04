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
        public static DescribeDBInstancesForCloneResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBInstancesForCloneResponse describeDBInstancesForCloneResponse = new DescribeDBInstancesForCloneResponse();

			describeDBInstancesForCloneResponse.HttpResponse = context.HttpResponse;
			describeDBInstancesForCloneResponse.RequestId = context.StringValue("DescribeDBInstancesForClone.RequestId");
			describeDBInstancesForCloneResponse.PageNumber = context.IntegerValue("DescribeDBInstancesForClone.PageNumber");
			describeDBInstancesForCloneResponse.TotalRecordCount = context.IntegerValue("DescribeDBInstancesForClone.TotalRecordCount");
			describeDBInstancesForCloneResponse.PageRecordCount = context.IntegerValue("DescribeDBInstancesForClone.PageRecordCount");

			List<DescribeDBInstancesForCloneResponse.DescribeDBInstancesForClone_DBInstance> describeDBInstancesForCloneResponse_items = new List<DescribeDBInstancesForCloneResponse.DescribeDBInstancesForClone_DBInstance>();
			for (int i = 0; i < context.Length("DescribeDBInstancesForClone.Items.Length"); i++) {
				DescribeDBInstancesForCloneResponse.DescribeDBInstancesForClone_DBInstance dBInstance = new DescribeDBInstancesForCloneResponse.DescribeDBInstancesForClone_DBInstance();
				dBInstance.InsId = context.IntegerValue("DescribeDBInstancesForClone.Items["+ i +"].InsId");
				dBInstance.DBInstanceId = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].DBInstanceId");
				dBInstance.DBInstanceDescription = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].DBInstanceDescription");
				dBInstance.PayType = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].PayType");
				dBInstance.DBInstanceType = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].DBInstanceType");
				dBInstance.RegionId = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].RegionId");
				dBInstance.ExpireTime = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].ExpireTime");
				dBInstance.DestroyTime = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].DestroyTime");
				dBInstance.DBInstanceStatus = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].DBInstanceStatus");
				dBInstance.Engine = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].Engine");
				dBInstance.DBInstanceNetType = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].DBInstanceNetType");
				dBInstance.ConnectionMode = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].ConnectionMode");
				dBInstance.LockMode = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].LockMode");
				dBInstance.Category = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].Category");
				dBInstance.DBInstanceStorageType = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].DBInstanceStorageType");
				dBInstance.DBInstanceClass = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].DBInstanceClass");
				dBInstance.InstanceNetworkType = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].InstanceNetworkType");
				dBInstance.VpcCloudInstanceId = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].VpcCloudInstanceId");
				dBInstance.LockReason = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].LockReason");
				dBInstance.ZoneId = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].ZoneId");
				dBInstance.MutriORsignle = context.BooleanValue("DescribeDBInstancesForClone.Items["+ i +"].MutriORsignle");
				dBInstance.CreateTime = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].CreateTime");
				dBInstance.EngineVersion = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].EngineVersion");
				dBInstance.GuardDBInstanceId = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].GuardDBInstanceId");
				dBInstance.TempDBInstanceId = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].TempDBInstanceId");
				dBInstance.MasterInstanceId = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].MasterInstanceId");
				dBInstance.VpcId = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].VpcId");
				dBInstance.VSwitchId = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].VSwitchId");
				dBInstance.ReplicateId = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].ReplicateId");
				dBInstance.ResourceGroupId = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].ResourceGroupId");

				List<DescribeDBInstancesForCloneResponse.DescribeDBInstancesForClone_DBInstance.DescribeDBInstancesForClone_ReadOnlyDBInstanceId> dBInstance_readOnlyDBInstanceIds = new List<DescribeDBInstancesForCloneResponse.DescribeDBInstancesForClone_DBInstance.DescribeDBInstancesForClone_ReadOnlyDBInstanceId>();
				for (int j = 0; j < context.Length("DescribeDBInstancesForClone.Items["+ i +"].ReadOnlyDBInstanceIds.Length"); j++) {
					DescribeDBInstancesForCloneResponse.DescribeDBInstancesForClone_DBInstance.DescribeDBInstancesForClone_ReadOnlyDBInstanceId readOnlyDBInstanceId = new DescribeDBInstancesForCloneResponse.DescribeDBInstancesForClone_DBInstance.DescribeDBInstancesForClone_ReadOnlyDBInstanceId();
					readOnlyDBInstanceId.DBInstanceId = context.StringValue("DescribeDBInstancesForClone.Items["+ i +"].ReadOnlyDBInstanceIds["+ j +"].DBInstanceId");

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
