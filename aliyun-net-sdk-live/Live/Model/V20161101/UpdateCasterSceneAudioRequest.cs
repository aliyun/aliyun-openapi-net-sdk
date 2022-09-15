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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.live.Transform;
using Aliyun.Acs.live.Transform.V20161101;

namespace Aliyun.Acs.live.Model.V20161101
{
    public class UpdateCasterSceneAudioRequest : RpcAcsRequest<UpdateCasterSceneAudioResponse>
    {
        public UpdateCasterSceneAudioRequest()
            : base("live", "2016-11-01", "UpdateCasterSceneAudio", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string casterId;

		private long? ownerId;

		private List<float?> audioLayers = new List<float?>(){ };

		private string sceneId;

		private List<string> mixLists = new List<string>(){ };

		private int? followEnable;

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
				DictionaryUtil.Add(QueryParameters, "CasterId", value);
			}
		}

		[JsonProperty(PropertyName = "OwnerId")]
		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "AudioLayer")]
		public List<float?> AudioLayers
		{
			get
			{
				return audioLayers;
			}

			set
			{
				audioLayers = value;
				if(audioLayers != null)
				{
					for (int depth1 = 0; depth1 < audioLayers.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"AudioLayer." + (depth1 + 1), audioLayers[depth1]);
						DictionaryUtil.Add(QueryParameters,"AudioLayer." + (depth1 + 1), audioLayers[depth1]);
						DictionaryUtil.Add(QueryParameters,"AudioLayer." + (depth1 + 1), audioLayers[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "SceneId")]
		public string SceneId
		{
			get
			{
				return sceneId;
			}
			set	
			{
				sceneId = value;
				DictionaryUtil.Add(QueryParameters, "SceneId", value);
			}
		}

		[JsonProperty(PropertyName = "MixList")]
		public List<string> MixLists
		{
			get
			{
				return mixLists;
			}

			set
			{
				mixLists = value;
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
				DictionaryUtil.Add(QueryParameters, "FollowEnable", value.ToString());
			}
		}

		public class AudioLayer
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

        public override UpdateCasterSceneAudioResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateCasterSceneAudioResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
