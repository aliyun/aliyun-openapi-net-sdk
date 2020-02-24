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
        public static DescribeTTSConfigResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeTTSConfigResponse describeTTSConfigResponse = new DescribeTTSConfigResponse();

			describeTTSConfigResponse.HttpResponse = context.HttpResponse;
			describeTTSConfigResponse.RequestId = context.StringValue("DescribeTTSConfig.RequestId");
			describeTTSConfigResponse.Success = context.BooleanValue("DescribeTTSConfig.Success");
			describeTTSConfigResponse.Code = context.StringValue("DescribeTTSConfig.Code");
			describeTTSConfigResponse.Message = context.StringValue("DescribeTTSConfig.Message");
			describeTTSConfigResponse.HttpStatusCode = context.IntegerValue("DescribeTTSConfig.HttpStatusCode");

			DescribeTTSConfigResponse.DescribeTTSConfig_TTSConfig tTSConfig = new DescribeTTSConfigResponse.DescribeTTSConfig_TTSConfig();
			tTSConfig.Id = context.StringValue("DescribeTTSConfig.TTSConfig.Id");
			tTSConfig.ScriptId = context.StringValue("DescribeTTSConfig.TTSConfig.ScriptId");
			tTSConfig.InstanceId = context.StringValue("DescribeTTSConfig.TTSConfig.InstanceId");
			tTSConfig.Voice = context.StringValue("DescribeTTSConfig.TTSConfig.Voice");
			tTSConfig.SpeechRate = context.StringValue("DescribeTTSConfig.TTSConfig.SpeechRate");
			tTSConfig.Volume = context.StringValue("DescribeTTSConfig.TTSConfig.Volume");
			describeTTSConfigResponse.TTSConfig = tTSConfig;
        
			return describeTTSConfigResponse;
        }
    }
}
