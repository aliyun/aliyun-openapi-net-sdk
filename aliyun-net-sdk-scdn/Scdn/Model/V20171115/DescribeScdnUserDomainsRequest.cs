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
using Aliyun.Acs.scdn;
using Aliyun.Acs.scdn.Transform;
using Aliyun.Acs.scdn.Transform.V20171115;

namespace Aliyun.Acs.scdn.Model.V20171115
{
    public class DescribeScdnUserDomainsRequest : RpcAcsRequest<DescribeScdnUserDomainsResponse>
    {
        public DescribeScdnUserDomainsRequest()
            : base("scdn", "2017-11-15", "DescribeScdnUserDomains")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.scdn.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.scdn.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? pageNumber;

		private bool? checkDomainShow;

		private string resourceGroupId;

		private string securityToken;

		private string changeEndTime;

		private int? pageSize;

		private string domainName;

		private long? ownerId;

		private string domainStatus;

		private string domainSearchType;

		private string changeStartTime;

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

		public string ChangeEndTime
		{
			get
			{
				return changeEndTime;
			}
			set	
			{
				changeEndTime = value;
				DictionaryUtil.Add(QueryParameters, "ChangeEndTime", value);
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

		public string ChangeStartTime
		{
			get
			{
				return changeStartTime;
			}
			set	
			{
				changeStartTime = value;
				DictionaryUtil.Add(QueryParameters, "ChangeStartTime", value);
			}
		}

        public override DescribeScdnUserDomainsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeScdnUserDomainsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
