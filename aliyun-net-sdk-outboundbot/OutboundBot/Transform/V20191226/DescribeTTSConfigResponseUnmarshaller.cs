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
using Aliyun.Acs.OutboundBot.Model.V20191226;

namespace Aliyun.Acs.OutboundBot.Transform.V20191226
{
    public class DescribeTTSConfigResponseUnmarshaller
    {
        public static DescribeTTSConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeTTSConfigResponse describeTTSConfigResponse = new DescribeTTSConfigResponse();

			describeTTSConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeTTSConfigResponse.HttpStatusCode = _ctx.IntegerValue("DescribeTTSConfig.HttpStatusCode");
			describeTTSConfigResponse.Code = _ctx.StringValue("DescribeTTSConfig.Code");
			describeTTSConfigResponse.Message = _ctx.StringValue("DescribeTTSConfig.Message");
			describeTTSConfigResponse.RequestId = _ctx.StringValue("DescribeTTSConfig.RequestId");
			describeTTSConfigResponse.Success = _ctx.BooleanValue("DescribeTTSConfig.Success");

			DescribeTTSConfigResponse.DescribeTTSConfig_TTSConfig tTSConfig = new DescribeTTSConfigResponse.DescribeTTSConfig_TTSConfig();
			tTSConfig.Voice = _ctx.StringValue("DescribeTTSConfig.TTSConfig.Voice");
			tTSConfig.SpeechRate = _ctx.StringValue("DescribeTTSConfig.TTSConfig.SpeechRate");
			tTSConfig.Volume = _ctx.StringValue("DescribeTTSConfig.TTSConfig.Volume");
			tTSConfig.InstanceId = _ctx.StringValue("DescribeTTSConfig.TTSConfig.InstanceId");
			tTSConfig.NlsServiceType = _ctx.StringValue("DescribeTTSConfig.TTSConfig.NlsServiceType");
			tTSConfig.AppKey = _ctx.StringValue("DescribeTTSConfig.TTSConfig.AppKey");
			describeTTSConfigResponse.TTSConfig = tTSConfig;
        
			return describeTTSConfigResponse;
        }
    }
}
