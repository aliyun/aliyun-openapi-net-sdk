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
    public class DescribeMigrateTasksResponseUnmarshaller
    {
        public static DescribeMigrateTasksResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeMigrateTasksResponse describeMigrateTasksResponse = new DescribeMigrateTasksResponse();

			describeMigrateTasksResponse.HttpResponse = context.HttpResponse;
			describeMigrateTasksResponse.RequestId = context.StringValue("DescribeMigrateTasks.RequestId");
			describeMigrateTasksResponse.DBInstanceId = context.StringValue("DescribeMigrateTasks.DBInstanceId");
			describeMigrateTasksResponse.TotalRecordCount = context.IntegerValue("DescribeMigrateTasks.TotalRecordCount");
			describeMigrateTasksResponse.PageNumber = context.IntegerValue("DescribeMigrateTasks.PageNumber");
			describeMigrateTasksResponse.PageRecordCount = context.IntegerValue("DescribeMigrateTasks.PageRecordCount");

			List<DescribeMigrateTasksResponse.DescribeMigrateTasks_MigrateTask> describeMigrateTasksResponse_items = new List<DescribeMigrateTasksResponse.DescribeMigrateTasks_MigrateTask>();
			for (int i = 0; i < context.Length("DescribeMigrateTasks.Items.Length"); i++) {
				DescribeMigrateTasksResponse.DescribeMigrateTasks_MigrateTask migrateTask = new DescribeMigrateTasksResponse.DescribeMigrateTasks_MigrateTask();
				migrateTask.DBName = context.StringValue("DescribeMigrateTasks.Items["+ i +"].DBName");
				migrateTask.MigrateTaskId = context.StringValue("DescribeMigrateTasks.Items["+ i +"].MigrateTaskId");
				migrateTask.CreateTime = context.StringValue("DescribeMigrateTasks.Items["+ i +"].CreateTime");
				migrateTask.EndTime = context.StringValue("DescribeMigrateTasks.Items["+ i +"].EndTime");
				migrateTask.BackupMode = context.StringValue("DescribeMigrateTasks.Items["+ i +"].BackupMode");
				migrateTask.Status = context.StringValue("DescribeMigrateTasks.Items["+ i +"].Status");
				migrateTask.IsDBReplaced = context.StringValue("DescribeMigrateTasks.Items["+ i +"].IsDBReplaced");
				migrateTask.Description = context.StringValue("DescribeMigrateTasks.Items["+ i +"].Description");

				describeMigrateTasksResponse_items.Add(migrateTask);
			}
			describeMigrateTasksResponse.Items = describeMigrateTasksResponse_items;
        
			return describeMigrateTasksResponse;
        }
    }
}
