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
    public class SubmitEmailVerificationResponseUnmarshaller
    {
        public static SubmitEmailVerificationResponse Unmarshall(UnmarshallerContext context)
        {
			SubmitEmailVerificationResponse submitEmailVerificationResponse = new SubmitEmailVerificationResponse();

			submitEmailVerificationResponse.HttpResponse = context.HttpResponse;
			submitEmailVerificationResponse.RequestId = context.StringValue("SubmitEmailVerification.RequestId");

			List<SubmitEmailVerificationResponse.SubmitEmailVerification_SendResult> submitEmailVerificationResponse_successList = new List<SubmitEmailVerificationResponse.SubmitEmailVerification_SendResult>();
			for (int i = 0; i < context.Length("SubmitEmailVerification.SuccessList.Length"); i++) {
				SubmitEmailVerificationResponse.SubmitEmailVerification_SendResult sendResult = new SubmitEmailVerificationResponse.SubmitEmailVerification_SendResult();
				sendResult.Email = context.StringValue("SubmitEmailVerification.SuccessList["+ i +"].Email");
				sendResult.Code = context.StringValue("SubmitEmailVerification.SuccessList["+ i +"].Code");
				sendResult.Message = context.StringValue("SubmitEmailVerification.SuccessList["+ i +"].Message");

				submitEmailVerificationResponse_successList.Add(sendResult);
			}
			submitEmailVerificationResponse.SuccessList = submitEmailVerificationResponse_successList;

			List<SubmitEmailVerificationResponse.SubmitEmailVerification_SendResult> submitEmailVerificationResponse_failList = new List<SubmitEmailVerificationResponse.SubmitEmailVerification_SendResult>();
			for (int i = 0; i < context.Length("SubmitEmailVerification.FailList.Length"); i++) {
				SubmitEmailVerificationResponse.SubmitEmailVerification_SendResult sendResult = new SubmitEmailVerificationResponse.SubmitEmailVerification_SendResult();
				sendResult.Email = context.StringValue("SubmitEmailVerification.FailList["+ i +"].Email");
				sendResult.Code = context.StringValue("SubmitEmailVerification.FailList["+ i +"].Code");
				sendResult.Message = context.StringValue("SubmitEmailVerification.FailList["+ i +"].Message");

				submitEmailVerificationResponse_failList.Add(sendResult);
			}
			submitEmailVerificationResponse.FailList = submitEmailVerificationResponse_failList;

			List<SubmitEmailVerificationResponse.SubmitEmailVerification_SendResult> submitEmailVerificationResponse_existList = new List<SubmitEmailVerificationResponse.SubmitEmailVerification_SendResult>();
			for (int i = 0; i < context.Length("SubmitEmailVerification.ExistList.Length"); i++) {
				SubmitEmailVerificationResponse.SubmitEmailVerification_SendResult sendResult = new SubmitEmailVerificationResponse.SubmitEmailVerification_SendResult();
				sendResult.Email = context.StringValue("SubmitEmailVerification.ExistList["+ i +"].Email");
				sendResult.Code = context.StringValue("SubmitEmailVerification.ExistList["+ i +"].Code");
				sendResult.Message = context.StringValue("SubmitEmailVerification.ExistList["+ i +"].Message");

				submitEmailVerificationResponse_existList.Add(sendResult);
			}
			submitEmailVerificationResponse.ExistList = submitEmailVerificationResponse_existList;
        
			return submitEmailVerificationResponse;
        }
    }
}
