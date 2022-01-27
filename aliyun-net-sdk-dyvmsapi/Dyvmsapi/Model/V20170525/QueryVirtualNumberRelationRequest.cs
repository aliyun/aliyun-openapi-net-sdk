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
    public class QueryVirtualNumberRelationRequest : RpcAcsRequest<QueryVirtualNumberRelationResponse>
    {
        public QueryVirtualNumberRelationRequest()
            : base("Dyvmsapi", "2017-05-25", "QueryVirtualNumberRelation", "dyvms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dyvmsapi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dyvmsapi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? specId;

		private long? resourceOwnerId;

		private int? routeType;

		private int? pageSize;

		private string relatedNum;

		private string regionNameCity;

		private long? qualificationId;

		private string resourceOwnerAccount;

		private string prodCode;

		private string phoneNum;

		private long? ownerId;

		private int? pageNo;

		public long? SpecId
		{
			get
			{
				return specId;
			}
			set	
			{
				specId = value;
				DictionaryUtil.Add(QueryParameters, "SpecId", value.ToString());
			}
		}

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

		public string RelatedNum
		{
			get
			{
				return relatedNum;
			}
			set	
			{
				relatedNum = value;
				DictionaryUtil.Add(QueryParameters, "RelatedNum", value);
			}
		}

		public string RegionNameCity
		{
			get
			{
				return regionNameCity;
			}
			set	
			{
				regionNameCity = value;
				DictionaryUtil.Add(QueryParameters, "RegionNameCity", value);
			}
		}

		public long? QualificationId
		{
			get
			{
				return qualificationId;
			}
			set	
			{
				qualificationId = value;
				DictionaryUtil.Add(QueryParameters, "QualificationId", value.ToString());
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

		public int? PageNo
		{
			get
			{
				return pageNo;
			}
			set	
			{
				pageNo = value;
				DictionaryUtil.Add(QueryParameters, "PageNo", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override QueryVirtualNumberRelationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryVirtualNumberRelationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
