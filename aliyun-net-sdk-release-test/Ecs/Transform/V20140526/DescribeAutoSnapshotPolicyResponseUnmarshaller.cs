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
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeAutoSnapshotPolicyResponseUnmarshaller
    {
        public static DescribeAutoSnapshotPolicyResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeAutoSnapshotPolicyResponse describeAutoSnapshotPolicyResponse = new DescribeAutoSnapshotPolicyResponse();

			describeAutoSnapshotPolicyResponse.HttpResponse = context.HttpResponse;
			describeAutoSnapshotPolicyResponse.RequestId = context.StringValue("DescribeAutoSnapshotPolicy.RequestId");
			describeAutoSnapshotPolicyResponse.AutoSnapshotOccupation = context.IntegerValue("DescribeAutoSnapshotPolicy.AutoSnapshotOccupation");

			DescribeAutoSnapshotPolicyResponse.DescribeAutoSnapshotPolicy_AutoSnapshotPolicy autoSnapshotPolicy = new DescribeAutoSnapshotPolicyResponse.DescribeAutoSnapshotPolicy_AutoSnapshotPolicy();
			autoSnapshotPolicy.SystemDiskPolicyEnabled = context.StringValue("DescribeAutoSnapshotPolicy.AutoSnapshotPolicy.SystemDiskPolicyEnabled");
			autoSnapshotPolicy.SystemDiskPolicyTimePeriod = context.StringValue("DescribeAutoSnapshotPolicy.AutoSnapshotPolicy.SystemDiskPolicyTimePeriod");
			autoSnapshotPolicy.SystemDiskPolicyRetentionDays = context.StringValue("DescribeAutoSnapshotPolicy.AutoSnapshotPolicy.SystemDiskPolicyRetentionDays");
			autoSnapshotPolicy.SystemDiskPolicyRetentionLastWeek = context.StringValue("DescribeAutoSnapshotPolicy.AutoSnapshotPolicy.SystemDiskPolicyRetentionLastWeek");
			autoSnapshotPolicy.DataDiskPolicyEnabled = context.StringValue("DescribeAutoSnapshotPolicy.AutoSnapshotPolicy.DataDiskPolicyEnabled");
			autoSnapshotPolicy.DataDiskPolicyTimePeriod = context.StringValue("DescribeAutoSnapshotPolicy.AutoSnapshotPolicy.DataDiskPolicyTimePeriod");
			autoSnapshotPolicy.DataDiskPolicyRetentionDays = context.StringValue("DescribeAutoSnapshotPolicy.AutoSnapshotPolicy.DataDiskPolicyRetentionDays");
			autoSnapshotPolicy.DataDiskPolicyRetentionLastWeek = context.StringValue("DescribeAutoSnapshotPolicy.AutoSnapshotPolicy.DataDiskPolicyRetentionLastWeek");
			describeAutoSnapshotPolicyResponse.AutoSnapshotPolicy = autoSnapshotPolicy;

			DescribeAutoSnapshotPolicyResponse.DescribeAutoSnapshotPolicy_AutoSnapshotExcutionStatus autoSnapshotExcutionStatus = new DescribeAutoSnapshotPolicyResponse.DescribeAutoSnapshotPolicy_AutoSnapshotExcutionStatus();
			autoSnapshotExcutionStatus.SystemDiskExcutionStatus = context.StringValue("DescribeAutoSnapshotPolicy.AutoSnapshotExcutionStatus.SystemDiskExcutionStatus");
			autoSnapshotExcutionStatus.DataDiskExcutionStatus = context.StringValue("DescribeAutoSnapshotPolicy.AutoSnapshotExcutionStatus.DataDiskExcutionStatus");
			describeAutoSnapshotPolicyResponse.AutoSnapshotExcutionStatus = autoSnapshotExcutionStatus;
        
			return describeAutoSnapshotPolicyResponse;
        }
    }
}