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
using Aliyun.Acs.waf_openapi.Transform.V20190910;

namespace Aliyun.Acs.waf_openapi.Model.V20190910
{
    public class ModifyDomainRequest : RpcAcsRequest<ModifyDomainResponse>
    {
        public ModifyDomainRequest()
            : base("waf-openapi", "2019-09-10", "ModifyDomain", "waf", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.waf_openapi.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.waf_openapi.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? ipFollowStatus;

		private string httpPort;

		private string http2Port;

		private int? writeTime;

		private int? accessHeaderMode;

		private string accessType;

		private string logHeaders;

		private string accessHeaders;

		private int? connectionTime;

		private int? clusterType;

		private string cloudNativeInstances;

		private int? httpsRedirect;

		private string instanceId;

		private string sourceIps;

		private string domain;

		private int? isAccessProduct;

		private int? readTime;

		private string httpsPort;

		private int? loadBalancing;

		private int? httpToUserIp;

		public int? IpFollowStatus
		{
			get
			{
				return ipFollowStatus;
			}
			set	
			{
				ipFollowStatus = value;
				DictionaryUtil.Add(QueryParameters, "IpFollowStatus", value.ToString());
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

		public string Http2Port
		{
			get
			{
				return http2Port;
			}
			set	
			{
				http2Port = value;
				DictionaryUtil.Add(QueryParameters, "Http2Port", value);
			}
		}

		public int? WriteTime
		{
			get
			{
				return writeTime;
			}
			set	
			{
				writeTime = value;
				DictionaryUtil.Add(QueryParameters, "WriteTime", value.ToString());
			}
		}

		public int? AccessHeaderMode
		{
			get
			{
				return accessHeaderMode;
			}
			set	
			{
				accessHeaderMode = value;
				DictionaryUtil.Add(QueryParameters, "AccessHeaderMode", value.ToString());
			}
		}

		public string AccessType
		{
			get
			{
				return accessType;
			}
			set	
			{
				accessType = value;
				DictionaryUtil.Add(QueryParameters, "AccessType", value);
			}
		}

		public string LogHeaders
		{
			get
			{
				return logHeaders;
			}
			set	
			{
				logHeaders = value;
				DictionaryUtil.Add(QueryParameters, "LogHeaders", value);
			}
		}

		public string AccessHeaders
		{
			get
			{
				return accessHeaders;
			}
			set	
			{
				accessHeaders = value;
				DictionaryUtil.Add(QueryParameters, "AccessHeaders", value);
			}
		}

		public int? ConnectionTime
		{
			get
			{
				return connectionTime;
			}
			set	
			{
				connectionTime = value;
				DictionaryUtil.Add(QueryParameters, "ConnectionTime", value.ToString());
			}
		}

		public int? ClusterType
		{
			get
			{
				return clusterType;
			}
			set	
			{
				clusterType = value;
				DictionaryUtil.Add(QueryParameters, "ClusterType", value.ToString());
			}
		}

		public string CloudNativeInstances
		{
			get
			{
				return cloudNativeInstances;
			}
			set	
			{
				cloudNativeInstances = value;
				DictionaryUtil.Add(QueryParameters, "CloudNativeInstances", value);
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

		public int? ReadTime
		{
			get
			{
				return readTime;
			}
			set	
			{
				readTime = value;
				DictionaryUtil.Add(QueryParameters, "ReadTime", value.ToString());
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

        public override ModifyDomainResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDomainResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
