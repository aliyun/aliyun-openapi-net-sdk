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
using Aliyun.Acs.avatar.Model.V20220130;

namespace Aliyun.Acs.avatar.Transform.V20220130
{
    public class Create2dAvatarResponseUnmarshaller
    {
        public static Create2dAvatarResponse Unmarshall(UnmarshallerContext _ctx)
        {
			Create2dAvatarResponse create2dAvatarResponse = new Create2dAvatarResponse();

			create2dAvatarResponse.HttpResponse = _ctx.HttpResponse;
			create2dAvatarResponse.RequestId = _ctx.StringValue("Create2dAvatar.RequestId");
			create2dAvatarResponse.Code = _ctx.StringValue("Create2dAvatar.Code");
			create2dAvatarResponse.Message = _ctx.StringValue("Create2dAvatar.Message");
			create2dAvatarResponse.Success = _ctx.BooleanValue("Create2dAvatar.Success");

			Create2dAvatarResponse.Create2dAvatar_Data data = new Create2dAvatarResponse.Create2dAvatar_Data();
			data.Code = _ctx.StringValue("Create2dAvatar.Data.Code");
			create2dAvatarResponse.Data = data;
        
			return create2dAvatarResponse;
        }
    }
}
