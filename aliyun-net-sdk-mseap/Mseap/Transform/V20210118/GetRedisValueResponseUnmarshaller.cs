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
    public class GetRedisValueResponseUnmarshaller
    {
        public static GetRedisValueResponse Unmarshall(UnmarshallerContext _ctx)
        {
			GetRedisValueResponse getRedisValueResponse = new GetRedisValueResponse();

			getRedisValueResponse.HttpResponse = _ctx.HttpResponse;
			getRedisValueResponse.AllowRetry = _ctx.BooleanValue("GetRedisValue.AllowRetry");
			getRedisValueResponse.RequestId = _ctx.StringValue("GetRedisValue.RequestId");
			getRedisValueResponse.ErrorMsg = _ctx.StringValue("GetRedisValue.ErrorMsg");
			getRedisValueResponse.HttpStatusCode = _ctx.IntegerValue("GetRedisValue.HttpStatusCode");
			getRedisValueResponse.DynamicCode = _ctx.StringValue("GetRedisValue.DynamicCode");
			getRedisValueResponse.ErrorCode = _ctx.StringValue("GetRedisValue.ErrorCode");
			getRedisValueResponse.DynamicMessage = _ctx.StringValue("GetRedisValue.DynamicMessage");
			getRedisValueResponse.Module = _ctx.StringValue("GetRedisValue.Module");
			getRedisValueResponse.Success = _ctx.BooleanValue("GetRedisValue.Success");
			getRedisValueResponse.AppName = _ctx.StringValue("GetRedisValue.AppName");
        
			return getRedisValueResponse;
        }
    }
}
