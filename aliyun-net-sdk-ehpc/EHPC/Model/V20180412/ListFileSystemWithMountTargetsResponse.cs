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

namespace Aliyun.Acs.EHPC.Model.V20180412
{
	public class ListFileSystemWithMountTargetsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<ListFileSystemWithMountTargets_FileSystems> fileSystemList;

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

		public List<ListFileSystemWithMountTargets_FileSystems> FileSystemList
		{
			get
			{
				return fileSystemList;
			}
			set	
			{
				fileSystemList = value;
			}
		}

		public class ListFileSystemWithMountTargets_FileSystems
		{

			private string regionId;

			private string fileSystemId;

			private string fileSystemType;

			private string protocolType;

			private string createTime;

			private string destription;

			private string storageType;

			private int? meteredSize;

			private int? capacity;

			private int? encryptType;

			private int? bandWidth;

			private string status;

			private List<ListFileSystemWithMountTargets_Packages> packageList;

			private List<ListFileSystemWithMountTargets_MountTargets> mountTargetList;

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

			public string FileSystemId
			{
				get
				{
					return fileSystemId;
				}
				set	
				{
					fileSystemId = value;
				}
			}

			public string FileSystemType
			{
				get
				{
					return fileSystemType;
				}
				set	
				{
					fileSystemType = value;
				}
			}

			public string ProtocolType
			{
				get
				{
					return protocolType;
				}
				set	
				{
					protocolType = value;
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

			public string Destription
			{
				get
				{
					return destription;
				}
				set	
				{
					destription = value;
				}
			}

			public string StorageType
			{
				get
				{
					return storageType;
				}
				set	
				{
					storageType = value;
				}
			}

			public int? MeteredSize
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

			public int? Capacity
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

			public int? EncryptType
			{
				get
				{
					return encryptType;
				}
				set	
				{
					encryptType = value;
				}
			}

			public int? BandWidth
			{
				get
				{
					return bandWidth;
				}
				set	
				{
					bandWidth = value;
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

			public List<ListFileSystemWithMountTargets_Packages> PackageList
			{
				get
				{
					return packageList;
				}
				set	
				{
					packageList = value;
				}
			}

			public List<ListFileSystemWithMountTargets_MountTargets> MountTargetList
			{
				get
				{
					return mountTargetList;
				}
				set	
				{
					mountTargetList = value;
				}
			}

			public class ListFileSystemWithMountTargets_Packages
			{

				private string packageId;

				public string PackageId
				{
					get
					{
						return packageId;
					}
					set	
					{
						packageId = value;
					}
				}
			}

			public class ListFileSystemWithMountTargets_MountTargets
			{

				private string mountTargetDomain;

				private string status;

				private string networkType;

				private string vswId;

				private string vpcId;

				private string accessGroup;

				public string MountTargetDomain
				{
					get
					{
						return mountTargetDomain;
					}
					set	
					{
						mountTargetDomain = value;
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

				public string VswId
				{
					get
					{
						return vswId;
					}
					set	
					{
						vswId = value;
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

				public string AccessGroup
				{
					get
					{
						return accessGroup;
					}
					set	
					{
						accessGroup = value;
					}
				}
			}
		}
	}
}
