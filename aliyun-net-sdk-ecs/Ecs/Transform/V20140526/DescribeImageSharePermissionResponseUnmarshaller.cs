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
using Aliyun.Acs.Ecs.Model.V20140526;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeImageSharePermissionResponseUnmarshaller
    {
        public static DescribeImageSharePermissionResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeImageSharePermissionResponse describeImageSharePermissionResponse = new DescribeImageSharePermissionResponse();

			describeImageSharePermissionResponse.HttpResponse = context.HttpResponse;
			describeImageSharePermissionResponse.RequestId = context.StringValue("DescribeImageSharePermission.RequestId");
			describeImageSharePermissionResponse.RegionId = context.StringValue("DescribeImageSharePermission.RegionId");
			describeImageSharePermissionResponse.TotalCount = context.IntegerValue("DescribeImageSharePermission.TotalCount");
			describeImageSharePermissionResponse.PageNumber = context.IntegerValue("DescribeImageSharePermission.PageNumber");
			describeImageSharePermissionResponse.PageSize = context.IntegerValue("DescribeImageSharePermission.PageSize");
			describeImageSharePermissionResponse.ImageId = context.StringValue("DescribeImageSharePermission.ImageId");

			List<DescribeImageSharePermissionResponse.ShareGroup> shareGroups = new List<DescribeImageSharePermissionResponse.ShareGroup>();
			for (int i = 0; i < context.Length("DescribeImageSharePermission.ShareGroups.Length"); i++) {
				DescribeImageSharePermissionResponse.ShareGroup shareGroup = new DescribeImageSharePermissionResponse.ShareGroup();
				shareGroup.Group = context.StringValue("DescribeImageSharePermission.ShareGroups["+ i +"].Group");

				shareGroups.Add(shareGroup);
			}
			describeImageSharePermissionResponse.ShareGroups = shareGroups;

			List<DescribeImageSharePermissionResponse.Account> accounts = new List<DescribeImageSharePermissionResponse.Account>();
			for (int i = 0; i < context.Length("DescribeImageSharePermission.Accounts.Length"); i++) {
				DescribeImageSharePermissionResponse.Account account = new DescribeImageSharePermissionResponse.Account();
				account.AliyunId = context.StringValue("DescribeImageSharePermission.Accounts["+ i +"].AliyunId");

				accounts.Add(account);
			}
			describeImageSharePermissionResponse.Accounts = accounts;
        
			return describeImageSharePermissionResponse;
        }
    }
}