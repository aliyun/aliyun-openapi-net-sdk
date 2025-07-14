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
    public class QueryReadableResourcesListByUserIdV2ResponseUnmarshaller
    {
        public static QueryReadableResourcesListByUserIdV2Response Unmarshall(UnmarshallerContext _ctx)
        {
			QueryReadableResourcesListByUserIdV2Response queryReadableResourcesListByUserIdV2Response = new QueryReadableResourcesListByUserIdV2Response();

			queryReadableResourcesListByUserIdV2Response.HttpResponse = _ctx.HttpResponse;
			queryReadableResourcesListByUserIdV2Response.Success = _ctx.BooleanValue("QueryReadableResourcesListByUserIdV2.Success");
			queryReadableResourcesListByUserIdV2Response.RequestId = _ctx.StringValue("QueryReadableResourcesListByUserIdV2.RequestId");

			List<QueryReadableResourcesListByUserIdV2Response.QueryReadableResourcesListByUserIdV2_Data> queryReadableResourcesListByUserIdV2Response_result = new List<QueryReadableResourcesListByUserIdV2Response.QueryReadableResourcesListByUserIdV2_Data>();
			for (int i = 0; i < _ctx.Length("QueryReadableResourcesListByUserIdV2.Result.Length"); i++) {
				QueryReadableResourcesListByUserIdV2Response.QueryReadableResourcesListByUserIdV2_Data data = new QueryReadableResourcesListByUserIdV2Response.QueryReadableResourcesListByUserIdV2_Data();
				data.Status = _ctx.IntegerValue("QueryReadableResourcesListByUserIdV2.Result["+ i +"].Status");
				data.ModifyTime = _ctx.StringValue("QueryReadableResourcesListByUserIdV2.Result["+ i +"].ModifyTime");
				data.OwnerName = _ctx.StringValue("QueryReadableResourcesListByUserIdV2.Result["+ i +"].OwnerName");
				data.Description = _ctx.StringValue("QueryReadableResourcesListByUserIdV2.Result["+ i +"].Description");
				data.WorkType = _ctx.StringValue("QueryReadableResourcesListByUserIdV2.Result["+ i +"].WorkType");
				data.ModifyName = _ctx.StringValue("QueryReadableResourcesListByUserIdV2.Result["+ i +"].ModifyName");
				data.CreateTime = _ctx.StringValue("QueryReadableResourcesListByUserIdV2.Result["+ i +"].CreateTime");
				data.WorkspaceId = _ctx.StringValue("QueryReadableResourcesListByUserIdV2.Result["+ i +"].WorkspaceId");
				data.ThirdPartAuthFlag = _ctx.IntegerValue("QueryReadableResourcesListByUserIdV2.Result["+ i +"].ThirdPartAuthFlag");
				data.OwnerId = _ctx.StringValue("QueryReadableResourcesListByUserIdV2.Result["+ i +"].OwnerId");
				data.SecurityLevel = _ctx.StringValue("QueryReadableResourcesListByUserIdV2.Result["+ i +"].SecurityLevel");
				data.WorkName = _ctx.StringValue("QueryReadableResourcesListByUserIdV2.Result["+ i +"].WorkName");
				data.WorkspaceName = _ctx.StringValue("QueryReadableResourcesListByUserIdV2.Result["+ i +"].WorkspaceName");
				data.WorksId = _ctx.StringValue("QueryReadableResourcesListByUserIdV2.Result["+ i +"].WorksId");

				QueryReadableResourcesListByUserIdV2Response.QueryReadableResourcesListByUserIdV2_Data.QueryReadableResourcesListByUserIdV2_Directory directory = new QueryReadableResourcesListByUserIdV2Response.QueryReadableResourcesListByUserIdV2_Data.QueryReadableResourcesListByUserIdV2_Directory();
				directory.PathId = _ctx.StringValue("QueryReadableResourcesListByUserIdV2.Result["+ i +"].Directory.PathId");
				directory.Id = _ctx.StringValue("QueryReadableResourcesListByUserIdV2.Result["+ i +"].Directory.Id");
				directory.PathName = _ctx.StringValue("QueryReadableResourcesListByUserIdV2.Result["+ i +"].Directory.PathName");
				directory.Name = _ctx.StringValue("QueryReadableResourcesListByUserIdV2.Result["+ i +"].Directory.Name");
				data.Directory = directory;

				queryReadableResourcesListByUserIdV2Response_result.Add(data);
			}
			queryReadableResourcesListByUserIdV2Response.Result = queryReadableResourcesListByUserIdV2Response_result;
        
			return queryReadableResourcesListByUserIdV2Response;
        }
    }
}
