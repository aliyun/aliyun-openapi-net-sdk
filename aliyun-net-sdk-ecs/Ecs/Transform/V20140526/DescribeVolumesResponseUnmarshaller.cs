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
    public class DescribeVolumesResponseUnmarshaller
    {
        public static DescribeVolumesResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeVolumesResponse describeVolumesResponse = new DescribeVolumesResponse();

			describeVolumesResponse.HttpResponse = context.HttpResponse;
			describeVolumesResponse.RequestId = context.StringValue("DescribeVolumes.RequestId");
			describeVolumesResponse.TotalCount = context.IntegerValue("DescribeVolumes.TotalCount");
			describeVolumesResponse.PageNumber = context.IntegerValue("DescribeVolumes.PageNumber");
			describeVolumesResponse.PageSize = context.IntegerValue("DescribeVolumes.PageSize");

			List<DescribeVolumesResponse.DescribeVolumes_Volume> describeVolumesResponse_volumes = new List<DescribeVolumesResponse.DescribeVolumes_Volume>();
			for (int i = 0; i < context.Length("DescribeVolumes.Volumes.Length"); i++) {
				DescribeVolumesResponse.DescribeVolumes_Volume volume = new DescribeVolumesResponse.DescribeVolumes_Volume();
				volume.VolumeId = context.StringValue("DescribeVolumes.Volumes["+ i +"].VolumeId");
				volume.RegionId = context.StringValue("DescribeVolumes.Volumes["+ i +"].RegionId");
				volume.ZoneId = context.StringValue("DescribeVolumes.Volumes["+ i +"].ZoneId");
				volume.VolumeName = context.StringValue("DescribeVolumes.Volumes["+ i +"].VolumeName");
				volume.Description = context.StringValue("DescribeVolumes.Volumes["+ i +"].Description");
				volume.Category = context.StringValue("DescribeVolumes.Volumes["+ i +"].Category");
				volume.Size = context.IntegerValue("DescribeVolumes.Volumes["+ i +"].Size");
				volume.SourceSnapshotId = context.StringValue("DescribeVolumes.Volumes["+ i +"].SourceSnapshotId");
				volume.AutoSnapshotPolicyId = context.StringValue("DescribeVolumes.Volumes["+ i +"].AutoSnapshotPolicyId");
				volume.SnapshotLinkId = context.StringValue("DescribeVolumes.Volumes["+ i +"].SnapshotLinkId");
				volume.Status = context.StringValue("DescribeVolumes.Volumes["+ i +"].Status");
				volume.EnableAutomatedSnapshotPolicy = context.BooleanValue("DescribeVolumes.Volumes["+ i +"].EnableAutomatedSnapshotPolicy");
				volume.CreationTime = context.StringValue("DescribeVolumes.Volumes["+ i +"].CreationTime");
				volume.VolumeChargeType = context.StringValue("DescribeVolumes.Volumes["+ i +"].VolumeChargeType");
				volume.MountInstanceNum = context.IntegerValue("DescribeVolumes.Volumes["+ i +"].MountInstanceNum");
				volume.Encrypted = context.BooleanValue("DescribeVolumes.Volumes["+ i +"].Encrypted");

				List<DescribeVolumesResponse.DescribeVolumes_Volume.DescribeVolumes_OperationLock> volume_operationLocks = new List<DescribeVolumesResponse.DescribeVolumes_Volume.DescribeVolumes_OperationLock>();
				for (int j = 0; j < context.Length("DescribeVolumes.Volumes["+ i +"].OperationLocks.Length"); j++) {
					DescribeVolumesResponse.DescribeVolumes_Volume.DescribeVolumes_OperationLock operationLock = new DescribeVolumesResponse.DescribeVolumes_Volume.DescribeVolumes_OperationLock();
					operationLock.LockReason = context.StringValue("DescribeVolumes.Volumes["+ i +"].OperationLocks["+ j +"].LockReason");

					volume_operationLocks.Add(operationLock);
				}
				volume.OperationLocks = volume_operationLocks;

				List<DescribeVolumesResponse.DescribeVolumes_Volume.DescribeVolumes_MountInstance> volume_mountInstances = new List<DescribeVolumesResponse.DescribeVolumes_Volume.DescribeVolumes_MountInstance>();
				for (int j = 0; j < context.Length("DescribeVolumes.Volumes["+ i +"].MountInstances.Length"); j++) {
					DescribeVolumesResponse.DescribeVolumes_Volume.DescribeVolumes_MountInstance mountInstance = new DescribeVolumesResponse.DescribeVolumes_Volume.DescribeVolumes_MountInstance();
					mountInstance.InstanceId = context.StringValue("DescribeVolumes.Volumes["+ i +"].MountInstances["+ j +"].InstanceId");
					mountInstance.Device = context.StringValue("DescribeVolumes.Volumes["+ i +"].MountInstances["+ j +"].Device");
					mountInstance.AttachedTime = context.StringValue("DescribeVolumes.Volumes["+ i +"].MountInstances["+ j +"].AttachedTime");

					volume_mountInstances.Add(mountInstance);
				}
				volume.MountInstances = volume_mountInstances;

				List<DescribeVolumesResponse.DescribeVolumes_Volume.DescribeVolumes_Tag> volume_tags = new List<DescribeVolumesResponse.DescribeVolumes_Volume.DescribeVolumes_Tag>();
				for (int j = 0; j < context.Length("DescribeVolumes.Volumes["+ i +"].Tags.Length"); j++) {
					DescribeVolumesResponse.DescribeVolumes_Volume.DescribeVolumes_Tag tag = new DescribeVolumesResponse.DescribeVolumes_Volume.DescribeVolumes_Tag();
					tag.TagKey = context.StringValue("DescribeVolumes.Volumes["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = context.StringValue("DescribeVolumes.Volumes["+ i +"].Tags["+ j +"].TagValue");

					volume_tags.Add(tag);
				}
				volume.Tags = volume_tags;

				describeVolumesResponse_volumes.Add(volume);
			}
			describeVolumesResponse.Volumes = describeVolumesResponse_volumes;
        
			return describeVolumesResponse;
        }
    }
}