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
    public class GetNodeByFlowIdResponseUnmarshaller
    {
        public static GetNodeByFlowIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetNodeByFlowIdResponse getNodeByFlowIdResponse = new GetNodeByFlowIdResponse();

			getNodeByFlowIdResponse.HttpResponse = _ctx.HttpResponse;
			getNodeByFlowIdResponse.AllowRetry = _ctx.BooleanValue("GetNodeByFlowId.AllowRetry");
			getNodeByFlowIdResponse.RequestId = _ctx.StringValue("GetNodeByFlowId.RequestId");
			getNodeByFlowIdResponse.ErrorMsg = _ctx.StringValue("GetNodeByFlowId.ErrorMsg");
			getNodeByFlowIdResponse.HttpStatusCode = _ctx.IntegerValue("GetNodeByFlowId.HttpStatusCode");
			getNodeByFlowIdResponse.DynamicCode = _ctx.StringValue("GetNodeByFlowId.DynamicCode");
			getNodeByFlowIdResponse.ErrorCode = _ctx.StringValue("GetNodeByFlowId.ErrorCode");
			getNodeByFlowIdResponse.DynamicMessage = _ctx.StringValue("GetNodeByFlowId.DynamicMessage");
			getNodeByFlowIdResponse.Module = _ctx.StringValue("GetNodeByFlowId.Module");
			getNodeByFlowIdResponse.Success = _ctx.BooleanValue("GetNodeByFlowId.Success");
			getNodeByFlowIdResponse.AppName = _ctx.StringValue("GetNodeByFlowId.AppName");
        
			return getNodeByFlowIdResponse;
        }
    }
}
