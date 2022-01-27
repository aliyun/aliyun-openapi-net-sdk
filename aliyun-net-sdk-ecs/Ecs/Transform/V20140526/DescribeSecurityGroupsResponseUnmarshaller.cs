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
using Aliyun.Acs.Ecs.Model.V20140526;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeSecurityGroupsResponseUnmarshaller
    {
        public static DescribeSecurityGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSecurityGroupsResponse describeSecurityGroupsResponse = new DescribeSecurityGroupsResponse();

			describeSecurityGroupsResponse.HttpResponse = _ctx.HttpResponse;
			describeSecurityGroupsResponse.PageSize = _ctx.IntegerValue("DescribeSecurityGroups.PageSize");
			describeSecurityGroupsResponse.PageNumber = _ctx.IntegerValue("DescribeSecurityGroups.PageNumber");
			describeSecurityGroupsResponse.RequestId = _ctx.StringValue("DescribeSecurityGroups.RequestId");
			describeSecurityGroupsResponse.TotalCount = _ctx.IntegerValue("DescribeSecurityGroups.TotalCount");
			describeSecurityGroupsResponse.RegionId = _ctx.StringValue("DescribeSecurityGroups.RegionId");
			describeSecurityGroupsResponse.NextToken = _ctx.StringValue("DescribeSecurityGroups.NextToken");

			List<DescribeSecurityGroupsResponse.DescribeSecurityGroups_SecurityGroup> describeSecurityGroupsResponse_securityGroups = new List<DescribeSecurityGroupsResponse.DescribeSecurityGroups_SecurityGroup>();
			for (int i = 0; i < _ctx.Length("DescribeSecurityGroups.SecurityGroups.Length"); i++) {
				DescribeSecurityGroupsResponse.DescribeSecurityGroups_SecurityGroup securityGroup = new DescribeSecurityGroupsResponse.DescribeSecurityGroups_SecurityGroup();
				securityGroup.CreationTime = _ctx.StringValue("DescribeSecurityGroups.SecurityGroups["+ i +"].CreationTime");
				securityGroup.VpcId = _ctx.StringValue("DescribeSecurityGroups.SecurityGroups["+ i +"].VpcId");
				securityGroup.ServiceManaged = _ctx.BooleanValue("DescribeSecurityGroups.SecurityGroups["+ i +"].ServiceManaged");
				securityGroup.Description = _ctx.StringValue("DescribeSecurityGroups.SecurityGroups["+ i +"].Description");
				securityGroup.SecurityGroupId = _ctx.StringValue("DescribeSecurityGroups.SecurityGroups["+ i +"].SecurityGroupId");
				securityGroup.ResourceGroupId = _ctx.StringValue("DescribeSecurityGroups.SecurityGroups["+ i +"].ResourceGroupId");
				securityGroup.SecurityGroupName = _ctx.StringValue("DescribeSecurityGroups.SecurityGroups["+ i +"].SecurityGroupName");
				securityGroup.EcsCount = _ctx.IntegerValue("DescribeSecurityGroups.SecurityGroups["+ i +"].EcsCount");
				securityGroup.ServiceID = _ctx.LongValue("DescribeSecurityGroups.SecurityGroups["+ i +"].ServiceID");
				securityGroup.SecurityGroupType = _ctx.StringValue("DescribeSecurityGroups.SecurityGroups["+ i +"].SecurityGroupType");
				securityGroup.AvailableInstanceAmount = _ctx.IntegerValue("DescribeSecurityGroups.SecurityGroups["+ i +"].AvailableInstanceAmount");

				List<DescribeSecurityGroupsResponse.DescribeSecurityGroups_SecurityGroup.DescribeSecurityGroups_Tag> securityGroup_tags = new List<DescribeSecurityGroupsResponse.DescribeSecurityGroups_SecurityGroup.DescribeSecurityGroups_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeSecurityGroups.SecurityGroups["+ i +"].Tags.Length"); j++) {
					DescribeSecurityGroupsResponse.DescribeSecurityGroups_SecurityGroup.DescribeSecurityGroups_Tag tag = new DescribeSecurityGroupsResponse.DescribeSecurityGroups_SecurityGroup.DescribeSecurityGroups_Tag();
					tag.TagValue = _ctx.StringValue("DescribeSecurityGroups.SecurityGroups["+ i +"].Tags["+ j +"].TagValue");
					tag.TagKey = _ctx.StringValue("DescribeSecurityGroups.SecurityGroups["+ i +"].Tags["+ j +"].TagKey");

					securityGroup_tags.Add(tag);
				}
				securityGroup.Tags = securityGroup_tags;

				describeSecurityGroupsResponse_securityGroups.Add(securityGroup);
			}
			describeSecurityGroupsResponse.SecurityGroups = describeSecurityGroupsResponse_securityGroups;
        
			return describeSecurityGroupsResponse;
        }
    }
}
