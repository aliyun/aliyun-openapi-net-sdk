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
			describeBackupsResponse.TotalEcsSnapshotSize = _ctx.LongValue("DescribeBackups.TotalEcsSnapshotSize");
			describeBackupsResponse.PageRecordCount = _ctx.StringValue("DescribeBackups.PageRecordCount");
			describeBackupsResponse.TotalRecordCount = _ctx.StringValue("DescribeBackups.TotalRecordCount");
			describeBackupsResponse.TotalBackupSize = _ctx.LongValue("DescribeBackups.TotalBackupSize");
			describeBackupsResponse.PageNumber = _ctx.StringValue("DescribeBackups.PageNumber");

			List<DescribeBackupsResponse.DescribeBackups_Backup> describeBackupsResponse_items = new List<DescribeBackupsResponse.DescribeBackups_Backup>();
			for (int i = 0; i < _ctx.Length("DescribeBackups.Items.Length"); i++) {
				DescribeBackupsResponse.DescribeBackups_Backup backup = new DescribeBackupsResponse.DescribeBackups_Backup();
				backup.StorageClass = _ctx.StringValue("DescribeBackups.Items["+ i +"].StorageClass");
				backup.Encryption = _ctx.StringValue("DescribeBackups.Items["+ i +"].Encryption");
				backup.BackupStatus = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupStatus");
				backup.StoreStatus = _ctx.StringValue("DescribeBackups.Items["+ i +"].StoreStatus");
				backup.ConsistentTime = _ctx.LongValue("DescribeBackups.Items["+ i +"].ConsistentTime");
				backup.BackupType = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupType");
				backup.CopyOnlyBackup = _ctx.StringValue("DescribeBackups.Items["+ i +"].CopyOnlyBackup");
				backup.BackupEndTime = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupEndTime");
				backup.MetaStatus = _ctx.StringValue("DescribeBackups.Items["+ i +"].MetaStatus");
				backup.BackupScale = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupScale");
				backup.BackupInitiator = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupInitiator");
				backup.BackupIntranetDownloadURL = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupIntranetDownloadURL");
				backup.BackupMethod = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupMethod");
				backup.SlaveStatus = _ctx.StringValue("DescribeBackups.Items["+ i +"].SlaveStatus");
				backup.BackupStartTime = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupStartTime");
				backup.BackupLocation = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupLocation");
				backup.TotalBackupSize = _ctx.LongValue("DescribeBackups.Items["+ i +"].TotalBackupSize");
				backup.BackupDownloadURL = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupDownloadURL");
				backup.IsAvail = _ctx.IntegerValue("DescribeBackups.Items["+ i +"].IsAvail");
				backup.BackupId = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupId");
				backup.BackupDBNames = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupDBNames");
				backup.HostInstanceID = _ctx.StringValue("DescribeBackups.Items["+ i +"].HostInstanceID");
				backup.BackupSize = _ctx.LongValue("DescribeBackups.Items["+ i +"].BackupSize");
				backup.BackupMode = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupMode");
				backup.DBInstanceId = _ctx.StringValue("DescribeBackups.Items["+ i +"].DBInstanceId");
				backup.BackupExtractionStatus = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupExtractionStatus");
				backup.Checksum = _ctx.StringValue("DescribeBackups.Items["+ i +"].Checksum");

				List<DescribeBackupsResponse.DescribeBackups_Backup.DescribeBackups_BackupDownloadLinkByDBItem> backup_backupDownloadLinkByDB = new List<DescribeBackupsResponse.DescribeBackups_Backup.DescribeBackups_BackupDownloadLinkByDBItem>();
				for (int j = 0; j < _ctx.Length("DescribeBackups.Items["+ i +"].BackupDownloadLinkByDB.Length"); j++) {
					DescribeBackupsResponse.DescribeBackups_Backup.DescribeBackups_BackupDownloadLinkByDBItem backupDownloadLinkByDBItem = new DescribeBackupsResponse.DescribeBackups_Backup.DescribeBackups_BackupDownloadLinkByDBItem();
					backupDownloadLinkByDBItem.IntranetDownloadLink = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupDownloadLinkByDB["+ j +"].IntranetDownloadLink");
					backupDownloadLinkByDBItem.DataBase = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupDownloadLinkByDB["+ j +"].DataBase");
					backupDownloadLinkByDBItem.DownloadLink = _ctx.StringValue("DescribeBackups.Items["+ i +"].BackupDownloadLinkByDB["+ j +"].DownloadLink");

					backup_backupDownloadLinkByDB.Add(backupDownloadLinkByDBItem);
				}
				backup.BackupDownloadLinkByDB = backup_backupDownloadLinkByDB;

				describeBackupsResponse_items.Add(backup);
			}
			describeBackupsResponse.Items = describeBackupsResponse_items;
        
			return describeBackupsResponse;
        }
    }
}
