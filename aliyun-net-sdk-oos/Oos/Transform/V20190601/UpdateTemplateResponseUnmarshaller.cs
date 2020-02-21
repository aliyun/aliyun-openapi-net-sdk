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
    public class UpdateTemplateResponseUnmarshaller
    {
        public static UpdateTemplateResponse Unmarshall(UnmarshallerContext context)
        {
			UpdateTemplateResponse updateTemplateResponse = new UpdateTemplateResponse();

			updateTemplateResponse.HttpResponse = context.HttpResponse;
			updateTemplateResponse.RequestId = context.StringValue("UpdateTemplate.RequestId");

			UpdateTemplateResponse.UpdateTemplate_Template template = new UpdateTemplateResponse.UpdateTemplate_Template();
			template.TemplateName = context.StringValue("UpdateTemplate.Template.TemplateName");
			template.TemplateId = context.StringValue("UpdateTemplate.Template.TemplateId");
			template.CreatedDate = context.StringValue("UpdateTemplate.Template.CreatedDate");
			template.CreatedBy = context.StringValue("UpdateTemplate.Template.CreatedBy");
			template.UpdatedDate = context.StringValue("UpdateTemplate.Template.UpdatedDate");
			template.UpdatedBy = context.StringValue("UpdateTemplate.Template.UpdatedBy");
			template.Hash = context.StringValue("UpdateTemplate.Template.Hash");
			template.Description = context.StringValue("UpdateTemplate.Template.Description");
			template.ShareType = context.StringValue("UpdateTemplate.Template.ShareType");
			template.TemplateFormat = context.StringValue("UpdateTemplate.Template.TemplateFormat");
			template.TemplateVersion = context.StringValue("UpdateTemplate.Template.TemplateVersion");
			template.HasTrigger = context.BooleanValue("UpdateTemplate.Template.HasTrigger");
			template.Tags = context.StringValue("UpdateTemplate.Template.Tags");
			updateTemplateResponse.Template = template;
        
			return updateTemplateResponse;
        }
    }
}
