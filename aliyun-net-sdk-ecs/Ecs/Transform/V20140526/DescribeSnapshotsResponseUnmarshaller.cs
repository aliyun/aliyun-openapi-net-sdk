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
    public class DescribeSnapshotsResponseUnmarshaller
    {
        public static DescribeSnapshotsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSnapshotsResponse describeSnapshotsResponse = new DescribeSnapshotsResponse();

			describeSnapshotsResponse.HttpResponse = context.HttpResponse;
			describeSnapshotsResponse.RequestId = context.StringValue("DescribeSnapshots.RequestId");
			describeSnapshotsResponse.TotalCount = context.IntegerValue("DescribeSnapshots.TotalCount");
			describeSnapshotsResponse.PageNumber = context.IntegerValue("DescribeSnapshots.PageNumber");
			describeSnapshotsResponse.PageSize = context.IntegerValue("DescribeSnapshots.PageSize");

			List<DescribeSnapshotsResponse.DescribeSnapshots_Snapshot> describeSnapshotsResponse_snapshots = new List<DescribeSnapshotsResponse.DescribeSnapshots_Snapshot>();
			for (int i = 0; i < context.Length("DescribeSnapshots.Snapshots.Length"); i++) {
				DescribeSnapshotsResponse.DescribeSnapshots_Snapshot snapshot = new DescribeSnapshotsResponse.DescribeSnapshots_Snapshot();
				snapshot.SnapshotId = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].SnapshotId");
				snapshot.SnapshotSN = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].SnapshotSN");
				snapshot.SnapshotName = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].SnapshotName");
				snapshot.Progress = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].Progress");
				snapshot.ProductCode = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].ProductCode");
				snapshot.SourceDiskId = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].SourceDiskId");
				snapshot.SourceDiskType = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].SourceDiskType");
				snapshot.RetentionDays = context.IntegerValue("DescribeSnapshots.Snapshots["+ i +"].RetentionDays");
				snapshot.Encrypted = context.BooleanValue("DescribeSnapshots.Snapshots["+ i +"].Encrypted");
				snapshot.SourceDiskSize = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].SourceDiskSize");
				snapshot.Description = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].Description");
				snapshot.CreationTime = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].CreationTime");
				snapshot.LastModifiedTime = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].LastModifiedTime");
				snapshot.Status = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].Status");
				snapshot.Usage = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].Usage");
				snapshot.SourceStorageType = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].SourceStorageType");
				snapshot.RemainTime = context.IntegerValue("DescribeSnapshots.Snapshots["+ i +"].RemainTime");
				snapshot.ResourceGroupId = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].ResourceGroupId");
				snapshot.KMSKeyId = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].KMSKeyId");
				snapshot.Category = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].Category");
				snapshot.SnapshotType = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].SnapshotType");

				List<DescribeSnapshotsResponse.DescribeSnapshots_Snapshot.DescribeSnapshots_Tag> snapshot_tags = new List<DescribeSnapshotsResponse.DescribeSnapshots_Snapshot.DescribeSnapshots_Tag>();
				for (int j = 0; j < context.Length("DescribeSnapshots.Snapshots["+ i +"].Tags.Length"); j++) {
					DescribeSnapshotsResponse.DescribeSnapshots_Snapshot.DescribeSnapshots_Tag tag = new DescribeSnapshotsResponse.DescribeSnapshots_Snapshot.DescribeSnapshots_Tag();
					tag.TagKey = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].Tags["+ j +"].TagValue");

					snapshot_tags.Add(tag);
				}
				snapshot.Tags = snapshot_tags;

				describeSnapshotsResponse_snapshots.Add(snapshot);
			}
			describeSnapshotsResponse.Snapshots = describeSnapshotsResponse_snapshots;
        
			return describeSnapshotsResponse;
        }
    }
}
