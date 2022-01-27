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
    public class DescribeBackupLocalResponseUnmarshaller
    {
        public static DescribeBackupLocalResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupLocalResponse describeBackupLocalResponse = new DescribeBackupLocalResponse();

			describeBackupLocalResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupLocalResponse.RequestId = _ctx.StringValue("DescribeBackupLocal.RequestId");
			describeBackupLocalResponse.Success = _ctx.BooleanValue("DescribeBackupLocal.Success");

			DescribeBackupLocalResponse.DescribeBackupLocal_BackupPolicyDO backupPolicyDO = new DescribeBackupLocalResponse.DescribeBackupLocal_BackupPolicyDO();
			backupPolicyDO.GmtCreate = _ctx.LongValue("DescribeBackupLocal.BackupPolicyDO.GmtCreate");
			backupPolicyDO.GmtModified = _ctx.LongValue("DescribeBackupLocal.BackupPolicyDO.GmtModified");
			backupPolicyDO.BackupPolicyMode = _ctx.StringValue("DescribeBackupLocal.BackupPolicyDO.BackupPolicyMode");
			backupPolicyDO.BackupType = _ctx.StringValue("DescribeBackupLocal.BackupPolicyDO.BackupType");
			backupPolicyDO.BackupLevel = _ctx.StringValue("DescribeBackupLocal.BackupPolicyDO.BackupLevel");
			backupPolicyDO.BackupDbName = _ctx.StringValue("DescribeBackupLocal.BackupPolicyDO.BackupDbName");
			backupPolicyDO.PreferredBackupTime = _ctx.StringValue("DescribeBackupLocal.BackupPolicyDO.PreferredBackupTime");
			backupPolicyDO.PreferredBackupPeriod = _ctx.StringValue("DescribeBackupLocal.BackupPolicyDO.PreferredBackupPeriod");
			backupPolicyDO.DataBackupRetentionPeriod = _ctx.LongValue("DescribeBackupLocal.BackupPolicyDO.DataBackupRetentionPeriod");
			backupPolicyDO.LogBackupRetentionPeriod = _ctx.LongValue("DescribeBackupLocal.BackupPolicyDO.LogBackupRetentionPeriod");
			backupPolicyDO.BackupRetentionPeriod = _ctx.LongValue("DescribeBackupLocal.BackupPolicyDO.BackupRetentionPeriod");
			backupPolicyDO.BackupLog = _ctx.StringValue("DescribeBackupLocal.BackupPolicyDO.BackupLog");
			backupPolicyDO.LocalLogRetentionHours = _ctx.LongValue("DescribeBackupLocal.BackupPolicyDO.LocalLogRetentionHours");
			backupPolicyDO.LocalLogRetentionSpace = _ctx.LongValue("DescribeBackupLocal.BackupPolicyDO.LocalLogRetentionSpace");
			backupPolicyDO.HighSpaceUsageProtection = _ctx.LongValue("DescribeBackupLocal.BackupPolicyDO.HighSpaceUsageProtection");
			backupPolicyDO.BackupAppName = _ctx.StringValue("DescribeBackupLocal.BackupPolicyDO.BackupAppName");
			backupPolicyDO.BackupMode = _ctx.StringValue("DescribeBackupLocal.BackupPolicyDO.BackupMode");
			backupPolicyDO.NextBackupActuallyTime = _ctx.StringValue("DescribeBackupLocal.BackupPolicyDO.NextBackupActuallyTime");
			describeBackupLocalResponse.BackupPolicyDO = backupPolicyDO;
        
			return describeBackupLocalResponse;
        }
    }
}
