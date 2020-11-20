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
using Aliyun.Acs.sgw.Model.V20180511;

namespace Aliyun.Acs.sgw.Transform.V20180511
{
    public class DescribeBlockVolumeSnapshotsResponseUnmarshaller
    {
        public static DescribeBlockVolumeSnapshotsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeBlockVolumeSnapshotsResponse describeBlockVolumeSnapshotsResponse = new DescribeBlockVolumeSnapshotsResponse();

			describeBlockVolumeSnapshotsResponse.HttpResponse = context.HttpResponse;
			describeBlockVolumeSnapshotsResponse.RequestId = context.StringValue("DescribeBlockVolumeSnapshots.RequestId");
			describeBlockVolumeSnapshotsResponse.Success = context.BooleanValue("DescribeBlockVolumeSnapshots.Success");
			describeBlockVolumeSnapshotsResponse.Code = context.StringValue("DescribeBlockVolumeSnapshots.Code");
			describeBlockVolumeSnapshotsResponse.Message = context.StringValue("DescribeBlockVolumeSnapshots.Message");
			describeBlockVolumeSnapshotsResponse.TotalCount = context.IntegerValue("DescribeBlockVolumeSnapshots.TotalCount");
			describeBlockVolumeSnapshotsResponse.PageNumber = context.IntegerValue("DescribeBlockVolumeSnapshots.PageNumber");
			describeBlockVolumeSnapshotsResponse.PageSize = context.IntegerValue("DescribeBlockVolumeSnapshots.PageSize");

			List<DescribeBlockVolumeSnapshotsResponse.DescribeBlockVolumeSnapshots_Snapshot> describeBlockVolumeSnapshotsResponse_snapshots = new List<DescribeBlockVolumeSnapshotsResponse.DescribeBlockVolumeSnapshots_Snapshot>();
			for (int i = 0; i < context.Length("DescribeBlockVolumeSnapshots.Snapshots.Length"); i++) {
				DescribeBlockVolumeSnapshotsResponse.DescribeBlockVolumeSnapshots_Snapshot snapshot = new DescribeBlockVolumeSnapshotsResponse.DescribeBlockVolumeSnapshots_Snapshot();
				snapshot.SnapshotName = context.StringValue("DescribeBlockVolumeSnapshots.Snapshots["+ i +"].SnapshotName");
				snapshot.CreateTime = context.LongValue("DescribeBlockVolumeSnapshots.Snapshots["+ i +"].CreateTime");
				snapshot.Size = context.LongValue("DescribeBlockVolumeSnapshots.Snapshots["+ i +"].Size");

				describeBlockVolumeSnapshotsResponse_snapshots.Add(snapshot);
			}
			describeBlockVolumeSnapshotsResponse.Snapshots = describeBlockVolumeSnapshotsResponse_snapshots;
        
			return describeBlockVolumeSnapshotsResponse;
        }
    }
}
