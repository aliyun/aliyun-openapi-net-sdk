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
    public class DescribeBackupsResponseUnmarshaller
    {
        public static DescribeBackupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupsResponse describeBackupsResponse = new DescribeBackupsResponse();

			describeBackupsResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupsResponse.TotalCount = _ctx.IntegerValue("DescribeBackups.TotalCount");
			describeBackupsResponse.RequestId = _ctx.StringValue("DescribeBackups.RequestId");
			describeBackupsResponse.PageSize = _ctx.IntegerValue("DescribeBackups.PageSize");
			describeBackupsResponse.PageNumber = _ctx.IntegerValue("DescribeBackups.PageNumber");

			List<DescribeBackupsResponse.DescribeBackups_Backup> describeBackupsResponse_backups = new List<DescribeBackupsResponse.DescribeBackups_Backup>();
			for (int i = 0; i < _ctx.Length("DescribeBackups.Backups.Length"); i++) {
				DescribeBackupsResponse.DescribeBackups_Backup backup = new DescribeBackupsResponse.DescribeBackups_Backup();
				backup.BackupStatus = _ctx.StringValue("DescribeBackups.Backups["+ i +"].BackupStatus");
				backup.BackupType = _ctx.StringValue("DescribeBackups.Backups["+ i +"].BackupType");
				backup.BackupStartTime = _ctx.StringValue("DescribeBackups.Backups["+ i +"].BackupStartTime");
				backup.BackupIntranetDownloadURL = _ctx.StringValue("DescribeBackups.Backups["+ i +"].BackupIntranetDownloadURL");
				backup.BackupSize = _ctx.LongValue("DescribeBackups.Backups["+ i +"].BackupSize");
				backup.BackupDownloadURL = _ctx.StringValue("DescribeBackups.Backups["+ i +"].BackupDownloadURL");
				backup.BackupMode = _ctx.StringValue("DescribeBackups.Backups["+ i +"].BackupMode");
				backup.BackupEndTime = _ctx.StringValue("DescribeBackups.Backups["+ i +"].BackupEndTime");
				backup.BackupId = _ctx.StringValue("DescribeBackups.Backups["+ i +"].BackupId");
				backup.BackupDBNames = _ctx.StringValue("DescribeBackups.Backups["+ i +"].BackupDBNames");
				backup.BackupMethod = _ctx.StringValue("DescribeBackups.Backups["+ i +"].BackupMethod");
				backup.BackupJobId = _ctx.StringValue("DescribeBackups.Backups["+ i +"].BackupJobId");
				backup.BackupName = _ctx.StringValue("DescribeBackups.Backups["+ i +"].BackupName");
				backup.BackupScale = _ctx.StringValue("DescribeBackups.Backups["+ i +"].BackupScale");
				backup.IsAvail = _ctx.BooleanValue("DescribeBackups.Backups["+ i +"].IsAvail");
				backup.EngineVersion = _ctx.StringValue("DescribeBackups.Backups["+ i +"].EngineVersion");

				describeBackupsResponse_backups.Add(backup);
			}
			describeBackupsResponse.Backups = describeBackupsResponse_backups;
        
			return describeBackupsResponse;
        }
    }
}
