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
    public class DescribeOrganizationUsersResponseUnmarshaller
    {
        public static DescribeOrganizationUsersResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeOrganizationUsersResponse describeOrganizationUsersResponse = new DescribeOrganizationUsersResponse();

			describeOrganizationUsersResponse.HttpResponse = context.HttpResponse;
			describeOrganizationUsersResponse.RequestId = context.StringValue("DescribeOrganizationUsers.RequestId");
			describeOrganizationUsersResponse.Success = context.BooleanValue("DescribeOrganizationUsers.Success");
			describeOrganizationUsersResponse.ErrorCode = context.IntegerValue("DescribeOrganizationUsers.ErrorCode");

			List<DescribeOrganizationUsersResponse.DescribeOrganizationUsers_ResultItem> describeOrganizationUsersResponse_result = new List<DescribeOrganizationUsersResponse.DescribeOrganizationUsers_ResultItem>();
			for (int i = 0; i < context.Length("DescribeOrganizationUsers.Result.Length"); i++) {
				DescribeOrganizationUsersResponse.DescribeOrganizationUsers_ResultItem resultItem = new DescribeOrganizationUsersResponse.DescribeOrganizationUsers_ResultItem();
				resultItem.CallerBid = context.StringValue("DescribeOrganizationUsers.Result["+ i +"].CallerBid");
				resultItem.CallerUid = context.LongValue("DescribeOrganizationUsers.Result["+ i +"].CallerUid");
				resultItem.RegionId = context.StringValue("DescribeOrganizationUsers.Result["+ i +"].RegionId");
				resultItem.OrganizationId = context.StringValue("DescribeOrganizationUsers.Result["+ i +"].OrganizationId");
				resultItem.Username = context.StringValue("DescribeOrganizationUsers.Result["+ i +"].Username");
				resultItem.FullName = context.StringValue("DescribeOrganizationUsers.Result["+ i +"].FullName");
				resultItem.CreateTime = context.StringValue("DescribeOrganizationUsers.Result["+ i +"].CreateTime");
				resultItem.ExpireTime = context.StringValue("DescribeOrganizationUsers.Result["+ i +"].ExpireTime");

				describeOrganizationUsersResponse_result.Add(resultItem);
			}
			describeOrganizationUsersResponse.Result = describeOrganizationUsersResponse_result;
        
			return describeOrganizationUsersResponse;
        }
    }
}