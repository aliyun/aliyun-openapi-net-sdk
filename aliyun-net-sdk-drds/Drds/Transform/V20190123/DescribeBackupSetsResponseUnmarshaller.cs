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
    public class DescribeBackupSetsResponseUnmarshaller
    {
        public static DescribeBackupSetsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupSetsResponse describeBackupSetsResponse = new DescribeBackupSetsResponse();

			describeBackupSetsResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupSetsResponse.RequestId = _ctx.StringValue("DescribeBackupSets.RequestId");
			describeBackupSetsResponse.Success = _ctx.BooleanValue("DescribeBackupSets.Success");

			List<DescribeBackupSetsResponse.DescribeBackupSets_BackupSet> describeBackupSetsResponse_backupSets = new List<DescribeBackupSetsResponse.DescribeBackupSets_BackupSet>();
			for (int i = 0; i < _ctx.Length("DescribeBackupSets.BackupSets.Length"); i++) {
				DescribeBackupSetsResponse.DescribeBackupSets_BackupSet backupSet = new DescribeBackupSetsResponse.DescribeBackupSets_BackupSet();
				backupSet.Id = _ctx.StringValue("DescribeBackupSets.BackupSets["+ i +"].Id");
				backupSet.BackupStartTime = _ctx.LongValue("DescribeBackupSets.BackupSets["+ i +"].BackupStartTime");
				backupSet.BackupEndTime = _ctx.LongValue("DescribeBackupSets.BackupSets["+ i +"].BackupEndTime");
				backupSet.BackupMode = _ctx.StringValue("DescribeBackupSets.BackupSets["+ i +"].BackupMode");
				backupSet.BackupLevel = _ctx.StringValue("DescribeBackupSets.BackupSets["+ i +"].BackupLevel");
				backupSet.BackupType = _ctx.StringValue("DescribeBackupSets.BackupSets["+ i +"].BackupType");
				backupSet.Status = _ctx.LongValue("DescribeBackupSets.BackupSets["+ i +"].Status");
				backupSet.EnableRecovery = _ctx.BooleanValue("DescribeBackupSets.BackupSets["+ i +"].EnableRecovery");
				backupSet.BackupTotalSize = _ctx.StringValue("DescribeBackupSets.BackupSets["+ i +"].BackupTotalSize");
				backupSet.BackupConsitentTime = _ctx.StringValue("DescribeBackupSets.BackupSets["+ i +"].BackupConsitentTime");

				List<string> backupSet_backupDbs = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeBackupSets.BackupSets["+ i +"].BackupDbs.Length"); j++) {
					backupSet_backupDbs.Add(_ctx.StringValue("DescribeBackupSets.BackupSets["+ i +"].BackupDbs["+ j +"]"));
				}
				backupSet.BackupDbs = backupSet_backupDbs;

				describeBackupSetsResponse_backupSets.Add(backupSet);
			}
			describeBackupSetsResponse.BackupSets = describeBackupSetsResponse_backupSets;
        
			return describeBackupSetsResponse;
        }
    }
}
