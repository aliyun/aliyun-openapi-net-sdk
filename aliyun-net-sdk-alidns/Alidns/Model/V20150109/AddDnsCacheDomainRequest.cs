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
using Aliyun.Acs.Alidns.Transform;
using Aliyun.Acs.Alidns.Transform.V20150109;

namespace Aliyun.Acs.Alidns.Model.V20150109
{
    public class AddDnsCacheDomainRequest : RpcAcsRequest<AddDnsCacheDomainResponse>
    {
        public AddDnsCacheDomainRequest()
            : base("Alidns", "2015-01-09", "AddDnsCacheDomain", "alidns", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Alidns.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Alidns.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string remark;

		private string sourceProtocol;

		private string lang;

		private string domainName;

		private int? cacheTtlMax;

		private string instanceId;

		private string sourceEdns;

		private int? cacheTtlMin;

		private List<SourceDnsServer> sourceDnsServers = new List<SourceDnsServer>(){ };

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
				DictionaryUtil.Add(QueryParameters, "Remark", value);
			}
		}

		public string SourceProtocol
		{
			get
			{
				return sourceProtocol;
			}
			set	
			{
				sourceProtocol = value;
				DictionaryUtil.Add(QueryParameters, "SourceProtocol", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string DomainName
		{
			get
			{
				return domainName;
			}
			set	
			{
				domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public int? CacheTtlMax
		{
			get
			{
				return cacheTtlMax;
			}
			set	
			{
				cacheTtlMax = value;
				DictionaryUtil.Add(QueryParameters, "CacheTtlMax", value.ToString());
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

		public string SourceEdns
		{
			get
			{
				return sourceEdns;
			}
			set	
			{
				sourceEdns = value;
				DictionaryUtil.Add(QueryParameters, "SourceEdns", value);
			}
		}

		public int? CacheTtlMin
		{
			get
			{
				return cacheTtlMin;
			}
			set	
			{
				cacheTtlMin = value;
				DictionaryUtil.Add(QueryParameters, "CacheTtlMin", value.ToString());
			}
		}

		public List<SourceDnsServer> SourceDnsServers
		{
			get
			{
				return sourceDnsServers;
			}

			set
			{
				sourceDnsServers = value;
				for (int i = 0; i < sourceDnsServers.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"SourceDnsServer." + (i + 1) + ".Port", sourceDnsServers[i].Port);
					DictionaryUtil.Add(QueryParameters,"SourceDnsServer." + (i + 1) + ".Host", sourceDnsServers[i].Host);
				}
			}
		}

		public class SourceDnsServer
		{

			private string port;

			private string host;

			public string Port
			{
				get
				{
					return port;
				}
				set	
				{
					port = value;
				}
			}

			public string Host
			{
				get
				{
					return host;
				}
				set	
				{
					host = value;
				}
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override AddDnsCacheDomainResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return AddDnsCacheDomainResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
