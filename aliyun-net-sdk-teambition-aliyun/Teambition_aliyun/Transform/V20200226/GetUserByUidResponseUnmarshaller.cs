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
using Aliyun.Acs.teambition_aliyun.Model.V20200226;

namespace Aliyun.Acs.teambition_aliyun.Transform.V20200226
{
    public class GetUserByUidResponseUnmarshaller
    {
        public static GetUserByUidResponse Unmarshall(UnmarshallerContext context)
        {
			GetUserByUidResponse getUserByUidResponse = new GetUserByUidResponse();

			getUserByUidResponse.HttpResponse = context.HttpResponse;
			getUserByUidResponse.Successful = context.BooleanValue("GetUserByUid.Successful");
			getUserByUidResponse.ErrorCode = context.StringValue("GetUserByUid.ErrorCode");
			getUserByUidResponse.ErrorMsg = context.StringValue("GetUserByUid.ErrorMsg");
			getUserByUidResponse.RequestId = context.StringValue("GetUserByUid.RequestId");

			GetUserByUidResponse.GetUserByUid__Object _object = new GetUserByUidResponse.GetUserByUid__Object();
			_object.Name = context.StringValue("GetUserByUid.Object.Name");
			_object.Id = context.StringValue("GetUserByUid.Object.Id");
			_object.AliyunPk = context.StringValue("GetUserByUid.Object.AliyunPk");
			_object.AvatarUrl = context.StringValue("GetUserByUid.Object.AvatarUrl");
			_object.Email = context.StringValue("GetUserByUid.Object.Email");
			_object.Phone = context.StringValue("GetUserByUid.Object.Phone");
			getUserByUidResponse._Object = _object;
        
			return getUserByUidResponse;
        }
    }
}
