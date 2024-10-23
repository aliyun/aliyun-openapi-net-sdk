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
    public class CreateOIDCProviderRequest : RpcAcsRequest<CreateOIDCProviderResponse>
    {
        public CreateOIDCProviderRequest()
            : base("Ims", "2019-08-15", "CreateOIDCProvider", "ims", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ims.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ims.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private long? issuanceLimitTime;

		private string issuerUrl;

		private string oIDCProviderName;

		private string description;

		private string clientIds;

		private string fingerprints;

		public long? IssuanceLimitTime
		{
			get
			{
				return issuanceLimitTime;
			}
			set	
			{
				issuanceLimitTime = value;
				DictionaryUtil.Add(QueryParameters, "IssuanceLimitTime", value.ToString());
			}
		}

		public string IssuerUrl
		{
			get
			{
				return issuerUrl;
			}
			set	
			{
				issuerUrl = value;
				DictionaryUtil.Add(QueryParameters, "IssuerUrl", value);
			}
		}

		public string OIDCProviderName
		{
			get
			{
				return oIDCProviderName;
			}
			set	
			{
				oIDCProviderName = value;
				DictionaryUtil.Add(QueryParameters, "OIDCProviderName", value);
			}
		}

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string ClientIds
		{
			get
			{
				return clientIds;
			}
			set	
			{
				clientIds = value;
				DictionaryUtil.Add(QueryParameters, "ClientIds", value);
			}
		}

		public string Fingerprints
		{
			get
			{
				return fingerprints;
			}
			set	
			{
				fingerprints = value;
				DictionaryUtil.Add(QueryParameters, "Fingerprints", value);
			}
		}

        public override CreateOIDCProviderResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateOIDCProviderResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
