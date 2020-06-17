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
using Aliyun.Acs.Ecs.Transform;
using Aliyun.Acs.Ecs.Transform.V20140526;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class CreateRouteEntryRequest : RpcAcsRequest<CreateRouteEntryResponse>
    {
        public CreateRouteEntryRequest()
            : base("Ecs", "2014-05-26", "CreateRouteEntry", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string clientToken;

		private string nextHopId;

		private string nextHopType;

		private string routeTableId;

		private string resourceOwnerAccount;

		private string destinationCidrBlock;

		private string ownerAccount;

		private long? ownerId;

		private List<NextHopList> nextHopLists = new List<NextHopList>(){ };

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

		public string ClientToken
		{
			get
			{
				return clientToken;
			}
			set	
			{
				clientToken = value;
				DictionaryUtil.Add(QueryParameters, "ClientToken", value);
			}
		}

		public string NextHopId
		{
			get
			{
				return nextHopId;
			}
			set	
			{
				nextHopId = value;
				DictionaryUtil.Add(QueryParameters, "NextHopId", value);
			}
		}

		public string NextHopType
		{
			get
			{
				return nextHopType;
			}
			set	
			{
				nextHopType = value;
				DictionaryUtil.Add(QueryParameters, "NextHopType", value);
			}
		}

		public string RouteTableId
		{
			get
			{
				return routeTableId;
			}
			set	
			{
				routeTableId = value;
				DictionaryUtil.Add(QueryParameters, "RouteTableId", value);
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

		public string DestinationCidrBlock
		{
			get
			{
				return destinationCidrBlock;
			}
			set	
			{
				destinationCidrBlock = value;
				DictionaryUtil.Add(QueryParameters, "DestinationCidrBlock", value);
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

		public List<NextHopList> NextHopLists
		{
			get
			{
				return nextHopLists;
			}

			set
			{
				nextHopLists = value;
				for (int i = 0; i < nextHopLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"NextHopList." + (i + 1) + ".NextHopId", nextHopLists[i].NextHopId);
					DictionaryUtil.Add(QueryParameters,"NextHopList." + (i + 1) + ".NextHopType", nextHopLists[i].NextHopType);
				}
			}
		}

		public class NextHopList
		{

			private string nextHopId;

			private string nextHopType;

			public string NextHopId
			{
				get
				{
					return nextHopId;
				}
				set	
				{
					nextHopId = value;
				}
			}

			public string NextHopType
			{
				get
				{
					return nextHopType;
				}
				set	
				{
					nextHopType = value;
				}
			}
		}

        public override CreateRouteEntryResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateRouteEntryResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
