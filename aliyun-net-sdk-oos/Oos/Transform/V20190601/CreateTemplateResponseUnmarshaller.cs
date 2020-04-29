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
    public class CreateTemplateResponseUnmarshaller
    {
        public static CreateTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			CreateTemplateResponse createTemplateResponse = new CreateTemplateResponse();

			createTemplateResponse.HttpResponse = context.HttpResponse;
			createTemplateResponse.RequestId = context.StringValue("CreateTemplate.RequestId");
			createTemplateResponse.TemplateType = context.StringValue("CreateTemplate.TemplateType");

			CreateTemplateResponse.CreateTemplate_Template template = new CreateTemplateResponse.CreateTemplate_Template();
			template.TemplateName = context.StringValue("CreateTemplate.Template.TemplateName");
			template.TemplateId = context.StringValue("CreateTemplate.Template.TemplateId");
			template.CreatedDate = context.StringValue("CreateTemplate.Template.CreatedDate");
			template.CreatedBy = context.StringValue("CreateTemplate.Template.CreatedBy");
			template.UpdatedDate = context.StringValue("CreateTemplate.Template.UpdatedDate");
			template.UpdatedBy = context.StringValue("CreateTemplate.Template.UpdatedBy");
			template.Hash = context.StringValue("CreateTemplate.Template.Hash");
			template.Description = context.StringValue("CreateTemplate.Template.Description");
			template.ShareType = context.StringValue("CreateTemplate.Template.ShareType");
			template.TemplateFormat = context.StringValue("CreateTemplate.Template.TemplateFormat");
			template.TemplateVersion = context.StringValue("CreateTemplate.Template.TemplateVersion");
			template.HasTrigger = context.BooleanValue("CreateTemplate.Template.HasTrigger");
			template.Tags = context.StringValue("CreateTemplate.Template.Tags");
			createTemplateResponse.Template = template;
        
			return createTemplateResponse;
        }
    }
}
