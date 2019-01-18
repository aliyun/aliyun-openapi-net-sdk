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
using Aliyun.Acs.R_kvstore.Model.V20150101;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.R_kvstore.Transform.V20150101
{
    public class DescribeSnapshotsResponseUnmarshaller
    {
        public static DescribeSnapshotsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeSnapshotsResponse describeSnapshotsResponse = new DescribeSnapshotsResponse();

			describeSnapshotsResponse.HttpResponse = context.HttpResponse;
			describeSnapshotsResponse.RequestId = context.StringValue("DescribeSnapshots.RequestId");

			List<DescribeSnapshotsResponse.DescribeSnapshots_Snapshot> describeSnapshotsResponse_snapshots = new List<DescribeSnapshotsResponse.DescribeSnapshots_Snapshot>();
			for (int i = 0; i < context.Length("DescribeSnapshots.Snapshots.Length"); i++) {
				DescribeSnapshotsResponse.DescribeSnapshots_Snapshot snapshot = new DescribeSnapshotsResponse.DescribeSnapshots_Snapshot();
				snapshot.SnapshotId = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].SnapshotId");
				snapshot.SnapshotName = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].SnapshotName");
				snapshot.InstanceId = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].InstanceId");
				snapshot.CreateTime = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].CreateTime");
				snapshot.Memory = context.LongValue("DescribeSnapshots.Snapshots["+ i +"].Memory");
				snapshot.RdbSize = context.LongValue("DescribeSnapshots.Snapshots["+ i +"].RdbSize");
				snapshot.Status = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].Status");
				snapshot.Type = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].Type");
				snapshot.OssDownloadInPath = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].OssDownloadInPath");
				snapshot.OssDownloadOutPath = context.StringValue("DescribeSnapshots.Snapshots["+ i +"].OssDownloadOutPath");

				describeSnapshotsResponse_snapshots.Add(snapshot);
			}
			describeSnapshotsResponse.Snapshots = describeSnapshotsResponse_snapshots;
        
			return describeSnapshotsResponse;
        }
    }
}