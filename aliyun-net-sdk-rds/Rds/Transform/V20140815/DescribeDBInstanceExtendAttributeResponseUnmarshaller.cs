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
    public class DescribeDBInstanceExtendAttributeResponseUnmarshaller
    {
        public static DescribeDBInstanceExtendAttributeResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDBInstanceExtendAttributeResponse describeDBInstanceExtendAttributeResponse = new DescribeDBInstanceExtendAttributeResponse();

			describeDBInstanceExtendAttributeResponse.HttpResponse = context.HttpResponse;
			describeDBInstanceExtendAttributeResponse.RequestId = context.StringValue("DescribeDBInstanceExtendAttribute.RequestId");
			describeDBInstanceExtendAttributeResponse.CanTempUpgrade = context.BooleanValue("DescribeDBInstanceExtendAttribute.CanTempUpgrade");
			describeDBInstanceExtendAttributeResponse.TempUpgradeTimeStart = context.StringValue("DescribeDBInstanceExtendAttribute.TempUpgradeTimeStart");
			describeDBInstanceExtendAttributeResponse.TempUpgradeTimeEnd = context.StringValue("DescribeDBInstanceExtendAttribute.TempUpgradeTimeEnd");
			describeDBInstanceExtendAttributeResponse.TempUpgradeRecoveryTime = context.StringValue("DescribeDBInstanceExtendAttribute.TempUpgradeRecoveryTime");
			describeDBInstanceExtendAttributeResponse.TempUpgradeRecoveryClass = context.StringValue("DescribeDBInstanceExtendAttribute.TempUpgradeRecoveryClass");
			describeDBInstanceExtendAttributeResponse.TempUpgradeRecoveryCpu = context.IntegerValue("DescribeDBInstanceExtendAttribute.TempUpgradeRecoveryCpu");
			describeDBInstanceExtendAttributeResponse.TempUpgradeRecoveryMemory = context.IntegerValue("DescribeDBInstanceExtendAttribute.TempUpgradeRecoveryMemory");
			describeDBInstanceExtendAttributeResponse.TempUpgradeRecoveryMaxIOPS = context.StringValue("DescribeDBInstanceExtendAttribute.TempUpgradeRecoveryMaxIOPS");
			describeDBInstanceExtendAttributeResponse.TempUpgradeRecoveryMaxConnections = context.StringValue("DescribeDBInstanceExtendAttribute.TempUpgradeRecoveryMaxConnections");
        
			return describeDBInstanceExtendAttributeResponse;
        }
    }
}