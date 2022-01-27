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
using Aliyun.Acs.Httpdns;
using Aliyun.Acs.Httpdns.Transform;
using Aliyun.Acs.Httpdns.Transform.V20160201;

namespace Aliyun.Acs.Httpdns.Model.V20160201
{
    public class DescribeDomainsRequest : RpcAcsRequest<DescribeDomainsResponse>
    {
        public DescribeDomainsRequest()
            : base("Httpdns", "2016-02-01", "DescribeDomains")
        {
			Method = MethodType.POST;
        }

		private long? pageNumber;

		private string accountId;

		private long? pageSize;

		public long? PageNumber
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

		public string AccountId
		{
			get
			{
				return accountId;
			}
			set	
			{
				accountId = value;
				DictionaryUtil.Add(QueryParameters, "AccountId", value);
			}
		}

		public long? PageSize
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

        public override DescribeDomainsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeDomainsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
