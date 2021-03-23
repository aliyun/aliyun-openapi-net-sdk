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
    public class DescribeBackupPolicyResponseUnmarshaller
    {
        public static DescribeBackupPolicyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupPolicyResponse describeBackupPolicyResponse = new DescribeBackupPolicyResponse();

			describeBackupPolicyResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupPolicyResponse.RequestId = _ctx.StringValue("DescribeBackupPolicy.RequestId");
			describeBackupPolicyResponse.BackupRetentionPeriod = _ctx.IntegerValue("DescribeBackupPolicy.BackupRetentionPeriod");
			describeBackupPolicyResponse.PreferredNextBackupTime = _ctx.StringValue("DescribeBackupPolicy.PreferredNextBackupTime");
			describeBackupPolicyResponse.PreferredBackupTime = _ctx.StringValue("DescribeBackupPolicy.PreferredBackupTime");
			describeBackupPolicyResponse.PreferredBackupPeriod = _ctx.StringValue("DescribeBackupPolicy.PreferredBackupPeriod");
			describeBackupPolicyResponse.BackupLog = _ctx.StringValue("DescribeBackupPolicy.BackupLog");
			describeBackupPolicyResponse.LogBackupRetentionPeriod = _ctx.IntegerValue("DescribeBackupPolicy.LogBackupRetentionPeriod");
			describeBackupPolicyResponse.EnableBackupLog = _ctx.StringValue("DescribeBackupPolicy.EnableBackupLog");
			describeBackupPolicyResponse.LocalLogRetentionHours = _ctx.IntegerValue("DescribeBackupPolicy.LocalLogRetentionHours");
			describeBackupPolicyResponse.LocalLogRetentionSpace = _ctx.StringValue("DescribeBackupPolicy.LocalLogRetentionSpace");
			describeBackupPolicyResponse.Duplication = _ctx.StringValue("DescribeBackupPolicy.Duplication");
			describeBackupPolicyResponse.DuplicationContent = _ctx.StringValue("DescribeBackupPolicy.DuplicationContent");
			describeBackupPolicyResponse.HighSpaceUsageProtection = _ctx.StringValue("DescribeBackupPolicy.HighSpaceUsageProtection");
			describeBackupPolicyResponse.LogBackupFrequency = _ctx.StringValue("DescribeBackupPolicy.LogBackupFrequency");
			describeBackupPolicyResponse.CompressType = _ctx.StringValue("DescribeBackupPolicy.CompressType");
			describeBackupPolicyResponse.ArchiveBackupRetentionPeriod = _ctx.StringValue("DescribeBackupPolicy.ArchiveBackupRetentionPeriod");
			describeBackupPolicyResponse.ArchiveBackupKeepPolicy = _ctx.StringValue("DescribeBackupPolicy.ArchiveBackupKeepPolicy");
			describeBackupPolicyResponse.ArchiveBackupKeepCount = _ctx.StringValue("DescribeBackupPolicy.ArchiveBackupKeepCount");
			describeBackupPolicyResponse.ReleasedKeepPolicy = _ctx.StringValue("DescribeBackupPolicy.ReleasedKeepPolicy");
			describeBackupPolicyResponse.LogBackupLocalRetentionNumber = _ctx.IntegerValue("DescribeBackupPolicy.LogBackupLocalRetentionNumber");
			describeBackupPolicyResponse.Category = _ctx.StringValue("DescribeBackupPolicy.Category");
			describeBackupPolicyResponse.SupportReleasedKeep = _ctx.IntegerValue("DescribeBackupPolicy.SupportReleasedKeep");
			describeBackupPolicyResponse.BackupInterval = _ctx.StringValue("DescribeBackupPolicy.BackupInterval");
			describeBackupPolicyResponse.SupportVolumeShadowCopy = _ctx.IntegerValue("DescribeBackupPolicy.SupportVolumeShadowCopy");
			describeBackupPolicyResponse.BackupMethod = _ctx.StringValue("DescribeBackupPolicy.BackupMethod");

			DescribeBackupPolicyResponse.DescribeBackupPolicy_DuplicationLocation duplicationLocation = new DescribeBackupPolicyResponse.DescribeBackupPolicy_DuplicationLocation();
			duplicationLocation.Sotrage = _ctx.StringValue("DescribeBackupPolicy.DuplicationLocation.Sotrage");

			DescribeBackupPolicyResponse.DescribeBackupPolicy_DuplicationLocation.DescribeBackupPolicy_Location location = new DescribeBackupPolicyResponse.DescribeBackupPolicy_DuplicationLocation.DescribeBackupPolicy_Location();
			location.Endpoint = _ctx.StringValue("DescribeBackupPolicy.DuplicationLocation.Location.Endpoint");
			location.Bucket = _ctx.StringValue("DescribeBackupPolicy.DuplicationLocation.Location.Bucket");
			duplicationLocation.Location = location;
			describeBackupPolicyResponse.DuplicationLocation = duplicationLocation;
        
			return describeBackupPolicyResponse;
        }
    }
}
