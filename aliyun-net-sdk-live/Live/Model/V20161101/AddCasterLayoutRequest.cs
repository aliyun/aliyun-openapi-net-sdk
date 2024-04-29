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

		private List<int?> audioLayers = new List<int?>(){ };

		private List<string> videoLayers = new List<string>(){ };

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

		public List<int?> AudioLayers
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

		public List<string> VideoLayers
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

			private int? fixedDelayDuration;

			private string validChannel;

			private float? volumeRate;

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
		}

		public class VideoLayer
		{

			private string fillMode;

			private int? fixedDelayDuration;

			private float? heightNormalized;

			private List<string> positionNormalizeds = new List<string>(){ };

			private string positionRefer;

			private float? widthNormalized;

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

        public override AddCasterLayoutResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddCasterLayoutResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
