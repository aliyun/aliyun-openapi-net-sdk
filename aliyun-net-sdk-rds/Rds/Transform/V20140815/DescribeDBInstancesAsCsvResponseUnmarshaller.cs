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
        public static DescribeDBInstancesAsCsvResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeDBInstancesAsCsvResponse describeDBInstancesAsCsvResponse = new DescribeDBInstancesAsCsvResponse();

			describeDBInstancesAsCsvResponse.HttpResponse = _ctx.HttpResponse;
			describeDBInstancesAsCsvResponse.RequestId = _ctx.StringValue("DescribeDBInstancesAsCsv.RequestId");

			List<DescribeDBInstancesAsCsvResponse.DescribeDBInstancesAsCsv_DBInstanceAttribute> describeDBInstancesAsCsvResponse_items = new List<DescribeDBInstancesAsCsvResponse.DescribeDBInstancesAsCsv_DBInstanceAttribute>();
			for (int i = 0; i < _ctx.Length("DescribeDBInstancesAsCsv.Items.Length"); i++) {
				DescribeDBInstancesAsCsvResponse.DescribeDBInstancesAsCsv_DBInstanceAttribute dBInstanceAttribute = new DescribeDBInstancesAsCsvResponse.DescribeDBInstancesAsCsv_DBInstanceAttribute();
				dBInstanceAttribute.VpcId = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].VpcId");
				dBInstanceAttribute.CreationTime = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].CreationTime");
				dBInstanceAttribute.TempDBInstanceId = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].TempDBInstanceId");
				dBInstanceAttribute.SupportUpgradeAccountType = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].SupportUpgradeAccountType");
				dBInstanceAttribute.IncrementSourceDBInstanceId = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].IncrementSourceDBInstanceId");
				dBInstanceAttribute.DBInstanceMemory = _ctx.LongValue("DescribeDBInstancesAsCsv.Items["+ i +"].DBInstanceMemory");
				dBInstanceAttribute.MaintainTime = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].MaintainTime");
				dBInstanceAttribute.PayType = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].PayType");
				dBInstanceAttribute.Tags = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].Tags");
				dBInstanceAttribute.AvailabilityValue = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].AvailabilityValue");
				dBInstanceAttribute.ReadDelayTime = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].ReadDelayTime");
				dBInstanceAttribute.ConnectionMode = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].ConnectionMode");
				dBInstanceAttribute.Port = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].Port");
				dBInstanceAttribute.AccountType = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].AccountType");
				dBInstanceAttribute.LockMode = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].LockMode");
				dBInstanceAttribute.EngineVersion = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].EngineVersion");
				dBInstanceAttribute.MaxIOPS = _ctx.IntegerValue("DescribeDBInstancesAsCsv.Items["+ i +"].MaxIOPS");
				dBInstanceAttribute.ConnectionString = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].ConnectionString");
				dBInstanceAttribute.InstanceNetworkType = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].InstanceNetworkType");
				dBInstanceAttribute.SecurityIPList = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].SecurityIPList");
				dBInstanceAttribute.MasterInstanceId = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].MasterInstanceId");
				dBInstanceAttribute.DBInstanceClassType = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].DBInstanceClassType");
				dBInstanceAttribute.DBInstanceDescription = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].DBInstanceDescription");
				dBInstanceAttribute.DBInstanceCPU = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].DBInstanceCPU");
				dBInstanceAttribute.ExpireTime = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].ExpireTime");
				dBInstanceAttribute.DBInstanceNetType = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].DBInstanceNetType");
				dBInstanceAttribute.DBInstanceType = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].DBInstanceType");
				dBInstanceAttribute.AccountMaxQuantity = _ctx.IntegerValue("DescribeDBInstancesAsCsv.Items["+ i +"].AccountMaxQuantity");
				dBInstanceAttribute.LockReason = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].LockReason");
				dBInstanceAttribute.DBInstanceStatus = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].DBInstanceStatus");
				dBInstanceAttribute.DBMaxQuantity = _ctx.IntegerValue("DescribeDBInstancesAsCsv.Items["+ i +"].DBMaxQuantity");
				dBInstanceAttribute.GuardDBInstanceId = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].GuardDBInstanceId");
				dBInstanceAttribute.RegionId = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].RegionId");
				dBInstanceAttribute.DBInstanceStorage = _ctx.IntegerValue("DescribeDBInstancesAsCsv.Items["+ i +"].DBInstanceStorage");
				dBInstanceAttribute.VSwitchId = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].VSwitchId");
				dBInstanceAttribute.ZoneId = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].ZoneId");
				dBInstanceAttribute.Category = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].Category");
				dBInstanceAttribute.MaxConnections = _ctx.IntegerValue("DescribeDBInstancesAsCsv.Items["+ i +"].MaxConnections");
				dBInstanceAttribute.DBInstanceId = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].DBInstanceId");
				dBInstanceAttribute.DBInstanceClass = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].DBInstanceClass");
				dBInstanceAttribute.Engine = _ctx.StringValue("DescribeDBInstancesAsCsv.Items["+ i +"].Engine");

				describeDBInstancesAsCsvResponse_items.Add(dBInstanceAttribute);
			}
			describeDBInstancesAsCsvResponse.Items = describeDBInstancesAsCsvResponse_items;
        
			return describeDBInstancesAsCsvResponse;
        }
    }
}
