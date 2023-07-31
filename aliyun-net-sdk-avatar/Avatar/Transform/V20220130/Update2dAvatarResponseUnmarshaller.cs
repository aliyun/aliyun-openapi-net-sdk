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
    public class Update2dAvatarResponseUnmarshaller
    {
        public static Update2dAvatarResponse Unmarshall(UnmarshallerContext _ctx)
        {
			Update2dAvatarResponse update2dAvatarResponse = new Update2dAvatarResponse();

			update2dAvatarResponse.HttpResponse = _ctx.HttpResponse;
			update2dAvatarResponse.RequestId = _ctx.StringValue("Update2dAvatar.RequestId");
			update2dAvatarResponse.Code = _ctx.StringValue("Update2dAvatar.Code");
			update2dAvatarResponse.Message = _ctx.StringValue("Update2dAvatar.Message");
			update2dAvatarResponse.Success = _ctx.BooleanValue("Update2dAvatar.Success");

			Update2dAvatarResponse.Update2dAvatar_Data data = new Update2dAvatarResponse.Update2dAvatar_Data();
			data.Code = _ctx.StringValue("Update2dAvatar.Data.Code");
			update2dAvatarResponse.Data = data;
        
			return update2dAvatarResponse;
        }
    }
}
