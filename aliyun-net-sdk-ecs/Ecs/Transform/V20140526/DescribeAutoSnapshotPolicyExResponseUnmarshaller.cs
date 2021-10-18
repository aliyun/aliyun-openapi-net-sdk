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
        public static DescribeAutoSnapshotPolicyExResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAutoSnapshotPolicyExResponse describeAutoSnapshotPolicyExResponse = new DescribeAutoSnapshotPolicyExResponse();

			describeAutoSnapshotPolicyExResponse.HttpResponse = _ctx.HttpResponse;
			describeAutoSnapshotPolicyExResponse.PageSize = _ctx.IntegerValue("DescribeAutoSnapshotPolicyEx.PageSize");
			describeAutoSnapshotPolicyExResponse.RequestId = _ctx.StringValue("DescribeAutoSnapshotPolicyEx.RequestId");
			describeAutoSnapshotPolicyExResponse.PageNumber = _ctx.IntegerValue("DescribeAutoSnapshotPolicyEx.PageNumber");
			describeAutoSnapshotPolicyExResponse.TotalCount = _ctx.IntegerValue("DescribeAutoSnapshotPolicyEx.TotalCount");

			List<DescribeAutoSnapshotPolicyExResponse.DescribeAutoSnapshotPolicyEx_AutoSnapshotPolicy> describeAutoSnapshotPolicyExResponse_autoSnapshotPolicies = new List<DescribeAutoSnapshotPolicyExResponse.DescribeAutoSnapshotPolicyEx_AutoSnapshotPolicy>();
			for (int i = 0; i < _ctx.Length("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies.Length"); i++) {
				DescribeAutoSnapshotPolicyExResponse.DescribeAutoSnapshotPolicyEx_AutoSnapshotPolicy autoSnapshotPolicy = new DescribeAutoSnapshotPolicyExResponse.DescribeAutoSnapshotPolicyEx_AutoSnapshotPolicy();
				autoSnapshotPolicy.TimePoints = _ctx.StringValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].TimePoints");
				autoSnapshotPolicy.CreationTime = _ctx.StringValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].CreationTime");
				autoSnapshotPolicy.Status = _ctx.StringValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].Status");
				autoSnapshotPolicy.AutoSnapshotPolicyName = _ctx.StringValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].AutoSnapshotPolicyName");
				autoSnapshotPolicy.TargetCopyRegions = _ctx.StringValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].TargetCopyRegions");
				autoSnapshotPolicy.CopiedSnapshotsRetentionDays = _ctx.IntegerValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].CopiedSnapshotsRetentionDays");
				autoSnapshotPolicy.AutoSnapshotPolicyId = _ctx.StringValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].AutoSnapshotPolicyId");
				autoSnapshotPolicy.RetentionDays = _ctx.IntegerValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].RetentionDays");
				autoSnapshotPolicy.RegionId = _ctx.StringValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].RegionId");
				autoSnapshotPolicy.DiskNums = _ctx.IntegerValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].DiskNums");
				autoSnapshotPolicy.EnableCrossRegionCopy = _ctx.BooleanValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].EnableCrossRegionCopy");
				autoSnapshotPolicy.RepeatWeekdays = _ctx.StringValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].RepeatWeekdays");
				autoSnapshotPolicy.VolumeNums = _ctx.IntegerValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].VolumeNums");
				autoSnapshotPolicy.ResourceGroupId = _ctx.StringValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].ResourceGroupId");

				List<DescribeAutoSnapshotPolicyExResponse.DescribeAutoSnapshotPolicyEx_AutoSnapshotPolicy.DescribeAutoSnapshotPolicyEx_Tag> autoSnapshotPolicy_tags = new List<DescribeAutoSnapshotPolicyExResponse.DescribeAutoSnapshotPolicyEx_AutoSnapshotPolicy.DescribeAutoSnapshotPolicyEx_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].Tags.Length"); j++) {
					DescribeAutoSnapshotPolicyExResponse.DescribeAutoSnapshotPolicyEx_AutoSnapshotPolicy.DescribeAutoSnapshotPolicyEx_Tag tag = new DescribeAutoSnapshotPolicyExResponse.DescribeAutoSnapshotPolicyEx_AutoSnapshotPolicy.DescribeAutoSnapshotPolicyEx_Tag();
					tag.TagValue = _ctx.StringValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].Tags["+ j +"].TagValue");
					tag.TagKey = _ctx.StringValue("DescribeAutoSnapshotPolicyEx.AutoSnapshotPolicies["+ i +"].Tags["+ j +"].TagKey");

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
