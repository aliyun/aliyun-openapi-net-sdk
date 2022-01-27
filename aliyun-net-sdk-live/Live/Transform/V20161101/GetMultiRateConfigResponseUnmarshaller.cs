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
    public class GetMultiRateConfigResponseUnmarshaller
    {
        public static GetMultiRateConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetMultiRateConfigResponse getMultiRateConfigResponse = new GetMultiRateConfigResponse();

			getMultiRateConfigResponse.HttpResponse = _ctx.HttpResponse;
			getMultiRateConfigResponse.RequestId = _ctx.StringValue("GetMultiRateConfig.RequestId");
			getMultiRateConfigResponse.Message = _ctx.StringValue("GetMultiRateConfig.Message");
			getMultiRateConfigResponse.Code = _ctx.IntegerValue("GetMultiRateConfig.Code");
			getMultiRateConfigResponse.Domain = _ctx.StringValue("GetMultiRateConfig.Domain");
			getMultiRateConfigResponse.App = _ctx.StringValue("GetMultiRateConfig.App");
			getMultiRateConfigResponse.Stream = _ctx.StringValue("GetMultiRateConfig.Stream");
			getMultiRateConfigResponse.AvFormat = _ctx.StringValue("GetMultiRateConfig.AvFormat");
			getMultiRateConfigResponse.GroupId = _ctx.StringValue("GetMultiRateConfig.GroupId");
			getMultiRateConfigResponse.IsLazy = _ctx.StringValue("GetMultiRateConfig.IsLazy");
			getMultiRateConfigResponse.IsTimeAlign = _ctx.StringValue("GetMultiRateConfig.IsTimeAlign");

			List<GetMultiRateConfigResponse.GetMultiRateConfig_Detail> getMultiRateConfigResponse_templatesInfo = new List<GetMultiRateConfigResponse.GetMultiRateConfig_Detail>();
			for (int i = 0; i < _ctx.Length("GetMultiRateConfig.TemplatesInfo.Length"); i++) {
				GetMultiRateConfigResponse.GetMultiRateConfig_Detail detail = new GetMultiRateConfigResponse.GetMultiRateConfig_Detail();
				detail.Template = _ctx.StringValue("GetMultiRateConfig.TemplatesInfo["+ i +"].Template");
				detail.TemplateType = _ctx.StringValue("GetMultiRateConfig.TemplatesInfo["+ i +"].TemplateType");
				detail.Height = _ctx.IntegerValue("GetMultiRateConfig.TemplatesInfo["+ i +"].Height");
				detail.Width = _ctx.IntegerValue("GetMultiRateConfig.TemplatesInfo["+ i +"].Width");
				detail.Fps = _ctx.IntegerValue("GetMultiRateConfig.TemplatesInfo["+ i +"].Fps");
				detail.Gop = _ctx.StringValue("GetMultiRateConfig.TemplatesInfo["+ i +"].Gop");
				detail.VideoBitrate = _ctx.IntegerValue("GetMultiRateConfig.TemplatesInfo["+ i +"].VideoBitrate");
				detail.Profile = _ctx.IntegerValue("GetMultiRateConfig.TemplatesInfo["+ i +"].Profile");
				detail.AudioProfile = _ctx.StringValue("GetMultiRateConfig.TemplatesInfo["+ i +"].AudioProfile");
				detail.AudioCodec = _ctx.StringValue("GetMultiRateConfig.TemplatesInfo["+ i +"].AudioCodec");
				detail.AudioRate = _ctx.IntegerValue("GetMultiRateConfig.TemplatesInfo["+ i +"].AudioRate");
				detail.AudioBitrate = _ctx.IntegerValue("GetMultiRateConfig.TemplatesInfo["+ i +"].AudioBitrate");
				detail.AudioChannelNum = _ctx.IntegerValue("GetMultiRateConfig.TemplatesInfo["+ i +"].AudioChannelNum");
				detail.BandWidth = _ctx.IntegerValue("GetMultiRateConfig.TemplatesInfo["+ i +"].BandWidth");

				getMultiRateConfigResponse_templatesInfo.Add(detail);
			}
			getMultiRateConfigResponse.TemplatesInfo = getMultiRateConfigResponse_templatesInfo;
        
			return getMultiRateConfigResponse;
        }
    }
}
