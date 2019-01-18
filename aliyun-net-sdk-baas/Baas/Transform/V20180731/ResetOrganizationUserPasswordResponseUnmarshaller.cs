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
using Aliyun.Acs.Baas.Model.V20180731;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Baas.Transform.V20180731
{
    public class ResetOrganizationUserPasswordResponseUnmarshaller
    {
        public static ResetOrganizationUserPasswordResponse Unmarshall(UnmarshallerContext context)
        {
			ResetOrganizationUserPasswordResponse resetOrganizationUserPasswordResponse = new ResetOrganizationUserPasswordResponse();

			resetOrganizationUserPasswordResponse.HttpResponse = context.HttpResponse;
			resetOrganizationUserPasswordResponse.RequestId = context.StringValue("ResetOrganizationUserPassword.RequestId");
			resetOrganizationUserPasswordResponse.Success = context.BooleanValue("ResetOrganizationUserPassword.Success");
			resetOrganizationUserPasswordResponse.ErrorCode = context.IntegerValue("ResetOrganizationUserPassword.ErrorCode");

			ResetOrganizationUserPasswordResponse.ResetOrganizationUserPassword_Result result = new ResetOrganizationUserPasswordResponse.ResetOrganizationUserPassword_Result();
			result.OrganizationId = context.StringValue("ResetOrganizationUserPassword.Result.OrganizationId");
			result.Username = context.StringValue("ResetOrganizationUserPassword.Result.Username");
			result.Password = context.StringValue("ResetOrganizationUserPassword.Result.Password");
			result.Fullname = context.StringValue("ResetOrganizationUserPassword.Result.Fullname");
			result.CreateTime = context.StringValue("ResetOrganizationUserPassword.Result.CreateTime");
			result.ExpireTime = context.StringValue("ResetOrganizationUserPassword.Result.ExpireTime");
			resetOrganizationUserPasswordResponse.Result = result;
        
			return resetOrganizationUserPasswordResponse;
        }
    }
}