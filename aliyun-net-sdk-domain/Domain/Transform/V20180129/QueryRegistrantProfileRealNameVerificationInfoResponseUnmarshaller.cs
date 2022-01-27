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
    public class QueryRegistrantProfileRealNameVerificationInfoResponseUnmarshaller
    {
        public static QueryRegistrantProfileRealNameVerificationInfoResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryRegistrantProfileRealNameVerificationInfoResponse queryRegistrantProfileRealNameVerificationInfoResponse = new QueryRegistrantProfileRealNameVerificationInfoResponse();

			queryRegistrantProfileRealNameVerificationInfoResponse.HttpResponse = _ctx.HttpResponse;
			queryRegistrantProfileRealNameVerificationInfoResponse.RequestId = _ctx.StringValue("QueryRegistrantProfileRealNameVerificationInfo.RequestId");
			queryRegistrantProfileRealNameVerificationInfoResponse.SubmissionDate = _ctx.StringValue("QueryRegistrantProfileRealNameVerificationInfo.SubmissionDate");
			queryRegistrantProfileRealNameVerificationInfoResponse.ModificationDate = _ctx.StringValue("QueryRegistrantProfileRealNameVerificationInfo.ModificationDate");
			queryRegistrantProfileRealNameVerificationInfoResponse.IdentityCredential = _ctx.StringValue("QueryRegistrantProfileRealNameVerificationInfo.IdentityCredential");
			queryRegistrantProfileRealNameVerificationInfoResponse.RegistrantProfileId = _ctx.LongValue("QueryRegistrantProfileRealNameVerificationInfo.RegistrantProfileId");
			queryRegistrantProfileRealNameVerificationInfoResponse.IdentityCredentialNo = _ctx.StringValue("QueryRegistrantProfileRealNameVerificationInfo.IdentityCredentialNo");
			queryRegistrantProfileRealNameVerificationInfoResponse.IdentityCredentialType = _ctx.StringValue("QueryRegistrantProfileRealNameVerificationInfo.IdentityCredentialType");
			queryRegistrantProfileRealNameVerificationInfoResponse.IdentityCredentialUrl = _ctx.StringValue("QueryRegistrantProfileRealNameVerificationInfo.IdentityCredentialUrl");
        
			return queryRegistrantProfileRealNameVerificationInfoResponse;
        }
    }
}
