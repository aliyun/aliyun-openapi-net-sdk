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
    public class ListTransitRouterPrefixListAssociationRequest : RpcAcsRequest<ListTransitRouterPrefixListAssociationResponse>
    {
        public ListTransitRouterPrefixListAssociationRequest()
            : base("Cbn", "2017-09-12", "ListTransitRouterPrefixListAssociation", "cbn", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cbn.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cbn.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private int? pageNumber;

		private string prefixListId;

		private int? pageSize;

		private long? ownerUid;

		private string nextHopType;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string transitRouterId;

		private string transitRouterTableId;

		private string nextHop;

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

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string PrefixListId
		{
			get
			{
				return prefixListId;
			}
			set	
			{
				prefixListId = value;
				DictionaryUtil.Add(QueryParameters, "PrefixListId", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public long? OwnerUid
		{
			get
			{
				return ownerUid;
			}
			set	
			{
				ownerUid = value;
				DictionaryUtil.Add(QueryParameters, "OwnerUid", value.ToString());
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

		public string TransitRouterId
		{
			get
			{
				return transitRouterId;
			}
			set	
			{
				transitRouterId = value;
				DictionaryUtil.Add(QueryParameters, "TransitRouterId", value);
			}
		}

		public string TransitRouterTableId
		{
			get
			{
				return transitRouterTableId;
			}
			set	
			{
				transitRouterTableId = value;
				DictionaryUtil.Add(QueryParameters, "TransitRouterTableId", value);
			}
		}

		public string NextHop
		{
			get
			{
				return nextHop;
			}
			set	
			{
				nextHop = value;
				DictionaryUtil.Add(QueryParameters, "NextHop", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListTransitRouterPrefixListAssociationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListTransitRouterPrefixListAssociationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
