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
    public class SetCasterSyncGroupRequest : RpcAcsRequest<SetCasterSyncGroupResponse>
    {
        public SetCasterSyncGroupRequest()
            : base("live", "2016-11-01", "SetCasterSyncGroup", "live", "openAPI")
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

		private List<string> syncGroups = new List<string>(){ };

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

		[JsonProperty(PropertyName = "SyncGroup")]
		public List<string> SyncGroups
		{
			get
			{
				return syncGroups;
			}

			set
			{
				syncGroups = value;
				if(syncGroups != null)
				{
					for (int depth1 = 0; depth1 < syncGroups.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"SyncGroup." + (depth1 + 1), syncGroups[depth1]);
						DictionaryUtil.Add(QueryParameters,"SyncGroup." + (depth1 + 1), syncGroups[depth1]);
						DictionaryUtil.Add(QueryParameters,"SyncGroup." + (depth1 + 1), syncGroups[depth1]);
					}
				}
			}
		}

		public class SyncGroup
		{

			private string hostResourceId;

			private List<string> resourceIdss = new List<string>(){ };

			private List<string> syncOffsetss = new List<string>(){ };

			private long? syncDelayThreshold;

			private int? mode;

			[JsonProperty(PropertyName = "HostResourceId")]
			public string HostResourceId
			{
				get
				{
					return hostResourceId;
				}
				set	
				{
					hostResourceId = value;
				}
			}

			[JsonProperty(PropertyName = "ResourceIds")]
			public List<string> ResourceIdss
			{
				get
				{
					return resourceIdss;
				}
				set	
				{
					resourceIdss = value;
				}
			}

			[JsonProperty(PropertyName = "SyncOffsets")]
			public List<string> SyncOffsetss
			{
				get
				{
					return syncOffsetss;
				}
				set	
				{
					syncOffsetss = value;
				}
			}

			[JsonProperty(PropertyName = "SyncDelayThreshold")]
			public long? SyncDelayThreshold
			{
				get
				{
					return syncDelayThreshold;
				}
				set	
				{
					syncDelayThreshold = value;
				}
			}

			[JsonProperty(PropertyName = "Mode")]
			public int? Mode
			{
				get
				{
					return mode;
				}
				set	
				{
					mode = value;
				}
			}
		}

        public override SetCasterSyncGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetCasterSyncGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
