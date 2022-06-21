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
    public class AddCasterLayoutRequest : RpcAcsRequest<AddCasterLayoutResponse>
    {
        public AddCasterLayoutRequest()
            : base("live", "2016-11-01", "AddCasterLayout", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> blendLists = new List<string>(){ };

		private string casterId;

		private long? ownerId;

		private List<AudioLayer> audioLayers = new List<AudioLayer>(){ };

		private List<VideoLayer> videoLayers = new List<VideoLayer>(){ };

		private List<string> mixLists = new List<string>(){ };

		public List<string> BlendLists
		{
			get
			{
				return blendLists;
			}

			set
			{
				blendLists = value;
				for (int i = 0; i < blendLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"BlendList." + (i + 1) , blendLists[i]);
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
					DictionaryUtil.Add(QueryParameters,"AudioLayer." + (i + 1) + ".VolumeRate", audioLayers[i].VolumeRate);
					DictionaryUtil.Add(QueryParameters,"AudioLayer." + (i + 1) + ".ValidChannel", audioLayers[i].ValidChannel);
					DictionaryUtil.Add(QueryParameters,"AudioLayer." + (i + 1) + ".FixedDelayDuration", audioLayers[i].FixedDelayDuration);
				}
			}
		}

		public List<VideoLayer> VideoLayers
		{
			get
			{
				return videoLayers;
			}

			set
			{
				videoLayers = value;
				for (int i = 0; i < videoLayers.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"VideoLayer." + (i + 1) + ".FillMode", videoLayers[i].FillMode);
					DictionaryUtil.Add(QueryParameters,"VideoLayer." + (i + 1) + ".HeightNormalized", videoLayers[i].HeightNormalized);
					DictionaryUtil.Add(QueryParameters,"VideoLayer." + (i + 1) + ".WidthNormalized", videoLayers[i].WidthNormalized);
					DictionaryUtil.Add(QueryParameters,"VideoLayer." + (i + 1) + ".PositionRefer", videoLayers[i].PositionRefer);
					for (int j = 0; j < videoLayers[i].PositionNormalizeds.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"VideoLayer." + (i + 1) + ".PositionNormalized." +(j + 1), videoLayers[i].PositionNormalizeds[j]);
					}
					DictionaryUtil.Add(QueryParameters,"VideoLayer." + (i + 1) + ".FixedDelayDuration", videoLayers[i].FixedDelayDuration);
				}
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

		public class AudioLayer
		{

			private float? volumeRate;

			private string validChannel;

			private int? fixedDelayDuration;

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
		}

		public class VideoLayer
		{

			private string fillMode;

			private float? heightNormalized;

			private float? widthNormalized;

			private string positionRefer;

			private List<float?> positionNormalizeds = new List<float?>(){ };

			private int? fixedDelayDuration;

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

			public List<float?> PositionNormalizeds
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
		}

        public override AddCasterLayoutResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddCasterLayoutResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
