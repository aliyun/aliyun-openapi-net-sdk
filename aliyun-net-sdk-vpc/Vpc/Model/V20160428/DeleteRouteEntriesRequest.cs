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
    public class DeleteRouteEntriesRequest : RpcAcsRequest<DeleteRouteEntriesResponse>
    {
        public DeleteRouteEntriesRequest()
            : base("Vpc", "2016-04-28", "DeleteRouteEntries", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private List<string> routeEntriess = new List<string>(){ };

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

		public List<string> RouteEntriess
		{
			get
			{
				return routeEntriess;
			}

			set
			{
				routeEntriess = value;
				if(routeEntriess != null)
				{
					for (int depth1 = 0; depth1 < routeEntriess.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"RouteEntries." + (depth1 + 1), routeEntriess[depth1]);
						DictionaryUtil.Add(QueryParameters,"RouteEntries." + (depth1 + 1), routeEntriess[depth1]);
						DictionaryUtil.Add(QueryParameters,"RouteEntries." + (depth1 + 1), routeEntriess[depth1]);
						DictionaryUtil.Add(QueryParameters,"RouteEntries." + (depth1 + 1), routeEntriess[depth1]);
					}
				}
			}
		}

		public class RouteEntries
		{

			private string routeTableId;

			private string routeEntryId;

			private string dstCidrBlock;

			private string nextHop;

			public string RouteTableId
			{
				get
				{
					return routeTableId;
				}
				set	
				{
					routeTableId = value;
				}
			}

			public string RouteEntryId
			{
				get
				{
					return routeEntryId;
				}
				set	
				{
					routeEntryId = value;
				}
			}

			public string DstCidrBlock
			{
				get
				{
					return dstCidrBlock;
				}
				set	
				{
					dstCidrBlock = value;
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
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeleteRouteEntriesResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteRouteEntriesResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
