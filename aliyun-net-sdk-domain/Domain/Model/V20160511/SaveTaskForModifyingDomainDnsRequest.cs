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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20160511;
using System.Collections.Generic;

namespace Aliyun.Acs.Domain.Model.V20160511
{
    public class SaveTaskForModifyingDomainDnsRequest : RpcAcsRequest<SaveTaskForModifyingDomainDnsResponse>
    {
        public SaveTaskForModifyingDomainDnsRequest()
            : base("Domain", "2016-05-11", "SaveTaskForModifyingDomainDns")
        {
        }

		private string saleId;

		private string userClientIp;

		private string domainName;

		private string lang;

		private bool? aliyunDns;

		private List<string> dnsLists;

		private string accessKeyId;

		public string SaleId
		{
			get
			{
				return saleId;
			}
			set	
			{
				saleId = value;
				DictionaryUtil.Add(QueryParameters, "SaleId", value);
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

		public List<string> DnsLists
		{
			get
			{
				return dnsLists;
			}

			set
			{
				dnsLists = value;
				for (int i = 0; i < dnsLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"DnsList." + (i + 1) , dnsLists[i]);
				}
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

        public override SaveTaskForModifyingDomainDnsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return SaveTaskForModifyingDomainDnsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}