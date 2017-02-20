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
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Cdn.Transform.V20141111;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
    public class DescribeUserDomainsRequest : RpcAcsRequest<DescribeUserDomainsResponse>
    {
        public DescribeUserDomainsRequest()
            : base("Cdn", "2014-11-11", "DescribeUserDomains")
        {
        }

		private long? _ownerId;

		private string _securityToken;

		private long? _pageSize;

		private long? _pageNumber;

		private string _domainName;

		private string _domainStatus;

		private string _domainSearchType;

		private string _sources;

		private string _cdnType;

		public long? OwnerId
		{
			get
			{
				return _ownerId;
			}
			set	
			{
				_ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string SecurityToken
		{
			get
			{
				return _securityToken;
			}
			set	
			{
				_securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public long? PageSize
		{
			get
			{
				return _pageSize;
			}
			set	
			{
				_pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public long? PageNumber
		{
			get
			{
				return _pageNumber;
			}
			set	
			{
				_pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string DomainName
		{
			get
			{
				return _domainName;
			}
			set	
			{
				_domainName = value;
				DictionaryUtil.Add(QueryParameters, "DomainName", value);
			}
		}

		public string DomainStatus
		{
			get
			{
				return _domainStatus;
			}
			set	
			{
				_domainStatus = value;
				DictionaryUtil.Add(QueryParameters, "DomainStatus", value);
			}
		}

		public string DomainSearchType
		{
			get
			{
				return _domainSearchType;
			}
			set	
			{
				_domainSearchType = value;
				DictionaryUtil.Add(QueryParameters, "DomainSearchType", value);
			}
		}

		public string Sources
		{
			get
			{
				return _sources;
			}
			set	
			{
				_sources = value;
				DictionaryUtil.Add(QueryParameters, "Sources", value);
			}
		}

		public string CdnType
		{
			get
			{
				return _cdnType;
			}
			set	
			{
				_cdnType = value;
				DictionaryUtil.Add(QueryParameters, "CdnType", value);
			}
		}

        public override DescribeUserDomainsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeUserDomainsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}