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
using Aliyun.Acs.devops_rdc.Model.V20200303;

namespace Aliyun.Acs.devops_rdc.Transform.V20200303
{
    public class GetUserByAliyunUidResponseUnmarshaller
    {
        public static GetUserByAliyunUidResponse Unmarshall(UnmarshallerContext context)
        {
			GetUserByAliyunUidResponse getUserByAliyunUidResponse = new GetUserByAliyunUidResponse();

			getUserByAliyunUidResponse.HttpResponse = context.HttpResponse;
			getUserByAliyunUidResponse.Successful = context.BooleanValue("GetUserByAliyunUid.Successful");
			getUserByAliyunUidResponse.ErrorCode = context.StringValue("GetUserByAliyunUid.ErrorCode");
			getUserByAliyunUidResponse.ErrorMsg = context.StringValue("GetUserByAliyunUid.ErrorMsg");
			getUserByAliyunUidResponse.RequestId = context.StringValue("GetUserByAliyunUid.RequestId");

			GetUserByAliyunUidResponse.GetUserByAliyunUid__Object _object = new GetUserByAliyunUidResponse.GetUserByAliyunUid__Object();
			_object.Name = context.StringValue("GetUserByAliyunUid.Object.Name");
			_object.Id = context.StringValue("GetUserByAliyunUid.Object.Id");
			_object.AliyunPk = context.StringValue("GetUserByAliyunUid.Object.AliyunPk");
			_object.AvatarUrl = context.StringValue("GetUserByAliyunUid.Object.AvatarUrl");
			_object.Email = context.StringValue("GetUserByAliyunUid.Object.Email");
			_object.Phone = context.StringValue("GetUserByAliyunUid.Object.Phone");
			getUserByAliyunUidResponse._Object = _object;
        
			return getUserByAliyunUidResponse;
        }
    }
}
