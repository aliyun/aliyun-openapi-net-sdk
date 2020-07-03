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
    public class GetTemplateResponseUnmarshaller
    {
        public static GetTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			GetTemplateResponse getTemplateResponse = new GetTemplateResponse();

			getTemplateResponse.HttpResponse = context.HttpResponse;
			getTemplateResponse.RequestId = context.StringValue("GetTemplate.RequestId");
			getTemplateResponse.Content = context.StringValue("GetTemplate.Content");

			GetTemplateResponse.GetTemplate_Template template = new GetTemplateResponse.GetTemplate_Template();
			template.TemplateName = context.StringValue("GetTemplate.Template.TemplateName");
			template.TemplateId = context.StringValue("GetTemplate.Template.TemplateId");
			template.CreatedDate = context.StringValue("GetTemplate.Template.CreatedDate");
			template.CreatedBy = context.StringValue("GetTemplate.Template.CreatedBy");
			template.UpdatedDate = context.StringValue("GetTemplate.Template.UpdatedDate");
			template.UpdatedBy = context.StringValue("GetTemplate.Template.UpdatedBy");
			template.Hash = context.StringValue("GetTemplate.Template.Hash");
			template.Description = context.StringValue("GetTemplate.Template.Description");
			template.ShareType = context.StringValue("GetTemplate.Template.ShareType");
			template.TemplateFormat = context.StringValue("GetTemplate.Template.TemplateFormat");
			template.TemplateVersion = context.StringValue("GetTemplate.Template.TemplateVersion");
			template.HasTrigger = context.BooleanValue("GetTemplate.Template.HasTrigger");
			template.Tags = context.StringValue("GetTemplate.Template.Tags");
			template.TemplateType = context.StringValue("GetTemplate.Template.TemplateType");
			template.VersionName = context.StringValue("GetTemplate.Template.VersionName");
			getTemplateResponse.Template = template;
        
			return getTemplateResponse;
        }
    }
}
