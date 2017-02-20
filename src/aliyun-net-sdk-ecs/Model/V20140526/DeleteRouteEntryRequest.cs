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
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ecs.Transform.V20140526;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Model.V20140526
{
    public class DeleteRouteEntryRequest : RpcAcsRequest<DeleteRouteEntryResponse>
    {
        public DeleteRouteEntryRequest()
            : base("Ecs", "2014-05-26", "DeleteRouteEntry")
        {
        }

		private List<NextHopList> _nextHopLists;

		private long? _ownerId;

		private string _resourceOwnerAccount;

		private long? _resourceOwnerId;

		private string _routeTableId;

		private string _destinationCidrBlock;

		private string _nextHopId;

		private string _ownerAccount;

		public List<NextHopList> NextHopLists
		{
			get
			{
				return _nextHopLists;
			}

			set
			{
				_nextHopLists = value;
				for (int i = 0; i < _nextHopLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"NextHopList." + (i + 1) + ".NextHopType", _nextHopLists[i].NextHopType);
					DictionaryUtil.Add(QueryParameters,"NextHopList." + (i + 1) + ".NextHopId", _nextHopLists[i].NextHopId);
				}
			}
		}

		public long? OwnerId
		{
			get
			{
				return _ownerId;
			}
			set	
			{
				_ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string ResourceOwnerAccount
		{
			get
			{
				return _resourceOwnerAccount;
			}
			set	
			{
				_resourceOwnerAccount = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerAccount", value);
			}
		}

		public long? ResourceOwnerId
		{
			get
			{
				return _resourceOwnerId;
			}
			set	
			{
				_resourceOwnerId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceOwnerId", value.ToString());
			}
		}

		public string RouteTableId
		{
			get
			{
				return _routeTableId;
			}
			set	
			{
				_routeTableId = value;
				DictionaryUtil.Add(QueryParameters, "RouteTableId", value);
			}
		}

		public string DestinationCidrBlock
		{
			get
			{
				return _destinationCidrBlock;
			}
			set	
			{
				_destinationCidrBlock = value;
				DictionaryUtil.Add(QueryParameters, "DestinationCidrBlock", value);
			}
		}

		public string NextHopId
		{
			get
			{
				return _nextHopId;
			}
			set	
			{
				_nextHopId = value;
				DictionaryUtil.Add(QueryParameters, "NextHopId", value);
			}
		}

		public string OwnerAccount
		{
			get
			{
				return _ownerAccount;
			}
			set	
			{
				_ownerAccount = value;
				DictionaryUtil.Add(QueryParameters, "OwnerAccount", value);
			}
		}

		public class NextHopList
		{
		    public string NextHopType { get; set; }

		    public string NextHopId { get; set; }
		}

        public override DeleteRouteEntryResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DeleteRouteEntryResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}