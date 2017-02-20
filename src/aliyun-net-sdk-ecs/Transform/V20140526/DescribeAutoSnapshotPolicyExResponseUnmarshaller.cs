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
    public class DescribeAutoSnapshotPolicyExResponseUnmarshaller
    {
        public static DescribeAutoSnapshotPolicyExResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeAutoSnapshotPolicyExResponse describeAutoSnapshotPolicyExResponse = new DescribeAutoSnapshotPolicyExResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeAutoSnapshotPolicyEx.RequestId"),
                TotalCount = context.IntegerValue("DescribeAutoSnapshotPolicyEx.TotalCount"),
                PageNumber = context.IntegerValue("DescribeAutoSnapshotPolicyEx.PageNumber"),
                PageSize = context.IntegerValue("DescribeAutoSnapshotPolicyEx.PageSize")
            };
            List<DescribeAutoSnapshotPolicyExResponse.AutoSnapshotPolicy> autoSnapshotPolicies = new List<DescribeAutoSnapshotPolicyExResponse.AutoSnapshotPolicy>();
			for (int i = 0; i < context.Length("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies.Length"); i++) {
                DescribeAutoSnapshotPolicyExResponse.AutoSnapshotPolicy autoSnapshotPolicy = new DescribeAutoSnapshotPolicyExResponse.AutoSnapshotPolicy()
                {
                    AutoSnapshotPolicyId = context.IntegerValue($"DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies[{i}].AutoSnapshotPolicyId"),
                    RegionId = context.StringValue($"DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies[{i}].RegionId"),
                    AutoSnapshotPolicyName = context.StringValue($"DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies[{i}].AutoSnapshotPolicyName"),
                    TimePoints = context.StringValue($"DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies[{i}].TimePoints"),
                    RepeatWeekdays = context.StringValue($"DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies[{i}].RepeatWeekdays"),
                    RetentionDays = context.IntegerValue($"DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies[{i}].RetentionDays"),
                    DiskNums = context.IntegerValue($"DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies[{i}].DiskNums"),
                    CreationTime = context.StringValue($"DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies[{i}].CreationTime")
                };
                autoSnapshotPolicies.Add(autoSnapshotPolicy);
			}
			describeAutoSnapshotPolicyExResponse.AutoSnapshotPolicies = autoSnapshotPolicies;
        
			return describeAutoSnapshotPolicyExResponse;
        }
    }
}