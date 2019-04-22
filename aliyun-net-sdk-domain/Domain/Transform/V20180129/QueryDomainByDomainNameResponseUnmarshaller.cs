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
        public static QueryDomainByDomainNameResponse Unmarshall(UnmarshallerContext context)
        {
			QueryDomainByDomainNameResponse queryDomainByDomainNameResponse = new QueryDomainByDomainNameResponse();

			queryDomainByDomainNameResponse.HttpResponse = context.HttpResponse;
			queryDomainByDomainNameResponse.UserId = context.StringValue("QueryDomainByDomainName.UserId");
			queryDomainByDomainNameResponse.DomainName = context.StringValue("QueryDomainByDomainName.DomainName");
			queryDomainByDomainNameResponse.InstanceId = context.StringValue("QueryDomainByDomainName.InstanceId");
			queryDomainByDomainNameResponse.RegistrationDate = context.StringValue("QueryDomainByDomainName.RegistrationDate");
			queryDomainByDomainNameResponse.ExpirationDate = context.StringValue("QueryDomainByDomainName.ExpirationDate");
			queryDomainByDomainNameResponse.RegistrantOrganization = context.StringValue("QueryDomainByDomainName.RegistrantOrganization");
			queryDomainByDomainNameResponse.RegistrantName = context.StringValue("QueryDomainByDomainName.RegistrantName");
			queryDomainByDomainNameResponse.Email = context.StringValue("QueryDomainByDomainName.Email");
			queryDomainByDomainNameResponse.UpdateProhibitionLock = context.StringValue("QueryDomainByDomainName.UpdateProhibitionLock");
			queryDomainByDomainNameResponse.TransferProhibitionLock = context.StringValue("QueryDomainByDomainName.TransferProhibitionLock");
			queryDomainByDomainNameResponse.DomainNameProxyService = context.BooleanValue("QueryDomainByDomainName.DomainNameProxyService");
			queryDomainByDomainNameResponse.Premium = context.BooleanValue("QueryDomainByDomainName.Premium");
			queryDomainByDomainNameResponse.EmailVerificationStatus = context.IntegerValue("QueryDomainByDomainName.EmailVerificationStatus");
			queryDomainByDomainNameResponse.EmailVerificationClientHold = context.BooleanValue("QueryDomainByDomainName.EmailVerificationClientHold");
			queryDomainByDomainNameResponse.RealNameStatus = context.StringValue("QueryDomainByDomainName.RealNameStatus");
			queryDomainByDomainNameResponse.RegistrantUpdatingStatus = context.StringValue("QueryDomainByDomainName.RegistrantUpdatingStatus");
			queryDomainByDomainNameResponse.TransferOutStatus = context.StringValue("QueryDomainByDomainName.TransferOutStatus");
			queryDomainByDomainNameResponse.RegistrantType = context.StringValue("QueryDomainByDomainName.RegistrantType");
			queryDomainByDomainNameResponse.DomainNameVerificationStatus = context.StringValue("QueryDomainByDomainName.DomainNameVerificationStatus");
			queryDomainByDomainNameResponse.RequestId = context.StringValue("QueryDomainByDomainName.RequestId");
			queryDomainByDomainNameResponse.ZhRegistrantOrganization = context.StringValue("QueryDomainByDomainName.ZhRegistrantOrganization");
			queryDomainByDomainNameResponse.ZhRegistrantName = context.StringValue("QueryDomainByDomainName.ZhRegistrantName");
			queryDomainByDomainNameResponse.RegistrationDateLong = context.LongValue("QueryDomainByDomainName.RegistrationDateLong");
			queryDomainByDomainNameResponse.ExpirationDateLong = context.LongValue("QueryDomainByDomainName.ExpirationDateLong");

			List<string> queryDomainByDomainNameResponse_dnsList = new List<string>();
			for (int i = 0; i < context.Length("QueryDomainByDomainName.DnsList.Length"); i++) {
				queryDomainByDomainNameResponse_dnsList.Add(context.StringValue("QueryDomainByDomainName.DnsList["+ i +"]"));
			}
			queryDomainByDomainNameResponse.DnsList = queryDomainByDomainNameResponse_dnsList;
        
			return queryDomainByDomainNameResponse;
        }
    }
}
