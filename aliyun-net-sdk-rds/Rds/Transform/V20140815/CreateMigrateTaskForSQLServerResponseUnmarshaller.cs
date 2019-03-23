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
    public class CreateMigrateTaskForSQLServerResponseUnmarshaller
    {
        public static CreateMigrateTaskForSQLServerResponse Unmarshall(UnmarshallerContext context)
        {
            CreateMigrateTaskForSQLServerResponse createMigrateTaskForSQLServerResponse = new CreateMigrateTaskForSQLServerResponse();

            createMigrateTaskForSQLServerResponse.HttpResponse = context.HttpResponse;
            createMigrateTaskForSQLServerResponse.RequestId = context.StringValue("CreateMigrateTaskForSQLServer.RequestId");
            createMigrateTaskForSQLServerResponse.DBInstanceId = context.StringValue("CreateMigrateTaskForSQLServer.DBInstanceId");
            createMigrateTaskForSQLServerResponse.DBInstanceName = context.StringValue("CreateMigrateTaskForSQLServer.DBInstanceName");
            createMigrateTaskForSQLServerResponse.TaskId = context.StringValue("CreateMigrateTaskForSQLServer.TaskId");
            createMigrateTaskForSQLServerResponse.DBName = context.StringValue("CreateMigrateTaskForSQLServer.DBName");
            createMigrateTaskForSQLServerResponse.MigrateIaskId = context.StringValue("CreateMigrateTaskForSQLServer.MigrateIaskId");
            createMigrateTaskForSQLServerResponse.TaskType = context.StringValue("CreateMigrateTaskForSQLServer.TaskType");

            return createMigrateTaskForSQLServerResponse;
        }
    }
}