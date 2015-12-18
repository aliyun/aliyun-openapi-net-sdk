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
    public class OpsDescribeMountedSnapshotsResponseUnmarshaller
    {
        public static OpsDescribeMountedSnapshotsResponse Unmarshall(UnmarshallerContext context)
        {
			OpsDescribeMountedSnapshotsResponse opsDescribeMountedSnapshotsResponse = new OpsDescribeMountedSnapshotsResponse();

			opsDescribeMountedSnapshotsResponse.HttpResponse = context.HttpResponse;
			opsDescribeMountedSnapshotsResponse.RequestId = context.StringValue("OpsDescribeMountedSnapshots.RequestId");
			opsDescribeMountedSnapshotsResponse.TotalCount = context.IntegerValue("OpsDescribeMountedSnapshots.TotalCount");
			opsDescribeMountedSnapshotsResponse.PageNo = context.IntegerValue("OpsDescribeMountedSnapshots.PageNo");
			opsDescribeMountedSnapshotsResponse.PageSize = context.IntegerValue("OpsDescribeMountedSnapshots.PageSize");

			List<OpsDescribeMountedSnapshotsResponse.Snapshot> mountedSnapshots = new List<OpsDescribeMountedSnapshotsResponse.Snapshot>();
			for (int i = 0; i < context.Length("OpsDescribeMountedSnapshots.MountedSnapshots.Length"); i++) {
				OpsDescribeMountedSnapshotsResponse.Snapshot snapshot = new OpsDescribeMountedSnapshotsResponse.Snapshot();
				snapshot.SnapshotId = context.StringValue("OpsDescribeMountedSnapshots.MountedSnapshots["+ i +"].SnapshotId");
				snapshot.LastAttachedTime = context.StringValue("OpsDescribeMountedSnapshots.MountedSnapshots["+ i +"].LastAttachedTime");
				snapshot.EcsInstanceId = context.StringValue("OpsDescribeMountedSnapshots.MountedSnapshots["+ i +"].EcsInstanceId");
				snapshot.Status = context.StringValue("OpsDescribeMountedSnapshots.MountedSnapshots["+ i +"].Status");
				snapshot.MountPoint = context.StringValue("OpsDescribeMountedSnapshots.MountedSnapshots["+ i +"].MountPoint");

				mountedSnapshots.Add(snapshot);
			}
			opsDescribeMountedSnapshotsResponse.MountedSnapshots = mountedSnapshots;
        
			return opsDescribeMountedSnapshotsResponse;
        }
    }
}