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
    public class DescribeConsortiumMembersResponseUnmarshaller
    {
        public static DescribeConsortiumMembersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeConsortiumMembersResponse describeConsortiumMembersResponse = new DescribeConsortiumMembersResponse();

			describeConsortiumMembersResponse.HttpResponse = context.HttpResponse;
			describeConsortiumMembersResponse.RequestId = context.StringValue("DescribeConsortiumMembers.RequestId");
			describeConsortiumMembersResponse.Success = context.BooleanValue("DescribeConsortiumMembers.Success");
			describeConsortiumMembersResponse.ErrorCode = context.IntegerValue("DescribeConsortiumMembers.ErrorCode");

			List<DescribeConsortiumMembersResponse.DescribeConsortiumMembers_DescribeConsortiumMember> describeConsortiumMembersResponse_result = new List<DescribeConsortiumMembersResponse.DescribeConsortiumMembers_DescribeConsortiumMember>();
			for (int i = 0; i < context.Length("DescribeConsortiumMembers.Result.Length"); i++) {
				DescribeConsortiumMembersResponse.DescribeConsortiumMembers_DescribeConsortiumMember describeConsortiumMember = new DescribeConsortiumMembersResponse.DescribeConsortiumMembers_DescribeConsortiumMember();
				describeConsortiumMember.Name = context.StringValue("DescribeConsortiumMembers.Result["+ i +"].Name");
				describeConsortiumMember.Domain = context.StringValue("DescribeConsortiumMembers.Result["+ i +"].Domain");
				describeConsortiumMember.Description = context.StringValue("DescribeConsortiumMembers.Result["+ i +"].Description");
				describeConsortiumMember.JoinedTime = context.StringValue("DescribeConsortiumMembers.Result["+ i +"].JoinedTime");
				describeConsortiumMember.ConsortiumId = context.StringValue("DescribeConsortiumMembers.Result["+ i +"].ConsortiumId");
				describeConsortiumMember.OrganizationId = context.StringValue("DescribeConsortiumMembers.Result["+ i +"].OrganizationId");

				describeConsortiumMembersResponse_result.Add(describeConsortiumMember);
			}
			describeConsortiumMembersResponse.Result = describeConsortiumMembersResponse_result;
        
			return describeConsortiumMembersResponse;
        }
    }
}