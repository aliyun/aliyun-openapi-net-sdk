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
using Aliyun.Acs.ddoscoo;
using Aliyun.Acs.ddoscoo.Transform;
using Aliyun.Acs.ddoscoo.Transform.V20200101;

namespace Aliyun.Acs.ddoscoo.Model.V20200101
{
    public class CreateDomainResourceRequest : RpcAcsRequest<CreateDomainResourceResponse>
    {
        public CreateDomainResourceRequest()
            : base("ddoscoo", "2020-01-01", "CreateDomainResource")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.ddoscoo.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.ddoscoo.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string httpsExt;

		private int? rsType;

		private List<string> realServerss = new List<string>(){ };

		private List<string> instanceIdss = new List<string>(){ };

		private List<ProxyTypes> proxyTypess = new List<ProxyTypes>(){ };

		private string domain;

		public string HttpsExt
		{
			get
			{
				return httpsExt;
			}
			set	
			{
				httpsExt = value;
				DictionaryUtil.Add(QueryParameters, "HttpsExt", value);
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

		public List<string> RealServerss
		{
			get
			{
				return realServerss;
			}

			set
			{
				realServerss = value;
				for (int i = 0; i < realServerss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"RealServers." + (i + 1) , realServerss[i]);
				}
			}
		}

		public List<string> InstanceIdss
		{
			get
			{
				return instanceIdss;
			}

			set
			{
				instanceIdss = value;
				for (int i = 0; i < instanceIdss.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"InstanceIds." + (i + 1) , instanceIdss[i]);
				}
			}
		}

		public List<ProxyTypes> ProxyTypess
		{
			get
			{
				return proxyTypess;
			}

			set
			{
				proxyTypess = value;
				for (int i = 0; i < proxyTypess.Count; i++)
				{
					for (int j = 0; j < proxyTypess[i].ProxyPortss.Count; j++)
					{
						DictionaryUtil.Add(QueryParameters,"ProxyTypes." + (i + 1) + ".ProxyPorts." +(j + 1), proxyTypess[i].ProxyPortss[j]);
					}
					DictionaryUtil.Add(QueryParameters,"ProxyTypes." + (i + 1) + ".ProxyType", proxyTypess[i].ProxyType);
				}
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

		public class ProxyTypes
		{

			private List<int?> proxyPortss = new List<int?>(){ };

			private string proxyType;

			public List<int?> ProxyPortss
			{
				get
				{
					return proxyPortss;
				}
				set	
				{
					proxyPortss = value;
				}
			}

			public string ProxyType
			{
				get
				{
					return proxyType;
				}
				set	
				{
					proxyType = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CreateDomainResourceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CreateDomainResourceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
