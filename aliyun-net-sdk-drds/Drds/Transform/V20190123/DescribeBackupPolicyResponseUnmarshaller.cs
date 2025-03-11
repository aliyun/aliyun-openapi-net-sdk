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
using Aliyun.Acs.Drds.Model.V20190123;

namespace Aliyun.Acs.Drds.Transform.V20190123
{
    public class DescribeBackupPolicyResponseUnmarshaller
    {
        public static DescribeBackupPolicyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupPolicyResponse describeBackupPolicyResponse = new DescribeBackupPolicyResponse();

			describeBackupPolicyResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupPolicyResponse.Success = _ctx.BooleanValue("DescribeBackupPolicy.Success");
			describeBackupPolicyResponse.RequestId = _ctx.StringValue("DescribeBackupPolicy.RequestId");

			DescribeBackupPolicyResponse.DescribeBackupPolicy_BackupPolicyDO backupPolicyDO = new DescribeBackupPolicyResponse.DescribeBackupPolicy_BackupPolicyDO();
			backupPolicyDO.BackupDbName = _ctx.StringValue("DescribeBackupPolicy.BackupPolicyDO.BackupDbName");
			backupPolicyDO.LogBackupRetentionPeriod = _ctx.LongValue("DescribeBackupPolicy.BackupPolicyDO.LogBackupRetentionPeriod");
			backupPolicyDO.DataBackupRetentionPeriod = _ctx.LongValue("DescribeBackupPolicy.BackupPolicyDO.DataBackupRetentionPeriod");
			backupPolicyDO.BackupType = _ctx.StringValue("DescribeBackupPolicy.BackupPolicyDO.BackupType");
			backupPolicyDO.BackupLevel = _ctx.StringValue("DescribeBackupPolicy.BackupPolicyDO.BackupLevel");
			backupPolicyDO.LocalLogRetentionHours = _ctx.LongValue("DescribeBackupPolicy.BackupPolicyDO.LocalLogRetentionHours");
			backupPolicyDO.HighSpaceUsageProtection = _ctx.LongValue("DescribeBackupPolicy.BackupPolicyDO.HighSpaceUsageProtection");
			backupPolicyDO.GmtModified = _ctx.LongValue("DescribeBackupPolicy.BackupPolicyDO.GmtModified");
			backupPolicyDO.BackupRetentionPeriod = _ctx.LongValue("DescribeBackupPolicy.BackupPolicyDO.BackupRetentionPeriod");
			backupPolicyDO.BackupPolicyMode = _ctx.StringValue("DescribeBackupPolicy.BackupPolicyDO.BackupPolicyMode");
			backupPolicyDO.PreferredBackupPeriod = _ctx.StringValue("DescribeBackupPolicy.BackupPolicyDO.PreferredBackupPeriod");
			backupPolicyDO.LocalLogRetentionSpace = _ctx.LongValue("DescribeBackupPolicy.BackupPolicyDO.LocalLogRetentionSpace");
			backupPolicyDO.BackupAppName = _ctx.StringValue("DescribeBackupPolicy.BackupPolicyDO.BackupAppName");
			backupPolicyDO.PreferredBackupTime = _ctx.StringValue("DescribeBackupPolicy.BackupPolicyDO.PreferredBackupTime");
			backupPolicyDO.GmtCreate = _ctx.LongValue("DescribeBackupPolicy.BackupPolicyDO.GmtCreate");
			backupPolicyDO.BackupMode = _ctx.StringValue("DescribeBackupPolicy.BackupPolicyDO.BackupMode");
			backupPolicyDO.BackupLog = _ctx.StringValue("DescribeBackupPolicy.BackupPolicyDO.BackupLog");
			backupPolicyDO.NextBackupActuallyTime = _ctx.StringValue("DescribeBackupPolicy.BackupPolicyDO.NextBackupActuallyTime");
			describeBackupPolicyResponse.BackupPolicyDO = backupPolicyDO;
        
			return describeBackupPolicyResponse;
        }
    }
}
