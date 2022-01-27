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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetMigrationSummaryResponseUnmarshaller
    {
        public static GetMigrationSummaryResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMigrationSummaryResponse getMigrationSummaryResponse = new GetMigrationSummaryResponse();

			getMigrationSummaryResponse.HttpResponse = _ctx.HttpResponse;
			getMigrationSummaryResponse.RequestId = _ctx.StringValue("GetMigrationSummary.RequestId");
			getMigrationSummaryResponse.Success = _ctx.BooleanValue("GetMigrationSummary.Success");

			GetMigrationSummaryResponse.GetMigrationSummary_Data data = new GetMigrationSummaryResponse.GetMigrationSummary_Data();
			data.MigrationId = _ctx.LongValue("GetMigrationSummary.Data.MigrationId");
			data.Name = _ctx.StringValue("GetMigrationSummary.Data.Name");
			data.GmtCreate = _ctx.LongValue("GetMigrationSummary.Data.GmtCreate");
			data.GmtModified = _ctx.LongValue("GetMigrationSummary.Data.GmtModified");
			data.CreateUser = _ctx.StringValue("GetMigrationSummary.Data.CreateUser");
			data.OpUser = _ctx.StringValue("GetMigrationSummary.Data.OpUser");
			data.Status = _ctx.StringValue("GetMigrationSummary.Data.Status");
			data.ProjectId = _ctx.LongValue("GetMigrationSummary.Data.ProjectId");
			data.DownloadUrl = _ctx.StringValue("GetMigrationSummary.Data.DownloadUrl");
			getMigrationSummaryResponse.Data = data;
        
			return getMigrationSummaryResponse;
        }
    }
}
