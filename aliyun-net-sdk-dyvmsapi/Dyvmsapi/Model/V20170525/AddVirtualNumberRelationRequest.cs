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
using Aliyun.Acs.Dyvmsapi.Transform;
using Aliyun.Acs.Dyvmsapi.Transform.V20170525;

namespace Aliyun.Acs.Dyvmsapi.Model.V20170525
{
    public class AddVirtualNumberRelationRequest : RpcAcsRequest<AddVirtualNumberRelationResponse>
    {
        public AddVirtualNumberRelationRequest()
            : base("Dyvmsapi", "2017-05-25", "AddVirtualNumberRelation", "dyvms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dyvmsapi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dyvmsapi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string numberList;

		private int? routeType;

		private string corpNameList;

		private string resourceOwnerAccount;

		private string prodCode;

		private string phoneNum;

		private long? ownerId;

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

		public string NumberList
		{
			get
			{
				return numberList;
			}
			set	
			{
				numberList = value;
				DictionaryUtil.Add(QueryParameters, "NumberList", value);
			}
		}

		public int? RouteType
		{
			get
			{
				return routeType;
			}
			set	
			{
				routeType = value;
				DictionaryUtil.Add(QueryParameters, "RouteType", value.ToString());
			}
		}

		public string CorpNameList
		{
			get
			{
				return corpNameList;
			}
			set	
			{
				corpNameList = value;
				DictionaryUtil.Add(QueryParameters, "CorpNameList", value);
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

		public string ProdCode
		{
			get
			{
				return prodCode;
			}
			set	
			{
				prodCode = value;
				DictionaryUtil.Add(QueryParameters, "ProdCode", value);
			}
		}

		public string PhoneNum
		{
			get
			{
				return phoneNum;
			}
			set	
			{
				phoneNum = value;
				DictionaryUtil.Add(QueryParameters, "PhoneNum", value);
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddVirtualNumberRelationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddVirtualNumberRelationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
