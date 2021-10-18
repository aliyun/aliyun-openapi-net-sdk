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
using Aliyun.Acs.waf_openapi.Transform;
using Aliyun.Acs.waf_openapi.Transform.V20180117;

namespace Aliyun.Acs.waf_openapi.Model.V20180117
{
    public class CreateCertAndKeyRequest : RpcAcsRequest<CreateCertAndKeyResponse>
    {
        public CreateCertAndKeyRequest()
            : base("waf-openapi", "2018-01-17", "CreateCertAndKey", "waf", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.waf_openapi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.waf_openapi.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string cert;

		private string httpsCertName;

		private string key;

		private string instanceId;

		private string domain;

		private string region;

		public string Cert
		{
			get
			{
				return cert;
			}
			set	
			{
				cert = value;
				DictionaryUtil.Add(QueryParameters, "Cert", value);
			}
		}

		public string HttpsCertName
		{
			get
			{
				return httpsCertName;
			}
			set	
			{
				httpsCertName = value;
				DictionaryUtil.Add(QueryParameters, "HttpsCertName", value);
			}
		}

		public string Key
		{
			get
			{
				return key;
			}
			set	
			{
				key = value;
				DictionaryUtil.Add(QueryParameters, "Key", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string Domain
		{
			get
			{
				return domain;
			}
			set	
			{
				domain = value;
				DictionaryUtil.Add(QueryParameters, "Domain", value);
			}
		}

		public string Region
		{
			get
			{
				return region;
			}
			set	
			{
				region = value;
				DictionaryUtil.Add(QueryParameters, "Region", value);
			}
		}

        public override CreateCertAndKeyResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateCertAndKeyResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
