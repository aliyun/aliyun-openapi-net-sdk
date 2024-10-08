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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Domain.Model.V20180129;

namespace Aliyun.Acs.Domain.Transform.V20180129
{
    public class QueryDomainListResponseUnmarshaller
    {
        public static QueryDomainListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDomainListResponse queryDomainListResponse = new QueryDomainListResponse();

			queryDomainListResponse.HttpResponse = _ctx.HttpResponse;
			queryDomainListResponse.PrePage = _ctx.BooleanValue("QueryDomainList.PrePage");
			queryDomainListResponse.CurrentPageNum = _ctx.IntegerValue("QueryDomainList.CurrentPageNum");
			queryDomainListResponse.RequestId = _ctx.StringValue("QueryDomainList.RequestId");
			queryDomainListResponse.PageSize = _ctx.IntegerValue("QueryDomainList.PageSize");
			queryDomainListResponse.TotalPageNum = _ctx.IntegerValue("QueryDomainList.TotalPageNum");
			queryDomainListResponse.TotalItemNum = _ctx.IntegerValue("QueryDomainList.TotalItemNum");
			queryDomainListResponse.NextPage = _ctx.BooleanValue("QueryDomainList.NextPage");

			List<QueryDomainListResponse.QueryDomainList_Domain> queryDomainListResponse_data = new List<QueryDomainListResponse.QueryDomainList_Domain>();
			for (int i = 0; i < _ctx.Length("QueryDomainList.Data.Length"); i++) {
				QueryDomainListResponse.QueryDomainList_Domain domain = new QueryDomainListResponse.QueryDomainList_Domain();
				domain.DomainAuditStatus = _ctx.StringValue("QueryDomainList.Data["+ i +"].DomainAuditStatus");
				domain.DomainGroupId = _ctx.StringValue("QueryDomainList.Data["+ i +"].DomainGroupId");
				domain.Remark = _ctx.StringValue("QueryDomainList.Data["+ i +"].Remark");
				domain.DomainGroupName = _ctx.StringValue("QueryDomainList.Data["+ i +"].DomainGroupName");
				domain.RegistrationDate = _ctx.StringValue("QueryDomainList.Data["+ i +"].RegistrationDate");
				domain.InstanceId = _ctx.StringValue("QueryDomainList.Data["+ i +"].InstanceId");
				domain.DomainName = _ctx.StringValue("QueryDomainList.Data["+ i +"].DomainName");
				domain.ExpirationDateStatus = _ctx.StringValue("QueryDomainList.Data["+ i +"].ExpirationDateStatus");
				domain.ExpirationDate = _ctx.StringValue("QueryDomainList.Data["+ i +"].ExpirationDate");
				domain.RegistrantType = _ctx.StringValue("QueryDomainList.Data["+ i +"].RegistrantType");
				domain.ExpirationDateLong = _ctx.LongValue("QueryDomainList.Data["+ i +"].ExpirationDateLong");
				domain.ExpirationCurrDateDiff = _ctx.IntegerValue("QueryDomainList.Data["+ i +"].ExpirationCurrDateDiff");
				domain.Premium = _ctx.BooleanValue("QueryDomainList.Data["+ i +"].Premium");
				domain.RegistrationDateLong = _ctx.LongValue("QueryDomainList.Data["+ i +"].RegistrationDateLong");
				domain.ProductId = _ctx.StringValue("QueryDomainList.Data["+ i +"].ProductId");
				domain.DomainStatus = _ctx.StringValue("QueryDomainList.Data["+ i +"].DomainStatus");
				domain.DomainType = _ctx.StringValue("QueryDomainList.Data["+ i +"].DomainType");
				domain.ResourceGroupId = _ctx.StringValue("QueryDomainList.Data["+ i +"].ResourceGroupId");
				domain.Ccompany = _ctx.StringValue("QueryDomainList.Data["+ i +"].Ccompany");
				domain.ChgholderStatus = _ctx.StringValue("QueryDomainList.Data["+ i +"].ChgholderStatus");

				List<QueryDomainListResponse.QueryDomainList_Domain.QueryDomainList_TagItem> domain_tag = new List<QueryDomainListResponse.QueryDomainList_Domain.QueryDomainList_TagItem>();
				for (int j = 0; j < _ctx.Length("QueryDomainList.Data["+ i +"].Tag.Length"); j++) {
					QueryDomainListResponse.QueryDomainList_Domain.QueryDomainList_TagItem tagItem = new QueryDomainListResponse.QueryDomainList_Domain.QueryDomainList_TagItem();
					tagItem.Key = _ctx.StringValue("QueryDomainList.Data["+ i +"].Tag["+ j +"].Key");
					tagItem._Value = _ctx.StringValue("QueryDomainList.Data["+ i +"].Tag["+ j +"].Value");

					domain_tag.Add(tagItem);
				}
				domain.Tag = domain_tag;

				queryDomainListResponse_data.Add(domain);
			}
			queryDomainListResponse.Data = queryDomainListResponse_data;
        
			return queryDomainListResponse;
        }
    }
}
