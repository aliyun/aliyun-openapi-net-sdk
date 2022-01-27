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
using Aliyun.Acs.dcdn;
using Aliyun.Acs.dcdn.Transform;
using Aliyun.Acs.dcdn.Transform.V20180115;

namespace Aliyun.Acs.dcdn.Model.V20180115
{
    public class DescribeDcdnUserDomainsRequest : RpcAcsRequest<DescribeDcdnUserDomainsResponse>
    {
        public DescribeDcdnUserDomainsRequest()
            : base("dcdn", "2018-01-15", "DescribeDcdnUserDomains")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dcdn.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dcdn.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private int? pageNumber;

		private bool? checkDomainShow;

		private string resourceGroupId;

		private string securityToken;

		private string changeEndTime;

		private int? pageSize;

		private List<Tag> tags = new List<Tag>(){ };

		private string coverage;

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

		public List<Tag> Tags
		{
			get
			{
				return tags;
			}

			set
			{
				tags = value;
				for (int i = 0; i < tags.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Value", tags[i].Value);
					DictionaryUtil.Add(QueryParameters,"Tag." + (i + 1) + ".Key", tags[i].Key);
				}
			}
		}

		public string Coverage
		{
			get
			{
				return coverage;
			}
			set	
			{
				coverage = value;
				DictionaryUtil.Add(QueryParameters, "Coverage", value);
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

		public class Tag
		{

			private string value_;

			private string key;

			public string Value
			{
				get
				{
					return value_;
				}
				set	
				{
					value_ = value;
				}
			}

			public string Key
			{
				get
				{
					return key;
				}
				set	
				{
					key = value;
				}
			}
		}

        public override DescribeDcdnUserDomainsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeDcdnUserDomainsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
