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
using Aliyun.Acs.amqp_open.Model.V20191212;

namespace Aliyun.Acs.amqp_open.Transform.V20191212
{
    public class CreateAccountResponseUnmarshaller
    {
        public static CreateAccountResponse Unmarshall(UnmarshallerContext _ctx)
        {
			CreateAccountResponse createAccountResponse = new CreateAccountResponse();

			createAccountResponse.HttpResponse = _ctx.HttpResponse;
			createAccountResponse.RequestId = _ctx.StringValue("CreateAccount.RequestId");
			createAccountResponse.Code = _ctx.IntegerValue("CreateAccount.Code");
			createAccountResponse.Message = _ctx.StringValue("CreateAccount.Message");
			createAccountResponse.Success = _ctx.BooleanValue("CreateAccount.Success");

			CreateAccountResponse.CreateAccount_Data data = new CreateAccountResponse.CreateAccount_Data();
			data.AccessKey = _ctx.StringValue("CreateAccount.Data.AccessKey");
			data.Password = _ctx.StringValue("CreateAccount.Data.Password");
			data.CreateTimeStamp = _ctx.LongValue("CreateAccount.Data.CreateTimeStamp");
			data.InstanceId = _ctx.StringValue("CreateAccount.Data.InstanceId");
			data.MasterUId = _ctx.LongValue("CreateAccount.Data.MasterUId");
			data.UserName = _ctx.StringValue("CreateAccount.Data.UserName");
			createAccountResponse.Data = data;
        
			return createAccountResponse;
        }
    }
}
