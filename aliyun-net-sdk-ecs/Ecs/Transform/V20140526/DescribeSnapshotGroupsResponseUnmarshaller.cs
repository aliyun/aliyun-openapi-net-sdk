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
			describeSnapshotGroupsResponse.NextToken = _ctx.StringValue("DescribeSnapshotGroups.NextToken");
			describeSnapshotGroupsResponse.RequestId = _ctx.StringValue("DescribeSnapshotGroups.RequestId");

			List<DescribeSnapshotGroupsResponse.DescribeSnapshotGroups_SnapshotGroup> describeSnapshotGroupsResponse_snapshotGroups = new List<DescribeSnapshotGroupsResponse.DescribeSnapshotGroups_SnapshotGroup>();
			for (int i = 0; i < _ctx.Length("DescribeSnapshotGroups.SnapshotGroups.Length"); i++) {
				DescribeSnapshotGroupsResponse.DescribeSnapshotGroups_SnapshotGroup snapshotGroup = new DescribeSnapshotGroupsResponse.DescribeSnapshotGroups_SnapshotGroup();
				snapshotGroup.Status = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].Status");
				snapshotGroup.CreationTime = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].CreationTime");
				snapshotGroup.Description = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].Description");
				snapshotGroup.ProgressStatus = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].ProgressStatus");
				snapshotGroup.SnapshotGroupId = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].SnapshotGroupId");
				snapshotGroup.InstanceId = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].InstanceId");
				snapshotGroup.Name = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].Name");
				snapshotGroup.ResourceGroupId = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].ResourceGroupId");

				List<DescribeSnapshotGroupsResponse.DescribeSnapshotGroups_SnapshotGroup.DescribeSnapshotGroups_Tag> snapshotGroup_tags = new List<DescribeSnapshotGroupsResponse.DescribeSnapshotGroups_SnapshotGroup.DescribeSnapshotGroups_Tag>();
				for (int j = 0; j < _ctx.Length("DescribeSnapshotGroups.SnapshotGroups["+ i +"].Tags.Length"); j++) {
					DescribeSnapshotGroupsResponse.DescribeSnapshotGroups_SnapshotGroup.DescribeSnapshotGroups_Tag tag = new DescribeSnapshotGroupsResponse.DescribeSnapshotGroups_SnapshotGroup.DescribeSnapshotGroups_Tag();
					tag.Key = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].Tags["+ j +"].Key");
					tag._Value = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].Tags["+ j +"].Value");

					snapshotGroup_tags.Add(tag);
				}
				snapshotGroup.Tags = snapshotGroup_tags;

				List<DescribeSnapshotGroupsResponse.DescribeSnapshotGroups_SnapshotGroup.DescribeSnapshotGroups_Snapshot> snapshotGroup_snapshots = new List<DescribeSnapshotGroupsResponse.DescribeSnapshotGroups_SnapshotGroup.DescribeSnapshotGroups_Snapshot>();
				for (int j = 0; j < _ctx.Length("DescribeSnapshotGroups.SnapshotGroups["+ i +"].Snapshots.Length"); j++) {
					DescribeSnapshotGroupsResponse.DescribeSnapshotGroups_SnapshotGroup.DescribeSnapshotGroups_Snapshot snapshot = new DescribeSnapshotGroupsResponse.DescribeSnapshotGroups_SnapshotGroup.DescribeSnapshotGroups_Snapshot();
					snapshot.SourceDiskId = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].Snapshots["+ j +"].SourceDiskId");
					snapshot.Progress = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].Snapshots["+ j +"].Progress");
					snapshot.InstantAccessRetentionDays = _ctx.IntegerValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].Snapshots["+ j +"].InstantAccessRetentionDays");
					snapshot.SnapshotId = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].Snapshots["+ j +"].SnapshotId");
					snapshot.InstantAccess = _ctx.BooleanValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].Snapshots["+ j +"].InstantAccess");
					snapshot.SourceDiskType = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].Snapshots["+ j +"].SourceDiskType");

					List<DescribeSnapshotGroupsResponse.DescribeSnapshotGroups_SnapshotGroup.DescribeSnapshotGroups_Snapshot.DescribeSnapshotGroups_Tag2> snapshot_tags1 = new List<DescribeSnapshotGroupsResponse.DescribeSnapshotGroups_SnapshotGroup.DescribeSnapshotGroups_Snapshot.DescribeSnapshotGroups_Tag2>();
					for (int k = 0; k < _ctx.Length("DescribeSnapshotGroups.SnapshotGroups["+ i +"].Snapshots["+ j +"].Tags.Length"); k++) {
						DescribeSnapshotGroupsResponse.DescribeSnapshotGroups_SnapshotGroup.DescribeSnapshotGroups_Snapshot.DescribeSnapshotGroups_Tag2 tag2 = new DescribeSnapshotGroupsResponse.DescribeSnapshotGroups_SnapshotGroup.DescribeSnapshotGroups_Snapshot.DescribeSnapshotGroups_Tag2();
						tag2.Key = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].Snapshots["+ j +"].Tags["+ k +"].Key");
						tag2._Value = _ctx.StringValue("DescribeSnapshotGroups.SnapshotGroups["+ i +"].Snapshots["+ j +"].Tags["+ k +"].Value");

						snapshot_tags1.Add(tag2);
					}
					snapshot.Tags1 = snapshot_tags1;

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
