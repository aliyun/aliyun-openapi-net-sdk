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
using Aliyun.Acs.Domain.Transform.V20160511;

namespace Aliyun.Acs.Domain.Model.V20160511
{
    public class QueryDomainListRequest : RpcAcsRequest<QueryDomainListResponse>
    {
        public QueryDomainListRequest()
            : base("Domain", "2016-05-11", "QueryDomainList")
        {
        }

		private string _userClientIp;

		private string _lang;

		private string _groupId;

		private string _startDate;

		private string _endDate;

		private string _domainName;

		private string _orderByType;

		private string _orderKeyType;

		private string _domainType;

		private int? _pageNum;

		private int? _pageSize;

		public string UserClientIp
		{
			get
			{
				return _userClientIp;
			}
			set	
			{
				_userClientIp = value;
				DictionaryUtil.Add(QueryParameters, "UserClientIp", value);
			}
		}

		public string Lang
		{
			get
			{
				return _lang;
			}
			set	
			{
				_lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string GroupId
		{
			get
			{
				return _groupId;
			}
			set	
			{
				_groupId = value;
				DictionaryUtil.Add(QueryParameters, "GroupId", value);
			}
		}

		public string StartDate
		{
			get
			{
				return _startDate;
			}
			set	
			{
				_startDate = value;
				DictionaryUtil.Add(QueryParameters, "StartDate", value);
			}
		}

		public string EndDate
		{
			get
			{
				return _endDate;
			}
			set	
			{
				_endDate = value;
				DictionaryUtil.Add(QueryParameters, "EndDate", value);
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

		public string OrderByType
		{
			get
			{
				return _orderByType;
			}
			set	
			{
				_orderByType = value;
				DictionaryUtil.Add(QueryParameters, "OrderByType", value);
			}
		}

		public string OrderKeyType
		{
			get
			{
				return _orderKeyType;
			}
			set	
			{
				_orderKeyType = value;
				DictionaryUtil.Add(QueryParameters, "OrderKeyType", value);
			}
		}

		public string DomainType
		{
			get
			{
				return _domainType;
			}
			set	
			{
				_domainType = value;
				DictionaryUtil.Add(QueryParameters, "DomainType", value);
			}
		}

		public int? PageNum
		{
			get
			{
				return _pageNum;
			}
			set	
			{
				_pageNum = value;
				DictionaryUtil.Add(QueryParameters, "PageNum", value.ToString());
			}
		}

		public int? PageSize
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

        public override QueryDomainListResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return QueryDomainListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}