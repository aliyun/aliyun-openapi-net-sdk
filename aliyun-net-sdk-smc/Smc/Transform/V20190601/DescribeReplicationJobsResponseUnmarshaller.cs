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
using Aliyun.Acs.smc.Model.V20190601;

namespace Aliyun.Acs.smc.Transform.V20190601
{
    public class DescribeReplicationJobsResponseUnmarshaller
    {
        public static DescribeReplicationJobsResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeReplicationJobsResponse describeReplicationJobsResponse = new DescribeReplicationJobsResponse();

			describeReplicationJobsResponse.HttpResponse = context.HttpResponse;
			describeReplicationJobsResponse.RequestId = context.StringValue("DescribeReplicationJobs.RequestId");
			describeReplicationJobsResponse.TotalCount = context.IntegerValue("DescribeReplicationJobs.TotalCount");
			describeReplicationJobsResponse.PageNumber = context.IntegerValue("DescribeReplicationJobs.PageNumber");
			describeReplicationJobsResponse.PageSize = context.IntegerValue("DescribeReplicationJobs.PageSize");

			List<DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob> describeReplicationJobsResponse_replicationJobs = new List<DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob>();
			for (int i = 0; i < context.Length("DescribeReplicationJobs.ReplicationJobs.Length"); i++) {
				DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob replicationJob = new DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob();
				replicationJob.JobId = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].JobId");
				replicationJob.SourceId = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].SourceId");
				replicationJob.Name = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].Name");
				replicationJob.Description = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].Description");
				replicationJob.RegionId = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].RegionId");
				replicationJob.TargetType = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].TargetType");
				replicationJob.ScheduledStartTime = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].ScheduledStartTime");
				replicationJob.ImageName = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].ImageName");
				replicationJob.InstanceId = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].InstanceId");
				replicationJob.ImageId = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].ImageId");
				replicationJob.Status = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].Status");
				replicationJob.BusinessStatus = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].BusinessStatus");
				replicationJob.ErrorCode = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].ErrorCode");
				replicationJob.Progress = context.FloatValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].Progress");
				replicationJob.CreationTime = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].CreationTime");
				replicationJob.ValidTime = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].ValidTime");
				replicationJob.StartTime = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].StartTime");
				replicationJob.EndTime = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].EndTime");
				replicationJob.NetMode = context.IntegerValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].NetMode");
				replicationJob.SystemDiskSize = context.IntegerValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].SystemDiskSize");
				replicationJob.VpcId = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].VpcId");
				replicationJob.VSwitchId = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].VSwitchId");
				replicationJob.TransitionInstanceId = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].TransitionInstanceId");
				replicationJob.StatusInfo = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].StatusInfo");
				replicationJob.ReplicationParameters = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].ReplicationParameters");
				replicationJob.RunOnce = context.BooleanValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].RunOnce");
				replicationJob.Frequency = context.IntegerValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].Frequency");
				replicationJob.MaxNumberOfImageToKeep = context.IntegerValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].MaxNumberOfImageToKeep");
				replicationJob.InstanceType = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].InstanceType");

				List<DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob.DescribeReplicationJobs_DataDisk> replicationJob_dataDisks = new List<DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob.DescribeReplicationJobs_DataDisk>();
				for (int j = 0; j < context.Length("DescribeReplicationJobs.ReplicationJobs["+ i +"].DataDisks.Length"); j++) {
					DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob.DescribeReplicationJobs_DataDisk dataDisk = new DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob.DescribeReplicationJobs_DataDisk();
					dataDisk.Size = context.IntegerValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].DataDisks["+ j +"].Size");
					dataDisk.Index = context.IntegerValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].DataDisks["+ j +"].Index");

					replicationJob_dataDisks.Add(dataDisk);
				}
				replicationJob.DataDisks = replicationJob_dataDisks;

				List<DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob.DescribeReplicationJobs_ReplicationJobRun> replicationJob_replicationJobRuns = new List<DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob.DescribeReplicationJobs_ReplicationJobRun>();
				for (int j = 0; j < context.Length("DescribeReplicationJobs.ReplicationJobs["+ i +"].ReplicationJobRuns.Length"); j++) {
					DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob.DescribeReplicationJobs_ReplicationJobRun replicationJobRun = new DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob.DescribeReplicationJobs_ReplicationJobRun();
					replicationJobRun.ImageId = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].ReplicationJobRuns["+ j +"].ImageId");
					replicationJobRun.Type = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].ReplicationJobRuns["+ j +"].Type");
					replicationJobRun.StartTime = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].ReplicationJobRuns["+ j +"].StartTime");
					replicationJobRun.EndTime = context.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].ReplicationJobRuns["+ j +"].EndTime");

					replicationJob_replicationJobRuns.Add(replicationJobRun);
				}
				replicationJob.ReplicationJobRuns = replicationJob_replicationJobRuns;

				describeReplicationJobsResponse_replicationJobs.Add(replicationJob);
			}
			describeReplicationJobsResponse.ReplicationJobs = describeReplicationJobsResponse_replicationJobs;
        
			return describeReplicationJobsResponse;
        }
    }
}
