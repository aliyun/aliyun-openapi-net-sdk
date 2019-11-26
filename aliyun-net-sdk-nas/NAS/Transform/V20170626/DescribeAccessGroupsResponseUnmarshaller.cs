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
        public static DescribeAccessGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAccessGroupsResponse describeAccessGroupsResponse = new DescribeAccessGroupsResponse();

			describeAccessGroupsResponse.HttpResponse = context.HttpResponse;
			describeAccessGroupsResponse.RequestId = context.StringValue("DescribeAccessGroups.RequestId");
			describeAccessGroupsResponse.TotalCount = context.IntegerValue("DescribeAccessGroups.TotalCount");
			describeAccessGroupsResponse.PageSize = context.IntegerValue("DescribeAccessGroups.PageSize");
			describeAccessGroupsResponse.PageNumber = context.IntegerValue("DescribeAccessGroups.PageNumber");

			List<DescribeAccessGroupsResponse.DescribeAccessGroups_AccessGroup> describeAccessGroupsResponse_accessGroups = new List<DescribeAccessGroupsResponse.DescribeAccessGroups_AccessGroup>();
			for (int i = 0; i < context.Length("DescribeAccessGroups.AccessGroups.Length"); i++) {
				DescribeAccessGroupsResponse.DescribeAccessGroups_AccessGroup accessGroup = new DescribeAccessGroupsResponse.DescribeAccessGroups_AccessGroup();
				accessGroup.AccessGroupName = context.StringValue("DescribeAccessGroups.AccessGroups["+ i +"].AccessGroupName");
				accessGroup.AccessGroupType = context.StringValue("DescribeAccessGroups.AccessGroups["+ i +"].AccessGroupType");
				accessGroup.RuleCount = context.IntegerValue("DescribeAccessGroups.AccessGroups["+ i +"].RuleCount");
				accessGroup.MountTargetCount = context.IntegerValue("DescribeAccessGroups.AccessGroups["+ i +"].MountTargetCount");
				accessGroup.Description = context.StringValue("DescribeAccessGroups.AccessGroups["+ i +"].Description");
				accessGroup.CreateTime = context.StringValue("DescribeAccessGroups.AccessGroups["+ i +"].CreateTime");

				List<DescribeAccessGroupsResponse.DescribeAccessGroups_AccessGroup.DescribeAccessGroups_Tag> accessGroup_tags = new List<DescribeAccessGroupsResponse.DescribeAccessGroups_AccessGroup.DescribeAccessGroups_Tag>();
				for (int j = 0; j < context.Length("DescribeAccessGroups.AccessGroups["+ i +"].Tags.Length"); j++) {
					DescribeAccessGroupsResponse.DescribeAccessGroups_AccessGroup.DescribeAccessGroups_Tag tag = new DescribeAccessGroupsResponse.DescribeAccessGroups_AccessGroup.DescribeAccessGroups_Tag();
					tag.Key = context.StringValue("DescribeAccessGroups.AccessGroups["+ i +"].Tags["+ j +"].Key");
					tag._Value = context.StringValue("DescribeAccessGroups.AccessGroups["+ i +"].Tags["+ j +"].Value");

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
