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
        public static QueryEmailVerificationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			QueryEmailVerificationResponse queryEmailVerificationResponse = new QueryEmailVerificationResponse();

			queryEmailVerificationResponse.HttpResponse = _ctx.HttpResponse;
			queryEmailVerificationResponse.RequestId = _ctx.StringValue("QueryEmailVerification.RequestId");
			queryEmailVerificationResponse.GmtCreate = _ctx.StringValue("QueryEmailVerification.GmtCreate");
			queryEmailVerificationResponse.GmtModified = _ctx.StringValue("QueryEmailVerification.GmtModified");
			queryEmailVerificationResponse.Email = _ctx.StringValue("QueryEmailVerification.Email");
			queryEmailVerificationResponse.UserId = _ctx.StringValue("QueryEmailVerification.UserId");
			queryEmailVerificationResponse.EmailVerificationNo = _ctx.StringValue("QueryEmailVerification.EmailVerificationNo");
			queryEmailVerificationResponse.TokenSendTime = _ctx.StringValue("QueryEmailVerification.TokenSendTime");
			queryEmailVerificationResponse.VerificationStatus = _ctx.IntegerValue("QueryEmailVerification.VerificationStatus");
			queryEmailVerificationResponse.VerificationTime = _ctx.StringValue("QueryEmailVerification.VerificationTime");
			queryEmailVerificationResponse.SendIp = _ctx.StringValue("QueryEmailVerification.SendIp");
			queryEmailVerificationResponse.ConfirmIp = _ctx.StringValue("QueryEmailVerification.ConfirmIp");
        
			return queryEmailVerificationResponse;
        }
    }
}
