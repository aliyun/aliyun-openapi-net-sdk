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
using Aliyun.Acs.SmartHosting.Transform;
using Aliyun.Acs.SmartHosting.Transform.V20200801;

namespace Aliyun.Acs.SmartHosting.Model.V20200801
{
    public class ListManagedRacksRequest : RpcAcsRequest<ListManagedRacksResponse>
    {
        public ListManagedRacksRequest()
            : base("SmartHosting", "2020-08-01", "ListManagedRacks", "smarthosting", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string hostType;

		private string nextToken;

		private List<string> managedRackIds = new List<string>(){ };

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private string managedPrivateSpaceId;

		private string zoneId;

		private int? maxResults;

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

		public string HostType
		{
			get
			{
				return hostType;
			}
			set	
			{
				hostType = value;
				DictionaryUtil.Add(QueryParameters, "HostType", value);
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

		public List<string> ManagedRackIds
		{
			get
			{
				return managedRackIds;
			}

			set
			{
				managedRackIds = value;
				for (int i = 0; i < managedRackIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ManagedRackId." + (i + 1) , managedRackIds[i]);
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

		public string ManagedPrivateSpaceId
		{
			get
			{
				return managedPrivateSpaceId;
			}
			set	
			{
				managedPrivateSpaceId = value;
				DictionaryUtil.Add(QueryParameters, "ManagedPrivateSpaceId", value);
			}
		}

		public string ZoneId
		{
			get
			{
				return zoneId;
			}
			set	
			{
				zoneId = value;
				DictionaryUtil.Add(QueryParameters, "ZoneId", value);
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

        public override ListManagedRacksResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListManagedRacksResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
