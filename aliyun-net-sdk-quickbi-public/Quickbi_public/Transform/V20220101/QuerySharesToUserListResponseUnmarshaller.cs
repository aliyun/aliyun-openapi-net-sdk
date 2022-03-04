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
    public class QuerySharesToUserListResponseUnmarshaller
    {
        public static QuerySharesToUserListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySharesToUserListResponse querySharesToUserListResponse = new QuerySharesToUserListResponse();

			querySharesToUserListResponse.HttpResponse = _ctx.HttpResponse;
			querySharesToUserListResponse.Success = _ctx.BooleanValue("QuerySharesToUserList.Success");
			querySharesToUserListResponse.RequestId = _ctx.StringValue("QuerySharesToUserList.RequestId");

			List<QuerySharesToUserListResponse.QuerySharesToUserList_Data> querySharesToUserListResponse_result = new List<QuerySharesToUserListResponse.QuerySharesToUserList_Data>();
			for (int i = 0; i < _ctx.Length("QuerySharesToUserList.Result.Length"); i++) {
				QuerySharesToUserListResponse.QuerySharesToUserList_Data data = new QuerySharesToUserListResponse.QuerySharesToUserList_Data();
				data.Status = _ctx.IntegerValue("QuerySharesToUserList.Result["+ i +"].Status");
				data.ThirdPartAuthFlag = _ctx.IntegerValue("QuerySharesToUserList.Result["+ i +"].ThirdPartAuthFlag");
				data.WorksId = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].WorksId");
				data.CreateTime = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].CreateTime");
				data.WorkType = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].WorkType");
				data.OwnerName = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].OwnerName");
				data.WorkspaceName = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].WorkspaceName");
				data.OwnerId = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].OwnerId");
				data.ModifyName = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].ModifyName");
				data.WorkspaceId = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].WorkspaceId");
				data.SecurityLevel = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].SecurityLevel");
				data.Description = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].Description");
				data.WorkName = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].WorkName");
				data.ModifyTime = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].ModifyTime");

				QuerySharesToUserListResponse.QuerySharesToUserList_Data.QuerySharesToUserList_Directory directory = new QuerySharesToUserListResponse.QuerySharesToUserList_Data.QuerySharesToUserList_Directory();
				directory.PathId = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].Directory.PathId");
				directory.PathName = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].Directory.PathName");
				directory.Name = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].Directory.Name");
				directory.Id = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].Directory.Id");
				data.Directory = directory;

				querySharesToUserListResponse_result.Add(data);
			}
			querySharesToUserListResponse.Result = querySharesToUserListResponse_result;
        
			return querySharesToUserListResponse;
        }
    }
}
