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
    public class CreateRepositoryDeployKeyResponseUnmarshaller
    {
        public static CreateRepositoryDeployKeyResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateRepositoryDeployKeyResponse createRepositoryDeployKeyResponse = new CreateRepositoryDeployKeyResponse();

			createRepositoryDeployKeyResponse.HttpResponse = _ctx.HttpResponse;
			createRepositoryDeployKeyResponse.ErrorCode = _ctx.StringValue("CreateRepositoryDeployKey.ErrorCode");
			createRepositoryDeployKeyResponse.ErrorMessage = _ctx.StringValue("CreateRepositoryDeployKey.ErrorMessage");
			createRepositoryDeployKeyResponse.RequestId = _ctx.StringValue("CreateRepositoryDeployKey.RequestId");
			createRepositoryDeployKeyResponse.Success = _ctx.BooleanValue("CreateRepositoryDeployKey.Success");

			CreateRepositoryDeployKeyResponse.CreateRepositoryDeployKey_Result result = new CreateRepositoryDeployKeyResponse.CreateRepositoryDeployKey_Result();
			result.Id = _ctx.LongValue("CreateRepositoryDeployKey.Result.Id");
			result.Title = _ctx.StringValue("CreateRepositoryDeployKey.Result.Title");
			result.Key = _ctx.StringValue("CreateRepositoryDeployKey.Result.Key");
			result.FingerPrint = _ctx.StringValue("CreateRepositoryDeployKey.Result.FingerPrint");
			result.CreatedAt = _ctx.StringValue("CreateRepositoryDeployKey.Result.CreatedAt");
			createRepositoryDeployKeyResponse.Result = result;
        
			return createRepositoryDeployKeyResponse;
        }
    }
}
