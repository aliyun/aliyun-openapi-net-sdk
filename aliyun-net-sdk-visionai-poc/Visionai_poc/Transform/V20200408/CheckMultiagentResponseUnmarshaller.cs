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
using Aliyun.Acs.visionai_poc.Model.V20200408;

namespace Aliyun.Acs.visionai_poc.Transform.V20200408
{
    public class CheckMultiagentResponseUnmarshaller
    {
        public static CheckMultiagentResponse Unmarshall(UnmarshallerContext context)
        {
			CheckMultiagentResponse checkMultiagentResponse = new CheckMultiagentResponse();

			checkMultiagentResponse.HttpResponse = context.HttpResponse;
			checkMultiagentResponse.Code = context.StringValue("CheckMultiagent.Code");
			checkMultiagentResponse.Success = context.BooleanValue("CheckMultiagent.Success");
			checkMultiagentResponse.Message = context.StringValue("CheckMultiagent.Message");

			CheckMultiagentResponse.CheckMultiagent_Response response = new CheckMultiagentResponse.CheckMultiagent_Response();
			response.Data = context.StringValue("CheckMultiagent.Response.Data");
			response.Success = context.BooleanValue("CheckMultiagent.Response.Success");
			response.Url = context.StringValue("CheckMultiagent.Response.Url");
			response.RequestId = context.StringValue("CheckMultiagent.Response.RequestId");
			response.ErrorCode = context.StringValue("CheckMultiagent.Response.ErrorCode");
			response.ErrorMessage = context.StringValue("CheckMultiagent.Response.ErrorMessage");
			checkMultiagentResponse.Response = response;
        
			return checkMultiagentResponse;
        }
    }
}
