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
using Aliyun.Acs.Cbn.Transform;
using Aliyun.Acs.Cbn.Transform.V20170912;

namespace Aliyun.Acs.Cbn.Model.V20170912
{
    public class CreateCenRouteMapRequest : RpcAcsRequest<CreateCenRouteMapResponse>
    {
        public CreateCenRouteMapRequest()
            : base("Cbn", "2017-09-12", "CreateCenRouteMap", "cbn", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cbn.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cbn.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string communityMatchMode;

		private string mapResult;

		private int? nextPriority;

		private List<string> destinationCidrBlockss = new List<string>(){ };

		private List<string> sourceInstanceIdss = new List<string>(){ };

		private List<string> sourceRegionIdss = new List<string>(){ };

		private List<long?> matchAsnss = new List<long?>(){ };

		private int? preference;

		private long? ownerId;

		private int? priority;

		private List<string> destinationChildInstanceTypess = new List<string>(){ };

		private List<string> sourceRouteTableIdss = new List<string>(){ };

		private List<string> sourceChildInstanceTypess = new List<string>(){ };

		private string communityOperateMode;

		private List<string> operateCommunitySets = new List<string>(){ };

		private List<string> routeTypess = new List<string>(){ };

		private string cidrMatchMode;

		private string cenId;

		private string description;

		private bool? sourceInstanceIdsReverseMatch;

		private List<string> destinationRouteTableIdss = new List<string>(){ };

		private string transmitDirection;

		private List<string> destinationInstanceIdss = new List<string>(){ };

		private string resourceOwnerAccount;

		private string ownerAccount;

		private bool? destinationInstanceIdsReverseMatch;

		private List<long?> prependAsPaths = new List<long?>(){ };

		private string asPathMatchMode;

		private List<string> matchCommunitySets = new List<string>(){ };

		private string cenRegionId;

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

		public string CommunityMatchMode
		{
			get
			{
				return communityMatchMode;
			}
			set	
			{
				communityMatchMode = value;
				DictionaryUtil.Add(QueryParameters, "CommunityMatchMode", value);
			}
		}

		public string MapResult
		{
			get
			{
				return mapResult;
			}
			set	
			{
				mapResult = value;
				DictionaryUtil.Add(QueryParameters, "MapResult", value);
			}
		}

		public int? NextPriority
		{
			get
			{
				return nextPriority;
			}
			set	
			{
				nextPriority = value;
				DictionaryUtil.Add(QueryParameters, "NextPriority", value.ToString());
			}
		}

		public List<string> DestinationCidrBlockss
		{
			get
			{
				return destinationCidrBlockss;
			}

			set
			{
				destinationCidrBlockss = value;
				for (int i = 0; i < destinationCidrBlockss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DestinationCidrBlocks." + (i + 1) , destinationCidrBlockss[i]);
				}
			}
		}

		public List<string> SourceInstanceIdss
		{
			get
			{
				return sourceInstanceIdss;
			}

			set
			{
				sourceInstanceIdss = value;
				for (int i = 0; i < sourceInstanceIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SourceInstanceIds." + (i + 1) , sourceInstanceIdss[i]);
				}
			}
		}

		public List<string> SourceRegionIdss
		{
			get
			{
				return sourceRegionIdss;
			}

			set
			{
				sourceRegionIdss = value;
				for (int i = 0; i < sourceRegionIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SourceRegionIds." + (i + 1) , sourceRegionIdss[i]);
				}
			}
		}

		public List<long?> MatchAsnss
		{
			get
			{
				return matchAsnss;
			}

			set
			{
				matchAsnss = value;
				for (int i = 0; i < matchAsnss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"MatchAsns." + (i + 1) , matchAsnss[i]);
				}
			}
		}

