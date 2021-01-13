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
    public class DescribeLiveStreamDelayConfigResponseUnmarshaller
    {
        public static DescribeLiveStreamDelayConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeLiveStreamDelayConfigResponse describeLiveStreamDelayConfigResponse = new DescribeLiveStreamDelayConfigResponse();

			describeLiveStreamDelayConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeLiveStreamDelayConfigResponse.RequestId = _ctx.StringValue("DescribeLiveStreamDelayConfig.RequestId");

			DescribeLiveStreamDelayConfigResponse.DescribeLiveStreamDelayConfig_LiveStreamHlsDelayConfig liveStreamHlsDelayConfig = new DescribeLiveStreamDelayConfigResponse.DescribeLiveStreamDelayConfig_LiveStreamHlsDelayConfig();
			liveStreamHlsDelayConfig.Level = _ctx.StringValue("DescribeLiveStreamDelayConfig.LiveStreamHlsDelayConfig.Level");
			liveStreamHlsDelayConfig.Delay = _ctx.IntegerValue("DescribeLiveStreamDelayConfig.LiveStreamHlsDelayConfig.Delay");
			describeLiveStreamDelayConfigResponse.LiveStreamHlsDelayConfig = liveStreamHlsDelayConfig;

			DescribeLiveStreamDelayConfigResponse.DescribeLiveStreamDelayConfig_LiveStreamFlvDelayConfig liveStreamFlvDelayConfig = new DescribeLiveStreamDelayConfigResponse.DescribeLiveStreamDelayConfig_LiveStreamFlvDelayConfig();
			liveStreamFlvDelayConfig.Level = _ctx.StringValue("DescribeLiveStreamDelayConfig.LiveStreamFlvDelayConfig.Level");
			liveStreamFlvDelayConfig.Delay = _ctx.IntegerValue("DescribeLiveStreamDelayConfig.LiveStreamFlvDelayConfig.Delay");
			describeLiveStreamDelayConfigResponse.LiveStreamFlvDelayConfig = liveStreamFlvDelayConfig;

			DescribeLiveStreamDelayConfigResponse.DescribeLiveStreamDelayConfig_LiveStreamRtmpDelayConfig liveStreamRtmpDelayConfig = new DescribeLiveStreamDelayConfigResponse.DescribeLiveStreamDelayConfig_LiveStreamRtmpDelayConfig();
			liveStreamRtmpDelayConfig.Level = _ctx.StringValue("DescribeLiveStreamDelayConfig.LiveStreamRtmpDelayConfig.Level");
			liveStreamRtmpDelayConfig.Delay = _ctx.IntegerValue("DescribeLiveStreamDelayConfig.LiveStreamRtmpDelayConfig.Delay");
			describeLiveStreamDelayConfigResponse.LiveStreamRtmpDelayConfig = liveStreamRtmpDelayConfig;
        
			return describeLiveStreamDelayConfigResponse;
        }
    }
}
