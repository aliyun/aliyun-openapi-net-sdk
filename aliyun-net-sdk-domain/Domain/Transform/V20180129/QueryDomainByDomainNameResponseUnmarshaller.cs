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
    public class QueryDomainByDomainNameResponseUnmarshaller
    {
        public static QueryDomainByDomainNameResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDomainByDomainNameResponse queryDomainByDomainNameResponse = new QueryDomainByDomainNameResponse();

			queryDomainByDomainNameResponse.HttpResponse = _ctx.HttpResponse;
			queryDomainByDomainNameResponse.UserId = _ctx.StringValue("QueryDomainByDomainName.UserId");
			queryDomainByDomainNameResponse.DomainName = _ctx.StringValue("QueryDomainByDomainName.DomainName");
			queryDomainByDomainNameResponse.InstanceId = _ctx.StringValue("QueryDomainByDomainName.InstanceId");
			queryDomainByDomainNameResponse.RegistrationDate = _ctx.StringValue("QueryDomainByDomainName.RegistrationDate");
			queryDomainByDomainNameResponse.ExpirationDate = _ctx.StringValue("QueryDomainByDomainName.ExpirationDate");
			queryDomainByDomainNameResponse.RegistrantOrganization = _ctx.StringValue("QueryDomainByDomainName.RegistrantOrganization");
			queryDomainByDomainNameResponse.RegistrantName = _ctx.StringValue("QueryDomainByDomainName.RegistrantName");
			queryDomainByDomainNameResponse.Email = _ctx.StringValue("QueryDomainByDomainName.Email");
			queryDomainByDomainNameResponse.UpdateProhibitionLock = _ctx.StringValue("QueryDomainByDomainName.UpdateProhibitionLock");
			queryDomainByDomainNameResponse.TransferProhibitionLock = _ctx.StringValue("QueryDomainByDomainName.TransferProhibitionLock");
			queryDomainByDomainNameResponse.DomainNameProxyService = _ctx.BooleanValue("QueryDomainByDomainName.DomainNameProxyService");
			queryDomainByDomainNameResponse.Premium = _ctx.BooleanValue("QueryDomainByDomainName.Premium");
			queryDomainByDomainNameResponse.EmailVerificationStatus = _ctx.IntegerValue("QueryDomainByDomainName.EmailVerificationStatus");
			queryDomainByDomainNameResponse.EmailVerificationClientHold = _ctx.BooleanValue("QueryDomainByDomainName.EmailVerificationClientHold");
			queryDomainByDomainNameResponse.RealNameStatus = _ctx.StringValue("QueryDomainByDomainName.RealNameStatus");
			queryDomainByDomainNameResponse.RegistrantUpdatingStatus = _ctx.StringValue("QueryDomainByDomainName.RegistrantUpdatingStatus");
			queryDomainByDomainNameResponse.TransferOutStatus = _ctx.StringValue("QueryDomainByDomainName.TransferOutStatus");
			queryDomainByDomainNameResponse.RegistrantType = _ctx.StringValue("QueryDomainByDomainName.RegistrantType");
			queryDomainByDomainNameResponse.DomainNameVerificationStatus = _ctx.StringValue("QueryDomainByDomainName.DomainNameVerificationStatus");
			queryDomainByDomainNameResponse.RequestId = _ctx.StringValue("QueryDomainByDomainName.RequestId");
			queryDomainByDomainNameResponse.ZhRegistrantOrganization = _ctx.StringValue("QueryDomainByDomainName.ZhRegistrantOrganization");
			queryDomainByDomainNameResponse.ZhRegistrantName = _ctx.StringValue("QueryDomainByDomainName.ZhRegistrantName");
			queryDomainByDomainNameResponse.RegistrationDateLong = _ctx.LongValue("QueryDomainByDomainName.RegistrationDateLong");
			queryDomainByDomainNameResponse.ExpirationDateLong = _ctx.LongValue("QueryDomainByDomainName.ExpirationDateLong");

			List<string> queryDomainByDomainNameResponse_dnsList = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryDomainByDomainName.DnsList.Length"); i++) {
				queryDomainByDomainNameResponse_dnsList.Add(_ctx.StringValue("QueryDomainByDomainName.DnsList["+ i +"]"));
			}
			queryDomainByDomainNameResponse.DnsList = queryDomainByDomainNameResponse_dnsList;
        
			return queryDomainByDomainNameResponse;
        }
    }
}
