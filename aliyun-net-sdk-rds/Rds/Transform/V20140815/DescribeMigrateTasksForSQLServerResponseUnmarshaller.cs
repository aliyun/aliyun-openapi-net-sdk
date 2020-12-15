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
        public static DescribeMigrateTasksForSQLServerResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMigrateTasksForSQLServerResponse describeMigrateTasksForSQLServerResponse = new DescribeMigrateTasksForSQLServerResponse();

			describeMigrateTasksForSQLServerResponse.HttpResponse = _ctx.HttpResponse;
			describeMigrateTasksForSQLServerResponse.RequestId = _ctx.StringValue("DescribeMigrateTasksForSQLServer.RequestId");
			describeMigrateTasksForSQLServerResponse.DBInstanceID = _ctx.StringValue("DescribeMigrateTasksForSQLServer.DBInstanceID");
			describeMigrateTasksForSQLServerResponse.DBInstanceName = _ctx.StringValue("DescribeMigrateTasksForSQLServer.DBInstanceName");
			describeMigrateTasksForSQLServerResponse.StartTime = _ctx.StringValue("DescribeMigrateTasksForSQLServer.StartTime");
			describeMigrateTasksForSQLServerResponse.EndTime = _ctx.StringValue("DescribeMigrateTasksForSQLServer.EndTime");
			describeMigrateTasksForSQLServerResponse.TotalRecordCount = _ctx.IntegerValue("DescribeMigrateTasksForSQLServer.TotalRecordCount");
			describeMigrateTasksForSQLServerResponse.PageNumber = _ctx.IntegerValue("DescribeMigrateTasksForSQLServer.PageNumber");
			describeMigrateTasksForSQLServerResponse.PageRecordCount = _ctx.IntegerValue("DescribeMigrateTasksForSQLServer.PageRecordCount");

			List<DescribeMigrateTasksForSQLServerResponse.DescribeMigrateTasksForSQLServer_MigrateTask> describeMigrateTasksForSQLServerResponse_items = new List<DescribeMigrateTasksForSQLServerResponse.DescribeMigrateTasksForSQLServer_MigrateTask>();
			for (int i = 0; i < _ctx.Length("DescribeMigrateTasksForSQLServer.Items.Length"); i++) {
				DescribeMigrateTasksForSQLServerResponse.DescribeMigrateTasksForSQLServer_MigrateTask migrateTask = new DescribeMigrateTasksForSQLServerResponse.DescribeMigrateTasksForSQLServer_MigrateTask();
				migrateTask.DBName = _ctx.StringValue("DescribeMigrateTasksForSQLServer.Items["+ i +"].DBName");
				migrateTask.MigrateIaskId = _ctx.StringValue("DescribeMigrateTasksForSQLServer.Items["+ i +"].MigrateIaskId");
				migrateTask.CreateTime = _ctx.StringValue("DescribeMigrateTasksForSQLServer.Items["+ i +"].CreateTime");
				migrateTask.EndTime = _ctx.StringValue("DescribeMigrateTasksForSQLServer.Items["+ i +"].EndTime");
				migrateTask.TaskType = _ctx.StringValue("DescribeMigrateTasksForSQLServer.Items["+ i +"].TaskType");
				migrateTask.Status = _ctx.StringValue("DescribeMigrateTasksForSQLServer.Items["+ i +"].Status");
				migrateTask.IsDBReplaced = _ctx.StringValue("DescribeMigrateTasksForSQLServer.Items["+ i +"].IsDBReplaced");
				migrateTask.Desc = _ctx.StringValue("DescribeMigrateTasksForSQLServer.Items["+ i +"].Desc");

				describeMigrateTasksForSQLServerResponse_items.Add(migrateTask);
			}
			describeMigrateTasksForSQLServerResponse.Items = describeMigrateTasksForSQLServerResponse_items;
        
			return describeMigrateTasksForSQLServerResponse;
        }
    }
}
