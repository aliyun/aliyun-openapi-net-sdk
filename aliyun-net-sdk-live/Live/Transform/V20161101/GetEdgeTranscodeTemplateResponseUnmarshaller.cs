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
using Aliyun.Acs.live.Model.V20161101;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class GetEdgeTranscodeTemplateResponseUnmarshaller
    {
        public static GetEdgeTranscodeTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetEdgeTranscodeTemplateResponse getEdgeTranscodeTemplateResponse = new GetEdgeTranscodeTemplateResponse();

			getEdgeTranscodeTemplateResponse.HttpResponse = _ctx.HttpResponse;
			getEdgeTranscodeTemplateResponse.RequestId = _ctx.StringValue("GetEdgeTranscodeTemplate.RequestId");

			GetEdgeTranscodeTemplateResponse.GetEdgeTranscodeTemplate_Template template = new GetEdgeTranscodeTemplateResponse.GetEdgeTranscodeTemplate_Template();
			template.Type = _ctx.StringValue("GetEdgeTranscodeTemplate.Template.Type");
			template.Gop = _ctx.StringValue("GetEdgeTranscodeTemplate.Template.Gop");
			template.CreateTime = _ctx.StringValue("GetEdgeTranscodeTemplate.Template.CreateTime");
			template.Codec = _ctx.StringValue("GetEdgeTranscodeTemplate.Template.Codec");
			template.Fps = _ctx.StringValue("GetEdgeTranscodeTemplate.Template.Fps");
			template.Bitrate = _ctx.StringValue("GetEdgeTranscodeTemplate.Template.Bitrate");
			template.Name = _ctx.StringValue("GetEdgeTranscodeTemplate.Template.Name");
			template.Resolution = _ctx.StringValue("GetEdgeTranscodeTemplate.Template.Resolution");
			template.TemplateId = _ctx.StringValue("GetEdgeTranscodeTemplate.Template.TemplateId");
			getEdgeTranscodeTemplateResponse.Template = template;
        
			return getEdgeTranscodeTemplateResponse;
        }
    }
}
