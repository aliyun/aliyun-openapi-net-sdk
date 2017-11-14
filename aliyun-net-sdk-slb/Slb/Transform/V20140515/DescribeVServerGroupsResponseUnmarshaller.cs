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
using Aliyun.Acs.Slb.Model.V20140515;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Slb.Transform.V20140515
{
    public class DescribeVServerGroupsResponseUnmarshaller
    {
        public static DescribeVServerGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVServerGroupsResponse describeVServerGroupsResponse = new DescribeVServerGroupsResponse();

			describeVServerGroupsResponse.HttpResponse = context.HttpResponse;
			describeVServerGroupsResponse.RequestId = context.StringValue("DescribeVServerGroups.RequestId");

			List<DescribeVServerGroupsResponse.DescribeVServerGroups_VServerGroup> describeVServerGroupsResponse_vServerGroups = new List<DescribeVServerGroupsResponse.DescribeVServerGroups_VServerGroup>();
			for (int i = 0; i < context.Length("DescribeVServerGroups.VServerGroups.Length"); i++) {
				DescribeVServerGroupsResponse.DescribeVServerGroups_VServerGroup vServerGroup = new DescribeVServerGroupsResponse.DescribeVServerGroups_VServerGroup();
				vServerGroup.VServerGroupId = context.StringValue("DescribeVServerGroups.VServerGroups["+ i +"].VServerGroupId");
				vServerGroup.VServerGroupName = context.StringValue("DescribeVServerGroups.VServerGroups["+ i +"].VServerGroupName");

				describeVServerGroupsResponse_vServerGroups.Add(vServerGroup);
			}
			describeVServerGroupsResponse.VServerGroups = describeVServerGroupsResponse_vServerGroups;
        
			return describeVServerGroupsResponse;
        }
    }
}