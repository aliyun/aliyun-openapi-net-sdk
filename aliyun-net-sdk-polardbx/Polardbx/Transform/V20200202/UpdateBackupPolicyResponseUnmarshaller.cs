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
    public class UpdateBackupPolicyResponseUnmarshaller
    {
        public static UpdateBackupPolicyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateBackupPolicyResponse updateBackupPolicyResponse = new UpdateBackupPolicyResponse();

			updateBackupPolicyResponse.HttpResponse = _ctx.HttpResponse;
			updateBackupPolicyResponse.Message = _ctx.StringValue("UpdateBackupPolicy.Message");
			updateBackupPolicyResponse.RequestId = _ctx.StringValue("UpdateBackupPolicy.RequestId");
			updateBackupPolicyResponse.Success = _ctx.BooleanValue("UpdateBackupPolicy.Success");

			List<UpdateBackupPolicyResponse.UpdateBackupPolicy_Account> updateBackupPolicyResponse_data = new List<UpdateBackupPolicyResponse.UpdateBackupPolicy_Account>();
			for (int i = 0; i < _ctx.Length("UpdateBackupPolicy.Data.Length"); i++) {
				UpdateBackupPolicyResponse.UpdateBackupPolicy_Account account = new UpdateBackupPolicyResponse.UpdateBackupPolicy_Account();
				account.LogLocalRetentionSpace = _ctx.IntegerValue("UpdateBackupPolicy.Data["+ i +"].LogLocalRetentionSpace");
				account.DBInstanceName = _ctx.StringValue("UpdateBackupPolicy.Data["+ i +"].DBInstanceName");
				account.BackupWay = _ctx.StringValue("UpdateBackupPolicy.Data["+ i +"].BackupWay");
				account.BackupPeriod = _ctx.StringValue("UpdateBackupPolicy.Data["+ i +"].BackupPeriod");
				account.ForceCleanOnHighSpaceUsage = _ctx.IntegerValue("UpdateBackupPolicy.Data["+ i +"].ForceCleanOnHighSpaceUsage");
				account.BackupType = _ctx.StringValue("UpdateBackupPolicy.Data["+ i +"].BackupType");
				account.LocalLogRetention = _ctx.IntegerValue("UpdateBackupPolicy.Data["+ i +"].LocalLogRetention");
				account.RemoveLogRetention = _ctx.IntegerValue("UpdateBackupPolicy.Data["+ i +"].RemoveLogRetention");
				account.BackupPlanBegin = _ctx.StringValue("UpdateBackupPolicy.Data["+ i +"].BackupPlanBegin");
				account.BackupSetRetention = _ctx.IntegerValue("UpdateBackupPolicy.Data["+ i +"].BackupSetRetention");
				account.IsEnabled = _ctx.IntegerValue("UpdateBackupPolicy.Data["+ i +"].IsEnabled");
				account.ColdDataBackupInterval = _ctx.IntegerValue("UpdateBackupPolicy.Data["+ i +"].ColdDataBackupInterval");
				account.ColdDataBackupRetention = _ctx.IntegerValue("UpdateBackupPolicy.Data["+ i +"].ColdDataBackupRetention");
				account.LocalLogRetentionNumber = _ctx.IntegerValue("UpdateBackupPolicy.Data["+ i +"].LocalLogRetentionNumber");
				account.IsCrossRegionDataBackupEnabled = _ctx.BooleanValue("UpdateBackupPolicy.Data["+ i +"].IsCrossRegionDataBackupEnabled");
				account.IsCrossRegionLogBackupEnabled = _ctx.BooleanValue("UpdateBackupPolicy.Data["+ i +"].IsCrossRegionLogBackupEnabled");
				account.DestCrossRegion = _ctx.StringValue("UpdateBackupPolicy.Data["+ i +"].DestCrossRegion");
				account.CrossRegionDataBackupRetention = _ctx.IntegerValue("UpdateBackupPolicy.Data["+ i +"].CrossRegionDataBackupRetention");
				account.CrossRegionLogBackupRetention = _ctx.IntegerValue("UpdateBackupPolicy.Data["+ i +"].CrossRegionLogBackupRetention");

				updateBackupPolicyResponse_data.Add(account);
			}
			updateBackupPolicyResponse.Data = updateBackupPolicyResponse_data;
        
			return updateBackupPolicyResponse;
        }
    }
}
