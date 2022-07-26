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
        public static GetTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetTemplateResponse getTemplateResponse = new GetTemplateResponse();

			getTemplateResponse.HttpResponse = _ctx.HttpResponse;
			getTemplateResponse.Content = _ctx.StringValue("GetTemplate.Content");
			getTemplateResponse.RequestId = _ctx.StringValue("GetTemplate.RequestId");

			GetTemplateResponse.GetTemplate_Template template = new GetTemplateResponse.GetTemplate_Template();
			template.Hash = _ctx.StringValue("GetTemplate.Template.Hash");
			template.UpdatedDate = _ctx.StringValue("GetTemplate.Template.UpdatedDate");
			template.UpdatedBy = _ctx.StringValue("GetTemplate.Template.UpdatedBy");
			template.TemplateType = _ctx.StringValue("GetTemplate.Template.TemplateType");
			template.Tags = _ctx.StringValue("GetTemplate.Template.Tags");
			template.TemplateName = _ctx.StringValue("GetTemplate.Template.TemplateName");
			template.TemplateVersion = _ctx.StringValue("GetTemplate.Template.TemplateVersion");
			template.TemplateFormat = _ctx.StringValue("GetTemplate.Template.TemplateFormat");
			template.Description = _ctx.StringValue("GetTemplate.Template.Description");
			template.ResourceGroupId = _ctx.StringValue("GetTemplate.Template.ResourceGroupId");
			template.CreatedBy = _ctx.StringValue("GetTemplate.Template.CreatedBy");
			template.CreatedDate = _ctx.StringValue("GetTemplate.Template.CreatedDate");
			template.VersionName = _ctx.StringValue("GetTemplate.Template.VersionName");
			template.TemplateId = _ctx.StringValue("GetTemplate.Template.TemplateId");
			template.HasTrigger = _ctx.BooleanValue("GetTemplate.Template.HasTrigger");
			template.ShareType = _ctx.StringValue("GetTemplate.Template.ShareType");
			getTemplateResponse.Template = template;
        
			return getTemplateResponse;
        }
    }
}
