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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Domain.Model.V20160511;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Domain.Transform.V20160511
{
    public class QueryDomainListResponseUnmarshaller
    {
        public static QueryDomainListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDomainListResponse queryDomainListResponse = new QueryDomainListResponse();

			queryDomainListResponse.HttpResponse = context.HttpResponse;
			queryDomainListResponse.RequestId = context.StringValue("QueryDomainList.RequestId");
			queryDomainListResponse.TotalItemNum = context.IntegerValue("QueryDomainList.TotalItemNum");
			queryDomainListResponse.CurrentPageNum = context.IntegerValue("QueryDomainList.CurrentPageNum");
			queryDomainListResponse.TotalPageNum = context.IntegerValue("QueryDomainList.TotalPageNum");
			queryDomainListResponse.PageSize = context.IntegerValue("QueryDomainList.PageSize");
			queryDomainListResponse.PrePage = context.BooleanValue("QueryDomainList.PrePage");
			queryDomainListResponse.NextPage = context.BooleanValue("QueryDomainList.NextPage");

			List<QueryDomainListResponse.QueryDomainList_Domain> queryDomainListResponse_data = new List<QueryDomainListResponse.QueryDomainList_Domain>();
			for (int i = 0; i < context.Length("QueryDomainList.Data.Length"); i++) {
				QueryDomainListResponse.QueryDomainList_Domain domain = new QueryDomainListResponse.QueryDomainList_Domain();
				domain.DomainName = context.StringValue("QueryDomainList.Data["+ i +"].DomainName");
				domain.SaleId = context.StringValue("QueryDomainList.Data["+ i +"].SaleId");
				domain.DeadDate = context.StringValue("QueryDomainList.Data["+ i +"].DeadDate");
				domain.RegDate = context.StringValue("QueryDomainList.Data["+ i +"].RegDate");
				domain.DomainAuditStatus = context.StringValue("QueryDomainList.Data["+ i +"].DomainAuditStatus");
				domain.DomainRegType = context.StringValue("QueryDomainList.Data["+ i +"].DomainRegType");
				domain.GroupId = context.StringValue("QueryDomainList.Data["+ i +"].GroupId");
				domain.DomainType = context.StringValue("QueryDomainList.Data["+ i +"].DomainType");
				domain.DomainStatus = context.StringValue("QueryDomainList.Data["+ i +"].DomainStatus");
				domain.DeadDateStatus = context.StringValue("QueryDomainList.Data["+ i +"].DeadDateStatus");
				domain.ProductId = context.StringValue("QueryDomainList.Data["+ i +"].ProductId");
				domain.DeadDateLong = context.LongValue("QueryDomainList.Data["+ i +"].DeadDateLong");
				domain.RegDateLong = context.LongValue("QueryDomainList.Data["+ i +"].RegDateLong");
				domain.Remark = context.StringValue("QueryDomainList.Data["+ i +"].Remark");
				domain.Premium = context.BooleanValue("QueryDomainList.Data["+ i +"].Premium");

				queryDomainListResponse_data.Add(domain);
			}
			queryDomainListResponse.Data = queryDomainListResponse_data;
        
			return queryDomainListResponse;
        }
    }
}