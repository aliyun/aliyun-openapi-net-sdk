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
    public class DescribeDBInstancesAsCsvResponseUnmarshaller
    {
        public static DescribeDBInstancesAsCsvResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBInstancesAsCsvResponse describeDBInstancesAsCsvResponse = new DescribeDBInstancesAsCsvResponse();

			describeDBInstancesAsCsvResponse.HttpResponse = context.HttpResponse;
			describeDBInstancesAsCsvResponse.RequestId = context.StringValue("DescribeDBInstancesAsCsv.RequestId");

			List<DescribeDBInstancesAsCsvResponse.DescribeDBInstancesAsCsv_DBInstanceAttribute> describeDBInstancesAsCsvResponse_items = new List<DescribeDBInstancesAsCsvResponse.DescribeDBInstancesAsCsv_DBInstanceAttribute>();
			for (int i = 0; i < context.Length("DescribeDBInstancesAsCsv.Items.Length"); i++) {
				DescribeDBInstancesAsCsvResponse.DescribeDBInstancesAsCsv_DBInstanceAttribute dBInstanceAttribute = new DescribeDBInstancesAsCsvResponse.DescribeDBInstancesAsCsv_DBInstanceAttribute();
				dBInstanceAttribute.DBInstanceId = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].DBInstanceId");
				dBInstanceAttribute.PayType = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].PayType");
				dBInstanceAttribute.DBInstanceClassType = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].DBInstanceClassType");
				dBInstanceAttribute.DBInstanceType = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].DBInstanceType");
				dBInstanceAttribute.RegionId = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].RegionId");
				dBInstanceAttribute.ConnectionString = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].ConnectionString");
				dBInstanceAttribute.Port = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].Port");
				dBInstanceAttribute.Engine = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].Engine");
				dBInstanceAttribute.EngineVersion = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].EngineVersion");
				dBInstanceAttribute.DBInstanceClass = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].DBInstanceClass");
				dBInstanceAttribute.DBInstanceMemory = context.LongValue("DescribeDBInstancesAsCsv.Items["+ i +"].DBInstanceMemory");
				dBInstanceAttribute.DBInstanceStorage = context.IntegerValue("DescribeDBInstancesAsCsv.Items["+ i +"].DBInstanceStorage");
				dBInstanceAttribute.DBInstanceNetType = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].DBInstanceNetType");
				dBInstanceAttribute.DBInstanceStatus = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].DBInstanceStatus");
				dBInstanceAttribute.DBInstanceDescription = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].DBInstanceDescription");
				dBInstanceAttribute.LockMode = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].LockMode");
				dBInstanceAttribute.LockReason = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].LockReason");
				dBInstanceAttribute.ReadDelayTime = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].ReadDelayTime");
				dBInstanceAttribute.DBMaxQuantity = context.IntegerValue("DescribeDBInstancesAsCsv.Items["+ i +"].DBMaxQuantity");
				dBInstanceAttribute.AccountMaxQuantity = context.IntegerValue("DescribeDBInstancesAsCsv.Items["+ i +"].AccountMaxQuantity");
				dBInstanceAttribute.CreationTime = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].CreationTime");
				dBInstanceAttribute.ExpireTime = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].ExpireTime");
				dBInstanceAttribute.MaintainTime = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].MaintainTime");
				dBInstanceAttribute.AvailabilityValue = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].AvailabilityValue");
				dBInstanceAttribute.MaxIOPS = context.IntegerValue("DescribeDBInstancesAsCsv.Items["+ i +"].MaxIOPS");
				dBInstanceAttribute.MaxConnections = context.IntegerValue("DescribeDBInstancesAsCsv.Items["+ i +"].MaxConnections");
				dBInstanceAttribute.MasterInstanceId = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].MasterInstanceId");
				dBInstanceAttribute.DBInstanceCPU = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].DBInstanceCPU");
				dBInstanceAttribute.IncrementSourceDBInstanceId = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].IncrementSourceDBInstanceId");
				dBInstanceAttribute.GuardDBInstanceId = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].GuardDBInstanceId");
				dBInstanceAttribute.TempDBInstanceId = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].TempDBInstanceId");
				dBInstanceAttribute.SecurityIPList = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].SecurityIPList");
				dBInstanceAttribute.ZoneId = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].ZoneId");
				dBInstanceAttribute.InstanceNetworkType = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].InstanceNetworkType");
				dBInstanceAttribute.Category = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].Category");
				dBInstanceAttribute.AccountType = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].AccountType");
				dBInstanceAttribute.SupportUpgradeAccountType = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].SupportUpgradeAccountType");
				dBInstanceAttribute.VpcId = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].VpcId");
				dBInstanceAttribute.VSwitchId = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].VSwitchId");
				dBInstanceAttribute.ConnectionMode = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].ConnectionMode");
				dBInstanceAttribute.Tags = context.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].Tags");

				describeDBInstancesAsCsvResponse_items.Add(dBInstanceAttribute);
			}
			describeDBInstancesAsCsvResponse.Items = describeDBInstancesAsCsvResponse_items;
        
			return describeDBInstancesAsCsvResponse;
        }
    }
}
