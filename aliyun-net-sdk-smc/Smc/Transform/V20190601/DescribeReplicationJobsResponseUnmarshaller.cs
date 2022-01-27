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
        public static DescribeReplicationJobsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeReplicationJobsResponse describeReplicationJobsResponse = new DescribeReplicationJobsResponse();

			describeReplicationJobsResponse.HttpResponse = _ctx.HttpResponse;
			describeReplicationJobsResponse.RequestId = _ctx.StringValue("DescribeReplicationJobs.RequestId");
			describeReplicationJobsResponse.TotalCount = _ctx.IntegerValue("DescribeReplicationJobs.TotalCount");
			describeReplicationJobsResponse.PageNumber = _ctx.IntegerValue("DescribeReplicationJobs.PageNumber");
			describeReplicationJobsResponse.PageSize = _ctx.IntegerValue("DescribeReplicationJobs.PageSize");

			List<DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob> describeReplicationJobsResponse_replicationJobs = new List<DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob>();
			for (int i = 0; i < _ctx.Length("DescribeReplicationJobs.ReplicationJobs.Length"); i++) {
				DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob replicationJob = new DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob();
				replicationJob.JobId = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].JobId");
				replicationJob.SourceId = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].SourceId");
				replicationJob.Name = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].Name");
				replicationJob.Description = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].Description");
				replicationJob.RegionId = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].RegionId");
				replicationJob.TargetType = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].TargetType");
				replicationJob.ScheduledStartTime = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].ScheduledStartTime");
				replicationJob.ImageName = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].ImageName");
				replicationJob.InstanceId = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].InstanceId");
				replicationJob.ImageId = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].ImageId");
				replicationJob.Status = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].Status");
				replicationJob.BusinessStatus = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].BusinessStatus");
				replicationJob.ErrorCode = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].ErrorCode");
				replicationJob.Progress = _ctx.FloatValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].Progress");
				replicationJob.CreationTime = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].CreationTime");
				replicationJob.ValidTime = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].ValidTime");
				replicationJob.StartTime = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].StartTime");
				replicationJob.EndTime = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].EndTime");
				replicationJob.NetMode = _ctx.IntegerValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].NetMode");
				replicationJob.SystemDiskSize = _ctx.IntegerValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].SystemDiskSize");
				replicationJob.VpcId = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].VpcId");
				replicationJob.VSwitchId = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].VSwitchId");
				replicationJob.TransitionInstanceId = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].TransitionInstanceId");
				replicationJob.StatusInfo = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].StatusInfo");
				replicationJob.ReplicationParameters = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].ReplicationParameters");
				replicationJob.RunOnce = _ctx.BooleanValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].RunOnce");
				replicationJob.Frequency = _ctx.IntegerValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].Frequency");
				replicationJob.MaxNumberOfImageToKeep = _ctx.IntegerValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].MaxNumberOfImageToKeep");
				replicationJob.InstanceType = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].InstanceType");
				replicationJob.LaunchTemplateId = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].LaunchTemplateId");
				replicationJob.LaunchTemplateVersion = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].LaunchTemplateVersion");
				replicationJob.InstanceRamRole = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].InstanceRamRole");
				replicationJob.ContainerNamespace = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].ContainerNamespace");
				replicationJob.ContainerRepository = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].ContainerRepository");
				replicationJob.ContainerTag = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].ContainerTag");
				replicationJob.LicenseType = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].LicenseType");

				List<DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob.DescribeReplicationJobs_SystemDiskPart> replicationJob_systemDiskParts = new List<DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob.DescribeReplicationJobs_SystemDiskPart>();
				for (int j = 0; j < _ctx.Length("DescribeReplicationJobs.ReplicationJobs["+ i +"].SystemDiskParts.Length"); j++) {
					DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob.DescribeReplicationJobs_SystemDiskPart systemDiskPart = new DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob.DescribeReplicationJobs_SystemDiskPart();
					systemDiskPart.Device = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].SystemDiskParts["+ j +"].Device");
					systemDiskPart.SizeBytes = _ctx.LongValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].SystemDiskParts["+ j +"].SizeBytes");
					systemDiskPart.Block = _ctx.BooleanValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].SystemDiskParts["+ j +"].Block");

					replicationJob_systemDiskParts.Add(systemDiskPart);
				}
				replicationJob.SystemDiskParts = replicationJob_systemDiskParts;

				List<DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob.DescribeReplicationJobs_DataDisk> replicationJob_dataDisks = new List<DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob.DescribeReplicationJobs_DataDisk>();
				for (int j = 0; j < _ctx.Length("DescribeReplicationJobs.ReplicationJobs["+ i +"].DataDisks.Length"); j++) {
					DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob.DescribeReplicationJobs_DataDisk dataDisk = new DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob.DescribeReplicationJobs_DataDisk();
					dataDisk.Size = _ctx.IntegerValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].DataDisks["+ j +"].Size");
					dataDisk.Index = _ctx.IntegerValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].DataDisks["+ j +"].Index");

					List<DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob.DescribeReplicationJobs_DataDisk.DescribeReplicationJobs_Part> dataDisk_parts = new List<DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob.DescribeReplicationJobs_DataDisk.DescribeReplicationJobs_Part>();
					for (int k = 0; k < _ctx.Length("DescribeReplicationJobs.ReplicationJobs["+ i +"].DataDisks["+ j +"].Parts.Length"); k++) {
						DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob.DescribeReplicationJobs_DataDisk.DescribeReplicationJobs_Part part = new DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob.DescribeReplicationJobs_DataDisk.DescribeReplicationJobs_Part();
						part.Device = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].DataDisks["+ j +"].Parts["+ k +"].Device");
						part.SizeBytes = _ctx.LongValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].DataDisks["+ j +"].Parts["+ k +"].SizeBytes");
						part.Block = _ctx.BooleanValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].DataDisks["+ j +"].Parts["+ k +"].Block");

						dataDisk_parts.Add(part);
					}
					dataDisk.Parts = dataDisk_parts;

					replicationJob_dataDisks.Add(dataDisk);
				}
				replicationJob.DataDisks = replicationJob_dataDisks;

				List<DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob.DescribeReplicationJobs_ReplicationJobRun> replicationJob_replicationJobRuns = new List<DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob.DescribeReplicationJobs_ReplicationJobRun>();
				for (int j = 0; j < _ctx.Length("DescribeReplicationJobs.ReplicationJobs["+ i +"].ReplicationJobRuns.Length"); j++) {
					DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob.DescribeReplicationJobs_ReplicationJobRun replicationJobRun = new DescribeReplicationJobsResponse.DescribeReplicationJobs_ReplicationJob.DescribeReplicationJobs_ReplicationJobRun();
					replicationJobRun.ImageId = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].ReplicationJobRuns["+ j +"].ImageId");
					replicationJobRun.Type = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].ReplicationJobRuns["+ j +"].Type");
					replicationJobRun.StartTime = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].ReplicationJobRuns["+ j +"].StartTime");
					replicationJobRun.EndTime = _ctx.StringValue("DescribeReplicationJobs.ReplicationJobs["+ i +"].ReplicationJobRuns["+ j +"].EndTime");

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
