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
    public class UnassignUserResponseUnmarshaller
    {
        public static UnassignUserResponse Unmarshall(UnmarshallerContext _ctx)
        {
			UnassignUserResponse unassignUserResponse = new UnassignUserResponse();

			unassignUserResponse.HttpResponse = _ctx.HttpResponse;
			unassignUserResponse.ErrorMessage = _ctx.StringValue("UnassignUser.ErrorMessage");
			unassignUserResponse.ErrorCode = _ctx.StringValue("UnassignUser.ErrorCode");
			unassignUserResponse.Message = _ctx.StringValue("UnassignUser.Message");
			unassignUserResponse.DynamicCode = _ctx.StringValue("UnassignUser.DynamicCode");
			unassignUserResponse.Code = _ctx.StringValue("UnassignUser.Code");
			unassignUserResponse.DynamicMessage = _ctx.StringValue("UnassignUser.DynamicMessage");
			unassignUserResponse.RequestId = _ctx.StringValue("UnassignUser.RequestId");
			unassignUserResponse.Success = _ctx.BooleanValue("UnassignUser.Success");
        
			return unassignUserResponse;
        }
    }
}
