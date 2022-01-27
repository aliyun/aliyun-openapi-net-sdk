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
    public class CreateDomainConfigRequest : RpcAcsRequest<CreateDomainConfigResponse>
    {
        public CreateDomainConfigRequest()
            : base("waf-openapi", "2018-01-17", "CreateDomainConfig", "waf", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.waf_openapi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.waf_openapi.Endpoint.endpointRegionalType, null);
            }
			Protocol = ProtocolType.HTTPS;
			Method = MethodType.POST;
        }

		private string resourceGroupId;

		private string httpPort;

		private string protocols;

		private int? rsType;

		private int? httpsRedirect;

		private string instanceId;

		private string sourceIps;

		private string domain;

		private int? isAccessProduct;

		private string httpsPort;

		private string region;

		private int? loadBalancing;

		private int? httpToUserIp;

		public string ResourceGroupId
		{
			get
			{
				return resourceGroupId;
			}
			set	
			{
				resourceGroupId = value;
				DictionaryUtil.Add(QueryParameters, "ResourceGroupId", value);
			}
		}

		public string HttpPort
		{
			get
			{
				return httpPort;
			}
			set	
			{
				httpPort = value;
				DictionaryUtil.Add(QueryParameters, "HttpPort", value);
			}
		}

		public string Protocols
		{
			get
			{
				return protocols;
			}
			set	
			{
				protocols = value;
				DictionaryUtil.Add(QueryParameters, "Protocols", value);
			}
		}

		public int? RsType
		{
			get
			{
				return rsType;
			}
			set	
			{
				rsType = value;
				DictionaryUtil.Add(QueryParameters, "RsType", value.ToString());
			}
		}

		public int? HttpsRedirect
		{
			get
			{
				return httpsRedirect;
			}
			set	
			{
				httpsRedirect = value;
				DictionaryUtil.Add(QueryParameters, "HttpsRedirect", value.ToString());
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

		public string SourceIps
		{
			get
			{
				return sourceIps;
			}
			set	
			{
				sourceIps = value;
				DictionaryUtil.Add(QueryParameters, "SourceIps", value);
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

		public int? IsAccessProduct
		{
			get
			{
				return isAccessProduct;
			}
			set	
			{
				isAccessProduct = value;
				DictionaryUtil.Add(QueryParameters, "IsAccessProduct", value.ToString());
			}
		}

		public string HttpsPort
		{
			get
			{
				return httpsPort;
			}
			set	
			{
				httpsPort = value;
				DictionaryUtil.Add(QueryParameters, "HttpsPort", value);
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

		public int? LoadBalancing
		{
			get
			{
				return loadBalancing;
			}
			set	
			{
				loadBalancing = value;
				DictionaryUtil.Add(QueryParameters, "LoadBalancing", value.ToString());
			}
		}

		public int? HttpToUserIp
		{
			get
			{
				return httpToUserIp;
			}
			set	
			{
				httpToUserIp = value;
				DictionaryUtil.Add(QueryParameters, "HttpToUserIp", value.ToString());
			}
		}

        public override CreateDomainConfigResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDomainConfigResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
