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
using Aliyun.Acs.Iot.Model.V20180120;

namespace Aliyun.Acs.Iot.Transform.V20180120
{
    public class QueryStudioProjectListResponseUnmarshaller
    {
        public static QueryStudioProjectListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryStudioProjectListResponse queryStudioProjectListResponse = new QueryStudioProjectListResponse();

			queryStudioProjectListResponse.HttpResponse = _ctx.HttpResponse;
			queryStudioProjectListResponse.RequestId = _ctx.StringValue("QueryStudioProjectList.RequestId");
			queryStudioProjectListResponse.Success = _ctx.BooleanValue("QueryStudioProjectList.Success");
			queryStudioProjectListResponse.Code = _ctx.StringValue("QueryStudioProjectList.Code");
			queryStudioProjectListResponse.ErrorMessage = _ctx.StringValue("QueryStudioProjectList.ErrorMessage");

			QueryStudioProjectListResponse.QueryStudioProjectList_Data data = new QueryStudioProjectListResponse.QueryStudioProjectList_Data();
			data.PageNo = _ctx.IntegerValue("QueryStudioProjectList.Data.PageNo");
			data.PageSize = _ctx.IntegerValue("QueryStudioProjectList.Data.PageSize");
			data.Total = _ctx.IntegerValue("QueryStudioProjectList.Data.Total");
			data.TotalPage = _ctx.IntegerValue("QueryStudioProjectList.Data.TotalPage");

			List<QueryStudioProjectListResponse.QueryStudioProjectList_Data.QueryStudioProjectList_ProjectInfo> data_list = new List<QueryStudioProjectListResponse.QueryStudioProjectList_Data.QueryStudioProjectList_ProjectInfo>();
			for (int i = 0; i < _ctx.Length("QueryStudioProjectList.Data.List.Length"); i++) {
				QueryStudioProjectListResponse.QueryStudioProjectList_Data.QueryStudioProjectList_ProjectInfo projectInfo = new QueryStudioProjectListResponse.QueryStudioProjectList_Data.QueryStudioProjectList_ProjectInfo();
				projectInfo.GmtCreate = _ctx.LongValue("QueryStudioProjectList.Data.List["+ i +"].GmtCreate");
				projectInfo.GmtModified = _ctx.LongValue("QueryStudioProjectList.Data.List["+ i +"].GmtModified");
				projectInfo.Name = _ctx.StringValue("QueryStudioProjectList.Data.List["+ i +"].Name");
				projectInfo.ProjectId = _ctx.StringValue("QueryStudioProjectList.Data.List["+ i +"].ProjectId");
				projectInfo.Description = _ctx.StringValue("QueryStudioProjectList.Data.List["+ i +"].Description");

				data_list.Add(projectInfo);
			}
			data.List = data_list;
			queryStudioProjectListResponse.Data = data;
        
			return queryStudioProjectListResponse;
        }
    }
}
