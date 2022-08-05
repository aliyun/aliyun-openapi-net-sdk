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
    public class QueryAdvancedDomainListResponseUnmarshaller
    {
        public static QueryAdvancedDomainListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryAdvancedDomainListResponse queryAdvancedDomainListResponse = new QueryAdvancedDomainListResponse();

			queryAdvancedDomainListResponse.HttpResponse = _ctx.HttpResponse;
			queryAdvancedDomainListResponse.PrePage = _ctx.BooleanValue("QueryAdvancedDomainList.PrePage");
			queryAdvancedDomainListResponse.CurrentPageNum = _ctx.IntegerValue("QueryAdvancedDomainList.CurrentPageNum");
			queryAdvancedDomainListResponse.RequestId = _ctx.StringValue("QueryAdvancedDomainList.RequestId");
			queryAdvancedDomainListResponse.PageSize = _ctx.IntegerValue("QueryAdvancedDomainList.PageSize");
			queryAdvancedDomainListResponse.TotalPageNum = _ctx.IntegerValue("QueryAdvancedDomainList.TotalPageNum");
			queryAdvancedDomainListResponse.TotalItemNum = _ctx.IntegerValue("QueryAdvancedDomainList.TotalItemNum");
			queryAdvancedDomainListResponse.NextPage = _ctx.BooleanValue("QueryAdvancedDomainList.NextPage");

			List<QueryAdvancedDomainListResponse.QueryAdvancedDomainList_Domain> queryAdvancedDomainListResponse_data = new List<QueryAdvancedDomainListResponse.QueryAdvancedDomainList_Domain>();
			for (int i = 0; i < _ctx.Length("QueryAdvancedDomainList.Data.Length"); i++) {
				QueryAdvancedDomainListResponse.QueryAdvancedDomainList_Domain domain = new QueryAdvancedDomainListResponse.QueryAdvancedDomainList_Domain();
				domain.DomainAuditStatus = _ctx.StringValue("QueryAdvancedDomainList.Data["+ i +"].DomainAuditStatus");
				domain.DomainGroupId = _ctx.StringValue("QueryAdvancedDomainList.Data["+ i +"].DomainGroupId");
				domain.Remark = _ctx.StringValue("QueryAdvancedDomainList.Data["+ i +"].Remark");
				domain.DomainGroupName = _ctx.StringValue("QueryAdvancedDomainList.Data["+ i +"].DomainGroupName");
				domain.ZhRegistrantOrganization = _ctx.StringValue("QueryAdvancedDomainList.Data["+ i +"].ZhRegistrantOrganization");
				domain.RegistrantOrganization = _ctx.StringValue("QueryAdvancedDomainList.Data["+ i +"].RegistrantOrganization");
				domain.RegistrationDate = _ctx.StringValue("QueryAdvancedDomainList.Data["+ i +"].RegistrationDate");
				domain.InstanceId = _ctx.StringValue("QueryAdvancedDomainList.Data["+ i +"].InstanceId");
				domain.DomainName = _ctx.StringValue("QueryAdvancedDomainList.Data["+ i +"].DomainName");
				domain.ExpirationDateStatus = _ctx.StringValue("QueryAdvancedDomainList.Data["+ i +"].ExpirationDateStatus");
				domain.ExpirationDate = _ctx.StringValue("QueryAdvancedDomainList.Data["+ i +"].ExpirationDate");
				domain.Email = _ctx.StringValue("QueryAdvancedDomainList.Data["+ i +"].Email");
				domain.RegistrantType = _ctx.StringValue("QueryAdvancedDomainList.Data["+ i +"].RegistrantType");
				domain.ExpirationDateLong = _ctx.LongValue("QueryAdvancedDomainList.Data["+ i +"].ExpirationDateLong");
				domain.ExpirationCurrDateDiff = _ctx.IntegerValue("QueryAdvancedDomainList.Data["+ i +"].ExpirationCurrDateDiff");
				domain.Premium = _ctx.BooleanValue("QueryAdvancedDomainList.Data["+ i +"].Premium");
				domain.RegistrationDateLong = _ctx.LongValue("QueryAdvancedDomainList.Data["+ i +"].RegistrationDateLong");
				domain.ProductId = _ctx.StringValue("QueryAdvancedDomainList.Data["+ i +"].ProductId");
				domain.DomainStatus = _ctx.StringValue("QueryAdvancedDomainList.Data["+ i +"].DomainStatus");
				domain.DomainType = _ctx.StringValue("QueryAdvancedDomainList.Data["+ i +"].DomainType");

				List<string> domain_dnsList = new List<string>();
				for (int j = 0; j < _ctx.Length("QueryAdvancedDomainList.Data["+ i +"].DnsList.Length"); j++) {
					domain_dnsList.Add(_ctx.StringValue("QueryAdvancedDomainList.Data["+ i +"].DnsList["+ j +"]"));
				}
				domain.DnsList = domain_dnsList;

				queryAdvancedDomainListResponse_data.Add(domain);
			}
			queryAdvancedDomainListResponse.Data = queryAdvancedDomainListResponse_data;
        
			return queryAdvancedDomainListResponse;
        }
    }
}
