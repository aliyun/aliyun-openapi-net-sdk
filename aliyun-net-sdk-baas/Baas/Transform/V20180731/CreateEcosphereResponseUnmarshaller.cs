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
    public class CreateEcosphereResponseUnmarshaller
    {
        public static CreateEcosphereResponse Unmarshall(UnmarshallerContext context)
        {
			CreateEcosphereResponse createEcosphereResponse = new CreateEcosphereResponse();

			createEcosphereResponse.HttpResponse = context.HttpResponse;
			createEcosphereResponse.RequestId = context.StringValue("CreateEcosphere.RequestId");
			createEcosphereResponse.Success = context.BooleanValue("CreateEcosphere.Success");
			createEcosphereResponse.ErrorCode = context.IntegerValue("CreateEcosphere.ErrorCode");
			createEcosphereResponse.ErrorMessage = context.StringValue("CreateEcosphere.ErrorMessage");

			CreateEcosphereResponse.CreateEcosphere_Result result = new CreateEcosphereResponse.CreateEcosphere_Result();
			result.ConsortiumId = context.StringValue("CreateEcosphere.Result.ConsortiumId");
			result.Name = context.StringValue("CreateEcosphere.Result.Name");
			result.RegionId = context.StringValue("CreateEcosphere.Result.RegionId");
			result.ZoneId = context.StringValue("CreateEcosphere.Result.ZoneId");
			result.Code = context.StringValue("CreateEcosphere.Result.Code");
			result.Domain = context.StringValue("CreateEcosphere.Result.Domain");
			result.Description = context.StringValue("CreateEcosphere.Result.Description");
			result.OwnerBid = context.StringValue("CreateEcosphere.Result.OwnerBid");
			result.OwnerUid = context.LongValue("CreateEcosphere.Result.OwnerUid");
			result.OrdererType = context.StringValue("CreateEcosphere.Result.OrdererType");
			result.ChannelPolicy = context.StringValue("CreateEcosphere.Result.ChannelPolicy");
			result.OrdererCount = context.IntegerValue("CreateEcosphere.Result.OrdererCount");
			result.MemberCount = context.IntegerValue("CreateEcosphere.Result.MemberCount");
			result.ChannelCount = context.IntegerValue("CreateEcosphere.Result.ChannelCount");
			result.SpecName = context.StringValue("CreateEcosphere.Result.SpecName");
			result.ClusterState = context.StringValue("CreateEcosphere.Result.ClusterState");
			result.ServiceState = context.StringValue("CreateEcosphere.Result.ServiceState");
			result.CreateTime = context.StringValue("CreateEcosphere.Result.CreateTime");

			CreateEcosphereResponse.CreateEcosphere_Result.CreateEcosphere_Specification specification = new CreateEcosphereResponse.CreateEcosphere_Result.CreateEcosphere_Specification();
			specification.Name = context.StringValue("CreateEcosphere.Result.Specification.Name");
			specification.Title = context.StringValue("CreateEcosphere.Result.Specification.Title");
			specification.NumOfNodes = context.IntegerValue("CreateEcosphere.Result.Specification.NumOfNodes");
			result.Specification = specification;

			List<CreateEcosphereResponse.CreateEcosphere_Result.CreateEcosphere_Organization> result_organizations = new List<CreateEcosphereResponse.CreateEcosphere_Result.CreateEcosphere_Organization>();
			for (int i = 0; i < context.Length("CreateEcosphere.Result.Organizations.Length"); i++) {
				CreateEcosphereResponse.CreateEcosphere_Result.CreateEcosphere_Organization organization = new CreateEcosphereResponse.CreateEcosphere_Result.CreateEcosphere_Organization();
				organization.Name = context.StringValue("CreateEcosphere.Result.Organizations["+ i +"].Name");
				organization.Code = context.StringValue("CreateEcosphere.Result.Organizations["+ i +"].Code");
				organization.Domain = context.StringValue("CreateEcosphere.Result.Organizations["+ i +"].Domain");
				organization.Description = context.StringValue("CreateEcosphere.Result.Organizations["+ i +"].Description");
				organization.ClusterState = context.StringValue("CreateEcosphere.Result.Organizations["+ i +"].ClusterState");
				organization.ServiceState = context.StringValue("CreateEcosphere.Result.Organizations["+ i +"].ServiceState");
				organization.CreateTime = context.StringValue("CreateEcosphere.Result.Organizations["+ i +"].CreateTime");

				result_organizations.Add(organization);
			}
			result.Organizations = result_organizations;
			createEcosphereResponse.Result = result;
        
			return createEcosphereResponse;
        }
    }
}