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
    public class DescribeRouteEntryListRequest : RpcAcsRequest<DescribeRouteEntryListResponse>
    {
        public DescribeRouteEntryListRequest()
            : base("Vpc", "2016-04-28", "DescribeRouteEntryList", "vpc", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Vpc.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string routeEntryName;

		private string nextToken;

		private string routeEntryType;

		private string ipVersion;

		private string nextHopId;

		private string nextHopType;

		private string routeTableId;

		private string resourceOwnerAccount;

		private string destinationCidrBlock;

		private string ownerAccount;

		private long? ownerId;

		private int? maxResult;

		private string routeEntryId;

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

		public string RouteEntryName
		{
			get
			{
				return routeEntryName;
			}
			set	
			{
				routeEntryName = value;
				DictionaryUtil.Add(QueryParameters, "RouteEntryName", value);
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

		public string RouteEntryType
		{
			get
			{
				return routeEntryType;
			}
			set	
			{
				routeEntryType = value;
				DictionaryUtil.Add(QueryParameters, "RouteEntryType", value);
			}
		}

		public string IpVersion
		{
			get
			{
				return ipVersion;
			}
			set	
			{
				ipVersion = value;
				DictionaryUtil.Add(QueryParameters, "IpVersion", value);
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

		public int? MaxResult
		{
			get
			{
				return maxResult;
			}
			set	
			{
				maxResult = value;
				DictionaryUtil.Add(QueryParameters, "MaxResult", value.ToString());
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
				DictionaryUtil.Add(QueryParameters, "RouteEntryId", value);
			}
		}

        public override DescribeRouteEntryListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeRouteEntryListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
