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
using Aliyun.Acs.BssOpenApi.Model.V20171214;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.BssOpenApi.Transform.V20171214
{
    public class CreateUserQuotaResponseUnmarshaller
    {
        public static CreateUserQuotaResponse Unmarshall(UnmarshallerContext context)
        {
			CreateUserQuotaResponse createUserQuotaResponse = new CreateUserQuotaResponse();

			createUserQuotaResponse.HttpResponse = context.HttpResponse;
			createUserQuotaResponse.RequestId = context.StringValue("CreateUserQuota.RequestId");
			createUserQuotaResponse.Code = context.StringValue("CreateUserQuota.Code");
			createUserQuotaResponse.Message = context.StringValue("CreateUserQuota.Message");
			createUserQuotaResponse.Success = context.BooleanValue("CreateUserQuota.Success");
			createUserQuotaResponse.Data = context.BooleanValue("CreateUserQuota.Data");
        
			return createUserQuotaResponse;
        }
    }
}