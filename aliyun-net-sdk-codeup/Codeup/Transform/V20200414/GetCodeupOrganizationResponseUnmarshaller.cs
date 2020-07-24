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
using Aliyun.Acs.codeup.Model.V20200414;

namespace Aliyun.Acs.codeup.Transform.V20200414
{
    public class GetCodeupOrganizationResponseUnmarshaller
    {
        public static GetCodeupOrganizationResponse Unmarshall(UnmarshallerContext context)
        {
			GetCodeupOrganizationResponse getCodeupOrganizationResponse = new GetCodeupOrganizationResponse();

			getCodeupOrganizationResponse.HttpResponse = context.HttpResponse;
			getCodeupOrganizationResponse.RequestId = context.StringValue("GetCodeupOrganization.RequestId");
			getCodeupOrganizationResponse.ErrorCode = context.StringValue("GetCodeupOrganization.ErrorCode");
			getCodeupOrganizationResponse.Success = context.BooleanValue("GetCodeupOrganization.Success");
			getCodeupOrganizationResponse.ErrorMessage = context.StringValue("GetCodeupOrganization.ErrorMessage");

			GetCodeupOrganizationResponse.GetCodeupOrganization_Result result = new GetCodeupOrganizationResponse.GetCodeupOrganization_Result();
			result.Id = context.LongValue("GetCodeupOrganization.Result.Id");
			result.OrganizationId = context.StringValue("GetCodeupOrganization.Result.OrganizationId");
			result.Path = context.StringValue("GetCodeupOrganization.Result.Path");
			result.CreatedAt = context.StringValue("GetCodeupOrganization.Result.CreatedAt");
			result.UpdatedAt = context.StringValue("GetCodeupOrganization.Result.UpdatedAt");
			result.NamespaceId = context.LongValue("GetCodeupOrganization.Result.NamespaceId");
			result.UserRole = context.StringValue("GetCodeupOrganization.Result.UserRole");
			getCodeupOrganizationResponse.Result = result;
        
			return getCodeupOrganizationResponse;
        }
    }
}
