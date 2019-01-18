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
    public class DescribeOrganizationDeletableResponseUnmarshaller
    {
        public static DescribeOrganizationDeletableResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOrganizationDeletableResponse describeOrganizationDeletableResponse = new DescribeOrganizationDeletableResponse();

			describeOrganizationDeletableResponse.HttpResponse = context.HttpResponse;
			describeOrganizationDeletableResponse.RequestId = context.StringValue("DescribeOrganizationDeletable.RequestId");
			describeOrganizationDeletableResponse.Success = context.BooleanValue("DescribeOrganizationDeletable.Success");
			describeOrganizationDeletableResponse.ErrorCode = context.IntegerValue("DescribeOrganizationDeletable.ErrorCode");

			DescribeOrganizationDeletableResponse.DescribeOrganizationDeletable_Result result = new DescribeOrganizationDeletableResponse.DescribeOrganizationDeletable_Result();
			result.OrganizationId = context.StringValue("DescribeOrganizationDeletable.Result.OrganizationId");
			result.Name = context.StringValue("DescribeOrganizationDeletable.Result.Name");
			result.RegionId = context.StringValue("DescribeOrganizationDeletable.Result.RegionId");
			result.ZoneId = context.StringValue("DescribeOrganizationDeletable.Result.ZoneId");
			result.CodeName = context.StringValue("DescribeOrganizationDeletable.Result.CodeName");
			result.Domain = context.StringValue("DescribeOrganizationDeletable.Result.Domain");
			result.Description = context.StringValue("DescribeOrganizationDeletable.Result.Description");
			result.State = context.StringValue("DescribeOrganizationDeletable.Result.State");
			result.Deletable = context.BooleanValue("DescribeOrganizationDeletable.Result.Deletable");
			describeOrganizationDeletableResponse.Result = result;
        
			return describeOrganizationDeletableResponse;
        }
    }
}