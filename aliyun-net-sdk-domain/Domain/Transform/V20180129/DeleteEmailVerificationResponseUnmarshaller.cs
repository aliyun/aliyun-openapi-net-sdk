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
    public class DeleteEmailVerificationResponseUnmarshaller
    {
        public static DeleteEmailVerificationResponse Unmarshall(UnmarshallerContext context)
        {
			DeleteEmailVerificationResponse deleteEmailVerificationResponse = new DeleteEmailVerificationResponse();

			deleteEmailVerificationResponse.HttpResponse = context.HttpResponse;
			deleteEmailVerificationResponse.RequestId = context.StringValue("DeleteEmailVerification.RequestId");

			List<DeleteEmailVerificationResponse.DeleteEmailVerification_SendResult> deleteEmailVerificationResponse_successList = new List<DeleteEmailVerificationResponse.DeleteEmailVerification_SendResult>();
			for (int i = 0; i < context.Length("DeleteEmailVerification.SuccessList.Length"); i++) {
				DeleteEmailVerificationResponse.DeleteEmailVerification_SendResult sendResult = new DeleteEmailVerificationResponse.DeleteEmailVerification_SendResult();
				sendResult.Email = context.StringValue("DeleteEmailVerification.SuccessList["+ i +"].Email");
				sendResult.Code = context.StringValue("DeleteEmailVerification.SuccessList["+ i +"].Code");
				sendResult.Message = context.StringValue("DeleteEmailVerification.SuccessList["+ i +"].Message");

				deleteEmailVerificationResponse_successList.Add(sendResult);
			}
			deleteEmailVerificationResponse.SuccessList = deleteEmailVerificationResponse_successList;

			List<DeleteEmailVerificationResponse.DeleteEmailVerification_SendResult> deleteEmailVerificationResponse_failList = new List<DeleteEmailVerificationResponse.DeleteEmailVerification_SendResult>();
			for (int i = 0; i < context.Length("DeleteEmailVerification.FailList.Length"); i++) {
				DeleteEmailVerificationResponse.DeleteEmailVerification_SendResult sendResult = new DeleteEmailVerificationResponse.DeleteEmailVerification_SendResult();
				sendResult.Email = context.StringValue("DeleteEmailVerification.FailList["+ i +"].Email");
				sendResult.Code = context.StringValue("DeleteEmailVerification.FailList["+ i +"].Code");
				sendResult.Message = context.StringValue("DeleteEmailVerification.FailList["+ i +"].Message");

				deleteEmailVerificationResponse_failList.Add(sendResult);
			}
			deleteEmailVerificationResponse.FailList = deleteEmailVerificationResponse_failList;
        
			return deleteEmailVerificationResponse;
        }
    }
}
