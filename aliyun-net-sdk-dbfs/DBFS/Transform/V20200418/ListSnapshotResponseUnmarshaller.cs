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
using Aliyun.Acs.DBFS.Model.V20200418;

namespace Aliyun.Acs.DBFS.Transform.V20200418
{
    public class ListSnapshotResponseUnmarshaller
    {
        public static ListSnapshotResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSnapshotResponse listSnapshotResponse = new ListSnapshotResponse();

			listSnapshotResponse.HttpResponse = _ctx.HttpResponse;
			listSnapshotResponse.RequestId = _ctx.StringValue("ListSnapshot.RequestId");
			listSnapshotResponse.TotalCount = _ctx.IntegerValue("ListSnapshot.TotalCount");
			listSnapshotResponse.PageNumber = _ctx.IntegerValue("ListSnapshot.PageNumber");
			listSnapshotResponse.PageSize = _ctx.IntegerValue("ListSnapshot.PageSize");

			List<ListSnapshotResponse.ListSnapshot_SnapshotsItem> listSnapshotResponse_snapshots = new List<ListSnapshotResponse.ListSnapshot_SnapshotsItem>();
			for (int i = 0; i < _ctx.Length("ListSnapshot.Snapshots.Length"); i++) {
				ListSnapshotResponse.ListSnapshot_SnapshotsItem snapshotsItem = new ListSnapshotResponse.ListSnapshot_SnapshotsItem();
				snapshotsItem.Category = _ctx.StringValue("ListSnapshot.Snapshots["+ i +"].Category");
				snapshotsItem.CreationTime = _ctx.StringValue("ListSnapshot.Snapshots["+ i +"].CreationTime");
				snapshotsItem.Description = _ctx.StringValue("ListSnapshot.Snapshots["+ i +"].Description");
				snapshotsItem.LastModifiedTime = _ctx.StringValue("ListSnapshot.Snapshots["+ i +"].LastModifiedTime");
				snapshotsItem.Progress = _ctx.StringValue("ListSnapshot.Snapshots["+ i +"].Progress");
				snapshotsItem.RemainTime = _ctx.IntegerValue("ListSnapshot.Snapshots["+ i +"].RemainTime");
				snapshotsItem.RetentionDays = _ctx.IntegerValue("ListSnapshot.Snapshots["+ i +"].RetentionDays");
				snapshotsItem.SnapshotId = _ctx.StringValue("ListSnapshot.Snapshots["+ i +"].SnapshotId");
				snapshotsItem.SnapshotName = _ctx.StringValue("ListSnapshot.Snapshots["+ i +"].SnapshotName");
				snapshotsItem.SnapshotType = _ctx.StringValue("ListSnapshot.Snapshots["+ i +"].SnapshotType");
				snapshotsItem.Status = _ctx.StringValue("ListSnapshot.Snapshots["+ i +"].Status");
				snapshotsItem.SourceFsId = _ctx.StringValue("ListSnapshot.Snapshots["+ i +"].SourceFsId");
				snapshotsItem.SourceFsSize = _ctx.IntegerValue("ListSnapshot.Snapshots["+ i +"].SourceFsSize");

				listSnapshotResponse_snapshots.Add(snapshotsItem);
			}
			listSnapshotResponse.Snapshots = listSnapshotResponse_snapshots;
        
			return listSnapshotResponse;
        }
    }
}
