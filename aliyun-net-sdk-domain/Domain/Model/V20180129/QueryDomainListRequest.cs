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
using Aliyun.Acs.Domain.Transform;
using Aliyun.Acs.Domain.Transform.V20180129;

namespace Aliyun.Acs.Domain.Model.V20180129
{
    public class QueryDomainListRequest : RpcAcsRequest<QueryDomainListResponse>
    {
        public QueryDomainListRequest()
            : base("Domain", "2018-01-29", "QueryDomainList", "domain", "openAPI")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string productDomainType;

		private string orderKeyType;

		private int? pageNum;

		private string orderByType;

		private int? pageSize;

		private string lang;

		private string queryType;

		private long? endExpirationDate;

		private string domainName;

		private long? startExpirationDate;

		private string domainGroupId;

		private long? endRegistrationDate;

		private string userClientIp;

		private long? startRegistrationDate;

		public string ProductDomainType
		{
			get
			{
				return productDomainType;
			}
			set	
			{
				productDomainType = value;
				DictionaryUtil.Add(QueryParameters, "ProductDomainType", value);
			}
		}

		public string OrderKeyType
		{
			get
			{
				return orderKeyType;
			}
			set	
			{
				orderKeyType = value;
				DictionaryUtil.Add(QueryParameters, "OrderKeyType", value);
			}
		}

		public int? PageNum
		{
			get
			{
				return pageNum;
			}
			set	
			{
				pageNum = value;
				DictionaryUtil.Add(QueryParameters, "PageNum", value.ToString());
			}
		}

		public string OrderByType
		{
			get
			{
				return orderByType;
			}
			set	
			{
				orderByType = value;
				DictionaryUtil.Add(QueryParameters, "OrderByType", value);
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

		public string QueryType
		{
			get
			{
				return queryType;
			}
			set	
			{
				queryType = value;
				DictionaryUtil.Add(QueryParameters, "QueryType", value);
			}
		}

		public long? EndExpirationDate
		{
			get
			{
				return endExpirationDate;
			}
			set	
			{
				endExpirationDate = value;
				DictionaryUtil.Add(QueryParameters, "EndExpirationDate", value.ToString());
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

		public long? StartExpirationDate
		{
			get
			{
				return startExpirationDate;
			}
			set	
			{
				startExpirationDate = value;
				DictionaryUtil.Add(QueryParameters, "StartExpirationDate", value.ToString());
			}
		}

		public string DomainGroupId
		{
			get
			{
				return domainGroupId;
			}
			set	
			{
				domainGroupId = value;
				DictionaryUtil.Add(QueryParameters, "DomainGroupId", value);
			}
		}

		public long? EndRegistrationDate
		{
			get
			{
				return endRegistrationDate;
			}
			set	
			{
				endRegistrationDate = value;
				DictionaryUtil.Add(QueryParameters, "EndRegistrationDate", value.ToString());
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

		public long? StartRegistrationDate
		{
			get
			{
				return startRegistrationDate;
			}
			set	
			{
				startRegistrationDate = value;
				DictionaryUtil.Add(QueryParameters, "StartRegistrationDate", value.ToString());
			}
		}

        public override QueryDomainListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryDomainListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
