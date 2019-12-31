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
        public static DescribeBackupPolicyResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBackupPolicyResponse describeBackupPolicyResponse = new DescribeBackupPolicyResponse();

			describeBackupPolicyResponse.HttpResponse = context.HttpResponse;
			describeBackupPolicyResponse.RequestId = context.StringValue("DescribeBackupPolicy.RequestId");
			describeBackupPolicyResponse.BackupRetentionPeriod = context.IntegerValue("DescribeBackupPolicy.BackupRetentionPeriod");
			describeBackupPolicyResponse.PreferredNextBackupTime = context.StringValue("DescribeBackupPolicy.PreferredNextBackupTime");
			describeBackupPolicyResponse.PreferredBackupTime = context.StringValue("DescribeBackupPolicy.PreferredBackupTime");
			describeBackupPolicyResponse.PreferredBackupPeriod = context.StringValue("DescribeBackupPolicy.PreferredBackupPeriod");
			describeBackupPolicyResponse.BackupLog = context.StringValue("DescribeBackupPolicy.BackupLog");
			describeBackupPolicyResponse.LogBackupRetentionPeriod = context.IntegerValue("DescribeBackupPolicy.LogBackupRetentionPeriod");
			describeBackupPolicyResponse.EnableBackupLog = context.StringValue("DescribeBackupPolicy.EnableBackupLog");
			describeBackupPolicyResponse.LocalLogRetentionHours = context.IntegerValue("DescribeBackupPolicy.LocalLogRetentionHours");
			describeBackupPolicyResponse.LocalLogRetentionSpace = context.StringValue("DescribeBackupPolicy.LocalLogRetentionSpace");
			describeBackupPolicyResponse.Duplication = context.StringValue("DescribeBackupPolicy.Duplication");
			describeBackupPolicyResponse.DuplicationContent = context.StringValue("DescribeBackupPolicy.DuplicationContent");
			describeBackupPolicyResponse.HighSpaceUsageProtection = context.StringValue("DescribeBackupPolicy.HighSpaceUsageProtection");
			describeBackupPolicyResponse.LogBackupFrequency = context.StringValue("DescribeBackupPolicy.LogBackupFrequency");
			describeBackupPolicyResponse.CompressType = context.StringValue("DescribeBackupPolicy.CompressType");
			describeBackupPolicyResponse.ArchiveBackupRetentionPeriod = context.StringValue("DescribeBackupPolicy.ArchiveBackupRetentionPeriod");
			describeBackupPolicyResponse.ArchiveBackupKeepPolicy = context.StringValue("DescribeBackupPolicy.ArchiveBackupKeepPolicy");
			describeBackupPolicyResponse.ArchiveBackupKeepCount = context.StringValue("DescribeBackupPolicy.ArchiveBackupKeepCount");
			describeBackupPolicyResponse.ReleasedKeepPolicy = context.StringValue("DescribeBackupPolicy.ReleasedKeepPolicy");
			describeBackupPolicyResponse.LogBackupLocalRetentionNumber = context.IntegerValue("DescribeBackupPolicy.LogBackupLocalRetentionNumber");

			DescribeBackupPolicyResponse.DescribeBackupPolicy_DuplicationLocation duplicationLocation = new DescribeBackupPolicyResponse.DescribeBackupPolicy_DuplicationLocation();
			duplicationLocation.Sotrage = context.StringValue("DescribeBackupPolicy.DuplicationLocation.Sotrage");

			DescribeBackupPolicyResponse.DescribeBackupPolicy_DuplicationLocation.DescribeBackupPolicy_Location location = new DescribeBackupPolicyResponse.DescribeBackupPolicy_DuplicationLocation.DescribeBackupPolicy_Location();
			location.Endpoint = context.StringValue("DescribeBackupPolicy.DuplicationLocation.Location.Endpoint");
			location.Bucket = context.StringValue("DescribeBackupPolicy.DuplicationLocation.Location.Bucket");
			duplicationLocation.Location = location;
			describeBackupPolicyResponse.DuplicationLocation = duplicationLocation;
        
			return describeBackupPolicyResponse;
        }
    }
}
