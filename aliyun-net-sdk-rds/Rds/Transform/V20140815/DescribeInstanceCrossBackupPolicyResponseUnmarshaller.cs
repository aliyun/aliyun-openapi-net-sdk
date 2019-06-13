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
    public class DescribeInstanceCrossBackupPolicyResponseUnmarshaller
    {
        public static DescribeInstanceCrossBackupPolicyResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeInstanceCrossBackupPolicyResponse describeInstanceCrossBackupPolicyResponse = new DescribeInstanceCrossBackupPolicyResponse();

			describeInstanceCrossBackupPolicyResponse.HttpResponse = context.HttpResponse;
			describeInstanceCrossBackupPolicyResponse.RequestId = context.StringValue("DescribeInstanceCrossBackupPolicy.RequestId");
			describeInstanceCrossBackupPolicyResponse.DBInstanceId = context.StringValue("DescribeInstanceCrossBackupPolicy.DBInstanceId");
			describeInstanceCrossBackupPolicyResponse.DBInstanceDescription = context.StringValue("DescribeInstanceCrossBackupPolicy.DBInstanceDescription");
			describeInstanceCrossBackupPolicyResponse.DBInstanceStatus = context.StringValue("DescribeInstanceCrossBackupPolicy.DBInstanceStatus");
			describeInstanceCrossBackupPolicyResponse.DBInstanceStatusDesc = context.StringValue("DescribeInstanceCrossBackupPolicy.DBInstanceStatusDesc");
			describeInstanceCrossBackupPolicyResponse.Engine = context.StringValue("DescribeInstanceCrossBackupPolicy.Engine");
			describeInstanceCrossBackupPolicyResponse.EngineVersion = context.StringValue("DescribeInstanceCrossBackupPolicy.EngineVersion");
			describeInstanceCrossBackupPolicyResponse.RegionId = context.StringValue("DescribeInstanceCrossBackupPolicy.RegionId");
			describeInstanceCrossBackupPolicyResponse.CrossBackupRegion = context.StringValue("DescribeInstanceCrossBackupPolicy.CrossBackupRegion");
			describeInstanceCrossBackupPolicyResponse.CrossBackupType = context.StringValue("DescribeInstanceCrossBackupPolicy.CrossBackupType");
			describeInstanceCrossBackupPolicyResponse.BackupEnabledTime = context.StringValue("DescribeInstanceCrossBackupPolicy.BackupEnabledTime");
			describeInstanceCrossBackupPolicyResponse.BackupEnabled = context.StringValue("DescribeInstanceCrossBackupPolicy.BackupEnabled");
			describeInstanceCrossBackupPolicyResponse.LogBackupEnabled = context.StringValue("DescribeInstanceCrossBackupPolicy.LogBackupEnabled");
			describeInstanceCrossBackupPolicyResponse.LogBackupEnabledTime = context.StringValue("DescribeInstanceCrossBackupPolicy.LogBackupEnabledTime");
			describeInstanceCrossBackupPolicyResponse.StorageOwner = context.StringValue("DescribeInstanceCrossBackupPolicy.StorageOwner");
			describeInstanceCrossBackupPolicyResponse.StorageType = context.StringValue("DescribeInstanceCrossBackupPolicy.StorageType");
			describeInstanceCrossBackupPolicyResponse.Endpoint = context.StringValue("DescribeInstanceCrossBackupPolicy.Endpoint");
			describeInstanceCrossBackupPolicyResponse.RetentType = context.IntegerValue("DescribeInstanceCrossBackupPolicy.RetentType");
			describeInstanceCrossBackupPolicyResponse.Retention = context.IntegerValue("DescribeInstanceCrossBackupPolicy.Retention");
			describeInstanceCrossBackupPolicyResponse.LockMode = context.StringValue("DescribeInstanceCrossBackupPolicy.LockMode");
        
			return describeInstanceCrossBackupPolicyResponse;
        }
    }
}
