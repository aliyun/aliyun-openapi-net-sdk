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
using Aliyun.Acs.mseap.Model.V20210118;

namespace Aliyun.Acs.mseap.Transform.V20210118
{
    public class GetVariableResponseUnmarshaller
    {
        public static GetVariableResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetVariableResponse getVariableResponse = new GetVariableResponse();

			getVariableResponse.HttpResponse = _ctx.HttpResponse;
			getVariableResponse.AllowRetry = _ctx.BooleanValue("GetVariable.AllowRetry");
			getVariableResponse.RequestId = _ctx.StringValue("GetVariable.RequestId");
			getVariableResponse.ErrorMsg = _ctx.StringValue("GetVariable.ErrorMsg");
			getVariableResponse.HttpStatusCode = _ctx.IntegerValue("GetVariable.HttpStatusCode");
			getVariableResponse.DynamicCode = _ctx.StringValue("GetVariable.DynamicCode");
			getVariableResponse.ErrorCode = _ctx.StringValue("GetVariable.ErrorCode");
			getVariableResponse.DynamicMessage = _ctx.StringValue("GetVariable.DynamicMessage");
			getVariableResponse.Module = _ctx.StringValue("GetVariable.Module");
			getVariableResponse.Success = _ctx.BooleanValue("GetVariable.Success");
			getVariableResponse.AppName = _ctx.StringValue("GetVariable.AppName");
        
			return getVariableResponse;
        }
    }
}
