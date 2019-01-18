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
    public class CreateConsortiumResponseUnmarshaller
    {
        public static CreateConsortiumResponse Unmarshall(UnmarshallerContext context)
        {
			CreateConsortiumResponse createConsortiumResponse = new CreateConsortiumResponse();

			createConsortiumResponse.HttpResponse = context.HttpResponse;
			createConsortiumResponse.RequestId = context.StringValue("CreateConsortium.RequestId");
			createConsortiumResponse.Success = context.BooleanValue("CreateConsortium.Success");
			createConsortiumResponse.ErrorCode = context.IntegerValue("CreateConsortium.ErrorCode");

			CreateConsortiumResponse.CreateConsortium_Result result = new CreateConsortiumResponse.CreateConsortium_Result();
			result.ConsortiumId = context.StringValue("CreateConsortium.Result.ConsortiumId");
			result.Name = context.StringValue("CreateConsortium.Result.Name");
			result.RegionId = context.StringValue("CreateConsortium.Result.RegionId");
			result.ZoneId = context.StringValue("CreateConsortium.Result.ZoneId");
			result.CodeName = context.StringValue("CreateConsortium.Result.CodeName");
			result.Domain = context.StringValue("CreateConsortium.Result.Domain");
			result.Description = context.StringValue("CreateConsortium.Result.Description");
			result.OwnerBid = context.StringValue("CreateConsortium.Result.OwnerBid");
			result.OwnerUid = context.LongValue("CreateConsortium.Result.OwnerUid");
			result.OrdererType = context.StringValue("CreateConsortium.Result.OrdererType");
			result.ChannelPolicy = context.StringValue("CreateConsortium.Result.ChannelPolicy");
			result.OrdererCount = context.IntegerValue("CreateConsortium.Result.OrdererCount");
			result.MemberCount = context.IntegerValue("CreateConsortium.Result.MemberCount");
			result.ChannelCount = context.IntegerValue("CreateConsortium.Result.ChannelCount");
			result.SpecName = context.StringValue("CreateConsortium.Result.SpecName");
			result.ClusterState = context.StringValue("CreateConsortium.Result.ClusterState");
			result.ServiceState = context.StringValue("CreateConsortium.Result.ServiceState");
			result.CreateTime = context.StringValue("CreateConsortium.Result.CreateTime");
			createConsortiumResponse.Result = result;
        
			return createConsortiumResponse;
        }
    }
}