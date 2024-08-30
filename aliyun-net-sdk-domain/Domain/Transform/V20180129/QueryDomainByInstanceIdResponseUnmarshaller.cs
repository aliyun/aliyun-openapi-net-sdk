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
    public class QueryDomainByInstanceIdResponseUnmarshaller
    {
        public static QueryDomainByInstanceIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDomainByInstanceIdResponse queryDomainByInstanceIdResponse = new QueryDomainByInstanceIdResponse();

			queryDomainByInstanceIdResponse.HttpResponse = _ctx.HttpResponse;
			queryDomainByInstanceIdResponse.Email = _ctx.StringValue("QueryDomainByInstanceId.Email");
			queryDomainByInstanceIdResponse.RegistrationDate = _ctx.StringValue("QueryDomainByInstanceId.RegistrationDate");
			queryDomainByInstanceIdResponse.RegistrationDateLong = _ctx.LongValue("QueryDomainByInstanceId.RegistrationDateLong");
			queryDomainByInstanceIdResponse.RealNameStatus = _ctx.StringValue("QueryDomainByInstanceId.RealNameStatus");
			queryDomainByInstanceIdResponse.Premium = _ctx.BooleanValue("QueryDomainByInstanceId.Premium");
			queryDomainByInstanceIdResponse.DomainNameVerificationStatus = _ctx.StringValue("QueryDomainByInstanceId.DomainNameVerificationStatus");
			queryDomainByInstanceIdResponse.ExpirationDateLong = _ctx.LongValue("QueryDomainByInstanceId.ExpirationDateLong");
			queryDomainByInstanceIdResponse.TransferOutStatus = _ctx.StringValue("QueryDomainByInstanceId.TransferOutStatus");
			queryDomainByInstanceIdResponse.ZhRegistrantOrganization = _ctx.StringValue("QueryDomainByInstanceId.ZhRegistrantOrganization");
			queryDomainByInstanceIdResponse.EmailVerificationClientHold = _ctx.BooleanValue("QueryDomainByInstanceId.EmailVerificationClientHold");
			queryDomainByInstanceIdResponse.EmailVerificationStatus = _ctx.IntegerValue("QueryDomainByInstanceId.EmailVerificationStatus");
			queryDomainByInstanceIdResponse.RegistrantOrganization = _ctx.StringValue("QueryDomainByInstanceId.RegistrantOrganization");
			queryDomainByInstanceIdResponse.TransferProhibitionLock = _ctx.StringValue("QueryDomainByInstanceId.TransferProhibitionLock");
			queryDomainByInstanceIdResponse.DomainNameProxyService = _ctx.BooleanValue("QueryDomainByInstanceId.DomainNameProxyService");
			queryDomainByInstanceIdResponse.RegistrantType = _ctx.StringValue("QueryDomainByInstanceId.RegistrantType");
			queryDomainByInstanceIdResponse.RegistrantUpdatingStatus = _ctx.StringValue("QueryDomainByInstanceId.RegistrantUpdatingStatus");
			queryDomainByInstanceIdResponse.RequestId = _ctx.StringValue("QueryDomainByInstanceId.RequestId");
			queryDomainByInstanceIdResponse.DomainName = _ctx.StringValue("QueryDomainByInstanceId.DomainName");
			queryDomainByInstanceIdResponse.InstanceId = _ctx.StringValue("QueryDomainByInstanceId.InstanceId");
			queryDomainByInstanceIdResponse.ZhRegistrantName = _ctx.StringValue("QueryDomainByInstanceId.ZhRegistrantName");
			queryDomainByInstanceIdResponse.ExpirationDate = _ctx.StringValue("QueryDomainByInstanceId.ExpirationDate");
			queryDomainByInstanceIdResponse.RegistrantName = _ctx.StringValue("QueryDomainByInstanceId.RegistrantName");
			queryDomainByInstanceIdResponse.UserId = _ctx.StringValue("QueryDomainByInstanceId.UserId");
			queryDomainByInstanceIdResponse.UpdateProhibitionLock = _ctx.StringValue("QueryDomainByInstanceId.UpdateProhibitionLock");
			queryDomainByInstanceIdResponse.DomainGroupId = _ctx.LongValue("QueryDomainByInstanceId.DomainGroupId");
			queryDomainByInstanceIdResponse.Remark = _ctx.StringValue("QueryDomainByInstanceId.Remark");
			queryDomainByInstanceIdResponse.DomainGroupName = _ctx.StringValue("QueryDomainByInstanceId.DomainGroupName");
			queryDomainByInstanceIdResponse.ExpirationDateStatus = _ctx.StringValue("QueryDomainByInstanceId.ExpirationDateStatus");
			queryDomainByInstanceIdResponse.ExpirationCurrDateDiff = _ctx.IntegerValue("QueryDomainByInstanceId.ExpirationCurrDateDiff");
			queryDomainByInstanceIdResponse.DomainType = _ctx.StringValue("QueryDomainByInstanceId.DomainType");
			queryDomainByInstanceIdResponse.DomainStatus = _ctx.StringValue("QueryDomainByInstanceId.DomainStatus");
			queryDomainByInstanceIdResponse.ResourceGroupId = _ctx.StringValue("QueryDomainByInstanceId.ResourceGroupId");

			List<string> queryDomainByInstanceIdResponse_dnsList = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryDomainByInstanceId.DnsList.Length"); i++) {
				queryDomainByInstanceIdResponse_dnsList.Add(_ctx.StringValue("QueryDomainByInstanceId.DnsList["+ i +"]"));
			}
			queryDomainByInstanceIdResponse.DnsList = queryDomainByInstanceIdResponse_dnsList;

			List<QueryDomainByInstanceIdResponse.QueryDomainByInstanceId_TagItem> queryDomainByInstanceIdResponse_tag = new List<QueryDomainByInstanceIdResponse.QueryDomainByInstanceId_TagItem>();
			for (int i = 0; i < _ctx.Length("QueryDomainByInstanceId.Tag.Length"); i++) {
				QueryDomainByInstanceIdResponse.QueryDomainByInstanceId_TagItem tagItem = new QueryDomainByInstanceIdResponse.QueryDomainByInstanceId_TagItem();
				tagItem.Key = _ctx.StringValue("QueryDomainByInstanceId.Tag["+ i +"].Key");
				tagItem._Value = _ctx.StringValue("QueryDomainByInstanceId.Tag["+ i +"].Value");

				queryDomainByInstanceIdResponse_tag.Add(tagItem);
			}
			queryDomainByInstanceIdResponse.Tag = queryDomainByInstanceIdResponse_tag;
        
			return queryDomainByInstanceIdResponse;
        }
    }
}
