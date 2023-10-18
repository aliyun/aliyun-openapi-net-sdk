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
    public class ListEdgeTranscodeTemplateResponseUnmarshaller
    {
        public static ListEdgeTranscodeTemplateResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListEdgeTranscodeTemplateResponse listEdgeTranscodeTemplateResponse = new ListEdgeTranscodeTemplateResponse();

			listEdgeTranscodeTemplateResponse.HttpResponse = _ctx.HttpResponse;
			listEdgeTranscodeTemplateResponse.TotalCount = _ctx.IntegerValue("ListEdgeTranscodeTemplate.TotalCount");
			listEdgeTranscodeTemplateResponse.RequestId = _ctx.StringValue("ListEdgeTranscodeTemplate.RequestId");

			List<ListEdgeTranscodeTemplateResponse.ListEdgeTranscodeTemplate_Template> listEdgeTranscodeTemplateResponse_templateList = new List<ListEdgeTranscodeTemplateResponse.ListEdgeTranscodeTemplate_Template>();
			for (int i = 0; i < _ctx.Length("ListEdgeTranscodeTemplate.TemplateList.Length"); i++) {
				ListEdgeTranscodeTemplateResponse.ListEdgeTranscodeTemplate_Template template = new ListEdgeTranscodeTemplateResponse.ListEdgeTranscodeTemplate_Template();
				template.Type = _ctx.StringValue("ListEdgeTranscodeTemplate.TemplateList["+ i +"].Type");
				template.Gop = _ctx.StringValue("ListEdgeTranscodeTemplate.TemplateList["+ i +"].Gop");
				template.CreateTime = _ctx.StringValue("ListEdgeTranscodeTemplate.TemplateList["+ i +"].CreateTime");
				template.Codec = _ctx.StringValue("ListEdgeTranscodeTemplate.TemplateList["+ i +"].Codec");
				template.Fps = _ctx.StringValue("ListEdgeTranscodeTemplate.TemplateList["+ i +"].Fps");
				template.Bitrate = _ctx.StringValue("ListEdgeTranscodeTemplate.TemplateList["+ i +"].Bitrate");
				template.Name = _ctx.StringValue("ListEdgeTranscodeTemplate.TemplateList["+ i +"].Name");
				template.Resolution = _ctx.StringValue("ListEdgeTranscodeTemplate.TemplateList["+ i +"].Resolution");
				template.TemplateId = _ctx.StringValue("ListEdgeTranscodeTemplate.TemplateList["+ i +"].TemplateId");

				listEdgeTranscodeTemplateResponse_templateList.Add(template);
			}
			listEdgeTranscodeTemplateResponse.TemplateList = listEdgeTranscodeTemplateResponse_templateList;
        
			return listEdgeTranscodeTemplateResponse;
        }
    }
}
