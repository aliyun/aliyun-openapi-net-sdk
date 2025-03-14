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
    public class QueryReadableResourcesListByUserIdResponseUnmarshaller
    {
        public static QueryReadableResourcesListByUserIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryReadableResourcesListByUserIdResponse queryReadableResourcesListByUserIdResponse = new QueryReadableResourcesListByUserIdResponse();

			queryReadableResourcesListByUserIdResponse.HttpResponse = _ctx.HttpResponse;
			queryReadableResourcesListByUserIdResponse.Success = _ctx.BooleanValue("QueryReadableResourcesListByUserId.Success");
			queryReadableResourcesListByUserIdResponse.RequestId = _ctx.StringValue("QueryReadableResourcesListByUserId.RequestId");

			List<QueryReadableResourcesListByUserIdResponse.QueryReadableResourcesListByUserId_Data> queryReadableResourcesListByUserIdResponse_result = new List<QueryReadableResourcesListByUserIdResponse.QueryReadableResourcesListByUserId_Data>();
			for (int i = 0; i < _ctx.Length("QueryReadableResourcesListByUserId.Result.Length"); i++) {
				QueryReadableResourcesListByUserIdResponse.QueryReadableResourcesListByUserId_Data data = new QueryReadableResourcesListByUserIdResponse.QueryReadableResourcesListByUserId_Data();
				data.CreateTime = _ctx.StringValue("QueryReadableResourcesListByUserId.Result["+ i +"].CreateTime");
				data.Description = _ctx.StringValue("QueryReadableResourcesListByUserId.Result["+ i +"].Description");
				data.ModifyName = _ctx.StringValue("QueryReadableResourcesListByUserId.Result["+ i +"].ModifyName");
				data.ModifyTime = _ctx.StringValue("QueryReadableResourcesListByUserId.Result["+ i +"].ModifyTime");
				data.OwnerId = _ctx.StringValue("QueryReadableResourcesListByUserId.Result["+ i +"].OwnerId");
				data.OwnerName = _ctx.StringValue("QueryReadableResourcesListByUserId.Result["+ i +"].OwnerName");
				data.SecurityLevel = _ctx.StringValue("QueryReadableResourcesListByUserId.Result["+ i +"].SecurityLevel");
				data.Status = _ctx.IntegerValue("QueryReadableResourcesListByUserId.Result["+ i +"].Status");
				data.ThirdPartAuthFlag = _ctx.IntegerValue("QueryReadableResourcesListByUserId.Result["+ i +"].ThirdPartAuthFlag");
				data.WorkName = _ctx.StringValue("QueryReadableResourcesListByUserId.Result["+ i +"].WorkName");
				data.WorkType = _ctx.StringValue("QueryReadableResourcesListByUserId.Result["+ i +"].WorkType");
				data.WorksId = _ctx.StringValue("QueryReadableResourcesListByUserId.Result["+ i +"].WorksId");
				data.WorkspaceId = _ctx.StringValue("QueryReadableResourcesListByUserId.Result["+ i +"].WorkspaceId");
				data.WorkspaceName = _ctx.StringValue("QueryReadableResourcesListByUserId.Result["+ i +"].WorkspaceName");

				QueryReadableResourcesListByUserIdResponse.QueryReadableResourcesListByUserId_Data.QueryReadableResourcesListByUserId_Directory directory = new QueryReadableResourcesListByUserIdResponse.QueryReadableResourcesListByUserId_Data.QueryReadableResourcesListByUserId_Directory();
				directory.Id = _ctx.StringValue("QueryReadableResourcesListByUserId.Result["+ i +"].Directory.Id");
				directory.Name = _ctx.StringValue("QueryReadableResourcesListByUserId.Result["+ i +"].Directory.Name");
				directory.PathId = _ctx.StringValue("QueryReadableResourcesListByUserId.Result["+ i +"].Directory.PathId");
				directory.PathName = _ctx.StringValue("QueryReadableResourcesListByUserId.Result["+ i +"].Directory.PathName");
				data.Directory = directory;

				queryReadableResourcesListByUserIdResponse_result.Add(data);
			}
			queryReadableResourcesListByUserIdResponse.Result = queryReadableResourcesListByUserIdResponse_result;
        
			return queryReadableResourcesListByUserIdResponse;
        }
    }
}
