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
    public class DescribeAutoSnapshotPolicyExResponseUnmarshaller
    {
        public static DescribeAutoSnapshotPolicyExResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAutoSnapshotPolicyExResponse describeAutoSnapshotPolicyExResponse = new DescribeAutoSnapshotPolicyExResponse();

			describeAutoSnapshotPolicyExResponse.HttpResponse = context.HttpResponse;
			describeAutoSnapshotPolicyExResponse.RequestId = context.StringValue("DescribeAutoSnapshotPolicyEx.RequestId");
			describeAutoSnapshotPolicyExResponse.TotalCount = context.IntegerValue("DescribeAutoSnapshotPolicyEx.TotalCount");
			describeAutoSnapshotPolicyExResponse.PageNumber = context.IntegerValue("DescribeAutoSnapshotPolicyEx.PageNumber");
			describeAutoSnapshotPolicyExResponse.PageSize = context.IntegerValue("DescribeAutoSnapshotPolicyEx.PageSize");

			List<DescribeAutoSnapshotPolicyExResponse.DescribeAutoSnapshotPolicyEx_AutoSnapshotPolicy> describeAutoSnapshotPolicyExResponse_autoSnapshotPolicies = new List<DescribeAutoSnapshotPolicyExResponse.DescribeAutoSnapshotPolicyEx_AutoSnapshotPolicy>();
			for (int i = 0; i < context.Length("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies.Length"); i++) {
				DescribeAutoSnapshotPolicyExResponse.DescribeAutoSnapshotPolicyEx_AutoSnapshotPolicy autoSnapshotPolicy = new DescribeAutoSnapshotPolicyExResponse.DescribeAutoSnapshotPolicyEx_AutoSnapshotPolicy();
				autoSnapshotPolicy.AutoSnapshotPolicyId = context.StringValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].AutoSnapshotPolicyId");
				autoSnapshotPolicy.RegionId = context.StringValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].RegionId");
				autoSnapshotPolicy.AutoSnapshotPolicyName = context.StringValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].AutoSnapshotPolicyName");
				autoSnapshotPolicy.TimePoints = context.StringValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].TimePoints");
				autoSnapshotPolicy.RepeatWeekdays = context.StringValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].RepeatWeekdays");
				autoSnapshotPolicy.RetentionDays = context.IntegerValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].RetentionDays");
				autoSnapshotPolicy.DiskNums = context.IntegerValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].DiskNums");
				autoSnapshotPolicy.VolumeNums = context.IntegerValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].VolumeNums");
				autoSnapshotPolicy.CreationTime = context.StringValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].CreationTime");
				autoSnapshotPolicy.Status = context.StringValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].Status");
				autoSnapshotPolicy.EnableCrossRegionCopy = context.BooleanValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].EnableCrossRegionCopy");
				autoSnapshotPolicy.TargetCopyRegions = context.StringValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].TargetCopyRegions");
				autoSnapshotPolicy.CopiedSnapshotsRetentionDays = context.IntegerValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].CopiedSnapshotsRetentionDays");

				List<DescribeAutoSnapshotPolicyExResponse.DescribeAutoSnapshotPolicyEx_AutoSnapshotPolicy.DescribeAutoSnapshotPolicyEx_Tag> autoSnapshotPolicy_tags = new List<DescribeAutoSnapshotPolicyExResponse.DescribeAutoSnapshotPolicyEx_AutoSnapshotPolicy.DescribeAutoSnapshotPolicyEx_Tag>();
				for (int j = 0; j < context.Length("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].Tags.Length"); j++) {
					DescribeAutoSnapshotPolicyExResponse.DescribeAutoSnapshotPolicyEx_AutoSnapshotPolicy.DescribeAutoSnapshotPolicyEx_Tag tag = new DescribeAutoSnapshotPolicyExResponse.DescribeAutoSnapshotPolicyEx_AutoSnapshotPolicy.DescribeAutoSnapshotPolicyEx_Tag();
					tag.TagKey = context.StringValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = context.StringValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].Tags["+ j +"].TagValue");

					autoSnapshotPolicy_tags.Add(tag);
				}
				autoSnapshotPolicy.Tags = autoSnapshotPolicy_tags;

				describeAutoSnapshotPolicyExResponse_autoSnapshotPolicies.Add(autoSnapshotPolicy);
			}
			describeAutoSnapshotPolicyExResponse.AutoSnapshotPolicies = describeAutoSnapshotPolicyExResponse_autoSnapshotPolicies;
        
			return describeAutoSnapshotPolicyExResponse;
        }
    }
}
