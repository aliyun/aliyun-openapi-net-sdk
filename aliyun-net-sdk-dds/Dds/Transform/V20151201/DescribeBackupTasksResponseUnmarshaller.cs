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
    public class DescribeBackupTasksResponseUnmarshaller
    {
        public static DescribeBackupTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeBackupTasksResponse describeBackupTasksResponse = new DescribeBackupTasksResponse();

			describeBackupTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeBackupTasksResponse.RequestId = _ctx.StringValue("DescribeBackupTasks.RequestId");

			List<DescribeBackupTasksResponse.DescribeBackupTasks_BackupTask> describeBackupTasksResponse_backupJobs = new List<DescribeBackupTasksResponse.DescribeBackupTasks_BackupTask>();
			for (int i = 0; i < _ctx.Length("DescribeBackupTasks.BackupJobs.Length"); i++) {
				DescribeBackupTasksResponse.DescribeBackupTasks_BackupTask backupTask = new DescribeBackupTasksResponse.DescribeBackupTasks_BackupTask();
				backupTask.BackupjobId = _ctx.StringValue("DescribeBackupTasks.BackupJobs["+ i +"].BackupjobId");
				backupTask.BackupSetStatus = _ctx.StringValue("DescribeBackupTasks.BackupJobs["+ i +"].BackupSetStatus");
				backupTask.BackupStartTime = _ctx.StringValue("DescribeBackupTasks.BackupJobs["+ i +"].BackupStartTime");
				backupTask.Progress = _ctx.StringValue("DescribeBackupTasks.BackupJobs["+ i +"].Progress");
				backupTask.JobMode = _ctx.StringValue("DescribeBackupTasks.BackupJobs["+ i +"].JobMode");

				describeBackupTasksResponse_backupJobs.Add(backupTask);
			}
			describeBackupTasksResponse.BackupJobs = describeBackupTasksResponse_backupJobs;
        
			return describeBackupTasksResponse;
        }
    }
}
