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
    public class SetCasterConfigRequest : RpcAcsRequest<SetCasterConfigResponse>
    {
        public SetCasterConfigRequest()
            : base("live", "2016-11-01", "SetCasterConfig", "live", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.live.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.live.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? channelEnable;

		private int? programEffect;

		private string programName;

		private string urgentImageUrl;

		private string recordConfig;

		private string urgentMaterialId;

		private string transcodeConfig;

		private string casterName;

		private string urgentLiveStreamUrl;

		private string sideOutputUrl;

		private string syncGroupsConfig;

		private string sideOutputUrlList;

		private string casterId;

		private string domainName;

		private long? ownerId;

		private float? delay;

		private string urgentImageId;

		private string callbackUrl;

		[JsonProperty(PropertyName = "ChannelEnable")]
		public int? ChannelEnable
		{
			get
			{
				return channelEnable;
			}
			set	
			{
				channelEnable = value;
				DictionaryUtil.Add(QueryParameters, "ChannelEnable", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ProgramEffect")]
		public int? ProgramEffect
		{
			get
			{
				return programEffect;
			}
			set	
			{
				programEffect = value;
				DictionaryUtil.Add(QueryParameters, "ProgramEffect", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "ProgramName")]
		public string ProgramName
		{
			get
			{
				return programName;
			}
			set	
			{
				programName = value;
				DictionaryUtil.Add(QueryParameters, "ProgramName", value);
			}
		}

		[JsonProperty(PropertyName = "UrgentImageUrl")]
		public string UrgentImageUrl
		{
			get
			{
				return urgentImageUrl;
			}
			set	
			{
				urgentImageUrl = value;
				DictionaryUtil.Add(QueryParameters, "UrgentImageUrl", value);
			}
		}

		[JsonProperty(PropertyName = "RecordConfig")]
		public string RecordConfig
		{
			get
			{
				return recordConfig;
			}
			set	
			{
				recordConfig = value;
				DictionaryUtil.Add(QueryParameters, "RecordConfig", value);
			}
		}

		[JsonProperty(PropertyName = "UrgentMaterialId")]
		public string UrgentMaterialId
		{
			get
			{
				return urgentMaterialId;
			}
			set	
			{
				urgentMaterialId = value;
				DictionaryUtil.Add(QueryParameters, "UrgentMaterialId", value);
			}
		}

		[JsonProperty(PropertyName = "TranscodeConfig")]
		public string TranscodeConfig
		{
			get
			{
				return transcodeConfig;
			}
			set	
			{
				transcodeConfig = value;
				DictionaryUtil.Add(QueryParameters, "TranscodeConfig", value);
			}
		}

		[JsonProperty(PropertyName = "CasterName")]
		public string CasterName
		{
			get
			{
				return casterName;
			}
			set	
			{
				casterName = value;
				DictionaryUtil.Add(QueryParameters, "CasterName", value);
			}
		}

		[JsonProperty(PropertyName = "UrgentLiveStreamUrl")]
		public string UrgentLiveStreamUrl
		{
			get
			{
				return urgentLiveStreamUrl;
			}
			set	
			{
				urgentLiveStreamUrl = value;
				DictionaryUtil.Add(QueryParameters, "UrgentLiveStreamUrl", value);
			}
		}

		[JsonProperty(PropertyName = "SideOutputUrl")]
		public string SideOutputUrl
		{
			get
			{
				return sideOutputUrl;
			}
			set	
			{
				sideOutputUrl = value;
				DictionaryUtil.Add(QueryParameters, "SideOutputUrl", value);
			}
		}

		[JsonProperty(PropertyName = "SyncGroupsConfig")]
		public string SyncGroupsConfig
		{
			get
			{
				return syncGroupsConfig;
			}
			set	
			{
				syncGroupsConfig = value;
				DictionaryUtil.Add(QueryParameters, "SyncGroupsConfig", value);
			}
		}

		[JsonProperty(PropertyName = "SideOutputUrlList")]
		public string SideOutputUrlList
		{
			get
			{
				return sideOutputUrlList;
			}
			set	
			{
				sideOutputUrlList = value;
				DictionaryUtil.Add(QueryParameters, "SideOutputUrlList", value);
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

		[JsonProperty(PropertyName = "DomainName")]
		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
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

		[JsonProperty(PropertyName = "Delay")]
		public float? Delay
		{
			get
			{
				return delay;
			}
			set	
			{
				delay = value;
				DictionaryUtil.Add(QueryParameters, "Delay", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "UrgentImageId")]
		public string UrgentImageId
		{
			get
			{
				return urgentImageId;
			}
			set	
			{
				urgentImageId = value;
				DictionaryUtil.Add(QueryParameters, "UrgentImageId", value);
			}
		}

		[JsonProperty(PropertyName = "CallbackUrl")]
		public string CallbackUrl
		{
			get
			{
				return callbackUrl;
			}
			set	
			{
				callbackUrl = value;
				DictionaryUtil.Add(QueryParameters, "CallbackUrl", value);
			}
		}

        public override SetCasterConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetCasterConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
