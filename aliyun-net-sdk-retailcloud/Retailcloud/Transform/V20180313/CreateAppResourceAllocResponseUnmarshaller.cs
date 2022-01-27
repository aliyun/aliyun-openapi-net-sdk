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
using Aliyun.Acs.retailcloud.Model.V20180313;

namespace Aliyun.Acs.retailcloud.Transform.V20180313
{
    public class CreateAppResourceAllocResponseUnmarshaller
    {
        public static CreateAppResourceAllocResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateAppResourceAllocResponse createAppResourceAllocResponse = new CreateAppResourceAllocResponse();

			createAppResourceAllocResponse.HttpResponse = _ctx.HttpResponse;
			createAppResourceAllocResponse.Code = _ctx.IntegerValue("CreateAppResourceAlloc.Code");
			createAppResourceAllocResponse.ErrMsg = _ctx.StringValue("CreateAppResourceAlloc.ErrMsg");
			createAppResourceAllocResponse.RequestId = _ctx.StringValue("CreateAppResourceAlloc.RequestId");
			createAppResourceAllocResponse.Success = _ctx.BooleanValue("CreateAppResourceAlloc.Success");

			CreateAppResourceAllocResponse.CreateAppResourceAlloc_Result result = new CreateAppResourceAllocResponse.CreateAppResourceAlloc_Result();
			result.AppEnvId = _ctx.LongValue("CreateAppResourceAlloc.Result.AppEnvId");
			result.AppId = _ctx.LongValue("CreateAppResourceAlloc.Result.AppId");
			result.ClusterId = _ctx.StringValue("CreateAppResourceAlloc.Result.ClusterId");
			result.Id = _ctx.LongValue("CreateAppResourceAlloc.Result.Id");
			result.ResourceDef = _ctx.StringValue("CreateAppResourceAlloc.Result.ResourceDef");
			createAppResourceAllocResponse.Result = result;
        
			return createAppResourceAllocResponse;
        }
    }
}
