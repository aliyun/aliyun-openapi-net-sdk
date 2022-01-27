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
using Aliyun.Acs.VoiceNavigator.Model.V20180612;

namespace Aliyun.Acs.VoiceNavigator.Transform.V20180612
{
    public class DescribeVoiceConfigResponseUnmarshaller
    {
        public static DescribeVoiceConfigResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVoiceConfigResponse describeVoiceConfigResponse = new DescribeVoiceConfigResponse();

			describeVoiceConfigResponse.HttpResponse = _ctx.HttpResponse;
			describeVoiceConfigResponse.SpeechNoiseThreshold = _ctx.StringValue("DescribeVoiceConfig.SpeechNoiseThreshold");
			describeVoiceConfigResponse.AsrCustomizationId = _ctx.StringValue("DescribeVoiceConfig.AsrCustomizationId");
			describeVoiceConfigResponse.Voice = _ctx.StringValue("DescribeVoiceConfig.Voice");
			describeVoiceConfigResponse.RequestId = _ctx.StringValue("DescribeVoiceConfig.RequestId");
			describeVoiceConfigResponse.AsrClassVocabularyId = _ctx.StringValue("DescribeVoiceConfig.AsrClassVocabularyId");
			describeVoiceConfigResponse.AsrVocabularyId = _ctx.StringValue("DescribeVoiceConfig.AsrVocabularyId");
			describeVoiceConfigResponse.AsrAcousticModelId = _ctx.StringValue("DescribeVoiceConfig.AsrAcousticModelId");
			describeVoiceConfigResponse.Volume = _ctx.IntegerValue("DescribeVoiceConfig.Volume");
			describeVoiceConfigResponse.SpeechRate = _ctx.IntegerValue("DescribeVoiceConfig.SpeechRate");

			List<DescribeVoiceConfigResponse.DescribeVoiceConfig_Ip> describeVoiceConfigResponse_apesIpList = new List<DescribeVoiceConfigResponse.DescribeVoiceConfig_Ip>();
			for (int i = 0; i < _ctx.Length("DescribeVoiceConfig.ApesIpList.Length"); i++) {
				DescribeVoiceConfigResponse.DescribeVoiceConfig_Ip ip = new DescribeVoiceConfigResponse.DescribeVoiceConfig_Ip();
				ip.Ip = _ctx.StringValue("DescribeVoiceConfig.ApesIpList["+ i +"].Ip");

				describeVoiceConfigResponse_apesIpList.Add(ip);
			}
			describeVoiceConfigResponse.ApesIpList = describeVoiceConfigResponse_apesIpList;
        
			return describeVoiceConfigResponse;
        }
    }
}
