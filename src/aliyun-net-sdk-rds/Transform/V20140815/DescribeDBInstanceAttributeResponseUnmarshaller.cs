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
    public class DescribeDBInstanceAttributeResponseUnmarshaller
    {
        public static DescribeDBInstanceAttributeResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDBInstanceAttributeResponse describeDBInstanceAttributeResponse = new DescribeDBInstanceAttributeResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDBInstanceAttribute.RequestId")
            };
            List<DescribeDBInstanceAttributeResponse.DBInstanceAttribute> items = new List<DescribeDBInstanceAttributeResponse.DBInstanceAttribute>();
			for (int i = 0; i < context.Length("DescribeDBInstanceAttribute.Items.Length"); i++) {
                DescribeDBInstanceAttributeResponse.DBInstanceAttribute dBInstanceAttribute = new DescribeDBInstanceAttributeResponse.DBInstanceAttribute()
                {
                    InsId = context.IntegerValue($"DescribeDBInstanceAttribute.Items[{i}].InsId"),
                    DBInstanceId = context.StringValue($"DescribeDBInstanceAttribute.Items[{i}].DBInstanceId"),
                    PayType = context.StringValue($"DescribeDBInstanceAttribute.Items[{i}].PayType"),
                    DBInstanceClassType = context.StringValue($"DescribeDBInstanceAttribute.Items[{i}].DBInstanceClassType"),
                    DBInstanceType = context.EnumValue<DescribeDBInstanceAttributeResponse.DBInstanceAttribute.DBInstanceTypeEnum>($"DescribeDBInstanceAttribute.Items[{i}].DBInstanceType"),
                    RegionId = context.StringValue($"DescribeDBInstanceAttribute.Items[{i}].RegionId"),
                    ConnectionString = context.StringValue($"DescribeDBInstanceAttribute.Items[{i}].ConnectionString"),
                    Port = context.StringValue($"DescribeDBInstanceAttribute.Items[{i}].Port"),
                    Engine = context.StringValue($"DescribeDBInstanceAttribute.Items[{i}].Engine"),
                    EngineVersion = context.StringValue($"DescribeDBInstanceAttribute.Items[{i}].EngineVersion"),
                    DBInstanceClass = context.StringValue($"DescribeDBInstanceAttribute.Items[{i}].DBInstanceClass"),
                    DBInstanceMemory = context.LongValue($"DescribeDBInstanceAttribute.Items[{i}].DBInstanceMemory"),
                    DBInstanceStorage = context.IntegerValue($"DescribeDBInstanceAttribute.Items[{i}].DBInstanceStorage"),
                    DBInstanceNetType = context.EnumValue<DescribeDBInstanceAttributeResponse.DBInstanceAttribute.DBInstanceNetTypeEnum>($"DescribeDBInstanceAttribute.Items[{i}].DBInstanceNetType"),
                    DBInstanceStatus = context.EnumValue<DescribeDBInstanceAttributeResponse.DBInstanceAttribute.DBInstanceStatusEnum>($"DescribeDBInstanceAttribute.Items[{i}].DBInstanceStatus"),
                    DBInstanceDescription = context.StringValue($"DescribeDBInstanceAttribute.Items[{i}].DBInstanceDescription"),
                    LockMode = context.EnumValue<DescribeDBInstanceAttributeResponse.DBInstanceAttribute.LockModeEnum>($"DescribeDBInstanceAttribute.Items[{i}].LockMode"),
                    LockReason = context.StringValue($"DescribeDBInstanceAttribute.Items[{i}].LockReason"),
                    ReadDelayTime = context.StringValue($"DescribeDBInstanceAttribute.Items[{i}].ReadDelayTime"),
                    DBMaxQuantity = context.IntegerValue($"DescribeDBInstanceAttribute.Items[{i}].DBMaxQuantity"),
                    AccountMaxQuantity = context.IntegerValue($"DescribeDBInstanceAttribute.Items[{i}].AccountMaxQuantity"),
                    CreationTime = context.StringValue($"DescribeDBInstanceAttribute.Items[{i}].CreationTime"),
                    ExpireTime = context.StringValue($"DescribeDBInstanceAttribute.Items[{i}].ExpireTime"),
                    MaintainTime = context.StringValue($"DescribeDBInstanceAttribute.Items[{i}].MaintainTime"),
                    AvailabilityValue = context.StringValue($"DescribeDBInstanceAttribute.Items[{i}].AvailabilityValue"),
                    MaxIops = context.IntegerValue($"DescribeDBInstanceAttribute.Items[{i}].MaxIOPS"),
                    MaxConnections = context.IntegerValue($"DescribeDBInstanceAttribute.Items[{i}].MaxConnections"),
                    MasterInstanceId = context.StringValue($"DescribeDBInstanceAttribute.Items[{i}].MasterInstanceId"),
                    IncrementSourceDBInstanceId = context.StringValue($"DescribeDBInstanceAttribute.Items[{i}].IncrementSourceDBInstanceId"),
                    GuardDBInstanceId = context.StringValue($"DescribeDBInstanceAttribute.Items[{i}].GuardDBInstanceId"),
                    TempDBInstanceId = context.StringValue($"DescribeDBInstanceAttribute.Items[{i}].TempDBInstanceId"),
                    SecurityIpList = context.StringValue($"DescribeDBInstanceAttribute.Items[{i}].SecurityIPList"),
                    ZoneId = context.StringValue($"DescribeDBInstanceAttribute.Items[{i}].ZoneId"),
                    InstanceNetworkType = context.StringValue($"DescribeDBInstanceAttribute.Items[{i}].InstanceNetworkType"),
                    AccountType = context.EnumValue<DescribeDBInstanceAttributeResponse.DBInstanceAttribute.AccountTypeEnum>($"DescribeDBInstanceAttribute.Items[{i}].AccountType"),
                    SupportUpgradeAccountType = context.EnumValue<DescribeDBInstanceAttributeResponse.DBInstanceAttribute.SupportUpgradeAccountTypeEnum>($"DescribeDBInstanceAttribute.Items[{i}].SupportUpgradeAccountType"),
                    VpcId = context.StringValue($"DescribeDBInstanceAttribute.Items[{i}].VpcId"),
                    ConnectionMode = context.EnumValue<DescribeDBInstanceAttributeResponse.DBInstanceAttribute.ConnectionModeEnum>($"DescribeDBInstanceAttribute.Items[{i}].ConnectionMode")
                };
                List<DescribeDBInstanceAttributeResponse.DBInstanceAttribute.ReadOnlyDBInstanceId> readOnlyDBInstanceIds = new List<DescribeDBInstanceAttributeResponse.DBInstanceAttribute.ReadOnlyDBInstanceId>();
				for (int j = 0; j < context.Length($"DescribeDBInstanceAttribute.Items[{i}].ReadOnlyDBInstanceIds.Length"); j++) {
                    DescribeDBInstanceAttributeResponse.DBInstanceAttribute.ReadOnlyDBInstanceId readOnlyDBInstanceId = new DescribeDBInstanceAttributeResponse.DBInstanceAttribute.ReadOnlyDBInstanceId()
                    {
                        DBInstanceId = context.StringValue($"DescribeDBInstanceAttribute.Items[{i}].ReadOnlyDBInstanceIds[{j}].DBInstanceId")
                    };
                    readOnlyDBInstanceIds.Add(readOnlyDBInstanceId);
				}
				dBInstanceAttribute.ReadOnlyDBInstanceIds = readOnlyDBInstanceIds;

				items.Add(dBInstanceAttribute);
			}
			describeDBInstanceAttributeResponse.Items = items;
        
			return describeDBInstanceAttributeResponse;
        }
    }
}