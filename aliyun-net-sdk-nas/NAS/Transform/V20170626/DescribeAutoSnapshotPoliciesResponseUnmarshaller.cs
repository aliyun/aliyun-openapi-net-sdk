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
    public class DescribeAutoSnapshotPoliciesResponseUnmarshaller
    {
        public static DescribeAutoSnapshotPoliciesResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeAutoSnapshotPoliciesResponse describeAutoSnapshotPoliciesResponse = new DescribeAutoSnapshotPoliciesResponse();

			describeAutoSnapshotPoliciesResponse.HttpResponse = _ctx.HttpResponse;
			describeAutoSnapshotPoliciesResponse.TotalCount = _ctx.IntegerValue("DescribeAutoSnapshotPolicies.TotalCount");
			describeAutoSnapshotPoliciesResponse.RequestId = _ctx.StringValue("DescribeAutoSnapshotPolicies.RequestId");
			describeAutoSnapshotPoliciesResponse.PageSize = _ctx.IntegerValue("DescribeAutoSnapshotPolicies.PageSize");
			describeAutoSnapshotPoliciesResponse.PageNumber = _ctx.IntegerValue("DescribeAutoSnapshotPolicies.PageNumber");

			List<DescribeAutoSnapshotPoliciesResponse.DescribeAutoSnapshotPolicies_AutoSnapshotPolicy> describeAutoSnapshotPoliciesResponse_autoSnapshotPolicies = new List<DescribeAutoSnapshotPoliciesResponse.DescribeAutoSnapshotPolicies_AutoSnapshotPolicy>();
			for (int i = 0; i < _ctx.Length("DescribeAutoSnapshotPolicies.AutoSnapshotPolicies.Length"); i++) {
				DescribeAutoSnapshotPoliciesResponse.DescribeAutoSnapshotPolicies_AutoSnapshotPolicy autoSnapshotPolicy = new DescribeAutoSnapshotPoliciesResponse.DescribeAutoSnapshotPolicies_AutoSnapshotPolicy();
				autoSnapshotPolicy.TimePoints = _ctx.StringValue("DescribeAutoSnapshotPolicies.AutoSnapshotPolicies["+ i +"].TimePoints");
				autoSnapshotPolicy.Status = _ctx.StringValue("DescribeAutoSnapshotPolicies.AutoSnapshotPolicies["+ i +"].Status");
				autoSnapshotPolicy.RepeatWeekdays = _ctx.StringValue("DescribeAutoSnapshotPolicies.AutoSnapshotPolicies["+ i +"].RepeatWeekdays");
				autoSnapshotPolicy.AutoSnapshotPolicyName = _ctx.StringValue("DescribeAutoSnapshotPolicies.AutoSnapshotPolicies["+ i +"].AutoSnapshotPolicyName");
				autoSnapshotPolicy.CreateTime = _ctx.StringValue("DescribeAutoSnapshotPolicies.AutoSnapshotPolicies["+ i +"].CreateTime");
				autoSnapshotPolicy.AutoSnapshotPolicyId = _ctx.StringValue("DescribeAutoSnapshotPolicies.AutoSnapshotPolicies["+ i +"].AutoSnapshotPolicyId");
				autoSnapshotPolicy.RetentionDays = _ctx.IntegerValue("DescribeAutoSnapshotPolicies.AutoSnapshotPolicies["+ i +"].RetentionDays");
				autoSnapshotPolicy.FileSystemNums = _ctx.IntegerValue("DescribeAutoSnapshotPolicies.AutoSnapshotPolicies["+ i +"].FileSystemNums");
				autoSnapshotPolicy.RegionId = _ctx.StringValue("DescribeAutoSnapshotPolicies.AutoSnapshotPolicies["+ i +"].RegionId");
				autoSnapshotPolicy.FileSystemType = _ctx.StringValue("DescribeAutoSnapshotPolicies.AutoSnapshotPolicies["+ i +"].FileSystemType");

				describeAutoSnapshotPoliciesResponse_autoSnapshotPolicies.Add(autoSnapshotPolicy);
			}
			describeAutoSnapshotPoliciesResponse.AutoSnapshotPolicies = describeAutoSnapshotPoliciesResponse_autoSnapshotPolicies;
        
			return describeAutoSnapshotPoliciesResponse;
        }
    }
}
