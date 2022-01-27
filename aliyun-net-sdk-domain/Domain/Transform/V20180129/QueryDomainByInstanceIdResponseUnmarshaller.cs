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
			queryDomainByInstanceIdResponse.UserId = _ctx.StringValue("QueryDomainByInstanceId.UserId");
			queryDomainByInstanceIdResponse.DomainName = _ctx.StringValue("QueryDomainByInstanceId.DomainName");
			queryDomainByInstanceIdResponse.InstanceId = _ctx.StringValue("QueryDomainByInstanceId.InstanceId");
			queryDomainByInstanceIdResponse.RegistrationDate = _ctx.StringValue("QueryDomainByInstanceId.RegistrationDate");
			queryDomainByInstanceIdResponse.ExpirationDate = _ctx.StringValue("QueryDomainByInstanceId.ExpirationDate");
			queryDomainByInstanceIdResponse.RegistrantOrganization = _ctx.StringValue("QueryDomainByInstanceId.RegistrantOrganization");
			queryDomainByInstanceIdResponse.RegistrantName = _ctx.StringValue("QueryDomainByInstanceId.RegistrantName");
			queryDomainByInstanceIdResponse.Email = _ctx.StringValue("QueryDomainByInstanceId.Email");
			queryDomainByInstanceIdResponse.UpdateProhibitionLock = _ctx.StringValue("QueryDomainByInstanceId.UpdateProhibitionLock");
			queryDomainByInstanceIdResponse.TransferProhibitionLock = _ctx.StringValue("QueryDomainByInstanceId.TransferProhibitionLock");
			queryDomainByInstanceIdResponse.DomainNameProxyService = _ctx.BooleanValue("QueryDomainByInstanceId.DomainNameProxyService");
			queryDomainByInstanceIdResponse.Premium = _ctx.BooleanValue("QueryDomainByInstanceId.Premium");
			queryDomainByInstanceIdResponse.EmailVerificationStatus = _ctx.IntegerValue("QueryDomainByInstanceId.EmailVerificationStatus");
			queryDomainByInstanceIdResponse.EmailVerificationClientHold = _ctx.BooleanValue("QueryDomainByInstanceId.EmailVerificationClientHold");
			queryDomainByInstanceIdResponse.RealNameStatus = _ctx.StringValue("QueryDomainByInstanceId.RealNameStatus");
			queryDomainByInstanceIdResponse.RegistrantUpdatingStatus = _ctx.StringValue("QueryDomainByInstanceId.RegistrantUpdatingStatus");
			queryDomainByInstanceIdResponse.TransferOutStatus = _ctx.StringValue("QueryDomainByInstanceId.TransferOutStatus");
			queryDomainByInstanceIdResponse.RegistrantType = _ctx.StringValue("QueryDomainByInstanceId.RegistrantType");
			queryDomainByInstanceIdResponse.DomainNameVerificationStatus = _ctx.StringValue("QueryDomainByInstanceId.DomainNameVerificationStatus");
			queryDomainByInstanceIdResponse.RequestId = _ctx.StringValue("QueryDomainByInstanceId.RequestId");
			queryDomainByInstanceIdResponse.ZhRegistrantOrganization = _ctx.StringValue("QueryDomainByInstanceId.ZhRegistrantOrganization");
			queryDomainByInstanceIdResponse.ZhRegistrantName = _ctx.StringValue("QueryDomainByInstanceId.ZhRegistrantName");
			queryDomainByInstanceIdResponse.RegistrationDateLong = _ctx.LongValue("QueryDomainByInstanceId.RegistrationDateLong");
			queryDomainByInstanceIdResponse.ExpirationDateLong = _ctx.LongValue("QueryDomainByInstanceId.ExpirationDateLong");

			List<string> queryDomainByInstanceIdResponse_dnsList = new List<string>();
			for (int i = 0; i < _ctx.Length("QueryDomainByInstanceId.DnsList.Length"); i++) {
				queryDomainByInstanceIdResponse_dnsList.Add(_ctx.StringValue("QueryDomainByInstanceId.DnsList["+ i +"]"));
			}
			queryDomainByInstanceIdResponse.DnsList = queryDomainByInstanceIdResponse_dnsList;
        
			return queryDomainByInstanceIdResponse;
        }
    }
}
