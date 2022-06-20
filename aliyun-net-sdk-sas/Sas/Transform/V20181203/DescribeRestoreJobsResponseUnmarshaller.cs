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
    public class DescribeRestoreJobsResponseUnmarshaller
    {
        public static DescribeRestoreJobsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeRestoreJobsResponse describeRestoreJobsResponse = new DescribeRestoreJobsResponse();

			describeRestoreJobsResponse.HttpResponse = _ctx.HttpResponse;
			describeRestoreJobsResponse.RequestId = _ctx.StringValue("DescribeRestoreJobs.RequestId");

			DescribeRestoreJobsResponse.DescribeRestoreJobs_PageInfo pageInfo = new DescribeRestoreJobsResponse.DescribeRestoreJobs_PageInfo();
			pageInfo.CurrentPage = _ctx.IntegerValue("DescribeRestoreJobs.PageInfo.CurrentPage");
			pageInfo.PageSize = _ctx.IntegerValue("DescribeRestoreJobs.PageInfo.PageSize");
			pageInfo.TotalCount = _ctx.IntegerValue("DescribeRestoreJobs.PageInfo.TotalCount");
			pageInfo.Count = _ctx.IntegerValue("DescribeRestoreJobs.PageInfo.Count");
			describeRestoreJobsResponse.PageInfo = pageInfo;

			List<DescribeRestoreJobsResponse.DescribeRestoreJobs_RestoreJob> describeRestoreJobsResponse_restoreJobs = new List<DescribeRestoreJobsResponse.DescribeRestoreJobs_RestoreJob>();
			for (int i = 0; i < _ctx.Length("DescribeRestoreJobs.RestoreJobs.Length"); i++) {
				DescribeRestoreJobsResponse.DescribeRestoreJobs_RestoreJob restoreJob = new DescribeRestoreJobsResponse.DescribeRestoreJobs_RestoreJob();
				restoreJob.Status = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].Status");
				restoreJob.SnapshotHash = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].SnapshotHash");
				restoreJob.SourceClientId = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].SourceClientId");
				restoreJob.ErrorFileUrl = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].ErrorFileUrl");
				restoreJob.Includes = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].Includes");
				restoreJob.RestoreName = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].RestoreName");
				restoreJob.InternetIp = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].InternetIp");
				restoreJob.VaultId = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].VaultId");
				restoreJob.ActualBytes = _ctx.LongValue("DescribeRestoreJobs.RestoreJobs["+ i +"].ActualBytes");
				restoreJob.Message = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].Message");
				restoreJob.Percentage = _ctx.IntegerValue("DescribeRestoreJobs.RestoreJobs["+ i +"].Percentage");
				restoreJob.GmtModified = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].GmtModified");
				restoreJob.RestoreType = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].RestoreType");
				restoreJob.ExitCode = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].ExitCode");
				restoreJob.ClientId = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].ClientId");
				restoreJob.ItemsDone = _ctx.LongValue("DescribeRestoreJobs.RestoreJobs["+ i +"].ItemsDone");
				restoreJob.BytesTotal = _ctx.LongValue("DescribeRestoreJobs.RestoreJobs["+ i +"].BytesTotal");
				restoreJob.RequestId = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].RequestId");
				restoreJob.InstanceName = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].InstanceName");
				restoreJob.CompleteTime = _ctx.LongValue("DescribeRestoreJobs.RestoreJobs["+ i +"].CompleteTime");
				restoreJob.ErrorType = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].ErrorType");
				restoreJob.SnapshotVersion = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].SnapshotVersion");
				restoreJob.Target = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].Target");
				restoreJob.CreatedTime = _ctx.LongValue("DescribeRestoreJobs.RestoreJobs["+ i +"].CreatedTime");
				restoreJob.InstanceId = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].InstanceId");
				restoreJob.Source = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].Source");
				restoreJob.IntranetIp = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].IntranetIp");
				restoreJob.ErrorFile = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].ErrorFile");
				restoreJob.Uuid = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].Uuid");
				restoreJob.Excludes = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].Excludes");
				restoreJob.Speed = _ctx.LongValue("DescribeRestoreJobs.RestoreJobs["+ i +"].Speed");
				restoreJob.SnapshotId = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].SnapshotId");
				restoreJob.UpdatedTime = _ctx.LongValue("DescribeRestoreJobs.RestoreJobs["+ i +"].UpdatedTime");
				restoreJob.RestoreId = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].RestoreId");
				restoreJob.GmtCreate = _ctx.StringValue("DescribeRestoreJobs.RestoreJobs["+ i +"].GmtCreate");
				restoreJob.Eta = _ctx.LongValue("DescribeRestoreJobs.RestoreJobs["+ i +"].Eta");
				restoreJob.Duration = _ctx.LongValue("DescribeRestoreJobs.RestoreJobs["+ i +"].Duration");
				restoreJob.ErrorCount = _ctx.LongValue("DescribeRestoreJobs.RestoreJobs["+ i +"].ErrorCount");
				restoreJob.ItemsTotal = _ctx.LongValue("DescribeRestoreJobs.RestoreJobs["+ i +"].ItemsTotal");
				restoreJob.BytesDone = _ctx.LongValue("DescribeRestoreJobs.RestoreJobs["+ i +"].BytesDone");

				describeRestoreJobsResponse_restoreJobs.Add(restoreJob);
			}
			describeRestoreJobsResponse.RestoreJobs = describeRestoreJobsResponse_restoreJobs;
        
			return describeRestoreJobsResponse;
        }
    }
}
