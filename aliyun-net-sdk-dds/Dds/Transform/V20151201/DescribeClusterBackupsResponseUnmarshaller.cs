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
    public class DescribeClusterBackupsResponseUnmarshaller
    {
        public static DescribeClusterBackupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeClusterBackupsResponse describeClusterBackupsResponse = new DescribeClusterBackupsResponse();

			describeClusterBackupsResponse.HttpResponse = _ctx.HttpResponse;
			describeClusterBackupsResponse.RequestId = _ctx.StringValue("DescribeClusterBackups.RequestId");
			describeClusterBackupsResponse.MaxResults = _ctx.IntegerValue("DescribeClusterBackups.MaxResults");
			describeClusterBackupsResponse.PageNumber = _ctx.IntegerValue("DescribeClusterBackups.PageNumber");
			describeClusterBackupsResponse.PageSize = _ctx.IntegerValue("DescribeClusterBackups.PageSize");

			List<DescribeClusterBackupsResponse.DescribeClusterBackups_ClusterBackup> describeClusterBackupsResponse_clusterBackups = new List<DescribeClusterBackupsResponse.DescribeClusterBackups_ClusterBackup>();
			for (int i = 0; i < _ctx.Length("DescribeClusterBackups.ClusterBackups.Length"); i++) {
				DescribeClusterBackupsResponse.DescribeClusterBackups_ClusterBackup clusterBackup = new DescribeClusterBackupsResponse.DescribeClusterBackups_ClusterBackup();
				clusterBackup.IsAvail = _ctx.IntegerValue("DescribeClusterBackups.ClusterBackups["+ i +"].IsAvail");
				clusterBackup.ClusterBackupId = _ctx.StringValue("DescribeClusterBackups.ClusterBackups["+ i +"].ClusterBackupId");
				clusterBackup.ClusterBackupStatus = _ctx.StringValue("DescribeClusterBackups.ClusterBackups["+ i +"].ClusterBackupStatus");
				clusterBackup.ClusterBackupStartTime = _ctx.StringValue("DescribeClusterBackups.ClusterBackups["+ i +"].ClusterBackupStartTime");
				clusterBackup.ClusterBackupSize = _ctx.StringValue("DescribeClusterBackups.ClusterBackups["+ i +"].ClusterBackupSize");
				clusterBackup.ClusterBackupEndTime = _ctx.StringValue("DescribeClusterBackups.ClusterBackups["+ i +"].ClusterBackupEndTime");
				clusterBackup.ClusterBackupMode = _ctx.StringValue("DescribeClusterBackups.ClusterBackups["+ i +"].ClusterBackupMode");
				clusterBackup.Progress = _ctx.StringValue("DescribeClusterBackups.ClusterBackups["+ i +"].Progress");
				clusterBackup.AttachLogStatus = _ctx.StringValue("DescribeClusterBackups.ClusterBackups["+ i +"].AttachLogStatus");
				clusterBackup.EngineVersion = _ctx.StringValue("DescribeClusterBackups.ClusterBackups["+ i +"].EngineVersion");
				clusterBackup.BackupExpireTime = _ctx.StringValue("DescribeClusterBackups.ClusterBackups["+ i +"].BackupExpireTime");

				DescribeClusterBackupsResponse.DescribeClusterBackups_ClusterBackup.DescribeClusterBackups_ExtraInfo extraInfo = new DescribeClusterBackupsResponse.DescribeClusterBackups_ClusterBackup.DescribeClusterBackups_ExtraInfo();
				extraInfo.RegistryFromHistory = _ctx.StringValue("DescribeClusterBackups.ClusterBackups["+ i +"].ExtraInfo.RegistryFromHistory");
				clusterBackup.ExtraInfo = extraInfo;

				List<DescribeClusterBackupsResponse.DescribeClusterBackups_ClusterBackup.DescribeClusterBackups_Backup> clusterBackup_backups = new List<DescribeClusterBackupsResponse.DescribeClusterBackups_ClusterBackup.DescribeClusterBackups_Backup>();
				for (int j = 0; j < _ctx.Length("DescribeClusterBackups.ClusterBackups["+ i +"].Backups.Length"); j++) {
					DescribeClusterBackupsResponse.DescribeClusterBackups_ClusterBackup.DescribeClusterBackups_Backup backup = new DescribeClusterBackupsResponse.DescribeClusterBackups_ClusterBackup.DescribeClusterBackups_Backup();
					backup.BackupId = _ctx.StringValue("DescribeClusterBackups.ClusterBackups["+ i +"].Backups["+ j +"].BackupId");
					backup.InstanceName = _ctx.StringValue("DescribeClusterBackups.ClusterBackups["+ i +"].Backups["+ j +"].InstanceName");
					backup.BackupDownloadURL = _ctx.StringValue("DescribeClusterBackups.ClusterBackups["+ i +"].Backups["+ j +"].BackupDownloadURL");
					backup.BackupIntranetDownloadURL = _ctx.StringValue("DescribeClusterBackups.ClusterBackups["+ i +"].Backups["+ j +"].BackupIntranetDownloadURL");
					backup.BackupStartTime = _ctx.StringValue("DescribeClusterBackups.ClusterBackups["+ i +"].Backups["+ j +"].BackupStartTime");
					backup.BackupEndTime = _ctx.StringValue("DescribeClusterBackups.ClusterBackups["+ i +"].Backups["+ j +"].BackupEndTime");
					backup.BackupSize = _ctx.StringValue("DescribeClusterBackups.ClusterBackups["+ i +"].Backups["+ j +"].BackupSize");
					backup.IsAvail = _ctx.StringValue("DescribeClusterBackups.ClusterBackups["+ i +"].Backups["+ j +"].IsAvail");
					backup.BackupStatus = _ctx.StringValue("DescribeClusterBackups.ClusterBackups["+ i +"].Backups["+ j +"].BackupStatus");
					backup.BackupName = _ctx.StringValue("DescribeClusterBackups.ClusterBackups["+ i +"].Backups["+ j +"].BackupName");

					DescribeClusterBackupsResponse.DescribeClusterBackups_ClusterBackup.DescribeClusterBackups_Backup.DescribeClusterBackups_ExtraInfo1 extraInfo1 = new DescribeClusterBackupsResponse.DescribeClusterBackups_ClusterBackup.DescribeClusterBackups_Backup.DescribeClusterBackups_ExtraInfo1();
					extraInfo1.NodeId = _ctx.StringValue("DescribeClusterBackups.ClusterBackups["+ i +"].Backups["+ j +"].ExtraInfo.NodeId");
					extraInfo1.StorageSize = _ctx.StringValue("DescribeClusterBackups.ClusterBackups["+ i +"].Backups["+ j +"].ExtraInfo.StorageSize");
					extraInfo1.InstanceClass = _ctx.StringValue("DescribeClusterBackups.ClusterBackups["+ i +"].Backups["+ j +"].ExtraInfo.InstanceClass");
					extraInfo1.NodeType = _ctx.StringValue("DescribeClusterBackups.ClusterBackups["+ i +"].Backups["+ j +"].ExtraInfo.NodeType");
					backup.ExtraInfo1 = extraInfo1;

					clusterBackup_backups.Add(backup);
				}
				clusterBackup.Backups = clusterBackup_backups;

				describeClusterBackupsResponse_clusterBackups.Add(clusterBackup);
			}
			describeClusterBackupsResponse.ClusterBackups = describeClusterBackupsResponse_clusterBackups;
        
			return describeClusterBackupsResponse;
        }
    }
}
