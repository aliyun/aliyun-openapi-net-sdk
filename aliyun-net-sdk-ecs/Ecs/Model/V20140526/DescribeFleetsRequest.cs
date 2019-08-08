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
    public class DescribeFleetsRequest : RpcAcsRequest<DescribeFleetsResponse>
    {
        public DescribeFleetsRequest()
            : base("Ecs", "2014-05-26", "DescribeFleets", "ecs", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? resourceOwnerId;

		private int? pageNumber;

		private string fleetName;

		private List<string> fleetStatuss;

		private int? pageSize;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private long? ownerId;

		private List<string> fleetIds;

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

		public string FleetName
		{
			get
			{
				return fleetName;
			}
			set	
			{
				fleetName = value;
				DictionaryUtil.Add(QueryParameters, "FleetName", value);
			}
		}

		public List<string> FleetStatuss
		{
			get
			{
				return fleetStatuss;
			}

			set
			{
				fleetStatuss = value;
				for (int i = 0; i < fleetStatuss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"FleetStatus." + (i + 1) , fleetStatuss[i]);
				}
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

		public List<string> FleetIds
		{
			get
			{
				return fleetIds;
			}

			set
			{
				fleetIds = value;
				for (int i = 0; i < fleetIds.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"FleetId." + (i + 1) , fleetIds[i]);
				}
			}
		}

        public override DescribeFleetsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeFleetsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
