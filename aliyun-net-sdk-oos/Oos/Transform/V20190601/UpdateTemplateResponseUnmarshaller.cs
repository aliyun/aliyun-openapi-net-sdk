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
        public static UpdateTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UpdateTemplateResponse updateTemplateResponse = new UpdateTemplateResponse();

			updateTemplateResponse.HttpResponse = _ctx.HttpResponse;
			updateTemplateResponse.RequestId = _ctx.StringValue("UpdateTemplate.RequestId");

			UpdateTemplateResponse.UpdateTemplate_Template template = new UpdateTemplateResponse.UpdateTemplate_Template();
			template.TemplateName = _ctx.StringValue("UpdateTemplate.Template.TemplateName");
			template.TemplateId = _ctx.StringValue("UpdateTemplate.Template.TemplateId");
			template.CreatedDate = _ctx.StringValue("UpdateTemplate.Template.CreatedDate");
			template.CreatedBy = _ctx.StringValue("UpdateTemplate.Template.CreatedBy");
			template.UpdatedDate = _ctx.StringValue("UpdateTemplate.Template.UpdatedDate");
			template.UpdatedBy = _ctx.StringValue("UpdateTemplate.Template.UpdatedBy");
			template.Hash = _ctx.StringValue("UpdateTemplate.Template.Hash");
			template.Description = _ctx.StringValue("UpdateTemplate.Template.Description");
			template.ShareType = _ctx.StringValue("UpdateTemplate.Template.ShareType");
			template.TemplateFormat = _ctx.StringValue("UpdateTemplate.Template.TemplateFormat");
			template.TemplateVersion = _ctx.StringValue("UpdateTemplate.Template.TemplateVersion");
			template.HasTrigger = _ctx.BooleanValue("UpdateTemplate.Template.HasTrigger");
			template.Tags = _ctx.StringValue("UpdateTemplate.Template.Tags");
			updateTemplateResponse.Template = template;
        
			return updateTemplateResponse;
        }
    }
}
