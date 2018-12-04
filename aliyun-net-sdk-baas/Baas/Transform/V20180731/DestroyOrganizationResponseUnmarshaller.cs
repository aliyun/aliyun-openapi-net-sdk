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
    public class DestroyOrganizationResponseUnmarshaller
    {
        public static DestroyOrganizationResponse Unmarshall(UnmarshallerContext context)
        {
			DestroyOrganizationResponse destroyOrganizationResponse = new DestroyOrganizationResponse();

			destroyOrganizationResponse.HttpResponse = context.HttpResponse;
			destroyOrganizationResponse.RequestId = context.StringValue("DestroyOrganization.RequestId");
			destroyOrganizationResponse.Success = context.BooleanValue("DestroyOrganization.Success");
			destroyOrganizationResponse.ErrorCode = context.IntegerValue("DestroyOrganization.ErrorCode");
			destroyOrganizationResponse.DynamicCode = context.StringValue("DestroyOrganization.DynamicCode");
			destroyOrganizationResponse.DynamicMessage = context.StringValue("DestroyOrganization.DynamicMessage");

			DestroyOrganizationResponse.DestroyOrganization_Result result = new DestroyOrganizationResponse.DestroyOrganization_Result();
			result.OrganizationId = context.StringValue("DestroyOrganization.Result.OrganizationId");
			result.Name = context.StringValue("DestroyOrganization.Result.Name");
			destroyOrganizationResponse.Result = result;
        
			return destroyOrganizationResponse;
        }
    }
}