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
        }

		private List<AudioLayer> audioLayers;

		private string casterId;

		private string sceneId;

		private List<string> mixLists;

		private long? ownerId;

		private int? followEnable;

		public List<AudioLayer> AudioLayers
		{
			get
			{
				return audioLayers;
			}

			set
			{
				audioLayers = value;
				for (int i = 0; i < audioLayers.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"AudioLayer." + (i + 1) + ".FixedDelayDuration", audioLayers[i].FixedDelayDuration);
					DictionaryUtil.Add(QueryParameters,"AudioLayer." + (i + 1) + ".VolumeRate", audioLayers[i].VolumeRate);
					DictionaryUtil.Add(QueryParameters,"AudioLayer." + (i + 1) + ".ValidChannel", audioLayers[i].ValidChannel);
				}
			}
		}

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

		public List<string> MixLists
		{
			get
			{
				return mixLists;
			}

			set
			{
				mixLists = value;
				for (int i = 0; i < mixLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"MixList." + (i + 1) , mixLists[i]);
				}
			}
		}

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

			private int? fixedDelayDuration;

			private float? volumeRate;

			private string validChannel;

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
