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
using Aliyun.Acs.polardb.Model.V20170801;

namespace Aliyun.Acs.polardb.Transform.V20170801
{
    public class DescribeBackupPolicyResponseUnmarshaller
    {
        public static DescribeBackupPolicyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupPolicyResponse describeBackupPolicyResponse = new DescribeBackupPolicyResponse();

			describeBackupPolicyResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupPolicyResponse.PreferredBackupPeriod = _ctx.StringValue("DescribeBackupPolicy.PreferredBackupPeriod");
			describeBackupPolicyResponse.DataLevel1BackupRetentionPeriod = _ctx.StringValue("DescribeBackupPolicy.DataLevel1BackupRetentionPeriod");
			describeBackupPolicyResponse.RequestId = _ctx.StringValue("DescribeBackupPolicy.RequestId");
			describeBackupPolicyResponse.PreferredBackupTime = _ctx.StringValue("DescribeBackupPolicy.PreferredBackupTime");
			describeBackupPolicyResponse.BackupRetentionPolicyOnClusterDeletion = _ctx.StringValue("DescribeBackupPolicy.BackupRetentionPolicyOnClusterDeletion");
			describeBackupPolicyResponse.BackupRetentionPeriod = _ctx.IntegerValue("DescribeBackupPolicy.BackupRetentionPeriod");
			describeBackupPolicyResponse.PreferredNextBackupTime = _ctx.StringValue("DescribeBackupPolicy.PreferredNextBackupTime");
			describeBackupPolicyResponse.DataLevel2BackupRetentionPeriod = _ctx.StringValue("DescribeBackupPolicy.DataLevel2BackupRetentionPeriod");
			describeBackupPolicyResponse.BackupFrequency = _ctx.StringValue("DescribeBackupPolicy.BackupFrequency");
			describeBackupPolicyResponse.DataLevel1BackupFrequency = _ctx.StringValue("DescribeBackupPolicy.DataLevel1BackupFrequency");
			describeBackupPolicyResponse.DataLevel1BackupPeriod = _ctx.StringValue("DescribeBackupPolicy.DataLevel1BackupPeriod");
			describeBackupPolicyResponse.DataLevel1BackupTime = _ctx.StringValue("DescribeBackupPolicy.DataLevel1BackupTime");
			describeBackupPolicyResponse.DataLevel2BackupPeriod = _ctx.StringValue("DescribeBackupPolicy.DataLevel2BackupPeriod");
			describeBackupPolicyResponse.DataLevel2BackupAnotherRegionRetentionPeriod = _ctx.StringValue("DescribeBackupPolicy.DataLevel2BackupAnotherRegionRetentionPeriod");
			describeBackupPolicyResponse.DataLevel2BackupAnotherRegionRegion = _ctx.StringValue("DescribeBackupPolicy.DataLevel2BackupAnotherRegionRegion");
        
			return describeBackupPolicyResponse;
        }
    }
}
