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
using Aliyun.Acs.polardbx.Model.V20200202;

namespace Aliyun.Acs.polardbx.Transform.V20200202
{
    public class DescribeBackupPolicyResponseUnmarshaller
    {
        public static DescribeBackupPolicyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupPolicyResponse describeBackupPolicyResponse = new DescribeBackupPolicyResponse();

			describeBackupPolicyResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupPolicyResponse.Message = _ctx.StringValue("DescribeBackupPolicy.Message");
			describeBackupPolicyResponse.RequestId = _ctx.StringValue("DescribeBackupPolicy.RequestId");
			describeBackupPolicyResponse.Success = _ctx.BooleanValue("DescribeBackupPolicy.Success");

			List<DescribeBackupPolicyResponse.DescribeBackupPolicy_Account> describeBackupPolicyResponse_data = new List<DescribeBackupPolicyResponse.DescribeBackupPolicy_Account>();
			for (int i = 0; i < _ctx.Length("DescribeBackupPolicy.Data.Length"); i++) {
				DescribeBackupPolicyResponse.DescribeBackupPolicy_Account account = new DescribeBackupPolicyResponse.DescribeBackupPolicy_Account();
				account.LogLocalRetentionSpace = _ctx.IntegerValue("DescribeBackupPolicy.Data["+ i +"].LogLocalRetentionSpace");
				account.DBInstanceName = _ctx.StringValue("DescribeBackupPolicy.Data["+ i +"].DBInstanceName");
				account.BackupWay = _ctx.StringValue("DescribeBackupPolicy.Data["+ i +"].BackupWay");
				account.BackupPeriod = _ctx.StringValue("DescribeBackupPolicy.Data["+ i +"].BackupPeriod");
				account.ForceCleanOnHighSpaceUsage = _ctx.IntegerValue("DescribeBackupPolicy.Data["+ i +"].ForceCleanOnHighSpaceUsage");
				account.BackupType = _ctx.StringValue("DescribeBackupPolicy.Data["+ i +"].BackupType");
				account.LocalLogRetention = _ctx.IntegerValue("DescribeBackupPolicy.Data["+ i +"].LocalLogRetention");
				account.RemoveLogRetention = _ctx.IntegerValue("DescribeBackupPolicy.Data["+ i +"].RemoveLogRetention");
				account.BackupPlanBegin = _ctx.StringValue("DescribeBackupPolicy.Data["+ i +"].BackupPlanBegin");
				account.BackupSetRetention = _ctx.IntegerValue("DescribeBackupPolicy.Data["+ i +"].BackupSetRetention");
				account.IsEnabled = _ctx.IntegerValue("DescribeBackupPolicy.Data["+ i +"].IsEnabled");
				account.ColdDataBackupInterval = _ctx.IntegerValue("DescribeBackupPolicy.Data["+ i +"].ColdDataBackupInterval");
				account.ColdDataBackupRetention = _ctx.IntegerValue("DescribeBackupPolicy.Data["+ i +"].ColdDataBackupRetention");
				account.LocalLogRetentionNumber = _ctx.IntegerValue("DescribeBackupPolicy.Data["+ i +"].LocalLogRetentionNumber");
				account.IsCrossRegionDataBackupEnabled = _ctx.BooleanValue("DescribeBackupPolicy.Data["+ i +"].IsCrossRegionDataBackupEnabled");
				account.IsCrossRegionLogBackupEnabled = _ctx.BooleanValue("DescribeBackupPolicy.Data["+ i +"].IsCrossRegionLogBackupEnabled");
				account.DestCrossRegion = _ctx.StringValue("DescribeBackupPolicy.Data["+ i +"].DestCrossRegion");
				account.CrossRegionDataBackupRetention = _ctx.IntegerValue("DescribeBackupPolicy.Data["+ i +"].CrossRegionDataBackupRetention");
				account.CrossRegionLogBackupRetention = _ctx.IntegerValue("DescribeBackupPolicy.Data["+ i +"].CrossRegionLogBackupRetention");

				describeBackupPolicyResponse_data.Add(account);
			}
			describeBackupPolicyResponse.Data = describeBackupPolicyResponse_data;
        
			return describeBackupPolicyResponse;
        }
    }
}
