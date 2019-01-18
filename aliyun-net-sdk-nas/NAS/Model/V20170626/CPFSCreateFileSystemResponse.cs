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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.NAS.Model.V20170626
{
	public class CPFSCreateFileSystemResponse : AcsResponse
	{

		private string requestId;

		private CPFSCreateFileSystem_FileSystem fileSystem;

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

		public CPFSCreateFileSystem_FileSystem FileSystem
		{
			get
			{
				return fileSystem;
			}
			set	
			{
				fileSystem = value;
			}
		}

		public class CPFSCreateFileSystem_FileSystem
		{

			private string fsId;

			private string fsDesc;

			private string fsSpec;

			private long? bandwidth;

			private long? capacity;

			private long? meteredSize;

			private string createTime;

			private string networkType;

			private string mountTargets;

			private string regionId;

			private string zoneId;

			private string vpcId;

			private string vSwitchId;

			public string FsId
			{
				get
				{
					return fsId;
				}
				set	
				{
					fsId = value;
				}
			}

			public string FsDesc
			{
				get
				{
					return fsDesc;
				}
				set	
				{
					fsDesc = value;
				}
			}

			public string FsSpec
			{
				get
				{
					return fsSpec;
				}
				set	
				{
					fsSpec = value;
				}
			}

			public long? Bandwidth
			{
				get
				{
					return bandwidth;
				}
				set	
				{
					bandwidth = value;
				}
			}

			public long? Capacity
			{
				get
				{
					return capacity;
				}
				set	
				{
					capacity = value;
				}
			}

			public long? MeteredSize
			{
				get
				{
					return meteredSize;
				}
				set	
				{
					meteredSize = value;
				}
			}

			public string CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public string NetworkType
			{
				get
				{
					return networkType;
				}
				set	
				{
					networkType = value;
				}
			}

			public string MountTargets
			{
				get
				{
					return mountTargets;
				}
				set	
				{
					mountTargets = value;
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

			public string ZoneId
			{
				get
				{
					return zoneId;
				}
				set	
				{
					zoneId = value;
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
		}
	}
}