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

namespace Aliyun.Acs.Ecs.Model.V20140526
{
	public class DescribeImagesResponse : AcsResponse
	{

		private string regionId;

		private int? totalCount;

		private int? pageNumber;

		private int? pageSize;

		private List<Image> images;

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

		public List<Image> Images
		{
			get
			{
				return images;
			}
			set	
			{
				images = value;
			}
		}

		public class Image{

			private string progress;

			private string imageId;

			private string imageName;

			private string imageVersion;

			private string description;

			private int? size;

			private string imageOwnerAlias;

			private string oSName;

			private Architecture_ architecture;

			private string status;

			private string productCode;

			private bool? isSubscribed;

			private string creationTime;

			private string isSelfShared;

			private string oSType;

			private string platform;

			private string usage;

			private bool? isCopied;

			private List<DiskDeviceMapping> diskDeviceMappings;

			private List<Tag> tags;

			public string Progress
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

			public string ImageVersion
			{
				get
				{
					return imageVersion;
				}
				set	
				{
					imageVersion = value;
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

			public string ImageOwnerAlias
			{
				get
				{
					return imageOwnerAlias;
				}
				set	
				{
					imageOwnerAlias = value;
				}
			}

			public string OSName
			{
				get
				{
					return oSName;
				}
				set	
				{
					oSName = value;
				}
			}

			public Architecture_ Architecture
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

			public string ProductCode
			{
				get
				{
					return productCode;
				}
				set	
				{
					productCode = value;
				}
			}

			public bool? IsSubscribed
			{
				get
				{
					return isSubscribed;
				}
				set	
				{
					isSubscribed = value;
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

			public string IsSelfShared
			{
				get
				{
					return isSelfShared;
				}
				set	
				{
					isSelfShared = value;
				}
			}

			public string OSType
			{
				get
				{
					return oSType;
				}
				set	
				{
					oSType = value;
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

			public string Usage
			{
				get
				{
					return usage;
				}
				set	
				{
					usage = value;
				}
			}

			public bool? IsCopied
			{
				get
				{
					return isCopied;
				}
				set	
				{
					isCopied = value;
				}
			}

			public List<DiskDeviceMapping> DiskDeviceMappings
			{
				get
				{
					return diskDeviceMappings;
				}
				set	
				{
					diskDeviceMappings = value;
				}
			}

			public List<Tag> Tags
			{
				get
				{
					return tags;
				}
				set	
				{
					tags = value;
				}
			}

			public enum Architecture_ {
			
					x86_64,
					i386,
			}

			public class DiskDeviceMapping{

				private string snapshotId;

				private string size;

				private string device;

				public string SnapshotId
				{
					get
					{
						return snapshotId;
					}
					set	
					{
						snapshotId = value;
					}
				}

				public string Size
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
			}

			public class Tag{

				private string tagKey;

				private string tagValue;

				public string TagKey
				{
					get
					{
						return tagKey;
					}
					set	
					{
						tagKey = value;
					}
				}

				public string TagValue
				{
					get
					{
						return tagValue;
					}
					set	
					{
						tagValue = value;
					}
				}
			}
		}
	}
}