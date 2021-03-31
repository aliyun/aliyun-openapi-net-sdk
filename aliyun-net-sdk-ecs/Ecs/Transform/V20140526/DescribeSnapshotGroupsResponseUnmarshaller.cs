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
    public class DescribeSnapshotGroupsResponseUnmarshaller
    {
        public static DescribeSnapshotGroupsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSnapshotGroupsResponse describeSnapshotGroupsResponse = new DescribeSnapshotGroupsResponse();

			describeSnapshotGroupsResponse.HttpResponse = _ctx.HttpResponse;
			describeSnapshotGroupsResponse.RequestId = _ctx.StringValue("DescribeSnapshotGroups.RequestId");
			describeSnapshotGroupsResponse.NextToken = _ctx.StringValue("DescribeSnapshotGroups.NextToken");

			List<DescribeSnapshotGroupsResponse.DescribeSnapshotGroups_SnapshotGroup> describeSnapshotGroupsResponse_snapshotGroups = new List<DescribeSnapshotGroupsResponse.DescribeSnapshotGroups_SnapshotGroup>();
			for (int i = 0; i < _ctx.Length("DescribeSnapshotGroups.SnapshotGroups.Length"); i++) {
				DescribeSnapshotGroupsResponse.DescribeSnapshotGroups_SnapshotGroup snapshotGroup = new DescribeSnapshotGroupsResponse.DescribeSnapshotGroups_SnapshotGroup();
				snapshotGroup.InstanceId = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].InstanceId");
				snapshotGroup.SnapshotGroupId = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].SnapshotGroupId");
				snapshotGroup.Status = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].Status");
				snapshotGroup.Name = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].Name");
				snapshotGroup.Description = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].Description");
				snapshotGroup.CreationTime = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].CreationTime");
				snapshotGroup.ProgressStatus = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].ProgressStatus");

				List<DescribeSnapshotGroupsResponse.DescribeSnapshotGroups_SnapshotGroup.DescribeSnapshotGroups_Snapshot> snapshotGroup_snapshots = new List<DescribeSnapshotGroupsResponse.DescribeSnapshotGroups_SnapshotGroup.DescribeSnapshotGroups_Snapshot>();
				for (int j = 0; j < _ctx.Length("DescribeSnapshotGroups.SnapshotGroups["+ i +"].Snapshots.Length"); j++) {
					DescribeSnapshotGroupsResponse.DescribeSnapshotGroups_SnapshotGroup.DescribeSnapshotGroups_Snapshot snapshot = new DescribeSnapshotGroupsResponse.DescribeSnapshotGroups_SnapshotGroup.DescribeSnapshotGroups_Snapshot();
					snapshot.SnapshotId = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].Snapshots["+ j +"].SnapshotId");
					snapshot.Progress = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].Snapshots["+ j +"].Progress");
					snapshot.SourceDiskId = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].Snapshots["+ j +"].SourceDiskId");
					snapshot.SourceDiskType = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].Snapshots["+ j +"].SourceDiskType");
					snapshot.InstantAccess = _ctx.BooleanValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].Snapshots["+ j +"].InstantAccess");
					snapshot.InstantAccessRetentionDays = _ctx.IntegerValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].Snapshots["+ j +"].InstantAccessRetentionDays");

					snapshotGroup_snapshots.Add(snapshot);
				}
				snapshotGroup.Snapshots = snapshotGroup_snapshots;

				describeSnapshotGroupsResponse_snapshotGroups.Add(snapshotGroup);
			}
			describeSnapshotGroupsResponse.SnapshotGroups = describeSnapshotGroupsResponse_snapshotGroups;
        
			return describeSnapshotGroupsResponse;
        }
    }
}
