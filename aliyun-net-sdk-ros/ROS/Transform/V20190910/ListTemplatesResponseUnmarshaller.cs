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
using Aliyun.Acs.ROS.Model.V20190910;

namespace Aliyun.Acs.ROS.Transform.V20190910
{
    public class ListTemplatesResponseUnmarshaller
    {
        public static ListTemplatesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListTemplatesResponse listTemplatesResponse = new ListTemplatesResponse();

			listTemplatesResponse.HttpResponse = _ctx.HttpResponse;
			listTemplatesResponse.PageNumber = _ctx.IntegerValue("ListTemplates.PageNumber");
			listTemplatesResponse.PageSize = _ctx.IntegerValue("ListTemplates.PageSize");
			listTemplatesResponse.RequestId = _ctx.StringValue("ListTemplates.RequestId");
			listTemplatesResponse.TotalCount = _ctx.IntegerValue("ListTemplates.TotalCount");

			List<ListTemplatesResponse.ListTemplates_Template> listTemplatesResponse_templates = new List<ListTemplatesResponse.ListTemplates_Template>();
			for (int i = 0; i < _ctx.Length("ListTemplates.Templates.Length"); i++) {
				ListTemplatesResponse.ListTemplates_Template template = new ListTemplatesResponse.ListTemplates_Template();
				template.CreateTime = _ctx.StringValue("ListTemplates.Templates["+ i +"].CreateTime");
				template.Description = _ctx.StringValue("ListTemplates.Templates["+ i +"].Description");
				template.TemplateId = _ctx.StringValue("ListTemplates.Templates["+ i +"].TemplateId");
				template.TemplateName = _ctx.StringValue("ListTemplates.Templates["+ i +"].TemplateName");
				template.UpdateTime = _ctx.StringValue("ListTemplates.Templates["+ i +"].UpdateTime");
				template.TemplateVersion = _ctx.StringValue("ListTemplates.Templates["+ i +"].TemplateVersion");
				template.ShareType = _ctx.StringValue("ListTemplates.Templates["+ i +"].ShareType");
				template.OwnerId = _ctx.StringValue("ListTemplates.Templates["+ i +"].OwnerId");
				template.TemplateARN = _ctx.StringValue("ListTemplates.Templates["+ i +"].TemplateARN");

				listTemplatesResponse_templates.Add(template);
			}
			listTemplatesResponse.Templates = listTemplatesResponse_templates;
        
			return listTemplatesResponse;
        }
    }
}
