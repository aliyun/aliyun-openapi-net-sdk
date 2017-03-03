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
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeDBInstanceAttributeResponseUnmarshaller
    {
        public static DescribeDBInstanceAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBInstanceAttributeResponse describeDBInstanceAttributeResponse = new DescribeDBInstanceAttributeResponse();

			describeDBInstanceAttributeResponse.HttpResponse = context.HttpResponse;
			describeDBInstanceAttributeResponse.RequestId = context.StringValue("DescribeDBInstanceAttribute.RequestId");

			List<DescribeDBInstanceAttributeResponse.DBInstanceAttribute> items = new List<DescribeDBInstanceAttributeResponse.DBInstanceAttribute>();
			for (int i = 0; i < context.Length("DescribeDBInstanceAttribute.Items.Length"); i++) {
				DescribeDBInstanceAttributeResponse.DBInstanceAttribute dBInstanceAttribute = new DescribeDBInstanceAttributeResponse.DBInstanceAttribute();
				dBInstanceAttribute.InsId = context.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].InsId");
				dBInstanceAttribute.DBInstanceId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceId");
				dBInstanceAttribute.PayType = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].PayType");
				dBInstanceAttribute.DBInstanceClassType = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceClassType");
				dBInstanceAttribute.DBInstanceType = context.EnumValue<DescribeDBInstanceAttributeResponse.DBInstanceAttribute.DBInstanceTypeEnum>("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceType");
				dBInstanceAttribute.RegionId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].RegionId");
				dBInstanceAttribute.ConnectionString = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ConnectionString");
				dBInstanceAttribute.Port = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Port");
				dBInstanceAttribute.Engine = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].Engine");
				dBInstanceAttribute.EngineVersion = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].EngineVersion");
				dBInstanceAttribute.DBInstanceClass = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceClass");
				dBInstanceAttribute.DBInstanceMemory = context.LongValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceMemory");
				dBInstanceAttribute.DBInstanceStorage = context.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceStorage");
				dBInstanceAttribute.DBInstanceNetType = context.EnumValue<DescribeDBInstanceAttributeResponse.DBInstanceAttribute.DBInstanceNetTypeEnum>("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceNetType");
				dBInstanceAttribute.DBInstanceStatus = context.EnumValue<DescribeDBInstanceAttributeResponse.DBInstanceAttribute.DBInstanceStatusEnum>("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceStatus");
				dBInstanceAttribute.DBInstanceDescription = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceDescription");
				dBInstanceAttribute.LockMode = context.EnumValue<DescribeDBInstanceAttributeResponse.DBInstanceAttribute.LockModeEnum>("DescribeDBInstanceAttribute.Items["+ i +"].LockMode");
				dBInstanceAttribute.LockReason = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].LockReason");
				dBInstanceAttribute.ReadDelayTime = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ReadDelayTime");
				dBInstanceAttribute.DBMaxQuantity = context.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].DBMaxQuantity");
				dBInstanceAttribute.AccountMaxQuantity = context.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].AccountMaxQuantity");
				dBInstanceAttribute.CreationTime = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].CreationTime");
				dBInstanceAttribute.ExpireTime = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ExpireTime");
				dBInstanceAttribute.MaintainTime = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].MaintainTime");
				dBInstanceAttribute.AvailabilityValue = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].AvailabilityValue");
				dBInstanceAttribute.MaxIOPS = context.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].MaxIOPS");
				dBInstanceAttribute.MaxConnections = context.IntegerValue("DescribeDBInstanceAttribute.Items["+ i +"].MaxConnections");
				dBInstanceAttribute.MasterInstanceId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].MasterInstanceId");
				dBInstanceAttribute.DBInstanceCPU = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].DBInstanceCPU");
				dBInstanceAttribute.IncrementSourceDBInstanceId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].IncrementSourceDBInstanceId");
				dBInstanceAttribute.GuardDBInstanceId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].GuardDBInstanceId");
				dBInstanceAttribute.TempDBInstanceId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].TempDBInstanceId");
				dBInstanceAttribute.SecurityIPList = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].SecurityIPList");
				dBInstanceAttribute.ZoneId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ZoneId");
				dBInstanceAttribute.InstanceNetworkType = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].InstanceNetworkType");
				dBInstanceAttribute.AccountType = context.EnumValue<DescribeDBInstanceAttributeResponse.DBInstanceAttribute.AccountTypeEnum>("DescribeDBInstanceAttribute.Items["+ i +"].AccountType");
				dBInstanceAttribute.SupportUpgradeAccountType = context.EnumValue<DescribeDBInstanceAttributeResponse.DBInstanceAttribute.SupportUpgradeAccountTypeEnum>("DescribeDBInstanceAttribute.Items["+ i +"].SupportUpgradeAccountType");
				dBInstanceAttribute.VpcId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].VpcId");
				dBInstanceAttribute.ConnectionMode = context.EnumValue<DescribeDBInstanceAttributeResponse.DBInstanceAttribute.ConnectionModeEnum>("DescribeDBInstanceAttribute.Items["+ i +"].ConnectionMode");

				List<DescribeDBInstanceAttributeResponse.DBInstanceAttribute.ReadOnlyDBInstanceId> readOnlyDBInstanceIds = new List<DescribeDBInstanceAttributeResponse.DBInstanceAttribute.ReadOnlyDBInstanceId>();
				for (int j = 0; j < context.Length("DescribeDBInstanceAttribute.Items["+ i +"].ReadOnlyDBInstanceIds.Length"); j++) {
					DescribeDBInstanceAttributeResponse.DBInstanceAttribute.ReadOnlyDBInstanceId readOnlyDBInstanceId = new DescribeDBInstanceAttributeResponse.DBInstanceAttribute.ReadOnlyDBInstanceId();
					readOnlyDBInstanceId.DBInstanceId = context.StringValue("DescribeDBInstanceAttribute.Items["+ i +"].ReadOnlyDBInstanceIds["+ j +"].DBInstanceId");

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