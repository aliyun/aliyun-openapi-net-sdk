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
using Aliyun.Acs.Vcs.Model.V20200515;

namespace Aliyun.Acs.Vcs.Transform.V20200515
{
    public class CreateUserResponseUnmarshaller
    {
        public static CreateUserResponse Unmarshall(UnmarshallerContext context)
        {
			CreateUserResponse createUserResponse = new CreateUserResponse();

			createUserResponse.HttpResponse = context.HttpResponse;
			createUserResponse.Code = context.StringValue("CreateUser.Code");
			createUserResponse.Message = context.StringValue("CreateUser.Message");
			createUserResponse.RequestId = context.StringValue("CreateUser.RequestId");

			CreateUserResponse.CreateUser_Data data = new CreateUserResponse.CreateUser_Data();
			data.UserId = context.IntegerValue("CreateUser.Data.UserId");
			data.IsvSubId = context.StringValue("CreateUser.Data.IsvSubId");
			data.UserName = context.StringValue("CreateUser.Data.UserName");
			data.UserGroupId = context.IntegerValue("CreateUser.Data.UserGroupId");
			data.IdNumber = context.StringValue("CreateUser.Data.IdNumber");
			data.FaceImageUrl = context.StringValue("CreateUser.Data.FaceImageUrl");
			data.Address = context.StringValue("CreateUser.Data.Address");
			data.Age = context.StringValue("CreateUser.Data.Age");
			data.Gender = context.StringValue("CreateUser.Data.Gender");
			data.PlateNo = context.StringValue("CreateUser.Data.PlateNo");
			data.PhoneNo = context.StringValue("CreateUser.Data.PhoneNo");
			data.Attachment = context.StringValue("CreateUser.Data.Attachment");
			data.BizId = context.StringValue("CreateUser.Data.BizId");
			createUserResponse.Data = data;
        
			return createUserResponse;
        }
    }
}
