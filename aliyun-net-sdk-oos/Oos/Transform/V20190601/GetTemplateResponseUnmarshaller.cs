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
			getTemplateResponse.RequestId = _ctx.StringValue("GetTemplate.RequestId");
			getTemplateResponse.Content = _ctx.StringValue("GetTemplate.Content");

			GetTemplateResponse.GetTemplate_Template template = new GetTemplateResponse.GetTemplate_Template();
			template.TemplateName = _ctx.StringValue("GetTemplate.Template.TemplateName");
			template.TemplateId = _ctx.StringValue("GetTemplate.Template.TemplateId");
			template.CreatedDate = _ctx.StringValue("GetTemplate.Template.CreatedDate");
			template.CreatedBy = _ctx.StringValue("GetTemplate.Template.CreatedBy");
			template.UpdatedDate = _ctx.StringValue("GetTemplate.Template.UpdatedDate");
			template.UpdatedBy = _ctx.StringValue("GetTemplate.Template.UpdatedBy");
			template.Hash = _ctx.StringValue("GetTemplate.Template.Hash");
			template.Description = _ctx.StringValue("GetTemplate.Template.Description");
			template.ShareType = _ctx.StringValue("GetTemplate.Template.ShareType");
			template.TemplateFormat = _ctx.StringValue("GetTemplate.Template.TemplateFormat");
			template.TemplateVersion = _ctx.StringValue("GetTemplate.Template.TemplateVersion");
			template.HasTrigger = _ctx.BooleanValue("GetTemplate.Template.HasTrigger");
			template.Tags = _ctx.StringValue("GetTemplate.Template.Tags");
			template.TemplateType = _ctx.StringValue("GetTemplate.Template.TemplateType");
			template.VersionName = _ctx.StringValue("GetTemplate.Template.VersionName");
			getTemplateResponse.Template = template;
        
			return getTemplateResponse;
        }
    }
}
