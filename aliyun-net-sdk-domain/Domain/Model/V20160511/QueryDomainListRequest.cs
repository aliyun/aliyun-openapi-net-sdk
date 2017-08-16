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
    public class QueryDomainListRequest : RpcAcsRequest<QueryDomainListResponse>
    {
        public QueryDomainListRequest()
            : base("Domain", "2016-05-11", "QueryDomainList")
        {
        }

		private string productDomainType;

		private long? regStartDate;

		private string orderKeyType;

		private string groupId;

		private long? deadEndDate;

		private string domainName;

		private string startDate;

		private int? pageNum;

		private string accessKeyId;

		private string orderByType;

		private long? regEndDate;

		private string endDate;

		private string domainType;

		private long? deadStartDate;

		private string userClientIp;

		private int? pageSize;

		private string lang;

		private string queryType;

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

		public long? RegStartDate
		{
			get
			{
				return regStartDate;
			}
			set	
			{
				regStartDate = value;
				DictionaryUtil.Add(QueryParameters, "RegStartDate", value.ToString());
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

		public string GroupId
		{
			get
			{
				return groupId;
			}
			set	
			{
				groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		public long? DeadEndDate
		{
			get
			{
				return deadEndDate;
			}
			set	
			{
				deadEndDate = value;
				DictionaryUtil.Add(QueryParameters, "DeadEndDate", value.ToString());
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

		public string StartDate
		{
			get
			{
				return startDate;
			}
			set	
			{
				startDate = value;
				DictionaryUtil.Add(QueryParameters, "StartDate", value);
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

		public long? RegEndDate
		{
			get
			{
				return regEndDate;
			}
			set	
			{
				regEndDate = value;
				DictionaryUtil.Add(QueryParameters, "RegEndDate", value.ToString());
			}
		}

		public string EndDate
		{
			get
			{
				return endDate;
			}
			set	
			{
				endDate = value;
				DictionaryUtil.Add(QueryParameters, "EndDate", value);
			}
		}

		public string DomainType
		{
			get
			{
				return domainType;
			}
			set	
			{
				domainType = value;
				DictionaryUtil.Add(QueryParameters, "DomainType", value);
			}
		}

		public long? DeadStartDate
		{
			get
			{
				return deadStartDate;
			}
			set	
			{
				deadStartDate = value;
				DictionaryUtil.Add(QueryParameters, "DeadStartDate", value.ToString());
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

        public override QueryDomainListResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return QueryDomainListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}