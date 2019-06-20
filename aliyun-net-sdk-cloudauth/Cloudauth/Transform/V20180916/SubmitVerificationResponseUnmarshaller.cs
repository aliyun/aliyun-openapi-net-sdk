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
using Aliyun.Acs.Cloudauth.Model.V20180916;

namespace Aliyun.Acs.Cloudauth.Transform.V20180916
{
    public class SubmitVerificationResponseUnmarshaller
    {
        public static SubmitVerificationResponse Unmarshall(UnmarshallerContext context)
        {
			SubmitVerificationResponse submitVerificationResponse = new SubmitVerificationResponse();

			submitVerificationResponse.HttpResponse = context.HttpResponse;
			submitVerificationResponse.RequestId = context.StringValue("SubmitVerification.RequestId");
			submitVerificationResponse.Success = context.BooleanValue("SubmitVerification.Success");
			submitVerificationResponse.Code = context.StringValue("SubmitVerification.Code");
			submitVerificationResponse.Message = context.StringValue("SubmitVerification.Message");

			SubmitVerificationResponse.SubmitVerification_Data data = new SubmitVerificationResponse.SubmitVerification_Data();

			SubmitVerificationResponse.SubmitVerification_Data.SubmitVerification_VerifyStatus verifyStatus = new SubmitVerificationResponse.SubmitVerification_Data.SubmitVerification_VerifyStatus();
			verifyStatus.StatusCode = context.IntegerValue("SubmitVerification.Data.VerifyStatus.StatusCode");
			verifyStatus.TrustedScore = context.FloatValue("SubmitVerification.Data.VerifyStatus.TrustedScore");
			verifyStatus.SimilarityScore = context.FloatValue("SubmitVerification.Data.VerifyStatus.SimilarityScore");
			verifyStatus.AuditConclusions = context.StringValue("SubmitVerification.Data.VerifyStatus.AuditConclusions");
			verifyStatus.AuthorityComparisonScore = context.FloatValue("SubmitVerification.Data.VerifyStatus.AuthorityComparisonScore");
			data.VerifyStatus = verifyStatus;
			submitVerificationResponse.Data = data;
        
			return submitVerificationResponse;
        }
    }
}
