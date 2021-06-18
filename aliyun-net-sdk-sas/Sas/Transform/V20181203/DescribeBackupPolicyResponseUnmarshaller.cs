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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeBackupPolicyResponseUnmarshaller
    {
        public static DescribeBackupPolicyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupPolicyResponse describeBackupPolicyResponse = new DescribeBackupPolicyResponse();

			describeBackupPolicyResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupPolicyResponse.RequestId = _ctx.StringValue("DescribeBackupPolicy.RequestId");

			DescribeBackupPolicyResponse.DescribeBackupPolicy_BackupPolicyDetail backupPolicyDetail = new DescribeBackupPolicyResponse.DescribeBackupPolicy_BackupPolicyDetail();
			backupPolicyDetail.Id = _ctx.LongValue("DescribeBackupPolicy.BackupPolicyDetail.Id");
			backupPolicyDetail.Name = _ctx.StringValue("DescribeBackupPolicy.BackupPolicyDetail.Name");
			backupPolicyDetail.Policy = _ctx.StringValue("DescribeBackupPolicy.BackupPolicyDetail.Policy");
			backupPolicyDetail.PolicyVersion = _ctx.StringValue("DescribeBackupPolicy.BackupPolicyDetail.PolicyVersion");
			backupPolicyDetail.RegionId = _ctx.StringValue("DescribeBackupPolicy.BackupPolicyDetail.RegionId");
			backupPolicyDetail.Status = _ctx.StringValue("DescribeBackupPolicy.BackupPolicyDetail.Status");
			backupPolicyDetail.ClientStatus = _ctx.StringValue("DescribeBackupPolicy.BackupPolicyDetail.ClientStatus");

			List<string> backupPolicyDetail_uuidList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeBackupPolicy.BackupPolicyDetail.UuidList.Length"); i++) {
				backupPolicyDetail_uuidList.Add(_ctx.StringValue("DescribeBackupPolicy.BackupPolicyDetail.UuidList["+ i +"]"));
			}
			backupPolicyDetail.UuidList = backupPolicyDetail_uuidList;
			describeBackupPolicyResponse.BackupPolicyDetail = backupPolicyDetail;
        
			return describeBackupPolicyResponse;
        }
    }
}
