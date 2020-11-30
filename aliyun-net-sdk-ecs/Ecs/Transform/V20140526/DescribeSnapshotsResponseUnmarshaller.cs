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
        public static DescribeSnapshotsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSnapshotsResponse describeSnapshotsResponse = new DescribeSnapshotsResponse();

			describeSnapshotsResponse.HttpResponse = _ctx.HttpResponse;
			describeSnapshotsResponse.RequestId = _ctx.StringValue("DescribeSnapshots.RequestId");
			describeSnapshotsResponse.TotalCount = _ctx.IntegerValue("DescribeSnapshots.TotalCount");
			describeSnapshotsResponse.PageNumber = _ctx.IntegerValue("DescribeSnapshots.PageNumber");
			describeSnapshotsResponse.PageSize = _ctx.IntegerValue("DescribeSnapshots.PageSize");
			describeSnapshotsResponse.NextToken = _ctx.StringValue("DescribeSnapshots.NextToken");

			List<DescribeSnapshotsResponse.DescribeSnapshots_Snapshot> describeSnapshotsResponse_snapshots = new List<DescribeSnapshotsResponse.DescribeSnapshots_Snapshot>();
			for (int i = 0; i < _ctx.Length("DescribeSnapshots.Snapshots.Length"); i++) {
				DescribeSnapshotsResponse.DescribeSnapshots_Snapshot snapshot = new DescribeSnapshotsResponse.DescribeSnapshots_Snapshot();
				snapshot.SnapshotId = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].SnapshotId");
				snapshot.SnapshotSN = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].SnapshotSN");
				snapshot.SnapshotName = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].SnapshotName");
				snapshot.Progress = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].Progress");
				snapshot.ProductCode = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].ProductCode");
				snapshot.SourceDiskId = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].SourceDiskId");
				snapshot.SourceDiskType = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].SourceDiskType");
				snapshot.RetentionDays = _ctx.IntegerValue("DescribeSnapshots.Snapshots["+ i +"].RetentionDays");
				snapshot.Encrypted = _ctx.BooleanValue("DescribeSnapshots.Snapshots["+ i +"].Encrypted");
				snapshot.SourceDiskSize = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].SourceDiskSize");
				snapshot.Description = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].Description");
				snapshot.CreationTime = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].CreationTime");
				snapshot.LastModifiedTime = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].LastModifiedTime");
				snapshot.Status = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].Status");
				snapshot.Usage = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].Usage");
				snapshot.SourceStorageType = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].SourceStorageType");
				snapshot.RemainTime = _ctx.IntegerValue("DescribeSnapshots.Snapshots["+ i +"].RemainTime");
				snapshot.ResourceGroupId = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].ResourceGroupId");
				snapshot.KMSKeyId = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].KMSKeyId");
				snapshot.Category = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].Category");
				snapshot.SnapshotType = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].SnapshotType");
				snapshot.InstantAccess = _ctx.BooleanValue("DescribeSnapshots.Snapshots["+ i +"].InstantAccess");
				snapshot.InstantAccessRetentionDays = _ctx.IntegerValue("DescribeSnapshots.Snapshots["+ i +"].InstantAccessRetentionDays");

				List<DescribeSnapshotsResponse.DescribeSnapshots_Snapshot.DescribeSnapshots_Tag> snapshot_tags = new List<DescribeSnapshotsResponse.DescribeSnapshots_Snapshot.DescribeSnapshots_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeSnapshots.Snapshots["+ i +"].Tags.Length"); j++) {
					DescribeSnapshotsResponse.DescribeSnapshots_Snapshot.DescribeSnapshots_Tag tag = new DescribeSnapshotsResponse.DescribeSnapshots_Snapshot.DescribeSnapshots_Tag();
					tag.TagKey = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].Tags["+ j +"].TagKey");
					tag.TagValue = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].Tags["+ j +"].TagValue");

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
