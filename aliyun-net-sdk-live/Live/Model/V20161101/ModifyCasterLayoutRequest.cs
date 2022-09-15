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
    public class ModifyCasterLayoutRequest : RpcAcsRequest<ModifyCasterLayoutResponse>
    {
        public ModifyCasterLayoutRequest()
            : base("live", "2016-11-01", "ModifyCasterLayout", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> blendLists = new List<string>(){ };

		private string layoutId;

		private string casterId;

		private long? ownerId;

		private List<float?> audioLayers = new List<float?>(){ };

		private List<int?> videoLayers = new List<int?>(){ };

		private List<string> mixLists = new List<string>(){ };

		[JsonProperty(PropertyName = "BlendList")]
		public List<string> BlendLists
		{
			get
			{
				return blendLists;
			}

			set
			{
				blendLists = value;
			}
		}

		[JsonProperty(PropertyName = "LayoutId")]
		public string LayoutId
		{
			get
			{
				return layoutId;
			}
			set	
			{
				layoutId = value;
				DictionaryUtil.Add(QueryParameters, "LayoutId", value);
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

		[JsonProperty(PropertyName = "VideoLayer")]
		public List<int?> VideoLayers
		{
			get
			{
				return videoLayers;
			}

			set
			{
				videoLayers = value;
				if(videoLayers != null)
				{
					for (int depth1 = 0; depth1 < videoLayers.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"VideoLayer." + (depth1 + 1), videoLayers[depth1]);
						DictionaryUtil.Add(QueryParameters,"VideoLayer." + (depth1 + 1), videoLayers[depth1]);
						DictionaryUtil.Add(QueryParameters,"VideoLayer." + (depth1 + 1), videoLayers[depth1]);
						DictionaryUtil.Add(QueryParameters,"VideoLayer." + (depth1 + 1), videoLayers[depth1]);
						DictionaryUtil.Add(QueryParameters,"VideoLayer." + (depth1 + 1), videoLayers[depth1]);
					}
				}
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

		public class VideoLayer
		{

			private int? fixedDelayDuration;

			private string fillMode;

			private float? heightNormalized;

			private string positionRefer;

			private List<string> positionNormalizeds = new List<string>(){ };

			private float? widthNormalized;

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

			[JsonProperty(PropertyName = "FillMode")]
			public string FillMode
			{
				get
				{
					return fillMode;
				}
				set	
				{
					fillMode = value;
				}
			}

			[JsonProperty(PropertyName = "HeightNormalized")]
			public float? HeightNormalized
			{
				get
				{
					return heightNormalized;
				}
				set	
				{
					heightNormalized = value;
				}
			}

			[JsonProperty(PropertyName = "PositionRefer")]
			public string PositionRefer
			{
				get
				{
					return positionRefer;
				}
				set	
				{
					positionRefer = value;
				}
			}

			[JsonProperty(PropertyName = "PositionNormalized")]
			public List<string> PositionNormalizeds
			{
				get
				{
					return positionNormalizeds;
				}
				set	
				{
					positionNormalizeds = value;
				}
			}

			[JsonProperty(PropertyName = "WidthNormalized")]
			public float? WidthNormalized
			{
				get
				{
					return widthNormalized;
				}
				set	
				{
					widthNormalized = value;
				}
			}
		}

        public override ModifyCasterLayoutResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyCasterLayoutResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
