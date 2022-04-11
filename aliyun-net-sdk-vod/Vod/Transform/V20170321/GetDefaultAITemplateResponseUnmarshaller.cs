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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class GetDefaultAITemplateResponseUnmarshaller
    {
        public static GetDefaultAITemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetDefaultAITemplateResponse getDefaultAITemplateResponse = new GetDefaultAITemplateResponse();

			getDefaultAITemplateResponse.HttpResponse = _ctx.HttpResponse;
			getDefaultAITemplateResponse.RequestId = _ctx.StringValue("GetDefaultAITemplate.RequestId");

			GetDefaultAITemplateResponse.GetDefaultAITemplate_TemplateInfo templateInfo = new GetDefaultAITemplateResponse.GetDefaultAITemplate_TemplateInfo();
			templateInfo.CreationTime = _ctx.StringValue("GetDefaultAITemplate.TemplateInfo.CreationTime");
			templateInfo.IsDefault = _ctx.StringValue("GetDefaultAITemplate.TemplateInfo.IsDefault");
			templateInfo.TemplateType = _ctx.StringValue("GetDefaultAITemplate.TemplateInfo.TemplateType");
			templateInfo.TemplateConfig = _ctx.StringValue("GetDefaultAITemplate.TemplateInfo.TemplateConfig");
			templateInfo.TemplateName = _ctx.StringValue("GetDefaultAITemplate.TemplateInfo.TemplateName");
			templateInfo.Source = _ctx.StringValue("GetDefaultAITemplate.TemplateInfo.Source");
			templateInfo.TemplateId = _ctx.StringValue("GetDefaultAITemplate.TemplateInfo.TemplateId");
			templateInfo.ModifyTime = _ctx.StringValue("GetDefaultAITemplate.TemplateInfo.ModifyTime");
			getDefaultAITemplateResponse.TemplateInfo = templateInfo;
        
			return getDefaultAITemplateResponse;
        }
    }
}
