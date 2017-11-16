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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Vpc.Transform;
using Aliyun.Acs.Vpc.Transform.V20160428;
using System.Collections.Generic;

namespace Aliyun.Acs.Vpc.Model.V20160428
{
    public class DeleteRouteEntryRequest : RpcAcsRequest<DeleteRouteEntryResponse>
    {
        public DeleteRouteEntryRequest()
            : base("Vpc", "2016-04-28", "DeleteRouteEntry", "vpc", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string destinationCidrBlock;

		private string ownerAccount;

		private string action;

		private string nextHopId;

		private long? ownerId;

		private List<NextHopList> nextHopLists;

		private string routeTableId;

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

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
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
					DictionaryUtil.Add(QueryParameters,"NextHopList." + (i + 1) + ".NextHopType", nextHopLists[i].NextHopType);
					DictionaryUtil.Add(QueryParameters,"NextHopList." + (i + 1) + ".NextHopId", nextHopLists[i].NextHopId);
				}
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

		public class NextHopList
		{

			private string nextHopType;

			private string nextHopId;

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
		}

        public override DeleteRouteEntryResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DeleteRouteEntryResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}