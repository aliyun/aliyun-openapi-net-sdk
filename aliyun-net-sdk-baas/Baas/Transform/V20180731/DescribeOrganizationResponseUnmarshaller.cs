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
    public class DescribeOrganizationResponseUnmarshaller
    {
        public static DescribeOrganizationResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOrganizationResponse describeOrganizationResponse = new DescribeOrganizationResponse();

			describeOrganizationResponse.HttpResponse = context.HttpResponse;
			describeOrganizationResponse.RequestId = context.StringValue("DescribeOrganization.RequestId");
			describeOrganizationResponse.Success = context.BooleanValue("DescribeOrganization.Success");
			describeOrganizationResponse.ErrorCode = context.IntegerValue("DescribeOrganization.ErrorCode");

			DescribeOrganizationResponse.DescribeOrganization_Result result = new DescribeOrganizationResponse.DescribeOrganization_Result();
			result.OrganizationId = context.StringValue("DescribeOrganization.Result.OrganizationId");
			result.Name = context.StringValue("DescribeOrganization.Result.Name");
			result.RegionId = context.StringValue("DescribeOrganization.Result.RegionId");
			result.ZoneId = context.StringValue("DescribeOrganization.Result.ZoneId");
			result.CodeName = context.StringValue("DescribeOrganization.Result.CodeName");
			result.Domain = context.StringValue("DescribeOrganization.Result.Domain");
			result.Description = context.StringValue("DescribeOrganization.Result.Description");
			result.OwnerBid = context.StringValue("DescribeOrganization.Result.OwnerBid");
			result.OwnerUid = context.LongValue("DescribeOrganization.Result.OwnerUid");
			result.OwnerName = context.StringValue("DescribeOrganization.Result.OwnerName");
			result.PeerCount = context.IntegerValue("DescribeOrganization.Result.PeerCount");
			result.UserCount = context.IntegerValue("DescribeOrganization.Result.UserCount");
			result.ConsortiumCount = context.IntegerValue("DescribeOrganization.Result.ConsortiumCount");
			result.SpecName = context.StringValue("DescribeOrganization.Result.SpecName");
			result.RequestId = context.StringValue("DescribeOrganization.Result.RequestId");
			result.CreateTime = context.StringValue("DescribeOrganization.Result.CreateTime");
			result.State = context.StringValue("DescribeOrganization.Result.State");
			describeOrganizationResponse.Result = result;
        
			return describeOrganizationResponse;
        }
    }
}