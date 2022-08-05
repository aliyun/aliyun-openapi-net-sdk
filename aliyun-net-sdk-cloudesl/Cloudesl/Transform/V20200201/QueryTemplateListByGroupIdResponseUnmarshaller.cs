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
    public class QueryTemplateListByGroupIdResponseUnmarshaller
    {
        public static QueryTemplateListByGroupIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryTemplateListByGroupIdResponse queryTemplateListByGroupIdResponse = new QueryTemplateListByGroupIdResponse();

			queryTemplateListByGroupIdResponse.HttpResponse = _ctx.HttpResponse;
			queryTemplateListByGroupIdResponse.RequestId = _ctx.StringValue("QueryTemplateListByGroupId.RequestId");
			queryTemplateListByGroupIdResponse.ErrorMessage = _ctx.StringValue("QueryTemplateListByGroupId.ErrorMessage");
			queryTemplateListByGroupIdResponse.Success = _ctx.BooleanValue("QueryTemplateListByGroupId.Success");
			queryTemplateListByGroupIdResponse.ErrorCode = _ctx.StringValue("QueryTemplateListByGroupId.ErrorCode");
			queryTemplateListByGroupIdResponse.Code = _ctx.StringValue("QueryTemplateListByGroupId.Code");
			queryTemplateListByGroupIdResponse.Message = _ctx.StringValue("QueryTemplateListByGroupId.Message");
			queryTemplateListByGroupIdResponse.DynamicMessage = _ctx.StringValue("QueryTemplateListByGroupId.DynamicMessage");
			queryTemplateListByGroupIdResponse.DynamicCode = _ctx.StringValue("QueryTemplateListByGroupId.DynamicCode");
			queryTemplateListByGroupIdResponse.TotalCount = _ctx.IntegerValue("QueryTemplateListByGroupId.TotalCount");
			queryTemplateListByGroupIdResponse.PageSize = _ctx.IntegerValue("QueryTemplateListByGroupId.PageSize");
			queryTemplateListByGroupIdResponse.PageNumber = _ctx.IntegerValue("QueryTemplateListByGroupId.PageNumber");

			List<QueryTemplateListByGroupIdResponse.QueryTemplateListByGroupId_Template> queryTemplateListByGroupIdResponse_templateList = new List<QueryTemplateListByGroupIdResponse.QueryTemplateListByGroupId_Template>();
			for (int i = 0; i < _ctx.Length("QueryTemplateListByGroupId.TemplateList.Length"); i++) {
				QueryTemplateListByGroupIdResponse.QueryTemplateListByGroupId_Template template = new QueryTemplateListByGroupIdResponse.QueryTemplateListByGroupId_Template();
				template.BasePicture = _ctx.StringValue("QueryTemplateListByGroupId.TemplateList["+ i +"].BasePicture");
				template.TemplateId = _ctx.StringValue("QueryTemplateListByGroupId.TemplateList["+ i +"].TemplateId");
				template.TemplateName = _ctx.StringValue("QueryTemplateListByGroupId.TemplateList["+ i +"].TemplateName");
				template.EslSize = _ctx.StringValue("QueryTemplateListByGroupId.TemplateList["+ i +"].EslSize");
				template.EslType = _ctx.StringValue("QueryTemplateListByGroupId.TemplateList["+ i +"].EslType");
				template.Width = _ctx.LongValue("QueryTemplateListByGroupId.TemplateList["+ i +"].Width");
				template.Height = _ctx.LongValue("QueryTemplateListByGroupId.TemplateList["+ i +"].Height");
				template.TemplateVersion = _ctx.StringValue("QueryTemplateListByGroupId.TemplateList["+ i +"].TemplateVersion");
				template.Layout = _ctx.StringValue("QueryTemplateListByGroupId.TemplateList["+ i +"].Layout");
				template.Scene = _ctx.StringValue("QueryTemplateListByGroupId.TemplateList["+ i +"].Scene");
				template.Brand = _ctx.StringValue("QueryTemplateListByGroupId.TemplateList["+ i +"].Brand");
				template.GroupId = _ctx.StringValue("QueryTemplateListByGroupId.TemplateList["+ i +"].GroupId");
				template.TemplateSceneId = _ctx.StringValue("QueryTemplateListByGroupId.TemplateList["+ i +"].TemplateSceneId");
				template.Relation = _ctx.BooleanValue("QueryTemplateListByGroupId.TemplateList["+ i +"].Relation");

				queryTemplateListByGroupIdResponse_templateList.Add(template);
			}
			queryTemplateListByGroupIdResponse.TemplateList = queryTemplateListByGroupIdResponse_templateList;
        
			return queryTemplateListByGroupIdResponse;
        }
    }
}
