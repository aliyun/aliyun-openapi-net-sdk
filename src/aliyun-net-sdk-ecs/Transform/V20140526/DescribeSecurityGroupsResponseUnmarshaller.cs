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
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeSecurityGroupsResponseUnmarshaller
    {
        public static DescribeSecurityGroupsResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeSecurityGroupsResponse describeSecurityGroupsResponse = new DescribeSecurityGroupsResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeSecurityGroups.RequestId"),
                RegionId = context.StringValue("DescribeSecurityGroups.RegionId"),
                TotalCount = context.IntegerValue("DescribeSecurityGroups.TotalCount"),
                PageNumber = context.IntegerValue("DescribeSecurityGroups.PageNumber"),
                PageSize = context.IntegerValue("DescribeSecurityGroups.PageSize")
            };
            List<DescribeSecurityGroupsResponse.SecurityGroup> securityGroups = new List<DescribeSecurityGroupsResponse.SecurityGroup>();
			for (int i = 0; i < context.Length("DescribeSecurityGroups.SecurityGroups.Length"); i++) {
                DescribeSecurityGroupsResponse.SecurityGroup securityGroup = new DescribeSecurityGroupsResponse.SecurityGroup()
                {
                    SecurityGroupId = context.StringValue($"DescribeSecurityGroups.SecurityGroups[{i}].SecurityGroupId"),
                    Description = context.StringValue($"DescribeSecurityGroups.SecurityGroups[{i}].Description"),
                    SecurityGroupName = context.StringValue($"DescribeSecurityGroups.SecurityGroups[{i}].SecurityGroupName"),
                    VpcId = context.StringValue($"DescribeSecurityGroups.SecurityGroups[{i}].VpcId"),
                    CreationTime = context.StringValue($"DescribeSecurityGroups.SecurityGroups[{i}].CreationTime"),
                    EcsCount = context.IntegerValue($"DescribeSecurityGroups.SecurityGroups[{i}].EcsCount")
                };
                List<DescribeSecurityGroupsResponse.SecurityGroup.Tag> tags = new List<DescribeSecurityGroupsResponse.SecurityGroup.Tag>();
				for (int j = 0; j < context.Length($"DescribeSecurityGroups.SecurityGroups[{i}].Tags.Length"); j++) {
                    DescribeSecurityGroupsResponse.SecurityGroup.Tag tag = new DescribeSecurityGroupsResponse.SecurityGroup.Tag()
                    {
                        TagKey = context.StringValue($"DescribeSecurityGroups.SecurityGroups[{i}].Tags[{j}].TagKey"),
                        TagValue = context.StringValue($"DescribeSecurityGroups.SecurityGroups[{i}].Tags[{j}].TagValue")
                    };
                    tags.Add(tag);
				}
				securityGroup.Tags = tags;

				securityGroups.Add(securityGroup);
			}
			describeSecurityGroupsResponse.SecurityGroups = securityGroups;
        
			return describeSecurityGroupsResponse;
        }
    }
}