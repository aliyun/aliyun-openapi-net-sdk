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
    public class DescribeMigrateTaskByIdResponseUnmarshaller
    {
        public static DescribeMigrateTaskByIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeMigrateTaskByIdResponse describeMigrateTaskByIdResponse = new DescribeMigrateTaskByIdResponse();

			describeMigrateTaskByIdResponse.HttpResponse = _ctx.HttpResponse;
			describeMigrateTaskByIdResponse.RequestId = _ctx.StringValue("DescribeMigrateTaskById.RequestId");
			describeMigrateTaskByIdResponse.DBInstanceName = _ctx.StringValue("DescribeMigrateTaskById.DBInstanceName");
			describeMigrateTaskByIdResponse.DBName = _ctx.StringValue("DescribeMigrateTaskById.DBName");
			describeMigrateTaskByIdResponse.MigrateTaskId = _ctx.StringValue("DescribeMigrateTaskById.MigrateTaskId");
			describeMigrateTaskByIdResponse.CreateTime = _ctx.StringValue("DescribeMigrateTaskById.CreateTime");
			describeMigrateTaskByIdResponse.EndTime = _ctx.StringValue("DescribeMigrateTaskById.EndTime");
			describeMigrateTaskByIdResponse.BackupMode = _ctx.StringValue("DescribeMigrateTaskById.BackupMode");
			describeMigrateTaskByIdResponse.Status = _ctx.StringValue("DescribeMigrateTaskById.Status");
			describeMigrateTaskByIdResponse.IsDBReplaced = _ctx.StringValue("DescribeMigrateTaskById.IsDBReplaced");
			describeMigrateTaskByIdResponse.Description = _ctx.StringValue("DescribeMigrateTaskById.Description");
        
			return describeMigrateTaskByIdResponse;
        }
    }
}
