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
    public class QueryDomainRealNameVerificationInfoResponseUnmarshaller
    {
        public static QueryDomainRealNameVerificationInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryDomainRealNameVerificationInfoResponse queryDomainRealNameVerificationInfoResponse = new QueryDomainRealNameVerificationInfoResponse();

			queryDomainRealNameVerificationInfoResponse.HttpResponse = _ctx.HttpResponse;
			queryDomainRealNameVerificationInfoResponse.IdentityCredentialType = _ctx.StringValue("QueryDomainRealNameVerificationInfo.IdentityCredentialType");
			queryDomainRealNameVerificationInfoResponse.RequestId = _ctx.StringValue("QueryDomainRealNameVerificationInfo.RequestId");
			queryDomainRealNameVerificationInfoResponse.InstanceId = _ctx.StringValue("QueryDomainRealNameVerificationInfo.InstanceId");
			queryDomainRealNameVerificationInfoResponse.DomainName = _ctx.StringValue("QueryDomainRealNameVerificationInfo.DomainName");
			queryDomainRealNameVerificationInfoResponse.IdentityCredential = _ctx.StringValue("QueryDomainRealNameVerificationInfo.IdentityCredential");
			queryDomainRealNameVerificationInfoResponse.SubmissionDate = _ctx.StringValue("QueryDomainRealNameVerificationInfo.SubmissionDate");
			queryDomainRealNameVerificationInfoResponse.IdentityCredentialNo = _ctx.StringValue("QueryDomainRealNameVerificationInfo.IdentityCredentialNo");
			queryDomainRealNameVerificationInfoResponse.IdentityCredentialUrl = _ctx.StringValue("QueryDomainRealNameVerificationInfo.IdentityCredentialUrl");
        
			return queryDomainRealNameVerificationInfoResponse;
        }
    }
}
