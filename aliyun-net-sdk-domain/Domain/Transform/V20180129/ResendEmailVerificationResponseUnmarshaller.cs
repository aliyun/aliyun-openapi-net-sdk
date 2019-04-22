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
    public class ResendEmailVerificationResponseUnmarshaller
    {
        public static ResendEmailVerificationResponse Unmarshall(UnmarshallerContext context)
        {
			ResendEmailVerificationResponse resendEmailVerificationResponse = new ResendEmailVerificationResponse();

			resendEmailVerificationResponse.HttpResponse = context.HttpResponse;
			resendEmailVerificationResponse.RequestId = context.StringValue("ResendEmailVerification.RequestId");

			List<ResendEmailVerificationResponse.ResendEmailVerification_SendResult> resendEmailVerificationResponse_successList = new List<ResendEmailVerificationResponse.ResendEmailVerification_SendResult>();
			for (int i = 0; i < context.Length("ResendEmailVerification.SuccessList.Length"); i++) {
				ResendEmailVerificationResponse.ResendEmailVerification_SendResult sendResult = new ResendEmailVerificationResponse.ResendEmailVerification_SendResult();
				sendResult.Email = context.StringValue("ResendEmailVerification.SuccessList["+ i +"].Email");
				sendResult.Code = context.StringValue("ResendEmailVerification.SuccessList["+ i +"].Code");
				sendResult.Message = context.StringValue("ResendEmailVerification.SuccessList["+ i +"].Message");

				resendEmailVerificationResponse_successList.Add(sendResult);
			}
			resendEmailVerificationResponse.SuccessList = resendEmailVerificationResponse_successList;

			List<ResendEmailVerificationResponse.ResendEmailVerification_SendResult> resendEmailVerificationResponse_failList = new List<ResendEmailVerificationResponse.ResendEmailVerification_SendResult>();
			for (int i = 0; i < context.Length("ResendEmailVerification.FailList.Length"); i++) {
				ResendEmailVerificationResponse.ResendEmailVerification_SendResult sendResult = new ResendEmailVerificationResponse.ResendEmailVerification_SendResult();
				sendResult.Email = context.StringValue("ResendEmailVerification.FailList["+ i +"].Email");
				sendResult.Code = context.StringValue("ResendEmailVerification.FailList["+ i +"].Code");
				sendResult.Message = context.StringValue("ResendEmailVerification.FailList["+ i +"].Message");

				resendEmailVerificationResponse_failList.Add(sendResult);
			}
			resendEmailVerificationResponse.FailList = resendEmailVerificationResponse_failList;
        
			return resendEmailVerificationResponse;
        }
    }
}
