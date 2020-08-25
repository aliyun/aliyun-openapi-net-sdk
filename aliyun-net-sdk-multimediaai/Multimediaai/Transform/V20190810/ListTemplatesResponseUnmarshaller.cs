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
using Aliyun.Acs.multimediaai.Model.V20190810;

namespace Aliyun.Acs.multimediaai.Transform.V20190810
{
    public class ListTemplatesResponseUnmarshaller
    {
        public static ListTemplatesResponse Unmarshall(UnmarshallerContext context)
        {
			ListTemplatesResponse listTemplatesResponse = new ListTemplatesResponse();

			listTemplatesResponse.HttpResponse = context.HttpResponse;
			listTemplatesResponse.RequestId = context.StringValue("ListTemplates.RequestId");
			listTemplatesResponse.PageNumber = context.IntegerValue("ListTemplates.PageNumber");
			listTemplatesResponse.PageSize = context.IntegerValue("ListTemplates.PageSize");
			listTemplatesResponse.TotalCount = context.LongValue("ListTemplates.TotalCount");
			listTemplatesResponse.TotalAmount = context.LongValue("ListTemplates.TotalAmount");

			List<ListTemplatesResponse.ListTemplates_Template> listTemplatesResponse_templates = new List<ListTemplatesResponse.ListTemplates_Template>();
			for (int i = 0; i < context.Length("ListTemplates.Templates.Length"); i++) {
				ListTemplatesResponse.ListTemplates_Template template = new ListTemplatesResponse.ListTemplates_Template();
				template.TemplateId = context.StringValue("ListTemplates.Templates["+ i +"].TemplateId");
				template.TemplateName = context.StringValue("ListTemplates.Templates["+ i +"].TemplateName");
				template.Type = context.IntegerValue("ListTemplates.Templates["+ i +"].Type");
				template.IsDefault = context.BooleanValue("ListTemplates.Templates["+ i +"].IsDefault");
				template.CreateTime = context.StringValue("ListTemplates.Templates["+ i +"].CreateTime");
				template.UpdateTime = context.StringValue("ListTemplates.Templates["+ i +"].UpdateTime");

				listTemplatesResponse_templates.Add(template);
			}
			listTemplatesResponse.Templates = listTemplatesResponse_templates;
        
			return listTemplatesResponse;
        }
    }
}
