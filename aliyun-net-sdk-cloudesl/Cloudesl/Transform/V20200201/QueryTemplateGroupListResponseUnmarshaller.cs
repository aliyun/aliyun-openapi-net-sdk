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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class QueryTemplateGroupListResponseUnmarshaller
    {
        public static QueryTemplateGroupListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryTemplateGroupListResponse queryTemplateGroupListResponse = new QueryTemplateGroupListResponse();

			queryTemplateGroupListResponse.HttpResponse = _ctx.HttpResponse;
			queryTemplateGroupListResponse.RequestId = _ctx.StringValue("QueryTemplateGroupList.RequestId");
			queryTemplateGroupListResponse.Success = _ctx.BooleanValue("QueryTemplateGroupList.Success");
			queryTemplateGroupListResponse.Message = _ctx.StringValue("QueryTemplateGroupList.Message");
			queryTemplateGroupListResponse.ErrorCode = _ctx.StringValue("QueryTemplateGroupList.ErrorCode");
			queryTemplateGroupListResponse.ErrorMessage = _ctx.StringValue("QueryTemplateGroupList.ErrorMessage");
			queryTemplateGroupListResponse.Code = _ctx.StringValue("QueryTemplateGroupList.Code");
			queryTemplateGroupListResponse.DynamicCode = _ctx.StringValue("QueryTemplateGroupList.DynamicCode");
			queryTemplateGroupListResponse.DynamicMessage = _ctx.StringValue("QueryTemplateGroupList.DynamicMessage");
			queryTemplateGroupListResponse.PageSize = _ctx.IntegerValue("QueryTemplateGroupList.PageSize");
			queryTemplateGroupListResponse.PageNumber = _ctx.IntegerValue("QueryTemplateGroupList.PageNumber");
			queryTemplateGroupListResponse.TotalCount = _ctx.IntegerValue("QueryTemplateGroupList.TotalCount");

			List<QueryTemplateGroupListResponse.QueryTemplateGroupList_TemplateGroup> queryTemplateGroupListResponse_templateGroupList = new List<QueryTemplateGroupListResponse.QueryTemplateGroupList_TemplateGroup>();
			for (int i = 0; i < _ctx.Length("QueryTemplateGroupList.TemplateGroupList.Length"); i++) {
				QueryTemplateGroupListResponse.QueryTemplateGroupList_TemplateGroup templateGroup = new QueryTemplateGroupListResponse.QueryTemplateGroupList_TemplateGroup();
				templateGroup.GroupId = _ctx.StringValue("QueryTemplateGroupList.TemplateGroupList["+ i +"].GroupId");
				templateGroup.GroupName = _ctx.StringValue("QueryTemplateGroupList.TemplateGroupList["+ i +"].GroupName");
				templateGroup.Description = _ctx.StringValue("QueryTemplateGroupList.TemplateGroupList["+ i +"].Description");
				templateGroup.WidthPx = _ctx.IntegerValue("QueryTemplateGroupList.TemplateGroupList["+ i +"].WidthPx");
				templateGroup.HeightPx = _ctx.IntegerValue("QueryTemplateGroupList.TemplateGroupList["+ i +"].HeightPx");
				templateGroup.Relation = _ctx.StringValue("QueryTemplateGroupList.TemplateGroupList["+ i +"].Relation");

				queryTemplateGroupListResponse_templateGroupList.Add(templateGroup);
			}
			queryTemplateGroupListResponse.TemplateGroupList = queryTemplateGroupListResponse_templateGroupList;
        
			return queryTemplateGroupListResponse;
        }
    }
}
