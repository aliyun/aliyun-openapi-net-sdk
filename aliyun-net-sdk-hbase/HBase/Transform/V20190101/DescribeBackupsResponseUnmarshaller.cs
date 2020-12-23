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
using Aliyun.Acs.HBase.Model.V20190101;

namespace Aliyun.Acs.HBase.Transform.V20190101
{
    public class DescribeBackupsResponseUnmarshaller
    {
        public static DescribeBackupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupsResponse describeBackupsResponse = new DescribeBackupsResponse();

			describeBackupsResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupsResponse.RequestId = _ctx.StringValue("DescribeBackups.RequestId");
			describeBackupsResponse.EnableStatus = _ctx.StringValue("DescribeBackups.EnableStatus");
			describeBackupsResponse.PageNumber = _ctx.IntegerValue("DescribeBackups.PageNumber");
			describeBackupsResponse.PageSize = _ctx.IntegerValue("DescribeBackups.PageSize");
			describeBackupsResponse.TotalCount = _ctx.IntegerValue("DescribeBackups.TotalCount");

			List<DescribeBackupsResponse.DescribeBackups_Backup> describeBackupsResponse_backups = new List<DescribeBackupsResponse.DescribeBackups_Backup>();
			for (int i = 0; i < _ctx.Length("DescribeBackups.Backups.Length"); i++) {
				DescribeBackupsResponse.DescribeBackups_Backup backup = new DescribeBackupsResponse.DescribeBackups_Backup();
				backup.BackupDBNames = _ctx.StringValue("DescribeBackups.Backups["+ i +"].BackupDBNames");
				backup.BackupId = _ctx.IntegerValue("DescribeBackups.Backups["+ i +"].BackupId");
				backup.BackupStatus = _ctx.StringValue("DescribeBackups.Backups["+ i +"].BackupStatus");
				backup.BackupStartTime = _ctx.StringValue("DescribeBackups.Backups["+ i +"].BackupStartTime");
				backup.BackupEndTime = _ctx.StringValue("DescribeBackups.Backups["+ i +"].BackupEndTime");
				backup.BackupType = _ctx.StringValue("DescribeBackups.Backups["+ i +"].BackupType");
				backup.BackupMode = _ctx.StringValue("DescribeBackups.Backups["+ i +"].BackupMode");
				backup.BackupMethod = _ctx.StringValue("DescribeBackups.Backups["+ i +"].BackupMethod");
				backup.BackupDownloadURL = _ctx.StringValue("DescribeBackups.Backups["+ i +"].BackupDownloadURL");
				backup.BackupSize = _ctx.StringValue("DescribeBackups.Backups["+ i +"].BackupSize");
				backup.BackupStartTimeUTC = _ctx.StringValue("DescribeBackups.Backups["+ i +"].BackupStartTimeUTC");
				backup.BackupEndTimeUTC = _ctx.StringValue("DescribeBackups.Backups["+ i +"].BackupEndTimeUTC");

				describeBackupsResponse_backups.Add(backup);
			}
			describeBackupsResponse.Backups = describeBackupsResponse_backups;
        
			return describeBackupsResponse;
        }
    }
}
