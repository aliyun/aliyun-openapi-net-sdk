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
using Aliyun.Acs.facebody.Model.V20200910;

namespace Aliyun.Acs.facebody.Transform.V20200910
{
    public class ExecuteServerSideVerificationResponseUnmarshaller
    {
        public static ExecuteServerSideVerificationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ExecuteServerSideVerificationResponse executeServerSideVerificationResponse = new ExecuteServerSideVerificationResponse();

			executeServerSideVerificationResponse.HttpResponse = _ctx.HttpResponse;
			executeServerSideVerificationResponse.Message = _ctx.StringValue("ExecuteServerSideVerification.Message");
			executeServerSideVerificationResponse.RequestId = _ctx.StringValue("ExecuteServerSideVerification.RequestId");
			executeServerSideVerificationResponse.Code = _ctx.StringValue("ExecuteServerSideVerification.Code");

			ExecuteServerSideVerificationResponse.ExecuteServerSideVerification_Data data = new ExecuteServerSideVerificationResponse.ExecuteServerSideVerification_Data();
			data.VerificationToken = _ctx.StringValue("ExecuteServerSideVerification.Data.VerificationToken");
			data.Pass = _ctx.BooleanValue("ExecuteServerSideVerification.Data.Pass");
			data.Reason = _ctx.StringValue("ExecuteServerSideVerification.Data.Reason");
			executeServerSideVerificationResponse.Data = data;
        
			return executeServerSideVerificationResponse;
        }
    }
}
