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
        public static QueryRegistrantProfileRealNameVerificationInfoResponse Unmarshall(UnmarshallerContext context)
        {
			QueryRegistrantProfileRealNameVerificationInfoResponse queryRegistrantProfileRealNameVerificationInfoResponse = new QueryRegistrantProfileRealNameVerificationInfoResponse();

			queryRegistrantProfileRealNameVerificationInfoResponse.HttpResponse = context.HttpResponse;
			queryRegistrantProfileRealNameVerificationInfoResponse.RequestId = context.StringValue("QueryRegistrantProfileRealNameVerificationInfo.RequestId");
			queryRegistrantProfileRealNameVerificationInfoResponse.SubmissionDate = context.StringValue("QueryRegistrantProfileRealNameVerificationInfo.SubmissionDate");
			queryRegistrantProfileRealNameVerificationInfoResponse.ModificationDate = context.StringValue("QueryRegistrantProfileRealNameVerificationInfo.ModificationDate");
			queryRegistrantProfileRealNameVerificationInfoResponse.IdentityCredential = context.StringValue("QueryRegistrantProfileRealNameVerificationInfo.IdentityCredential");
			queryRegistrantProfileRealNameVerificationInfoResponse.RegistrantProfileId = context.LongValue("QueryRegistrantProfileRealNameVerificationInfo.RegistrantProfileId");
			queryRegistrantProfileRealNameVerificationInfoResponse.IdentityCredentialNo = context.StringValue("QueryRegistrantProfileRealNameVerificationInfo.IdentityCredentialNo");
			queryRegistrantProfileRealNameVerificationInfoResponse.IdentityCredentialType = context.StringValue("QueryRegistrantProfileRealNameVerificationInfo.IdentityCredentialType");
			queryRegistrantProfileRealNameVerificationInfoResponse.IdentityCredentialUrl = context.StringValue("QueryRegistrantProfileRealNameVerificationInfo.IdentityCredentialUrl");
        
			return queryRegistrantProfileRealNameVerificationInfoResponse;
        }
    }
}
