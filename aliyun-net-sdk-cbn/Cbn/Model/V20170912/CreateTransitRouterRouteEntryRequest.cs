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
    public class CreateTransitRouterRouteEntryRequest : RpcAcsRequest<CreateTransitRouterRouteEntryResponse>
    {
        public CreateTransitRouterRouteEntryRequest()
            : base("Cbn", "2017-09-12", "CreateTransitRouterRouteEntry", "cbn", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cbn.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cbn.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string clientToken;

		private string transitRouterRouteEntryNextHopType;

		private string transitRouterRouteEntryDestinationCidrBlock;

		private string transitRouterRouteTableId;

		private string transitRouterRouteEntryNextHopId;

		private string transitRouterRouteEntryDescription;

		private bool? dryRun;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string transitRouterRouteEntryName;

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

		public string TransitRouterRouteEntryNextHopType
		{
			get
			{
				return transitRouterRouteEntryNextHopType;
			}
			set	
			{
				transitRouterRouteEntryNextHopType = value;
				DictionaryUtil.Add(QueryParameters, "TransitRouterRouteEntryNextHopType", value);
			}
		}

		public string TransitRouterRouteEntryDestinationCidrBlock
		{
			get
			{
				return transitRouterRouteEntryDestinationCidrBlock;
			}
			set	
			{
				transitRouterRouteEntryDestinationCidrBlock = value;
				DictionaryUtil.Add(QueryParameters, "TransitRouterRouteEntryDestinationCidrBlock", value);
			}
		}

		public string TransitRouterRouteTableId
		{
			get
			{
				return transitRouterRouteTableId;
			}
			set	
			{
				transitRouterRouteTableId = value;
				DictionaryUtil.Add(QueryParameters, "TransitRouterRouteTableId", value);
			}
		}

		public string TransitRouterRouteEntryNextHopId
		{
			get
			{
				return transitRouterRouteEntryNextHopId;
			}
			set	
			{
				transitRouterRouteEntryNextHopId = value;
				DictionaryUtil.Add(QueryParameters, "TransitRouterRouteEntryNextHopId", value);
			}
		}

		public string TransitRouterRouteEntryDescription
		{
			get
			{
				return transitRouterRouteEntryDescription;
			}
			set	
			{
				transitRouterRouteEntryDescription = value;
				DictionaryUtil.Add(QueryParameters, "TransitRouterRouteEntryDescription", value);
			}
		}

		public bool? DryRun
		{
			get
			{
				return dryRun;
			}
			set	
			{
				dryRun = value;
				DictionaryUtil.Add(QueryParameters, "DryRun", value.ToString());
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

		public string TransitRouterRouteEntryName
		{
			get
			{
				return transitRouterRouteEntryName;
			}
			set	
			{
				transitRouterRouteEntryName = value;
				DictionaryUtil.Add(QueryParameters, "TransitRouterRouteEntryName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateTransitRouterRouteEntryResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateTransitRouterRouteEntryResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
