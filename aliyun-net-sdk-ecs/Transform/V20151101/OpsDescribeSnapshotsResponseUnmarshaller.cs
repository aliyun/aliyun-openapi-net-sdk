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
using Aliyun.Acs.Ecs.Model.V20151101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Ecs.Transform.V20151101
{
    public class OpsDescribeSnapshotsResponseUnmarshaller
    {
        public static OpsDescribeSnapshotsResponse Unmarshall(UnmarshallerContext context)
        {
			OpsDescribeSnapshotsResponse opsDescribeSnapshotsResponse = new OpsDescribeSnapshotsResponse();

			opsDescribeSnapshotsResponse.HttpResponse = context.HttpResponse;
			opsDescribeSnapshotsResponse.RequestId = context.StringValue("OpsDescribeSnapshots.RequestId");
			opsDescribeSnapshotsResponse.TotalCount = context.IntegerValue("OpsDescribeSnapshots.TotalCount");
			opsDescribeSnapshotsResponse.PageNo = context.IntegerValue("OpsDescribeSnapshots.PageNo");
			opsDescribeSnapshotsResponse.PageSize = context.IntegerValue("OpsDescribeSnapshots.PageSize");

			List<OpsDescribeSnapshotsResponse.Snapshot> snapshots = new List<OpsDescribeSnapshotsResponse.Snapshot>();
			for (int i = 0; i < context.Length("OpsDescribeSnapshots.Snapshots.Length"); i++) {
				OpsDescribeSnapshotsResponse.Snapshot snapshot = new OpsDescribeSnapshotsResponse.Snapshot();
				snapshot.AliUid = context.LongValue("OpsDescribeSnapshots.Snapshots["+ i +"].AliUid");
				snapshot.Bid = context.StringValue("OpsDescribeSnapshots.Snapshots["+ i +"].Bid");
				snapshot.SnapshotName = context.StringValue("OpsDescribeSnapshots.Snapshots["+ i +"].SnapshotName");
				snapshot.SnapshotId = context.StringValue("OpsDescribeSnapshots.Snapshots["+ i +"].SnapshotId");
				snapshot.HouyiSnapshotId = context.StringValue("OpsDescribeSnapshots.Snapshots["+ i +"].HouyiSnapshotId");
				snapshot.CreatedTime = context.StringValue("OpsDescribeSnapshots.Snapshots["+ i +"].CreatedTime");
				snapshot.ModifiedTime = context.StringValue("OpsDescribeSnapshots.Snapshots["+ i +"].ModifiedTime");
				snapshot.SnapshotType = context.StringValue("OpsDescribeSnapshots.Snapshots["+ i +"].SnapshotType");
				snapshot.SnapshotSize = context.IntegerValue("OpsDescribeSnapshots.Snapshots["+ i +"].SnapshotSize");
				snapshot.Progress = context.StringValue("OpsDescribeSnapshots.Snapshots["+ i +"].Progress");
				snapshot.Description = context.StringValue("OpsDescribeSnapshots.Snapshots["+ i +"].Description");
				snapshot.SourceDiskId = context.StringValue("OpsDescribeSnapshots.Snapshots["+ i +"].SourceDiskId");
				snapshot.SourceDiskType = context.StringValue("OpsDescribeSnapshots.Snapshots["+ i +"].SourceDiskType");
				snapshot.ImageId = context.StringValue("OpsDescribeSnapshots.Snapshots["+ i +"].ImageId");
				snapshot.RegionNo = context.StringValue("OpsDescribeSnapshots.Snapshots["+ i +"].RegionNo");

				snapshots.Add(snapshot);
			}
			opsDescribeSnapshotsResponse.Snapshots = snapshots;
        
			return opsDescribeSnapshotsResponse;
        }
    }
}