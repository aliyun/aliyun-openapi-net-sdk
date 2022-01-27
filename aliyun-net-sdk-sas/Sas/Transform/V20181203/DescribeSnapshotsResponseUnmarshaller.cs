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
using Aliyun.Acs.Sas.Model.V20181203;

namespace Aliyun.Acs.Sas.Transform.V20181203
{
    public class DescribeSnapshotsResponseUnmarshaller
    {
        public static DescribeSnapshotsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSnapshotsResponse describeSnapshotsResponse = new DescribeSnapshotsResponse();

			describeSnapshotsResponse.HttpResponse = _ctx.HttpResponse;
			describeSnapshotsResponse.RequestId = _ctx.StringValue("DescribeSnapshots.RequestId");

			DescribeSnapshotsResponse.DescribeSnapshots_PageInfo pageInfo = new DescribeSnapshotsResponse.DescribeSnapshots_PageInfo();
			pageInfo.Count = _ctx.IntegerValue("DescribeSnapshots.PageInfo.Count");
			pageInfo.NextToken = _ctx.StringValue("DescribeSnapshots.PageInfo.NextToken");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeSnapshots.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribeSnapshots.PageInfo.TotalCount");
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeSnapshots.PageInfo.CurrentPage");
			describeSnapshotsResponse.PageInfo = pageInfo;

			List<DescribeSnapshotsResponse.DescribeSnapshots_BackupSnapshots> describeSnapshotsResponse_snapshots = new List<DescribeSnapshotsResponse.DescribeSnapshots_BackupSnapshots>();
			for (int i = 0; i < _ctx.Length("DescribeSnapshots.Snapshots.Length"); i++) {
				DescribeSnapshotsResponse.DescribeSnapshots_BackupSnapshots backupSnapshots = new DescribeSnapshotsResponse.DescribeSnapshots_BackupSnapshots();
				backupSnapshots.SnapshotId = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].SnapshotId");
				backupSnapshots.ClientId = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].ClientId");
				backupSnapshots.VaultId = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].VaultId");
				backupSnapshots.SnapshotHash = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].SnapshotHash");
				backupSnapshots.Duration = _ctx.LongValue("DescribeSnapshots.Snapshots["+ i +"].Duration");
				backupSnapshots.CompleteTime = _ctx.LongValue("DescribeSnapshots.Snapshots["+ i +"].CompleteTime");
				backupSnapshots.Source = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].Source");
				backupSnapshots.ParentHash = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].ParentHash");
				backupSnapshots.Status = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].Status");
				backupSnapshots.Size = _ctx.LongValue("DescribeSnapshots.Snapshots["+ i +"].Size");
				backupSnapshots.ErrorCount = _ctx.LongValue("DescribeSnapshots.Snapshots["+ i +"].ErrorCount");
				backupSnapshots.Retention = _ctx.LongValue("DescribeSnapshots.Snapshots["+ i +"].Retention");
				backupSnapshots.SnapshotName = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].SnapshotName");
				backupSnapshots.BytesDone = _ctx.LongValue("DescribeSnapshots.Snapshots["+ i +"].BytesDone");
				backupSnapshots.BytesTotal = _ctx.LongValue("DescribeSnapshots.Snapshots["+ i +"].BytesTotal");
				backupSnapshots.ItemsDone = _ctx.LongValue("DescribeSnapshots.Snapshots["+ i +"].ItemsDone");
				backupSnapshots.ItemsTotal = _ctx.LongValue("DescribeSnapshots.Snapshots["+ i +"].ItemsTotal");
				backupSnapshots.ActualBytes = _ctx.LongValue("DescribeSnapshots.Snapshots["+ i +"].ActualBytes");
				backupSnapshots.JobId = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].JobId");
				backupSnapshots.ExitCode = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].ExitCode");
				backupSnapshots.CreatedTime = _ctx.LongValue("DescribeSnapshots.Snapshots["+ i +"].CreatedTime");
				backupSnapshots.UpdatedTime = _ctx.LongValue("DescribeSnapshots.Snapshots["+ i +"].UpdatedTime");
				backupSnapshots.SourceType = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].SourceType");
				backupSnapshots.SnapshotOption = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].SnapshotOption");
				backupSnapshots.ContainerSnapshotId = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].ContainerSnapshotId");
				backupSnapshots.PlanId = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].PlanId");
				backupSnapshots.SnapshotType = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].SnapshotType");
				backupSnapshots.ServerId = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].ServerId");
				backupSnapshots.Extra = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].Extra");
				backupSnapshots.ErrorMessage = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].ErrorMessage");
				backupSnapshots.ErrorFile = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].ErrorFile");
				backupSnapshots.ErrorType = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].ErrorType");
				backupSnapshots.Uuid = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].Uuid");
				backupSnapshots.InstanceId = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].InstanceId");
				backupSnapshots.MachineInfoJson = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].MachineInfoJson");
				backupSnapshots.RegionId = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].RegionId");
				backupSnapshots.BackupType = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].BackupType");
				backupSnapshots.ParentSnapshotHash = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].ParentSnapshotHash");
				backupSnapshots.Bucket = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].Bucket");
				backupSnapshots.Prefix = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].Prefix");
				backupSnapshots.FileSystemId = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].FileSystemId");
				backupSnapshots.StartTime = _ctx.LongValue("DescribeSnapshots.Snapshots["+ i +"].StartTime");
				backupSnapshots.CreateTime = _ctx.LongValue("DescribeSnapshots.Snapshots["+ i +"].CreateTime");
				backupSnapshots.ActualItems = _ctx.LongValue("DescribeSnapshots.Snapshots["+ i +"].ActualItems");
				backupSnapshots.Path = _ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].Path");

				List<string> backupSnapshots_paths = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeSnapshots.Snapshots["+ i +"].Paths.Length"); j++) {
					backupSnapshots_paths.Add(_ctx.StringValue("DescribeSnapshots.Snapshots["+ i +"].Paths["+ j +"]"));
				}
				backupSnapshots.Paths = backupSnapshots_paths;

				describeSnapshotsResponse_snapshots.Add(backupSnapshots);
			}
			describeSnapshotsResponse.Snapshots = describeSnapshotsResponse_snapshots;
        
			return describeSnapshotsResponse;
        }
    }
}
