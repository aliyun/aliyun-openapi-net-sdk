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
        public static ListTemplatesResponse Unmarshall(UnmarshallerContext context)
        {
			ListTemplatesResponse listTemplatesResponse = new ListTemplatesResponse();

			listTemplatesResponse.HttpResponse = context.HttpResponse;
			listTemplatesResponse.RequestId = context.StringValue("ListTemplates.RequestId");
			listTemplatesResponse.MaxResults = context.IntegerValue("ListTemplates.MaxResults");
			listTemplatesResponse.NextToken = context.StringValue("ListTemplates.NextToken");

			List<ListTemplatesResponse.ListTemplates_Template> listTemplatesResponse_templates = new List<ListTemplatesResponse.ListTemplates_Template>();
			for (int i = 0; i < context.Length("ListTemplates.Templates.Length"); i++) {
				ListTemplatesResponse.ListTemplates_Template template = new ListTemplatesResponse.ListTemplates_Template();
				template.TemplateName = context.StringValue("ListTemplates.Templates["+ i +"].TemplateName");
				template.TemplateId = context.StringValue("ListTemplates.Templates["+ i +"].TemplateId");
				template.CreatedDate = context.StringValue("ListTemplates.Templates["+ i +"].CreatedDate");
				template.CreatedBy = context.StringValue("ListTemplates.Templates["+ i +"].CreatedBy");
				template.UpdatedDate = context.StringValue("ListTemplates.Templates["+ i +"].UpdatedDate");
				template.UpdatedBy = context.StringValue("ListTemplates.Templates["+ i +"].UpdatedBy");
				template.Hash = context.StringValue("ListTemplates.Templates["+ i +"].Hash");
				template.Description = context.StringValue("ListTemplates.Templates["+ i +"].Description");
				template.ShareType = context.StringValue("ListTemplates.Templates["+ i +"].ShareType");
				template.TemplateFormat = context.StringValue("ListTemplates.Templates["+ i +"].TemplateFormat");
				template.TemplateVersion = context.StringValue("ListTemplates.Templates["+ i +"].TemplateVersion");
				template.HasTrigger = context.BooleanValue("ListTemplates.Templates["+ i +"].HasTrigger");
				template.TotalExecutionCount = context.IntegerValue("ListTemplates.Templates["+ i +"].TotalExecutionCount");
				template.Popularity = context.IntegerValue("ListTemplates.Templates["+ i +"].Popularity");
				template.Tags = context.StringValue("ListTemplates.Templates["+ i +"].Tags");
				template.Category = context.StringValue("ListTemplates.Templates["+ i +"].Category");
				template.TemplateType = context.StringValue("ListTemplates.Templates["+ i +"].TemplateType");

				listTemplatesResponse_templates.Add(template);
			}
			listTemplatesResponse.Templates = listTemplatesResponse_templates;
        
			return listTemplatesResponse;
        }
    }
}
