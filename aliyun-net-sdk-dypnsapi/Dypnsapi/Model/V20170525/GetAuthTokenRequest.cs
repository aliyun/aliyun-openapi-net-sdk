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
using Aliyun.Acs.Dypnsapi.Transform;
using Aliyun.Acs.Dypnsapi.Transform.V20170525;

namespace Aliyun.Acs.Dypnsapi.Model.V20170525
{
    public class GetAuthTokenRequest : RpcAcsRequest<GetAuthTokenResponse>
    {
        public GetAuthTokenRequest()
            : base("Dypnsapi", "2017-05-25", "GetAuthToken", "dypnsapi", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dypnsapi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dypnsapi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string origin;

		private string sceneCode;

		private int? cuApiCode;

		private string resourceOwnerAccount;

		private int? ctApiCode;

		private long? ownerId;

		private string version;

		private string url;

		private int? bizType;

		private int? cmApiCode;

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

		public string Origin
		{
			get
			{
				return origin;
			}
			set	
			{
				origin = value;
				DictionaryUtil.Add(QueryParameters, "Origin", value);
			}
		}

		public string SceneCode
		{
			get
			{
				return sceneCode;
			}
			set	
			{
				sceneCode = value;
				DictionaryUtil.Add(QueryParameters, "SceneCode", value);
			}
		}

		public int? CuApiCode
		{
			get
			{
				return cuApiCode;
			}
			set	
			{
				cuApiCode = value;
				DictionaryUtil.Add(QueryParameters, "CuApiCode", value.ToString());
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

		public int? CtApiCode
		{
			get
			{
				return ctApiCode;
			}
			set	
			{
				ctApiCode = value;
				DictionaryUtil.Add(QueryParameters, "CtApiCode", value.ToString());
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

		public string Version
		{
			get
			{
				return version;
			}
			set	
			{
				version = value;
				DictionaryUtil.Add(QueryParameters, "Version", value);
			}
		}

		public string Url
		{
			get
			{
				return url;
			}
			set	
			{
				url = value;
				DictionaryUtil.Add(QueryParameters, "Url", value);
			}
		}

		public int? BizType
		{
			get
			{
				return bizType;
			}
			set	
			{
				bizType = value;
				DictionaryUtil.Add(QueryParameters, "BizType", value.ToString());
			}
		}

		public int? CmApiCode
		{
			get
			{
				return cmApiCode;
			}
			set	
			{
				cmApiCode = value;
				DictionaryUtil.Add(QueryParameters, "CmApiCode", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetAuthTokenResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetAuthTokenResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
