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
using Aliyun.Acs.NAS.Model.V20170626;

namespace Aliyun.Acs.NAS.Transform.V20170626
{
    public class DescribeAccessGroupsResponseUnmarshaller
    {
        public static DescribeAccessGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAccessGroupsResponse describeAccessGroupsResponse = new DescribeAccessGroupsResponse();

			describeAccessGroupsResponse.HttpResponse = _ctx.HttpResponse;
			describeAccessGroupsResponse.TotalCount = _ctx.IntegerValue("DescribeAccessGroups.TotalCount");
			describeAccessGroupsResponse.RequestId = _ctx.StringValue("DescribeAccessGroups.RequestId");
			describeAccessGroupsResponse.PageSize = _ctx.IntegerValue("DescribeAccessGroups.PageSize");
			describeAccessGroupsResponse.PageNumber = _ctx.IntegerValue("DescribeAccessGroups.PageNumber");

			List<DescribeAccessGroupsResponse.DescribeAccessGroups_AccessGroup> describeAccessGroupsResponse_accessGroups = new List<DescribeAccessGroupsResponse.DescribeAccessGroups_AccessGroup>();
			for (int i = 0; i < _ctx.Length("DescribeAccessGroups.AccessGroups.Length"); i++) {
				DescribeAccessGroupsResponse.DescribeAccessGroups_AccessGroup accessGroup = new DescribeAccessGroupsResponse.DescribeAccessGroups_AccessGroup();
				accessGroup.AccessGroupName = _ctx.StringValue("DescribeAccessGroups.AccessGroups["+ i +"].AccessGroupName");
				accessGroup.Description = _ctx.StringValue("DescribeAccessGroups.AccessGroups["+ i +"].Description");
				accessGroup.CreateTime = _ctx.StringValue("DescribeAccessGroups.AccessGroups["+ i +"].CreateTime");
				accessGroup.AccessGroupType = _ctx.StringValue("DescribeAccessGroups.AccessGroups["+ i +"].AccessGroupType");
				accessGroup.RuleCount = _ctx.IntegerValue("DescribeAccessGroups.AccessGroups["+ i +"].RuleCount");
				accessGroup.MountTargetCount = _ctx.IntegerValue("DescribeAccessGroups.AccessGroups["+ i +"].MountTargetCount");
				accessGroup.FileSystemType = _ctx.StringValue("DescribeAccessGroups.AccessGroups["+ i +"].FileSystemType");
				accessGroup.RegionId = _ctx.StringValue("DescribeAccessGroups.AccessGroups["+ i +"].RegionId");

				List<DescribeAccessGroupsResponse.DescribeAccessGroups_AccessGroup.DescribeAccessGroups_Tag> accessGroup_tags = new List<DescribeAccessGroupsResponse.DescribeAccessGroups_AccessGroup.DescribeAccessGroups_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeAccessGroups.AccessGroups["+ i +"].Tags.Length"); j++) {
					DescribeAccessGroupsResponse.DescribeAccessGroups_AccessGroup.DescribeAccessGroups_Tag tag = new DescribeAccessGroupsResponse.DescribeAccessGroups_AccessGroup.DescribeAccessGroups_Tag();
					tag.Key = _ctx.StringValue("DescribeAccessGroups.AccessGroups["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeAccessGroups.AccessGroups["+ i +"].Tags["+ j +"].Value");

					accessGroup_tags.Add(tag);
				}
				accessGroup.Tags = accessGroup_tags;

				describeAccessGroupsResponse_accessGroups.Add(accessGroup);
			}
			describeAccessGroupsResponse.AccessGroups = describeAccessGroupsResponse_accessGroups;
        
			return describeAccessGroupsResponse;
        }
    }
}
