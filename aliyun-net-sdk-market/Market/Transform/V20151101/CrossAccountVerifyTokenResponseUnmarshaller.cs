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
using Aliyun.Acs.Market.Model.V20151101;

namespace Aliyun.Acs.Market.Transform.V20151101
{
    public class CrossAccountVerifyTokenResponseUnmarshaller
    {
        public static CrossAccountVerifyTokenResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CrossAccountVerifyTokenResponse crossAccountVerifyTokenResponse = new CrossAccountVerifyTokenResponse();

			crossAccountVerifyTokenResponse.HttpResponse = _ctx.HttpResponse;
			crossAccountVerifyTokenResponse.Success = _ctx.BooleanValue("CrossAccountVerifyToken.Success");
			crossAccountVerifyTokenResponse.Code = _ctx.StringValue("CrossAccountVerifyToken.Code");
			crossAccountVerifyTokenResponse.Message = _ctx.StringValue("CrossAccountVerifyToken.Message");
			crossAccountVerifyTokenResponse.RequestId = _ctx.StringValue("CrossAccountVerifyToken.RequestId");

			CrossAccountVerifyTokenResponse.CrossAccountVerifyToken_Result result = new CrossAccountVerifyTokenResponse.CrossAccountVerifyToken_Result();
			result.Name = _ctx.StringValue("CrossAccountVerifyToken.Result.Name");
			result.Uid = _ctx.StringValue("CrossAccountVerifyToken.Result.Uid");
			result.AuthTime = _ctx.LongValue("CrossAccountVerifyToken.Result.AuthTime");

			List<string> result_authRoles = new List<string>();
			for (int i = 0; i < _ctx.Length("CrossAccountVerifyToken.Result.AuthRoles.Length"); i++) {
				result_authRoles.Add(_ctx.StringValue("CrossAccountVerifyToken.Result.AuthRoles["+ i +"]"));
			}
			result.AuthRoles = result_authRoles;
			crossAccountVerifyTokenResponse.Result = result;
        
			return crossAccountVerifyTokenResponse;
        }
    }
}
