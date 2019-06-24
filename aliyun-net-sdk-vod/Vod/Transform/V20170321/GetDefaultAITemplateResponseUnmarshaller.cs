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
        public static GetDefaultAITemplateResponse Unmarshall(UnmarshallerContext context)
        {
			GetDefaultAITemplateResponse getDefaultAITemplateResponse = new GetDefaultAITemplateResponse();

			getDefaultAITemplateResponse.HttpResponse = context.HttpResponse;
			getDefaultAITemplateResponse.RequestId = context.StringValue("GetDefaultAITemplate.RequestId");

			GetDefaultAITemplateResponse.GetDefaultAITemplate_TemplateInfo templateInfo = new GetDefaultAITemplateResponse.GetDefaultAITemplate_TemplateInfo();
			templateInfo.TemplateId = context.StringValue("GetDefaultAITemplate.TemplateInfo.TemplateId");
			templateInfo.TemplateType = context.StringValue("GetDefaultAITemplate.TemplateInfo.TemplateType");
			templateInfo.TemplateName = context.StringValue("GetDefaultAITemplate.TemplateInfo.TemplateName");
			templateInfo.TemplateConfig = context.StringValue("GetDefaultAITemplate.TemplateInfo.TemplateConfig");
			templateInfo.Source = context.StringValue("GetDefaultAITemplate.TemplateInfo.Source");
			templateInfo.IsDefault = context.StringValue("GetDefaultAITemplate.TemplateInfo.IsDefault");
			templateInfo.CreationTime = context.StringValue("GetDefaultAITemplate.TemplateInfo.CreationTime");
			templateInfo.ModifyTime = context.StringValue("GetDefaultAITemplate.TemplateInfo.ModifyTime");
			getDefaultAITemplateResponse.TemplateInfo = templateInfo;
        
			return getDefaultAITemplateResponse;
        }
    }
}
