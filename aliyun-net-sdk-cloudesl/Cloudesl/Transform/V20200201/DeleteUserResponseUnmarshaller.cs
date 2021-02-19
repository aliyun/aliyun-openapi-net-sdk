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
using Aliyun.Acs.cloudesl.Model.V20200201;

namespace Aliyun.Acs.cloudesl.Transform.V20200201
{
    public class DeleteUserResponseUnmarshaller
    {
        public static DeleteUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DeleteUserResponse deleteUserResponse = new DeleteUserResponse();

			deleteUserResponse.HttpResponse = _ctx.HttpResponse;
			deleteUserResponse.ErrorMessage = _ctx.StringValue("DeleteUser.ErrorMessage");
			deleteUserResponse.ErrorCode = _ctx.StringValue("DeleteUser.ErrorCode");
			deleteUserResponse.Message = _ctx.StringValue("DeleteUser.Message");
			deleteUserResponse.DynamicCode = _ctx.StringValue("DeleteUser.DynamicCode");
			deleteUserResponse.Code = _ctx.StringValue("DeleteUser.Code");
			deleteUserResponse.DynamicMessage = _ctx.StringValue("DeleteUser.DynamicMessage");
			deleteUserResponse.RequestId = _ctx.StringValue("DeleteUser.RequestId");
			deleteUserResponse.Success = _ctx.BooleanValue("DeleteUser.Success");
        
			return deleteUserResponse;
        }
    }
}
