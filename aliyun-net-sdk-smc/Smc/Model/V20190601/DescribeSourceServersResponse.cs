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
	public class DescribeSourceServersResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<DescribeSourceServers_SourceServer> sourceServers;

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

		public List<DescribeSourceServers_SourceServer> SourceServers
		{
			get
			{
				return sourceServers;
			}
			set	
			{
				sourceServers = value;
			}
		}

		public class DescribeSourceServers_SourceServer
		{

			private string sourceId;

			private string jobId;

			private string agentVersion;

			private string name;

			private string description;

			private int? kernelLevel;

			private string platform;

			private string architecture;

			private int? systemDiskSize;

			private string replicationDriver;

			private string systemInfo;

			private string creationTime;

			private string state;

			private string errorCode;

			private string statusInfo;

			private int? heartbeatRate;

			private List<DescribeSourceServers_DataDisk> dataDisks;

			private List<DescribeSourceServers_SystemDiskPart> systemDiskParts;

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

			public string AgentVersion
			{
				get
				{
					return agentVersion;
				}
				set	
				{
					agentVersion = value;
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

			public int? KernelLevel
			{
				get
				{
					return kernelLevel;
				}
				set	
				{
					kernelLevel = value;
				}
			}

			public string Platform
			{
				get
				{
					return platform;
				}
				set	
				{
					platform = value;
				}
			}

			public string Architecture
			{
				get
				{
					return architecture;
				}
				set	
				{
					architecture = value;
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

			public string ReplicationDriver
			{
				get
				{
					return replicationDriver;
				}
				set	
				{
					replicationDriver = value;
				}
			}

			public string SystemInfo
			{
				get
				{
					return systemInfo;
				}
				set	
				{
					systemInfo = value;
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

			public string State
			{
				get
				{
					return state;
				}
				set	
				{
					state = value;
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

			public int? HeartbeatRate
			{
				get
				{
					return heartbeatRate;
				}
				set	
				{
					heartbeatRate = value;
				}
			}

			public List<DescribeSourceServers_DataDisk> DataDisks
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

			public List<DescribeSourceServers_SystemDiskPart> SystemDiskParts
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

			public class DescribeSourceServers_DataDisk
			{

				private int? index;

				private int? size;

				private string path;

				private List<DescribeSourceServers_Part> parts;

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

				public string Path
				{
					get
					{
						return path;
					}
					set	
					{
						path = value;
					}
				}

				public List<DescribeSourceServers_Part> Parts
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

				public class DescribeSourceServers_Part
				{

					private string path;

					private string device;

					private long? sizeBytes;

					private bool? need;

					private bool? canBlock;

					public string Path
					{
						get
						{
							return path;
						}
						set	
						{
							path = value;
						}
					}

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

					public bool? Need
					{
						get
						{
							return need;
						}
						set	
						{
							need = value;
						}
					}

					public bool? CanBlock
					{
						get
						{
							return canBlock;
						}
						set	
						{
							canBlock = value;
						}
					}
				}
			}

			public class DescribeSourceServers_SystemDiskPart
			{

				private string path;

				private string device;

				private long? sizeBytes;

				private bool? need;

				private bool? canBlock;

				public string Path
				{
					get
					{
						return path;
					}
					set	
					{
						path = value;
					}
				}

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

				public bool? Need
				{
					get
					{
						return need;
					}
					set	
					{
						need = value;
					}
				}

				public bool? CanBlock
				{
					get
					{
						return canBlock;
					}
					set	
					{
						canBlock = value;
					}
				}
			}
		}
	}
}
