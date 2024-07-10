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
    public class GetNodeByTemplateIdResponseUnmarshaller
    {
        public static GetNodeByTemplateIdResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetNodeByTemplateIdResponse getNodeByTemplateIdResponse = new GetNodeByTemplateIdResponse();

			getNodeByTemplateIdResponse.HttpResponse = _ctx.HttpResponse;
			getNodeByTemplateIdResponse.AllowRetry = _ctx.BooleanValue("GetNodeByTemplateId.AllowRetry");
			getNodeByTemplateIdResponse.RequestId = _ctx.StringValue("GetNodeByTemplateId.RequestId");
			getNodeByTemplateIdResponse.ErrorMsg = _ctx.StringValue("GetNodeByTemplateId.ErrorMsg");
			getNodeByTemplateIdResponse.HttpStatusCode = _ctx.IntegerValue("GetNodeByTemplateId.HttpStatusCode");
			getNodeByTemplateIdResponse.DynamicCode = _ctx.StringValue("GetNodeByTemplateId.DynamicCode");
			getNodeByTemplateIdResponse.ErrorCode = _ctx.StringValue("GetNodeByTemplateId.ErrorCode");
			getNodeByTemplateIdResponse.DynamicMessage = _ctx.StringValue("GetNodeByTemplateId.DynamicMessage");
			getNodeByTemplateIdResponse.Module = _ctx.StringValue("GetNodeByTemplateId.Module");
			getNodeByTemplateIdResponse.Success = _ctx.BooleanValue("GetNodeByTemplateId.Success");
			getNodeByTemplateIdResponse.AppName = _ctx.StringValue("GetNodeByTemplateId.AppName");
        
			return getNodeByTemplateIdResponse;
        }
    }
}
