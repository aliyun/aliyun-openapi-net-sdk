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
    public class QueryEmailVerificationResponseUnmarshaller
    {
        public static QueryEmailVerificationResponse Unmarshall(UnmarshallerContext context)
        {
			QueryEmailVerificationResponse queryEmailVerificationResponse = new QueryEmailVerificationResponse();

			queryEmailVerificationResponse.HttpResponse = context.HttpResponse;
			queryEmailVerificationResponse.RequestId = context.StringValue("QueryEmailVerification.RequestId");
			queryEmailVerificationResponse.GmtCreate = context.StringValue("QueryEmailVerification.GmtCreate");
			queryEmailVerificationResponse.GmtModified = context.StringValue("QueryEmailVerification.GmtModified");
			queryEmailVerificationResponse.Email = context.StringValue("QueryEmailVerification.Email");
			queryEmailVerificationResponse.UserId = context.StringValue("QueryEmailVerification.UserId");
			queryEmailVerificationResponse.EmailVerificationNo = context.StringValue("QueryEmailVerification.EmailVerificationNo");
			queryEmailVerificationResponse.TokenSendTime = context.StringValue("QueryEmailVerification.TokenSendTime");
			queryEmailVerificationResponse.VerificationStatus = context.IntegerValue("QueryEmailVerification.VerificationStatus");
			queryEmailVerificationResponse.VerificationTime = context.StringValue("QueryEmailVerification.VerificationTime");
			queryEmailVerificationResponse.SendIp = context.StringValue("QueryEmailVerification.SendIp");
			queryEmailVerificationResponse.ConfirmIp = context.StringValue("QueryEmailVerification.ConfirmIp");
        
			return queryEmailVerificationResponse;
        }
    }
}
