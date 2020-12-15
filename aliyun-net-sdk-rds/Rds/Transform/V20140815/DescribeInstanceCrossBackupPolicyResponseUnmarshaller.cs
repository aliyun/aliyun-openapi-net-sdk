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
        public static DescribeInstanceCrossBackupPolicyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeInstanceCrossBackupPolicyResponse describeInstanceCrossBackupPolicyResponse = new DescribeInstanceCrossBackupPolicyResponse();

			describeInstanceCrossBackupPolicyResponse.HttpResponse = _ctx.HttpResponse;
			describeInstanceCrossBackupPolicyResponse.RequestId = _ctx.StringValue("DescribeInstanceCrossBackupPolicy.RequestId");
			describeInstanceCrossBackupPolicyResponse.DBInstanceId = _ctx.StringValue("DescribeInstanceCrossBackupPolicy.DBInstanceId");
			describeInstanceCrossBackupPolicyResponse.DBInstanceDescription = _ctx.StringValue("DescribeInstanceCrossBackupPolicy.DBInstanceDescription");
			describeInstanceCrossBackupPolicyResponse.DBInstanceStatus = _ctx.StringValue("DescribeInstanceCrossBackupPolicy.DBInstanceStatus");
			describeInstanceCrossBackupPolicyResponse.DBInstanceStatusDesc = _ctx.StringValue("DescribeInstanceCrossBackupPolicy.DBInstanceStatusDesc");
			describeInstanceCrossBackupPolicyResponse.Engine = _ctx.StringValue("DescribeInstanceCrossBackupPolicy.Engine");
			describeInstanceCrossBackupPolicyResponse.EngineVersion = _ctx.StringValue("DescribeInstanceCrossBackupPolicy.EngineVersion");
			describeInstanceCrossBackupPolicyResponse.RegionId = _ctx.StringValue("DescribeInstanceCrossBackupPolicy.RegionId");
			describeInstanceCrossBackupPolicyResponse.CrossBackupRegion = _ctx.StringValue("DescribeInstanceCrossBackupPolicy.CrossBackupRegion");
			describeInstanceCrossBackupPolicyResponse.CrossBackupType = _ctx.StringValue("DescribeInstanceCrossBackupPolicy.CrossBackupType");
			describeInstanceCrossBackupPolicyResponse.BackupEnabledTime = _ctx.StringValue("DescribeInstanceCrossBackupPolicy.BackupEnabledTime");
			describeInstanceCrossBackupPolicyResponse.BackupEnabled = _ctx.StringValue("DescribeInstanceCrossBackupPolicy.BackupEnabled");
			describeInstanceCrossBackupPolicyResponse.LogBackupEnabled = _ctx.StringValue("DescribeInstanceCrossBackupPolicy.LogBackupEnabled");
			describeInstanceCrossBackupPolicyResponse.LogBackupEnabledTime = _ctx.StringValue("DescribeInstanceCrossBackupPolicy.LogBackupEnabledTime");
			describeInstanceCrossBackupPolicyResponse.StorageOwner = _ctx.StringValue("DescribeInstanceCrossBackupPolicy.StorageOwner");
			describeInstanceCrossBackupPolicyResponse.StorageType = _ctx.StringValue("DescribeInstanceCrossBackupPolicy.StorageType");
			describeInstanceCrossBackupPolicyResponse.Endpoint = _ctx.StringValue("DescribeInstanceCrossBackupPolicy.Endpoint");
			describeInstanceCrossBackupPolicyResponse.RetentType = _ctx.IntegerValue("DescribeInstanceCrossBackupPolicy.RetentType");
			describeInstanceCrossBackupPolicyResponse.Retention = _ctx.IntegerValue("DescribeInstanceCrossBackupPolicy.Retention");
			describeInstanceCrossBackupPolicyResponse.LockMode = _ctx.StringValue("DescribeInstanceCrossBackupPolicy.LockMode");
			describeInstanceCrossBackupPolicyResponse.RelService = _ctx.StringValue("DescribeInstanceCrossBackupPolicy.RelService");
			describeInstanceCrossBackupPolicyResponse.RelServiceId = _ctx.StringValue("DescribeInstanceCrossBackupPolicy.RelServiceId");
        
			return describeInstanceCrossBackupPolicyResponse;
        }
    }
}
