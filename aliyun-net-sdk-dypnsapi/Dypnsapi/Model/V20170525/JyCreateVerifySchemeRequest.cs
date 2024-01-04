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
    public class JyCreateVerifySchemeRequest : RpcAcsRequest<JyCreateVerifySchemeResponse>
    {
        public JyCreateVerifySchemeRequest()
            : base("Dypnsapi", "2017-05-25", "JyCreateVerifyScheme", "dypnsapi", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dypnsapi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dypnsapi.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string bundleId;

		private string appName;

		private string packSign;

		private string packName;

		private long? cuApiCode;

		private string resourceOwnerAccount;

		private long? ctApiCode;

		private string osType;

		private long? ownerId;

		private long? cmApiCode;

		private string schemeName;

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

        public override JyCreateVerifySchemeResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return JyCreateVerifySchemeResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
