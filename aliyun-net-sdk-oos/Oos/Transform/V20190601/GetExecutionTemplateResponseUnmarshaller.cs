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
    public class GetExecutionTemplateResponseUnmarshaller
    {
        public static GetExecutionTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetExecutionTemplateResponse getExecutionTemplateResponse = new GetExecutionTemplateResponse();

			getExecutionTemplateResponse.HttpResponse = _ctx.HttpResponse;
			getExecutionTemplateResponse.RequestId = _ctx.StringValue("GetExecutionTemplate.RequestId");
			getExecutionTemplateResponse.Content = _ctx.StringValue("GetExecutionTemplate.Content");

			GetExecutionTemplateResponse.GetExecutionTemplate_Template template = new GetExecutionTemplateResponse.GetExecutionTemplate_Template();
			template.TemplateName = _ctx.StringValue("GetExecutionTemplate.Template.TemplateName");
			template.TemplateId = _ctx.StringValue("GetExecutionTemplate.Template.TemplateId");
			template.CreatedDate = _ctx.StringValue("GetExecutionTemplate.Template.CreatedDate");
			template.CreatedBy = _ctx.StringValue("GetExecutionTemplate.Template.CreatedBy");
			template.UpdatedDate = _ctx.StringValue("GetExecutionTemplate.Template.UpdatedDate");
			template.UpdatedBy = _ctx.StringValue("GetExecutionTemplate.Template.UpdatedBy");
			template.Hash = _ctx.StringValue("GetExecutionTemplate.Template.Hash");
			template.Description = _ctx.StringValue("GetExecutionTemplate.Template.Description");
			template.ShareType = _ctx.StringValue("GetExecutionTemplate.Template.ShareType");
			template.TemplateFormat = _ctx.StringValue("GetExecutionTemplate.Template.TemplateFormat");
			template.TemplateVersion = _ctx.StringValue("GetExecutionTemplate.Template.TemplateVersion");
			template.Tags = _ctx.StringValue("GetExecutionTemplate.Template.Tags");
			getExecutionTemplateResponse.Template = template;
        
			return getExecutionTemplateResponse;
        }
    }
}
