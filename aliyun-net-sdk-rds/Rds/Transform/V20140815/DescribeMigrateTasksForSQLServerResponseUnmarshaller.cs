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
    public class DescribeMigrateTasksForSQLServerResponseUnmarshaller
    {
        public static DescribeMigrateTasksForSQLServerResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeMigrateTasksForSQLServerResponse describeMigrateTasksForSQLServerResponse = new DescribeMigrateTasksForSQLServerResponse();

			describeMigrateTasksForSQLServerResponse.HttpResponse = context.HttpResponse;
			describeMigrateTasksForSQLServerResponse.RequestId = context.StringValue("DescribeMigrateTasksForSQLServer.RequestId");
			describeMigrateTasksForSQLServerResponse.DBInstanceID = context.StringValue("DescribeMigrateTasksForSQLServer.DBInstanceID");
			describeMigrateTasksForSQLServerResponse.DBInstanceName = context.StringValue("DescribeMigrateTasksForSQLServer.DBInstanceName");
			describeMigrateTasksForSQLServerResponse.StartTime = context.StringValue("DescribeMigrateTasksForSQLServer.StartTime");
			describeMigrateTasksForSQLServerResponse.EndTime = context.StringValue("DescribeMigrateTasksForSQLServer.EndTime");
			describeMigrateTasksForSQLServerResponse.TotalRecordCount = context.IntegerValue("DescribeMigrateTasksForSQLServer.TotalRecordCount");
			describeMigrateTasksForSQLServerResponse.PageNumber = context.IntegerValue("DescribeMigrateTasksForSQLServer.PageNumber");
			describeMigrateTasksForSQLServerResponse.PageRecordCount = context.IntegerValue("DescribeMigrateTasksForSQLServer.PageRecordCount");

			List<DescribeMigrateTasksForSQLServerResponse.DescribeMigrateTasksForSQLServer_MigrateTask> describeMigrateTasksForSQLServerResponse_items = new List<DescribeMigrateTasksForSQLServerResponse.DescribeMigrateTasksForSQLServer_MigrateTask>();
			for (int i = 0; i < context.Length("DescribeMigrateTasksForSQLServer.Items.Length"); i++) {
				DescribeMigrateTasksForSQLServerResponse.DescribeMigrateTasksForSQLServer_MigrateTask migrateTask = new DescribeMigrateTasksForSQLServerResponse.DescribeMigrateTasksForSQLServer_MigrateTask();
				migrateTask.DBName = context.StringValue("DescribeMigrateTasksForSQLServer.Items["+ i +"].DBName");
				migrateTask.MigrateIaskId = context.StringValue("DescribeMigrateTasksForSQLServer.Items["+ i +"].MigrateIaskId");
				migrateTask.CreateTime = context.StringValue("DescribeMigrateTasksForSQLServer.Items["+ i +"].CreateTime");
				migrateTask.EndTime = context.StringValue("DescribeMigrateTasksForSQLServer.Items["+ i +"].EndTime");
				migrateTask.TaskType = context.StringValue("DescribeMigrateTasksForSQLServer.Items["+ i +"].TaskType");
				migrateTask.Status = context.StringValue("DescribeMigrateTasksForSQLServer.Items["+ i +"].Status");
				migrateTask.IsDBReplaced = context.StringValue("DescribeMigrateTasksForSQLServer.Items["+ i +"].IsDBReplaced");
				migrateTask.Desc = context.StringValue("DescribeMigrateTasksForSQLServer.Items["+ i +"].Desc");

				describeMigrateTasksForSQLServerResponse_items.Add(migrateTask);
			}
			describeMigrateTasksForSQLServerResponse.Items = describeMigrateTasksForSQLServerResponse_items;
        
			return describeMigrateTasksForSQLServerResponse;
        }
    }
}
