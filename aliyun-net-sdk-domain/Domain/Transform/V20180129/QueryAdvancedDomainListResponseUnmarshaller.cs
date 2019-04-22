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
        public static QueryAdvancedDomainListResponse Unmarshall(UnmarshallerContext context)
        {
			QueryAdvancedDomainListResponse queryAdvancedDomainListResponse = new QueryAdvancedDomainListResponse();

			queryAdvancedDomainListResponse.HttpResponse = context.HttpResponse;
			queryAdvancedDomainListResponse.RequestId = context.StringValue("QueryAdvancedDomainList.RequestId");
			queryAdvancedDomainListResponse.TotalItemNum = context.IntegerValue("QueryAdvancedDomainList.TotalItemNum");
			queryAdvancedDomainListResponse.CurrentPageNum = context.IntegerValue("QueryAdvancedDomainList.CurrentPageNum");
			queryAdvancedDomainListResponse.TotalPageNum = context.IntegerValue("QueryAdvancedDomainList.TotalPageNum");
			queryAdvancedDomainListResponse.PageSize = context.IntegerValue("QueryAdvancedDomainList.PageSize");
			queryAdvancedDomainListResponse.PrePage = context.BooleanValue("QueryAdvancedDomainList.PrePage");
			queryAdvancedDomainListResponse.NextPage = context.BooleanValue("QueryAdvancedDomainList.NextPage");

			List<QueryAdvancedDomainListResponse.QueryAdvancedDomainList_Domain> queryAdvancedDomainListResponse_data = new List<QueryAdvancedDomainListResponse.QueryAdvancedDomainList_Domain>();
			for (int i = 0; i < context.Length("QueryAdvancedDomainList.Data.Length"); i++) {
				QueryAdvancedDomainListResponse.QueryAdvancedDomainList_Domain domain = new QueryAdvancedDomainListResponse.QueryAdvancedDomainList_Domain();
				domain.DomainName = context.StringValue("QueryAdvancedDomainList.Data["+ i +"].DomainName");
				domain.InstanceId = context.StringValue("QueryAdvancedDomainList.Data["+ i +"].InstanceId");
				domain.ExpirationDate = context.StringValue("QueryAdvancedDomainList.Data["+ i +"].ExpirationDate");
				domain.RegistrationDate = context.StringValue("QueryAdvancedDomainList.Data["+ i +"].RegistrationDate");
				domain.DomainType = context.StringValue("QueryAdvancedDomainList.Data["+ i +"].DomainType");
				domain.DomainStatus = context.StringValue("QueryAdvancedDomainList.Data["+ i +"].DomainStatus");
				domain.ProductId = context.StringValue("QueryAdvancedDomainList.Data["+ i +"].ProductId");
				domain.ExpirationDateLong = context.LongValue("QueryAdvancedDomainList.Data["+ i +"].ExpirationDateLong");
				domain.RegistrationDateLong = context.LongValue("QueryAdvancedDomainList.Data["+ i +"].RegistrationDateLong");
				domain.Premium = context.BooleanValue("QueryAdvancedDomainList.Data["+ i +"].Premium");
				domain.DomainAuditStatus = context.StringValue("QueryAdvancedDomainList.Data["+ i +"].DomainAuditStatus");
				domain.ExpirationDateStatus = context.StringValue("QueryAdvancedDomainList.Data["+ i +"].ExpirationDateStatus");
				domain.RegistrantType = context.StringValue("QueryAdvancedDomainList.Data["+ i +"].RegistrantType");
				domain.DomainGroupId = context.StringValue("QueryAdvancedDomainList.Data["+ i +"].DomainGroupId");
				domain.Remark = context.StringValue("QueryAdvancedDomainList.Data["+ i +"].Remark");
				domain.DomainGroupName = context.StringValue("QueryAdvancedDomainList.Data["+ i +"].DomainGroupName");
				domain.ExpirationCurrDateDiff = context.IntegerValue("QueryAdvancedDomainList.Data["+ i +"].ExpirationCurrDateDiff");
				domain.Email = context.StringValue("QueryAdvancedDomainList.Data["+ i +"].Email");
				domain.ZhRegistrantOrganization = context.StringValue("QueryAdvancedDomainList.Data["+ i +"].ZhRegistrantOrganization");
				domain.RegistrantOrganization = context.StringValue("QueryAdvancedDomainList.Data["+ i +"].RegistrantOrganization");

				List<string> domain_dnsList = new List<string>();
				for (int j = 0; j < context.Length("QueryAdvancedDomainList.Data["+ i +"].DnsList.Length"); j++) {
					domain_dnsList.Add(context.StringValue("QueryAdvancedDomainList.Data["+ i +"].DnsList["+ j +"]"));
				}
				domain.DnsList = domain_dnsList;

				queryAdvancedDomainListResponse_data.Add(domain);
			}
			queryAdvancedDomainListResponse.Data = queryAdvancedDomainListResponse_data;
        
			return queryAdvancedDomainListResponse;
        }
    }
}
