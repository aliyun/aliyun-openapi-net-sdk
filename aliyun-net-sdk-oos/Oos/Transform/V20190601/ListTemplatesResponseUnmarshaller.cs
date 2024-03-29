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
using Aliyun.Acs.oos.Model.V20190601;

namespace Aliyun.Acs.oos.Transform.V20190601
{
    public class ListTemplatesResponseUnmarshaller
    {
        public static ListTemplatesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTemplatesResponse listTemplatesResponse = new ListTemplatesResponse();

			listTemplatesResponse.HttpResponse = _ctx.HttpResponse;
			listTemplatesResponse.NextToken = _ctx.StringValue("ListTemplates.NextToken");
			listTemplatesResponse.RequestId = _ctx.StringValue("ListTemplates.RequestId");
			listTemplatesResponse.MaxResults = _ctx.IntegerValue("ListTemplates.MaxResults");

			List<ListTemplatesResponse.ListTemplates_Template> listTemplatesResponse_templates = new List<ListTemplatesResponse.ListTemplates_Template>();
			for (int i = 0; i < _ctx.Length("ListTemplates.Templates.Length"); i++) {
				ListTemplatesResponse.ListTemplates_Template template = new ListTemplatesResponse.ListTemplates_Template();
				template.Hash = _ctx.StringValue("ListTemplates.Templates["+ i +"].Hash");
				template.UpdatedDate = _ctx.StringValue("ListTemplates.Templates["+ i +"].UpdatedDate");
				template.UpdatedBy = _ctx.StringValue("ListTemplates.Templates["+ i +"].UpdatedBy");
				template.TemplateType = _ctx.StringValue("ListTemplates.Templates["+ i +"].TemplateType");
				template.Tags = _ctx.StringValue("ListTemplates.Templates["+ i +"].Tags");
				template.TemplateName = _ctx.StringValue("ListTemplates.Templates["+ i +"].TemplateName");
				template.TemplateVersion = _ctx.StringValue("ListTemplates.Templates["+ i +"].TemplateVersion");
				template.TemplateFormat = _ctx.StringValue("ListTemplates.Templates["+ i +"].TemplateFormat");
				template.Popularity = _ctx.IntegerValue("ListTemplates.Templates["+ i +"].Popularity");
				template.TotalExecutionCount = _ctx.IntegerValue("ListTemplates.Templates["+ i +"].TotalExecutionCount");
				template.Description = _ctx.StringValue("ListTemplates.Templates["+ i +"].Description");
				template.ResourceGroupId = _ctx.StringValue("ListTemplates.Templates["+ i +"].ResourceGroupId");
				template.CreatedBy = _ctx.StringValue("ListTemplates.Templates["+ i +"].CreatedBy");
				template.CreatedDate = _ctx.StringValue("ListTemplates.Templates["+ i +"].CreatedDate");
				template.Category = _ctx.StringValue("ListTemplates.Templates["+ i +"].Category");
				template.HasTrigger = _ctx.BooleanValue("ListTemplates.Templates["+ i +"].HasTrigger");
				template.TemplateId = _ctx.StringValue("ListTemplates.Templates["+ i +"].TemplateId");
				template.ShareType = _ctx.StringValue("ListTemplates.Templates["+ i +"].ShareType");

				listTemplatesResponse_templates.Add(template);
			}
			listTemplatesResponse.Templates = listTemplatesResponse_templates;
        
			return listTemplatesResponse;
        }
    }
}
