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
    public class DescribeSnapshotsResponseUnmarshaller
    {
        public static DescribeSnapshotsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSnapshotsResponse describeSnapshotsResponse = new DescribeSnapshotsResponse();

			describeSnapshotsResponse.HttpResponse = _ctx.HttpResponse;
			describeSnapshotsResponse.TotalCount = _ctx.IntegerValue("DescribeSnapshots.TotalCount");
			describeSnapshotsResponse.RequestId = _ctx.StringValue("DescribeSnapshots.RequestId");
			describeSnapshotsResponse.PageSize = _ctx.IntegerValue("DescribeSnapshots.PageSize");
			describeSnapshotsResponse.PageNumber = _ctx.IntegerValue("DescribeSnapshots.PageNumber");

			List<DescribeSnapshotsResponse.DescribeSnapshots_Snapshot> describeSnapshotsResponse_snapshots = new List<DescribeSnapshotsResponse.DescribeSnapshots_Snapshot>();
			for (int i = 0; i < _ctx.Length("DescribeSnapshots.Snapshots.Length"); i++) {
				DescribeSnapshotsResponse.DescribeSnapshots_Snapshot snapshot = new DescribeSnapshotsResponse.DescribeSnapshots_Snapshot();
				snapshot.Status = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].Status");
				snapshot.Progress = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].Progress");
				snapshot.CreateTime = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].CreateTime");
				snapshot.SourceFileSystemId = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].SourceFileSystemId");
				snapshot.RetentionDays = _ctx.IntegerValue("DescribeSnapshots.Snapshots["+ i +"].RetentionDays");
				snapshot.RemainTime = _ctx.IntegerValue("DescribeSnapshots.Snapshots["+ i +"].RemainTime");
				snapshot.SourceFileSystemSize = _ctx.LongValue("DescribeSnapshots.Snapshots["+ i +"].SourceFileSystemSize");
				snapshot.SourceFileSystemVersion = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].SourceFileSystemVersion");
				snapshot.SnapshotName = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].SnapshotName");
				snapshot.EncryptType = _ctx.IntegerValue("DescribeSnapshots.Snapshots["+ i +"].EncryptType");
				snapshot.Description = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].Description");
				snapshot.SnapshotId = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].SnapshotId");

				describeSnapshotsResponse_snapshots.Add(snapshot);
			}
			describeSnapshotsResponse.Snapshots = describeSnapshotsResponse_snapshots;
        
			return describeSnapshotsResponse;
        }
    }
}
