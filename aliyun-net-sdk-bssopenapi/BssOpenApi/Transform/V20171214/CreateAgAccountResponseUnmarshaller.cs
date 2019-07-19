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
using Aliyun.Acs.BssOpenApi.Model.V20171214;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class CreateAgAccountResponseUnmarshaller
    {
        public static CreateAgAccountResponse Unmarshall(UnmarshallerContext context)
        {
			CreateAgAccountResponse createAgAccountResponse = new CreateAgAccountResponse();

			createAgAccountResponse.HttpResponse = context.HttpResponse;
			createAgAccountResponse.RequestId = context.StringValue("CreateAgAccount.RequestId");
			createAgAccountResponse.Code = context.StringValue("CreateAgAccount.Code");
			createAgAccountResponse.Message = context.StringValue("CreateAgAccount.Message");
			createAgAccountResponse.Success = context.BooleanValue("CreateAgAccount.Success");

			CreateAgAccountResponse.CreateAgAccount_AgRelationDto agRelationDto = new CreateAgAccountResponse.CreateAgAccount_AgRelationDto();
			agRelationDto.Pk = context.StringValue("CreateAgAccount.AgRelationDto.Pk");
			agRelationDto.Type = context.StringValue("CreateAgAccount.AgRelationDto.Type");
			agRelationDto.Mpk = context.StringValue("CreateAgAccount.AgRelationDto.Mpk");
			agRelationDto.RamAdminRoleName = context.StringValue("CreateAgAccount.AgRelationDto.RamAdminRoleName");
			createAgAccountResponse.AgRelationDto = agRelationDto;
        
			return createAgAccountResponse;
        }
    }
}
