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
    public class QueryFailReasonForDomainRealNameVerificationResponseUnmarshaller
    {
        public static QueryFailReasonForDomainRealNameVerificationResponse Unmarshall(UnmarshallerContext context)
        {
			QueryFailReasonForDomainRealNameVerificationResponse queryFailReasonForDomainRealNameVerificationResponse = new QueryFailReasonForDomainRealNameVerificationResponse();

			queryFailReasonForDomainRealNameVerificationResponse.HttpResponse = context.HttpResponse;
			queryFailReasonForDomainRealNameVerificationResponse.RequestId = context.StringValue("QueryFailReasonForDomainRealNameVerification.RequestId");

			List<QueryFailReasonForDomainRealNameVerificationResponse.QueryFailReasonForDomainRealNameVerification_FailRecord> queryFailReasonForDomainRealNameVerificationResponse_data = new List<QueryFailReasonForDomainRealNameVerificationResponse.QueryFailReasonForDomainRealNameVerification_FailRecord>();
			for (int i = 0; i < context.Length("QueryFailReasonForDomainRealNameVerification.Data.Length"); i++) {
				QueryFailReasonForDomainRealNameVerificationResponse.QueryFailReasonForDomainRealNameVerification_FailRecord failRecord = new QueryFailReasonForDomainRealNameVerificationResponse.QueryFailReasonForDomainRealNameVerification_FailRecord();
				failRecord.Date = context.StringValue("QueryFailReasonForDomainRealNameVerification.Data["+ i +"].Date");
				failRecord.FailReason = context.StringValue("QueryFailReasonForDomainRealNameVerification.Data["+ i +"].FailReason");
				failRecord.DomainNameVerificationStatus = context.StringValue("QueryFailReasonForDomainRealNameVerification.Data["+ i +"].DomainNameVerificationStatus");

				queryFailReasonForDomainRealNameVerificationResponse_data.Add(failRecord);
			}
			queryFailReasonForDomainRealNameVerificationResponse.Data = queryFailReasonForDomainRealNameVerificationResponse_data;
        
			return queryFailReasonForDomainRealNameVerificationResponse;
        }
    }
}
