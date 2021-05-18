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
    public class QueryStudioAppPageListOpenResponseUnmarshaller
    {
        public static QueryStudioAppPageListOpenResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryStudioAppPageListOpenResponse queryStudioAppPageListOpenResponse = new QueryStudioAppPageListOpenResponse();

			queryStudioAppPageListOpenResponse.HttpResponse = _ctx.HttpResponse;
			queryStudioAppPageListOpenResponse.RequestId = _ctx.StringValue("QueryStudioAppPageListOpen.RequestId");
			queryStudioAppPageListOpenResponse.Success = _ctx.BooleanValue("QueryStudioAppPageListOpen.Success");
			queryStudioAppPageListOpenResponse.Code = _ctx.StringValue("QueryStudioAppPageListOpen.Code");
			queryStudioAppPageListOpenResponse.ErrorMessage = _ctx.StringValue("QueryStudioAppPageListOpen.ErrorMessage");

			QueryStudioAppPageListOpenResponse.QueryStudioAppPageListOpen_Data data = new QueryStudioAppPageListOpenResponse.QueryStudioAppPageListOpen_Data();
			data.PageSize = _ctx.IntegerValue("QueryStudioAppPageListOpen.Data.PageSize");
			data.PageNo = _ctx.IntegerValue("QueryStudioAppPageListOpen.Data.PageNo");
			data.Total = _ctx.IntegerValue("QueryStudioAppPageListOpen.Data.Total");
			data.TotalPage = _ctx.IntegerValue("QueryStudioAppPageListOpen.Data.TotalPage");

			List<QueryStudioAppPageListOpenResponse.QueryStudioAppPageListOpen_Data.QueryStudioAppPageListOpen_PageInfo> data_list = new List<QueryStudioAppPageListOpenResponse.QueryStudioAppPageListOpen_Data.QueryStudioAppPageListOpen_PageInfo>();
			for (int i = 0; i < _ctx.Length("QueryStudioAppPageListOpen.Data.List.Length"); i++) {
				QueryStudioAppPageListOpenResponse.QueryStudioAppPageListOpen_Data.QueryStudioAppPageListOpen_PageInfo pageInfo = new QueryStudioAppPageListOpenResponse.QueryStudioAppPageListOpen_Data.QueryStudioAppPageListOpen_PageInfo();
				pageInfo.Id = _ctx.IntegerValue("QueryStudioAppPageListOpen.Data.List["+ i +"].Id");
				pageInfo.PageId = _ctx.StringValue("QueryStudioAppPageListOpen.Data.List["+ i +"].PageId");
				pageInfo.Path = _ctx.StringValue("QueryStudioAppPageListOpen.Data.List["+ i +"].Path");
				pageInfo.IsHidden = _ctx.IntegerValue("QueryStudioAppPageListOpen.Data.List["+ i +"].IsHidden");
				pageInfo.IsHome = _ctx.IntegerValue("QueryStudioAppPageListOpen.Data.List["+ i +"].IsHome");
				pageInfo.IsLoginPage = _ctx.IntegerValue("QueryStudioAppPageListOpen.Data.List["+ i +"].IsLoginPage");
				pageInfo.Name = _ctx.StringValue("QueryStudioAppPageListOpen.Data.List["+ i +"].Name");
				pageInfo.GmtCreate = _ctx.StringValue("QueryStudioAppPageListOpen.Data.List["+ i +"].GmtCreate");
				pageInfo.GmtModified = _ctx.StringValue("QueryStudioAppPageListOpen.Data.List["+ i +"].GmtModified");

				data_list.Add(pageInfo);
			}
			data.List = data_list;
			queryStudioAppPageListOpenResponse.Data = data;
        
			return queryStudioAppPageListOpenResponse;
        }
    }
}
