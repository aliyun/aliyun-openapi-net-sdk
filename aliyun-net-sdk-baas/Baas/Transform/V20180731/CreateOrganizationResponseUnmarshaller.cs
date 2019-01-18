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
    public class CreateOrganizationResponseUnmarshaller
    {
        public static CreateOrganizationResponse Unmarshall(UnmarshallerContext context)
        {
			CreateOrganizationResponse createOrganizationResponse = new CreateOrganizationResponse();

			createOrganizationResponse.HttpResponse = context.HttpResponse;
			createOrganizationResponse.RequestId = context.StringValue("CreateOrganization.RequestId");
			createOrganizationResponse.Success = context.BooleanValue("CreateOrganization.Success");
			createOrganizationResponse.ErrorCode = context.IntegerValue("CreateOrganization.ErrorCode");

			CreateOrganizationResponse.CreateOrganization_Result result = new CreateOrganizationResponse.CreateOrganization_Result();
			result.OrganizationId = context.StringValue("CreateOrganization.Result.OrganizationId");
			result.Name = context.StringValue("CreateOrganization.Result.Name");
			result.RegionId = context.StringValue("CreateOrganization.Result.RegionId");
			result.ZoneId = context.StringValue("CreateOrganization.Result.ZoneId");
			result.CodeName = context.StringValue("CreateOrganization.Result.CodeName");
			result.Domain = context.StringValue("CreateOrganization.Result.Domain");
			result.Description = context.StringValue("CreateOrganization.Result.Description");
			result.OwnerBid = context.StringValue("CreateOrganization.Result.OwnerBid");
			result.OwnerUid = context.IntegerValue("CreateOrganization.Result.OwnerUid");
			result.OwnerName = context.StringValue("CreateOrganization.Result.OwnerName");
			result.PeerCount = context.IntegerValue("CreateOrganization.Result.PeerCount");
			result.UserCount = context.IntegerValue("CreateOrganization.Result.UserCount");
			result.ConsortiumCount = context.IntegerValue("CreateOrganization.Result.ConsortiumCount");
			result.SpecName = context.StringValue("CreateOrganization.Result.SpecName");
			result.RequestId = context.StringValue("CreateOrganization.Result.RequestId");
			result.CreateTime = context.StringValue("CreateOrganization.Result.CreateTime");
			result.ClusterState = context.StringValue("CreateOrganization.Result.ClusterState");
			result.ServiceState = context.StringValue("CreateOrganization.Result.ServiceState");
			createOrganizationResponse.Result = result;
        
			return createOrganizationResponse;
        }
    }
}