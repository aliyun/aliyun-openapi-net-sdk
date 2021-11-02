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
using Aliyun.Acs.vod.Model.V20170321;

namespace Aliyun.Acs.vod.Transform.V20170321
{
    public class ListSnapshotsResponseUnmarshaller
    {
        public static ListSnapshotsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSnapshotsResponse listSnapshotsResponse = new ListSnapshotsResponse();

			listSnapshotsResponse.HttpResponse = _ctx.HttpResponse;
			listSnapshotsResponse.RequestId = _ctx.StringValue("ListSnapshots.RequestId");

			ListSnapshotsResponse.ListSnapshots_MediaSnapshot mediaSnapshot = new ListSnapshotsResponse.ListSnapshots_MediaSnapshot();
			mediaSnapshot.Total = _ctx.LongValue("ListSnapshots.MediaSnapshot.Total");
			mediaSnapshot.Regular = _ctx.StringValue("ListSnapshots.MediaSnapshot.Regular");
			mediaSnapshot.CreationTime = _ctx.StringValue("ListSnapshots.MediaSnapshot.CreationTime");
			mediaSnapshot.JobId = _ctx.StringValue("ListSnapshots.MediaSnapshot.JobId");

			List<ListSnapshotsResponse.ListSnapshots_MediaSnapshot.ListSnapshots_Snapshot> mediaSnapshot_snapshots = new List<ListSnapshotsResponse.ListSnapshots_MediaSnapshot.ListSnapshots_Snapshot>();
			for (int i = 0; i < _ctx.Length("ListSnapshots.MediaSnapshot.Snapshots.Length"); i++) {
				ListSnapshotsResponse.ListSnapshots_MediaSnapshot.ListSnapshots_Snapshot snapshot = new ListSnapshotsResponse.ListSnapshots_MediaSnapshot.ListSnapshots_Snapshot();
				snapshot.Index = _ctx.LongValue("ListSnapshots.MediaSnapshot.Snapshots["+ i +"].Index");
				snapshot.Url = _ctx.StringValue("ListSnapshots.MediaSnapshot.Snapshots["+ i +"].Url");

				mediaSnapshot_snapshots.Add(snapshot);
			}
			mediaSnapshot.Snapshots = mediaSnapshot_snapshots;
			listSnapshotsResponse.MediaSnapshot = mediaSnapshot;
        
			return listSnapshotsResponse;
        }
    }
}
