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
    public class DeleteCenChildInstanceRouteEntryToCenRequest : RpcAcsRequest<DeleteCenChildInstanceRouteEntryToCenResponse>
    {
        public DeleteCenChildInstanceRouteEntryToCenRequest()
            : base("Cbn", "2017-09-12", "DeleteCenChildInstanceRouteEntryToCen", "cbn", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Cbn.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Cbn.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string cenId;

		private string childInstanceRegionId;

		private string routeTableId;

		private string resourceOwnerAccount;

		private string ownerAccount;

		private string destinationCidrBlock;

		private long? ownerId;

		private string childInstanceType;

		private string childInstanceId;

		private long? childInstanceAliUid;

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

		public string CenId
		{
			get
			{
				return cenId;
			}
			set	
			{
				cenId = value;
				DictionaryUtil.Add(QueryParameters, "CenId", value);
			}
		}

		public string ChildInstanceRegionId
		{
			get
			{
				return childInstanceRegionId;
			}
			set	
			{
				childInstanceRegionId = value;
				DictionaryUtil.Add(QueryParameters, "ChildInstanceRegionId", value);
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

		public string ChildInstanceType
		{
			get
			{
				return childInstanceType;
			}
			set	
			{
				childInstanceType = value;
				DictionaryUtil.Add(QueryParameters, "ChildInstanceType", value);
			}
		}

		public string ChildInstanceId
		{
			get
			{
				return childInstanceId;
			}
			set	
			{
				childInstanceId = value;
				DictionaryUtil.Add(QueryParameters, "ChildInstanceId", value);
			}
		}

		public long? ChildInstanceAliUid
		{
			get
			{
				return childInstanceAliUid;
			}
			set	
			{
				childInstanceAliUid = value;
				DictionaryUtil.Add(QueryParameters, "ChildInstanceAliUid", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DeleteCenChildInstanceRouteEntryToCenResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DeleteCenChildInstanceRouteEntryToCenResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
