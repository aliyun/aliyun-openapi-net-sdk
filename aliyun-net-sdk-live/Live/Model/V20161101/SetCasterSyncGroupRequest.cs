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

		private List<SyncGroup> syncGroups = new List<SyncGroup>(){ };

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

		public List<SyncGroup> SyncGroups
		{
			get
			{
				return syncGroups;
			}

			set
			{
				syncGroups = value;
				for (int i = 0; i < syncGroups.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SyncGroup." + (i + 1) + ".Mode", syncGroups[i].Mode);
					DictionaryUtil.Add(QueryParameters,"SyncGroup." + (i + 1) + ".SyncDelayThreshold", syncGroups[i].SyncDelayThreshold);
					DictionaryUtil.Add(QueryParameters,"SyncGroup." + (i + 1) + ".HostResourceId", syncGroups[i].HostResourceId);
					for (int j = 0; j < syncGroups[i].ResourceIdss.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"SyncGroup." + (i + 1) + ".ResourceIds." +(j + 1), syncGroups[i].ResourceIdss[j]);
					}
				}
			}
		}

		public class SyncGroup
		{

			private int? mode;

			private long? syncDelayThreshold;

			private string hostResourceId;

			private List<string> resourceIdss = new List<string>(){ };

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
		}

        public override SetCasterSyncGroupResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SetCasterSyncGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
