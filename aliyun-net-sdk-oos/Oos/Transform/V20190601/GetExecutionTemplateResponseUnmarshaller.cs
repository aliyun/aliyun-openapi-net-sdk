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
			getExecutionTemplateResponse.Content = _ctx.StringValue("GetExecutionTemplate.Content");
			getExecutionTemplateResponse.RequestId = _ctx.StringValue("GetExecutionTemplate.RequestId");

			GetExecutionTemplateResponse.GetExecutionTemplate_Template template = new GetExecutionTemplateResponse.GetExecutionTemplate_Template();
			template.Hash = _ctx.StringValue("GetExecutionTemplate.Template.Hash");
			template.UpdatedDate = _ctx.StringValue("GetExecutionTemplate.Template.UpdatedDate");
			template.UpdatedBy = _ctx.StringValue("GetExecutionTemplate.Template.UpdatedBy");
			template.Tags = _ctx.StringValue("GetExecutionTemplate.Template.Tags");
			template.TemplateName = _ctx.StringValue("GetExecutionTemplate.Template.TemplateName");
			template.TemplateVersion = _ctx.StringValue("GetExecutionTemplate.Template.TemplateVersion");
			template.TemplateFormat = _ctx.StringValue("GetExecutionTemplate.Template.TemplateFormat");
			template.Description = _ctx.StringValue("GetExecutionTemplate.Template.Description");
			template.CreatedBy = _ctx.StringValue("GetExecutionTemplate.Template.CreatedBy");
			template.CreatedDate = _ctx.StringValue("GetExecutionTemplate.Template.CreatedDate");
			template.TemplateId = _ctx.StringValue("GetExecutionTemplate.Template.TemplateId");
			template.ShareType = _ctx.StringValue("GetExecutionTemplate.Template.ShareType");
			getExecutionTemplateResponse.Template = template;
        
			return getExecutionTemplateResponse;
        }
    }
}
