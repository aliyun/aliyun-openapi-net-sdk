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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.smc.Model.V20190601
{
	public class DescribeReplicationJobsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeReplicationJobs_ReplicationJob> replicationJobs;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public int? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public int? PageNumber
		{
			get
			{
				return pageNumber;
			}
			set	
			{
				pageNumber = value;
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
			}
		}

		public List<DescribeReplicationJobs_ReplicationJob> ReplicationJobs
		{
			get
			{
				return replicationJobs;
			}
			set	
			{
				replicationJobs = value;
			}
		}

		public class DescribeReplicationJobs_ReplicationJob
		{

			private string jobId;

			private string sourceId;

			private string name;

			private string description;

			private string regionId;

			private string targetType;

			private string scheduledStartTime;

			private string imageName;

			private string instanceId;

			private string imageId;

			private string status;

			private string businessStatus;

			private string errorCode;

			private float? progress;

			private string creationTime;

			private string validTime;

			private string startTime;

			private string endTime;

			private int? netMode;

			private int? systemDiskSize;

			private string vpcId;

			private string vSwitchId;

			private string transitionInstanceId;

			private string statusInfo;

			private string replicationParameters;

			private bool? runOnce;

			private int? frequency;

			private int? maxNumberOfImageToKeep;

			private string instanceType;

			private string launchTemplateId;

			private string launchTemplateVersion;

			private string instanceRamRole;

			private string containerNamespace;

			private string containerRepository;

			private string containerTag;

			private string licenseType;

			private List<DescribeReplicationJobs_SystemDiskPart> systemDiskParts;

			private List<DescribeReplicationJobs_DataDisk> dataDisks;

			private List<DescribeReplicationJobs_ReplicationJobRun> replicationJobRuns;

			public string JobId
			{
				get
				{
					return jobId;
				}
				set	
				{
					jobId = value;
				}
			}

			public string SourceId
			{
				get
				{
					return sourceId;
				}
				set	
				{
					sourceId = value;
				}
			}

			public string Name
			{
				get
				{
					return name;
				}
				set	
				{
					name = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string RegionId
			{
				get
				{
					return regionId;
				}
				set	
				{
					regionId = value;
				}
			}

			public string TargetType
			{
				get
				{
					return targetType;
				}
				set	
				{
					targetType = value;
				}
			}

			public string ScheduledStartTime
			{
				get
				{
					return scheduledStartTime;
				}
				set	
				{
					scheduledStartTime = value;
				}
			}

			public string ImageName
			{
				get
				{
					return imageName;
				}
				set	
				{
					imageName = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public string ImageId
			{
				get
				{
					return imageId;
				}
				set	
				{
					imageId = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public string BusinessStatus
			{
				get
				{
					return businessStatus;
				}
				set	
				{
					businessStatus = value;
				}
			}

			public string ErrorCode
			{
				get
				{
					return errorCode;
				}
				set	
				{
					errorCode = value;
				}
			}

			public float? Progress
			{
				get
				{
					return progress;
				}
				set	
				{
					progress = value;
				}
			}

			public string CreationTime
			{
				get
				{
					return creationTime;
				}
				set	
				{
					creationTime = value;
				}
			}

			public string ValidTime
			{
				get
				{
					return validTime;
				}
				set	
				{
					validTime = value;
				}
			}

			public string StartTime
			{
				get
				{
					return startTime;
				}
				set	
				{
					startTime = value;
				}
			}

			public string EndTime
			{
				get
				{
					return endTime;
				}
				set	
				{
					endTime = value;
				}
			}

			public int? NetMode
			{
				get
				{
					return netMode;
				}
				set	
				{
					netMode = value;
				}
			}

			public int? SystemDiskSize
			{
				get
				{
					return systemDiskSize;
				}
				set	
				{
					systemDiskSize = value;
				}
			}

			public string VpcId
			{
				get
				{
					return vpcId;
				}
				set	
				{
					vpcId = value;
				}
			}

			public string VSwitchId
			{
				get
				{
					return vSwitchId;
				}
				set	
				{
					vSwitchId = value;
				}
			}

			public string TransitionInstanceId
			{
				get
				{
					return transitionInstanceId;
				}
				set	
				{
					transitionInstanceId = value;
				}
			}

			public string StatusInfo
			{
				get
				{
					return statusInfo;
				}
				set	
				{
					statusInfo = value;
				}
			}

			public string ReplicationParameters
			{
				get
				{
					return replicationParameters;
				}
				set	
				{
					replicationParameters = value;
				}
			}

			public bool? RunOnce
			{
				get
				{
					return runOnce;
				}
				set	
				{
					runOnce = value;
				}
			}

			public int? Frequency
			{
				get
				{
					return frequency;
				}
				set	
				{
					frequency = value;
				}
			}

			public int? MaxNumberOfImageToKeep
			{
				get
				{
					return maxNumberOfImageToKeep;
				}
				set	
				{
					maxNumberOfImageToKeep = value;
				}
			}

			public string InstanceType
			{
				get
				{
					return instanceType;
				}
				set	
				{
					instanceType = value;
				}
			}

			public string LaunchTemplateId
			{
				get
				{
					return launchTemplateId;
				}
				set	
				{
					launchTemplateId = value;
				}
			}

			public string LaunchTemplateVersion
			{
				get
				{
					return launchTemplateVersion;
				}
				set	
				{
					launchTemplateVersion = value;
				}
			}

			public string InstanceRamRole
			{
				get
				{
					return instanceRamRole;
				}
				set	
				{
					instanceRamRole = value;
				}
			}

			public string ContainerNamespace
			{
				get
				{
					return containerNamespace;
				}
				set	
				{
					containerNamespace = value;
				}
			}

			public string ContainerRepository
			{
				get
				{
					return containerRepository;
				}
				set	
				{
					containerRepository = value;
				}
			}

			public string ContainerTag
			{
				get
				{
					return containerTag;
				}
				set	
				{
					containerTag = value;
				}
			}

			public string LicenseType
			{
				get
				{
					return licenseType;
				}
				set	
				{
					licenseType = value;
				}
			}

			public List<DescribeReplicationJobs_SystemDiskPart> SystemDiskParts
			{
				get
				{
					return systemDiskParts;
				}
				set	
				{
					systemDiskParts = value;
				}
			}

			public List<DescribeReplicationJobs_DataDisk> DataDisks
			{
				get
				{
					return dataDisks;
				}
				set	
				{
					dataDisks = value;
				}
			}

			public List<DescribeReplicationJobs_ReplicationJobRun> ReplicationJobRuns
			{
				get
				{
					return replicationJobRuns;
				}
				set	
				{
					replicationJobRuns = value;
				}
			}

			public class DescribeReplicationJobs_SystemDiskPart
			{

				private string device;

				private long? sizeBytes;

				private bool? block;

				public string Device
				{
					get
					{
						return device;
					}
					set	
					{
						device = value;
					}
				}

				public long? SizeBytes
				{
					get
					{
						return sizeBytes;
					}
					set	
					{
						sizeBytes = value;
					}
				}

				public bool? Block
				{
					get
					{
						return block;
					}
					set	
					{
						block = value;
					}
				}
			}

			public class DescribeReplicationJobs_DataDisk
			{

				private int? size;

				private int? index;

				private List<DescribeReplicationJobs_Part> parts;

				public int? Size
				{
					get
					{
						return size;
					}
					set	
					{
						size = value;
					}
				}

				public int? Index
				{
					get
					{
						return index;
					}
					set	
					{
						index = value;
					}
				}

				public List<DescribeReplicationJobs_Part> Parts
				{
					get
					{
						return parts;
					}
					set	
					{
						parts = value;
					}
				}

				public class DescribeReplicationJobs_Part
				{

					private string device;

					private long? sizeBytes;

					private bool? block;

					public string Device
					{
						get
						{
							return device;
						}
						set	
						{
							device = value;
						}
					}

					public long? SizeBytes
					{
						get
						{
							return sizeBytes;
						}
						set	
						{
							sizeBytes = value;
						}
					}

					public bool? Block
					{
						get
						{
							return block;
						}
						set	
						{
							block = value;
						}
					}
				}
			}

			public class DescribeReplicationJobs_ReplicationJobRun
			{

				private string imageId;

				private string type;

				private string startTime;

				private string endTime;

				public string ImageId
				{
					get
					{
						return imageId;
					}
					set	
					{
						imageId = value;
					}
				}

				public string Type
				{
					get
					{
						return type;
					}
					set	
					{
						type = value;
					}
				}

				public string StartTime
				{
					get
					{
						return startTime;
					}
					set	
					{
						startTime = value;
					}
				}

				public string EndTime
				{
					get
					{
						return endTime;
					}
					set	
					{
						endTime = value;
					}
				}
			}
		}
	}
}
