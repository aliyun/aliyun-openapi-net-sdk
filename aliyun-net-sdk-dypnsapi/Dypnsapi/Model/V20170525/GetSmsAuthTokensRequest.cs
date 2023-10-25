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
    public class GetSmsAuthTokensRequest : RpcAcsRequest<GetSmsAuthTokensResponse>
    {
        public GetSmsAuthTokensRequest()
            : base("Dypnsapi", "2017-05-25", "GetSmsAuthTokens", "dypnsapi", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dypnsapi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dypnsapi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string bundleId;

		private string signName;

		private string sceneCode;

		private string resourceOwnerAccount;

		private int? smsCodeExpire;

		private string packageName;

		private string osType;

		private long? ownerId;

		private string smsTemplateCode;

		private long? expire;

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

		public string BundleId
		{
			get
			{
				return bundleId;
			}
			set	
			{
				bundleId = value;
				DictionaryUtil.Add(QueryParameters, "BundleId", value);
			}
		}

		public string SignName
		{
			get
			{
				return signName;
			}
			set	
			{
				signName = value;
				DictionaryUtil.Add(QueryParameters, "SignName", value);
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

		public int? SmsCodeExpire
		{
			get
			{
				return smsCodeExpire;
			}
			set	
			{
				smsCodeExpire = value;
				DictionaryUtil.Add(QueryParameters, "SmsCodeExpire", value.ToString());
			}
		}

		public string PackageName
		{
			get
			{
				return packageName;
			}
			set	
			{
				packageName = value;
				DictionaryUtil.Add(QueryParameters, "PackageName", value);
			}
		}

		public string OsType
		{
			get
			{
				return osType;
			}
			set	
			{
				osType = value;
				DictionaryUtil.Add(QueryParameters, "OsType", value);
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

		public string SmsTemplateCode
		{
			get
			{
				return smsTemplateCode;
			}
			set	
			{
				smsTemplateCode = value;
				DictionaryUtil.Add(QueryParameters, "SmsTemplateCode", value);
			}
		}

		public long? Expire
		{
			get
			{
				return expire;
			}
			set	
			{
				expire = value;
				DictionaryUtil.Add(QueryParameters, "Expire", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetSmsAuthTokensResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetSmsAuthTokensResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
