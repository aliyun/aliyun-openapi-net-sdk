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
    public class QueryCallDetailByCallIdRequest : RpcAcsRequest<QueryCallDetailByCallIdResponse>
    {
        public QueryCallDetailByCallIdRequest()
            : base("Dyvmsapi", "2017-05-25", "QueryCallDetailByCallId", "dyvms", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private string callId;

		private long? resourceOwnerId;

		private long? queryDate;

		private string resourceOwnerAccount;

		private long? prodId;

		private long? ownerId;

		public string CallId
		{
			get
			{
				return callId;
			}
			set	
			{
				callId = value;
				DictionaryUtil.Add(QueryParameters, "CallId", value);
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

		public long? QueryDate
		{
			get
			{
				return queryDate;
			}
			set	
			{
				queryDate = value;
				DictionaryUtil.Add(QueryParameters, "QueryDate", value.ToString());
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

		public long? ProdId
		{
			get
			{
				return prodId;
			}
			set	
			{
				prodId = value;
				DictionaryUtil.Add(QueryParameters, "ProdId", value.ToString());
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

        public override QueryCallDetailByCallIdResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryCallDetailByCallIdResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
