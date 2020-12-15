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
    public class DescribeBackupsResponseUnmarshaller
    {
        public static DescribeBackupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupsResponse describeBackupsResponse = new DescribeBackupsResponse();

			describeBackupsResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupsResponse.RequestId = _ctx.StringValue("DescribeBackups.RequestId");
			describeBackupsResponse.TotalRecordCount = _ctx.StringValue("DescribeBackups.TotalRecordCount");
			describeBackupsResponse.PageNumber = _ctx.StringValue("DescribeBackups.PageNumber");
			describeBackupsResponse.PageRecordCount = _ctx.StringValue("DescribeBackups.PageRecordCount");
			describeBackupsResponse.TotalBackupSize = _ctx.LongValue("DescribeBackups.TotalBackupSize");
			describeBackupsResponse.TotalEcsSnapshotSize = _ctx.LongValue("DescribeBackups.TotalEcsSnapshotSize");

			List<DescribeBackupsResponse.DescribeBackups_Backup> describeBackupsResponse_items = new List<DescribeBackupsResponse.DescribeBackups_Backup>();
			for (int i = 0; i < _ctx.Length("DescribeBackups.Items.Length"); i++) {
				DescribeBackupsResponse.DescribeBackups_Backup backup = new DescribeBackupsResponse.DescribeBackups_Backup();
				backup.BackupId = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupId");
				backup.DBInstanceId = _ctx.StringValue("DescribeBackups.Items["+ i +"].DBInstanceId");
				backup.BackupStatus = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupStatus");
				backup.BackupStartTime = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupStartTime");
				backup.BackupEndTime = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupEndTime");
				backup.BackupType = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupType");
				backup.BackupMode = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupMode");
				backup.BackupMethod = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupMethod");
				backup.BackupDownloadURL = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupDownloadURL");
				backup.BackupIntranetDownloadURL = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupIntranetDownloadURL");
				backup.BackupLocation = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupLocation");
				backup.BackupExtractionStatus = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupExtractionStatus");
				backup.BackupScale = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupScale");
				backup.BackupDBNames = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupDBNames");
				backup.TotalBackupSize = _ctx.LongValue("DescribeBackups.Items["+ i +"].TotalBackupSize");
				backup.BackupSize = _ctx.LongValue("DescribeBackups.Items["+ i +"].BackupSize");
				backup.HostInstanceID = _ctx.StringValue("DescribeBackups.Items["+ i +"].HostInstanceID");
				backup.StoreStatus = _ctx.StringValue("DescribeBackups.Items["+ i +"].StoreStatus");
				backup.MetaStatus = _ctx.StringValue("DescribeBackups.Items["+ i +"].MetaStatus");
				backup.SlaveStatus = _ctx.StringValue("DescribeBackups.Items["+ i +"].SlaveStatus");
				backup.ConsistentTime = _ctx.LongValue("DescribeBackups.Items["+ i +"].ConsistentTime");
				backup.BackupInitiator = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupInitiator");
				backup.CopyOnlyBackup = _ctx.StringValue("DescribeBackups.Items["+ i +"].CopyOnlyBackup");
				backup.StorageClass = _ctx.StringValue("DescribeBackups.Items["+ i +"].StorageClass");
				backup.IsAvail = _ctx.IntegerValue("DescribeBackups.Items["+ i +"].IsAvail");
				backup.Encryption = _ctx.StringValue("DescribeBackups.Items["+ i +"].Encryption");

				describeBackupsResponse_items.Add(backup);
			}
			describeBackupsResponse.Items = describeBackupsResponse_items;
        
			return describeBackupsResponse;
        }
    }
}
