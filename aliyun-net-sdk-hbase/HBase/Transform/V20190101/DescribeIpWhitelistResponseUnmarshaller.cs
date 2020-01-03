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
using Aliyun.Acs.HBase.Model.V20190101;

namespace Aliyun.Acs.HBase.Transform.V20190101
{
    public class DescribeIpWhitelistResponseUnmarshaller
    {
        public static DescribeIpWhitelistResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeIpWhitelistResponse describeIpWhitelistResponse = new DescribeIpWhitelistResponse();

			describeIpWhitelistResponse.HttpResponse = context.HttpResponse;
			describeIpWhitelistResponse.RequestId = context.StringValue("DescribeIpWhitelist.RequestId");

			List<DescribeIpWhitelistResponse.DescribeIpWhitelist_Group> describeIpWhitelistResponse_groups = new List<DescribeIpWhitelistResponse.DescribeIpWhitelist_Group>();
			for (int i = 0; i < context.Length("DescribeIpWhitelist.Groups.Length"); i++) {
				DescribeIpWhitelistResponse.DescribeIpWhitelist_Group group = new DescribeIpWhitelistResponse.DescribeIpWhitelist_Group();
				group.GroupName = context.StringValue("DescribeIpWhitelist.Groups["+ i +"].GroupName");
				group.IpVersion = context.IntegerValue("DescribeIpWhitelist.Groups["+ i +"].IpVersion");

				List<string> group_ipList = new List<string>();
				for (int j = 0; j < context.Length("DescribeIpWhitelist.Groups["+ i +"].IpList.Length"); j++) {
					group_ipList.Add(context.StringValue("DescribeIpWhitelist.Groups["+ i +"].IpList["+ j +"]"));
				}
				group.IpList = group_ipList;

				describeIpWhitelistResponse_groups.Add(group);
			}
			describeIpWhitelistResponse.Groups = describeIpWhitelistResponse_groups;
        
			return describeIpWhitelistResponse;
        }
    }
}
