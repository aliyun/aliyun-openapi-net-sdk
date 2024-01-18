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
    public class DescribeBackupTasksResponseUnmarshaller
    {
        public static DescribeBackupTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupTasksResponse describeBackupTasksResponse = new DescribeBackupTasksResponse();

			describeBackupTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupTasksResponse.InstanceId = _ctx.StringValue("DescribeBackupTasks.InstanceId");
			describeBackupTasksResponse.RequestId = _ctx.StringValue("DescribeBackupTasks.RequestId");

			DescribeBackupTasksResponse.DescribeBackupTasks_AccessDeniedDetail accessDeniedDetail = new DescribeBackupTasksResponse.DescribeBackupTasks_AccessDeniedDetail();
			accessDeniedDetail.AuthAction = _ctx.StringValue("DescribeBackupTasks.AccessDeniedDetail.AuthAction");
			accessDeniedDetail.AuthPrincipalDisplayName = _ctx.StringValue("DescribeBackupTasks.AccessDeniedDetail.AuthPrincipalDisplayName");
			accessDeniedDetail.AuthPrincipalOwnerId = _ctx.StringValue("DescribeBackupTasks.AccessDeniedDetail.AuthPrincipalOwnerId");
			accessDeniedDetail.AuthPrincipalType = _ctx.StringValue("DescribeBackupTasks.AccessDeniedDetail.AuthPrincipalType");
			accessDeniedDetail.EncodedDiagnosticMessage = _ctx.StringValue("DescribeBackupTasks.AccessDeniedDetail.EncodedDiagnosticMessage");
			accessDeniedDetail.NoPermissionType = _ctx.StringValue("DescribeBackupTasks.AccessDeniedDetail.NoPermissionType");
			accessDeniedDetail.PolicyType = _ctx.StringValue("DescribeBackupTasks.AccessDeniedDetail.PolicyType");
			describeBackupTasksResponse.AccessDeniedDetail = accessDeniedDetail;

			List<DescribeBackupTasksResponse.DescribeBackupTasks_BackupJob> describeBackupTasksResponse_backupJobs = new List<DescribeBackupTasksResponse.DescribeBackupTasks_BackupJob>();
			for (int i = 0; i < _ctx.Length("DescribeBackupTasks.BackupJobs.Length"); i++) {
				DescribeBackupTasksResponse.DescribeBackupTasks_BackupJob backupJob = new DescribeBackupTasksResponse.DescribeBackupTasks_BackupJob();
				backupJob.StartTime = _ctx.StringValue("DescribeBackupTasks.BackupJobs["+ i +"].StartTime");
				backupJob.Process = _ctx.StringValue("DescribeBackupTasks.BackupJobs["+ i +"].Process");
				backupJob.JobMode = _ctx.StringValue("DescribeBackupTasks.BackupJobs["+ i +"].JobMode");
				backupJob.BackupJobID = _ctx.IntegerValue("DescribeBackupTasks.BackupJobs["+ i +"].BackupJobID");
				backupJob.BackupProgressStatus = _ctx.StringValue("DescribeBackupTasks.BackupJobs["+ i +"].BackupProgressStatus");
				backupJob.NodeId = _ctx.StringValue("DescribeBackupTasks.BackupJobs["+ i +"].NodeId");
				backupJob.TaskAction = _ctx.StringValue("DescribeBackupTasks.BackupJobs["+ i +"].TaskAction");

				describeBackupTasksResponse_backupJobs.Add(backupJob);
			}
			describeBackupTasksResponse.BackupJobs = describeBackupTasksResponse_backupJobs;
        
			return describeBackupTasksResponse;
        }
    }
}
