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
using Aliyun.Acs.quickbi_public.Model.V20220101;

namespace Aliyun.Acs.quickbi_public.Transform.V20220101
{
    public class QueryWorksResponseUnmarshaller
    {
        public static QueryWorksResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryWorksResponse queryWorksResponse = new QueryWorksResponse();

			queryWorksResponse.HttpResponse = _ctx.HttpResponse;
			queryWorksResponse.Success = _ctx.BooleanValue("QueryWorks.Success");
			queryWorksResponse.RequestId = _ctx.StringValue("QueryWorks.RequestId");

			QueryWorksResponse.QueryWorks_Result result = new QueryWorksResponse.QueryWorks_Result();
			result.WorksId = _ctx.StringValue("QueryWorks.Result.WorksId");
			result.WorkType = _ctx.StringValue("QueryWorks.Result.WorkType");
			result.WorkName = _ctx.StringValue("QueryWorks.Result.WorkName");
			result.WorkspaceId = _ctx.StringValue("QueryWorks.Result.WorkspaceId");
			result.WorkspaceName = _ctx.StringValue("QueryWorks.Result.WorkspaceName");
			result.SecurityLevel = _ctx.StringValue("QueryWorks.Result.SecurityLevel");
			result.Auth3rdFlag = _ctx.IntegerValue("QueryWorks.Result.Auth3rdFlag");
			result.Description = _ctx.StringValue("QueryWorks.Result.Description");
			result.OwnerId = _ctx.StringValue("QueryWorks.Result.OwnerId");
			result.OwnerName = _ctx.StringValue("QueryWorks.Result.OwnerName");
			result.ModifyName = _ctx.StringValue("QueryWorks.Result.ModifyName");
			result.GmtCreate = _ctx.StringValue("QueryWorks.Result.GmtCreate");
			result.GmtModify = _ctx.StringValue("QueryWorks.Result.GmtModify");
			result.Status = _ctx.IntegerValue("QueryWorks.Result.Status");

			QueryWorksResponse.QueryWorks_Result.QueryWorks_Directory directory = new QueryWorksResponse.QueryWorks_Result.QueryWorks_Directory();
			directory.Id = _ctx.StringValue("QueryWorks.Result.Directory.Id");
			directory.Name = _ctx.StringValue("QueryWorks.Result.Directory.Name");
			directory.PathId = _ctx.StringValue("QueryWorks.Result.Directory.PathId");
			directory.PathName = _ctx.StringValue("QueryWorks.Result.Directory.PathName");
			result.Directory = directory;
			queryWorksResponse.Result = result;
        
			return queryWorksResponse;
        }
    }
}
