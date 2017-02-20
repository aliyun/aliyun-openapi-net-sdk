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
    public class DescribeDisksResponseUnmarshaller
    {
        public static DescribeDisksResponse Unmarshall(UnmarshallerContext context)
        {
            DescribeDisksResponse describeDisksResponse = new DescribeDisksResponse()
            {
                HttpResponse = context.HttpResponse,
                RequestId = context.StringValue("DescribeDisks.RequestId"),
                TotalCount = context.IntegerValue("DescribeDisks.TotalCount"),
                PageNumber = context.IntegerValue("DescribeDisks.PageNumber"),
                PageSize = context.IntegerValue("DescribeDisks.PageSize")
            };
            List<DescribeDisksResponse.Disk> disks = new List<DescribeDisksResponse.Disk>();
			for (int i = 0; i < context.Length("DescribeDisks.Disks.Length"); i++) {
                DescribeDisksResponse.Disk disk = new DescribeDisksResponse.Disk()
                {
                    DiskId = context.StringValue($"DescribeDisks.Disks[{i}].DiskId"),
                    RegionId = context.StringValue($"DescribeDisks.Disks[{i}].RegionId"),
                    ZoneId = context.StringValue($"DescribeDisks.Disks[{i}].ZoneId"),
                    DiskName = context.StringValue($"DescribeDisks.Disks[{i}].DiskName"),
                    Description = context.StringValue($"DescribeDisks.Disks[{i}].Description"),
                    Type = context.EnumValue<DescribeDisksResponse.Disk.TypeEnum>($"DescribeDisks.Disks[{i}].Type"),
                    Category = context.EnumValue<DescribeDisksResponse.Disk.CategoryEnum>($"DescribeDisks.Disks[{i}].Category"),
                    Size = context.IntegerValue($"DescribeDisks.Disks[{i}].Size"),
                    ImageId = context.StringValue($"DescribeDisks.Disks[{i}].ImageId"),
                    SourceSnapshotId = context.StringValue($"DescribeDisks.Disks[{i}].SourceSnapshotId"),
                    AutoSnapshotPolicyId = context.StringValue($"DescribeDisks.Disks[{i}].AutoSnapshotPolicyId"),
                    ProductCode = context.StringValue($"DescribeDisks.Disks[{i}].ProductCode"),
                    Portable = context.BooleanValue($"DescribeDisks.Disks[{i}].Portable"),
                    Status = context.StringValue($"DescribeDisks.Disks[{i}].Status"),
                    InstanceId = context.StringValue($"DescribeDisks.Disks[{i}].InstanceId"),
                    Device = context.StringValue($"DescribeDisks.Disks[{i}].Device"),
                    DeleteWithInstance = context.BooleanValue($"DescribeDisks.Disks[{i}].DeleteWithInstance"),
                    DeleteAutoSnapshot = context.BooleanValue($"DescribeDisks.Disks[{i}].DeleteAutoSnapshot"),
                    EnableAutoSnapshot = context.BooleanValue($"DescribeDisks.Disks[{i}].EnableAutoSnapshot"),
                    EnableAutomatedSnapshotPolicy = context.BooleanValue($"DescribeDisks.Disks[{i}].EnableAutomatedSnapshotPolicy"),
                    CreationTime = context.StringValue($"DescribeDisks.Disks[{i}].CreationTime"),
                    AttachedTime = context.StringValue($"DescribeDisks.Disks[{i}].AttachedTime"),
                    DetachedTime = context.StringValue($"DescribeDisks.Disks[{i}].DetachedTime"),
                    DiskChargeType = context.StringValue($"DescribeDisks.Disks[{i}].DiskChargeType"),
                    ExpiredTime = context.StringValue($"DescribeDisks.Disks[{i}].ExpiredTime")
                };
                List<DescribeDisksResponse.Disk.OperationLock> operationLocks = new List<DescribeDisksResponse.Disk.OperationLock>();
				for (int j = 0; j < context.Length($"DescribeDisks.Disks[{i}].OperationLocks.Length"); j++) {
                    DescribeDisksResponse.Disk.OperationLock operationLock = new DescribeDisksResponse.Disk.OperationLock()
                    {
                        LockReason = context.StringValue($"DescribeDisks.Disks[{i}].OperationLocks[{j}].LockReason")
                    };
                    operationLocks.Add(operationLock);
				}
				disk.OperationLocks = operationLocks;

				List<DescribeDisksResponse.Disk.Tag> tags = new List<DescribeDisksResponse.Disk.Tag>();
				for (int j = 0; j < context.Length($"DescribeDisks.Disks[{i}].Tags.Length"); j++) {
                    DescribeDisksResponse.Disk.Tag tag = new DescribeDisksResponse.Disk.Tag()
                    {
                        TagKey = context.StringValue($"DescribeDisks.Disks[{i}].Tags[{j}].TagKey"),
                        TagValue = context.StringValue($"DescribeDisks.Disks[{i}].Tags[{j}].TagValue")
                    };
                    tags.Add(tag);
				}
				disk.Tags = tags;

				disks.Add(disk);
			}
			describeDisksResponse.Disks = disks;
        
			return describeDisksResponse;
        }
    }
}