		public int? Preference
		{
			get
			{
				return preference;
			}
			set	
			{
				preference = value;
				DictionaryUtil.Add(QueryParameters, "Preference", value.ToString());
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

		public List<string> DestinationChildInstanceTypess
		{
			get
			{
				return destinationChildInstanceTypess;
			}

			set
			{
				destinationChildInstanceTypess = value;
				for (int i = 0; i < destinationChildInstanceTypess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DestinationChildInstanceTypes." + (i + 1) , destinationChildInstanceTypess[i]);
				}
			}
		}

		public List<string> SourceRouteTableIdss
		{
			get
			{
				return sourceRouteTableIdss;
			}

			set
			{
				sourceRouteTableIdss = value;
				for (int i = 0; i < sourceRouteTableIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SourceRouteTableIds." + (i + 1) , sourceRouteTableIdss[i]);
				}
			}
		}

		public List<string> SourceChildInstanceTypess
		{
			get
			{
				return sourceChildInstanceTypess;
			}

			set
			{
				sourceChildInstanceTypess = value;
				for (int i = 0; i < sourceChildInstanceTypess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SourceChildInstanceTypes." + (i + 1) , sourceChildInstanceTypess[i]);
				}
			}
		}

		public string CommunityOperateMode
		{
			get
			{
				return communityOperateMode;
			}
			set	
			{
				communityOperateMode = value;
				DictionaryUtil.Add(QueryParameters, "CommunityOperateMode", value);
			}
		}

		public List<string> OperateCommunitySets
		{
			get
			{
				return operateCommunitySets;
			}

			set
			{
				operateCommunitySets = value;
				for (int i = 0; i < operateCommunitySets.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"OperateCommunitySet." + (i + 1) , operateCommunitySets[i]);
				}
			}
		}

		public List<string> RouteTypess
		{
			get
			{
				return routeTypess;
			}

			set
			{
				routeTypess = value;
				for (int i = 0; i < routeTypess.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"RouteTypes." + (i + 1) , routeTypess[i]);
				}
			}
		}

		public string CidrMatchMode
		{
			get
			{
				return cidrMatchMode;
			}
			set	
			{
				cidrMatchMode = value;
				DictionaryUtil.Add(QueryParameters, "CidrMatchMode", value);
			}
		}

		public string CenId
		{
			get
			{
				return cenId;
			}
			set	
			{
				cenId = value;
				DictionaryUtil.Add(QueryParameters, "CenId", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public bool? SourceInstanceIdsReverseMatch
		{
			get
			{
				return sourceInstanceIdsReverseMatch;
			}
			set	
			{
				sourceInstanceIdsReverseMatch = value;
				DictionaryUtil.Add(QueryParameters, "SourceInstanceIdsReverseMatch", value.ToString());
			}
		}

		public List<string> DestinationRouteTableIdss
		{
			get
			{
				return destinationRouteTableIdss;
			}

			set
			{
				destinationRouteTableIdss = value;
				for (int i = 0; i < destinationRouteTableIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DestinationRouteTableIds." + (i + 1) , destinationRouteTableIdss[i]);
				}
			}
		}

		public string TransmitDirection
		{
			get
			{
				return transmitDirection;
			}
			set	
			{
				transmitDirection = value;
				DictionaryUtil.Add(QueryParameters, "TransmitDirection", value);
			}
		}

		public List<string> DestinationInstanceIdss
		{
			get
			{
				return destinationInstanceIdss;
			}

			set
			{
				destinationInstanceIdss = value;
				for (int i = 0; i < destinationInstanceIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DestinationInstanceIds." + (i + 1) , destinationInstanceIdss[i]);
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

		public bool? DestinationInstanceIdsReverseMatch
		{
			get
			{
				return destinationInstanceIdsReverseMatch;
			}
			set	
			{
				destinationInstanceIdsReverseMatch = value;
				DictionaryUtil.Add(QueryParameters, "DestinationInstanceIdsReverseMatch", value.ToString());
			}
		}

		public List<long?> PrependAsPaths
		{
			get
			{
				return prependAsPaths;
			}

			set
			{
				prependAsPaths = value;
				for (int i = 0; i < prependAsPaths.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"PrependAsPath." + (i + 1) , prependAsPaths[i]);
				}
			}
		}

		public string AsPathMatchMode
		{
			get
			{
				return asPathMatchMode;
			}
			set	
			{
				asPathMatchMode = value;
				DictionaryUtil.Add(QueryParameters, "AsPathMatchMode", value);
			}
		}

		public List<string> MatchCommunitySets
		{
			get
			{
				return matchCommunitySets;
			}

			set
			{
				matchCommunitySets = value;
				for (int i = 0; i < matchCommunitySets.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"MatchCommunitySet." + (i + 1) , matchCommunitySets[i]);
				}
			}
		}

		public string CenRegionId
		{
			get
			{
				return cenRegionId;
			}
			set	
			{
				cenRegionId = value;
				DictionaryUtil.Add(QueryParameters, "CenRegionId", value);
			}
		}

        public override CreateCenRouteMapResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateCenRouteMapResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
