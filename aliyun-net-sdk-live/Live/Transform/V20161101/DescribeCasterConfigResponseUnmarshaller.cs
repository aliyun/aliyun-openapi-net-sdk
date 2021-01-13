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
    public class DescribeCasterConfigResponseUnmarshaller
    {
        public static DescribeCasterConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCasterConfigResponse describeCasterConfigResponse = new DescribeCasterConfigResponse();

			describeCasterConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeCasterConfigResponse.RequestId = _ctx.StringValue("DescribeCasterConfig.RequestId");
			describeCasterConfigResponse.CasterId = _ctx.StringValue("DescribeCasterConfig.CasterId");
			describeCasterConfigResponse.CasterName = _ctx.StringValue("DescribeCasterConfig.CasterName");
			describeCasterConfigResponse.DomainName = _ctx.StringValue("DescribeCasterConfig.DomainName");
			describeCasterConfigResponse.Delay = _ctx.FloatValue("DescribeCasterConfig.Delay");
			describeCasterConfigResponse.UrgentMaterialId = _ctx.StringValue("DescribeCasterConfig.UrgentMaterialId");
			describeCasterConfigResponse.SideOutputUrl = _ctx.StringValue("DescribeCasterConfig.SideOutputUrl");
			describeCasterConfigResponse.CallbackUrl = _ctx.StringValue("DescribeCasterConfig.CallbackUrl");
			describeCasterConfigResponse.ProgramName = _ctx.StringValue("DescribeCasterConfig.ProgramName");
			describeCasterConfigResponse.ProgramEffect = _ctx.IntegerValue("DescribeCasterConfig.ProgramEffect");
			describeCasterConfigResponse.ChannelEnable = _ctx.IntegerValue("DescribeCasterConfig.ChannelEnable");

			DescribeCasterConfigResponse.DescribeCasterConfig_TranscodeConfig transcodeConfig = new DescribeCasterConfigResponse.DescribeCasterConfig_TranscodeConfig();
			transcodeConfig.CasterTemplate = _ctx.StringValue("DescribeCasterConfig.TranscodeConfig.CasterTemplate");

			List<string> transcodeConfig_liveTemplateIds = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeCasterConfig.TranscodeConfig.LiveTemplateIds.Length"); i++) {
				transcodeConfig_liveTemplateIds.Add(_ctx.StringValue("DescribeCasterConfig.TranscodeConfig.LiveTemplateIds["+ i +"]"));
			}
			transcodeConfig.LiveTemplateIds = transcodeConfig_liveTemplateIds;
			describeCasterConfigResponse.TranscodeConfig = transcodeConfig;

			DescribeCasterConfigResponse.DescribeCasterConfig_RecordConfig recordConfig = new DescribeCasterConfigResponse.DescribeCasterConfig_RecordConfig();
			recordConfig.OssEndpoint = _ctx.StringValue("DescribeCasterConfig.RecordConfig.OssEndpoint");
			recordConfig.OssBucket = _ctx.StringValue("DescribeCasterConfig.RecordConfig.OssBucket");

			List<DescribeCasterConfigResponse.DescribeCasterConfig_RecordConfig.DescribeCasterConfig_RecordFormatItem> recordConfig_recordFormat = new List<DescribeCasterConfigResponse.DescribeCasterConfig_RecordConfig.DescribeCasterConfig_RecordFormatItem>();
			for (int i = 0; i < _ctx.Length("DescribeCasterConfig.RecordConfig.RecordFormat.Length"); i++) {
				DescribeCasterConfigResponse.DescribeCasterConfig_RecordConfig.DescribeCasterConfig_RecordFormatItem recordFormatItem = new DescribeCasterConfigResponse.DescribeCasterConfig_RecordConfig.DescribeCasterConfig_RecordFormatItem();
				recordFormatItem.Format = _ctx.StringValue("DescribeCasterConfig.RecordConfig.RecordFormat["+ i +"].Format");
				recordFormatItem.OssObjectPrefix = _ctx.StringValue("DescribeCasterConfig.RecordConfig.RecordFormat["+ i +"].OssObjectPrefix");
				recordFormatItem.SliceOssObjectPrefix = _ctx.StringValue("DescribeCasterConfig.RecordConfig.RecordFormat["+ i +"].SliceOssObjectPrefix");
				recordFormatItem.CycleDuration = _ctx.IntegerValue("DescribeCasterConfig.RecordConfig.RecordFormat["+ i +"].CycleDuration");

				recordConfig_recordFormat.Add(recordFormatItem);
			}
			recordConfig.RecordFormat = recordConfig_recordFormat;
			describeCasterConfigResponse.RecordConfig = recordConfig;
        
			return describeCasterConfigResponse;
        }
    }
}
