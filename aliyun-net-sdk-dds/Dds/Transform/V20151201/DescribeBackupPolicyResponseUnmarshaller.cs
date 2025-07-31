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
using Aliyun.Acs.Dds.Model.V20151201;

namespace Aliyun.Acs.Dds.Transform.V20151201
{
    public class DescribeBackupPolicyResponseUnmarshaller
    {
        public static DescribeBackupPolicyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupPolicyResponse describeBackupPolicyResponse = new DescribeBackupPolicyResponse();

			describeBackupPolicyResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupPolicyResponse.PreferredBackupPeriod = _ctx.StringValue("DescribeBackupPolicy.PreferredBackupPeriod");
			describeBackupPolicyResponse.RequestId = _ctx.StringValue("DescribeBackupPolicy.RequestId");
			describeBackupPolicyResponse.PreferredBackupTime = _ctx.StringValue("DescribeBackupPolicy.PreferredBackupTime");
			describeBackupPolicyResponse.BackupRetentionPeriod = _ctx.StringValue("DescribeBackupPolicy.BackupRetentionPeriod");
			describeBackupPolicyResponse.PreferredNextBackupTime = _ctx.StringValue("DescribeBackupPolicy.PreferredNextBackupTime");
			describeBackupPolicyResponse.EnableBackupLog = _ctx.IntegerValue("DescribeBackupPolicy.EnableBackupLog");
			describeBackupPolicyResponse.LogBackupRetentionPeriod = _ctx.IntegerValue("DescribeBackupPolicy.LogBackupRetentionPeriod");
			describeBackupPolicyResponse.SnapshotBackupType = _ctx.StringValue("DescribeBackupPolicy.SnapshotBackupType");
			describeBackupPolicyResponse.BackupInterval = _ctx.IntegerValue("DescribeBackupPolicy.BackupInterval");
			describeBackupPolicyResponse.HighFrequencyBackupRetention = _ctx.StringValue("DescribeBackupPolicy.HighFrequencyBackupRetention");
			describeBackupPolicyResponse.BackupRetentionPolicyOnClusterDeletion = _ctx.IntegerValue("DescribeBackupPolicy.BackupRetentionPolicyOnClusterDeletion");
			describeBackupPolicyResponse.SrcRegion = _ctx.StringValue("DescribeBackupPolicy.SrcRegion");
			describeBackupPolicyResponse.DestRegion = _ctx.StringValue("DescribeBackupPolicy.DestRegion");
			describeBackupPolicyResponse.CrossRetentionType = _ctx.StringValue("DescribeBackupPolicy.CrossRetentionType");
			describeBackupPolicyResponse.CrossRetentionValue = _ctx.IntegerValue("DescribeBackupPolicy.CrossRetentionValue");
			describeBackupPolicyResponse.CrossBackupPeriod = _ctx.StringValue("DescribeBackupPolicy.CrossBackupPeriod");
			describeBackupPolicyResponse.EnableCrossLogBackup = _ctx.IntegerValue("DescribeBackupPolicy.EnableCrossLogBackup");
			describeBackupPolicyResponse.CrossLogRetentionType = _ctx.StringValue("DescribeBackupPolicy.CrossLogRetentionType");
			describeBackupPolicyResponse.CrossLogRetentionValue = _ctx.IntegerValue("DescribeBackupPolicy.CrossLogRetentionValue");
			describeBackupPolicyResponse.PreserveOneEachHour = _ctx.BooleanValue("DescribeBackupPolicy.PreserveOneEachHour");
        
			return describeBackupPolicyResponse;
        }
    }
}
