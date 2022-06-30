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
    public class ModifyDomainResourceRequest : RpcAcsRequest<ModifyDomainResourceResponse>
    {
        public ModifyDomainResourceRequest()
            : base("ddoscoo", "2020-01-01", "ModifyDomainResource")
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

		private List<ProxyTypes> proxyTypess = new List<ProxyTypes>(){ };

		private List<string> instanceIdss = new List<string>(){ };

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
				if(proxyTypess != null)
				{
					for (int depth1 = 0; depth1 < proxyTypess.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"ProxyTypes." + (depth1 + 1), proxyTypess[depth1]);
					}
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

			private List<string> proxyPortss = new List<string>(){ };

			private string proxyType;

			public List<string> ProxyPortss
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

        public override ModifyDomainResourceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ModifyDomainResourceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
