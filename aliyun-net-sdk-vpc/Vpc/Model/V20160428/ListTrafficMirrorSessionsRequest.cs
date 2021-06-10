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
using Aliyun.Acs.Vpc.Transform;
using Aliyun.Acs.Vpc.Transform.V20160428;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class ListTrafficMirrorSessionsRequest : RpcAcsRequest<ListTrafficMirrorSessionsResponse>
    {
        public ListTrafficMirrorSessionsRequest()
            : base("Vpc", "2016-04-28", "ListTrafficMirrorSessions", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string trafficMirrorSourceId;

		private bool? enabled;

		private string trafficMirrorSessionName;

		private string nextToken;

		private List<string> trafficMirrorSessionIdss = new List<string>(){ };

		private string resourceOwnerAccount;

		private string ownerAccount;

		private int? priority;

		private long? ownerId;

		private string trafficMirrorTargetId;

		private string trafficMirrorFilterId;

		private int? maxResults;

		private int? virtualNetworkId;

		public long? ResourceOwnerId
		{
			get
			{
				return resourceOwnerId;
			}
			set	
			{
				resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string TrafficMirrorSourceId
		{
			get
			{
				return trafficMirrorSourceId;
			}
			set	
			{
				trafficMirrorSourceId = value;
				DictionaryUtil.Add(QueryParameters, "TrafficMirrorSourceId", value);
			}
		}

		public bool? Enabled
		{
			get
			{
				return enabled;
			}
			set	
			{
				enabled = value;
				DictionaryUtil.Add(QueryParameters, "Enabled", value.ToString());
			}
		}

		public string TrafficMirrorSessionName
		{
			get
			{
				return trafficMirrorSessionName;
			}
			set	
			{
				trafficMirrorSessionName = value;
				DictionaryUtil.Add(QueryParameters, "TrafficMirrorSessionName", value);
			}
		}

		public string NextToken
		{
			get
			{
				return nextToken;
			}
			set	
			{
				nextToken = value;
				DictionaryUtil.Add(QueryParameters, "NextToken", value);
			}
		}

		public List<string> TrafficMirrorSessionIdss
		{
			get
			{
				return trafficMirrorSessionIdss;
			}

			set
			{
				trafficMirrorSessionIdss = value;
				for (int i = 0; i < trafficMirrorSessionIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"TrafficMirrorSessionIds." + (i + 1) , trafficMirrorSessionIdss[i]);
				}
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return resourceOwnerAccount;
			}
			set	
			{
				resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return ownerAccount;
			}
			set	
			{
				ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public int? Priority
		{
			get
			{
				return priority;
			}
			set	
			{
				priority = value;
				DictionaryUtil.Add(QueryParameters, "Priority", value.ToString());
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

		public string TrafficMirrorTargetId
		{
			get
			{
				return trafficMirrorTargetId;
			}
			set	
			{
				trafficMirrorTargetId = value;
				DictionaryUtil.Add(QueryParameters, "TrafficMirrorTargetId", value);
			}
		}

		public string TrafficMirrorFilterId
		{
			get
			{
				return trafficMirrorFilterId;
			}
			set	
			{
				trafficMirrorFilterId = value;
				DictionaryUtil.Add(QueryParameters, "TrafficMirrorFilterId", value);
			}
		}

		public int? MaxResults
		{
			get
			{
				return maxResults;
			}
			set	
			{
				maxResults = value;
				DictionaryUtil.Add(QueryParameters, "MaxResults", value.ToString());
			}
		}

		public int? VirtualNetworkId
		{
			get
			{
				return virtualNetworkId;
			}
			set	
			{
				virtualNetworkId = value;
				DictionaryUtil.Add(QueryParameters, "VirtualNetworkId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListTrafficMirrorSessionsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListTrafficMirrorSessionsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
