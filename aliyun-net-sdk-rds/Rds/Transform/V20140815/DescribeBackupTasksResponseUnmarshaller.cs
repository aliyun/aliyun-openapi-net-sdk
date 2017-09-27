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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Rds.Model.V20140815;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Rds.Transform.V20140815
{
    public class DescribeBackupTasksResponseUnmarshaller
    {
        public static DescribeBackupTasksResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBackupTasksResponse describeBackupTasksResponse = new DescribeBackupTasksResponse();

			describeBackupTasksResponse.HttpResponse = context.HttpResponse;
			describeBackupTasksResponse.RequestId = context.StringValue("DescribeBackupTasks.RequestId");

			List<DescribeBackupTasksResponse.DescribeBackupTasks_BackupJob> describeBackupTasksResponse_items = new List<DescribeBackupTasksResponse.DescribeBackupTasks_BackupJob>();
			for (int i = 0; i < context.Length("DescribeBackupTasks.Items.Length"); i++) {
				DescribeBackupTasksResponse.DescribeBackupTasks_BackupJob backupJob = new DescribeBackupTasksResponse.DescribeBackupTasks_BackupJob();
				backupJob.BackupProgressStatus = context.StringValue("DescribeBackupTasks.Items["+ i +"].BackupProgressStatus");
				backupJob.JobMode = context.StringValue("DescribeBackupTasks.Items["+ i +"].JobMode");
				backupJob.Process = context.StringValue("DescribeBackupTasks.Items["+ i +"].Process");
				backupJob.TaskAction = context.StringValue("DescribeBackupTasks.Items["+ i +"].TaskAction");
				backupJob.BackupjobId = context.StringValue("DescribeBackupTasks.Items["+ i +"].BackupjobId");

				describeBackupTasksResponse_items.Add(backupJob);
			}
			describeBackupTasksResponse.Items = describeBackupTasksResponse_items;
        
			return describeBackupTasksResponse;
        }
    }
}