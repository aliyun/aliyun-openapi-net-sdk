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
			addMultiRateConfigResponse.RequestId = _ctx.StringValue("AddMultiRateConfig.RequestId");
			addMultiRateConfigResponse.Message = _ctx.StringValue("AddMultiRateConfig.Message");
			addMultiRateConfigResponse.Code = _ctx.IntegerValue("AddMultiRateConfig.Code");

			List<AddMultiRateConfigResponse.AddMultiRateConfig_FailedTemplates> addMultiRateConfigResponse_body = new List<AddMultiRateConfigResponse.AddMultiRateConfig_FailedTemplates>();
			for (int i = 0; i < _ctx.Length("AddMultiRateConfig.Body.Length"); i++) {
				AddMultiRateConfigResponse.AddMultiRateConfig_FailedTemplates failedTemplates = new AddMultiRateConfigResponse.AddMultiRateConfig_FailedTemplates();
				failedTemplates.Template = _ctx.StringValue("AddMultiRateConfig.Body["+ i +"].Template");
				failedTemplates.TemplateType = _ctx.StringValue("AddMultiRateConfig.Body["+ i +"].TemplateType");
				failedTemplates.Height = _ctx.IntegerValue("AddMultiRateConfig.Body["+ i +"].Height");
				failedTemplates.Width = _ctx.IntegerValue("AddMultiRateConfig.Body["+ i +"].Width");
				failedTemplates.Fps = _ctx.IntegerValue("AddMultiRateConfig.Body["+ i +"].Fps");
				failedTemplates.Gop = _ctx.StringValue("AddMultiRateConfig.Body["+ i +"].Gop");
				failedTemplates.VideoBitrate = _ctx.IntegerValue("AddMultiRateConfig.Body["+ i +"].VideoBitrate");
				failedTemplates.Profile = _ctx.IntegerValue("AddMultiRateConfig.Body["+ i +"].Profile");
				failedTemplates.AudioProfile = _ctx.StringValue("AddMultiRateConfig.Body["+ i +"].AudioProfile");
				failedTemplates.AudioCodec = _ctx.StringValue("AddMultiRateConfig.Body["+ i +"].AudioCodec");
				failedTemplates.AudioRate = _ctx.IntegerValue("AddMultiRateConfig.Body["+ i +"].AudioRate");
				failedTemplates.AudioBitrate = _ctx.IntegerValue("AddMultiRateConfig.Body["+ i +"].AudioBitrate");
				failedTemplates.AudioChannelNum = _ctx.IntegerValue("AddMultiRateConfig.Body["+ i +"].AudioChannelNum");
				failedTemplates.BandWidth = _ctx.IntegerValue("AddMultiRateConfig.Body["+ i +"].BandWidth");

				addMultiRateConfigResponse_body.Add(failedTemplates);
			}
			addMultiRateConfigResponse.Body = addMultiRateConfigResponse_body;
        
			return addMultiRateConfigResponse;
        }
    }
}
