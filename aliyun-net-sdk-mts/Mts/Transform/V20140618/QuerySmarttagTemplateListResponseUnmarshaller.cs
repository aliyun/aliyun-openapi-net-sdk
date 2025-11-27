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
using Aliyun.Acs.Mts.Model.V20140618;

namespace Aliyun.Acs.Mts.Transform.V20140618
{
    public class QuerySmarttagTemplateListResponseUnmarshaller
    {
        public static QuerySmarttagTemplateListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QuerySmarttagTemplateListResponse querySmarttagTemplateListResponse = new QuerySmarttagTemplateListResponse();

			querySmarttagTemplateListResponse.HttpResponse = _ctx.HttpResponse;
			querySmarttagTemplateListResponse.RequestId = _ctx.StringValue("QuerySmarttagTemplateList.RequestId");

			List<QuerySmarttagTemplateListResponse.QuerySmarttagTemplateList_Template> querySmarttagTemplateListResponse_templates = new List<QuerySmarttagTemplateListResponse.QuerySmarttagTemplateList_Template>();
			for (int i = 0; i < _ctx.Length("QuerySmarttagTemplateList.Templates.Length"); i++) {
				QuerySmarttagTemplateListResponse.QuerySmarttagTemplateList_Template template = new QuerySmarttagTemplateListResponse.QuerySmarttagTemplateList_Template();
				template.AnalyseTypes = _ctx.StringValue("QuerySmarttagTemplateList.Templates["+ i +"].AnalyseTypes");
				template.Industry = _ctx.StringValue("QuerySmarttagTemplateList.Templates["+ i +"].Industry");
				template.IsDefault = _ctx.BooleanValue("QuerySmarttagTemplateList.Templates["+ i +"].IsDefault");
				template.TemplateName = _ctx.StringValue("QuerySmarttagTemplateList.Templates["+ i +"].TemplateName");
				template.TemplateId = _ctx.StringValue("QuerySmarttagTemplateList.Templates["+ i +"].TemplateId");
				template.FaceCategoryIds = _ctx.StringValue("QuerySmarttagTemplateList.Templates["+ i +"].FaceCategoryIds");
				template.FaceCustomParamsConfig = _ctx.StringValue("QuerySmarttagTemplateList.Templates["+ i +"].FaceCustomParamsConfig");
				template.ObjectGroupIds = _ctx.StringValue("QuerySmarttagTemplateList.Templates["+ i +"].ObjectGroupIds");
				template.LandmarkGroupIds = _ctx.StringValue("QuerySmarttagTemplateList.Templates["+ i +"].LandmarkGroupIds");
				template.Scene = _ctx.StringValue("QuerySmarttagTemplateList.Templates["+ i +"].Scene");
				template.LabelType = _ctx.StringValue("QuerySmarttagTemplateList.Templates["+ i +"].LabelType");
				template.LabelVersion = _ctx.StringValue("QuerySmarttagTemplateList.Templates["+ i +"].LabelVersion");
				template.KnowledgeConfig = _ctx.StringValue("QuerySmarttagTemplateList.Templates["+ i +"].KnowledgeConfig");
				template.KeywordConfig = _ctx.StringValue("QuerySmarttagTemplateList.Templates["+ i +"].KeywordConfig");

				querySmarttagTemplateListResponse_templates.Add(template);
			}
			querySmarttagTemplateListResponse.Templates = querySmarttagTemplateListResponse_templates;
        
			return querySmarttagTemplateListResponse;
        }
    }
}
