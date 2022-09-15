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
    public class AddMultiRateConfigResponseUnmarshaller
    {
        public static AddMultiRateConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			AddMultiRateConfigResponse addMultiRateConfigResponse = new AddMultiRateConfigResponse();

			addMultiRateConfigResponse.HttpResponse = _ctx.HttpResponse;
			addMultiRateConfigResponse.Code = _ctx.IntegerValue("AddMultiRateConfig.Code");
			addMultiRateConfigResponse.Message = _ctx.StringValue("AddMultiRateConfig.Message");
			addMultiRateConfigResponse.RequestId = _ctx.StringValue("AddMultiRateConfig.RequestId");

			List<AddMultiRateConfigResponse.AddMultiRateConfig_FailedTemplates> addMultiRateConfigResponse_body = new List<AddMultiRateConfigResponse.AddMultiRateConfig_FailedTemplates>();
			for (int i = 0; i < _ctx.Length("AddMultiRateConfig.Body.Length"); i++) {
				AddMultiRateConfigResponse.AddMultiRateConfig_FailedTemplates failedTemplates = new AddMultiRateConfigResponse.AddMultiRateConfig_FailedTemplates();
				failedTemplates.AudioBitrate = _ctx.IntegerValue("AddMultiRateConfig.Body["+ i +"].AudioBitrate");
				failedTemplates.Template = _ctx.StringValue("AddMultiRateConfig.Body["+ i +"].Template");
				failedTemplates.Height = _ctx.IntegerValue("AddMultiRateConfig.Body["+ i +"].Height");
				failedTemplates.TemplateType = _ctx.StringValue("AddMultiRateConfig.Body["+ i +"].TemplateType");
				failedTemplates.BandWidth = _ctx.IntegerValue("AddMultiRateConfig.Body["+ i +"].BandWidth");
				failedTemplates.Profile = _ctx.IntegerValue("AddMultiRateConfig.Body["+ i +"].Profile");
				failedTemplates.AudioRate = _ctx.IntegerValue("AddMultiRateConfig.Body["+ i +"].AudioRate");
				failedTemplates.AudioCodec = _ctx.StringValue("AddMultiRateConfig.Body["+ i +"].AudioCodec");
				failedTemplates.Gop = _ctx.StringValue("AddMultiRateConfig.Body["+ i +"].Gop");
				failedTemplates.Width = _ctx.IntegerValue("AddMultiRateConfig.Body["+ i +"].Width");
				failedTemplates.VideoBitrate = _ctx.IntegerValue("AddMultiRateConfig.Body["+ i +"].VideoBitrate");
				failedTemplates.AudioChannelNum = _ctx.IntegerValue("AddMultiRateConfig.Body["+ i +"].AudioChannelNum");
				failedTemplates.Fps = _ctx.IntegerValue("AddMultiRateConfig.Body["+ i +"].Fps");
				failedTemplates.AudioProfile = _ctx.StringValue("AddMultiRateConfig.Body["+ i +"].AudioProfile");

				addMultiRateConfigResponse_body.Add(failedTemplates);
			}
			addMultiRateConfigResponse.Body = addMultiRateConfigResponse_body;
        
			return addMultiRateConfigResponse;
        }
    }
}
