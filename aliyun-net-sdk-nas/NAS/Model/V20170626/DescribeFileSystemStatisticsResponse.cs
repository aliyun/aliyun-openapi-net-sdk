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

namespace Aliyun.Acs.NAS.Model.V20170626
{
	public class DescribeFileSystemStatisticsResponse : AcsResponse
	{

		private string requestId;

		private int? pageSize;

		private int? pageNumber;

		private int? totalCount;

		private List<DescribeFileSystemStatistics_FileSystemStatistic> fileSystemStatistics;

		private List<DescribeFileSystemStatistics_FileSystem> fileSystems;

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

		public List<DescribeFileSystemStatistics_FileSystemStatistic> FileSystemStatistics
		{
			get
			{
				return fileSystemStatistics;
			}
			set	
			{
				fileSystemStatistics = value;
			}
		}

		public List<DescribeFileSystemStatistics_FileSystem> FileSystems
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

		public class DescribeFileSystemStatistics_FileSystemStatistic
		{

			private string fileSystemType;

			private int? totalCount;

			private long? meteredSize;

			private int? expiredCount;

			private int? expiringCount;

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

			public int? ExpiredCount
			{
				get
				{
					return expiredCount;
				}
				set	
				{
					expiredCount = value;
				}
			}

			public int? ExpiringCount
			{
				get
				{
					return expiringCount;
				}
				set	
				{
					expiringCount = value;
				}
			}
		}

		public class DescribeFileSystemStatistics_FileSystem
		{

			private string fileSystemId;

			private string description;

			private string createTime;

			private string expiredTime;

			private string regionId;

			private string zoneId;

			private string protocolType;

			private string storageType;

			private string fileSystemType;

			private long? meteredSize;

			private long? meteredIASize;

			private long? capacity;

			private string chargeType;

			private string status;

			private List<DescribeFileSystemStatistics_Package> packages;

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

			public string ExpiredTime
			{
				get
				{
					return expiredTime;
				}
				set	
				{
					expiredTime = value;
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

			public long? MeteredIASize
			{
				get
				{
					return meteredIASize;
				}
				set	
				{
					meteredIASize = value;
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

			public string ChargeType
			{
				get
				{
					return chargeType;
				}
				set	
				{
					chargeType = value;
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

			public List<DescribeFileSystemStatistics_Package> Packages
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

			public class DescribeFileSystemStatistics_Package
			{

				private string packageId;

				private long? size;

				private string startTime;

				private string expiredTime;

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

				public long? Size
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

				public string ExpiredTime
				{
					get
					{
						return expiredTime;
					}
					set	
					{
						expiredTime = value;
					}
				}
			}
		}
	}
}
