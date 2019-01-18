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
using Aliyun.Acs.Cdn.Transform;
using Aliyun.Acs.Cdn.Transform.V20141111;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Model.V20141111
{
    public class DescribeUserDomainsRequest : RpcAcsRequest<DescribeUserDomainsResponse>
    {
        public DescribeUserDomainsRequest()
            : base("Cdn", "2014-11-11", "DescribeUserDomains")
        {
        }

		private string funcFilter;

		private string sources;

		private string domainName;

		private long? ownerId;

		private string funcId;

		private int? pageNumber;

		private string domainStatus;

		private string accessKeyId;

		private string domainSearchType;

		private bool? checkDomainShow;

		private string resourceGroupId;

		private string securityToken;

		private string cdnType;

		private int? pageSize;

		private string action;

		public string FuncFilter
		{
			get
			{
				return funcFilter;
			}
			set	
			{
				funcFilter = value;
				DictionaryUtil.Add(QueryParameters, "FuncFilter", value);
			}
		}

		public string Sources
		{
			get
			{
				return sources;
			}
			set	
			{
				sources = value;
				DictionaryUtil.Add(QueryParameters, "Sources", value);
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

		public long? OwnerId
		{
			get
			{
				return ownerId;
			}
			set	
			{
				ownerId = value;
				DictionaryUtil.Add(QueryParameters, "OwnerId", value.ToString());
			}
		}

		public string FuncId
		{
			get
			{
				return funcId;
			}
			set	
			{
				funcId = value;
				DictionaryUtil.Add(QueryParameters, "FuncId", value);
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
				DictionaryUtil.Add(QueryParameters, "PageNumber", value.ToString());
			}
		}

		public string DomainStatus
		{
			get
			{
				return domainStatus;
			}
			set	
			{
				domainStatus = value;
				DictionaryUtil.Add(QueryParameters, "DomainStatus", value);
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

		public string DomainSearchType
		{
			get
			{
				return domainSearchType;
			}
			set	
			{
				domainSearchType = value;
				DictionaryUtil.Add(QueryParameters, "DomainSearchType", value);
			}
		}

		public bool? CheckDomainShow
		{
			get
			{
				return checkDomainShow;
			}
			set	
			{
				checkDomainShow = value;
				DictionaryUtil.Add(QueryParameters, "CheckDomainShow", value.ToString());
			}
		}

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

		public string SecurityToken
		{
			get
			{
				return securityToken;
			}
			set	
			{
				securityToken = value;
				DictionaryUtil.Add(QueryParameters, "SecurityToken", value);
			}
		}

		public string CdnType
		{
			get
			{
				return cdnType;
			}
			set	
			{
				cdnType = value;
				DictionaryUtil.Add(QueryParameters, "CdnType", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public string Action
		{
			get
			{
				return action;
			}
			set	
			{
				action = value;
				DictionaryUtil.Add(QueryParameters, "Action", value);
			}
		}

        public override DescribeUserDomainsResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeUserDomainsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}