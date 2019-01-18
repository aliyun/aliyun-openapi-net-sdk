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
    public class ModifyRouteTableAttributesRequest : RpcAcsRequest<ModifyRouteTableAttributesResponse>
    {
        public ModifyRouteTableAttributesRequest()
            : base("Vpc", "2016-04-28", "ModifyRouteTableAttributes", "vpc", "openAPI")
        {
        }

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string bandwidth;

		private string ownerAccount;

		private string description;

		private long? ownerId;

		private string kbpsBandwidth;

		private string routeTableName;

		private string regionId;

		private long? resourceUid;

		private string action;

		private string resourceBid;

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

		public string Bandwidth
		{
			get
			{
				return bandwidth;
			}
			set	
			{
				bandwidth = value;
				DictionaryUtil.Add(QueryParameters, "Bandwidth", value);
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

		public string KbpsBandwidth
		{
			get
			{
				return kbpsBandwidth;
			}
			set	
			{
				kbpsBandwidth = value;
				DictionaryUtil.Add(QueryParameters, "KbpsBandwidth", value);
			}
		}

		public string RouteTableName
		{
			get
			{
				return routeTableName;
			}
			set	
			{
				routeTableName = value;
				DictionaryUtil.Add(QueryParameters, "RouteTableName", value);
			}
		}

		public string RegionId
		{
			get
			{
				return regionId;
			}
			set	
			{
				regionId = value;
				DictionaryUtil.Add(QueryParameters, "RegionId", value);
			}
		}

		public long? ResourceUid
		{
			get
			{
				return resourceUid;
			}
			set	
			{
				resourceUid = value;
				DictionaryUtil.Add(QueryParameters, "ResourceUid", value.ToString());
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

		public string ResourceBid
		{
			get
			{
				return resourceBid;
			}
			set	
			{
				resourceBid = value;
				DictionaryUtil.Add(QueryParameters, "ResourceBid", value);
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

        public override ModifyRouteTableAttributesResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return ModifyRouteTableAttributesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}