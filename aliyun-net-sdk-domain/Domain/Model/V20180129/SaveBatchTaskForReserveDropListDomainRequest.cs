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
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20180129;

namespace Aliyun.Acs.Domain.Model.V20180129
{
    public class SaveBatchTaskForReserveDropListDomainRequest : RpcAcsRequest<SaveBatchTaskForReserveDropListDomainResponse>
    {
        public SaveBatchTaskForReserveDropListDomainRequest()
            : base("Domain", "2018-01-29", "SaveBatchTaskForReserveDropListDomain", "domain", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Domain.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Domain.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private List<string> domainss = new List<string>(){ };

		private string contactTemplateId;

		[JsonProperty(PropertyName = "Domains")]
		public List<string> Domainss
		{
			get
			{
				return domainss;
			}

			set
			{
				domainss = value;
				if(domainss != null)
				{
					for (int depth1 = 0; depth1 < domainss.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Domains." + (depth1 + 1), domainss[depth1]);
						DictionaryUtil.Add(QueryParameters,"Domains." + (depth1 + 1), domainss[depth1]);
						DictionaryUtil.Add(QueryParameters,"Domains." + (depth1 + 1), domainss[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "ContactTemplateId")]
		public string ContactTemplateId
		{
			get
			{
				return contactTemplateId;
			}
			set	
			{
				contactTemplateId = value;
				DictionaryUtil.Add(QueryParameters, "ContactTemplateId", value);
			}
		}

		public class Domains
		{

			private string dns2;

			private string dns1;

			private string domainName;

			[JsonProperty(PropertyName = "Dns2")]
			public string Dns2
			{
				get
				{
					return dns2;
				}
				set	
				{
					dns2 = value;
				}
			}

			[JsonProperty(PropertyName = "Dns1")]
			public string Dns1
			{
				get
				{
					return dns1;
				}
				set	
				{
					dns1 = value;
				}
			}

			[JsonProperty(PropertyName = "DomainName")]
			public string DomainName
			{
				get
				{
					return domainName;
				}
				set	
				{
					domainName = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SaveBatchTaskForReserveDropListDomainResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveBatchTaskForReserveDropListDomainResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
