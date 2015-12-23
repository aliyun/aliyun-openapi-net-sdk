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
using Aliyun.Acs.Ecs.Model.V20151101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20151101
{
    public class OpsDescribeGroupsResponseUnmarshaller
    {
        public static OpsDescribeGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			OpsDescribeGroupsResponse opsDescribeGroupsResponse = new OpsDescribeGroupsResponse();

			opsDescribeGroupsResponse.HttpResponse = context.HttpResponse;
			opsDescribeGroupsResponse.RequestId = context.StringValue("OpsDescribeGroups.RequestId");
			opsDescribeGroupsResponse.TotalCount = context.IntegerValue("OpsDescribeGroups.TotalCount");
			opsDescribeGroupsResponse.PageNo = context.IntegerValue("OpsDescribeGroups.PageNo");
			opsDescribeGroupsResponse.PageSize = context.IntegerValue("OpsDescribeGroups.PageSize");

			List<OpsDescribeGroupsResponse.Group> groups = new List<OpsDescribeGroupsResponse.Group>();
			for (int i = 0; i < context.Length("OpsDescribeGroups.Groups.Length"); i++) {
				OpsDescribeGroupsResponse.Group group = new OpsDescribeGroupsResponse.Group();
				group.GroupId = context.StringValue("OpsDescribeGroups.Groups["+ i +"].GroupId");
				group.GroupName = context.StringValue("OpsDescribeGroups.Groups["+ i +"].GroupName");
				group.GroupDesc = context.StringValue("OpsDescribeGroups.Groups["+ i +"].GroupDesc");
				group.VpcId = context.StringValue("OpsDescribeGroups.Groups["+ i +"].VpcId");
				group.EcsInstanceCount = context.IntegerValue("OpsDescribeGroups.Groups["+ i +"].EcsInstanceCount");
				group.CreatedTime = context.StringValue("OpsDescribeGroups.Groups["+ i +"].CreatedTime");
				group.ModifiedTime = context.StringValue("OpsDescribeGroups.Groups["+ i +"].ModifiedTime");
				group.RegionNo = context.StringValue("OpsDescribeGroups.Groups["+ i +"].RegionNo");

				groups.Add(group);
			}
			opsDescribeGroupsResponse.Groups = groups;
        
			return opsDescribeGroupsResponse;
        }
    }
}