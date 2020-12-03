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
using Aliyun.Acs.dataworks_public.Model.V20200518;

namespace Aliyun.Acs.dataworks_public.Transform.V20200518
{
    public class GetNodeCodeResponseUnmarshaller
    {
        public static GetNodeCodeResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetNodeCodeResponse getNodeCodeResponse = new GetNodeCodeResponse();

			getNodeCodeResponse.HttpResponse = _ctx.HttpResponse;
			getNodeCodeResponse.Success = _ctx.BooleanValue("GetNodeCode.Success");
			getNodeCodeResponse.ErrorCode = _ctx.StringValue("GetNodeCode.ErrorCode");
			getNodeCodeResponse.ErrorMessage = _ctx.StringValue("GetNodeCode.ErrorMessage");
			getNodeCodeResponse.HttpStatusCode = _ctx.IntegerValue("GetNodeCode.HttpStatusCode");
			getNodeCodeResponse.RequestId = _ctx.StringValue("GetNodeCode.RequestId");
			getNodeCodeResponse.Data = _ctx.StringValue("GetNodeCode.Data");
        
			return getNodeCodeResponse;
        }
    }
}
