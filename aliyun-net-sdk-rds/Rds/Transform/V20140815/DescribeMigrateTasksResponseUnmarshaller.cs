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
        public static DescribeMigrateTasksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMigrateTasksResponse describeMigrateTasksResponse = new DescribeMigrateTasksResponse();

			describeMigrateTasksResponse.HttpResponse = _ctx.HttpResponse;
			describeMigrateTasksResponse.DBInstanceId = _ctx.StringValue("DescribeMigrateTasks.DBInstanceId");
			describeMigrateTasksResponse.PageNumber = _ctx.IntegerValue("DescribeMigrateTasks.PageNumber");
			describeMigrateTasksResponse.RequestId = _ctx.StringValue("DescribeMigrateTasks.RequestId");
			describeMigrateTasksResponse.PageRecordCount = _ctx.IntegerValue("DescribeMigrateTasks.PageRecordCount");
			describeMigrateTasksResponse.TotalRecordCount = _ctx.IntegerValue("DescribeMigrateTasks.TotalRecordCount");

			List<DescribeMigrateTasksResponse.DescribeMigrateTasks_MigrateTask> describeMigrateTasksResponse_items = new List<DescribeMigrateTasksResponse.DescribeMigrateTasks_MigrateTask>();
			for (int i = 0; i < _ctx.Length("DescribeMigrateTasks.Items.Length"); i++) {
				DescribeMigrateTasksResponse.DescribeMigrateTasks_MigrateTask migrateTask = new DescribeMigrateTasksResponse.DescribeMigrateTasks_MigrateTask();
				migrateTask.EndTime = _ctx.StringValue("DescribeMigrateTasks.Items["+ i +"].EndTime");
				migrateTask.Status = _ctx.StringValue("DescribeMigrateTasks.Items["+ i +"].Status");
				migrateTask.Description = _ctx.StringValue("DescribeMigrateTasks.Items["+ i +"].Description");
				migrateTask.CreateTime = _ctx.StringValue("DescribeMigrateTasks.Items["+ i +"].CreateTime");
				migrateTask.DBName = _ctx.StringValue("DescribeMigrateTasks.Items["+ i +"].DBName");
				migrateTask.BackupMode = _ctx.StringValue("DescribeMigrateTasks.Items["+ i +"].BackupMode");
				migrateTask.MigrateTaskId = _ctx.StringValue("DescribeMigrateTasks.Items["+ i +"].MigrateTaskId");
				migrateTask.IsDBReplaced = _ctx.StringValue("DescribeMigrateTasks.Items["+ i +"].IsDBReplaced");

				describeMigrateTasksResponse_items.Add(migrateTask);
			}
			describeMigrateTasksResponse.Items = describeMigrateTasksResponse_items;
        
			return describeMigrateTasksResponse;
        }
    }
}
