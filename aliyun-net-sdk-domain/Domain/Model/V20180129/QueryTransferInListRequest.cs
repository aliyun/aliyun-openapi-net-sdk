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
    public class QueryTransferInListRequest : RpcAcsRequest<QueryTransferInListResponse>
    {
        public QueryTransferInListRequest()
            : base("Domain", "2018-01-29", "QueryTransferInList")
        {
        }

		private long? submissionStartDate;

		private string userClientIp;

		private long? submissionEndDate;

		private string domainName;

		private string simpleTransferInStatus;

		private int? pageSize;

		private string lang;

		private int? pageNum;

		public long? SubmissionStartDate
		{
			get
			{
				return submissionStartDate;
			}
			set	
			{
				submissionStartDate = value;
				DictionaryUtil.Add(QueryParameters, "SubmissionStartDate", value.ToString());
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

		public long? SubmissionEndDate
		{
			get
			{
				return submissionEndDate;
			}
			set	
			{
				submissionEndDate = value;
				DictionaryUtil.Add(QueryParameters, "SubmissionEndDate", value.ToString());
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

		public string SimpleTransferInStatus
		{
			get
			{
				return simpleTransferInStatus;
			}
			set	
			{
				simpleTransferInStatus = value;
				DictionaryUtil.Add(QueryParameters, "SimpleTransferInStatus", value);
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

        public override QueryTransferInListResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return QueryTransferInListResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
