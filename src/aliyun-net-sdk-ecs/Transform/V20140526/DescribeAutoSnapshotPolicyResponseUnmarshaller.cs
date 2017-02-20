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

namespace Aliyun.Acs.Ecs.Transform.V20140526
{
    public class DescribeAutoSnapshotPolicyResponseUnmarshaller
    {
        public static DescribeAutoSnapshotPolicyResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeAutoSnapshotPolicyResponse describeAutoSnapshotPolicyResponse = new DescribeAutoSnapshotPolicyResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeAutoSnapshotPolicy.RequestId"),
                AutoSnapshotOccupation = context.IntegerValue("DescribeAutoSnapshotPolicy.AutoSnapshotOccupation")
            };
            DescribeAutoSnapshotPolicyResponse.AutoSnapshotPolicy_ autoSnapshotPolicy = new DescribeAutoSnapshotPolicyResponse.AutoSnapshotPolicy_()
            {
                SystemDiskPolicyEnabled = context.StringValue("DescribeAutoSnapshotPolicy.AutoSnapshotPolicy.SystemDiskPolicyEnabled"),
                SystemDiskPolicyTimePeriod = context.StringValue("DescribeAutoSnapshotPolicy.AutoSnapshotPolicy.SystemDiskPolicyTimePeriod"),
                SystemDiskPolicyRetentionDays = context.StringValue("DescribeAutoSnapshotPolicy.AutoSnapshotPolicy.SystemDiskPolicyRetentionDays"),
                SystemDiskPolicyRetentionLastWeek = context.StringValue("DescribeAutoSnapshotPolicy.AutoSnapshotPolicy.SystemDiskPolicyRetentionLastWeek"),
                DataDiskPolicyEnabled = context.StringValue("DescribeAutoSnapshotPolicy.AutoSnapshotPolicy.DataDiskPolicyEnabled"),
                DataDiskPolicyTimePeriod = context.StringValue("DescribeAutoSnapshotPolicy.AutoSnapshotPolicy.DataDiskPolicyTimePeriod"),
                DataDiskPolicyRetentionDays = context.StringValue("DescribeAutoSnapshotPolicy.AutoSnapshotPolicy.DataDiskPolicyRetentionDays"),
                DataDiskPolicyRetentionLastWeek = context.StringValue("DescribeAutoSnapshotPolicy.AutoSnapshotPolicy.DataDiskPolicyRetentionLastWeek")
            };
            describeAutoSnapshotPolicyResponse.AutoSnapshotPolicy = autoSnapshotPolicy;

            DescribeAutoSnapshotPolicyResponse.AutoSnapshotExcutionStatus_ autoSnapshotExcutionStatus = new DescribeAutoSnapshotPolicyResponse.AutoSnapshotExcutionStatus_()
            {
                SystemDiskExcutionStatus = context.EnumValue<DescribeAutoSnapshotPolicyResponse.AutoSnapshotExcutionStatus_.SystemDiskExcutionStatusEnum>("DescribeAutoSnapshotPolicy.AutoSnapshotExcutionStatus.SystemDiskExcutionStatus"),
                DataDiskExcutionStatus = context.EnumValue<DescribeAutoSnapshotPolicyResponse.AutoSnapshotExcutionStatus_.DataDiskExcutionStatusEnum>("DescribeAutoSnapshotPolicy.AutoSnapshotExcutionStatus.DataDiskExcutionStatus")
            };
            describeAutoSnapshotPolicyResponse.AutoSnapshotExcutionStatus = autoSnapshotExcutionStatus;
        
			return describeAutoSnapshotPolicyResponse;
        }
    }
}