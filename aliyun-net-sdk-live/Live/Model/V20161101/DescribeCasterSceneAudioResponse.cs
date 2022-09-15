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
using System.Collections.Generic;
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.live.Model.V20161101
{
	public class DescribeCasterSceneAudioResponse : AcsResponse
	{

		private string requestId;

		private string casterId;

		private int? followEnable;

		private List<DescribeCasterSceneAudio_AudioLayer> audioLayers;

		private List<string> mixList;

		[JsonProperty(PropertyName = "RequestId")]
		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		[JsonProperty(PropertyName = "CasterId")]
		public string CasterId
		{
			get
			{
				return casterId;
			}
			set	
			{
				casterId = value;
			}
		}

		[JsonProperty(PropertyName = "FollowEnable")]
		public int? FollowEnable
		{
			get
			{
				return followEnable;
			}
			set	
			{
				followEnable = value;
			}
		}

		[JsonProperty(PropertyName = "AudioLayers")]
		public List<DescribeCasterSceneAudio_AudioLayer> AudioLayers
		{
			get
			{
				return audioLayers;
			}
			set	
			{
				audioLayers = value;
			}
		}

		[JsonProperty(PropertyName = "MixList")]
		public List<string> MixList
		{
			get
			{
				return mixList;
			}
			set	
			{
				mixList = value;
			}
		}

		public class DescribeCasterSceneAudio_AudioLayer
		{

			private float? volumeRate;

			private int? fixedDelayDuration;

			private string validChannel;

			[JsonProperty(PropertyName = "VolumeRate")]
			public float? VolumeRate
			{
				get
				{
					return volumeRate;
				}
				set	
				{
					volumeRate = value;
				}
			}

			[JsonProperty(PropertyName = "FixedDelayDuration")]
			public int? FixedDelayDuration
			{
				get
				{
					return fixedDelayDuration;
				}
				set	
				{
					fixedDelayDuration = value;
				}
			}

			[JsonProperty(PropertyName = "ValidChannel")]
			public string ValidChannel
			{
				get
				{
					return validChannel;
				}
				set	
				{
					validChannel = value;
				}
			}
		}
	}
}
