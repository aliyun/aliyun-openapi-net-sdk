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
    public class CreateSchemeConfigRequest : RpcAcsRequest<CreateSchemeConfigResponse>
    {
        public CreateSchemeConfigRequest()
            : base("Dypnsapi", "2017-05-25", "CreateSchemeConfig", "dypnsapi", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Dypnsapi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Dypnsapi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? resourceOwnerId;

		private string androidPackageSign;

		private string platform;

		private string h5Url;

		private string iosBundleId;

		private string appName;

		private string resourceOwnerAccount;

		private long? ownerId;

		private string h5Origin;

		private string schemeName;

		private string androidPackageName;

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

		public string AndroidPackageSign
		{
			get
			{
				return androidPackageSign;
			}
			set	
			{
				androidPackageSign = value;
				DictionaryUtil.Add(QueryParameters, "AndroidPackageSign", value);
			}
		}

		public string Platform
		{
			get
			{
				return platform;
			}
			set	
			{
				platform = value;
				DictionaryUtil.Add(QueryParameters, "Platform", value);
			}
		}

		public string H5Url
		{
			get
			{
				return h5Url;
			}
			set	
			{
				h5Url = value;
				DictionaryUtil.Add(QueryParameters, "H5Url", value);
			}
		}

		public string IosBundleId
		{
			get
			{
				return iosBundleId;
			}
			set	
			{
				iosBundleId = value;
				DictionaryUtil.Add(QueryParameters, "IosBundleId", value);
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

		public string H5Origin
		{
			get
			{
				return h5Origin;
			}
			set	
			{
				h5Origin = value;
				DictionaryUtil.Add(QueryParameters, "H5Origin", value);
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

		public string AndroidPackageName
		{
			get
			{
				return androidPackageName;
			}
			set	
			{
				androidPackageName = value;
				DictionaryUtil.Add(QueryParameters, "AndroidPackageName", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateSchemeConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateSchemeConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
