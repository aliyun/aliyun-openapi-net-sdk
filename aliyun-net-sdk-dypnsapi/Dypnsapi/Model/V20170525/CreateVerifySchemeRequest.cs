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
    public class CreateVerifySchemeRequest : RpcAcsRequest<CreateVerifySchemeResponse>
    {
        public CreateVerifySchemeRequest()
            : base("Dypnsapi", "2017-05-25", "CreateVerifyScheme", "dypnsapi", "openAPI")
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

		private string bundleId;

		private string authType;

		private string appName;

		private string ipWhiteList;

		private string email;

		private string packSign;

		private string packName;

		private long? cuApiCode;

		private string sceneType;

		private string resourceOwnerAccount;

		private long? ctApiCode;

		private string osType;

		private long? ownerId;

		private string url;

		private long? cmApiCode;

		private string schemeName;

		private string smsSignName;

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

		public string AuthType
		{
			get
			{
				return authType;
			}
			set	
			{
				authType = value;
				DictionaryUtil.Add(QueryParameters, "AuthType", value);
			}
		}

		public string AppName
		{
			get
			{
				return appName;
			}
			set	
			{
				appName = value;
				DictionaryUtil.Add(QueryParameters, "AppName", value);
			}
		}

		public string IpWhiteList
		{
			get
			{
				return ipWhiteList;
			}
			set	
			{
				ipWhiteList = value;
				DictionaryUtil.Add(QueryParameters, "IpWhiteList", value);
			}
		}

		public string Email
		{
			get
			{
				return email;
			}
			set	
			{
				email = value;
				DictionaryUtil.Add(QueryParameters, "Email", value);
			}
		}

		public string PackSign
		{
			get
			{
				return packSign;
			}
			set	
			{
				packSign = value;
				DictionaryUtil.Add(QueryParameters, "PackSign", value);
			}
		}

		public string PackName
		{
			get
			{
				return packName;
			}
			set	
			{
				packName = value;
				DictionaryUtil.Add(QueryParameters, "PackName", value);
			}
		}

		public long? CuApiCode
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

		public string SceneType
		{
			get
			{
				return sceneType;
			}
			set	
			{
				sceneType = value;
				DictionaryUtil.Add(QueryParameters, "SceneType", value);
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

		public long? CtApiCode
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

		public long? CmApiCode
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

		public string SchemeName
		{
			get
			{
				return schemeName;
			}
			set	
			{
				schemeName = value;
				DictionaryUtil.Add(QueryParameters, "SchemeName", value);
			}
		}

		public string SmsSignName
		{
			get
			{
				return smsSignName;
			}
			set	
			{
				smsSignName = value;
				DictionaryUtil.Add(QueryParameters, "SmsSignName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateVerifySchemeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateVerifySchemeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
