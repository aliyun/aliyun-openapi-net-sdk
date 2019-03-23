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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.CCC.Model.V20170705;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.CCC.Transform.V20170705
{
    public class CreateUserResponseUnmarshaller
    {
        public static CreateUserResponse Unmarshall(UnmarshallerContext context)
        {
            CreateUserResponse createUserResponse = new CreateUserResponse();

            createUserResponse.HttpResponse = context.HttpResponse;
            createUserResponse.RequestId = context.StringValue("CreateUser.RequestId");
            createUserResponse.Success = context.BooleanValue("CreateUser.Success");
            createUserResponse.Code = context.StringValue("CreateUser.Code");
            createUserResponse.Message = context.StringValue("CreateUser.Message");
            createUserResponse.HttpStatusCode = context.IntegerValue("CreateUser.HttpStatusCode");
            createUserResponse.UserId = context.StringValue("CreateUser.UserId");

            return createUserResponse;
        }
    }
}