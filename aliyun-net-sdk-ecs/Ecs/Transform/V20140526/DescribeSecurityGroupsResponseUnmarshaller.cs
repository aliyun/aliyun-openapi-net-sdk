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
        public static DescribeSecurityGroupsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSecurityGroupsResponse describeSecurityGroupsResponse = new DescribeSecurityGroupsResponse();

			describeSecurityGroupsResponse.HttpResponse = context.HttpResponse;
			describeSecurityGroupsResponse.RequestId = context.StringValue("DescribeSecurityGroups.RequestId");
			describeSecurityGroupsResponse.RegionId = context.StringValue("DescribeSecurityGroups.RegionId");
			describeSecurityGroupsResponse.TotalCount = context.IntegerValue("DescribeSecurityGroups.TotalCount");
			describeSecurityGroupsResponse.PageNumber = context.IntegerValue("DescribeSecurityGroups.PageNumber");
			describeSecurityGroupsResponse.PageSize = context.IntegerValue("DescribeSecurityGroups.PageSize");

			List<DescribeSecurityGroupsResponse.DescribeSecurityGroups_SecurityGroup> describeSecurityGroupsResponse_securityGroups = new List<DescribeSecurityGroupsResponse.DescribeSecurityGroups_SecurityGroup>();
			for (int i = 0; i < context.Length("DescribeSecurityGroups.SecurityGroups.Length"); i++) {
				DescribeSecurityGroupsResponse.DescribeSecurityGroups_SecurityGroup securityGroup = new DescribeSecurityGroupsResponse.DescribeSecurityGroups_SecurityGroup();
				securityGroup.SecurityGroupId = context.StringValue("DescribeSecurityGroups.SecurityGroups["+ i +"].SecurityGroupId");
				securityGroup.Description = context.StringValue("DescribeSecurityGroups.SecurityGroups["+ i +"].Description");
				securityGroup.SecurityGroupName = context.StringValue("DescribeSecurityGroups.SecurityGroups["+ i +"].SecurityGroupName");
				securityGroup.VpcId = context.StringValue("DescribeSecurityGroups.SecurityGroups["+ i +"].VpcId");
				securityGroup.CreationTime = context.StringValue("DescribeSecurityGroups.SecurityGroups["+ i +"].CreationTime");
				securityGroup.SecurityGroupType = context.StringValue("DescribeSecurityGroups.SecurityGroups["+ i +"].SecurityGroupType");
				securityGroup.AvailableInstanceAmount = context.IntegerValue("DescribeSecurityGroups.SecurityGroups["+ i +"].AvailableInstanceAmount");
				securityGroup.EcsCount = context.IntegerValue("DescribeSecurityGroups.SecurityGroups["+ i +"].EcsCount");
				securityGroup.ResourceGroupId = context.StringValue("DescribeSecurityGroups.SecurityGroups["+ i +"].ResourceGroupId");
				securityGroup.ServiceID = context.LongValue("DescribeSecurityGroups.SecurityGroups["+ i +"].ServiceID");
				securityGroup.ServiceManaged = context.BooleanValue("DescribeSecurityGroups.SecurityGroups["+ i +"].ServiceManaged");

				List<DescribeSecurityGroupsResponse.DescribeSecurityGroups_SecurityGroup.DescribeSecurityGroups_Tag> securityGroup_tags = new List<DescribeSecurityGroupsResponse.DescribeSecurityGroups_SecurityGroup.DescribeSecurityGroups_Tag>();
				for (int j = 0; j < context.Length("DescribeSecurityGroups.SecurityGroups["+ i +"].Tags.Length"); j++) {
					DescribeSecurityGroupsResponse.DescribeSecurityGroups_SecurityGroup.DescribeSecurityGroups_Tag tag = new DescribeSecurityGroupsResponse.DescribeSecurityGroups_SecurityGroup.DescribeSecurityGroups_Tag();
					tag.TagKey = context.StringValue("DescribeSecurityGroups.SecurityGroups["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = context.StringValue("DescribeSecurityGroups.SecurityGroups["+ i +"].Tags["+ j +"].TagValue");

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
