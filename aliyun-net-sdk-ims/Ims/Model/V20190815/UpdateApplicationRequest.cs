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
using Newtonsoft.Json;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Ims.Transform;
using Aliyun.Acs.Ims.Transform.V20190815;

namespace Aliyun.Acs.Ims.Model.V20190815
{
    public class UpdateApplicationRequest : RpcAcsRequest<UpdateApplicationResponse>
    {
        public UpdateApplicationRequest()
            : base("Ims", "2019-08-15", "UpdateApplication", "ims", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ims.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ims.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private bool? newIsMultiTenant;

		private int? newRefreshTokenValidity;

		private string newPredefinedScopes;

		private bool? newSecretRequired;

		private string newDisplayName;

		private string newRequiredScopes;

		private string newRedirectUris;

		private string appId;

		private int? newAccessTokenValidity;

		[JsonProperty(PropertyName = "NewIsMultiTenant")]
		public bool? NewIsMultiTenant
		{
			get
			{
				return newIsMultiTenant;
			}
			set	
			{
				newIsMultiTenant = value;
				DictionaryUtil.Add(QueryParameters, "NewIsMultiTenant", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "NewRefreshTokenValidity")]
		public int? NewRefreshTokenValidity
		{
			get
			{
				return newRefreshTokenValidity;
			}
			set	
			{
				newRefreshTokenValidity = value;
				DictionaryUtil.Add(QueryParameters, "NewRefreshTokenValidity", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "NewPredefinedScopes")]
		public string NewPredefinedScopes
		{
			get
			{
				return newPredefinedScopes;
			}
			set	
			{
				newPredefinedScopes = value;
				DictionaryUtil.Add(QueryParameters, "NewPredefinedScopes", value);
			}
		}

		[JsonProperty(PropertyName = "NewSecretRequired")]
		public bool? NewSecretRequired
		{
			get
			{
				return newSecretRequired;
			}
			set	
			{
				newSecretRequired = value;
				DictionaryUtil.Add(QueryParameters, "NewSecretRequired", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "NewDisplayName")]
		public string NewDisplayName
		{
			get
			{
				return newDisplayName;
			}
			set	
			{
				newDisplayName = value;
				DictionaryUtil.Add(QueryParameters, "NewDisplayName", value);
			}
		}

		[JsonProperty(PropertyName = "NewRequiredScopes")]
		public string NewRequiredScopes
		{
			get
			{
				return newRequiredScopes;
			}
			set	
			{
				newRequiredScopes = value;
				DictionaryUtil.Add(QueryParameters, "NewRequiredScopes", value);
			}
		}

		[JsonProperty(PropertyName = "NewRedirectUris")]
		public string NewRedirectUris
		{
			get
			{
				return newRedirectUris;
			}
			set	
			{
				newRedirectUris = value;
				DictionaryUtil.Add(QueryParameters, "NewRedirectUris", value);
			}
		}

		[JsonProperty(PropertyName = "AppId")]
		public string AppId
		{
			get
			{
				return appId;
			}
			set	
			{
				appId = value;
				DictionaryUtil.Add(QueryParameters, "AppId", value);
			}
		}

		[JsonProperty(PropertyName = "NewAccessTokenValidity")]
		public int? NewAccessTokenValidity
		{
			get
			{
				return newAccessTokenValidity;
			}
			set	
			{
				newAccessTokenValidity = value;
				DictionaryUtil.Add(QueryParameters, "NewAccessTokenValidity", value.ToString());
			}
		}

        public override UpdateApplicationResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return UpdateApplicationResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
