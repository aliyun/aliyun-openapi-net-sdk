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
using Aliyun.Acs.Ims.Transform;
using Aliyun.Acs.Ims.Transform.V20190815;

namespace Aliyun.Acs.Ims.Model.V20190815
{
    public class CreateApplicationRequest : RpcAcsRequest<CreateApplicationResponse>
    {
        public CreateApplicationRequest()
            : base("Ims", "2019-08-15", "CreateApplication", "ims", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ims.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ims.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string appName;

		private string requiredScopes;

		private int? accessTokenValidity;

		private int? refreshTokenValidity;

		private string redirectUris;

		private bool? secretRequired;

		private string appType;

		private string displayName;

		private string predefinedScopes;

		private bool? isMultiTenant;

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

		public string RequiredScopes
		{
			get
			{
				return requiredScopes;
			}
			set	
			{
				requiredScopes = value;
				DictionaryUtil.Add(QueryParameters, "RequiredScopes", value);
			}
		}

		public int? AccessTokenValidity
		{
			get
			{
				return accessTokenValidity;
			}
			set	
			{
				accessTokenValidity = value;
				DictionaryUtil.Add(QueryParameters, "AccessTokenValidity", value.ToString());
			}
		}

		public int? RefreshTokenValidity
		{
			get
			{
				return refreshTokenValidity;
			}
			set	
			{
				refreshTokenValidity = value;
				DictionaryUtil.Add(QueryParameters, "RefreshTokenValidity", value.ToString());
			}
		}

		public string RedirectUris
		{
			get
			{
				return redirectUris;
			}
			set	
			{
				redirectUris = value;
				DictionaryUtil.Add(QueryParameters, "RedirectUris", value);
			}
		}

		public bool? SecretRequired
		{
			get
			{
				return secretRequired;
			}
			set	
			{
				secretRequired = value;
				DictionaryUtil.Add(QueryParameters, "SecretRequired", value.ToString());
			}
		}

		public string AppType
		{
			get
			{
				return appType;
			}
			set	
			{
				appType = value;
				DictionaryUtil.Add(QueryParameters, "AppType", value);
			}
		}

		public string DisplayName
		{
			get
			{
				return displayName;
			}
			set	
			{
				displayName = value;
				DictionaryUtil.Add(QueryParameters, "DisplayName", value);
			}
		}

		public string PredefinedScopes
		{
			get
			{
				return predefinedScopes;
			}
			set	
			{
				predefinedScopes = value;
				DictionaryUtil.Add(QueryParameters, "PredefinedScopes", value);
			}
		}

		public bool? IsMultiTenant
		{
			get
			{
				return isMultiTenant;
			}
			set	
			{
				isMultiTenant = value;
				DictionaryUtil.Add(QueryParameters, "IsMultiTenant", value.ToString());
			}
		}

        public override CreateApplicationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateApplicationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
