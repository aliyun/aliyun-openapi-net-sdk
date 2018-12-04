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
    public class DescribeChannelMembersResponseUnmarshaller
    {
        public static DescribeChannelMembersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeChannelMembersResponse describeChannelMembersResponse = new DescribeChannelMembersResponse();

			describeChannelMembersResponse.HttpResponse = context.HttpResponse;
			describeChannelMembersResponse.RequestId = context.StringValue("DescribeChannelMembers.RequestId");
			describeChannelMembersResponse.Success = context.BooleanValue("DescribeChannelMembers.Success");
			describeChannelMembersResponse.ErrorCode = context.IntegerValue("DescribeChannelMembers.ErrorCode");

			List<DescribeChannelMembersResponse.DescribeChannelMembers_ResultItem> describeChannelMembersResponse_result = new List<DescribeChannelMembersResponse.DescribeChannelMembers_ResultItem>();
			for (int i = 0; i < context.Length("DescribeChannelMembers.Result.Length"); i++) {
				DescribeChannelMembersResponse.DescribeChannelMembers_ResultItem resultItem = new DescribeChannelMembersResponse.DescribeChannelMembers_ResultItem();
				resultItem.ChannelId = context.StringValue("DescribeChannelMembers.Result["+ i +"].ChannelId");
				resultItem.OrganizationId = context.StringValue("DescribeChannelMembers.Result["+ i +"].OrganizationId");
				resultItem.WithPeer = context.BooleanValue("DescribeChannelMembers.Result["+ i +"].WithPeer");
				resultItem.State = context.StringValue("DescribeChannelMembers.Result["+ i +"].State");
				resultItem.InviteTime = context.StringValue("DescribeChannelMembers.Result["+ i +"].InviteTime");
				resultItem.AcceptTime = context.StringValue("DescribeChannelMembers.Result["+ i +"].AcceptTime");
				resultItem.Name = context.StringValue("DescribeChannelMembers.Result["+ i +"].Name");
				resultItem.Domain = context.StringValue("DescribeChannelMembers.Result["+ i +"].Domain");
				resultItem.Description = context.StringValue("DescribeChannelMembers.Result["+ i +"].Description");

				describeChannelMembersResponse_result.Add(resultItem);
			}
			describeChannelMembersResponse.Result = describeChannelMembersResponse_result;
        
			return describeChannelMembersResponse;
        }
    }
}