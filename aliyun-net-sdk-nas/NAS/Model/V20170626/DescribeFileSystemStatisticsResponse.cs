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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.NAS.Model.V20170626
{
	public class DescribeFileSystemStatisticsResponse : AcsResponse
	{

		private int? totalCount;

		private string requestId;

		private int? pageSize;

		private int? pageNumber;

		private List<DescribeFileSystemStatistics_FileSystem> fileSystems;

		private List<DescribeFileSystemStatistics_FileSystemStatistic> fileSystemStatistics;

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

		public class DescribeFileSystemStatistics_FileSystem
		{

			private string status;

			private long? capacity;

			private long? meteredIASize;

			private string createTime;

			private string chargeType;

			private string storageType;

			private string regionId;

			private string fileSystemType;

			private string fileSystemId;

			private long? meteredSize;

			private string description;

			private string expiredTime;

			private string zoneId;

			private string protocolType;

			private List<DescribeFileSystemStatistics_Package> packages;

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

				private string startTime;

				private string expiredTime;

				private long? size;

				private string packageId;

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

		public class DescribeFileSystemStatistics_FileSystemStatistic
		{

			private string fileSystemType;

			private long? meteredSize;

			private int? expiringCount;

			private int? totalCount;

			private int? expiredCount;

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
		}
	}
}
