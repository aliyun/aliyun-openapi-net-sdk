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
using Aliyun.Acs.codeup.Model.V20200414;

namespace Aliyun.Acs.codeup.Transform.V20200414
{
    public class CreateSshKeyResponseUnmarshaller
    {
        public static CreateSshKeyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateSshKeyResponse createSshKeyResponse = new CreateSshKeyResponse();

			createSshKeyResponse.HttpResponse = _ctx.HttpResponse;
			createSshKeyResponse.ErrorCode = _ctx.StringValue("CreateSshKey.ErrorCode");
			createSshKeyResponse.ErrorMessage = _ctx.StringValue("CreateSshKey.ErrorMessage");
			createSshKeyResponse.RequestId = _ctx.StringValue("CreateSshKey.RequestId");
			createSshKeyResponse.Success = _ctx.BooleanValue("CreateSshKey.Success");

			CreateSshKeyResponse.CreateSshKey_Result result = new CreateSshKeyResponse.CreateSshKey_Result();
			result.CreatedAt = _ctx.StringValue("CreateSshKey.Result.CreatedAt");
			result.FingerPrint = _ctx.StringValue("CreateSshKey.Result.FingerPrint");
			result.Id = _ctx.LongValue("CreateSshKey.Result.Id");
			result.Key = _ctx.StringValue("CreateSshKey.Result.Key");
			result.KeyScope = _ctx.StringValue("CreateSshKey.Result.KeyScope");
			result.Title = _ctx.StringValue("CreateSshKey.Result.Title");
			createSshKeyResponse.Result = result;
        
			return createSshKeyResponse;
        }
    }
}
