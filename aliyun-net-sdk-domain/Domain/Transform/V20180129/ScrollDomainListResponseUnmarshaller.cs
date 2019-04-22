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
    public class ScrollDomainListResponseUnmarshaller
    {
        public static ScrollDomainListResponse Unmarshall(UnmarshallerContext context)
        {
			ScrollDomainListResponse scrollDomainListResponse = new ScrollDomainListResponse();

			scrollDomainListResponse.HttpResponse = context.HttpResponse;
			scrollDomainListResponse.RequestId = context.StringValue("ScrollDomainList.RequestId");
			scrollDomainListResponse.TotalItemNum = context.IntegerValue("ScrollDomainList.TotalItemNum");
			scrollDomainListResponse.PageSize = context.IntegerValue("ScrollDomainList.PageSize");
			scrollDomainListResponse.ScrollId = context.StringValue("ScrollDomainList.ScrollId");

			List<ScrollDomainListResponse.ScrollDomainList_Domain> scrollDomainListResponse_data = new List<ScrollDomainListResponse.ScrollDomainList_Domain>();
			for (int i = 0; i < context.Length("ScrollDomainList.Data.Length"); i++) {
				ScrollDomainListResponse.ScrollDomainList_Domain domain = new ScrollDomainListResponse.ScrollDomainList_Domain();
				domain.DomainName = context.StringValue("ScrollDomainList.Data["+ i +"].DomainName");
				domain.InstanceId = context.StringValue("ScrollDomainList.Data["+ i +"].InstanceId");
				domain.ExpirationDate = context.StringValue("ScrollDomainList.Data["+ i +"].ExpirationDate");
				domain.RegistrationDate = context.StringValue("ScrollDomainList.Data["+ i +"].RegistrationDate");
				domain.DomainType = context.StringValue("ScrollDomainList.Data["+ i +"].DomainType");
				domain.DomainStatus = context.StringValue("ScrollDomainList.Data["+ i +"].DomainStatus");
				domain.ProductId = context.StringValue("ScrollDomainList.Data["+ i +"].ProductId");
				domain.ExpirationDateLong = context.LongValue("ScrollDomainList.Data["+ i +"].ExpirationDateLong");
				domain.RegistrationDateLong = context.LongValue("ScrollDomainList.Data["+ i +"].RegistrationDateLong");
				domain.Premium = context.BooleanValue("ScrollDomainList.Data["+ i +"].Premium");
				domain.DomainAuditStatus = context.StringValue("ScrollDomainList.Data["+ i +"].DomainAuditStatus");
				domain.ExpirationDateStatus = context.StringValue("ScrollDomainList.Data["+ i +"].ExpirationDateStatus");
				domain.RegistrantType = context.StringValue("ScrollDomainList.Data["+ i +"].RegistrantType");
				domain.DomainGroupId = context.StringValue("ScrollDomainList.Data["+ i +"].DomainGroupId");
				domain.Remark = context.StringValue("ScrollDomainList.Data["+ i +"].Remark");
				domain.DomainGroupName = context.StringValue("ScrollDomainList.Data["+ i +"].DomainGroupName");
				domain.ExpirationCurrDateDiff = context.IntegerValue("ScrollDomainList.Data["+ i +"].ExpirationCurrDateDiff");
				domain.Email = context.StringValue("ScrollDomainList.Data["+ i +"].Email");
				domain.ZhRegistrantOrganization = context.StringValue("ScrollDomainList.Data["+ i +"].ZhRegistrantOrganization");
				domain.RegistrantOrganization = context.StringValue("ScrollDomainList.Data["+ i +"].RegistrantOrganization");

				List<string> domain_dnsList = new List<string>();
				for (int j = 0; j < context.Length("ScrollDomainList.Data["+ i +"].DnsList.Length"); j++) {
					domain_dnsList.Add(context.StringValue("ScrollDomainList.Data["+ i +"].DnsList["+ j +"]"));
				}
				domain.DnsList = domain_dnsList;

				scrollDomainListResponse_data.Add(domain);
			}
			scrollDomainListResponse.Data = scrollDomainListResponse_data;
        
			return scrollDomainListResponse;
        }
    }
}
