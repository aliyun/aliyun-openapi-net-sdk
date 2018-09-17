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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.live.Model.V20161101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.live.Transform.V20161101
{
    public class DescribeCasterSceneAudioResponseUnmarshaller
    {
        public static DescribeCasterSceneAudioResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeCasterSceneAudioResponse describeCasterSceneAudioResponse = new DescribeCasterSceneAudioResponse();

			describeCasterSceneAudioResponse.HttpResponse = context.HttpResponse;
			describeCasterSceneAudioResponse.RequestId = context.StringValue("DescribeCasterSceneAudio.RequestId");
			describeCasterSceneAudioResponse.CasterId = context.StringValue("DescribeCasterSceneAudio.CasterId");
			describeCasterSceneAudioResponse.FollowEnable = context.IntegerValue("DescribeCasterSceneAudio.FollowEnable");

			List<string> describeCasterSceneAudioResponse_mixList = new List<string>();
			for (int i = 0; i < context.Length("DescribeCasterSceneAudio.MixList.Length"); i++) {
				describeCasterSceneAudioResponse_mixList.Add(context.StringValue("DescribeCasterSceneAudio.MixList["+ i +"]"));
			}
			describeCasterSceneAudioResponse.MixList = describeCasterSceneAudioResponse_mixList;

			List<DescribeCasterSceneAudioResponse.DescribeCasterSceneAudio_AudioLayer> describeCasterSceneAudioResponse_audioLayers = new List<DescribeCasterSceneAudioResponse.DescribeCasterSceneAudio_AudioLayer>();
			for (int i = 0; i < context.Length("DescribeCasterSceneAudio.AudioLayers.Length"); i++) {
				DescribeCasterSceneAudioResponse.DescribeCasterSceneAudio_AudioLayer audioLayer = new DescribeCasterSceneAudioResponse.DescribeCasterSceneAudio_AudioLayer();
				audioLayer.VolumeRate = context.FloatValue("DescribeCasterSceneAudio.AudioLayers["+ i +"].VolumeRate");
				audioLayer.ValidChannel = context.StringValue("DescribeCasterSceneAudio.AudioLayers["+ i +"].ValidChannel");
				audioLayer.FixedDelayDuration = context.IntegerValue("DescribeCasterSceneAudio.AudioLayers["+ i +"].FixedDelayDuration");

				describeCasterSceneAudioResponse_audioLayers.Add(audioLayer);
			}
			describeCasterSceneAudioResponse.AudioLayers = describeCasterSceneAudioResponse_audioLayers;
        
			return describeCasterSceneAudioResponse;
        }
    }
}