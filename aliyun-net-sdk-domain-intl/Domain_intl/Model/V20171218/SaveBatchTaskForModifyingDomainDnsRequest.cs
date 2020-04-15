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
using Aliyun.Acs.Domain_intl.Transform;
using Aliyun.Acs.Domain_intl.Transform.V20171218;

namespace Aliyun.Acs.Domain_intl.Model.V20171218
{
    public class SaveBatchTaskForModifyingDomainDnsRequest : RpcAcsRequest<SaveBatchTaskForModifyingDomainDnsResponse>
    {
        public SaveBatchTaskForModifyingDomainDnsRequest()
            : base("Domain-intl", "2017-12-18", "SaveBatchTaskForModifyingDomainDns", "domain", "openAPI")
        {
        }

		private List<string> domainNames = new List<string>(){ };

		private bool? aliyunDns;

		private string userClientIp;

		private List<string> domainNameServers = new List<string>(){ };

		private string lang;

		public List<string> DomainNames
		{
			get
			{
				return domainNames;
			}

			set
			{
				domainNames = value;
				for (int i = 0; i < domainNames.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DomainName." + (i + 1) , domainNames[i]);
				}
			}
		}

		public bool? AliyunDns
		{
			get
			{
				return aliyunDns;
			}
			set	
			{
				aliyunDns = value;
				DictionaryUtil.Add(QueryParameters, "AliyunDns", value.ToString());
			}
		}

		public string UserClientIp
		{
			get
			{
				return userClientIp;
			}
			set	
			{
				userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public List<string> DomainNameServers
		{
			get
			{
				return domainNameServers;
			}

			set
			{
				domainNameServers = value;
				for (int i = 0; i < domainNameServers.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DomainNameServer." + (i + 1) , domainNameServers[i]);
				}
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

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SaveBatchTaskForModifyingDomainDnsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SaveBatchTaskForModifyingDomainDnsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
