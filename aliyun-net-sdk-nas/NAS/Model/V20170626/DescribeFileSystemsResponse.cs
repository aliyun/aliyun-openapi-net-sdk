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
	public class DescribeFileSystemsResponse : AcsResponse
	{

		private string requestId;

		private int? totalCount;

		private int? pageSize;

		private int? pageNumber;

		private List<DescribeFileSystems_FileSystem> fileSystems;

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

		public List<DescribeFileSystems_FileSystem> FileSystems
		{
			get
			{
				return fileSystems;
			}
			set	
			{
				fileSystems = value;
			}
		}

		public class DescribeFileSystems_FileSystem
		{

			private string fileSystemId;

			private string destription;

			private string createTime;

			private string regionId;

			private string protocolType;

			private string storageType;

			private long? meteredSize;

			private List<DescribeFileSystems_MountTarget> mountTargets;

			private List<DescribeFileSystems_Package> packages;

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

			public List<DescribeFileSystems_MountTarget> MountTargets
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

			public List<DescribeFileSystems_Package> Packages
			{
				get
				{
					return packages;
				}
				set	
				{
					packages = value;
				}
			}

			public class DescribeFileSystems_MountTarget
			{

				private string mountTargetDomain;

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
			}

			public class DescribeFileSystems_Package
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
		}
	}
}