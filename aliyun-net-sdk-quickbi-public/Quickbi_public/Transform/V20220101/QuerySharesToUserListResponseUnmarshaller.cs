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
			querySharesToUserListResponse.RequestId = _ctx.StringValue("QuerySharesToUserList.RequestId");
			querySharesToUserListResponse.Success = _ctx.BooleanValue("QuerySharesToUserList.Success");

			List<QuerySharesToUserListResponse.QuerySharesToUserList_Data> querySharesToUserListResponse_result = new List<QuerySharesToUserListResponse.QuerySharesToUserList_Data>();
			for (int i = 0; i < _ctx.Length("QuerySharesToUserList.Result.Length"); i++) {
				QuerySharesToUserListResponse.QuerySharesToUserList_Data data = new QuerySharesToUserListResponse.QuerySharesToUserList_Data();
				data.CreateTime = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].CreateTime");
				data.Description = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].Description");
				data.ModifyName = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].ModifyName");
				data.ModifyTime = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].ModifyTime");
				data.OwnerId = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].OwnerId");
				data.OwnerName = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].OwnerName");
				data.SecurityLevel = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].SecurityLevel");
				data.Status = _ctx.IntegerValue("QuerySharesToUserList.Result["+ i +"].Status");
				data.ThirdPartAuthFlag = _ctx.IntegerValue("QuerySharesToUserList.Result["+ i +"].ThirdPartAuthFlag");
				data.WorkName = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].WorkName");
				data.WorkType = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].WorkType");
				data.WorksId = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].WorksId");
				data.WorkspaceId = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].WorkspaceId");
				data.WorkspaceName = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].WorkspaceName");

				QuerySharesToUserListResponse.QuerySharesToUserList_Data.QuerySharesToUserList_Directory directory = new QuerySharesToUserListResponse.QuerySharesToUserList_Data.QuerySharesToUserList_Directory();
				directory.Id = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].Directory.Id");
				directory.Name = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].Directory.Name");
				directory.PathId = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].Directory.PathId");
				directory.PathName = _ctx.StringValue("QuerySharesToUserList.Result["+ i +"].Directory.PathName");
				data.Directory = directory;

				querySharesToUserListResponse_result.Add(data);
			}
			querySharesToUserListResponse.Result = querySharesToUserListResponse_result;
        
			return querySharesToUserListResponse;
        }
    }
}
