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
    public class DescribeOrganizationMembersResponseUnmarshaller
    {
        public static DescribeOrganizationMembersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOrganizationMembersResponse describeOrganizationMembersResponse = new DescribeOrganizationMembersResponse();

			describeOrganizationMembersResponse.HttpResponse = context.HttpResponse;
			describeOrganizationMembersResponse.RequestId = context.StringValue("DescribeOrganizationMembers.RequestId");
			describeOrganizationMembersResponse.Success = context.BooleanValue("DescribeOrganizationMembers.Success");
			describeOrganizationMembersResponse.ErrorCode = context.IntegerValue("DescribeOrganizationMembers.ErrorCode");

			List<DescribeOrganizationMembersResponse.DescribeOrganizationMembers_DescribeOrganizationMembers> describeOrganizationMembersResponse_result = new List<DescribeOrganizationMembersResponse.DescribeOrganizationMembers_DescribeOrganizationMembers>();
			for (int i = 0; i < context.Length("DescribeOrganizationMembers.Result.Length"); i++) {
				DescribeOrganizationMembersResponse.DescribeOrganizationMembers_DescribeOrganizationMembers describeOrganizationMembers = new DescribeOrganizationMembersResponse.DescribeOrganizationMembers_DescribeOrganizationMembers();
				describeOrganizationMembers.Id = context.StringValue("DescribeOrganizationMembers.Result["+ i +"].Id");
				describeOrganizationMembers.Name = context.StringValue("DescribeOrganizationMembers.Result["+ i +"].Name");
				describeOrganizationMembers.ConsortiumId = context.StringValue("DescribeOrganizationMembers.Result["+ i +"].ConsortiumId");
				describeOrganizationMembers.ConsortiumName = context.StringValue("DescribeOrganizationMembers.Result["+ i +"].ConsortiumName");
				describeOrganizationMembers.Domain = context.StringValue("DescribeOrganizationMembers.Result["+ i +"].Domain");
				describeOrganizationMembers.Description = context.StringValue("DescribeOrganizationMembers.Result["+ i +"].Description");
				describeOrganizationMembers.JoinedTime = context.StringValue("DescribeOrganizationMembers.Result["+ i +"].JoinedTime");
				describeOrganizationMembers.State = context.StringValue("DescribeOrganizationMembers.Result["+ i +"].State");

				describeOrganizationMembersResponse_result.Add(describeOrganizationMembers);
			}
			describeOrganizationMembersResponse.Result = describeOrganizationMembersResponse_result;
        
			return describeOrganizationMembersResponse;
        }
    }
}