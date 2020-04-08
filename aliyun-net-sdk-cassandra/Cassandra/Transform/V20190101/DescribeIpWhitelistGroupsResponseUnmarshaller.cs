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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Cassandra.Model.V20190101;

namespace Aliyun.Acs.Cassandra.Transform.V20190101
{
    public class DescribeIpWhitelistGroupsResponseUnmarshaller
    {
        public static DescribeIpWhitelistGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeIpWhitelistGroupsResponse describeIpWhitelistGroupsResponse = new DescribeIpWhitelistGroupsResponse();

			describeIpWhitelistGroupsResponse.HttpResponse = context.HttpResponse;
			describeIpWhitelistGroupsResponse.RequestId = context.StringValue("DescribeIpWhitelistGroups.RequestId");

			List<DescribeIpWhitelistGroupsResponse.DescribeIpWhitelistGroups_Group> describeIpWhitelistGroupsResponse_groups = new List<DescribeIpWhitelistGroupsResponse.DescribeIpWhitelistGroups_Group>();
			for (int i = 0; i < context.Length("DescribeIpWhitelistGroups.Groups.Length"); i++) {
				DescribeIpWhitelistGroupsResponse.DescribeIpWhitelistGroups_Group group = new DescribeIpWhitelistGroupsResponse.DescribeIpWhitelistGroups_Group();
				group.GroupName = context.StringValue("DescribeIpWhitelistGroups.Groups["+ i +"].GroupName");
				group.IpVersion = context.IntegerValue("DescribeIpWhitelistGroups.Groups["+ i +"].IpVersion");

				List<string> group_ipList = new List<string>();
				for (int j = 0; j < context.Length("DescribeIpWhitelistGroups.Groups["+ i +"].IpList.Length"); j++) {
					group_ipList.Add(context.StringValue("DescribeIpWhitelistGroups.Groups["+ i +"].IpList["+ j +"]"));
				}
				group.IpList = group_ipList;

				describeIpWhitelistGroupsResponse_groups.Add(group);
			}
			describeIpWhitelistGroupsResponse.Groups = describeIpWhitelistGroupsResponse_groups;
        
			return describeIpWhitelistGroupsResponse;
        }
    }
}
