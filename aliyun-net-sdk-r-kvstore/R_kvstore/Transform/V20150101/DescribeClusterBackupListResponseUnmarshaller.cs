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
using Aliyun.Acs.R_kvstore.Model.V20150101;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeClusterBackupListResponseUnmarshaller
    {
        public static DescribeClusterBackupListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeClusterBackupListResponse describeClusterBackupListResponse = new DescribeClusterBackupListResponse();

			describeClusterBackupListResponse.HttpResponse = _ctx.HttpResponse;
			describeClusterBackupListResponse.RequestId = _ctx.StringValue("DescribeClusterBackupList.RequestId");
			describeClusterBackupListResponse.MaxResults = _ctx.IntegerValue("DescribeClusterBackupList.MaxResults");
			describeClusterBackupListResponse.PageNumber = _ctx.IntegerValue("DescribeClusterBackupList.PageNumber");
			describeClusterBackupListResponse.PageSize = _ctx.IntegerValue("DescribeClusterBackupList.PageSize");

			List<DescribeClusterBackupListResponse.DescribeClusterBackupList_ClusterBackup> describeClusterBackupListResponse_clusterBackups = new List<DescribeClusterBackupListResponse.DescribeClusterBackupList_ClusterBackup>();
			for (int i = 0; i < _ctx.Length("DescribeClusterBackupList.ClusterBackups.Length"); i++) {
				DescribeClusterBackupListResponse.DescribeClusterBackupList_ClusterBackup clusterBackup = new DescribeClusterBackupListResponse.DescribeClusterBackupList_ClusterBackup();
				clusterBackup.IsAvail = _ctx.IntegerValue("DescribeClusterBackupList.ClusterBackups["+ i +"].IsAvail");
				clusterBackup.ClusterBackupId = _ctx.StringValue("DescribeClusterBackupList.ClusterBackups["+ i +"].ClusterBackupId");
				clusterBackup.ClusterBackupStatus = _ctx.StringValue("DescribeClusterBackupList.ClusterBackups["+ i +"].ClusterBackupStatus");
				clusterBackup.ClusterBackupSize = _ctx.StringValue("DescribeClusterBackupList.ClusterBackups["+ i +"].ClusterBackupSize");
				clusterBackup.ClusterBackupStartTime = _ctx.StringValue("DescribeClusterBackupList.ClusterBackups["+ i +"].ClusterBackupStartTime");
				clusterBackup.ClusterBackupEndTime = _ctx.StringValue("DescribeClusterBackupList.ClusterBackups["+ i +"].ClusterBackupEndTime");
				clusterBackup.ClusterBackupMode = _ctx.StringValue("DescribeClusterBackupList.ClusterBackups["+ i +"].ClusterBackupMode");
				clusterBackup.ShardClassMemory = _ctx.IntegerValue("DescribeClusterBackupList.ClusterBackups["+ i +"].ShardClassMemory");
				clusterBackup.Progress = _ctx.StringValue("DescribeClusterBackupList.ClusterBackups["+ i +"].Progress");

				DescribeClusterBackupListResponse.DescribeClusterBackupList_ClusterBackup.DescribeClusterBackupList_ExtraInfo extraInfo = new DescribeClusterBackupListResponse.DescribeClusterBackupList_ClusterBackup.DescribeClusterBackupList_ExtraInfo();
				extraInfo.RegistryFromHistory = _ctx.StringValue("DescribeClusterBackupList.ClusterBackups["+ i +"].ExtraInfo.RegistryFromHistory");
				clusterBackup.ExtraInfo = extraInfo;

				List<DescribeClusterBackupListResponse.DescribeClusterBackupList_ClusterBackup.DescribeClusterBackupList_Backup> clusterBackup_backups = new List<DescribeClusterBackupListResponse.DescribeClusterBackupList_ClusterBackup.DescribeClusterBackupList_Backup>();
				for (int j = 0; j < _ctx.Length("DescribeClusterBackupList.ClusterBackups["+ i +"].Backups.Length"); j++) {
					DescribeClusterBackupListResponse.DescribeClusterBackupList_ClusterBackup.DescribeClusterBackupList_Backup backup = new DescribeClusterBackupListResponse.DescribeClusterBackupList_ClusterBackup.DescribeClusterBackupList_Backup();
					backup.BackupId = _ctx.StringValue("DescribeClusterBackupList.ClusterBackups["+ i +"].Backups["+ j +"].BackupId");
					backup.InstanceName = _ctx.StringValue("DescribeClusterBackupList.ClusterBackups["+ i +"].Backups["+ j +"].InstanceName");
					backup.BackupDownloadURL = _ctx.StringValue("DescribeClusterBackupList.ClusterBackups["+ i +"].Backups["+ j +"].BackupDownloadURL");
					backup.BackupIntranetDownloadURL = _ctx.StringValue("DescribeClusterBackupList.ClusterBackups["+ i +"].Backups["+ j +"].BackupIntranetDownloadURL");
					backup.BackupStartTime = _ctx.StringValue("DescribeClusterBackupList.ClusterBackups["+ i +"].Backups["+ j +"].BackupStartTime");
					backup.BackupEndTime = _ctx.StringValue("DescribeClusterBackupList.ClusterBackups["+ i +"].Backups["+ j +"].BackupEndTime");
					backup.BackupSize = _ctx.StringValue("DescribeClusterBackupList.ClusterBackups["+ i +"].Backups["+ j +"].BackupSize");
					backup.IsAvail = _ctx.StringValue("DescribeClusterBackupList.ClusterBackups["+ i +"].Backups["+ j +"].IsAvail");
					backup.BackupStatus = _ctx.StringValue("DescribeClusterBackupList.ClusterBackups["+ i +"].Backups["+ j +"].BackupStatus");
					backup.BackupName = _ctx.StringValue("DescribeClusterBackupList.ClusterBackups["+ i +"].Backups["+ j +"].BackupName");
					backup.Engine = _ctx.StringValue("DescribeClusterBackupList.ClusterBackups["+ i +"].Backups["+ j +"].Engine");

					DescribeClusterBackupListResponse.DescribeClusterBackupList_ClusterBackup.DescribeClusterBackupList_Backup.DescribeClusterBackupList_ExtraInfo1 extraInfo1 = new DescribeClusterBackupListResponse.DescribeClusterBackupList_ClusterBackup.DescribeClusterBackupList_Backup.DescribeClusterBackupList_ExtraInfo1();
					extraInfo1.CustinsLevelId = _ctx.IntegerValue("DescribeClusterBackupList.ClusterBackups["+ i +"].Backups["+ j +"].ExtraInfo.CustinsLevelId");
					extraInfo1.CustinsDbVersion = _ctx.StringValue("DescribeClusterBackupList.ClusterBackups["+ i +"].Backups["+ j +"].ExtraInfo.CustinsDbVersion");
					extraInfo1.CustinsName = _ctx.StringValue("DescribeClusterBackupList.ClusterBackups["+ i +"].Backups["+ j +"].ExtraInfo.CustinsName");
					extraInfo1.CustinsId = _ctx.IntegerValue("DescribeClusterBackupList.ClusterBackups["+ i +"].Backups["+ j +"].ExtraInfo.CustinsId");
					backup.ExtraInfo1 = extraInfo1;

					clusterBackup_backups.Add(backup);
				}
				clusterBackup.Backups = clusterBackup_backups;

				describeClusterBackupListResponse_clusterBackups.Add(clusterBackup);
			}
			describeClusterBackupListResponse.ClusterBackups = describeClusterBackupListResponse_clusterBackups;
        
			return describeClusterBackupListResponse;
        }
    }
}
