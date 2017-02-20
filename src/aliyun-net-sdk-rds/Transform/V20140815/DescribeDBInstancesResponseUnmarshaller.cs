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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDBInstancesResponseUnmarshaller
    {
        public static DescribeDBInstancesResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDBInstancesResponse describeDBInstancesResponse = new DescribeDBInstancesResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDBInstances.RequestId"),
                PageNumber = context.IntegerValue("DescribeDBInstances.PageNumber"),
                TotalRecordCount = context.IntegerValue("DescribeDBInstances.TotalRecordCount"),
                PageRecordCount = context.IntegerValue("DescribeDBInstances.PageRecordCount")
            };
            List<DescribeDBInstancesResponse.DBInstance> items = new List<DescribeDBInstancesResponse.DBInstance>();
			for (int i = 0; i < context.Length("DescribeDBInstances.Items.Length"); i++) {
                DescribeDBInstancesResponse.DBInstance dBInstance = new DescribeDBInstancesResponse.DBInstance()
                {
                    InsId = context.IntegerValue($"DescribeDBInstances.Items[{i}].InsId"),
                    DBInstanceId = context.StringValue($"DescribeDBInstances.Items[{i}].DBInstanceId"),
                    DBInstanceDescription = context.StringValue($"DescribeDBInstances.Items[{i}].DBInstanceDescription"),
                    PayType = context.StringValue($"DescribeDBInstances.Items[{i}].PayType"),
                    DBInstanceType = context.EnumValue<DescribeDBInstancesResponse.DBInstance.DBInstanceTypeEnum>($"DescribeDBInstances.Items[{i}].DBInstanceType"),
                    RegionId = context.StringValue($"DescribeDBInstances.Items[{i}].RegionId"),
                    ExpireTime = context.StringValue($"DescribeDBInstances.Items[{i}].ExpireTime"),
                    DBInstanceStatus = context.EnumValue<DescribeDBInstancesResponse.DBInstance.DBInstanceStatusEnum>($"DescribeDBInstances.Items[{i}].DBInstanceStatus"),
                    Engine = context.StringValue($"DescribeDBInstances.Items[{i}].Engine"),
                    DBInstanceNetType = context.EnumValue<DescribeDBInstancesResponse.DBInstance.DBInstanceNetTypeEnum>($"DescribeDBInstances.Items[{i}].DBInstanceNetType"),
                    ConnectionMode = context.EnumValue<DescribeDBInstancesResponse.DBInstance.ConnectionModeEnum>($"DescribeDBInstances.Items[{i}].ConnectionMode"),
                    LockMode = context.EnumValue<DescribeDBInstancesResponse.DBInstance.LockModeEnum>($"DescribeDBInstances.Items[{i}].LockMode"),
                    InstanceNetworkType = context.StringValue($"DescribeDBInstances.Items[{i}].InstanceNetworkType"),
                    LockReason = context.StringValue($"DescribeDBInstances.Items[{i}].LockReason"),
                    ZoneId = context.StringValue($"DescribeDBInstances.Items[{i}].ZoneId"),
                    MutriORsignle = context.BooleanValue($"DescribeDBInstances.Items[{i}].MutriORsignle"),
                    CreateTime = context.StringValue($"DescribeDBInstances.Items[{i}].CreateTime"),
                    EngineVersion = context.StringValue($"DescribeDBInstances.Items[{i}].EngineVersion"),
                    GuardDBInstanceId = context.StringValue($"DescribeDBInstances.Items[{i}].GuardDBInstanceId"),
                    TempDBInstanceId = context.StringValue($"DescribeDBInstances.Items[{i}].TempDBInstanceId"),
                    MasterInstanceId = context.StringValue($"DescribeDBInstances.Items[{i}].MasterInstanceId"),
                    VpcId = context.StringValue($"DescribeDBInstances.Items[{i}].VpcId")
                };
                List<DescribeDBInstancesResponse.DBInstance.ReadOnlyDBInstanceId> readOnlyDBInstanceIds = new List<DescribeDBInstancesResponse.DBInstance.ReadOnlyDBInstanceId>();
				for (int j = 0; j < context.Length($"DescribeDBInstances.Items[{i}].ReadOnlyDBInstanceIds.Length"); j++) {
                    DescribeDBInstancesResponse.DBInstance.ReadOnlyDBInstanceId readOnlyDBInstanceId = new DescribeDBInstancesResponse.DBInstance.ReadOnlyDBInstanceId()
                    {
                        DBInstanceId = context.StringValue($"DescribeDBInstances.Items[{i}].ReadOnlyDBInstanceIds[{j}].DBInstanceId")
                    };
                    readOnlyDBInstanceIds.Add(readOnlyDBInstanceId);
				}
				dBInstance.ReadOnlyDBInstanceIds = readOnlyDBInstanceIds;

				items.Add(dBInstance);
			}
			describeDBInstancesResponse.Items = items;
        
			return describeDBInstancesResponse;
        }
    }
}