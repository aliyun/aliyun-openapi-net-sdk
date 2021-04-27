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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeAllGroupsResponseUnmarshaller
    {
        public static DescribeAllGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAllGroupsResponse describeAllGroupsResponse = new DescribeAllGroupsResponse();

			describeAllGroupsResponse.HttpResponse = _ctx.HttpResponse;
			describeAllGroupsResponse.RequestId = _ctx.StringValue("DescribeAllGroups.RequestId");
			describeAllGroupsResponse.Count = _ctx.IntegerValue("DescribeAllGroups.Count");

			List<DescribeAllGroupsResponse.DescribeAllGroups_Group> describeAllGroupsResponse_groups = new List<DescribeAllGroupsResponse.DescribeAllGroups_Group>();
			for (int i = 0; i < _ctx.Length("DescribeAllGroups.Groups.Length"); i++) {
				DescribeAllGroupsResponse.DescribeAllGroups_Group group = new DescribeAllGroupsResponse.DescribeAllGroups_Group();
				group.GroupName = _ctx.StringValue("DescribeAllGroups.Groups["+ i +"].GroupName");
				group.GroupId = _ctx.IntegerValue("DescribeAllGroups.Groups["+ i +"].GroupId");
				group.GroupFlag = _ctx.IntegerValue("DescribeAllGroups.Groups["+ i +"].GroupFlag");

				describeAllGroupsResponse_groups.Add(group);
			}
			describeAllGroupsResponse.Groups = describeAllGroupsResponse_groups;
        
			return describeAllGroupsResponse;
        }
    }
}
