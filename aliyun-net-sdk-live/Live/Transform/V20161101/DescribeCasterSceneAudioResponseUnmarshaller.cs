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
    public class DescribeCasterSceneAudioResponseUnmarshaller
    {
        public static DescribeCasterSceneAudioResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeCasterSceneAudioResponse describeCasterSceneAudioResponse = new DescribeCasterSceneAudioResponse();

			describeCasterSceneAudioResponse.HttpResponse = _ctx.HttpResponse;
			describeCasterSceneAudioResponse.RequestId = _ctx.StringValue("DescribeCasterSceneAudio.RequestId");
			describeCasterSceneAudioResponse.CasterId = _ctx.StringValue("DescribeCasterSceneAudio.CasterId");
			describeCasterSceneAudioResponse.FollowEnable = _ctx.IntegerValue("DescribeCasterSceneAudio.FollowEnable");

			List<string> describeCasterSceneAudioResponse_mixList = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeCasterSceneAudio.MixList.Length"); i++) {
				describeCasterSceneAudioResponse_mixList.Add(_ctx.StringValue("DescribeCasterSceneAudio.MixList["+ i +"]"));
			}
			describeCasterSceneAudioResponse.MixList = describeCasterSceneAudioResponse_mixList;

			List<DescribeCasterSceneAudioResponse.DescribeCasterSceneAudio_AudioLayer> describeCasterSceneAudioResponse_audioLayers = new List<DescribeCasterSceneAudioResponse.DescribeCasterSceneAudio_AudioLayer>();
			for (int i = 0; i < _ctx.Length("DescribeCasterSceneAudio.AudioLayers.Length"); i++) {
				DescribeCasterSceneAudioResponse.DescribeCasterSceneAudio_AudioLayer audioLayer = new DescribeCasterSceneAudioResponse.DescribeCasterSceneAudio_AudioLayer();
				audioLayer.VolumeRate = _ctx.FloatValue("DescribeCasterSceneAudio.AudioLayers["+ i +"].VolumeRate");
				audioLayer.ValidChannel = _ctx.StringValue("DescribeCasterSceneAudio.AudioLayers["+ i +"].ValidChannel");
				audioLayer.FixedDelayDuration = _ctx.IntegerValue("DescribeCasterSceneAudio.AudioLayers["+ i +"].FixedDelayDuration");

				describeCasterSceneAudioResponse_audioLayers.Add(audioLayer);
			}
			describeCasterSceneAudioResponse.AudioLayers = describeCasterSceneAudioResponse_audioLayers;
        
			return describeCasterSceneAudioResponse;
        }
    }
}
