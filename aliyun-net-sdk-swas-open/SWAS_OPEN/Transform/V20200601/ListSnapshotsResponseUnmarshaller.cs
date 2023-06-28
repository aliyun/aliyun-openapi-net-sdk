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
using Aliyun.Acs.SWAS_OPEN.Model.V20200601;

namespace Aliyun.Acs.SWAS_OPEN.Transform.V20200601
{
    public class ListSnapshotsResponseUnmarshaller
    {
        public static ListSnapshotsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSnapshotsResponse listSnapshotsResponse = new ListSnapshotsResponse();

			listSnapshotsResponse.HttpResponse = _ctx.HttpResponse;
			listSnapshotsResponse.TotalCount = _ctx.IntegerValue("ListSnapshots.TotalCount");
			listSnapshotsResponse.RequestId = _ctx.StringValue("ListSnapshots.RequestId");
			listSnapshotsResponse.PageSize = _ctx.IntegerValue("ListSnapshots.PageSize");
			listSnapshotsResponse.PageNumber = _ctx.IntegerValue("ListSnapshots.PageNumber");

			List<ListSnapshotsResponse.ListSnapshots_Snapshot> listSnapshotsResponse_snapshots = new List<ListSnapshotsResponse.ListSnapshots_Snapshot>();
			for (int i = 0; i < _ctx.Length("ListSnapshots.Snapshots.Length"); i++) {
				ListSnapshotsResponse.ListSnapshots_Snapshot snapshot = new ListSnapshotsResponse.ListSnapshots_Snapshot();
				snapshot.Status = _ctx.StringValue("ListSnapshots.Snapshots["+ i +"].Status");
				snapshot.CreationTime = _ctx.StringValue("ListSnapshots.Snapshots["+ i +"].CreationTime");
				snapshot.SourceDiskId = _ctx.StringValue("ListSnapshots.Snapshots["+ i +"].SourceDiskId");
				snapshot.SnapshotName = _ctx.StringValue("ListSnapshots.Snapshots["+ i +"].SnapshotName");
				snapshot.Progress = _ctx.StringValue("ListSnapshots.Snapshots["+ i +"].Progress");
				snapshot.Remark = _ctx.StringValue("ListSnapshots.Snapshots["+ i +"].Remark");
				snapshot.SnapshotId = _ctx.StringValue("ListSnapshots.Snapshots["+ i +"].SnapshotId");
				snapshot.SourceDiskType = _ctx.StringValue("ListSnapshots.Snapshots["+ i +"].SourceDiskType");
				snapshot.RegionId = _ctx.StringValue("ListSnapshots.Snapshots["+ i +"].RegionId");

				listSnapshotsResponse_snapshots.Add(snapshot);
			}
			listSnapshotsResponse.Snapshots = listSnapshotsResponse_snapshots;
        
			return listSnapshotsResponse;
        }
    }
}
